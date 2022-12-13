using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MediaPlayer.Components;
using MediaPlayer.Structures;
using MediaPlayer.Handlers;
using MediaPlayer.Properties;

namespace MediaPlayer
{
    public partial class MediaPlayer : Form
    {
        private SongHandler songHandler;
        private SongComponentHandler songComponentHandler;

        private bool isPlayListOpen = true;
        private bool isPlaying;
        private bool isMute;
        private bool isNext;
        private bool isLoop;
        private bool isRandom;
        private int timeSleep;
        public int currentSongIndexPlay;
        private Random rand;
        public MediaPlayer()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            songHandler = new SongHandler();
            songComponentHandler = new SongComponentHandler(flowpnPlaylist, this);

            isPlayListOpen = true;
            isPlaying = false;
            isMute = false;
            isNext = false;
            isLoop = false;
            isRandom = false;
            timeSleep = 0;
            currentSongIndexPlay = default;
            rand = new Random();

            btnPlay.Image = Resources.icon_play;
            btnLoop.Image = Resources.icon_notloop;
            btnRandom.Image = Resources.icon_notrandom;

            sliderDuration.Value = 0;
            sliderVolume.Value = 50;
            songHandler.wmPlayer.settings.volume = 50;

            AlignmentAllCenter();

            Timer tmr = new Timer();
            tmr.Interval = 1000;
            tmr.Start();
            tmr.Tick += tmr_Tick;
        }
        private void tmr_Tick(object sender, EventArgs e)
        {
            if (songHandler.currentSong == null)
                return;

            //Duration real time và thanh duration
            if (isPlaying == true)
            {
                lblDurationRealTime.Text = TimeSpan.FromSeconds(songHandler.wmPlayer.controls.currentPosition).ToString("mm':'ss");
                sliderDuration.Value = (int)songHandler.wmPlayer.controls.currentPosition;
            }

            //Check hết bài nhạc, next song
            if (songHandler.wmPlayer.controls.currentPosition > songHandler.currentSong.duration.TotalSeconds - 1)
            {
                isNext = true;
                isPlaying = false;
                btnPlay.Image = Resources.icon_play;
                sliderDuration.Value = 0;
                lblDurationRealTime.Text = "00:00";

                songComponentHandler.ResetAll();

                AlignmentAllCenter();
                ChangeColorPanel();

                songHandler.currentPosition = 0;
            }

            if (isNext == true)
            {
                timeSleep++;
                if (timeSleep == 2)
                {
                    if (isLoop == false && isRandom == false)
                        this.NextSong();

                    if (isLoop == false && isRandom == true)
                        this.PlayIndex(rand.Next(songHandler.totalSong - 1));

                    if (isLoop == true && isRandom == false)
                        this.PlaySong();

                    timeSleep = 0;
                    isNext = false;
                }
            }

        }
        private void PlaySong()
        {
            if (songHandler.currentSong == null && songHandler.currentNodeSong == null && songHandler.totalSong == 0)
            {
                DialogResult = MessageBox.Show("Bạn chưa thêm bản nhạc nào.", "Vui lòng thêm nhạc.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (isPlaying == false)
            {
                btnPlay.Image = Resources.icon_pause;

                isPlaying = true;
                songHandler.Play();
                songComponentHandler.ResetAll();
                songComponentHandler.SetPlay(currentSongIndexPlay);

                ChangeColorPanel();
                _Update();
            }
            else
            {
                btnPlay.Image = Resources.icon_play;
                songHandler.Pause();
                isPlaying = false;
                ChangeColorPanel();
                _Update();
            }
        }

        private int RandNextSongIndex()
        {
            int randomNextSong = rand.Next(0, songHandler.totalSong);

            if (randomNextSong == currentSongIndexPlay) {
                return RandNextSongIndex();
            } else
            {
                return randomNextSong;
            }
        }

        private void NextSong()
        {
            if (songHandler.currentNodeSong == null)
            {
                return;
            }

            if (songHandler.currentNodeSong.GetNodeNext() == null)
            {
                return;
            }

            isPlaying = true;
            btnPlay.Image = Resources.icon_pause;

            if (isRandom)
            {
                currentSongIndexPlay = RandNextSongIndex();
                songHandler.PlayIndex(currentSongIndexPlay);
            }
            else
            {
                ++currentSongIndexPlay;
                songHandler.NextSong();
            }

            songComponentHandler.ResetAll();
            songComponentHandler.SetPlay(currentSongIndexPlay);

            ChangeColorPanel();
            _Update();
        }
        public void Remove(int index)
        {
            if (currentSongIndexPlay == index)
            {
                MessageBox.Show("Bài nhạc đang phát, bạn không thể xóa", "Lỗi khi xoá bài hát", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            songHandler.RemoveSong(index);
            songComponentHandler.RemoveSong(index);

            // nếu index current < index remove -> giữ nguyên
            // nếu remove > current -> giảm 1
            if (currentSongIndexPlay > index)
                currentSongIndexPlay--;

            songComponentHandler.SetPlay(currentSongIndexPlay);
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Giảng viên hướng dẫn: Thầy Đặng Ngọc Hoàng Thành \nThành viên nhóm: \nĐào Trung Quân\nTrương Nhựt Huy\nBùi Minh Tân \nHuỳnh Phương Thanh Phát", "Projects cuối kì", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPlayList_Click(object sender, EventArgs e)
        {
            //Open Play list
            if (isPlayListOpen == false)
            {
                pnPlaylist.Size = new Size(440, pnPlaylist.Size.Height);
                pnPlaylist.Location = new Point(26, 60);
                isPlayListOpen = true;
            }
            //Close Play List
            else
            {
                pnPlaylist.Size = new Size(70, pnPlaylist.Size.Height);
                pnPlaylist.Location = new Point(410, 60);
                isPlayListOpen = false;
            }
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "File nhạc (*.mp3)|*.mp3;";

            if (open.ShowDialog() != DialogResult.OK)
                return;
            if (songHandler.AddSong(open.FileName) == false)
                return;

            songComponentHandler.AddSong(songHandler.musicList.GetLast());

            //cập nhật
            isPlaying = true;
            currentSongIndexPlay = songHandler.totalSong - 1;
            btnPlay.Image = Resources.icon_pause;
            ChangeColorPanel();

            _Update();
        }

        private void ChangeColorPanel()
        {
            //Status Playing: Chuyển sang màu xanh lá
            if (isPlaying == true)
            {
                pnMain.BackColor = Color.FromArgb(183, 252, 199);
                pnMain.BackColor = Color.FromArgb(183, 252, 199);
            }
            //Status Pase/Stop: Chuyển sang màu xanh dương 
            else
            {
                pnMain.BackColor = Color.FromArgb(222, 243, 252);
                pnMain.BackColor = Color.FromArgb(222, 243, 252);
            }
        }
        private void _Update()
        {
            //cập nhật thông tin bản nhạc
            string title = songHandler.currentSong.title;
            string duration = songHandler.currentSong.duration.ToString("mm':'ss");
            Image image = songHandler.currentSong.image;

            lblTitle.Text = title;
            lblDurationTotal.Text = duration;
            sliderDuration.Maximum = (int)songHandler.currentSong.duration.TotalSeconds;

            //Cập nhật hình ảnh
            int ratio = image.Height / ptbImage.Height;
            image = resizeImage(image, new Size(image.Width / ratio, image.Height / ratio));
            ptbImage.SizeMode = PictureBoxSizeMode.CenterImage;
            ptbImage.Image = image;

            //Căn giữa
            AlignmentAllCenter();
        }
        private void AlignmentAllCenter()
        {
            lblTitle.Location = new Point(pnMain.Width / 2 - lblTitle.Width / 2, lblTitle.Location.Y);
        }
        public static Image resizeImage(Image imgToResize, Size size)
        {
            return (Image)(new Bitmap(imgToResize, size));
        }

        public void PlayIndex(int index)
        {
            btnPlay.Image = Resources.icon_pause;

            isPlaying = true;
            currentSongIndexPlay = index;

            songHandler.PlayIndex(index);
            songComponentHandler.ResetAll();
            songComponentHandler.SetPlay(index);

            ChangeColorPanel();
            _Update();
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (isRandom == false)
            {
                // Chuyển sang random bài hát
                btnRandom.Image = Resources.icon_random;
                isLoop = false;
                btnLoop.Image = Resources.icon_notloop;
                isRandom = true;
            }
            else
            {
                // Tắt random
                btnRandom.Image = Resources.icon_notrandom;
                isRandom = false;
            }
        }

        private void sliderVolume_ValueChanged(object sender, Utilities.BunifuSlider.BunifuVScrollBar.ValueChangedEventArgs e)
        {
            if (sliderVolume.Value > 0)
            {
                btnVolume.Image = Resources.icon_volume;
            } else
            {
                btnVolume.Image = Resources.icon_mute;
            }
            songHandler.wmPlayer.settings.volume = sliderVolume.Value;
        }

        private void sliderDuration_MouseCaptureChanged(object sender, Utilities.BunifuSlider.BunifuHScrollBar.MouseCaptureChangedEventArgs e)
        {
            songHandler.wmPlayer.controls.currentPosition = sliderDuration.Value;
        }

        private void btnVolume_Click(object sender, EventArgs e)
        {

            if (isMute == true)
            {
                btnVolume.Image = Resources.icon_volume;
                songHandler.wmPlayer.settings.mute = false;
                isMute = false;
            }
            else
            {
                btnVolume.Image = Resources.icon_mute;
                songHandler.wmPlayer.settings.mute = true;
                isMute = true;
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.PlaySong();
        }

        private void btnLoop_Click(object sender, EventArgs e)
        {
            if (isLoop == false)
            {
                btnLoop.Image = Resources.icon_loop;
                isRandom = false;
                btnRandom.Image = Resources.icon_notrandom;
                isLoop = true;
            }
            //mode not loop
            else
            {
                btnLoop.Image = Resources.icon_notloop;
                isLoop = false;
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            this.PrevSong();
        }
        private void PrevSong()
        {
            // Nếu không có bài nào thì return kết thúc hàm
            if (songHandler.currentNodeSong == null || currentSongIndexPlay == 0)
            {
                return;
            }

            if (songHandler.currentNodeSong.GetNodePrev() == null)
            {
                return;
            }

            isPlaying = true;
            btnPlay.Image = Resources.icon_pause;

            if (isRandom)
            {
                currentSongIndexPlay = RandNextSongIndex();
                songHandler.PlayIndex(currentSongIndexPlay);
            } else
            {
                --currentSongIndexPlay;
                songHandler.PrevSong();
            }

            songComponentHandler.ResetAll();
            songComponentHandler.SetPlay(currentSongIndexPlay);

            ChangeColorPanel();
            _Update();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.NextSong();
        }
    }
}

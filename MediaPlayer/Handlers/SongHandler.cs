using System;
using MediaPlayer.Structures;
using MediaPlayer.Objects;
using System.IO;
using NAudio.Wave;
using System.Drawing;
using MediaPlayer.Properties;
using System.Windows.Forms;
using WMPLib;

namespace MediaPlayer.Handlers
{
    public class SongHandler
    {
        public LinkedList<Song> musicList = new LinkedList<Song>();

        public Node<Song> currentNodeSong;
        public Song currentSong;
        public double currentPosition;
        public int totalSong;

        public WindowsMediaPlayer wmPlayer;
        private TagLib.File tagMedia;
        private MemoryStream ms;
        private Mp3FileReader rmp3;
        
        public SongHandler()
        {
            wmPlayer = new WMPLib.WindowsMediaPlayer();

            currentNodeSong = null;
            currentSong = null;
            currentPosition = default;

            tagMedia = null;
            ms = null;
            rmp3 = null;
        }

        public void Play()
        {
            if (currentNodeSong == null || currentSong == null || totalSong == 0)
                return;

            wmPlayer.URL = currentSong.filePath;
            if (currentPosition != 0)
            {
                wmPlayer.controls.currentPosition = currentPosition;
            }

            wmPlayer.controls.play();
        }

        public bool AddSong(string filePath)
        {
            tagMedia = null;
            ms = null;
            rmp3 = null;

            tagMedia = TagLib.File.Create(filePath);
            try
            {
                ms = new MemoryStream(tagMedia.Tag.Pictures[0].Data.Data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            try
            {
                rmp3 = new Mp3FileReader(filePath);
            }
            catch (Exception ex)
            {
                Console.Write(ex);
                MessageBox.Show("Có lỗi khi thêm bài hát, vui lòng thử lại !", "Thêm thất bại", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            string _filePath = filePath;
            string title = tagMedia.Tag.Title;
            TimeSpan duration = rmp3.TotalTime;
            Image image = Resources.icon_songDefault;

            if (ms != null)
                image = Image.FromStream(ms);
            if (title == null)
                title = Path.GetFileNameWithoutExtension(filePath);

            Song newSong = new Song(_filePath, title, duration, image);
            this.musicList.AddLast(newSong);
            totalSong++;

            currentNodeSong = this.musicList.Node(totalSong - 1);
            currentSong = currentNodeSong.GetItem();
            currentPosition = 0;

            this.Play();

            return true;
        }

        public void PlayIndex(int index)
        {
            currentNodeSong = musicList.Node(index);
            currentSong = currentNodeSong.GetItem();

            currentPosition = 0;
            this.Play();
        }
        public void NextSong()
        {
            if (currentNodeSong == null || currentSong == null || totalSong == 0)
                return;

            currentNodeSong = currentNodeSong.GetNodeNext();
            currentSong = currentNodeSong.GetItem();

            currentPosition = 0;
            this.Play();
        }
        public void PrevSong()
        {
            if (currentNodeSong == null || currentSong == null || totalSong == 0)
                return;

            currentNodeSong = currentNodeSong.GetNodePrev();
            currentSong = currentNodeSong.GetItem();

            currentPosition = 0;
            this.Play();

        }
        public void Pause()
        {
            if (currentNodeSong == null || currentSong == null || totalSong == 0)
                return;

            wmPlayer.controls.pause();
            currentPosition = wmPlayer.controls.currentPosition;
        }
        public void RemoveSong(int index)
        {
            musicList.Remove(index);
            totalSong--;
        }
    }
}

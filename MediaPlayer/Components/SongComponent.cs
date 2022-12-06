using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MediaPlayer.Components
{
    public partial class SongComponent : UserControl
    {
        private MediaPlayer frm;

        public bool isCurrent;
        public SongComponent(Form _frm)
        {
            InitializeComponent();

            isCurrent = false;

            this.frm = (MediaPlayer)_frm;
            Timer tmr = new Timer();
            tmr.Interval = 10;
            tmr.Start();
        }

        private void SongComponent_Load(object sender, EventArgs e)
        {
            if (title.Size.Width > 150)
                title.Text = title.Text.Substring(0, 20) + "...";
        }

        private string _title;
        private TimeSpan _duration;
        private Image _image;
        private Image _icon;
        private int _index;

        public string Title
        {
            get { return _title; }
            set { _title = value; title.Text = value; }
        }

        public TimeSpan Duration
        {
            get { return _duration; }
            set { _duration = value; duration.Text = value.ToString("mm':'ss"); }
        }

        public Image Image
        {
            get { return _image; }
            set { _image = value; image.Image = value; }
        }
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; btnPlay.Image = value; }
        }

        public int Index
        {
            get { return _index; }
            set { _index = value; }
        }
        public void SetColorPanel(Color color)
        {
            this.BackColor = color;
            borderBottom.BackColor = color;
        }

        private void SongComponent_MouseEnter(object sender, EventArgs e)
        {
            if (isCurrent == false)
                borderBottom.BackColor = Color.FromArgb(255, 128, 128);
        }

        private void SongComponent_MouseLeave(object sender, EventArgs e)
        {
            if (isCurrent == false)
                borderBottom.BackColor = Color.FromArgb(205, 236, 250);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            isCurrent = false;
            frm.Remove(this.Index);
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            isCurrent = true;
            frm.PlayIndex(this.Index);
        }
    }
}

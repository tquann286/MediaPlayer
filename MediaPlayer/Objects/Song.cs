using System;
using System.Drawing;

namespace MediaPlayer.Objects
{
    public class Song
    {
        public string filePath { get; set; }
        public string title { get; set; }
        public TimeSpan duration { get; set; }
        public Image image { get; set; }
        public Song()
        {

        }
        public Song(string _filePath, string _title, TimeSpan _duration, Image _image)
        {
            this.filePath = _filePath; ;
            this.title = _title;
            this.duration = _duration;
            this.image = _image;
        }
    }
}

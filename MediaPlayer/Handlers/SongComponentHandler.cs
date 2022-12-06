using MediaPlayer.Components;
using MediaPlayer.Objects;
using MediaPlayer.Properties;
using MediaPlayer.Structures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaPlayer.Handlers
{
    internal class SongComponentHandler
    { 
        FlowLayoutPanel pnContain;
        Form frmContain;
        public Structures.LinkedList<SongComponent> musicComponentList = new Structures.LinkedList<SongComponent>();

        public Node<SongComponent> currentNodeSongComponent;
        public SongComponent currentSongComponent;
        public int totalSongComponent;
        public SongComponentHandler(FlowLayoutPanel _flowpn, Form _frm)
        {
            this.pnContain = _flowpn;
            this.frmContain = _frm;

            currentNodeSongComponent = null;
            currentSongComponent = null;
            totalSongComponent = 0;
        }
        public void AddSong(Song song)
        {
            totalSongComponent++;

            SongComponent newComponet = new SongComponent(frmContain)
            {
                Title = song.title,
                Duration = song.duration,
                Image = song.image,
                Index = totalSongComponent - 1,
                Icon = Resources.icon_playRed
            };

            musicComponentList.AddLast(newComponet);

            currentNodeSongComponent = musicComponentList.Node(totalSongComponent - 1);
            currentSongComponent = currentNodeSongComponent.GetItem();

            ResetAll();
            SetPlay(newComponet.Index);

            //Thêm vào flow panel
            pnContain.Controls.Add(currentSongComponent);
        }
        public void RerenderAll()
        {
            for (int i = 0; i < totalSongComponent; i++)
            {
                musicComponentList.Get(i).SetColorPanel(Color.White);
                musicComponentList.Get(i).isCurrent = false;
            }
        }
        public void RemoveSong(int index)
        {
            musicComponentList.Remove(index);
            totalSongComponent--;

            _Refresh();
        }
        public void SetPlay(int index)
        {
            musicComponentList.Get(index).Icon = Resources.icon_play;
            musicComponentList.Get(index).SetColorPanel(Color.FromArgb(243, 251, 254));
            musicComponentList.Get(index).isCurrent = true;
        }
        public void _Refresh()
        {
            pnContain.Controls.Clear();
            pnContain.Refresh();

            for (int i = 0; i < totalSongComponent; i++)
            {
                musicComponentList.Get(i).Index = i;
                pnContain.Controls.Add(musicComponentList.Get(i));
            }
        }

        public void ResetAll()
        {
            for (int i = 0; i < totalSongComponent; i++)
            {
                musicComponentList.Get(i).Icon = Resources.icon_playRed;
                musicComponentList.Get(i).SetColorPanel(Color.White);
                musicComponentList.Get(i).isCurrent = false;
            }
        }
    }
}

namespace MediaPlayer.Components
{
    partial class SongComponent
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SongComponent));
            this.title = new System.Windows.Forms.Label();
            this.duration = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.borderBottom = new System.Windows.Forms.Panel();
            this.btnRemove = new System.Windows.Forms.Panel();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Cursor = System.Windows.Forms.Cursors.Hand;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.Location = new System.Drawing.Point(176, 34);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(52, 26);
            this.title.TabIndex = 2;
            this.title.Text = "Title";
            // 
            // duration
            // 
            this.duration.AutoSize = true;
            this.duration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.duration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.duration.Location = new System.Drawing.Point(393, 65);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(85, 25);
            this.duration.TabIndex = 3;
            this.duration.Text = "Duration";
            // 
            // image
            // 
            this.image.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("image.BackgroundImage")));
            this.image.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.image.Location = new System.Drawing.Point(91, 16);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(79, 74);
            this.image.TabIndex = 4;
            this.image.TabStop = false;
            // 
            // borderBottom
            // 
            this.borderBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.borderBottom.Location = new System.Drawing.Point(0, 96);
            this.borderBottom.Name = "borderBottom";
            this.borderBottom.Size = new System.Drawing.Size(514, 29);
            this.borderBottom.TabIndex = 5;
            // 
            // btnRemove
            // 
            this.btnRemove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRemove.BackgroundImage")));
            this.btnRemove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRemove.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemove.Location = new System.Drawing.Point(452, 3);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(26, 25);
            this.btnRemove.TabIndex = 6;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.AllowFocused = false;
            this.btnPlay.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnPlay.AutoSizeHeight = true;
            this.btnPlay.BorderRadius = 28;
            this.btnPlay.Image = global::MediaPlayer.Properties.Resources.icon_playRed;
            this.btnPlay.IsCircle = true;
            this.btnPlay.Location = new System.Drawing.Point(19, 22);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(56, 56);
            this.btnPlay.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPlay.TabIndex = 8;
            this.btnPlay.TabStop = false;
            this.btnPlay.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // SongComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.borderBottom);
            this.Controls.Add(this.image);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.title);
            this.Name = "SongComponent";
            this.Size = new System.Drawing.Size(489, 100);
            this.Load += new System.EventHandler(this.SongComponent_Load);
            this.MouseEnter += new System.EventHandler(this.SongComponent_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.SongComponent_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPlay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label duration;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Panel borderBottom;
        private System.Windows.Forms.Panel btnRemove;
        private Bunifu.UI.WinForms.BunifuPictureBox btnPlay;
    }
}

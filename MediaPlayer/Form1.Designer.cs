namespace MediaPlayer
{
    partial class MediaPlayer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MediaPlayer));
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges borderEdges4 = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderEdges();
            this.pnMain = new System.Windows.Forms.Panel();
            this.pnPlaylist = new System.Windows.Forms.Panel();
            this.btnVolume = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.sliderVolume = new Bunifu.UI.WinForms.BunifuVSlider();
            this.flowpnPlaylist = new System.Windows.Forms.FlowLayoutPanel();
            this.sliderDuration = new Bunifu.UI.WinForms.BunifuHSlider();
            this.lblDurationTotal = new System.Windows.Forms.Label();
            this.lblDurationRealTime = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnPicture = new System.Windows.Forms.Panel();
            this.ptbImage = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.btnPlayList = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnPlay = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnLoop = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnRandom = new Bunifu.UI.WinForms.BunifuButton.BunifuIconButton();
            this.btnNext = new System.Windows.Forms.Panel();
            this.btnPrev = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.btnOpenFile = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pnMain.SuspendLayout();
            this.pnPlaylist.SuspendLayout();
            this.pnPicture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel12.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnMain
            // 
            this.pnMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(248)))), ((int)(((byte)(253)))));
            this.pnMain.Controls.Add(this.pnPlaylist);
            this.pnMain.Controls.Add(this.sliderDuration);
            this.pnMain.Controls.Add(this.lblDurationTotal);
            this.pnMain.Controls.Add(this.lblDurationRealTime);
            this.pnMain.Controls.Add(this.lblTitle);
            this.pnMain.Controls.Add(this.pnPicture);
            this.pnMain.Controls.Add(this.btnPlayList);
            this.pnMain.Controls.Add(this.panel4);
            this.pnMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.pnMain.Location = new System.Drawing.Point(27, 88);
            this.pnMain.Name = "pnMain";
            this.pnMain.Size = new System.Drawing.Size(605, 693);
            this.pnMain.TabIndex = 1;
            // 
            // pnPlaylist
            // 
            this.pnPlaylist.BackColor = System.Drawing.Color.White;
            this.pnPlaylist.Controls.Add(this.btnVolume);
            this.pnPlaylist.Controls.Add(this.sliderVolume);
            this.pnPlaylist.Controls.Add(this.flowpnPlaylist);
            this.pnPlaylist.Location = new System.Drawing.Point(16, 79);
            this.pnPlaylist.Name = "pnPlaylist";
            this.pnPlaylist.Size = new System.Drawing.Size(586, 386);
            this.pnPlaylist.TabIndex = 2;
            // 
            // btnVolume
            // 
            this.btnVolume.AllowAnimations = true;
            this.btnVolume.AllowBorderColorChanges = true;
            this.btnVolume.AllowMouseEffects = true;
            this.btnVolume.AnimationSpeed = 200;
            this.btnVolume.BackColor = System.Drawing.Color.Transparent;
            this.btnVolume.BackgroundColor = System.Drawing.Color.White;
            this.btnVolume.BorderColor = System.Drawing.Color.White;
            this.btnVolume.BorderRadius = 1;
            this.btnVolume.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnVolume.BorderThickness = 1;
            this.btnVolume.ColorContrastOnClick = 30;
            this.btnVolume.ColorContrastOnHover = 30;
            this.btnVolume.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.btnVolume.CustomizableEdges = borderEdges1;
            this.btnVolume.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnVolume.Image = global::MediaPlayer.Properties.Resources.icon_volume;
            this.btnVolume.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnVolume.Location = new System.Drawing.Point(7, 317);
            this.btnVolume.Name = "btnVolume";
            this.btnVolume.RoundBorders = true;
            this.btnVolume.ShowBorders = true;
            this.btnVolume.Size = new System.Drawing.Size(50, 50);
            this.btnVolume.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnVolume.TabIndex = 8;
            this.btnVolume.Click += new System.EventHandler(this.btnVolume_Click);
            // 
            // sliderVolume
            // 
            this.sliderVolume.AllowCursorChanges = true;
            this.sliderVolume.AllowHomeEndKeysDetection = false;
            this.sliderVolume.AllowIncrementalClickMoves = true;
            this.sliderVolume.AllowMouseDownEffects = false;
            this.sliderVolume.AllowMouseHoverEffects = false;
            this.sliderVolume.AllowScrollingAnimations = true;
            this.sliderVolume.AllowScrollKeysDetection = true;
            this.sliderVolume.AllowScrollOptionsMenu = true;
            this.sliderVolume.AllowShrinkingOnFocusLost = false;
            this.sliderVolume.BackColor = System.Drawing.Color.Transparent;
            this.sliderVolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderVolume.BackgroundImage")));
            this.sliderVolume.BindingContainer = null;
            this.sliderVolume.BorderRadius = 2;
            this.sliderVolume.BorderThickness = 1;
            this.sliderVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderVolume.DirectionalScroll = Utilities.BunifuSlider.BunifuVScrollBar.DirectionalMovements.BottomUp;
            this.sliderVolume.DrawThickBorder = false;
            this.sliderVolume.DurationBeforeShrink = 2000;
            this.sliderVolume.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.sliderVolume.LargeChange = 10;
            this.sliderVolume.Location = new System.Drawing.Point(5, 42);
            this.sliderVolume.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.sliderVolume.Maximum = 100;
            this.sliderVolume.Minimum = 0;
            this.sliderVolume.MinimumSize = new System.Drawing.Size(31, 0);
            this.sliderVolume.MinimumThumbLength = 18;
            this.sliderVolume.Name = "sliderVolume";
            this.sliderVolume.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sliderVolume.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sliderVolume.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sliderVolume.OnDisableSlider.ElapsedColor = System.Drawing.Color.Silver;
            this.sliderVolume.OnDisableSlider.SliderColor = System.Drawing.Color.Gainsboro;
            this.sliderVolume.OnDisableSlider.ThumbColor = System.Drawing.Color.Silver;
            this.sliderVolume.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderVolume.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderVolume.ShrinkSizeLimit = 3;
            this.sliderVolume.Size = new System.Drawing.Size(55, 265);
            this.sliderVolume.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderVolume.SliderStyle = Bunifu.UI.WinForms.BunifuVSlider.SliderStyles.Thin;
            this.sliderVolume.SliderThumbStyle = Utilities.BunifuSlider.BunifuVScrollBar.SliderThumbStyles.Circular;
            this.sliderVolume.SmallChange = 1;
            this.sliderVolume.TabIndex = 7;
            this.sliderVolume.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.sliderVolume.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.sliderVolume.ThumbLength = 26;
            this.sliderVolume.ThumbMargin = 1;
            this.sliderVolume.ThumbSize = Bunifu.UI.WinForms.BunifuVSlider.ThumbSizes.Medium;
            this.sliderVolume.ThumbStyle = Bunifu.UI.WinForms.BunifuVSlider.ThumbStyles.Outline;
            this.sliderVolume.Value = 50;
            this.sliderVolume.ValueChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuVScrollBar.ValueChangedEventArgs>(this.sliderVolume_ValueChanged);
            // 
            // flowpnPlaylist
            // 
            this.flowpnPlaylist.AutoScroll = true;
            this.flowpnPlaylist.BackColor = System.Drawing.Color.White;
            this.flowpnPlaylist.Location = new System.Drawing.Point(64, 25);
            this.flowpnPlaylist.Name = "flowpnPlaylist";
            this.flowpnPlaylist.Size = new System.Drawing.Size(532, 347);
            this.flowpnPlaylist.TabIndex = 0;
            // 
            // sliderDuration
            // 
            this.sliderDuration.AllowCursorChanges = true;
            this.sliderDuration.AllowHomeEndKeysDetection = false;
            this.sliderDuration.AllowIncrementalClickMoves = true;
            this.sliderDuration.AllowMouseDownEffects = false;
            this.sliderDuration.AllowMouseHoverEffects = false;
            this.sliderDuration.AllowScrollingAnimations = true;
            this.sliderDuration.AllowScrollKeysDetection = true;
            this.sliderDuration.AllowScrollOptionsMenu = true;
            this.sliderDuration.AllowShrinkingOnFocusLost = false;
            this.sliderDuration.BackColor = System.Drawing.Color.Transparent;
            this.sliderDuration.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sliderDuration.BackgroundImage")));
            this.sliderDuration.BindingContainer = null;
            this.sliderDuration.BorderRadius = 2;
            this.sliderDuration.BorderThickness = 1;
            this.sliderDuration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sliderDuration.DrawThickBorder = false;
            this.sliderDuration.DurationBeforeShrink = 2000;
            this.sliderDuration.ElapsedColor = System.Drawing.Color.DodgerBlue;
            this.sliderDuration.LargeChange = 10;
            this.sliderDuration.Location = new System.Drawing.Point(142, 482);
            this.sliderDuration.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.sliderDuration.Maximum = 100;
            this.sliderDuration.Minimum = 0;
            this.sliderDuration.MinimumSize = new System.Drawing.Size(0, 31);
            this.sliderDuration.MinimumThumbLength = 18;
            this.sliderDuration.Name = "sliderDuration";
            this.sliderDuration.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.sliderDuration.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.sliderDuration.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.sliderDuration.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderDuration.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderDuration.ShrinkSizeLimit = 3;
            this.sliderDuration.Size = new System.Drawing.Size(337, 31);
            this.sliderDuration.SliderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.sliderDuration.SliderStyle = Bunifu.UI.WinForms.BunifuHSlider.SliderStyles.Thin;
            this.sliderDuration.SliderThumbStyle = Utilities.BunifuSlider.BunifuHScrollBar.SliderThumbStyles.Circular;
            this.sliderDuration.SmallChange = 1;
            this.sliderDuration.TabIndex = 7;
            this.sliderDuration.ThumbColor = System.Drawing.Color.DodgerBlue;
            this.sliderDuration.ThumbFillColor = System.Drawing.SystemColors.Control;
            this.sliderDuration.ThumbLength = 33;
            this.sliderDuration.ThumbMargin = 1;
            this.sliderDuration.ThumbSize = Bunifu.UI.WinForms.BunifuHSlider.ThumbSizes.Medium;
            this.sliderDuration.ThumbStyle = Bunifu.UI.WinForms.BunifuHSlider.ThumbStyles.Outline;
            this.sliderDuration.Value = 50;
            this.sliderDuration.MouseCaptureChanged += new System.EventHandler<Utilities.BunifuSlider.BunifuHScrollBar.MouseCaptureChangedEventArgs>(this.sliderDuration_MouseCaptureChanged);
            // 
            // lblDurationTotal
            // 
            this.lblDurationTotal.AutoSize = true;
            this.lblDurationTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationTotal.Location = new System.Drawing.Point(498, 484);
            this.lblDurationTotal.Name = "lblDurationTotal";
            this.lblDurationTotal.Size = new System.Drawing.Size(62, 25);
            this.lblDurationTotal.TabIndex = 6;
            this.lblDurationTotal.Text = "00:00";
            // 
            // lblDurationRealTime
            // 
            this.lblDurationRealTime.AutoSize = true;
            this.lblDurationRealTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDurationRealTime.Location = new System.Drawing.Point(67, 483);
            this.lblDurationRealTime.Name = "lblDurationRealTime";
            this.lblDurationRealTime.Size = new System.Drawing.Size(62, 25);
            this.lblDurationRealTime.TabIndex = 5;
            this.lblDurationRealTime.Text = "00:00";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(208, 409);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(181, 32);
            this.lblTitle.TabIndex = 4;
            this.lblTitle.Text = "Choose song";
            // 
            // pnPicture
            // 
            this.pnPicture.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnPicture.Controls.Add(this.ptbImage);
            this.pnPicture.Location = new System.Drawing.Point(142, 104);
            this.pnPicture.Name = "pnPicture";
            this.pnPicture.Size = new System.Drawing.Size(302, 293);
            this.pnPicture.TabIndex = 3;
            // 
            // ptbImage
            // 
            this.ptbImage.AllowFocused = false;
            this.ptbImage.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ptbImage.AutoSizeHeight = true;
            this.ptbImage.BorderRadius = 92;
            this.ptbImage.Image = global::MediaPlayer.Properties.Resources.icon_headphone;
            this.ptbImage.IsCircle = true;
            this.ptbImage.Location = new System.Drawing.Point(62, 57);
            this.ptbImage.Name = "ptbImage";
            this.ptbImage.Size = new System.Drawing.Size(185, 185);
            this.ptbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbImage.TabIndex = 0;
            this.ptbImage.TabStop = false;
            this.ptbImage.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // btnPlayList
            // 
            this.btnPlayList.BackColor = System.Drawing.Color.White;
            this.btnPlayList.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlayList.BackgroundImage")));
            this.btnPlayList.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlayList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlayList.Location = new System.Drawing.Point(551, 17);
            this.btnPlayList.Name = "btnPlayList";
            this.btnPlayList.Size = new System.Drawing.Size(54, 47);
            this.btnPlayList.TabIndex = 1;
            this.btnPlayList.Click += new System.EventHandler(this.btnPlayList_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.panel4.Controls.Add(this.btnPlay);
            this.panel4.Controls.Add(this.btnLoop);
            this.panel4.Controls.Add(this.btnRandom);
            this.panel4.Controls.Add(this.btnNext);
            this.panel4.Controls.Add(this.btnPrev);
            this.panel4.Location = new System.Drawing.Point(29, 539);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(558, 141);
            this.panel4.TabIndex = 0;
            // 
            // btnPlay
            // 
            this.btnPlay.AllowAnimations = true;
            this.btnPlay.AllowBorderColorChanges = true;
            this.btnPlay.AllowMouseEffects = true;
            this.btnPlay.AnimationSpeed = 200;
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnPlay.BorderColor = System.Drawing.Color.Transparent;
            this.btnPlay.BorderRadius = 1;
            this.btnPlay.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnPlay.BorderThickness = 1;
            this.btnPlay.ColorContrastOnClick = 30;
            this.btnPlay.ColorContrastOnHover = 30;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.btnPlay.CustomizableEdges = borderEdges2;
            this.btnPlay.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPlay.Image = global::MediaPlayer.Properties.Resources.icon_play;
            this.btnPlay.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnPlay.Location = new System.Drawing.Point(206, 6);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.RoundBorders = true;
            this.btnPlay.ShowBorders = true;
            this.btnPlay.Size = new System.Drawing.Size(132, 132);
            this.btnPlay.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnPlay.TabIndex = 9;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnLoop
            // 
            this.btnLoop.AllowAnimations = true;
            this.btnLoop.AllowBorderColorChanges = true;
            this.btnLoop.AllowMouseEffects = true;
            this.btnLoop.AnimationSpeed = 200;
            this.btnLoop.BackColor = System.Drawing.Color.Transparent;
            this.btnLoop.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnLoop.BorderColor = System.Drawing.Color.Transparent;
            this.btnLoop.BorderRadius = 1;
            this.btnLoop.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnLoop.BorderThickness = 1;
            this.btnLoop.ColorContrastOnClick = 30;
            this.btnLoop.ColorContrastOnHover = 30;
            this.btnLoop.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.btnLoop.CustomizableEdges = borderEdges3;
            this.btnLoop.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLoop.Image = global::MediaPlayer.Properties.Resources.icon_notloop;
            this.btnLoop.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnLoop.Location = new System.Drawing.Point(465, 35);
            this.btnLoop.Name = "btnLoop";
            this.btnLoop.RoundBorders = true;
            this.btnLoop.ShowBorders = true;
            this.btnLoop.Size = new System.Drawing.Size(65, 65);
            this.btnLoop.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnLoop.TabIndex = 8;
            this.btnLoop.Click += new System.EventHandler(this.btnLoop_Click);
            // 
            // btnRandom
            // 
            this.btnRandom.AllowAnimations = true;
            this.btnRandom.AllowBorderColorChanges = true;
            this.btnRandom.AllowMouseEffects = true;
            this.btnRandom.AnimationSpeed = 200;
            this.btnRandom.BackColor = System.Drawing.Color.Transparent;
            this.btnRandom.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnRandom.BorderColor = System.Drawing.Color.Transparent;
            this.btnRandom.BorderRadius = 1;
            this.btnRandom.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.BorderStyles.Solid;
            this.btnRandom.BorderThickness = 1;
            this.btnRandom.ColorContrastOnClick = 30;
            this.btnRandom.ColorContrastOnHover = 30;
            this.btnRandom.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges4.BottomLeft = true;
            borderEdges4.BottomRight = true;
            borderEdges4.TopLeft = true;
            borderEdges4.TopRight = true;
            this.btnRandom.CustomizableEdges = borderEdges4;
            this.btnRandom.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRandom.Image = global::MediaPlayer.Properties.Resources.icon_notrandom;
            this.btnRandom.ImageMargin = new System.Windows.Forms.Padding(0);
            this.btnRandom.Location = new System.Drawing.Point(43, 43);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.RoundBorders = true;
            this.btnRandom.ShowBorders = true;
            this.btnRandom.Size = new System.Drawing.Size(57, 57);
            this.btnRandom.Style = Bunifu.UI.WinForms.BunifuButton.BunifuIconButton.ButtonStyles.Round;
            this.btnRandom.TabIndex = 7;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.Location = new System.Drawing.Point(365, 43);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(50, 52);
            this.btnNext.TabIndex = 3;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(236)))), ((int)(((byte)(250)))));
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrev.Location = new System.Drawing.Point(141, 47);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(42, 48);
            this.btnPrev.TabIndex = 1;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.btnOpenFile);
            this.panel12.Location = new System.Drawing.Point(12, 105);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(148, 47);
            this.panel12.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackgroundImage = global::MediaPlayer.Properties.Resources.icon_file;
            this.btnOpenFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOpenFile.Location = new System.Drawing.Point(84, 0);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(58, 47);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // panel13
            // 
            this.panel13.BackColor = System.Drawing.Color.White;
            this.panel13.Location = new System.Drawing.Point(15, 105);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(142, 47);
            this.panel13.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel3.Location = new System.Drawing.Point(12, 105);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(78, 47);
            this.panel3.TabIndex = 0;
            this.panel3.Click += new System.EventHandler(this.panel3_Click);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(596, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(54, 54);
            this.panel2.TabIndex = 0;
            this.panel2.Click += new System.EventHandler(this.panel2_Click);
            // 
            // MediaPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(656, 793);
            this.ControlBox = false;
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel12);
            this.Controls.Add(this.panel13);
            this.Controls.Add(this.pnMain);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "MediaPlayer";
            this.Text = "Media Player";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnMain.ResumeLayout(false);
            this.pnMain.PerformLayout();
            this.pnPlaylist.ResumeLayout(false);
            this.pnPicture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ptbImage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel btnNext;
        private System.Windows.Forms.Panel btnPrev;
        private System.Windows.Forms.Panel btnPlayList;
        private System.Windows.Forms.Panel pnPlaylist;
        private System.Windows.Forms.FlowLayoutPanel flowpnPlaylist;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel btnOpenFile;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnPicture;
        private System.Windows.Forms.Label lblDurationTotal;
        private System.Windows.Forms.Label lblDurationRealTime;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnRandom;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnLoop;
        private Bunifu.UI.WinForms.BunifuHSlider sliderDuration;
        private Bunifu.UI.WinForms.BunifuVSlider sliderVolume;
        private Bunifu.UI.WinForms.BunifuPictureBox ptbImage;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnVolume;
        private Bunifu.UI.WinForms.BunifuButton.BunifuIconButton btnPlay;
    }
}


namespace MusicPlayer
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.btnSeach = new FontAwesome.Sharp.IconButton();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.btnSortFav = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btnAlbumList = new FontAwesome.Sharp.IconButton();
            this.btnOpen = new FontAwesome.Sharp.IconButton();
            this.btnMedia = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TabControlAlbum = new System.Windows.Forms.TabControl();
            this.CurrListPage = new System.Windows.Forms.TabPage();
            this.FavouritePage = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnAddFav = new FontAwesome.Sharp.IconButton();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNext = new FontAwesome.Sharp.IconButton();
            this.btnPre = new FontAwesome.Sharp.IconButton();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnDeletePage = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelMedia.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel4.SuspendLayout();
            this.TabControlAlbum.SuspendLayout();
            this.CurrListPage.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 606);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panelMedia);
            this.panel3.Controls.Add(this.btnMedia);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 506);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Controls.Add(this.btnSeach);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 484);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 22);
            this.panel6.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(161, 22);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // btnSeach
            // 
            this.btnSeach.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeach.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSeach.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeach.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSeach.IconColor = System.Drawing.Color.Green;
            this.btnSeach.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSeach.IconSize = 25;
            this.btnSeach.Location = new System.Drawing.Point(161, 0);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(39, 22);
            this.btnSeach.TabIndex = 0;
            this.btnSeach.UseVisualStyleBackColor = true;
            this.btnSeach.Click += new System.EventHandler(this.btnSeach_Click);
            // 
            // panelMedia
            // 
            this.panelMedia.Controls.Add(this.btnSortFav);
            this.panelMedia.Controls.Add(this.iconButton1);
            this.panelMedia.Controls.Add(this.btnAlbumList);
            this.panelMedia.Controls.Add(this.btnOpen);
            this.panelMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedia.Location = new System.Drawing.Point(0, 51);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(200, 204);
            this.panelMedia.TabIndex = 1;
            // 
            // btnSortFav
            // 
            this.btnSortFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSortFav.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSortFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSortFav.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUp;
            this.btnSortFav.IconColor = System.Drawing.Color.GreenYellow;
            this.btnSortFav.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSortFav.IconSize = 30;
            this.btnSortFav.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSortFav.Location = new System.Drawing.Point(0, 153);
            this.btnSortFav.Name = "btnSortFav";
            this.btnSortFav.Size = new System.Drawing.Size(200, 34);
            this.btnSortFav.TabIndex = 11;
            this.btnSortFav.UseVisualStyleBackColor = true;
            this.btnSortFav.Click += new System.EventHandler(this.btnSortFav_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Black;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.iconButton1.IconColor = System.Drawing.Color.Green;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 102);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(200, 51);
            this.iconButton1.TabIndex = 10;
            this.iconButton1.Text = "Add new album";
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnAlbumList
            // 
            this.btnAlbumList.BackColor = System.Drawing.Color.Black;
            this.btnAlbumList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAlbumList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAlbumList.FlatAppearance.BorderSize = 0;
            this.btnAlbumList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlbumList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAlbumList.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnAlbumList.IconColor = System.Drawing.Color.Green;
            this.btnAlbumList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAlbumList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlbumList.Location = new System.Drawing.Point(0, 51);
            this.btnAlbumList.Name = "btnAlbumList";
            this.btnAlbumList.Size = new System.Drawing.Size(200, 51);
            this.btnAlbumList.TabIndex = 3;
            this.btnAlbumList.Text = "Album";
            this.btnAlbumList.UseVisualStyleBackColor = false;
            this.btnAlbumList.Click += new System.EventHandler(this.btnAlbumList_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Black;
            this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOpen.FlatAppearance.BorderSize = 0;
            this.btnOpen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpen.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnOpen.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.btnOpen.IconColor = System.Drawing.Color.Green;
            this.btnOpen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOpen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnOpen.Location = new System.Drawing.Point(0, 0);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(200, 51);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open files";
            this.btnOpen.UseVisualStyleBackColor = false;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.Black;
            this.btnMedia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMedia.FlatAppearance.BorderSize = 0;
            this.btnMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMedia.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnMedia.IconChar = FontAwesome.Sharp.IconChar.Music;
            this.btnMedia.IconColor = System.Drawing.Color.Green;
            this.btnMedia.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMedia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMedia.Location = new System.Drawing.Point(0, 0);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(200, 51);
            this.btnMedia.TabIndex = 0;
            this.btnMedia.Text = "Media";
            this.btnMedia.UseVisualStyleBackColor = false;
            this.btnMedia.Click += new System.EventHandler(this.btnMedia_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Green;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Headset;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Green;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 71;
            this.iconPictureBox1.Location = new System.Drawing.Point(61, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(71, 76);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.TabControlAlbum);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.listBox);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 606);
            this.panel4.TabIndex = 2;
            // 
            // TabControlAlbum
            // 
            this.TabControlAlbum.Controls.Add(this.CurrListPage);
            this.TabControlAlbum.Controls.Add(this.FavouritePage);
            this.TabControlAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlAlbum.Location = new System.Drawing.Point(0, 0);
            this.TabControlAlbum.Name = "TabControlAlbum";
            this.TabControlAlbum.SelectedIndex = 0;
            this.TabControlAlbum.Size = new System.Drawing.Size(901, 522);
            this.TabControlAlbum.TabIndex = 10;
            this.TabControlAlbum.SelectedIndexChanged += new System.EventHandler(this.TabControlAlbum_SelectedIndexChanged);
            // 
            // CurrListPage
            // 
            this.CurrListPage.Controls.Add(this.btnDeletePage);
            this.CurrListPage.Location = new System.Drawing.Point(4, 22);
            this.CurrListPage.Name = "CurrListPage";
            this.CurrListPage.Padding = new System.Windows.Forms.Padding(3);
            this.CurrListPage.Size = new System.Drawing.Size(893, 496);
            this.CurrListPage.TabIndex = 0;
            this.CurrListPage.Text = "List Music";
            this.CurrListPage.UseVisualStyleBackColor = true;
            // 
            // FavouritePage
            // 
            this.FavouritePage.Location = new System.Drawing.Point(4, 22);
            this.FavouritePage.Name = "FavouritePage";
            this.FavouritePage.Padding = new System.Windows.Forms.Padding(3);
            this.FavouritePage.Size = new System.Drawing.Size(893, 496);
            this.FavouritePage.TabIndex = 1;
            this.FavouritePage.Text = "Favourite";
            this.FavouritePage.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 522);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(901, 10);
            this.progressBar1.TabIndex = 9;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 25;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(901, 532);
            this.listBox.TabIndex = 3;
            this.listBox.Visible = false;
            this.listBox.DoubleClick += new System.EventHandler(this.listBox_DoubleClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.iconPictureBox2);
            this.panel5.Controls.Add(this.trackBar1);
            this.panel5.Controls.Add(this.btnAddFav);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnNext);
            this.panel5.Controls.Add(this.btnPre);
            this.panel5.Controls.Add(this.btnPlay);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 532);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(901, 74);
            this.panel5.TabIndex = 2;
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.GreenYellow;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(554, 29);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(36, 37);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.Location = new System.Drawing.Point(235, 26);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(32, 32);
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(35, 26);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(194, 45);
            this.trackBar1.TabIndex = 7;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnAddFav
            // 
            this.btnAddFav.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddFav.FlatAppearance.BorderSize = 0;
            this.btnAddFav.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddFav.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnAddFav.IconColor = System.Drawing.Color.GreenYellow;
            this.btnAddFav.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddFav.Location = new System.Drawing.Point(502, 29);
            this.btnAddFav.Name = "btnAddFav";
            this.btnAddFav.Size = new System.Drawing.Size(36, 37);
            this.btnAddFav.TabIndex = 6;
            this.btnAddFav.UseVisualStyleBackColor = true;
            this.btnAddFav.Click += new System.EventHandler(this.btnAddFav_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Music\'s name";
            // 
            // btnNext
            // 
            this.btnNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNext.FlatAppearance.BorderSize = 0;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.btnNext.IconColor = System.Drawing.Color.GreenYellow;
            this.btnNext.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNext.Location = new System.Drawing.Point(460, 29);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 37);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPre
            // 
            this.btnPre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPre.FlatAppearance.BorderSize = 0;
            this.btnPre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPre.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.btnPre.IconColor = System.Drawing.Color.GreenYellow;
            this.btnPre.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPre.Location = new System.Drawing.Point(370, 29);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(39, 37);
            this.btnPre.TabIndex = 2;
            this.btnPre.UseVisualStyleBackColor = true;
            this.btnPre.Click += new System.EventHandler(this.btnPre_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.btnPlay.IconColor = System.Drawing.Color.GreenYellow;
            this.btnPlay.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPlay.Location = new System.Drawing.Point(415, 24);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(39, 47);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(901, 606);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Mp3 files|*mp3|Mp4 files|*.mp4|All files|*.*\"";
            this.openFileDialog1.Multiselect = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnDeletePage
            // 
            this.btnDeletePage.BackColor = System.Drawing.Color.Silver;
            this.btnDeletePage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeletePage.FlatAppearance.BorderSize = 0;
            this.btnDeletePage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletePage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnDeletePage.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDeletePage.IconColor = System.Drawing.Color.Black;
            this.btnDeletePage.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeletePage.Location = new System.Drawing.Point(851, 420);
            this.btnDeletePage.Name = "btnDeletePage";
            this.btnDeletePage.Size = new System.Drawing.Size(39, 54);
            this.btnDeletePage.TabIndex = 10;
            this.btnDeletePage.UseVisualStyleBackColor = false;
            this.btnDeletePage.Visible = false;
            this.btnDeletePage.Click += new System.EventHandler(this.btnDeletePage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1101, 606);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelMedia.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.TabControlAlbum.ResumeLayout(false);
            this.CurrListPage.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMedia;
        private System.Windows.Forms.Panel panelMedia;
        private FontAwesome.Sharp.IconButton btnOpen;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnNext;
        private FontAwesome.Sharp.IconButton btnPre;
        private FontAwesome.Sharp.IconButton btnAlbumList;
        private System.Windows.Forms.ListBox listBox;
        private FontAwesome.Sharp.IconButton btnAddFav;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton btnSeach;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TabControl TabControlAlbum;
        private System.Windows.Forms.TabPage CurrListPage;
        private System.Windows.Forms.TabPage FavouritePage;
        private FontAwesome.Sharp.IconButton btnSortFav;
        private FontAwesome.Sharp.IconButton btnDeletePage;
    }
}


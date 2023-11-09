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
            System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("ListViewGroup", System.Windows.Forms.HorizontalAlignment.Left);
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
            this.btnDeletePage = new FontAwesome.Sharp.IconButton();
            this.FavouritePage = new System.Windows.Forms.TabPage();
            this.listView = new System.Windows.Forms.ListView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.listBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconcheck = new FontAwesome.Sharp.IconButton();
            this.btnRepeat = new FontAwesome.Sharp.IconButton();
            this.btnAddToAlbum = new FontAwesome.Sharp.IconButton();
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
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
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(300, 932);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panelMedia);
            this.panel3.Controls.Add(this.btnMedia);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 154);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 778);
            this.panel3.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.richTextBox1);
            this.panel6.Controls.Add(this.btnSeach);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 744);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(300, 34);
            this.panel6.TabIndex = 2;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 0);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(242, 34);
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
            this.btnSeach.Location = new System.Drawing.Point(242, 0);
            this.btnSeach.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSeach.Name = "btnSeach";
            this.btnSeach.Size = new System.Drawing.Size(58, 34);
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
            this.panelMedia.Location = new System.Drawing.Point(0, 79);
            this.panelMedia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(300, 314);
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
            this.btnSortFav.Location = new System.Drawing.Point(0, 237);
            this.btnSortFav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSortFav.Name = "btnSortFav";
            this.btnSortFav.Size = new System.Drawing.Size(300, 52);
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
            this.iconButton1.Location = new System.Drawing.Point(0, 158);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(300, 79);
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
            this.btnAlbumList.Location = new System.Drawing.Point(0, 79);
            this.btnAlbumList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAlbumList.Name = "btnAlbumList";
            this.btnAlbumList.Size = new System.Drawing.Size(300, 79);
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
            this.btnOpen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(300, 79);
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
            this.btnMedia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMedia.Name = "btnMedia";
            this.btnMedia.Size = new System.Drawing.Size(300, 79);
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
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 154);
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
            this.iconPictureBox1.IconSize = 107;
            this.iconPictureBox1.Location = new System.Drawing.Point(91, 19);
            this.iconPictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(107, 118);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.TabControlAlbum);
            this.panel4.Controls.Add(this.listView);
            this.panel4.Controls.Add(this.progressBar1);
            this.panel4.Controls.Add(this.listBox);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(300, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1352, 932);
            this.panel4.TabIndex = 2;
            // 
            // TabControlAlbum
            // 
            this.TabControlAlbum.Controls.Add(this.CurrListPage);
            this.TabControlAlbum.Controls.Add(this.FavouritePage);
            this.TabControlAlbum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabControlAlbum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControlAlbum.Location = new System.Drawing.Point(0, 0);
            this.TabControlAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TabControlAlbum.Name = "TabControlAlbum";
            this.TabControlAlbum.SelectedIndex = 0;
            this.TabControlAlbum.Size = new System.Drawing.Size(1352, 803);
            this.TabControlAlbum.TabIndex = 10;
            this.TabControlAlbum.SelectedIndexChanged += new System.EventHandler(this.TabControlAlbum_SelectedIndexChanged);
            // 
            // CurrListPage
            // 
            this.CurrListPage.Controls.Add(this.btnDeletePage);
            this.CurrListPage.Location = new System.Drawing.Point(4, 38);
            this.CurrListPage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrListPage.Name = "CurrListPage";
            this.CurrListPage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CurrListPage.Size = new System.Drawing.Size(1344, 761);
            this.CurrListPage.TabIndex = 0;
            this.CurrListPage.Text = "List Music";
            this.CurrListPage.UseVisualStyleBackColor = true;
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
            this.btnDeletePage.Location = new System.Drawing.Point(1277, 646);
            this.btnDeletePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDeletePage.Name = "btnDeletePage";
            this.btnDeletePage.Size = new System.Drawing.Size(58, 82);
            this.btnDeletePage.TabIndex = 10;
            this.btnDeletePage.UseVisualStyleBackColor = false;
            this.btnDeletePage.Visible = false;
            this.btnDeletePage.Click += new System.EventHandler(this.btnDeletePage_Click);
            // 
            // FavouritePage
            // 
            this.FavouritePage.Location = new System.Drawing.Point(4, 38);
            this.FavouritePage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FavouritePage.Name = "FavouritePage";
            this.FavouritePage.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.FavouritePage.Size = new System.Drawing.Size(1344, 761);
            this.FavouritePage.TabIndex = 1;
            this.FavouritePage.Text = "Favourite";
            this.FavouritePage.UseVisualStyleBackColor = true;
            // 
            // listView
            // 
            this.listView.AllowDrop = true;
            this.listView.BackColor = System.Drawing.Color.Gainsboro;
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            listViewGroup2.Header = "ListViewGroup";
            listViewGroup2.Name = "listViewGroup1";
            this.listView.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup2});
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(1352, 803);
            this.listView.TabIndex = 10;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.List;
            this.listView.DragDrop += new System.Windows.Forms.DragEventHandler(this.listView_DragDrop);
            this.listView.DragEnter += new System.Windows.Forms.DragEventHandler(this.listView_DragEnter);
            this.listView.DragOver += new System.Windows.Forms.DragEventHandler(this.listView_DragOver);
            this.listView.DoubleClick += new System.EventHandler(this.listView_DoubleClick);
            this.listView.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listView_MouseDown);
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 803);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1352, 15);
            this.progressBar1.TabIndex = 9;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.listBox.FormattingEnabled = true;
            this.listBox.HorizontalScrollbar = true;
            this.listBox.ItemHeight = 36;
            this.listBox.Location = new System.Drawing.Point(0, 0);
            this.listBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(1352, 818);
            this.listBox.TabIndex = 3;
            this.listBox.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.iconcheck);
            this.panel5.Controls.Add(this.btnRepeat);
            this.panel5.Controls.Add(this.btnAddToAlbum);
            this.panel5.Controls.Add(this.btnDelete);
            this.panel5.Controls.Add(this.iconPictureBox2);
            this.panel5.Controls.Add(this.trackBar1);
            this.panel5.Controls.Add(this.btnAddFav);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.btnNext);
            this.panel5.Controls.Add(this.btnPre);
            this.panel5.Controls.Add(this.btnPlay);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 818);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1352, 114);
            this.panel5.TabIndex = 2;
            // 
            // iconcheck
            // 
            this.iconcheck.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.iconcheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconcheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconcheck.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.iconcheck.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconcheck.IconColor = System.Drawing.Color.GreenYellow;
            this.iconcheck.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconcheck.IconSize = 15;
            this.iconcheck.Location = new System.Drawing.Point(508, 68);
            this.iconcheck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.iconcheck.Name = "iconcheck";
            this.iconcheck.Size = new System.Drawing.Size(24, 31);
            this.iconcheck.TabIndex = 3;
            this.iconcheck.UseVisualStyleBackColor = false;
            // 
            // btnRepeat
            // 
            this.btnRepeat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepeat.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnRepeat.IconChar = FontAwesome.Sharp.IconChar.Repeat;
            this.btnRepeat.IconColor = System.Drawing.Color.GreenYellow;
            this.btnRepeat.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRepeat.Location = new System.Drawing.Point(464, 40);
            this.btnRepeat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRepeat.Name = "btnRepeat";
            this.btnRepeat.Size = new System.Drawing.Size(52, 68);
            this.btnRepeat.TabIndex = 11;
            this.btnRepeat.UseVisualStyleBackColor = true;
            this.btnRepeat.Click += new System.EventHandler(this.btnRepeat_Click_1);
            // 
            // btnAddToAlbum
            // 
            this.btnAddToAlbum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddToAlbum.FlatAppearance.BorderSize = 0;
            this.btnAddToAlbum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddToAlbum.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnAddToAlbum.IconColor = System.Drawing.Color.GreenYellow;
            this.btnAddToAlbum.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddToAlbum.Location = new System.Drawing.Point(915, 38);
            this.btnAddToAlbum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddToAlbum.Name = "btnAddToAlbum";
            this.btnAddToAlbum.Size = new System.Drawing.Size(54, 72);
            this.btnAddToAlbum.TabIndex = 10;
            this.btnAddToAlbum.UseVisualStyleBackColor = true;
            this.btnAddToAlbum.Click += new System.EventHandler(this.btnAddToAlbum_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnDelete.IconColor = System.Drawing.Color.GreenYellow;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDelete.Location = new System.Drawing.Point(831, 45);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(54, 58);
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
            this.iconPictureBox2.IconSize = 48;
            this.iconPictureBox2.Location = new System.Drawing.Point(352, 40);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(48, 49);
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(53, 40);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(291, 69);
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
            this.btnAddFav.Location = new System.Drawing.Point(753, 45);
            this.btnAddFav.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddFav.Name = "btnAddFav";
            this.btnAddFav.Size = new System.Drawing.Size(54, 58);
            this.btnAddFav.TabIndex = 6;
            this.btnAddFav.UseVisualStyleBackColor = true;
            this.btnAddFav.Click += new System.EventHandler(this.btnAddFav_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(415, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
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
            this.btnNext.Location = new System.Drawing.Point(690, 45);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(54, 58);
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
            this.btnPre.Location = new System.Drawing.Point(555, 45);
            this.btnPre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPre.Name = "btnPre";
            this.btnPre.Size = new System.Drawing.Size(58, 58);
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
            this.btnPlay.Location = new System.Drawing.Point(622, 40);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(58, 72);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(0, 0);
            this.axWindowsMediaPlayer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(1352, 932);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            this.axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(this.axWindowsMediaPlayer1_PlayStateChange);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Mp3 files|*mp3|Mp4 files|*.mp4|All files|*.*\"";
            this.openFileDialog1.Multiselect = true;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1652, 932);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private FontAwesome.Sharp.IconButton btnSeach;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.TabControl TabControlAlbum;
        private System.Windows.Forms.TabPage FavouritePage;
        private FontAwesome.Sharp.IconButton btnSortFav;
        private FontAwesome.Sharp.IconButton btnAddToAlbum;
        private System.Windows.Forms.TabPage CurrListPage;
        private FontAwesome.Sharp.IconButton btnDeletePage;
        private FontAwesome.Sharp.IconButton btnRepeat;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton iconcheck;
        private System.Windows.Forms.ListView listView;
    }
}


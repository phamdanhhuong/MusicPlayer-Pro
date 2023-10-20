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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnMedia = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panelMedia = new System.Windows.Forms.Panel();
            this.btnOpen = new FontAwesome.Sharp.IconButton();
            this.btnCurList = new FontAwesome.Sharp.IconButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnPlay = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.btnFavList = new FontAwesome.Sharp.IconButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddFav = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelMedia.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.panel5.SuspendLayout();
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
            // panel2
            // 
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.WindowText;
            this.panel3.Controls.Add(this.panelMedia);
            this.panel3.Controls.Add(this.btnMedia);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 506);
            this.panel3.TabIndex = 2;
            // 
            // btnMedia
            // 
            this.btnMedia.BackColor = System.Drawing.Color.Black;
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
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Green;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.HeadphonesAlt;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Green;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 71;
            this.iconPictureBox1.Location = new System.Drawing.Point(61, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(71, 76);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            // 
            // panelMedia
            // 
            this.panelMedia.Controls.Add(this.btnFavList);
            this.panelMedia.Controls.Add(this.btnCurList);
            this.panelMedia.Controls.Add(this.btnOpen);
            this.panelMedia.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMedia.Location = new System.Drawing.Point(0, 51);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(200, 158);
            this.panelMedia.TabIndex = 1;
            // 
            // btnOpen
            // 
            this.btnOpen.BackColor = System.Drawing.Color.Black;
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
            // btnCurList
            // 
            this.btnCurList.BackColor = System.Drawing.Color.Black;
            this.btnCurList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCurList.FlatAppearance.BorderSize = 0;
            this.btnCurList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCurList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCurList.IconChar = FontAwesome.Sharp.IconChar.List;
            this.btnCurList.IconColor = System.Drawing.Color.Green;
            this.btnCurList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCurList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCurList.Location = new System.Drawing.Point(0, 51);
            this.btnCurList.Name = "btnCurList";
            this.btnCurList.Size = new System.Drawing.Size(200, 51);
            this.btnCurList.TabIndex = 2;
            this.btnCurList.Text = "List";
            this.btnCurList.UseVisualStyleBackColor = false;
            this.btnCurList.Click += new System.EventHandler(this.btnCurList_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Controls.Add(this.listBox);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.axWindowsMediaPlayer1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(901, 606);
            this.panel4.TabIndex = 2;
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
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "\"Mp3 files|*mp3|All files|*.*\"";
            this.openFileDialog1.Multiselect = true;
            // 
            // btnPlay
            // 
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
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAddFav);
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.iconButton5);
            this.panel5.Controls.Add(this.iconButton2);
            this.panel5.Controls.Add(this.btnPlay);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 532);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(901, 74);
            this.panel5.TabIndex = 2;
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Backward;
            this.iconButton2.IconColor = System.Drawing.Color.GreenYellow;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(370, 29);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(39, 37);
            this.iconButton2.TabIndex = 2;
            this.iconButton2.UseVisualStyleBackColor = true;
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Forward;
            this.iconButton5.IconColor = System.Drawing.Color.GreenYellow;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.Location = new System.Drawing.Point(460, 29);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(36, 37);
            this.iconButton5.TabIndex = 3;
            this.iconButton5.UseVisualStyleBackColor = true;
            // 
            // btnFavList
            // 
            this.btnFavList.BackColor = System.Drawing.Color.Black;
            this.btnFavList.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFavList.FlatAppearance.BorderSize = 0;
            this.btnFavList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFavList.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnFavList.IconChar = FontAwesome.Sharp.IconChar.Heart;
            this.btnFavList.IconColor = System.Drawing.Color.Green;
            this.btnFavList.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFavList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFavList.Location = new System.Drawing.Point(0, 102);
            this.btnFavList.Name = "btnFavList";
            this.btnFavList.Size = new System.Drawing.Size(200, 51);
            this.btnFavList.TabIndex = 3;
            this.btnFavList.Text = "Favourite";
            this.btnFavList.UseVisualStyleBackColor = false;
            this.btnFavList.Click += new System.EventHandler(this.btnFavList_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(277, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Music\'s name";
            // 
            // btnAddFav
            // 
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
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelMedia.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnMedia;
        private System.Windows.Forms.Panel panelMedia;
        private FontAwesome.Sharp.IconButton btnCurList;
        private FontAwesome.Sharp.IconButton btnOpen;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel4;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private FontAwesome.Sharp.IconButton btnPlay;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton iconButton5;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton btnFavList;
        private System.Windows.Forms.ListBox listBox;
        private FontAwesome.Sharp.IconButton btnAddFav;
        private System.Windows.Forms.Label label1;
    }
}


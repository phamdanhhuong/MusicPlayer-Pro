using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using ListBox = System.Windows.Forms.ListBox;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        enum status
        {
            Curr=1,
            Search=2,
            Album=3,
            Fav=4
        }
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Hide();
            listBox.Hide();
            axWindowsMediaPlayer1.settings.volume = 0;
            btnSortFav.Hide();
            btnDelete.Hide();
            TabControlAlbum.Hide();
            panelMedia.Hide();
            panel6.Hide();
        }
        LIST<music> musicCur = new LIST<music>();
        LIST<music> musicFav = new LIST<music>();
        LIST<music> searchResult = new LIST<music>();
        LIST<string> AlbumName = new LIST<string>();
        Dictionary<string,LIST<music>> musicDic=new Dictionary<string,LIST<music>>();
        
        int pos = 0;
        status where= status.Curr;
        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (panelMedia.Visible == true)
            {
                panelMedia.Hide();
            }
            else
            {
                panelMedia.Show();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult =MessageBox.Show("Ban co muon thoat", "Thoat", MessageBoxButtons.YesNo);
            if(DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void play(LIST<music> a,int vt) 
        {
            if (a != null)
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                axWindowsMediaPlayer1.Show();
                axWindowsMediaPlayer1.URL = a[vt].Path;
                btnSortFav.Hide();
                listBox.Hide();
                TabControlAlbum.Hide();
                label1.Text ="Music's name "+ a[vt].Name;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            music temp = new music();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
               for(int i=0; i < openFileDialog1.FileNames.Length; i++)
                {
                    temp = new music(openFileDialog1.SafeFileNames[i], openFileDialog1.FileNames[i]);
                    if (checkVar(musicCur, temp)==true)
                    {
                        musicCur.Add(temp);
                    }
                }
               Sort.quickSort(musicCur,0,musicCur.Count-1);
            }
        }
        private bool checkVar(LIST<music> a, music item)
        {
            for (int i=0;i<a.Count;i++)
            {
                if(string.Compare(item.Path , a[i].Path)==0)
                    return false;
            }
            return true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
            }
            else if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                try
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                }
                catch
                {
                    if (where == status.Fav)
                    {
                        play(musicFav, pos);
                    }
                    else if (where == status.Curr)
                    {
                        play(musicCur, pos);
                    }
                    else if (where == status.Search)
                    {
                        play(searchResult, pos);
                    }
                }
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
            }
        }

        private void btnAddFav_Click(object sender, EventArgs e)
        {
            if(musicCur[pos].Fav == false)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                musicCur[pos].Fav = true;
                music temp = musicCur[pos];
                temp.Fav = true;
                if (musicFav.IndexOfItem(temp)==-1)
                    musicFav.Add(temp);
            }
            else if(musicCur[pos].Fav == true)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.Heart;
                musicCur[pos].Fav = false;
                musicFav.Remove(musicCur[pos]);
            }
        }
        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            
            if(listBox.SelectedIndex > -1)
            {
                pos = listBox.SelectedIndex;
                if (where == status.Search)
                {
                    play(searchResult, pos);
                }
                else if (where == status.Fav)
                {
                    play(musicFav, pos);
                }
                else
                {
                    play(musicCur, pos);
                }
                update();
            }
        }

        private void update()
        {
            if (where == status.Fav)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                btnDelete.Hide();
            }
            else if(where == status.Curr)
            {
                if (musicCur[pos].Fav)
                {
                    btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                }
                else
                {
                    btnAddFav.IconChar = FontAwesome.Sharp.IconChar.Heart;
                }
                btnDelete.Show();
            }
            else if(where == status.Search)
            {
                if (searchResult[pos].Fav)
                {
                    btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                }
                else
                {
                    btnAddFav.IconChar = FontAwesome.Sharp.IconChar.Heart;
                }
            }
        }
        private void btnPre_Click(object sender, EventArgs e)
        {
            pre();
        }
        private void pre()
        {
            if (where == status.Fav)
            {
                if (pos == 0)
                    pos = musicFav.Count - 1;
                else if (pos > 0)
                    pos--;
                play(musicFav, pos);
            }
            else if (where == status.Curr)
            {
                if (pos == 0)
                    pos = musicCur.Count - 1;
                else if (pos > 0)
                    pos--;
                play(musicCur, pos);
            }
            else if(where == status.Search)
            {
                if (pos == 0)
                    pos = searchResult.Count - 1;
                else if (pos > 0)
                    pos--;
                play(searchResult, pos);
            }
            update();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            next();
        }
        private void next()
        {
            if (where == status.Fav)
            {
                if (pos == musicFav.Count - 1)
                    pos = 0;
                else
                    pos++;
                play(musicFav, pos);
            }
            else if (where == status.Curr)
            {
                if (pos == musicCur.Count - 1)
                    pos = 0;
                else
                    pos++;
                play(musicCur, pos);
            }
            else if(where == status.Search)
            {
                if (pos == searchResult.Count - 1)
                    pos = 0;
                else
                    pos++;
                play(searchResult, pos);
            }
            update();
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                timer2.Start();
                progressBar1.Value = 0;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value*10;
            if (trackBar1.Value >= 5)
            {
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
            }
            else if(trackBar1.Value <5 && trackBar1.Value>0)
            {
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VolumeLow;
            }
            else if(trackBar1.Value == 0)
            {
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Value = (int)axWindowsMediaPlayer1.Ctlcontrols.currentPosition;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            next();
            timer2.Stop();
        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Show();
            panel6.Hide();
            btnSortFav.Hide();
            listBox.Hide();
            TabControlAlbum.Hide();
        }

        private void btnSortFav_Click(object sender, EventArgs e)
        {
            if(btnSortFav.IconChar==FontAwesome.Sharp.IconChar.SortAlphaUp)
            {
                Sort.InterchangeSort(musicFav);
                listBox.Items.Clear();
                pos = 0;
                for(int i = 0; i < musicFav.Count; i++)
                {
                    listBox.Items.Add(musicFav[i].Name);
                }
                btnSortFav.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUpAlt;
                TabControlAlbum.SelectTab(FavouritePage);
            }
            else
            {
                Sort.InterchangeSortRev(musicFav);
                listBox.Items.Clear();
                pos = 0;
                for (int i = 0; i < musicFav.Count; i++)
                {
                    listBox.Items.Add(musicFav[i].Name);
                }
                btnSortFav.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUp;
                TabControlAlbum.SelectTab(FavouritePage);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult = MessageBox.Show("Bạn có muốn xóa bài này", "Xóa", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                musicCur.Remove(musicCur[pos]);
                listBox.Items.Clear();
                where = status.Curr;
                pos = 0;
                for (int i = 0; i < musicCur.Count; i++)
                {
                    listBox.Items.Add(musicCur[i].Name);
                }
                if (musicCur.Count>0)
                {
                    play(musicCur, pos);
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                }
                else
                {
                    axWindowsMediaPlayer1.Ctlcontrols.pause();
                    label1.Text = "Music's name";
                }
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Play;
                progressBar1.Value = 0;
                btnDelete.Show();
            }
        }

        private void btnSeach_Click(object sender, EventArgs e)
        {
            music tmp = Search.BinarySearch(musicCur, new music(richTextBox1.Text, ""));
            if (tmp != null)
            {
                axWindowsMediaPlayer1.Hide();
                listBox.Items.Clear();
                searchResult.Add(tmp);
                listBox.Items.Add(tmp.Name);
                where = status.Search;
                pos = 0;
                btnDelete.Show();
                listBox.Show();
            }
            else
            {
                listBox.Items.Clear();
            }
        }

        private void btnAlbumList_Click(object sender, EventArgs e)
        {
            panel6.Show();
            axWindowsMediaPlayer1.Hide();
            TabControlAlbum.Show();
            TabControlAlbum.SelectTab(CurrListPage);
            listBox.Items.Clear();
            btnDelete.Show();
            where = status.Curr;
            pos = 0;
            for (int i = 0; i < musicCur.Count; i++)
            {
                listBox.Items.Add(musicCur[i].Name);
            }
            CurrListPage.Controls.Add(listBox);
            listBox.Visible = true;
        }
       

        private void iconButton1_Click(object sender, EventArgs e)
        {
            using (TabName tabNameInputForm = new TabName())
            {
                if (tabNameInputForm.ShowDialog() == DialogResult.OK)
                {
                    // Lấy tên từ TextBox trên Form TabNameInputForm
                    string tabName = tabNameInputForm.TabNameInput;
                    // Tạo một tabPage mới với tên từ người dùng
                    TabPage newTab = new TabPage(tabName);
                    // Thêm tabPage mới vào TabControl
                    TabControlAlbum.TabPages.Add(newTab);
                    //creat a new music list
                    LIST<music> a = new LIST<music>();
                    musicDic.Add(tabName, a);
                    // Chuyển đến tabPage mới
                    TabControlAlbum.SelectedTab = newTab;
                }
            }
            TabControlAlbum.Show();
        }

        private void TabControlAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlAlbum.SelectedTab==CurrListPage)
            {
                panel6.Show();
                listBox.Items.Clear();
                where = status.Curr;
                btnDelete.Show();
                pos = 0;
                for (int i = 0; i < musicCur.Count; i++)
                {
                    listBox.Items.Add(musicCur[i].Name);
                }
                CurrListPage.Controls.Add(listBox);
                listBox.Visible = true;
            }
            else if (TabControlAlbum.SelectedTab== FavouritePage)
            {
                listBox.Items.Clear();
                panel6.Hide();
                btnSortFav.Show();
                where = status.Fav;
                btnDelete.Hide();
                pos = 0;
                for (int i = 0; i < musicFav.Count; i++)
                {
                    listBox.Items.Add(musicFav[i].Name);
                }
                FavouritePage.Controls.Add(listBox);
                listBox.Visible = true;
            }
            else
            {
                LIST<music> temp = musicDic[TabControlAlbum.SelectedTab.Text];
                listBox.Items.Clear();
                panel6.Hide();
                where = status.Album;
                btnDelete.Hide();
                pos = 0;
                for (int i = 0; i < temp.Count; i++)
                {
                    listBox.Items.Add(temp[i].Name);
                }
                TabControlAlbum.SelectedTab.Controls.Add(listBox);
                TabControlAlbum.SelectedTab.Controls.Add(btnDeletePage);
                listBox.Visible = true;
                btnDeletePage.Visible = true;
                btnDeletePage.BringToFront();
            }
        }

        private void btnDeletePage_Click(object sender, EventArgs e)
        {
            if (TabControlAlbum.TabCount > 0)
            {
                DialogResult = MessageBox.Show("Bạn có muốn xóa", "Remove Tab", MessageBoxButtons.YesNo);
                if (DialogResult == DialogResult.Yes)
                {
                    int currentIndex = TabControlAlbum.SelectedIndex;
                    TabControlAlbum.TabPages.Remove(TabControlAlbum.SelectedTab);
                    if (currentIndex > 0)
                        TabControlAlbum.SelectedTab = TabControlAlbum.TabPages[currentIndex - 1];
                }
            }
        }
    }
}

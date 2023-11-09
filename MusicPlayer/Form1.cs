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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Runtime.Remoting.Messaging;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        enum status
        {
            Curr = 1,
            Search = 2,
            Album = 3,
            Fav = 4
        }
        public Form1()
        {
            InitializeComponent();
            axWindowsMediaPlayer1.Hide();
            listView.Hide();
            axWindowsMediaPlayer1.settings.volume = 0;
            btnSortFav.Hide();
            btnDelete.Hide();
            TabControlAlbum.Hide();
            panelMedia.Hide();
            panel6.Hide();
            btnAddToAlbum.Hide();
            listView.AllowDrop = true;

        }
        LIST<music> musicCur = new LIST<music>();
        LIST<music> musicFav = new LIST<music>();
        LIST<music> searchResult = new LIST<music>();
        LIST<string> AlbumName = new LIST<string>();
        LIST<music> tempFav = new LIST<music>();
        Dictionary<string, LIST<music>> musicDic = new Dictionary<string, LIST<music>>();
        bool repeat = false;
        int pos = 0;
        status where = status.Curr;
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
            DialogResult = MessageBox.Show("Ban co muon thoat", "Thoat", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void play(LIST<music> a, int vt)
        {
            if (a != null)
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                axWindowsMediaPlayer1.Show();
                axWindowsMediaPlayer1.URL = a[vt].Path;
                btnSortFav.Hide();
                listView.Hide();
                TabControlAlbum.Hide();
                label1.Text = "Music's name " + a[vt].Name;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            music temp = new music();
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                for (int i = 0; i < openFileDialog1.FileNames.Length; i++)
                {
                    temp = new music(openFileDialog1.SafeFileNames[i], openFileDialog1.FileNames[i]);
                    if (checkVar(musicCur, temp) == true)
                    {
                        musicCur.Add(temp);
                        string[] tam = { temp.Name, temp.Path, "false" };
                        File.AppendAllLines("ListMusic.txt", tam);
                    }
                }
                Sort.quickSort(musicCur, 0, musicCur.Count - 1);
            }
        }
        private bool checkVar(LIST<music> a, music item)
        {
            for (int i = 0; i < a.Count; i++)
            {
                if (string.Compare(item.Path, a[i].Path) == 0)
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
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
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
            if (musicCur[pos].Fav == false)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                musicCur[pos].Fav = true;
                music temp = musicCur[pos];
                temp.Fav = true;
                if (musicFav.IndexOfItem(temp) == -1)
                    musicFav.Add(temp);
            }
            else if (musicCur[pos].Fav == true)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.Heart;
                musicCur[pos].Fav = false;
                musicFav.Remove(musicCur[pos]);
            }
        }
        private void listView_DoubleClick(object sender, EventArgs e)
        {
            if (listView.SelectedItems.Count > -1)
            {
                pos = listView.SelectedItems[0].Index;
                if (where == status.Search)
                {
                    play(searchResult, pos);

                }
                else if (where == status.Fav)
                {

                    play(musicFav, pos);

                }
                else if (where == status.Album)
                {
                    play(musicDic[TabControlAlbum.SelectedTab.Text], pos);
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
            else if (where == status.Curr)
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
            else if (where == status.Search)
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
            repeat = false;
            iconcheck.IconChar = FontAwesome.Sharp.IconChar.None;
            iconcheck.Hide();
            pre();
        }
        private void pre()
        {
            if (where == status.Fav)
            {
                if (repeat == false)
                {
                    if (pos == 0)
                        pos = musicFav.Count - 1;
                    else if (pos > 0)
                        pos--;
                }
                play(musicFav, pos);
            }
            else if (where == status.Curr)
            {
                if (repeat == false)
                {
                    if (pos == 0)
                        pos = musicCur.Count - 1;
                    else if (pos > 0)
                        pos--;
                }
                play(musicCur, pos);
            }
            else if (where == status.Search)
            {
                if (repeat == false)
                {
                    if (pos == 0)
                        pos = searchResult.Count - 1;
                    else if (pos > 0)
                        pos--;
                }
                play(searchResult, pos);
            }
            else if (where == status.Album)
            {
                if (repeat == false)
                {
                    if (pos == 0)
                        pos = musicDic[TabControlAlbum.SelectedTab.Text].Count - 1;
                    else if (pos > 0)
                        pos--;
                }
                play(musicDic[TabControlAlbum.SelectedTab.Text], pos);
            }
            update();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            repeat = false;
            iconcheck.IconChar = FontAwesome.Sharp.IconChar.None;
            iconcheck.Hide();
            next();
        }
        private void next()
        {
            if (where == status.Fav)
            {
                if (repeat == false)
                {
                    if (pos == musicFav.Count - 1)
                        pos = 0;
                    else
                        pos++;
                }
                play(musicFav, pos);
            }
            else if (where == status.Curr)
            {
                if (repeat == false)
                {
                    if (pos == musicCur.Count - 1)
                        pos = 0;
                    else
                        pos++;
                }
                play(musicCur, pos);
            }
            else if (where == status.Search)
            {
                if (repeat == false)
                {
                    if (pos == searchResult.Count - 1)
                        pos = 0;
                    else
                        pos++;
                }
                play(searchResult, pos);
            }
            else if (where == status.Album)
            {
                if (repeat == false)
                {
                    if (pos == musicDic[TabControlAlbum.SelectedTab.Text].Count - 1)
                        pos = 0;
                    else
                        pos++;
                }
                play(musicDic[TabControlAlbum.SelectedTab.Text], pos);
            }
            update();
        }
        private void axWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                progressBar1.Maximum = (int)axWindowsMediaPlayer1.Ctlcontrols.currentItem.duration;
                timer1.Start();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPaused)
            {
                timer1.Stop();
            }
            else if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                timer1.Stop();
                timer2.Start();
                progressBar1.Value = 0;
            }
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.settings.volume = trackBar1.Value * 10;
            if (trackBar1.Value >= 5)
            {
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VolumeHigh;
            }
            else if (trackBar1.Value < 5 && trackBar1.Value > 0)
            {
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VolumeLow;
            }
            else if (trackBar1.Value == 0)
            {
                iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.VolumeMute;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1.playState == WMPLib.WMPPlayState.wmppsPlaying)
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
            listView.Hide();
            TabControlAlbum.Hide();
        }

        private void btnSortFav_Click(object sender, EventArgs e)
        {
            if (btnSortFav.IconChar == FontAwesome.Sharp.IconChar.SortAlphaUp)
            {
                Sort.InterchangeSort(musicFav);
                listView.Items.Clear();
                pos = 0;
                for (int i = 0; i < musicFav.Count; i++)
                {
                    listView.Items.Add(musicFav[i].Name);
                }
                btnSortFav.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUpAlt;
                TabControlAlbum.SelectTab(FavouritePage);
            }
            else
            {
                Sort.InterchangeSortRev(musicFav);
                listView.Items.Clear();
                pos = 0;
                for (int i = 0; i < musicFav.Count; i++)
                {
                    listView.Items.Add(musicFav[i].Name);
                }
                btnSortFav.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUp;
                TabControlAlbum.SelectTab(FavouritePage);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult = MessageBox.Show("Bạn có muốn xóa bài này", "Xóa", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes && where == status.Curr)
            {
                musicCur.Remove(musicCur[pos]);
                listView.Items.Clear();
                where = status.Curr;
                pos = 0;
                for (int i = 0; i < musicCur.Count; i++)
                {
                    listView.Items.Add(musicCur[i].Name);
                }
                if (musicCur.Count > 0)
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
            else if (DialogResult == DialogResult.Yes && where == status.Album)
            {
                musicDic[TabControlAlbum.SelectedTab.Text].Remove(musicDic[TabControlAlbum.SelectedTab.Text][pos]);
                listView.Items.Clear();
                where = status.Album;
                for (int i = 0; i < musicDic[TabControlAlbum.SelectedTab.Text].Count; i++)
                {
                    listView.Items.Add(musicDic[TabControlAlbum.SelectedTab.Text][i].Name);
                }
                if (musicDic[TabControlAlbum.SelectedTab.Text].Count > 0)
                {
                    play(musicDic[TabControlAlbum.SelectedTab.Text], pos);
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
            music tmp = Search.linear(musicCur, new music(richTextBox1.Text, ""));
            if (tmp != null)
            {
                axWindowsMediaPlayer1.Hide();
                listView.Items.Clear();
                searchResult.Add(tmp);
                listView.Items.Add(tmp.Name);
                where = status.Search;
                pos = 0;
                btnDelete.Show();
                listView.Show();
            }
            else
            {
                listView.Items.Clear();
            }
        }

        private void btnAlbumList_Click(object sender, EventArgs e)
        {
            panel6.Show();
            axWindowsMediaPlayer1.Hide();
            TabControlAlbum.Show();
            TabControlAlbum.SelectTab(CurrListPage);
            listView.Items.Clear();
            btnDelete.Show();
            btnAddToAlbum.Show();
            where = status.Curr;
            pos = 0;
            for (int i = 0; i < musicCur.Count; i++)
            {
                listView.Items.Add(musicCur[i].Name);
            }
            CurrListPage.Controls.Add(listView);
            listView.Visible = true;
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
                    AlbumName.Add(tabName);
                    musicDic.Add(tabName, new LIST<music>());
                    string[] name = { tabName };
                    File.AppendAllLines("NameAlbum", name);
                    // Chuyển đến tabPage mới
                    TabControlAlbum.SelectedTab = newTab;
                    TabControlAlbum.Show();
                }
            }
        }

        private void TabControlAlbum_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlAlbum.SelectedTab == CurrListPage)
            {
                panel6.Show();
                listView.Items.Clear();
                where = status.Curr;
                btnDelete.Show();
                btnAddFav.Show();
                btnSortFav.Hide();
                btnAddToAlbum.Show();
                pos = 0;
                for (int i = 0; i < musicCur.Count; i++)
                {
                    listView.Items.Add(musicCur[i].Name);
                }
                CurrListPage.Controls.Add(listView);
                listView.Visible = true;
            }
            else if (TabControlAlbum.SelectedTab == FavouritePage)
            {
                listView.Items.Clear();
                panel6.Hide();
                btnAddFav.Hide();
                btnSortFav.Show();
                where = status.Fav;
                btnDelete.Hide();
                btnAddToAlbum.Hide();
                pos = 0;
                for (int i = 0; i < musicFav.Count; i++)
                {
                    listView.Items.Add(musicFav[i].Name);
                }
                FavouritePage.Controls.Add(listView);
                listView.Visible = true;
            }
            else
            {
                LIST<music> temp = musicDic[TabControlAlbum.SelectedTab.Text];
                listView.Items.Clear();
                panel6.Hide();
                btnSortFav.Hide();
                where = status.Album;
                btnDelete.Show();
                btnAddFav.Hide();
                btnAddToAlbum.Hide();
                pos = 0;
                for (int i = 0; i < temp.Count; i++)
                {
                    listView.Items.Add(temp[i].Name);
                }
                TabControlAlbum.SelectedTab.Controls.Add(listView);
                TabControlAlbum.SelectedTab.Controls.Add(btnDeletePage);
                listView.Visible = true;
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
                    File.Delete(TabControlAlbum.SelectedTab.Text);
                    UpdateList.UpdateAlbum(TabControlAlbum);
                    if (currentIndex > 0)
                        TabControlAlbum.SelectedTab = TabControlAlbum.TabPages[currentIndex - 1];
                }
            }
        }

        private void btnAddToAlbum_Click(object sender, EventArgs e)
        {
            if (AlbumName.Count > 0 && musicCur.Count > 0)
            {
                using (Menu SelecteAlbum = new Menu(AlbumName.toArray()))
                {
                    if (SelecteAlbum.ShowDialog() == DialogResult.Yes)
                    {
                        string Selected = SelecteAlbum.SelectedAlbum;
                        if (Selected != "")
                        {
                            if (musicDic[Selected].IndexOfItem(musicCur[pos]) == -1)
                            {
                                musicDic[Selected].Add(musicCur[pos]);
                                string[] sing = { musicCur[pos].Name, musicCur[pos].Path, "false" };
                                if (musicCur[pos].Fav == true)
                                    sing[2] = "true";
                                File.AppendAllLines(Selected, sing);
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iconcheck.Hide();
            string filePath = "ListMusic.txt";

            if (File.Exists(filePath))
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        music tam = new music();
                        tam.Name = line;
                        line = reader.ReadLine();
                        tam.Path = line;
                        line = reader.ReadLine();
                        tam.Fav = false;
                        if (line == "true")
                        {
                            tam.Fav = true;
                            musicFav.Add(tam);
                        }
                        musicCur.Add(tam);
                    }
                }
            }
            string fileAlbum = "NameAlbum";

            if (File.Exists(fileAlbum))
            {
                using (StreamReader reader = new StreamReader(fileAlbum))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string tabName = line;
                        // Tạo một tabPage mới với tên từ người dùng
                        TabPage newTab = new TabPage(tabName);
                        // Thêm tabPage mới vào TabControl
                        TabControlAlbum.TabPages.Add(newTab);
                        //creat a new music list
                        AlbumName.Add(tabName);
                        musicDic.Add(tabName, new LIST<music>());
                        string fileMusic = tabName;
                        if (File.Exists(fileMusic))
                        {
                            using (StreamReader readerMusic = new StreamReader(fileMusic))
                            {
                                string lineMusic;
                                while ((lineMusic = readerMusic.ReadLine()) != null)
                                {
                                    music tam1 = new music();
                                    tam1.Name = lineMusic;
                                    lineMusic = readerMusic.ReadLine();
                                    tam1.Path = lineMusic;
                                    lineMusic = readerMusic.ReadLine();
                                    tam1.Fav = false;
                                    if (lineMusic == "true")
                                    {
                                        tam1.Fav = true;
                                    }
                                    musicDic[line].Add(tam1);

                                }
                            }
                        }
                    }
                }
            }
            string fileFav = "Favourite.txt";
            LIST<string> tmp = new LIST<string>();
            if (File.Exists(fileFav))
            {
                using (StreamReader readerFav = new StreamReader(fileFav))
                {
                    string line;
                    while ((line = readerFav.ReadLine()) != null)
                    {
                        tmp.Add(line);
                        line = readerFav.ReadLine();
                        tmp.Add(line);
                    }
                }
            }
            bool[] check = new bool[musicFav.Count];
            for (int i=0; i<tmp.Count; i++)
            {
                for (int j=0; j<musicFav.Count; j++)
                {
                    if (string.Compare(musicFav[j].Name, tmp[i]) == 0 && check[j]==false)
                    {
                        tempFav.Add(musicFav[j]);
                        check[j] = true;
                        break;

                    }
                }
            }
            for (int i = 0; i < musicFav.Count; i++)
            {
                musicFav[i] = tempFav[i];
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            UpdateList.UpdateMusic(musicCur);
            UpdateList.UpdateFav(musicFav);
            UpdateList.UpdateFileAlbum(TabControlAlbum,musicDic);
        }

        private void btnRepeat_Click_1(object sender, EventArgs e)
        {
            if (iconcheck.IconChar == FontAwesome.Sharp.IconChar.None)
            {
                iconcheck.IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
                iconcheck.Show();
                repeat = true;
            }
            else
            {
                iconcheck.IconChar = FontAwesome.Sharp.IconChar.None;
                iconcheck.Hide();
                repeat = false;
            } 
        }

        #region event Kéo thả
        // biến để lưu trữ mục đang được kéo
        System.Windows.Forms.ListViewItem draggingItem = null;
        private void listView_MouseDown(object sender, MouseEventArgs e)
        {
            // sử dụng phương thức HitTest để xác định mục mà người dùng đã nhấp chuột vào
            ListViewHitTestInfo info = listView.HitTest(e.X, e.Y);
            if (info.Item != null)
            {
                draggingItem = info.Item;
         // bắt đầu quá trình kéo và thả, chỉ định rằng người dùng đang muốn di chuyển mục
                listView.DoDragDrop(draggingItem, DragDropEffects.Move);
            }
        }
        // sự kiện xảy ra khi mục được kéo đến ListView
        private void listView_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        // Sự kiện xảy ra khi mục đang được kéo di chuyển trên ListView
        private void listView_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
        // Sự kiện xảy ra khi mục được thả vào ListView
        private void listView_DragDrop(object sender, DragEventArgs e)
        {
            // xác định vị trí thả của mục trong ListView
            Point point = listView.PointToClient(new Point(e.X, e.Y));
            // xác định mục mà mục đang được kéo sẽ được thả vào
            System.Windows.Forms.ListViewItem targetItem = listView.GetItemAt(point.X, point.Y);

            if (targetItem != null && draggingItem != null)
            {
                int targetIndex = targetItem.Index;
                if (draggingItem.Index != targetIndex)
                {
                    if (where == status.Curr)
                    {
                        music tmp = musicCur[draggingItem.Index];
                        musicCur.Remove(musicCur[draggingItem.Index]);
                        musicCur.insert(targetIndex, tmp);
                    }
                    else if (where == status.Fav)
                    {
                        music tmp = musicFav[draggingItem.Index];
                        musicFav.Remove(musicFav[draggingItem.Index]);
                        musicFav.insert(targetIndex, tmp);
                    }
                    else
                    {
                        music tmp = musicDic[TabControlAlbum.SelectedTab.Text][draggingItem.Index];
                        musicDic[TabControlAlbum.SelectedTab.Text].Remove(musicDic[TabControlAlbum.SelectedTab.Text][draggingItem.Index]);
                        musicDic[TabControlAlbum.SelectedTab.Text].insert(targetIndex, tmp);
                    }
                    listView.Items.Remove(draggingItem);
                    listView.Items.Insert(targetIndex, draggingItem);
                }
            }
            listView_DoubleClick(sender, e);
            draggingItem = null;           
        }
        #endregion
    }
}

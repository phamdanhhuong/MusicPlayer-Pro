using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Hide();
            axWindowsMediaPlayer1.Hide();
            listBox.Hide();
            axWindowsMediaPlayer1.settings.volume = 0;
            btnSortFav.Hide();
            btnDelete.Hide();
        }
        LIST<music> musicCur = new LIST<music>();
        LIST<music> musicFav = new LIST<music>();
        LIST<music> searchResult = new LIST<music>();
        List<music> temp;
        int pos = 0;
        bool search = false;
        bool isFav = false;
        private void Hide()
        {
            panelMedia.Visible = false;
        }
        private void Show()
        {
            if (panelMedia.Visible == false)
            {
                panelMedia.Visible = true;
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            if (panelMedia.Visible == true)
            {
                Hide();
            }
            else
            {
                Show();
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
                    if (isFav == true)
                    {
                        play(musicFav, pos);
                    }
                    else if (isFav == false)
                    {
                        play(musicCur, pos);
                    }
                }
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
            }
        }

        private void btnCurList_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Hide();
            listBox.Items.Clear();
            isFav = false;
            pos = 0;
            temp=musicCur.toList();
            foreach (music cur in temp)
            {
                listBox.Items.Add(cur.Name);
            }
            btnSortFav.Hide();
            btnDelete.Show();
            listBox.Show();
        }

        private void btnAddFav_Click(object sender, EventArgs e)
        {
            if(musicCur[pos].Fav == false)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                musicCur[pos].Fav = true;
                music temp = musicCur[pos];
                temp.Fav = true;
                if (musicFav.IndexOfItem(temp)!=-1)
                    musicFav.Add(temp);
            }
            else if(musicCur[pos].Fav == true)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.Heart;
                musicCur[pos].Fav = false;
                musicFav.Remove(musicCur[pos]);
            }
        }

        private void btnFavList_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Hide();
            listBox.Items.Clear();
            isFav = true;
            pos = 0;
            temp = musicFav.toList();
            foreach (music fav in temp)
            {
                listBox.Items.Add(fav.Name);
            }
            btnSortFav.Show();
            btnDelete.Hide();
            listBox.Show();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex > -1)
            {
                pos = listBox.SelectedIndex;
                if (search == true)
                {
                    play(searchResult, pos);
                    search = false;
                }
                else if (isFav == true)
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
            if (isFav == true)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                btnDelete.Hide();
            }
            else
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
        }
        private void btnPre_Click(object sender, EventArgs e)
        {
            pre();
        }
        private void pre()
        {
            if (isFav == true)
            {
                if (pos == 0)
                    pos = musicFav.Count - 1;
                else if (pos > 0)
                    pos--;
                play(musicFav, pos);
            }
            else if (isFav == false)
            {
                if (pos == 0)
                    pos = musicCur.Count - 1;
                else if (pos > 0)
                    pos--;
                play(musicCur, pos);
            }
            update();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            next();
        }
        private void next()
        {
            if (isFav == true)
            {
                if (pos == musicFav.Count - 1)
                    pos = 0;
                else
                    pos++;
                play(musicFav, pos);
            }
            else if (isFav == false)
            {
                if (pos == musicCur.Count - 1)
                    pos = 0;
                else
                    pos++;
                play(musicCur, pos);
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
            btnSortFav.Hide();
            listBox.Hide();
        }

        private void btnSortFav_Click(object sender, EventArgs e)
        {
            if(btnSortFav.IconChar==FontAwesome.Sharp.IconChar.SortAlphaUp)
            {
                Sort.InterchangeSort(musicFav);
                listBox.Items.Clear();
                pos = 0;
                temp = musicFav.toList();
                foreach (music fav in temp)
                {
                    listBox.Items.Add(fav.Name);
                }
                btnSortFav.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUpAlt;
                listBox.Show();
            }
            else
            {
                Sort.InterchangeSortRev(musicFav);
                listBox.Items.Clear();
                pos = 0;
                temp = musicFav.toList();
                foreach (music fav in temp)
                {
                    listBox.Items.Add(fav.Name);
                }
                btnSortFav.IconChar = FontAwesome.Sharp.IconChar.SortAlphaUp;
                listBox.Show();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

            DialogResult = MessageBox.Show("Bạn có muốn xóa bài này", "Xóa", MessageBoxButtons.YesNo);
            if (DialogResult == DialogResult.Yes)
            {
                musicCur.Remove(musicCur[pos]);
                listBox.Items.Clear();
                isFav = false;
                pos = 0;
                temp = musicCur.toList();
                foreach (music cur in temp)
                {
                    listBox.Items.Add(cur.Name);
                }
                btnDelete.Show();
                listBox.Show();
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
                isFav = false;
                search = true;
                pos = 0;
                btnDelete.Show();
                listBox.Show();
            }
            else
            {
                listBox.Items.Clear();
            }
        }
    }
}

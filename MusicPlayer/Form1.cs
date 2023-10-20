using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        }
        List<music> musicCur = new List<music>();
        List<music> musicFav = new List<music>();
        bool isFav=false;
        int pos = 0;
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

        private void play(List<music> a,int vt) 
        {
            if (a != null)
            {
                btnPlay.IconChar = FontAwesome.Sharp.IconChar.Pause;
                axWindowsMediaPlayer1.URL = a[vt].Path;
                axWindowsMediaPlayer1.Show();
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
                    if (checkVar(musicFav, temp)==true)
                    {
                        musicCur.Add(temp);
                    }
                }
            }
        }
        private bool checkVar(List<music> a,music item)
        {
            foreach (music m in a)
            {
                if(item.Path==m.Path)
                    return false;
            }
            return true;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(musicCur.Count > 0)
            {
                play(musicCur, pos);
            }
        }

        private void btnCurList_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Hide();
            listBox.Items.Clear();
            isFav = false;
            foreach (music cur in musicCur)
            {
                listBox.Items.Add(cur.Name);
            }
            listBox.Show();
        }

        private void btnAddFav_Click(object sender, EventArgs e)
        {
            if(musicCur[pos].Fav == false)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                musicCur[pos].Fav = true;
                musicFav.Add(musicCur[pos]);
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
            foreach (music fav in musicFav)
            {
                listBox.Items.Add(fav.Name);
            }
            listBox.Show();
        }

        private void listBox_DoubleClick(object sender, EventArgs e)
        {
            if(listBox.SelectedIndex > -1)
            {
                if(isFav == true)
                {
                    pos= listBox.SelectedIndex;
                    play(musicFav, listBox.SelectedIndex);
                    btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                }
                else
                {
                    pos = listBox.SelectedIndex;
                    play(musicCur, listBox.SelectedIndex);
                    if (musicCur[listBox.SelectedIndex].Fav)
                    {
                        btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
                    }
                    else
                    {
                        btnAddFav.IconChar = FontAwesome.Sharp.IconChar.Heart;
                    }
                }
            }
        }

        private void btnPre_Click(object sender, EventArgs e)
        {
            if (isFav == true)
            {
                if (pos == 0)
                    pos = musicFav.Count - 1;
                else if(pos>0)
                    pos--;
                play(musicFav, pos);
            }
            else if(isFav == false)
            {
                if (pos == 0)
                    pos = musicCur.Count - 1;
                else if (pos > 0)
                    pos--;
                play(musicCur, pos);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
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
        }
    }
}

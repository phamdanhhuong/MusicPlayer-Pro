﻿using System;
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
                axWindowsMediaPlayer1.Show();
                axWindowsMediaPlayer1.URL = a[vt].Path;
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
                }
                else
                {
                    pos = listBox.SelectedIndex;
                    play(musicCur, listBox.SelectedIndex);
                }
                update();
            }
        }

        private void update()
        {
            if (isFav == true)
            {
                btnAddFav.IconChar = FontAwesome.Sharp.IconChar.HeartCircleCheck;
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
    }
}

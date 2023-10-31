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
    public partial class Menu : Form
    {
        public string SelectedAlbum = default;
        string[] albums;
        public Menu(string[] album)
        {
            InitializeComponent();
            albums = album;
        }
        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            SelectedAlbum= albums[listBox1.SelectedIndex];
            DialogResult = MessageBox.Show("Xác nhận chọn " + albums[listBox1.SelectedIndex], "Chọn album", MessageBoxButtons.YesNo);
            if(DialogResult == DialogResult.Yes)
                this.Close();   
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            foreach (string album in albums)
            {
                listBox1.Items.Add(album);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}

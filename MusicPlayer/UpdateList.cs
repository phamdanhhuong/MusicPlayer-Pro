using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace MusicPlayer
{
    internal class UpdateList
    {
        public static void UpdateMusic(LIST<music> mySong)
        {
            int n = mySong.Count;
            File.Delete("ListMusic.txt");
            for (int i = 0; i < n; i++)
            {
                string fav = "false";
                if (mySong[i].Fav == true)
                {
                    fav = "true";
                }
                string[] tam = { mySong[i].Name, mySong[i].Path, fav };
                File.AppendAllLines("ListMusic.txt", tam);
            }
        }
        public static void UpdateFav(LIST<music> mySong)
        {
            int n = mySong.Count;
            File.Delete("Favourite.txt");
            for (int i = 0; i<n; i++)
            {
                string[] temp = { mySong[i].Name };
                File.AppendAllLines("Favourite.txt", temp);
            }
        }
        public static void UpdateAlbum(System.Windows.Forms.TabControl tabControlAlbum)
        {
            File.Delete("NameAlbum");
            for (int i = 2; i < tabControlAlbum.TabCount; i++)
            {
                string[] name = { tabControlAlbum.TabPages[i].Text };
                File.AppendAllLines("NameAlbum", name);
            }
        }
        public static void UpdateFileAlbum(System.Windows.Forms.TabControl tabControlAlbum, Dictionary<string, LIST<music>> musicDic)
        {
            for (int i = 2; i < tabControlAlbum.TabCount; i++)
            {
                string nameAlbum =  tabControlAlbum.TabPages[i].Text ;
                File.Delete(nameAlbum);
                int n = musicDic[nameAlbum].Count;
                for (int j = 0; j < n; j++)
                {
                    string[] sing = { musicDic[nameAlbum][j].Name, musicDic[nameAlbum][j].Path, "false" };
                    if (musicDic[nameAlbum][j].Fav == true)
                    {
                        sing[2] = "true";
                    }
                    File.AppendAllLines(nameAlbum, sing);
                }

            }
        }
    }
}

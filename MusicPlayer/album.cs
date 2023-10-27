using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class album
    {
        LIST<music> musicList=new LIST<music>();
        string albumName;
        public LIST<music> MusicList { get { return musicList; } }
        public string AlbumName { get => albumName; set => albumName = value; }
        public album(string name,LIST<music>a)
        {
            albumName = name;
            musicList = a;  
        }
        public album() { }
        public void Add(music a)
        {
            musicList.Add(a);
        }
    }
}

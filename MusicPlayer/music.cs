using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class music
    {
        string name;
        string path;
        bool fav;

        public string Name { get => name; set => name = value; }
        public string Path { get => path; set => path = value; }
        public bool Fav { get => fav; set => fav = value; }
        public music(string name, string path)
        {
            Name = name;
            Path = path;
            Fav = false;
        }
        public music() { }
    }
}

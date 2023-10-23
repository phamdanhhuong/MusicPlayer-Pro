using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace MusicPlayer
{
    internal class Search
    {
        public static music BinarySearch(LIST<music> mySong, music x)
        {
            int l = 0, r = mySong.Count - 1;
            int m;
            while (l <= r)
            {
                m = (l + r) / 2;
                if (string.Compare(mySong[m].Name, x.Name) == 0)
                    return mySong[m];
                if (string.Compare(mySong[m].Name, x.Name) > 0)
                    r = m - 1;
                else
                    l = m + 1;
            }
            return null;
        }
        public static music linear(LIST<music> mySong, music x)
        {
            for (int i = 0; i < mySong.Count; i++)
            {
                if (string.Compare(mySong[i].Name , x.Name) == 0)
                {
                    return mySong[i];
                }
            }
            return null;
        }
    }
}
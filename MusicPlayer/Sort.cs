using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayer
{
    internal class Sort
    {
        static int Compare(string a, string b)
        {
            for (int i = 0; i < max(a.Length, b.Length); i++)
            {
                if (a[i] > b[i])
                    return 1;
                else if (a[i] < b[i])
                    return -1;

            }
            return 0;
        }
        static int max(int a, int b)
        {
            if (a > b)
                return a;
            else
                return b;
        }
        public static void InterchangeSort(LIST<music> mySong)
        {
            int n = mySong.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    int a = string.Compare(mySong[i].Name, mySong[j].Name);
                    if (a > 0)
                    {
                        music tam = mySong[i];
                        mySong[i] = mySong[j];
                        mySong[j] = tam;
                    }
                }
        }
        public static void InterchangeSortRev(LIST<music> mySong)
        {
            int n = mySong.Count;
            for (int i = 0; i < n - 1; i++)
                for (int j = i + 1; j < n; j++)
                {
                    int a = string.Compare(mySong[i].Name, mySong[j].Name);
                    if (a < 0)
                    {
                        music tam = mySong[i];
                        mySong[i] = mySong[j];
                        mySong[j] = tam;
                    }
                }
        }
        public static void BubbleSort(LIST<music> mySong)
        {
            int n = mySong.Count;
            int flag = 1;
            int j = 0;
            while (flag==1)
            {
                flag = 0;
                j++;
                for (int i = 0; i < n - j; i++)
            {
                    if (string.Compare(mySong[i].Name, mySong[i+1].Name)>0)
                    {
                        music temp = mySong[i];
                        mySong[i] = mySong[i + 1];
                        mySong[i + 1] = temp;
                        flag = 1;
                    }
                }
            }
        }
        public static void quickSort(LIST<music> mySong, int l, int r)
        {
            int i = l, j = r;
            string x = mySong[(l + r) / 2].Name;
            while (i <= j)
            {
                while (string.Compare(mySong[i].Name, x) < 0)
                    i++;
                while (string.Compare(mySong[j].Name, x) > 0)
                    j--;
                if (i <= j)
                {
                    music temp = mySong[i];
                    mySong[i] = mySong[j];
                    mySong[j] = temp;
                    i++;
                    j--;
                }
            }
            if (l < j)
                quickSort(mySong, l, j);
            if (i < r)
                quickSort(mySong, i, r);
        }
        public static void InsertionSortMaxToMin(LIST<music> mySong)
        {
            int n = mySong.Count;
            for (int i = 1; i < n; i++)
            {
                int j = i - 1;
                music tmp = mySong[i];
                while (j >= 0 && string.Compare(mySong[j].Name, tmp.Name) < 0)
                {
                    mySong[j + 1] = mySong[j];
                    j--;
                }
                mySong[j + 1] = tmp;
            }
        }
    }

}
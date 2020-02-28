using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercise302_ExtensionMethods
{
    public static class ListExtension
    {
        public static T GetRandomElement<T>(this List<T> list)
        {
            return list[new Random().Next(0, list.Count)];
        }

        public static void ShuffleList<T>(this List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = new Random().Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

    }
}

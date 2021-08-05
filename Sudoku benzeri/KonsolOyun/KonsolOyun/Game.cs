using System;
using System.Collections.Generic;
using System.Text;

namespace KonsolOyun
{
    class Game
    {
        
        

        public int[] Karistir(int[] array)
        {
            Random r = new Random();
            for (int i = array.Length; i > 0; i--)
            {
                int j = r.Next(i);
                int k = array[j];
                array[j] = array[i - 1];
                array[i - 1] = k;
            }
            return array;
            
        }
        

    }
}



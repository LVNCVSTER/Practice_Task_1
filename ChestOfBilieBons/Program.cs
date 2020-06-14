using System;
using System.Linq;
using System.IO;

namespace ChestOfBilieBons
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StreamReader sr = new StreamReader("input.txt");
            StreamWriter wr = new StreamWriter("output.txt");
            string xy = (sr.ReadLine());
            string[] number = xy.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    int X, Y;
                    X = Convert.ToInt32(number[0]);
                    Y = Convert.ToInt32(number[1]);
                    int[] Arr = new int[X];
                    //перебираем 2 элемент
           if (X <= 20 && Y <= 32767 && X > 2 && Y > 0)
              for (int second = 0; second < Y - second; second++)
              { //Перебираем 1 элемент
                for (int first = second + 1; first < Y - second; first++)
                {
                   Arr[0] = first;
                   Arr[1] = second;
                   for (int i = 2; i < X; i++)
                   {
                     Arr[i] = Arr[i - 1] + Arr[i - 2];
                   }
                   if (Arr.Last() == Y)
                   {
                     wr.WriteLine(first + " " + second);
                   }
                }

              }
            else
            {
                wr.WriteLine("0");
            }
        }
    }
}
 

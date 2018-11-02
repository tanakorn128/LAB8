using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ตรวจสอบความกว้างarray
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] GPS = new float [8];
            int[] N = new int[8];
            try
            {
                for (int i = 0,num=1; i< GPS.Length;i++,num++)
                {
                 
                    Console.WriteLine("input GPS term {0}",num);
                    GPS[i] = float.Parse(Console.ReadLine());
                    Console.WriteLine("Input N term{0}",num);
                    N[i] = int.Parse(Console.ReadLine());

                    Console.WriteLine("GPS  = {0}", GPS[i]);
                    Console.WriteLine("N = {0}",N[i]);

                }
            }
            catch { }
            
        }
    }
}

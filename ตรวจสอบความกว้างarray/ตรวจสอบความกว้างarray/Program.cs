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
            for (int i = 0; i < GPS.Length; i++)
            {
                GPS[i] = Convert.ToInt32(Console.ReadLine());i++;
                Console.WriteLine("input GPS {0}",i);i--;


            }
            Console.WriteLine("input GPA");
        }
    }
}

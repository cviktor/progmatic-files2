using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File
{
    class Program
    {
        static void Main(string[] args)
        {
            //relat�v el�r�si �t az exe f�jl hely�t�l
            //FileStream file = new FileStream(@"..\..\hello.txt", FileMode.Open);
            //abszol�t el�r�si �t (egy meghajt� n�vvel kezd�dik �s mindig ugyan oda mutat mindegy hol az exe)
            FileStream file = new FileStream(@"F:\Projects\Progmatic\2018-07-23\File\File\hello.txt", FileMode.Open);


            for (int i = 0; i < 5; i++)
            {
                int b = file.ReadByte();
                Console.WriteLine(b);
                Console.WriteLine((char)b);
            }


            Console.ReadKey();
        }
    }
}

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


            //for (int i = 0; i < 6; i++)
            //{
            //    int b = file.ReadByte(); //int-et ad vissza mert a f�jl v�g�n -1-et fog vissz adni ami ugye nem egy �rv�nyes byte �rt�k
            //    Console.WriteLine(b);
            //    Console.WriteLine((char)b);
            //}

            while(file.Position < file.Length)
            {
                int b = file.ReadByte();
                Console.WriteLine(b);
                Console.WriteLine((char)b);
            }

            Console.ReadKey();
        }
    }
}

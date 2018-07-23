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
            //relatív elérési út az exe fájl helyétõl
            //FileStream file = new FileStream(@"..\..\hello.txt", FileMode.Open);
            //abszolút elérési út (egy meghajtó névvel kezdõdik és mindig ugyan oda mutat mindegy hol az exe)
            FileStream file = new FileStream(@"F:\Projects\Progmatic\2018-07-23\File\File\hello.txt", FileMode.Open);


            //for (int i = 0; i < 6; i++)
            //{
            //    int b = file.ReadByte(); //int-et ad vissza mert a fájl végén -1-et fog vissz adni ami ugye nem egy érvényes byte érték
            //    Console.WriteLine(b);
            //    Console.WriteLine((char)b);
            //}

            //while (file.Position < file.Length)
            //{
            //    int b = file.ReadByte();
            //    Console.WriteLine(b);
            //    Console.WriteLine((char)b);
            //}

            //file.Seek(-1, SeekOrigin.End);
            ////file.Seek(-2, SeekOrigin.Current);
            //int b = file.ReadByte();
            //Console.WriteLine(b);
            //Console.WriteLine((char)b);

            //ha nem állítunk Position-t akkor az elsõ karaktert írná felül
            file.Seek(0, SeekOrigin.End);
            file.WriteByte((byte)'!');

            Console.ReadKey();
        }
    }
}

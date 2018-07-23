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
            StreamWriter sw = new StreamWriter(file);

            //for (int i = 0; i < 6; i++)
            //{
            //    int b = file.ReadByte(); //int-et ad vissza mert a f�jl v�g�n -1-et fog vissz adni ami ugye nem egy �rv�nyes byte �rt�k
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

            //ha nem �ll�tunk Position-t akkor az els� karaktert �rn� fel�l
            //file.Seek(0, SeekOrigin.End);
            //file.WriteByte((byte)'!');
            try
            {
                WriteHello(sw);

            }
            catch
            {
                Console.WriteLine("hiba t�rt�nt");
            }

            sw = null;
            file = null;

            Console.ReadKey();
        }

        private static void WriteHello(StreamWriter sw)
        {
            try
            {
                sw.BaseStream.Seek(0, SeekOrigin.End);
                sw.Write("hello");
                sw.Write("world");
                sw.Write("!!!");
                throw new Exception();
            }
            finally
            {
                sw.Flush(); //bufferel�s miatt kell
                sw.Close(); //ezzel jelezz�k hogy a f�jlt m�r nem haszn�ljuk t�bbet
                            //sw.Write("hiba"); hib�t fog dobni mert m�r lez�rtuk
            }
        }
    }
}

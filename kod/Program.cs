using System;
using System.IO;

namespace kod
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath=@"C:\Users\Admin\Desktop\Summa Program\Summa.txt";
            StreamReader sr = new StreamReader(filepath);


            String red;
            int summa = 0;
            int fem = 0;
            while ((red = sr.ReadLine()) != null){
                summa +- int.Parse(red);
                

            }





























        }
    }
}

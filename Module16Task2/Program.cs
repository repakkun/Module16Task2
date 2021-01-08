using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Module16Task2
{
    class Program
    {          
        static void Main(string[] args)
        {
            Console.WriteLine("Введите путь до папки");
            string folderName = Console.ReadLine();
            DirectoryInfo directoryInfo = new DirectoryInfo(folderName);               
            try
            {              
                Console.WriteLine($"Размер = {DirectorySize(directoryInfo)}");        
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
        public static long DirectorySize(DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] files = d.GetFiles();
            foreach (FileInfo f in files)
            {
                size += f.Length;
            }
            DirectoryInfo[] dis = d.GetDirectories();
            foreach (DirectoryInfo di in dis)
            {
                size += DirectorySize(di);
            }
            return size;
        }
         
    }
}

using System;
using System.IO;

namespace FileHandling
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string path = @"D://";
            Console.WriteLine("Enter Foler Name?");

            #pragma warning disable CS8600
            string dname= Console.ReadLine();
            #pragma warning restore CS8600

            #pragma warning disable CS8604 
            string fullpath = Path.Combine(path, dname);
            #pragma warning restore CS8604
            

            //-----------Creating Directry-------------

            if (!Directory.Exists(fullpath))
            {
                Directory.CreateDirectory(fullpath);
                Console.WriteLine("Folder Created Successfully!");
            }
            else
            {
                Console.WriteLine("Folder Already Exist!");
            }

            //-------Delete Directry------------------

            /*
            if (Directory.Exists(fullpath))
            {
                Directory.CreateDirectory(fullpath);
                Console.WriteLine("Folder Deleted Successfully!");
            }
            else
            {
                Console.WriteLine("Folder Not Exist!");
            }*/
        }
    }
}

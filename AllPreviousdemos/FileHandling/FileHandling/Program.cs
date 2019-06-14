using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileHandling
{
    class Program
    {
        public static void StreamReadWriteDemo()
        {
            if (File.Exists("D:\\Data.txt"))
            {
                Console.WriteLine("File already exists");
            }

            StreamWriter sWriter = new StreamWriter("D:\\Data.txt");
            sWriter.WriteLine("This file is created using StreamWriter class");
            sWriter.WriteLine("Demo of writing file using StreamWriter class");
            sWriter.Close();

            if (File.Exists("D:\\Data.txt"))
            {
                Console.WriteLine("File already exists");
            }
            //usinf File static class
            StreamReader sReader = File.OpenText("D:\\Data.txt");
            string txt;
            while ((txt = sReader.ReadLine()) != null)
            {
                Console.WriteLine(txt);
            }

            Console.WriteLine("End of stream");
            sReader.Close();
           
            

        }
        public static void BasicIODemo()
        {
            // Uses Directory static class
            Console.WriteLine("Directory");
            string[] dir = Directory.GetDirectories(@"C:\SportsApplication");
            foreach (string s in dir)
            {
                Console.WriteLine(s);
            }
            // Uses Directory static class
            string[] dirfiles = Directory.GetFiles("C:\\SportsApplication");
            foreach (string s in dirfiles)
            {
                Console.WriteLine(s);
            }

            string[] logdrive = Directory.GetLogicalDrives();
            Console.WriteLine(logdrive.Length);
            foreach (string s in logdrive)
            {
                Console.WriteLine(s);
            }
            // Uses DirectoryInfo class
            Console.WriteLine("Directory Info class");
            DirectoryInfo d = new DirectoryInfo("c:\\");
            Console.WriteLine("Name: " + d.Name);
            Console.WriteLine("Parent: " + d.Parent);
            Console.WriteLine("Root: " + d.Root);
            Console.WriteLine("Creation Time: " + d.CreationTime);
            Console.WriteLine("Full Name: " + d.FullName);
            // Uses File static class
            string filePath = "D:\\Data.txt";
            if (File.Exists(filePath))
            {
                Console.WriteLine("File already exits");
            }
            else
            {
                File.Create(filePath);

                Console.WriteLine("File created");
            }
            
          }

        public static void UsingFileInfo()
        {
            string path = @"D:\\DemoTest.txt";//Path.GetTempFileName();
            FileInfo fi1 = new FileInfo(path);

            //Create a file to write to.
            using (StreamWriter sw = fi1.CreateText())
            {
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
            }

            //Open the file to read from.
            using (StreamReader sr = fi1.OpenText())
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

        }
     
        public static void BinaryReadWriteDemo()
        {

            FileStream fs = new FileStream(@"D:\\myfile.txt", FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write("This is Binaray Writer Demo");
            bw.Write(100);
            bw.Close();
            fs.Close();

            fs = new FileStream(@"D:\\myfile.txt", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);
            Console.WriteLine(br.ReadString().ToString());// Read string
            Console.WriteLine(br.ReadInt32().ToString()); // Read Integer 100
            br.Close();
            fs.Close();
        }
        static void Main(string[] args)
        {
            //BasicIODemo();
           // StreamReadWriteDemo();
           //  BinaryReadWriteDemo();
             UsingFileInfo();

            Console.WriteLine("Press any key to exit");
            Console.ReadLine();
        }
    }
}

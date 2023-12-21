using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PracticeDec20_2pm
{
    public class Employee
    {
        private string name = "Suresh";
        public string M1
        {
            get { return name; }
            set { name = value; }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.M1 = "Naresh";
            //Console.WriteLine(employee.M1);
            Assembly ass = Assembly.LoadFile("C:\\Windows\\Microsoft.NET\\Framework64\\v4.0.30319\\System.dll");
            foreach (Type asm in ass.GetTypes())
            {
                // Console.WriteLine(asm);
            }
            //Console.ReadLine();


            //----------------------------------------------------------------------------------\\

            /*Files*/
            //wArWithFileStream();
            //FileCreateread();
            //fileFunctions();
            //directries();
            fileInfo();
        }
        public static void FileCreateread() {
            StreamWriter write = new StreamWriter("C:\\Users\\dell\\source\\repos\\Files\\suresh.text", true);
            write.WriteLine("Hii suresh");
            write.Close();
            StreamReader read = new StreamReader("C:\\Users\\dell\\source\\repos\\Files\\suresh.text");
            string s = read.ReadToEnd();
            Console.WriteLine(s);
            read.Close();

        } 
        public static void wArWithFileStream()
        {
            FileStream fs=new FileStream("C:\\Users\\dell\\source\\repos\\Files\\file.txt",FileMode.Create,FileAccess.Write);
            StreamWriter writer=new StreamWriter(fs);
            writer.WriteLine("hii\nBye");
            writer.Close();

            FileStream f=new FileStream("C:\\Users\\dell\\source\\repos\\Files\\file.txt",FileMode.Open,FileAccess.Read);
            StreamReader read=new StreamReader(f);
            string s1 = read.ReadToEnd();
            Console.WriteLine(s1);
            fs.Close();
            f.Close();
        }
        public static void fileFunctions()
        {
            String path = "C:\\Users\\dell\\source\\repos\\Files\\data.txt";
            if (File.Exists(path))
            {
                StreamReader sr=File.OpenText(path);
                String str= sr.ReadToEnd();
                Console.WriteLine("File is found so we read"+str);
                sr.Close();
            }
            else
            {
                StreamWriter sw=new StreamWriter(path);
                sw.WriteLine("File not found so we write");
                sw.Close();
            }
            DateTime d=File.GetCreationTime(path);
            Console.WriteLine(d);
            //StreamWriter sd=File.AppendText(path);
            //File.Move(path, "C:\\Users\\dell\\source\\repos\\Console_codes\\database.txt");
            //File.Copy("C:\\Users\\dell\\source\\repos\\Console_codes\\database.txt", "C:\\Users\\dell\\source\\repos\\Files\\suresh.txt");
            File.Delete("C:\\Users\\dell\\source\\repos\\Files\\suresh.txt");

        }
        public static void directries()
        {
            //string path = "c:\\Users\\Desktop";
            //Directory .CreateDirectory(path);
            //if (Directory.Exists(path))
            //{
            //    Directory.Delete(path);
            //}
            //else
            //{
            //    Console.WriteLine("Directory was not found");
            //}
            String[] str = Directory.GetFiles("c:\\windows");
            foreach(String str2 in str)
            {
                //Console.WriteLine(str2);
            }
            string[] s = Directory.GetDirectories("c:\\");
            foreach (String str3 in s)
            {
               // Console.WriteLine(str3);
            }

        }
        public static void fileInfo()
        {
            FileInfo f = new FileInfo("C:\\Users\\dell\\source\\repos\\Console_codes\\details.txt");
            string s = f.Extension;
            long size=f.Length;
            Console.WriteLine($"File extension is {s}\nFile size is {size}");

        }
    }
}

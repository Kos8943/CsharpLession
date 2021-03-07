using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;

namespace Work1
{
    class Program
    {
        static void Main(string[] args)
        {
            //如果args是空值
            if (args.Length == 0)
            {
                Console.WriteLine("請輸入參數");
                return;
            }


            //檔案路徑&名稱
            string path = "D:\\C#\\AAA\\";
            string file = "123.txt";


            //如果檔案不存在
            if(!File.Exists(path + file))
            {
                Console.WriteLine("檔案不存在");
                return;
            }


            //將參數寫入TXT檔
            foreach (string item in args)
            {
                File.AppendAllText(path + file, $"{item}{Environment.NewLine}");
            }

            
            //讀取TXT檔
            string readFile = File.ReadAllText(path + file);
            Console.WriteLine(readFile);
            
            Console.ReadLine();


        }
    }
}

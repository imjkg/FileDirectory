using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectory
{
    /// <summary>檔案複製</summary>
    class FileCopy
    {
        public static void Run()
        {
            Console.Write(@"=檔案複製=");

            Console.Write(@"-請輸入檔案來源資料夾:");
            string from_dir = Console.ReadLine();
            Console.Write(@"-請輸入檔案目的資料夾:");
            string to_dir = Console.ReadLine();

            Console.Write(@"-請輸入檔案路徑清單CSV檔案位置:");
            string csv_path = Console.ReadLine();

            FileStream fileStream = new FileStream(csv_path, System.IO.FileMode.Open, System.IO.FileAccess.Read);
            StreamReader streamReader = new StreamReader(fileStream, Encoding.UTF8);
            string strLine = "";
            while ((strLine = streamReader.ReadLine()) != null)
            {
                strLine = strLine.Replace(@"/", @"\");
                string file_from_path = Path.Combine(from_dir, strLine);
                string file_to_path = Path.Combine(to_dir, strLine);
                Console.Write(file_from_path);

                string file_to_directory = Path.GetDirectoryName(file_to_path);
                if (!Directory.Exists(file_to_directory))
                {
                    Directory.CreateDirectory(file_to_directory);
                }
                if (!File.Exists(file_from_path))
                {
                    Console.Write($" 檔案不存在");
                    continue;
                }

                File.Copy(file_from_path, file_to_path,true);
                Console.Write($" 已複製");
                Console.WriteLine();
            }
        }
    }
}

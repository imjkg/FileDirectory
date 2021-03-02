using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("[功能項目]");
                Console.WriteLine("[1] 檔案複製");
                
                Console.Write(@"-請輸入要執行的功能項目:");

                string tool = Console.ReadLine();
                switch (tool)
                {
                    case "1":
                        FileCopy.Run();
                        break;
                    
                    default:
                        Console.WriteLine("-項目不存在");
                        break;
                }
            }
        }
    }
}

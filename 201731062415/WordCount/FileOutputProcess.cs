using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 输入结果到文件
/// </summary>
namespace WordCount
{
    class FileOutputProcess :ResultOutPutProcess
    {
        public override bool process(Context context)
        {
            Console.WriteLine("内容输出到文件");
            //输出文件位置
            string path = @"E:\Gitprogram\WordCount\201731062415\WordCount\test.txt";
            FileInfo fileInfo = new FileInfo(path);
            StreamWriter sw = fileInfo.AppendText();
            foreach (KeyValuePair<string, int> entry in context.WordCount)
            {
                sw.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }
            return true;
        }
    }
}

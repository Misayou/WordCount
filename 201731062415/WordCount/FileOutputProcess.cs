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
        private string path;
        public FileOutputProcess(string path)
        {
            this.path = path;
        }
        public override bool process(Context context)
        {
            FileInfo fileInfo = new FileInfo(path);
            StreamWriter sw = fileInfo.AppendText();
            sw.WriteLine("文本基础信息如下(其中words统计了小于等于4个字母的)");
            foreach(KeyValuePair<string, int> entry in context.BaseInfo)
            {
                sw.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }
            sw.WriteLine("单词统计信息：");
            foreach (KeyValuePair<string, int> entry in context.WordCount)
            {
                sw.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }
            sw.Close();
            return true;
        }
    }
}

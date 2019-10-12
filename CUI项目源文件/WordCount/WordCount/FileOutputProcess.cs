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
        private int n;
        public FileOutputProcess(string path,int n)
        {
            this.path = path;
            this.n = n;
        }
        public override bool process(Context context)
        {
            FileInfo fileInfo = new FileInfo(path);
            
            StreamWriter sw = fileInfo.AppendText();

            try
            {
                sw.WriteLine("文本基础信息如下(其中words统计了小于等于4个字母的)");
                foreach (KeyValuePair<string, int> entry in context.BaseInfo)
                {
                    sw.WriteLine("{0}:{1}", entry.Key, entry.Value);
                }



                sw.WriteLine("单词统计信息：");
                //按字典序排序
                context.WordCount = context.WordCount.OrderByDescending(o => o.Value).ThenBy(o => o.Key).ToDictionary(o => o.Key, o => o.Value);
                int count = 0;

                foreach (KeyValuePair<string, int> entry in context.WordCount)
                {
                    sw.WriteLine("{0}:{1}", entry.Key.ToLower(), entry.Value);
                    count++;
                    if ((count == n) && n != -1)
                    {
                        break;
                    }
                }

                sw.WriteLine("词组统计信息：");
                context.WordCount = context.WordCount.OrderByDescending(o => o.Value).ThenBy(o => o.Key).ToDictionary(o => o.Key, o => o.Value);
                foreach (KeyValuePair<string, int> entry in context.GroupCount)
                {
                    sw.WriteLine("{0}:{1}", entry.Key.ToLower(), entry.Value);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("输出文件错误！");
            }
            finally
            {
                sw.Flush();
                sw.Close();
            }
            
            return true;
        }
    }
}

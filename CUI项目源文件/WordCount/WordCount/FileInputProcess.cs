using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class FileInputProcess :InputProcess
    {

        /// <summary>
        /// 文件的读取路径
        /// </summary>
        private string path;

        public FileInputProcess(string path)
        {
            this.path = path;
        }

        public override bool process(Context context)
        {
            //从文件中读取文本内容
            string text = null;
            try
            {
                text = File.ReadAllText(path);
                context.FileInfo = text;

                //Console.WriteLine("文本内容如下" + context.FileInfo);
                //完成文本内容的读取后，交由下一个处理
                getNextHandler().process(context);
            }
            catch(Exception e)
            {
                Console.WriteLine("请输入正确的文件路径！");
            }
            
            return true;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCountAPI
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
            context.FileInfo = File.ReadAllText(path);
           
            //Console.WriteLine("文本内容如下" + context.FileInfo);
            //完成文本内容的读取后，交由下一个处理
            getNextHandler().process(context);
            return true;
        }

    }
}

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
        public override bool process(Context context)
        {
            Console.WriteLine("请输入文件路径:");
            string path = Console.ReadLine();
            Dictionary<string, int> keyValuePairs = new Dictionary<string, int>();
            context.Info = File.ReadAllText(path);
            context.WordCount = keyValuePairs;
            Console.WriteLine("从文件输入处理" + context.Info);
            //完成文本内容的读取后，交由下一个处理
            getNextHandler().process(context);
            return true;
        }

    }
}

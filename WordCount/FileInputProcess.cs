using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class FileInputProcess :InputProcess
    {
        public override bool process(Context context)
        {

            Console.WriteLine("从文件输入处理" + context.Info);
            //完成文本内容的读取后，交由下一个处理
            getNextHandler().process(context);
            return true;
        }

    }
}

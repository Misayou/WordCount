using System;
using System.Collections.Generic;
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
            return true;
        }
    }
}

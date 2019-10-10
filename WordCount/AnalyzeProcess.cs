using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    /// <summary>
    /// 统计文本中的单词信息
    /// </summary>
    class AnalyzeProcess : Handler
    {
        public override bool process(Context context)
        {
           
            //上一步文件读取后的信息，存放在context中，
            //这一步利用上一步存在context的结果进行单词统计，并将结果存在context中
            Console.WriteLine("文件单词统计"+context.Info);
            getNextHandler().process(context);
            return true;
        }
    }
}

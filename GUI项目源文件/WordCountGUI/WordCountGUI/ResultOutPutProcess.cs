using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// 抽象输出类
/// </summary>
namespace WordCountAPI
{
    class ResultOutPutProcess : Handler
    {
        public override bool process(Context context)
        {
            throw new Exception("请使用具体输出实现类");
        }
    }
}

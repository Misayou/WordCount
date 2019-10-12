using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    /// <summary>
    /// 抽象的文本信息输入处理
    /// </summary>
    class InputProcess : Handler
    {
        public override bool process(Context context)
        {
           
            throw new Exception("请使用具体输入处理");
            
        }
    }
}

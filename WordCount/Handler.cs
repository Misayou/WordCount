using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    /// <summary>
    /// 抽象处理器
    /// </summary>
    abstract class Handler
    {
        /// <summary>
        /// 进行下一步处理的处理器
        /// </summary>
        private Handler nextHandler;
        public Handler getNextHandler() { return nextHandler; }
        public void setNextHandler(Handler nextHandler) { this.nextHandler = nextHandler; }
        

        public abstract bool process(Context context);
    }
}

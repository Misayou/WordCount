using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    /// <summary>
    /// 上下文信息
    /// </summary>
    class Context
    {
        /// <summary>
        /// 文本内容
        /// </summary>
        private string info;

        private Dictionary<string, int> wordCount;

        public string Info { get => info; set => info = value; }

        public Dictionary<string, int> WordCount { get => wordCount; set => wordCount = value; }
    }
}

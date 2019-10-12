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
        private string fileInfo;
  
        /// <summary>
        /// 统计文件的基础信息，如行数，字符数等
        /// </summary>
        private Dictionary<string, int> baseInfo;


        /// <summary>
        /// 单词计数
        /// </summary>
        private Dictionary<string, int> wordCount;


        /// <summary>
        /// 词组计数
        /// </summary>
        private Dictionary<string, int> groupCount;

        public Context()
        {
            this.baseInfo = new Dictionary<string, int>();
            this.wordCount = new Dictionary<string, int>();
            this.groupCount = new Dictionary<string, int>();
        }

        public Dictionary<string, int> BaseInfo { get => baseInfo; set => baseInfo = value; }
        public Dictionary<string, int> WordCount { get => wordCount; set => wordCount = value; }
        public Dictionary<string, int> GroupCount { get => groupCount; set => groupCount = value; }
        public string FileInfo { get => fileInfo; set => fileInfo = value; }
    }
}

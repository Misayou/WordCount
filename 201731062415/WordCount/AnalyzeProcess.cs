using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace WordCount
{
    /// <summary>
    /// 统计文本中的单词信息
    /// </summary>
    class AnalyzeProcess : Handler
    {
        /// <summary>
        /// 统计字符数数量
        /// </summary>
        /// <param name="context"></param>
        public void countChar(Context context)
        {
            int count = 0;
            context.WordCount.Add("characters", 0);
            foreach (char countchar in context.Info)
            {
                if(countchar<128 && countchar >= 0)
                {
                    count++;
                    context.WordCount["characters"]++;
                }
            }
            Console.WriteLine(count);
            
            Console.WriteLine("Key:{0},Value:{1}", "characters:", context.WordCount["characters"]);
        }

        /// <summary>
        /// 统计总共的单词数量
        /// </summary>
        /// <param name="context"></param>
        public void countWords(Context context)
        {
            string[] words = Regex.Split(context.Info, @"\W+");
            context.WordCount.Add("words", 0);
            foreach (string word in words)
            {
                if(word.Length>=4)
                {                  
                    context.WordCount["words"]++; 
                }
            }

            foreach(KeyValuePair<string,int> entry in context.WordCount)
            {
                Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }
        }

        /// <summary>
        /// 统计分割线的数量
        /// </summary>
        /// <param name="context"></param>
        public void countLines(Context context)
        {

            MatchCollection mch = Regex.Matches(context.Info, "\n");
            context.WordCount.Add("lines", mch.Count);
        }

        /// <summary>
        /// 统计每一个出现单词的数量，单词长度大于4
        /// </summary>
        /// <param name="context"></param>
        public void showWord(Context context)
        {
            string[] words = Regex.Split(context.Info, @"\W+");
            foreach (string word in words)
            {
                if (word.Length >= 4)
                {
                    if (context.WordCount.ContainsKey(word))
                    {
                        context.WordCount[word]++;
                    }
                    else
                    {
                        context.WordCount[word] = 1;
                    }
                }
            }

        }

        public override bool process(Context context)
        {

            //上一步文件读取后的信息，存放在context中，
            //这一步利用上一步存在context的结果进行单词统计，并将结果存在context中


            countChar(context);
            countWords(context);
            countLines(context);
            showWord(context);
            Console.WriteLine("文件单词统计" + context.Info);
            //Console.WriteLine("{0}:{1}", "characters", context.WordCount["characters"]);
            foreach (KeyValuePair<string, int> entry in context.WordCount)
            {
                Console.WriteLine("{0}:{1}", entry.Key, entry.Value);
            }
            getNextHandler().process(context);
            return true;
        }

       
    }
}

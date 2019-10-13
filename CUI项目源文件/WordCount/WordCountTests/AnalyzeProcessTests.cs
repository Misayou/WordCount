using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCount;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount.Tests
{
    [TestClass()]
    public class AnalyzeProcessTests
    {

        private string testCase01 = "You got things to do. Places to go. People to see. Futures to make.";

        [TestMethod()]
        public void countCharTest()
        {
            Context context = new Context();
            AnalyzeProcess analyzeProcess = new AnalyzeProcess(-1);

            //测试用例一
            context.FileInfo = "You got things to do. Places to go. People to see. Futures to make.";
            analyzeProcess.countChar(context);
            int count = context.BaseInfo["characters"];
            Assert.AreEqual(count, 67);

            //测试用例二
            Context context02 = new Context();
            context02.FileInfo = "hello world!";
            analyzeProcess.countChar(context02);
            count = context02.BaseInfo["characters"];
            Assert.AreEqual(count, 12);


        }

        [TestMethod()]
        public void countWordsTest()
        {
            AnalyzeProcess analyze = new AnalyzeProcess(-1);
            Context context = new Context();
            context.FileInfo = "hello world world process world ";
            analyze.countWords(context);
            Assert.AreEqual(context.WordCount["hello"], 1);
            Assert.AreEqual(context.WordCount["world"], 3);
            Assert.AreEqual(context.WordCount["process"], 1);

        }

        [TestMethod()]
        public void countWordGroupTest()
        {
            AnalyzeProcess analyze = new AnalyzeProcess(2);
            Context context = new Context();
            context.FileInfo = "hello world world world process world";
            analyze.countWordGroup(context,2);

            foreach (KeyValuePair<string, int> entry in context.GroupCount)
            {
                Console.WriteLine(entry.Key+ ":" + entry.Value);
               
            }
            Assert.AreEqual(context.GroupCount["hello world "], 1);
            Assert.AreEqual(context.GroupCount["world world "], 2);
            Assert.AreEqual(context.GroupCount["world process "], 1);
        }
    }
}
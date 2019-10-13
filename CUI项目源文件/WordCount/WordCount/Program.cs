using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WordCount
{
    class Program
    {

        static void Main(string[] args)
        {
            string inPath="";
            string outPath="";
            int m=-1; //统计的词组的长度
            int n=-1; //输出的单词的数量
            for(int i = 0; i < args.Length-1; i++)
            {
                try
                {
                    if ("-i".Equals(args[i]))
                    {
                        inPath = args[i + 1];
                    }
                    else if ("-o".Equals(args[i]))
                    {
                        outPath = args[i + 1];
                    }
                    else if ("-m".Equals(args[i]))
                    {
                        m = int.Parse(args[i + 1]);
                    }
                    else if ("-n".Equals(args[i]))
                    {
                        n = int.Parse(args[i + 1]);
                    }
                }
                catch
                {
                    Console.WriteLine("请输入正确的指令，如-i,-o,-m或-n");
                }
            }
            if ("".Equals(inPath) || "".Equals(outPath))
            {
                Console.WriteLine("请输入正确的命令");
            }
           

            Context context = new Context();
           

            InputProcess inputProcess= new FileInputProcess(inPath);
            ResultOutPutProcess outPutProcess = new FileOutputProcess(outPath,n);

            WordCount wordCount = new WordCount(inputProcess, new AnalyzeProcess(m),outPutProcess, context);
            wordCount.process();
            Console.ReadLine();
        }
    }
}

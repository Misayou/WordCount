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
            
            Context context = new Context();
            Console.WriteLine("请输入源文件的路径");
            string inpath = Console.ReadLine();
            Console.WriteLine("请输入结果输出的文件,如F:\\out.txt");
            string outpath = Console.ReadLine();

            InputProcess inputProcess= new FileInputProcess(inpath);
            ResultOutPutProcess outPutProcess = new FileOutputProcess(outpath);

            WordCount wordCount = new WordCount(inputProcess, new AnalyzeProcess(),outPutProcess, context);
            wordCount.process();
            Console.ReadLine();
        }
    }
}

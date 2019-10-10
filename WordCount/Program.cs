using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {



            
            Context context = new Context();

            WordCount wordCount = new WordCount(new FileInputProcess(),new AnalyzeProcess(),new FileOutputProcess(), context);
            wordCount.process();
            Console.ReadLine();
        }
    }
}

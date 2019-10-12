using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordCountAPI
{
    class WordCount
    {
        InputProcess inputProcess;
        AnalyzeProcess analyzeProcess;
        ResultOutPutProcess resultOutPutProcess;
        Context context;

        public WordCount(InputProcess input,AnalyzeProcess analyze,ResultOutPutProcess output, Context context)
        {
            //初始化处理对象
            this.inputProcess = input;
            this.analyzeProcess = analyze;
            this.resultOutPutProcess = output;

            //构造处理流程
            input.setNextHandler(analyze);
            analyze.setNextHandler(output);

            this.context = context;
        }

        /// <summary>
        /// 开始处理
        /// </summary>
        public void process()
        {
            inputProcess.process(context);
        }


    }
}

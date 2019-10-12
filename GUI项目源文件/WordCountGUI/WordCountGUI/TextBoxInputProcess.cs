using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCountAPI;
using WordCountGUI;

namespace WordCountGUI
{
    class TextBoxInputProcess:InputProcess
    {
        public override bool process(Context context)
        {
            //读取控件内的文本信息
            context.FileInfo = Form1.form.infoTextBox.Text;
            getNextHandler().process(context);
            return true;

        }
    }
}

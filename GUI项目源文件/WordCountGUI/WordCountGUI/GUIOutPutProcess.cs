using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WordCountAPI;

namespace WordCountGUI
{
    class GUIOutPutProcess : ResultOutPutProcess
    {
        private int n;

        public GUIOutPutProcess(int n)
        {
            this.n = n;
        }
        public override bool process(Context context)
        {
            //清空显示
            Form1.form.baseInfoTextBox.Text = "";
            Form1.form.wordCountTextBox.Text = "";

           
            foreach (KeyValuePair<string, int> entry in context.BaseInfo)
            {
                Form1.form.baseInfoTextBox.Text += entry.Key + ":" + entry.Value + "\r\n";

            }




            Form1.form.wordCountTextBox.Text += "单词统计信息\r\n";
            //按字典序排序
            context.WordCount = context.WordCount.OrderBy(o => o.Key).ToDictionary(o => o.Key, o => o.Value);
            int count = 0;
            foreach (KeyValuePair<string, int> entry in context.WordCount)
            {
                Form1.form.wordCountTextBox.Text += entry.Key.ToLower() + ":" + entry.Value + "\r\n";
                count++;
                if ((count == n) && n != -1)
                {
                    break;
                }
            }

            if (context.GroupCount.Count == 0)
            {
                return true;
            }
            Form1.form.wordCountTextBox.Text += "词组统计信息\r\n";
            context.GroupCount = context.GroupCount.OrderBy(o => o.Key).ToDictionary(o => o.Key, o => o.Value);
            foreach (KeyValuePair<string, int> entry in context.GroupCount)
            {
                Form1.form.wordCountTextBox.Text += entry.Key.ToLower() + ":" + entry.Value + "\r\n";
            }

            return true;

        }
    }
}

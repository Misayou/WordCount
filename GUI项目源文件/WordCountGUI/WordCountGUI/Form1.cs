using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using WordCountAPI;
using WordCountGUI;

namespace WordCountGUI
{
    public partial class Form1 : Form
    {

        public static Form1 form;
        public Form1()
        {
            InitializeComponent();
            form = this;
        }

        /// <summary>
        /// 点击选择导入单词文件按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Multiselect = false;//该值确定是否可以选择多个文件
            dialog.Title = "请选择单词文件";
            dialog.Filter = "所有文件(*.*)|*.*";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string file = dialog.FileName;
                try
                {
                   
                    string info = File.ReadAllText(file);
                    infoTextBox.Text = info;
                }
                catch
                {
                    MessageBox.Show("文件导入发生错误");
                }
                
                
            }
        }

        /// <summary>
        /// 导出按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void outPutbutton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
           
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string path = dialog.SelectedPath;
                FileInfo fileInfo = new FileInfo(path + "\\out.txt");
                StreamWriter sw=fileInfo.AppendText();
                sw.WriteLine("基本信息：");
                sw.Write(baseInfoTextBox.Text);
                sw.WriteLine("单词词频信息:");
                sw.Write(wordCountTextBox.Text);
                sw.Close();
                MessageBox.Show("导出成功");
            }
        }

        /// <summary>
        /// 开始统计按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void beginButton_Click(object sender, EventArgs e)
        {
            int m = -1;
            int n = -1;
            try
            {
                if (!"".Equals(mTextBox.Text))
                {
                    m = int.Parse(mTextBox.Text);
                }
                if (!"".Equals(nTextBox.Text))
                {
                    n = int.Parse(nTextBox.Text);
                }
            }
            catch(FormatException f)
            {
                MessageBox.Show("可选参数必须是整数");
                return;
            }

            Console.WriteLine(m + "  " + n);
            Context context = new Context();
            WordCount wordCount = new WordCount(new TextBoxInputProcess(), new AnalyzeProcess(m), new GUIOutPutProcess(n), context);
            wordCount.process();

        }
    }
}

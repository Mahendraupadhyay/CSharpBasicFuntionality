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
using System.Threading;

namespace WinFormsSampleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private int ReadDataCharacterCount()
        {
            int count = 0;
            using (StreamReader reader = new StreamReader("C:\\Users\\Mahendra\\Desktop\\Data.txt"))
            {
                string read = reader.ReadToEnd();
                count = read.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        /*Usage of Asyns and Await*/
        //private async void btnProcessing_Click(object sender, EventArgs e)
        //{
        //    Task<int> task = new Task<int>(ReadDataCharacterCount);
        //    task.Start();
        //    lblStatusMessage.Text = "Processing file...";

        //    int count = await task;
        //    lblStatusMessage.Text = count.ToString() + " number of character in file";
        //}
        /*Usage of Asyns and Await*  **END**/
        /*Same example using thread*/
        int countChar = 0;
        private void btnProcessing_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                countChar = ReadDataCharacterCount();
                Action action = new Action(SetLabelMessage);
                this.BeginInvoke(action);
            }
            );
            thread.Start();
            lblStatusMessage.Text = "Processing file...";
        }

        private void SetLabelMessage()
        {
            lblStatusMessage.Text = countChar.ToString() + " number of character in file";
        }
        /*END thread examle*/
    }
}


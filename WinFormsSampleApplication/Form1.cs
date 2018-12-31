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
    delegate void masterDelegate(object sender, EventArgs e);
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

       public void ReadList(List<string> list)
        {
            list.Add("First");
            list.Add("Two");
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

        public void button1_Click(object sender, EventArgs e)
        {
            
            if (textBox1.InvokeRequired)
            {
                textBox1.Invoke(new MethodInvoker(delegate {
                    textBox1.Text = DateTime.Now.ToString();
                    textBox1.BackColor = System.Drawing.Color.Yellow;
                }));
            }
            else
            {
                textBox1.Text = DateTime.Now.ToString();
                textBox1.BackColor = System.Drawing.Color.Yellow;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (textBox2.InvokeRequired)
            {
                textBox2.Invoke(new MethodInvoker(delegate {
                    textBox2.Text = DateTime.Now.ToString();
                    textBox2.BackColor = System.Drawing.Color.Red;
                }));
            }
            else
            {
                textBox2.Text = DateTime.Now.ToString();
                textBox2.BackColor = System.Drawing.Color.Red;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            try
            {
                string g = "";
                MessageBox.Show(g.ToString());
                MessageBox.Show(Convert.ToString(g));
                if (textBox3.InvokeRequired)
                {
                    textBox3.Invoke(new MethodInvoker(delegate
                    {
                        textBox3.Text = DateTime.Now.ToString();
                        textBox3.BackColor = System.Drawing.Color.RosyBrown;
                    }));
                }
                else
                {
                    textBox3.Text = DateTime.Now.ToString();
                    textBox3.BackColor = System.Drawing.Color.RosyBrown;
                }
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
           
            if (textBox4.InvokeRequired)
            {
                textBox4.Invoke(new MethodInvoker(delegate
                {
                    textBox4.Text = DateTime.Now.ToString();
                    textBox4.BackColor = System.Drawing.Color.Purple;
                }));
            }
            else
            {
                textBox4.Text = DateTime.Now.ToString();
                textBox4.BackColor = System.Drawing.Color.Purple;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = "";
            textBox1.BackColor = textBox2.BackColor = textBox3.BackColor = textBox4.BackColor = Color.White;
        }
        private void button5_Click(object sender, EventArgs e)
        {
            //masterDelegate del1, del2, del3, del4, del5;
            //del1 = new masterDelegate(button1_Click);
            //del2 = new masterDelegate(button2_Click);
            //del3 = new masterDelegate(button3_Click);
            //del4 = new masterDelegate(button4_Click);
            //del5 = del1 + del2 + del3 + del4;
            //del5(sender, e);

            //Thread t1 = new Thread(()=>button1_Click(null,null));
            //Thread t2 = new Thread(() => button2_Click(null, null));
            //Thread t3 = new Thread(() => button3_Click(null, null));
            //Thread t4 = new Thread(() => button4_Click(null, null));
            //t1.Start(); t2.Start(); t3.Start(); t4.Start();

            Task task = new Task(() => button1_Click(null, null));
            Task task1 = new Task(() => button2_Click(null, null));
            Task task2 = new Task(() => button3_Click(null, null));
            Task task3 = new Task(() => button4_Click(null, null));
            task.Start(); task2.Start(); task3.Start(); task1.Start();
        }
        /*END thread example*/
    }
}


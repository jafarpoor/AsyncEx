using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Threading
{
    public partial class MainForm : Form
    {
        Thread thread = null;
        Thread Globalthread =null;

        public MainForm()
        {
            InitializeComponent();
        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            ///creat new thread
            /// ThreadStart is fro void func
            //Thread thread = new Thread(new ThreadStart(DoWork));
            //thread.Start();



            //thread to thread
             thread = new Thread(MainThread);
            thread.IsBackground=true;
            thread.Start();

        }


        //it is for new ThreadStart//
        //private void DoWork()
        //{
        //    for (int i = 0; i < 100; i++)
        //    {
        //        Invoke(new Action(() =>textOutPut.Text += "start" + i +Environment.NewLine));
        //        Thread.Sleep(100);
        //    }
        //}


        void MainThread()
        {
            //send parmeter to do work
            Globalthread = new Thread(new ParameterizedThreadStart(DoWork));
            Globalthread.Start(new ThreadParamter
            {
                Start = 10,
                End = 30
            });
        }

        private void DoWork(object obj)
        {
            var ThreadsParems = (ThreadParamter)obj;
            for (int i = ThreadsParems.Start; i < ThreadsParems.End; i++)
            {
                Invoke(new Action(() => textOutPut.Text += "start" + i + Environment.NewLine));
                Thread.Sleep(1000);
            }
        }
        public class ThreadParamter
        {
            public int Start { get; set; }
            public int End { get; set; }
        }

        private void Stopbtn_Click(object sender, EventArgs e)
        {
            if (thread != null && Globalthread.IsAlive )
            {
                thread.Abort();
                Globalthread.Abort();
            }
        }
    }
}

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
    public partial class ConcurrenciFrm : Form
    {
        public object obj = new object();
        public ConcurrenciFrm()
        {
            InitializeComponent();
        }

        private void Asyncbtn_Click(object sender, EventArgs e)
        {
            Thread[] threads = new Thread[10];
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(Print);
                threads[i].Name = "works" + (i + 1);
                threads[i].Start();
            }
        }

        void Print()
        {
            //synchrozation
            //interlock
            lock (obj)
            {
                var CurrentThreadName = Thread.CurrentThread.Name;
                Invoke(new Action(() => txt.Text += CurrentThreadName + Environment.NewLine));
                for (int i = 0; i < 5; i++)
                {
                    Invoke(new Action(() => txt.Text += "start" + i + Environment.NewLine));
                    Thread.Sleep(1000);
                }
            }



            //monitor
            //Monitor.Enter(obj);
            //try
            //{
            //    Console.Write("{0} is printing numbers  >  ", Thread.CurrentThread.Name);
            //    for (int counter = 0; counter < 10; counter++)
            //    {
            //        Thread.Sleep(200 * new Random().Next(5));
            //        Console.Write("{0},", counter);
            //    }
            //    Console.WriteLine();
            //}
            //finally
            //{
            //    Monitor.Exit(obj);
            //}

        }
    }
}

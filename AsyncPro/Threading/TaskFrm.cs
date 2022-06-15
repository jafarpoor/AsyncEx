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
    public partial class TaskFrm : Form
    {
        CancellationTokenSource cts;
        public TaskFrm()
        {
            InitializeComponent();
        }

        private void Taskbtn_Click(object sender, EventArgs e)
        {
             cts = new CancellationTokenSource();
            Task task = new Task(PrintNumber);
            task.Start();
          //  PrintNumber();
        }

        void PrintNumber()
        {
            var ListNumber = Enumerable.Repeat(70, 1000000000).ToList();
            int Sum = 0;
            //for (int i = 0; i < ListNumber.Count; i++)
            //{
            //    Sum += ListNumber[i];   
            //}

            ParallelOptions parallelOptions = new ParallelOptions();
            parallelOptions.MaxDegreeOfParallelism = 5;
            parallelOptions.CancellationToken = cts.Token;
           

            try
            {

                //parallel
                Parallel.For(0, ListNumber.Count, parallelOptions,
                    i => {
                        Sum += ListNumber[i];
                        parallelOptions.CancellationToken.ThrowIfCancellationRequested();
                      MessageBox.Show((Sum / ListNumber.Count).ToString());
                    });
            }
            catch (OperationCanceledException ex)
            {
                MessageBox.Show("task canceled.....");
                Taskbtn.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cts.Cancel();
        }

        private void Linqbtn_Click(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() =>
            {
                var ListNumber = Enumerable.Repeat(70, 1000000000).ToList() ;
                var result = (from n in ListNumber.AsParallel()
                             select n).Count();

                MessageBox.Show(result.ToString());

            });

        }
    }
}

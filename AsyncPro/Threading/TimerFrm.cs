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
    public partial class TimerFrm : Form
    {
        public TimerFrm()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            TimerCallback callback = new TimerCallback(PrintTime);

            System.Threading.Timer timer = new System.Threading.Timer(callback, null, 0, 1000);
            MessageBox.Show("Press any key to terminate application...");
            Console.ReadKey();
        }

        public static void PrintTime(object state)
        {
            MessageBox.Show(DateTime.Now.ToString("hh:mm:ss"));
        }
    }
}

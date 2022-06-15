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
    public partial class AsyncAwite : Form
    {
        public AsyncAwite()
        {
            InitializeComponent();
        }

        private async void changtextbtn_Click(object sender, EventArgs e)
        {
            label1.Text = await GetTitleAsync();
        }

        private Task<string> GetTitleAsync()
        {
            return Task.Run<string>(() =>
            {
                Thread.Sleep(200);
                return "Update";

            });
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectAnxiety
{
    public partial class Creators : Form
    {
        public Creators()
        {
            InitializeComponent();
        }

        private void monoFlat_Button1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/nBG4xhMVZm");
        }

        private void monoFlat_Button2_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCSAj306v3m-1FypMrB6V2Zw");
        }
    }
}

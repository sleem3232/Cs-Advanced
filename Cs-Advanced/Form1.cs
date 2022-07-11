using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cs_Advanced
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Tuple tuple = new Tuple();
            tuple.run();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delegate delegat= new Delegate();
            delegat.run();

        }
    }
}

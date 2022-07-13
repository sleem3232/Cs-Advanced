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

        private void button3_Click(object sender, EventArgs e)
        {
            Event events= new Event();
            opeate opeate= new opeate();
            opeate.Init();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Foreach foreacha= new Foreach();
            foreacha.RunMyItems();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Stract stract= new Stract();
           stract.run();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PartialClass partialClass= new PartialClass();
            partialClass.run();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RefVal refVal= new RefVal();
            refVal.run();
        }
    }
}

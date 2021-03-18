using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFactoryPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                // Use Factory to get a Position for each id.
                Position p = Factory.Get(i);
                // Display the results.
                label1.Text += "Id = " + i + ", position = " + p.Title + "\r\n";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomGenerator
{
    public partial class displayForm : Form
    {
        public displayForm()
        {
            InitializeComponent();
        }

        public displayForm(List<string> displayList)
        {
            InitializeComponent();
            this.tbDisplay.Text = string.Empty;
            this.tbDisplay.ScrollBars = ScrollBars.Vertical;

            foreach (string displayStr in displayList)
            {
                this.tbDisplay.Text = this.tbDisplay.Text + displayStr + Environment.NewLine;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(this.tbDisplay.Text);
        }

        private void tbDisplay_KeyDown(object sender, KeyEventArgs e)
        {
           
        }
    }
}

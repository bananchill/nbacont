using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nbacont
{
    public partial class EditMatch : Form
    {
        string cellContent;
        public EditMatch(string cellContent)
        {
            InitializeComponent();
            this.cellContent = cellContent;
        }

        private void EditMatch_Load(object sender, EventArgs e)
        {
            textBox1.Text = cellContent;
        }
    }
}

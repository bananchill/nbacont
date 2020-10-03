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
    public partial class visitorform : Form
    {
        Admin userActive;
        public visitorform(Admin userActive)
        {
            InitializeComponent();
            this.userActive = userActive;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            auth auth = new auth();
            auth.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Matchupsbutton_Click(object sender, EventArgs e)
        {
            Matchups a = new Matchups(userActive);
            a.Show();
            this.Hide();
        }
    }
}

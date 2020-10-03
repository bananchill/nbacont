using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace nbacont
{
    public partial class Matchups : Form
    {
        DbController dbController = new DbController();
        private static NbacontEntities db { get; set; }
        Admin role;
        string task;
        MatchUp mt;
        private DataGridViewRow row = new DataGridViewRow();
        public Matchups(Admin userActive)
        {
            InitializeComponent();
            this.role = userActive;
            dataGridView1.DataSource = DbController.match();
            db = new NbacontEntities();

        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
        }

        private void Matchups_Load(object sender, EventArgs e)
        {
            LoadDataEditData();

        }
        private void LoadDataEditData()
        {

            this.dataGridView1.Columns["idMatchUp"].Visible = false;
            this.dataGridView1.Columns["PlayerStatistics"].Visible = false;
            this.dataGridView1.Columns["Season_idSeason"].Visible = false;
            this.dataGridView1.Columns["MatchUpType_idMatchUpType"].Visible = false;
            this.dataGridView1.Columns["MatchUpDetail"].Visible = false;
            this.dataGridView1.Columns["MatchUpLog"].Visible = false;
            this.dataGridView1.Columns.Add("Delete", "Delete");

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                DataGridViewLinkCell linkCell = new DataGridViewLinkCell();
                dataGridView1[16, i] = linkCell;
                this.dataGridView1.Rows[i].Cells[16].Value = "Delete";
            }


        }
        private void filterButton_Click(object sender, EventArgs e)
        {
            var selectedCell = dataGridView1.SelectedCells[0].Value.ToString();
            EditMatch match = new EditMatch(selectedCell);
            match.Show();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 16)
            {
                string task = dataGridView1.Rows[e.ColumnIndex].Cells[16].Value.ToString();
                if (task == "Delete")
                {
                    if (MessageBox.Show("Удалить эту строку ?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        int rowin = e.RowIndex;
                        dataGridView1.Rows.RemoveAt(rowin);

                        

                    }

                }
                
                else if (task == "Insert")
                {



                }
                else if (task == "Update")
                {



                }

            }

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
        }
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LABARATORNAYA
{
    public partial class Form4 : Form
    {
        public int teamId;
        Team tm = new Team();
        public Form4()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolTip1_Popup_1(object sender, PopupEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Team_Detail_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < Form3.teams.Length; i++)
                if (Form3.teams[i].teamId == this.teamId)
                    this.tm = Form3.teams[i];

            label3.Text = this.tm.name;

            for (int i = 0; i < Form1.players.Length; i++)
                if (Form1.players[i].teamId == this.teamId)
                    dataGridView1.Rows.Add(Form1.players[i].playerId, Form1.players[i].firstName);
        }

        private void Years_SelectedItemChanged(object sender, EventArgs e)
        {

        }
    }
}

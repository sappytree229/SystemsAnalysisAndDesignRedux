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

namespace ISAD_User_Story_1
{
    public partial class aBITSForm : Form
    {
        public aBITSForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand query = new SqlCommand("Insert into PROSPECTIVE_MEMBER_INFO (fName) values (" + fNameTextBox.Text + ")");
        }

        private void aBITSForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aBITSDataSet.Prospective_Member_Info' table. You can move, or remove it, as needed.
            this.prospective_Member_InfoTableAdapter.Fill(this.aBITSDataSet.Prospective_Member_Info);

        }

        private void fNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

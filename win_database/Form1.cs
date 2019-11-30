using DataBaseConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_database
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_move_MouseEnter(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.Gray;
            ((Button)sender).ForeColor = Color.White;
        }

        private void Btn_move_MouseLeave(object sender, EventArgs e)
        {
            ((Button)sender).BackColor = Color.White;
            ((Button)sender).ForeColor = Color.Black;
        }

        private void Btn_select_Click(object sender, EventArgs e)
        {
            frmSelect fr = new frmSelect();
            fr.frm1Obj = this;
            fr.ShowDialog();
        }

        private void Btn_move_Click(object sender, EventArgs e)
        {
            move fr = new move();
            fr.frm1_Obj = this;
            fr.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            PDBC dbObj = new PDBC();
            dbObj.Connect();
            DataTable dt = dbObj.Select("SELECT [id],[Name],[LastName] FROM [tblFirstLoad]");
            dbObj.DC();
            
            dgv_MainDataTable.DataSource = dt;
        }
    }
}

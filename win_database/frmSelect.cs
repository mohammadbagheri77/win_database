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
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }
        public Form1 frm1Obj { get; set; }
        private void FrmSelect_Load(object sender, EventArgs e)
        {
            ComboboxObjects cbo = new ComboboxObjects();
            cbo.Text = "جایگاه های کاری";
            cbo.Value = "tblJobPosition";
            ComboboxObjects cbo2 = new ComboboxObjects();
            cbo2.Text = "کاربر ها";
            cbo2.Value = "tblFirstLoad";
            cmbTables.Items.Add(cbo);
            cmbTables.Items.Add(cbo2);
            cmbTables.SelectedIndex = 0;
        }
        private void BtnSabt_Click(object sender, EventArgs e)
        {
            PDBC db = new PDBC();
            db.Connect();
            DataTable dt = db.Select($"Select * From {((ComboboxObjects)(cmbTables.SelectedItem)).Value}");
            db.DC();
            frm1Obj.dgv_MainDataTable.DataSource = dt;
            this.Hide();
        }
    }
}

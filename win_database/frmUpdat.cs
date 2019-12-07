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
    public partial class frmUpdat : Form
    {    
        private string _TBNName { set; get; }
        private string _TBNCell { set; get; }
        private string _TBNColval { set; get; }
        private string _TBNWhere { set; get; }
        private bool _TBLIsInt { set; get; }
        public frmUpdat(string TBNName ,string TBNCell ,string TBNColval, string TBNWhere,bool TBLIsInt)
        {
            _TBNName = TBNName;
            _TBNCell = TBNCell;
            _TBNColval = TBNColval;
            _TBNWhere = TBNWhere;
            _TBLIsInt = TBLIsInt;
            InitializeComponent();
        }

        private void FrmUpdat_Load(object sender, EventArgs e)
        {
            lbl_2.Text = "مقدار قبلی در" + _TBNName + ":" + _TBNColval;
        }
        /*
         UPDATE [{_TBNName}] SET [{_TBNCell}] = {flog} WHERE {_TBNWhere} 
             */
        private void Btn_save_Click(object sender, EventArgs e)
        {
            PDBC db = new PDBC();
            db.Connect();
            string result = "عدم توانایی";
            if(_TBLIsInt)
            {
                int flog = 0;
                if(Int32.TryParse(lbl_1.Text,out flog))
                {
                    result = db.Script($" UPDATE [{_TBNName}] SET [{_TBNCell}] = {flog} WHERE {_TBNWhere}");
                }

            }
            else
            {
               result = db.Script($" UPDATE [{_TBNName}] SET [{_TBNCell}] = '{lbl_1.Text}' WHERE {_TBNWhere}");
            }
            db.DC();
            MessageBox.Show(result);
            this.Hide();
        }
    }
}

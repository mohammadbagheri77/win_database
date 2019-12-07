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
    public partial class frmInsert : Form
    {
        public string _TableName { get; set; }
        public frmInsert(string tableName)
        {
            _TableName = tableName;
            InitializeComponent();
        }
        //--------------------------------------------
        PDBC _db;
        DataTable dt_AddData = new DataTable();
        private void FrmInsert_Load(object sender, EventArgs e)
        {
            lbl_2.Text = _TableName;
            _db = new PDBC();
            _db.Connect();
            using (DataTable dt = _db.Select("SELECT [id] as 'آیدی',[name] as 'نام',[lastname] as 'نام خانوادگی'FROM [tblFirstLoad1]"))
            {
                dvg_father.DataSource = dt;
            }
            using (DataTable dt = _db.Select($"SELECT * FROM[{_TableName}]"))
            {
                for (int i = 0; i < dt.Columns.Count; i++)
                {
                    if (dt.Columns[i].ColumnName != "id")
                    {
                        dt_AddData.Columns.Add(dt.Columns[i].ColumnName, typeof(System.String));
                    }
                    dvg_toadd.DataSource = dt_AddData;
                    _db.DC();
                }
            }
        }

        private void Btn_save_Click(object sender, EventArgs e)
        {
            List<string> Query = new List<string>();
            for (int i = 0; i < dvg_toadd.Rows.Count-1; i++)
            {
                string Query_S = "INSERT INTO [TSH_TabName] ([TSH_ValuesHeader]) VALUES ([TSH_Value]) ";

                string Headers = "";
                string Vals = "";
                for (int j = 0; j < dvg_toadd.Columns.Count; j++)
                {
                    Headers += dvg_toadd.Columns[j].Name + ",";
                    if (dvg_toadd.Columns[j].HeaderText.ToString().ToLower().Contains("id"))
                    {
                        Vals += dvg_toadd.Rows[i].Cells[j].Value.ToString() + ",";
                    }
                    else
                    {
                        Vals += "N'"+dvg_toadd.Rows[i].Cells[j].Value.ToString() + "',";
                    }
                }
                Vals = Vals.TrimEnd(',');
                Headers=Headers.TrimEnd(',');
                Query.Add(Query_S.Replace("TSH_TabName", _TableName).Replace("[TSH_ValuesHeader]", Headers).Replace("[TSH_Value]", Vals));
            }
            _db.Connect();
            string Result ="";
            for (int i=0; i <Query.Count; i++)
            {
                Result += "," + _db.Script(Query[i]);
            }
            _db.DC();
            MessageBox.Show(Result);
        }
    }
}

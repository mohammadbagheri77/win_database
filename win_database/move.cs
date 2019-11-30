using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace win_database
{
    public partial class move : Form
    {
        public move()
        {
            InitializeComponent();
        }
        public Form1 frm1_Obj { get; set; }
        private void Move_Load(object sender, EventArgs e)
        {
            string downloadString, str;

            List<class_move> list_move = new List<class_move>();
            class_get_move get_sring = new class_get_move();

            WebClient client = new WebClient();
            client.Encoding = Encoding.UTF8;

            downloadString = client.DownloadString("http://www.film2serial.ir/");
            str = get_sring.GetStringBetween(downloadString, "<div class=\"tabs-b\" id=\"New\">", "</div>");
            List<string> all = get_sring.List_file_move(str, "<li>", "</li>");

            for (int ii = 0; ii < all.Count; ii++)
            {
                class_move Move = new class_move();
                Move.move_link = "http://www.film2serial.ir/";
                Move.move_name = get_sring.GetStringBetween(all[ii], "<a title=\"", "\" href");
                Move.move_token = get_sring.GetStringBetween(all[ii], "href=\"", "\">");
                list_move.Add(Move);
            }

            for (int i = 0; i < list_move.Count; i++)
            {
                ComboboxObjects cbo = new ComboboxObjects();
                cbo.Text = list_move[i].move_name;
                cbo.Value = list_move[i].move_token;
                com_box.Items.Add(cbo);
                com_box.SelectedIndex = 0;
            }
        }

        private void Btn_go_Click(object sender, EventArgs e)
        {
            var url =$" {((ComboboxObjects)(com_box.SelectedItem)).Value}";
            web.Navigate(url);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BOOM_GAMEBAR
{
   
    public partial class staff_login_form : Form
    {
        List<staff_info_class> list_of_staff_info;
        public staff_login_form()
        {
            InitializeComponent();
        }
        private void staff_login_form_Load(object sender, EventArgs e)
        {
            staff_info_class staff_info = new staff_info_class();
            list_of_staff_info = staff_info.get_all_objects();
        }
        private void login_button_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < list_of_staff_info.Count; i++)
            {
                if (list_of_staff_info[i].get_login == login_text_box.Text.ToString() &&
                    list_of_staff_info[i].get_password == password_textbox.Text.ToString())
                {

                }
            }
        }
    }
}

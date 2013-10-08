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
    public partial class Add_client_form : Form
    {
        private SqlConnection add_client_to_clients_table_connection;
        
        private double getPrice;
        private bool op_tables = false;
        private bool op_clients = false;
        private int clientCounter;

        List<string> free_tables;
        List<string> clients_info;

        public Add_client_form()
        {
            
            InitializeComponent();
        }
        private void Add_client_form_Load(object sender, EventArgs e)
        {
            clients_info = new List<string>();
            free_tables = new List<string>();
            GetDataFromDB();
            add_client_button.FlatStyle = FlatStyle.Flat;
        }
        private void GetDataFromDB()
        {
            //------------------------Getting all free tables-----------------------------
            using (add_client_to_clients_table_connection)
            {
                add_client_to_clients_table_connection = new SqlConnection(@"Server= (local)\SQLEXPRESS; Initial Catalog=Boom; Integrated Security=True;");
                add_client_to_clients_table_connection.Open();
                SqlCommand command = new SqlCommand("SELECT table_id FROM tables_info WHERE table_state='free'", add_client_to_clients_table_connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    free_tables.Add(reader.GetInt32(0).ToString());
                }
                reader.Close();
            //------------------------Getting all free tables-----------------------------


                //SqlCommand command2 = new SqlCommand("SELECT customer_id FROM customer", add_client_to_clients_table_connection);
                //SqlDataReader reader2 = command2.ExecuteReader();
                //while (reader2.Read())
                //{
                //    clients_info.Add(reader2.GetString(0).ToString());
                //}
                //reader2.Close();
            }
        }
        private void table_num_MouseClick(object sender, MouseEventArgs e)
        {
            if (!op_tables)
            {
                op_tables = true;
                for (int i = 0; i < free_tables.Count; i++)
                {
                    table_num.Items.Add(free_tables[i]);
                }
            }
        }

        private void add_client_button_Click(object sender, EventArgs e)
        {
            if (table_num.Text == ""|| 
                    paid_sum_text_box.Text == "" ||
                    int.Parse(paid_sum_text_box.Text) <= 0 ||
                    client_DATE_out_field.Value.ToString("dd.MMM.yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm") == System.DateTime.Now.ToString("dd.MMM.yyyy HH:mm"))
            {
                MessageBox.Show("ERROR!\nCheck all fields!!!\nPossible troubles:\n -You didn't change date!\n-Paid sum is equal to zero!");
            }
            else if (System.DateTime.Parse(client_DATE_out_field.Value.ToString("dd.MMM.yyyy") + " "
               + client_TIME_out_field.Value.ToString("HH:mm")) < System.DateTime.Now.Date)
            {
                MessageBox.Show("Check the date and time!\n" +
                                " The date you put is is too far from current time!\n" +
                                " You've entered date: " + client_DATE_out_field.Value.ToString("dd.MMM.yyyy"));
            }
            else 
            {
                SqlCommand insert_deposit_table;
                insert_deposit_table = new SqlCommand("INSERT INTO new_client(client_num, table_id, time_come, time_out, customer_id, discount, total_cost, client_state)" +
                                            " VALUES (@client_num, @table_id, @client_time, @client_out, '0', '0', '0', 'opened'); ", add_client_to_clients_table_connection);
                insert_deposit_table.Parameters.Add(new SqlParameter("@client_num", SqlDbType.Int));
                insert_deposit_table.Parameters["@client_num"].Value = clientCounter;

                insert_deposit_table.Parameters.Add(new SqlParameter("@table_id", SqlDbType.Int));
                insert_deposit_table.Parameters["@table_id"].Value = int.Parse(table_num.Text);

                insert_deposit_table.Parameters.Add(new SqlParameter("@client_time", SqlDbType.DateTime));
                insert_deposit_table.Parameters["@client_time"].Value = client_DATE_out_field.Value.ToString("dd/MMM/yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm");

                insert_deposit_table.Parameters.Add(new SqlParameter("@client_out", SqlDbType.DateTime));
                insert_deposit_table.Parameters["@client_out"].Value = client_DATE_out_field.Value.ToString("dd/MMM/yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm");

                insert_deposit_table.ExecuteNonQuery();

                SqlCommand update_table_info;
                update_table_info = new SqlCommand("UPDATE tables_info SET table_state='busy' WHERE table_id=@table_id", add_client_to_clients_table_connection);
                update_table_info.Parameters.Add(new SqlParameter("@table_id", SqlDbType.Int));
                update_table_info.Parameters["@table_id"].Value = int.Parse(table_num.Text);

                update_table_info.ExecuteNonQuery();
                table_num.Items.Clear();
                Close();
            }
        }

        private void paid_sum_text_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (System.DateTime.Parse(System.DateTime.Now.TimeOfDay.ToString("HH:mm")) > System.DateTime.Parse("19:00"))
            {
                MessageBox.Show(">");
            }
            else if (System.DateTime.Parse(System.DateTime.Now.TimeOfDay.ToString("HH:mm")) < System.DateTime.Parse("19:00"))
            {
                MessageBox.Show("<");
            }
            //int sum;
            //double paidTime = 0;
            //if (e.KeyChar != 8 && (e.KeyChar < 48 || e.KeyChar > 57))
            //{
            //    e.Handled = true;
            //    try
            //    {
            //        sum = int.Parse(paid_sum_text_box.Text);
            //        paidTime = sum / opt.getPrice(int.Parse(table_num.Text));
            //        client_TIME_out_field.Value = System.DateTime.Now.AddMinutes(Math.Round(paidTime));
            //        client_TIME_out_field.Update();
            //        Invalidate();
            //    }
            //    catch (FormatException)
            //    {

            //    }
            //}
        }

       
    }
}

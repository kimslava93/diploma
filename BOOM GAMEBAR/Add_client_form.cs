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
        int PAID_NUMERIC_UP_DOWN_IS_CLICKED = 1;
        int DATE_TIME_IS_CLICKED = 2;
        int OTHER_IS_CLICKED = 3;
        int CLICKED_ELEMENT = 3;

        int counter;
        private SqlConnection add_client_to_clients_table_connection;
        private bool op_tables = false;
        private int clientCounter;
        Options opt = new Options();
        List<string> free_tables;
        List<string> clients_info;
        Timer current_time = new Timer();
        double increment_value;
        
        public Add_client_form(int counter)
        {
            clientCounter = counter;
            InitializeComponent();
        }
        private void Add_client_form_Load(object sender, EventArgs e)
        {
            counter = 0;
            current_time.Start();
            current_time.Enabled = true;
            current_time_label.Text = "Time: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            clients_info = new List<string>();
            free_tables = new List<string>();
            GetDataFromDB();
            
            increment_value = opt.getPrice(int.Parse(table_num.Text));
            
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
                
                if (!op_tables)
                {
                    op_tables = true;
                    for (int i = 0; i < free_tables.Count; i++)
                    {
                        table_num.Items.Add(free_tables[i]);
                    }
                }
                if (free_tables.Count > 0 && free_tables[0] != null)
                {
                    table_num.SelectedIndex = 0;
                }
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
                    paid_price_numeric_up_down.Value <= 0 ||
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
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void paid_sum_text_box_TextChanged(object sender, EventArgs e)
        {
            //if (client_DATE_out_field.Value.ToString("dd.MM.yyyy") == DateTime.Now.ToString("dd.MM.yyyy")
            //    && client_TIME_out_field.Value.ToString("HH:mm") == DateTime.Now.ToString("HH:mm"))
            ////if(paid_sum_text_box.Text.Length == 0)
            //{
            ////if (paid_sum_text_box.Text == "" || paid_sum_text_box.Text == null || int.Parse(paid_sum_text_box.Text) >= 100000000)
            ////{
            ////    paid_sum_text_box.Text = "0";
            ////    paid_sum_text_box.SelectAll();
            ////}
            ////int sum = 0;
            ////double paidTime = 0;
            ////try
            ////{
            ////    sum = int.Parse(paid_sum_text_box.Text);
            ////    paidTime = sum / opt.getPrice(int.Parse(table_num.Text));
            ////    client_TIME_out_field.Value = System.DateTime.Now.AddMinutes(Math.Round(paidTime));
            ////    client_DATE_out_field.Value = System.DateTime.Now.AddMinutes(Math.Round(paidTime));

            ////}
            ////catch (FormatException)
            ////{
            ////    MessageBox.Show("Error");
            ////}
        }
        //}

        private void client_TIME_out_field_ValueChanged(object sender, EventArgs e)
        {
                if ((client_DATE_out_field.Value.Date >= DateTime.Now.Date) && client_TIME_out_field.Value.Hour == 0)
                {
                    client_DATE_out_field.Text = client_DATE_out_field.Value.AddDays(1).ToString();
                }
                else if (DateTime.Parse(client_DATE_out_field.Value.ToString("dd.MM.yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm")) <
                                    DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy HH:mm")))
                {
                    client_TIME_out_field.Text = DateTime.Now.ToString("HH:mm");
                }
                if (CLICKED_ELEMENT == 2)
                {
                    if ((client_DATE_out_field.Value.ToString("dd.MM.yyyy") + client_TIME_out_field.Value.ToString("HH:mm") != DateTime.Now.ToString("dd.MM.yyyy HH:mm")))// || (client_DATE_out_field.Value.ToString("dd.MM.yyyy") + client_TIME_out_field.Value.ToString("HH:mm") != DateTime.Now.ToString("dd.MM.yyyy HH:mm") && client_TIME_out_field.Value.Hour == 0))
                    {
                        TimeSpan days_span = DateTime.Parse(client_DATE_out_field.Value.ToString("dd.MM.yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm")).Subtract(DateTime.Now);
                        //MessageBox.Show(client_DATE_out_field.Value.ToString("dd.MM.yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm")+" - \n" + DateTime.Now.ToString("dd.MM.yyyy HH:mm") + " = \n" + 
                        //    days_span.ToString());
                        counter++;
                        double minutes = days_span.TotalMinutes;
                        double price = minutes * opt.getPrice(int.Parse(table_num.Text));
                        if (price < 0)
                        {
                            paid_price_numeric_up_down.Value = 0;
                        }
                        else if ((decimal)price < paid_price_numeric_up_down.Minimum && (decimal)price > paid_price_numeric_up_down.Maximum)
                        {
                            MessageBox.Show("Price is lower than 0 or higher than 30 000 \nIt is very high price please check entered data");
                        }
                        else
                        {
                            paid_price_numeric_up_down.Value = Math.Round((decimal)price, 2);
                        }

                    }
            }
        }

      

        private void table_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            increment_value = opt.getPrice(int.Parse(table_num.Text));
            paid_price_numeric_up_down.Increment = (decimal)increment_value;
            MessageBox.Show(increment_value.ToString());
        }

        private void paid_price_numeric_up_down_ValueChanged(object sender, EventArgs e)
        {
                if (paid_price_numeric_up_down.Value <= 0 || paid_price_numeric_up_down.Value > paid_price_numeric_up_down.Maximum ||
                    paid_price_numeric_up_down.Value < paid_price_numeric_up_down.Minimum)
                {
                    paid_price_numeric_up_down.Value = 0;
                }
                if (CLICKED_ELEMENT == 2)
                {
                    double paidTime = 0;
                    try
                    {
                        paidTime = (double)paid_price_numeric_up_down.Value / opt.getPrice(int.Parse(table_num.Text));
                        client_TIME_out_field.Value = System.DateTime.Now.AddMinutes(Math.Round(paidTime));
                        client_DATE_out_field.Value = System.DateTime.Now.AddMinutes(Math.Round(paidTime));
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Error");
                    }
                }
        }    
        
        private void timer_Tick(object sender, EventArgs e)
        {
            current_time_label.Text = "Time: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void paid_price_numeric_up_down_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
            {
                e.Handled = true;
            }
        }

        private void Add_client_form_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show(CLICKED_ELEMENT + "");
            CLICKED_ELEMENT = 3;

            MessageBox.Show("was clicked 3");
        }

        private void client_DATE_out_field_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("was clicked 2");
            CLICKED_ELEMENT = 2;
        }

        private void client_TIME_out_field_MouseDown(object sender, MouseEventArgs e)
        {
            MessageBox.Show("was clicked 2");
            CLICKED_ELEMENT = 2;
        }

        private void paid_price_numeric_up_down_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("was clicked 1");
            CLICKED_ELEMENT = 1;
        }   
    }
}

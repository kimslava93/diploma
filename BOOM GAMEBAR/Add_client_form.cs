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
        int counter;
        private SqlConnection add_client_to_clients_table_connection;
        private bool op_tables = false;
        private bool op_clients = false;
        private int clientCounter;
        Options opt = new Options();
        List<string> free_tables;
        List<string> clients_info;
        Timer current_time = new Timer();
        double increment_value;
        int last_changed_hour;
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
            if (free_tables.Count > 0 && free_tables[0] != null)
            {
                table_num.SelectedIndex = 0;
            }
            last_changed_hour = client_TIME_out_field.Value.Hour;
            //increment_value = opt.getPrice(int.Parse(table_num.Text));
            
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
                //if (free_tables.Count > 0 && free_tables[0] != null)
                //{
                //    table_num.SelectedIndex = 0;
                //}
            //------------------------Getting all free tables-----------------------------


                SqlCommand command2 = new SqlCommand("SELECT customer_id FROM customers_with_cards", add_client_to_clients_table_connection);
                SqlDataReader reader2 = command2.ExecuteReader();
                while (reader2.Read())
                {
                    clients_info.Add(reader2.GetString(0).ToString());
                }
                reader2.Close();
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
            if (table_num.Text == "" ||
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
                insert_deposit_table = new SqlCommand("INSERT INTO new_client(client_num, " +
                                                                             "time_come, " +
                                                                             "time_out," +
                                                                             "table_id," +
                                                                             "customer_id," +
                                                                             "added_on_cards," +
                                                                             "already_played_sum," +
                                                                             "discount," +
                                                                             "paid_sum," +
                                                                             "comments, " +
                                                                             "client_state)" +

                                                     " VALUES (@client_num, " +
                                                              "@client_come," +
                                                              "@client_out," +
                                                              "@table_id," +
                                                              "@customer_id," +
                                                              "@added_on_card," +
                                                              "'0', " +
                                                              "@discount," +
                                                              "@paid_sum, " +
                                                              "@comments, " +
                                                              "'opened'); ", add_client_to_clients_table_connection);

                insert_deposit_table.Parameters.Add(new SqlParameter("@client_num", SqlDbType.Int));
                insert_deposit_table.Parameters["@client_num"].Value = clientCounter;
               
                insert_deposit_table.Parameters.Add(new SqlParameter("@client_come", SqlDbType.DateTime));
                insert_deposit_table.Parameters["@client_come"].Value = DateTime.Now.ToString("dd.MM.yyyy HH:mm");//client_DATE_out_field.Value.ToString("dd/MMM/yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm");

                insert_deposit_table.Parameters.Add(new SqlParameter("@client_out", SqlDbType.DateTime));
                insert_deposit_table.Parameters["@client_out"].Value = client_DATE_out_field.Value.ToString("dd/MMM/yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm");

                insert_deposit_table.Parameters.Add(new SqlParameter("@table_id", SqlDbType.Int));
                insert_deposit_table.Parameters["@table_id"].Value = int.Parse(table_num.Text);

                insert_deposit_table.Parameters.Add(new SqlParameter("@customer_id", SqlDbType.VarChar));
                insert_deposit_table.Parameters["@customer_id"].Value = combo_box_client_discount_card.Text;

                if (combo_box_client_discount_card.Text != "0")
                {
                    insert_deposit_table.Parameters.Add(new SqlParameter("@added_on_card", SqlDbType.Float));
                    insert_deposit_table.Parameters["@added_on_card"].Value = double.Parse(add_money_on_card_numericUpDown.Text);

                    insert_deposit_table.Parameters.Add(new SqlParameter("@discount", SqlDbType.Float));
                    insert_deposit_table.Parameters["@discount"].Value = 0;

                    insert_deposit_table.Parameters.Add(new SqlParameter("@paid_sum", SqlDbType.Float));
                    insert_deposit_table.Parameters["@paid_sum"].Value = 0;

                    insert_deposit_table.Parameters.Add(new SqlParameter("@comments", SqlDbType.VarChar));
                    insert_deposit_table.Parameters["@comments"].Value = "";
                }
                else
                {
                    insert_deposit_table.Parameters.Add(new SqlParameter("@added_on_card", SqlDbType.Float));
                    insert_deposit_table.Parameters["@added_on_card"].Value = 0;

                    insert_deposit_table.Parameters.Add(new SqlParameter("@discount", SqlDbType.Float)); // need to be made if there are available any discounts
                    insert_deposit_table.Parameters["@discount"].Value = 0;

                    insert_deposit_table.Parameters.Add(new SqlParameter("@paid_sum", SqlDbType.Float)); 
                    insert_deposit_table.Parameters["@paid_sum"].Value = double.Parse(paid_price_numeric_up_down.Value.ToString());

                    insert_deposit_table.Parameters.Add(new SqlParameter("@comments", SqlDbType.VarChar)); // need to be added if necessary 
                    insert_deposit_table.Parameters["@comments"].Value = "";
                }
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

        //private void paid_sum_text_box_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
        //    {
        //        e.Handled = true;
        //    }
        //}

        //private void paid_sum_text_box_TextChanged(object sender, EventArgs e)
        //{
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
        //}

        private void client_TIME_out_field_ValueChanged(object sender, EventArgs e)
        {
            if ((client_DATE_out_field.Value.Date >= DateTime.Now.Date) && client_TIME_out_field.Value.Hour == 0 && last_changed_hour != 00)
            {
                client_DATE_out_field.Text = client_DATE_out_field.Value.AddDays(1).ToString();
            }
            else if (DateTime.Parse(client_DATE_out_field.Value.ToString("dd.MM.yyyy") + " " + client_TIME_out_field.Value.ToString("HH:mm")) <
                                DateTime.Parse(DateTime.Now.ToString("dd.MM.yyyy HH:mm")))
            {
                client_TIME_out_field.Text = DateTime.Now.ToString("HH:mm");
            }
            if (radioButtonTimeOut.Checked == true)
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
            last_changed_hour = client_TIME_out_field.Value.Hour;
        }
        private void table_num_SelectedIndexChanged(object sender, EventArgs e)
        {
            increment_value = opt.getPrice(int.Parse(table_num.Text));
            paid_price_numeric_up_down.Increment = (decimal)increment_value;
        }

        private void paid_price_numeric_up_down_ValueChanged(object sender, EventArgs e)
        {
            if (radioButtonPaidSum.Checked == true)
            {
                if (paid_price_numeric_up_down.Value <= 0 || paid_price_numeric_up_down.Value > paid_price_numeric_up_down.Maximum ||
                    paid_price_numeric_up_down.Value < paid_price_numeric_up_down.Minimum)
                {
                    paid_price_numeric_up_down.Value = 0;
                }

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
        private void radioButtonPaidSum_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonPaidSum.Checked == true)
            {
                radioButtonTimeOut.Checked = false;
                client_DATE_out_field.Enabled = false;
                client_TIME_out_field.Enabled = false;
                client_time_out_label.Enabled = false;

                paid_price_numeric_up_down.Enabled = true;
                paid_sum_label.Enabled = true;
            }
            else
            {
                radioButtonTimeOut.Checked = true;
                client_DATE_out_field.Enabled = true;
                client_TIME_out_field.Enabled = true;
                client_time_out_label.Enabled = true;

                paid_price_numeric_up_down.Enabled = false;
                paid_sum_label.Enabled = false;
            }
        }

        private void radioButtonTimeOut_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonTimeOut.Checked == true)
            {
                radioButtonTimeOut.Checked = true;
                client_DATE_out_field.Enabled = true;
                client_TIME_out_field.Enabled = true;
                client_time_out_label.Enabled = true;

                paid_price_numeric_up_down.Enabled = false;
                paid_sum_label.Enabled = false;
            }
            else
            {
                radioButtonTimeOut.Checked = false;
                client_DATE_out_field.Enabled = false;
                client_TIME_out_field.Enabled = false;
                client_time_out_label.Enabled = false;

                paid_price_numeric_up_down.Enabled = true;
                paid_sum_label.Enabled = true;
            }
        }

        private void Add_client_form_KeyDown(object sender, KeyEventArgs e)
        {
            MessageBox.Show("baskd");
            if (e.KeyCode == Keys.Space)
            {
                if (radioButtonTimeOut.Checked == true)
                {
                    radioButtonPaidSum.Checked = true;
                    radioButtonTimeOut.Checked = false;
                }
                else
                {
                    radioButtonTimeOut.Checked = true;
                    radioButtonPaidSum.Checked = false;
                }
            }
        }

        private void Add_client_form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                MessageBox.Show("");
            }
        }

        private void paid_price_numeric_up_down_KeyUp(object sender, KeyEventArgs e)
        {
            if (radioButtonPaidSum.Checked == true)
            {
                if (paid_price_numeric_up_down.Value <= 0 || paid_price_numeric_up_down.Value > paid_price_numeric_up_down.Maximum ||
                    paid_price_numeric_up_down.Value < paid_price_numeric_up_down.Minimum)
                {
                    paid_price_numeric_up_down.Value = 0;
                }

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

        private void combo_box_client_discount_card_MouseClick(object sender, MouseEventArgs e)
        {
            if (!op_clients)
            {
                op_clients = true;
                for (int i = 0; i < clients_info.Count; i++)
                {
                    combo_box_client_discount_card.Items.Add(clients_info[i]);
                }
            }
        }

        private void combo_box_client_discount_card_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (combo_box_client_discount_card.Text != "0")
            {
                deposit_payment_groupBox.Enabled = false;
                client_info_group_box.Enabled = true;

                SqlCommand get_client_info_command = new SqlCommand("SELECT money_left, customer_name FROM customers_with_cards WHERE customer_id=@customer_id", add_client_to_clients_table_connection);
                get_client_info_command.Parameters.Add(new SqlParameter("@customer_id", SqlDbType.Int));
                get_client_info_command.Parameters["@customer_id"].Value = int.Parse(combo_box_client_discount_card.Text);
                SqlDataReader reader_from_customer_with_cards_table = get_client_info_command.ExecuteReader();
               
                while (reader_from_customer_with_cards_table.Read())
                {
                    client_name_textBox.Text = reader_from_customer_with_cards_table["customer_name"].ToString();
                    clients_money_left_textBox.Text = reader_from_customer_with_cards_table["money_left"].ToString();
                }
                reader_from_customer_with_cards_table.Close();
            }
            else
            {
                deposit_payment_groupBox.Enabled = true;
                client_info_group_box.Enabled = false;

                client_name_textBox.Text = "Usual client";
                clients_money_left_textBox.Text = "0";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }
    }
}

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
    public partial class add_payment_on_card_form : Form
    {
        private SqlConnection put_money_on_card_connection;
        private bool op_clients = false;
        private List<string> clients_info;
        private string customer_id;
        private int selected_index;
        public add_payment_on_card_form(string _customer_id)
        {
            customer_id = _customer_id;
            clients_info = new List<string>();
            get_list_of_clients();
            InitializeComponent();
            open_customer_id_combobox();
            customer_id_comboBox.SelectedIndex = selected_index;
            put_money_on_client_card_numericUpDown1.Value = 0;
        }
        private void get_list_of_clients()
        {
            //------------------------Getting all free tables-----------------------------
            using (put_money_on_card_connection)
            {
                put_money_on_card_connection = new SqlConnection(@"Server= (local)\SQLEXPRESS; Initial Catalog=Boom; Integrated Security=True;");
                put_money_on_card_connection.Open();
                SqlCommand get_client_info = new SqlCommand("SELECT customer_id FROM customers_with_cards", put_money_on_card_connection);
                SqlDataReader read_client_info = get_client_info.ExecuteReader();
                while (read_client_info.Read())
                {
                    if (read_client_info["customer_id"].ToString() != "0")
                    {
                        clients_info.Add(read_client_info["customer_id"].ToString());
                    }
                }
                read_client_info.Close();
            }
        }

        private void get_client_data()
        {
            SqlCommand get_client_info_command = new SqlCommand("SELECT money_left, customer_name, customer_phone, discount, data_of_activation  FROM customers_with_cards WHERE customer_id=@customer_id", put_money_on_card_connection);
            get_client_info_command.Parameters.Add(new SqlParameter("@customer_id", SqlDbType.VarChar));
            get_client_info_command.Parameters["@customer_id"].Value = customer_id_comboBox.Text;
            SqlDataReader read_client_info = get_client_info_command.ExecuteReader();

            while (read_client_info.Read())
            {
                customer_name_textBox.Text = read_client_info["customer_name"].ToString();
                customer_phone_textBox2.Text = read_client_info["customer_phone"].ToString();
                customer_money_left_textBox3.Text = read_client_info["money_left"].ToString() + " soms";
                discount_textbox.Text = (double.Parse(read_client_info["discount"].ToString()) * 100).ToString() + "%";
                data_of_activation_textbox.Text = read_client_info["data_of_activation"].ToString();
            }
            read_client_info.Close();
        }
        private void open_customer_id_combobox()
        {
            //if (clients_info.Count > 0)
            //{
            //    if (!op_clients)
            //    {
            op_clients = true;
            for (int i = 0; i < clients_info.Count; i++)
            {
                customer_id_comboBox.Items.Add(clients_info[i]);
                if (clients_info[i] == customer_id)
                {
                    selected_index = i;
                }
            }
            //    }
            //}
        }
        private void comboBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (clients_info.Count > 0)
            {
                if (!op_clients)
                {
                    op_clients = true;
                    open_customer_id_combobox();
                }
            }
        }

        private void customer_id_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (customer_id_comboBox.Text != "0")
            {
                get_client_data();
            }
        }

        private void put_money_button_Click(object sender, EventArgs e)
        {
            if (put_money_on_client_card_numericUpDown1.Value <= 0)
            {
                put_money_on_client_card_numericUpDown1.Value = 0;
            }
            else if (put_money_on_client_card_numericUpDown1.Value > 0)
            {
                DialogResult put_payment_or_not = MessageBox.Show("Do you want to put "+put_money_on_client_card_numericUpDown1.Value.ToString()+" to "+customer_id_comboBox.Text+" card?",
                                                                    "Question",
                                                                    MessageBoxButtons.YesNo,
                                                                    MessageBoxIcon.Question);
                if (put_payment_or_not == DialogResult.Yes)
                {
                    SqlCommand update_money_left_command;
                    update_money_left_command = new SqlCommand("UPDATE customers_with_cards SET money_left=@money_left WHERE customer_id=@customer_id", put_money_on_card_connection);

                    update_money_left_command.Parameters.Add(new SqlParameter("@money_left", SqlDbType.Float));
                    MessageBox.Show((split_digits_from_string(customer_money_left_textBox3.Text) + (double)put_money_on_client_card_numericUpDown1.Value).ToString());
                    update_money_left_command.Parameters["@money_left"].Value = split_digits_from_string(customer_money_left_textBox3.Text) + (float)put_money_on_client_card_numericUpDown1.Value;

                    update_money_left_command.Parameters.Add(new SqlParameter("@customer_id", SqlDbType.VarChar));
                    update_money_left_command.Parameters["@customer_id"].Value = customer_id_comboBox.Text;

                    update_money_left_command.ExecuteNonQuery();
                    get_client_data();
                    Close();
                }
                else if (put_payment_or_not == DialogResult.No)
                {
                    Close();
                }
            }
        }
        private double split_digits_from_string(string data)
        {
            data = data.Substring(0, data.Length - 4);
            return double.Parse(data);
        }
    }
}

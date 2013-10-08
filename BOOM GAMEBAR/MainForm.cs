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
    public partial class BOOM : Form
    {
        private SqlConnection clients_connection;
        private int clients_number;
        private string column_client_num = "Client #";
        private string column_table_num = "Table #";
        private string column_time_start = "Time start";
        private string column_time_out = "Time out";
        private string column_discount_id = "Discount id";
        private string column_discount_sum = "Discount sum";
        private string column_total_sum = "Total sum";
        private string column_table_state= "Table state";

        public BOOM()
        {
            Application.EnableVisualStyles();
            InitializeComponent();
        }

        private void BOOM_Load(object sender, EventArgs e)
        {
            UpdateData();
            set_columns_names();

        }
        private void set_columns_names()
        {
            clients_table.Columns[0].HeaderText = column_client_num;
            clients_table.Columns[1].HeaderText = column_table_num;
            clients_table.Columns[2].HeaderText = column_time_start;
            clients_table.Columns[3].HeaderText = column_time_out;
            clients_table.Columns[4].HeaderText = column_discount_id;
            clients_table.Columns[5].HeaderText = column_discount_sum;
            clients_table.Columns[6].HeaderText = column_total_sum;
            clients_table.Columns[7].HeaderText = column_table_state;
        }
        private void UpdateData()
        {
            clients_connection = new SqlConnection(@"Server= (local)\SQLEXPRESS; Initial Catalog=Boom; Integrated Security=True;");
            clients_connection.Open();
            SqlDataAdapter data_adapter = new SqlDataAdapter("SELECT * FROM new_client", clients_connection);
            SqlCommandBuilder sql_commandbuilder = new SqlCommandBuilder(data_adapter);
            DataSet data_set = new DataSet();
            data_adapter.Fill(data_set, "client_table");
            clients_table.DataSource = data_set.Tables[0];
            for (int i = 0; i < clients_table.Columns.Count - 1; i++)
            {
                clients_table.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            foreach (DataGridViewRow row in clients_table.Rows)
            {
                if (row.Cells[0].Value == null)
                {
                    continue;
                }
                else if (row.Cells[2].Value.ToString() == row.Cells[3].Value.ToString())
                {
                    row.DefaultCellStyle.BackColor = Color.Yellow;
                }
            }
            clients_number = clients_table.Rows.Count;
        }
        private void clients_table_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void add_client_button_Click(object sender, EventArgs e)
        {
            Add_client_form open_add_client_form = new Add_client_form();
            open_add_client_form.ShowDialog();
            UpdateData();
        }
    }
}

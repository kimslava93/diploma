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
    class close_client_class
    {
        DataGridView datagridview;
        int clicked_row;
        public close_client_class(DataGridView _dgv, int _clicked_row)
        {
            datagridview = _dgv;
            clicked_row = _clicked_row;
        }

        private void close()
        {
            //opt = new Options();
            //if (datagridview.CurrentRow == null)
            //{
            //    MessageBox.Show("Please choose any field!");
            //}
            //else if (clicked_row != -1 && datagridview.CurrentRow.Cells[2].Value.ToString() == datagridview.CurrentRow.Cells[3].Value.ToString())
            //{
            //    if (MessageBox.Show("Are ou sure that you want to close table#" + datagridview.CurrentRow.Cells[1].Value.ToString() + " ?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            //    {
            //        SqlCommand update_client_info;
            //        update_client_info = new SqlCommand("UPDATE new_client SET time_out = @cur_time, client_state = 'closed' WHERE client_num = @client_num;", con);
            //        update_client_info.Parameters.Add(new SqlParameter("@client_num", SqlDbType.Int));
            //        update_client_info.Parameters["@client_num"].Value = clicked_row;

            //        update_client_info.Parameters.Add(new SqlParameter("@cur_time", SqlDbType.DateTime));
            //        update_client_info.Parameters["@cur_time"].Value = System.DateTime.Now;

            //        update_client_info.ExecuteNonQuery();
            //        DoesClientHasDiscount dchd = new DoesClientHasDiscount(clicked_row, dataGridView1.CurrentRow.Cells[4].Value.ToString());
            //        dchd.ShowDialog();

            //        UpdateData();

            //        double price = (opt.getPrice(int.Parse(datagridview.Rows[datagridview.CurrentRow.Index].Cells[1].Value.ToString())));

            //        SqlCommand command2;
            //        command2 = new SqlCommand("(SELECT discount FROM customer WHERE customer_id=(SELECT customer_id FROM new_client WHERE client_num = @client_num))", con);
            //        command2.Parameters.Add(new SqlParameter("@client_num", SqlDbType.VarChar));
            //        command2.Parameters["@client_num"].Value = clicked_row;

            //        double dr = double.Parse(command2.ExecuteScalar().ToString()) / 100;//discount
            //        //MessageBox.Show("discount in % = " + (dr).ToString());

            //        SqlCommand difference_between_two_dates = new SqlCommand("(SELECT CAST(DATEDIFF(minute,(SELECT time_come from new_client WHERE client_num = @client_num), (SELECT time_out from new_client WHERE client_num = @client_num )) AS FLOAT(56)));", con);
            //        difference_between_two_dates.Parameters.Add(new SqlParameter("@client_num", SqlDbType.Int));
            //        difference_between_two_dates.Parameters["@client_num"].Value = clicked_row;

            //        double dr2 = double.Parse(difference_between_two_dates.ExecuteScalar().ToString());//difference between two times

            //        //MessageBox.Show("difference between two dates= " + dr2);
            //        double discount = dr * (dr2 * price);

            //        // MessageBox.Show("Discount in money= " + discount.ToString());
            //        SqlCommand free_closed_table;
            //        free_closed_table = new SqlCommand("UPDATE tables_info SET table_state='free' WHERE table_id=(SELECT table_id from new_client WHERE client_num = @client_num)" +
            //                                 "UPDATE new_client SET  discount = @discount, total_cost = @total_sum WHERE client_num = @client_num;", con);
            //        free_closed_table.Parameters.Add(new SqlParameter("@client_num", SqlDbType.Int));
            //        //MessageBox.Show(clicked_column_index.ToString());
            //        free_closed_table.Parameters["@client_num"].Value = clicked_row;

            //        free_closed_table.Parameters.Add(new SqlParameter("@discount", SqlDbType.Int));
            //        free_closed_table.Parameters["@discount"].Value = (int)discount;

            //        free_closed_table.Parameters.Add(new SqlParameter("@total_sum", SqlDbType.Int));
            //        free_closed_table.Parameters["@total_sum"].Value = (int)((int)(dr2 * price) - (int)discount);

            //        free_closed_table.ExecuteNonQuery();
            //        UpdateData();
            //        //if (dataGridView1.Rows[clicked_column_index].Cells[4].Value.ToString() != "0")
            //        //{
            //        //    SqlCommand updateHistory = new SqlCommand("INSERT INTO customer_game_history VALUES(@customer_id, @date_time, @discount_price)",con);
            //        //    updateHistory.Parameters.Add(new SqlParameter("@customer_id", SqlDbType.VarChar));
            //        //    updateHistory.Parameters["@customer_id"].Value = dataGridView1.Rows[clicked_column_index].Cells[4].Value.ToString();

            //        //    updateHistory.Parameters.Add(new SqlParameter("@date_time", SqlDbType.DateTime));
            //        //    updateHistory.Parameters["@date_time"].Value = dataGridView1.Rows[clicked_column_index].Cells[2].Value.ToString();

            //        //}
            //        clicked_row = -1;
            //    }
            //}
        }
    }
}

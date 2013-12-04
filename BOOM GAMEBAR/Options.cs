using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BOOM_GAMEBAR
{
    class Options
    {
        public void switch_on_TV(int table_num)
        {}
        public void switch_off_TV(int table_num)
        {}
        public bool get_status_of_table(int table_num)
        {
            bool result = false;
            return result;
        }

        public double getPrice(int table_num)
        {
            double result = 0.0;
            if (System.DateTime.Parse(System.DateTime.Now.ToString("HH:mm")) < System.DateTime.Parse("19:00"))
            {
                if (table_num > 0 && table_num < 8)
                {
                    result = (double)80 / (double)60;
                }
                else if (table_num == 8)
                {
                    result = (double)100 / (double)60;
                }
                else if (table_num == 9 || table_num == 11)
                {
                    result = (double)160 / (double)60;
                }
                else if (table_num == 12)
                {
                    result = (double)300 / (double)60;
                }
                else
                {
                    string temp = "Error there is no table #" + table_num.ToString();
                    MessageBox.Show(temp);
                    return 0;
                }
            }
            else if (System.DateTime.Parse(System.DateTime.Now.ToString("HH:mm")) > System.DateTime.Parse("19:00"))
            {
                if (table_num > 0 && table_num < 8)
                {
                    result = (double)90 / (double)60;
                }
                else if (table_num == 8)
                {
                    result = (double)120 / (double)60;
                }
                else if (table_num == 9 || table_num == 11)
                {
                    result = (double)180 / (double)60;
                }
                else if (table_num == 12)
                {
                    result = (double)320 / (double)60;
                }
                else
                {
                    string temp = "Error there is no table #" + table_num.ToString();
                    MessageBox.Show(temp);
                    return 0;
                }
            }
            return result;
        }

    }
}

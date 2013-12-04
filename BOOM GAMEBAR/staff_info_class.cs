using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace BOOM_GAMEBAR
{
    class staff_info_class
    {
        private string person_id;
        private string name;
        private string login;
        private string password;
        private string position;
        private string phone;
        private string additional_phone;
        private DateTime birthday;
        private string home_address;
        private double salary_per_day;

        SqlConnection connection_get_all_staff_info;

        public staff_info_class()
        {
            //person_id = _person_id;
            //name = _name;
            //position = _position;
            //phone = _phone;
            //additional_phone = _additional_phone;
            //birthday = _birthday;
            //home_address = _home_address;
            //salary_per_day = _salary_per_day;
        }

        public List<staff_info_class> get_all_objects()
        {
            connection_get_all_staff_info = new SqlConnection(@"Server= (local)\SQLEXPRESS; Initial Catalog=BoomDB; Integrated Security=True;");
            List<staff_info_class> result_list_of_staff_info = new List<staff_info_class>();
            staff_info_class result_staff_info;
            connection_get_all_staff_info.Open();
            SqlCommand command_get_all_staff_info = new SqlCommand("SELECT * FROM personal_info_t", connection_get_all_staff_info);
            SqlDataReader reader = command_get_all_staff_info.ExecuteReader();

            while (reader.Read())
            {
                result_staff_info = new staff_info_class();
                result_staff_info.person_id = reader["person_id"].ToString();
                result_staff_info.name = reader["name"].ToString();
                result_staff_info.password = reader["staff_password"].ToString();
                result_staff_info.position = reader["position"].ToString();
                result_staff_info.phone = reader["phone"].ToString();
                result_staff_info.additional_phone = reader["additional_phone"].ToString();
                result_staff_info.birthday = DateTime.Parse(reader["birthday"].ToString());
                result_staff_info.home_address = reader["home_address"].ToString(); ;
                result_staff_info.salary_per_day = double.Parse(reader["salary_per_day"].ToString());
                
                result_list_of_staff_info.Add(result_staff_info);
            }
            return result_list_of_staff_info;
        }

        public string get_person_id 
        {
            get
            {
                return person_id;
            }
        }
        public string get_name 
        {
            get
            {
                return name;
            }
        }
        public string get_login
        {
            get
            {
                return login;
            }
        }
        public string get_password 
        {
            get 
            {
                return password;
            }
        }
        public string get_position
        {
            get
            {
                return position;
            }
        }
        public string get_phone
        {
            get
            {
                return phone;
            }
        }
        public string get_additional_phone 
        {
            get 
            {
                return additional_phone;
            }
        }
        public DateTime get_birthday
        {
            get
            {
                return birthday;
            }
        }
        public string get_home_address
        {
            get
            {
                return home_address;
            }
        }
        public double get_salary_per_day
        {
            get
            {
                return salary_per_day;
            }
        }
    }
}

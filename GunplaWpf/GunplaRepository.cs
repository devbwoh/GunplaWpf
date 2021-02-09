using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GunplaWpf {
    class GunplaRepository {
        MySqlConnection dbc = null;

        public string Connect() {
            string con = "server=13.125.30.184;port=58615;user=root;database=gunpladb;password=mysql1234;charset=utf8";
            dbc = new MySqlConnection(con);
            try {
                dbc.Open();
            }
            catch (Exception ex) {
                return ex.ToString();
            }
            return null;
        }

        public void Close() {
            dbc.Close();
        }

        public DataTable Mechanic() {
            MySqlDataAdapter adapter;
            string query = "SELECT * FROM mechanic";
            adapter = new MySqlDataAdapter(query, dbc);

            DataTable table = new DataTable("mechanic");
            adapter.Fill(table);

            return table;
        }
    }

}

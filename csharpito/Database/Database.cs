using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace csharpito {
    static class Database {

        public static MySqlConnection connection;

        // REMOVER LASTNAME E DATACREATED OU REMOVER O NOT NULL
        // CRIAR O METODO SOMENTE ATRIBUINDO A ELE

        public static void ConnectionWithDB() {

            string __DBINFO__ = "datasource=localhost;username=root;password=root;database=newron";
            connection = new MySqlConnection(__DBINFO__);

            if (connection.State == ConnectionState.Open) {
                return;
            }

        }

        public static void InsertDB(string username, string password, string email) {
            
            // string __QUERY_SELECT__ = "SELECT FROM newron (users) WHERE" +
            string __QUERY_INSERT__ = "INSERT INTO users (name, password, email) "
                          + "VALUES"
                          + "('"
                          + username
                          + "', '"
                          + password
                          + "', '"
                          + email
                          + " ') ";


            MySqlCommand command = new MySqlCommand(__QUERY_INSERT__, connection);
            ConnectionWithDB();
            command.ExecuteReader();
        }

        public static void SelectInDB(string username, string password, string email) {
            string __QUERY_SELECT__ = "SELECT name, password, email FROM users  WHERE name = " + username + " AND password = " + password + " AND email = " + email;

            MySqlCommand command = new MySqlCommand(__QUERY_SELECT__, connection);

            ConnectionWithDB();
            command.ExecuteReader();

            if (command.ExecuteNonQuery() > 0) {
                MessageBox.Show("NAO", "cLOSE", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            } else {
                MessageBox.Show("HM");
            }
        }


    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;

namespace MRodriguezACP2_2
{
    public partial class frmDatabase : Form
    {
        SQLiteConnection sqlite_conn;

        string myInfo;


        public frmDatabase()
        {
            InitializeComponent();
        }

        private void frmDatabase_Load(object sender, EventArgs e)
        {
            sqlite_conn = CreateConnection();
        }

        static SQLiteConnection CreateConnection()
        {
            SQLiteConnection sqlite_conn;
            sqlite_conn = new SQLiteConnection("Data Source = nfl.db");
            //open connection
            try
            {
                sqlite_conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return sqlite_conn;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new frmAbout().Show();
        }

        private void frmDatabase_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateTable_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd;
            cmd = sqlite_conn.CreateCommand();
            //drop it if it there
            cmd.CommandText = "DROP TABLE IF EXISTS nfl";
            cmd.ExecuteNonQuery();
            //create table with 4 columns, primary key, title, main character, genre, release year;
            cmd.CommandText = @"CREATE TABLE nfl(id INTEGER PRIMARY KEY, team_name TEXT, conference TEXT, state TEXT, year_established INT, superbowls_won INT, seasons_played INT)";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your table has be created", "Table Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnInsertData_Click(object sender, EventArgs e)
        {
            SQLiteCommand cmd;
            cmd = sqlite_conn.CreateCommand();
            //insert 15 rows into game table
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tDallas Cowboys', '\tNFC East\t', '\tTexas\t\t', \t1960\t\t\t, \t\t\t\t\t\t5\t\t\t, \t62)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tNew York Giants', '\tNFC East', '\t\tNew York\t\t', 1925\t\t\t, \t\t\t\t\t\t4\t\t\t, \t96)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tPhiladelphia Eagles', '\tNFC East', '\t\tPennsylvania\t', 1933\t\t\t, \t\t\t\t\t\t1\t\t\t, \t62)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tWashington Football Team', 'NFC East\t\t', 'Maryland\t\t', 1932\t\t, \t\t\t\t\t\t3\t\t\t, \t90)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tArizona Cardinals\t', 'NFC West\t', 'Arizona\t\t', 1898\t\t\t, \t\t\t\t\t\t0\t\t\t, \t62)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tLos Angeles Rams\t', 'NFC West\t', 'California\t\t', 1936\t\t\t, \t\t\t\t\t\t1, \t85)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tSan Francisco 49ers', 'NFC West\t', 'California\t\t', 1946\t\t\t, \t\t\t\t\t\t5\t\t\t, \t76)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tSeattle Seahawks\t', 'NFC West\t', 'Washington\t', 1974\t\t\t, \t\t\t\t\t\t1\t\t\t, \t45)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tCarolina Panthers\t', 'NFC South\t', 'North Carolina\t', 1993\t\t\t, \t\t\t\t\t\t0\t\t\t, \t27)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tTampa Bay Buccaneers', 'NFC South\t', 'Florida\t\t', 1976\t\t\t, \t\t\t\t\t\t2\t\t\t, \t46)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tNew Orleans Saints\t', 'NFC South\t', 'Louisiana\t\t', 1967\t\t\t, \t\t\t\t\t\t1\t\t\t, \t55)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tAtlanta Falcons\t', 'NFC South\t', 'Georgia\t\t', 1965\t\t\t, \t\t\t\t\t\t0\t\t\t, \t\t\t56)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tMinnesota Vikings\t', 'NFC North\t', 'Minnesota\t', 1960\t\t\t, \t\t\t\t\t\t0\t\t\t, \t56)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tGreen Bay Packers\t', 'NFC North\t', 'Wisconsin\t', 1919\t\t\t, \t\t\t\t\t\t4\t\t\t, \t101)";
            cmd.ExecuteNonQuery();
            cmd.CommandText = "INSERT INTO nfl(team_name, conference, state, year_established, superbowls_won, seasons_played) VALUES ('\tDetroit Lions\t', 'NFC North\t', 'Michigan\t\t', 1929\t\t\t, \t\t\t\t\t\t0\t\t\t, \t92)";
            cmd.ExecuteNonQuery();
            MessageBox.Show("Your rows have been created", "Rows Created", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDisplayData_Click(object sender, EventArgs e)
        {
            new frmDisplay(sqlite_conn).Show();
        }


        private StringBuilder GenerateReport()
        {
            StringBuilder html = new StringBuilder();
            StringBuilder css = new StringBuilder();
            //www.w3schools.com/Css/css_syntax.asp
            css.Append("<style>");
            css.Append("td {padding:5px;text-align:center;font-weight:bold;text-align:center;}");
            css.Append("h1{color: green;}");
            css.Append("</style>");
            // HTML is used to format the layout of a webpage. This will be the frame
            // we use to place our data in. CSS is used to style the page to look a
            // certain way.

            // The <HTML> and </HTML> tags are the start and end of a webpage.
            // The <HTML> and </HTML> tags gives information about the webpage
            // such as the title and if there is any CSS styles being used.
            // The text between the <TITLE> and </TITLE> tags are used by the 
            // browser to display the name of the page.
            // <BODY> and </BODY> is where the data of the page is stored
            // <H1> and </H1> is the largest font size for the headings. These
            // can be from H1 to H6. H6 is the smallest font.

            html.Append("<html>");
            html.Append($"<head>{css}<title>{"NFL Team Information"}</title></head>");
            html.Append("<body>");
            html.Append($"<h1>{"NFL Team Information"}</h1>");

            //Create table data
            // <TABLE> and </TABLE> is the start and end of a table of rows and data.
            // <TR> and </TR> is one row of data. They contain <TD> and </TD> tags.
            // <TD> and </TD> represents the data inside of the table in a particular row.
            // https://www.w3schools.com/tags/tag_table.asp

            // I used an <HR /> tag which is a "horizontal rule" as table data.
            // You can "span" it across multiple columns of data.
            SQLiteDataReader dr;
            SQLiteCommand cmd;
            cmd = sqlite_conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM nfl";
            //use reader to get data from table
            dr = cmd.ExecuteReader();
            html.Append("<table>");
            html.Append("<tr><td colspan=8><hr/></td></tr>");
            html.Append("<tr>");

            while (dr.Read())
            {
                myInfo = dr.GetInt32(0) + "\t" + dr.GetString(1) + "\t" + dr.GetString(2) + "\t" + dr.GetString(3) + "\t" + dr.GetInt32(4) + "\t" + dr.GetInt32(5) + "\t" + dr.GetInt32(6);
                html.Append($"<td>{dr.GetInt32(0)}</td>");
                html.Append($"<td>{dr.GetString(1)}</td>");
                html.Append($"<td>{dr.GetString(2)}</td>");
                html.Append($"<td>{dr.GetString(3)}</td>");
                html.Append($"<td>{dr.GetInt32(4)}</td>");
                html.Append($"<td>{dr.GetInt32(5)}</td>");
                html.Append($"<td>{dr.GetInt32(6)}</td>");
                html.Append("</tr>");
            }
            html.Append("<tr><td colspan=8><hr/></td></tr>");
            html.Append("</table>");
            html.Append("</body></html>");
            return html;
        }

        private void PrintReport(StringBuilder html)
        {
            //write to hard drive using the name report.html
            try
            {
                //using statement will automatically close a file after opening it
                using (StreamWriter wr = new StreamWriter("Report.html"))
                {
                    wr.WriteLine(html);
                }
                System.Diagnostics.Process.Start(@"Report.html");
            }
            catch (Exception)
            {
                MessageBox.Show("You don't have write permissions", "Error System Permission", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DateTime today = DateTime.Now;
            using (StreamWriter wr = new StreamWriter($"{today.ToString("yyyy-MM-dd-HHmmss")} - Report.html"))
            {
                wr.WriteLine(html);
            }
        }

        private void btnGenerateReport_Click(object sender, EventArgs e)
        {
            PrintReport(GenerateReport());
        }
    }
}

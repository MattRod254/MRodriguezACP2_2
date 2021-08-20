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
    public partial class frmDisplay : Form
    {
        SQLiteConnection _sqlite_conn;
        string myInfo;

        public frmDisplay(SQLiteConnection conn)
        {
            _sqlite_conn = conn;
            InitializeComponent();
        }

        private void frmDisplay_Load(object sender, EventArgs e)
        {
            SQLiteDataReader dr;
            SQLiteCommand cmd;
            cmd = _sqlite_conn.CreateCommand();
            cmd.CommandText = "SELECT * FROM nfl";
            //use reader to get data from table
            dr = cmd.ExecuteReader();
            lbxResults.Items.Add("ID\t\tTeam Name\t\tConference\t\tState\t\tYear Established\t\tSuper Bowls Won\t\tSeasons Played");
            while (dr.Read())
            {
                myInfo = dr.GetInt32(0) + "\t" + dr.GetString(1) + "\t" + dr.GetString(2) + "\t" + dr.GetString(3) + "\t" + dr.GetInt32(4) + "\t" + dr.GetInt32(5) + "\t" + dr.GetInt32(6);
                lbxResults.Items.Add(myInfo);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BetaMart
{
    class CRUD
    {
        private static string getConnectionString()
        {
            string conString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath;
            conString += "\\db_betamart.accdb;Persist Security Info=False;";
            return conString;
        }

        public static OleDbConnection con = new OleDbConnection(getConnectionString());
        public static OleDbCommand cmd = default(OleDbCommand);
        public static string sql = string.Empty;

        public static DataTable PerformCRUD(OleDbCommand com)
        {
            OleDbDataAdapter da = default(OleDbDataAdapter);
            DataTable dt = new DataTable();
            try
            {
                da = new OleDbDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);
                return dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("An Error Occurred: " + ex.Message,
                    "Perform CRUD Operation Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
            return dt;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace MyGUiAppFirst
{
    public partial class FormDB : Form
    {
        private SqlConnection sqlCon = null;
        private SqlCommand sqlCmd;
        private SqlDataReader sqlReader;
        private string str;
        private DataTable deptdataTable;
        public FormDB()
        {
            InitializeComponent();
        }

        private void FormDB_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = ListAllDeptsSecond(); //ListAllDepts();
        }
        public SqlConnection GetConnection()
        {

            if (sqlCon.State != ConnectionState.Open)
            {

            }
            return sqlCon;
        }
        public DataTable ListAllDepts()
        {
            str = ConfigurationManager.ConnectionStrings["CnStr"].ToString();
            sqlCon = new SqlConnection(str);
            sqlCon.Open();

            //sqlCon.Open();
            sqlCmd = new SqlCommand("SELECT * FROM DEPT", sqlCon);

            DataTable deptdataTable = new DataTable();
            sqlReader = sqlCmd.ExecuteReader();
            deptdataTable.Load(sqlReader);




            return deptdataTable;
        }



        public DataTable ListAllDeptsSecond()
        {
            str = ConfigurationManager.ConnectionStrings["CnStr"].ToString();
            sqlCon = new SqlConnection(str);
            SqlDataAdapter sqlAdapter = new SqlDataAdapter("Select * from dept", sqlCon);
            DataSet dSet = new DataSet();
            sqlAdapter.Fill(dSet, "Dept");
            return dSet.Tables["Dept"]; ;

        }
    }
}

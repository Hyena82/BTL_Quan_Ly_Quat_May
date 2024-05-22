using System.Data;
using System.Data.SqlClient;

namespace BTL_Quan_Ly_Quat_May
{
    public partial class FormDashboard : Form
    {
        private SqlConnection myConnection;
        private SqlDataAdapter myDataAdapter;
        private DataSet myDataSet;
        private DataTable myTable;
        private int pos = 0;
        string connectString = @"Data Source=DESKTOP-A6GOITV;Initial Catalog=QL_Quat_May;Integrated Security=True;Encrypt=False";
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormDashboard_Load(object sender, EventArgs e)
        {
            myConnection = new SqlConnection(connectString);
            myConnection.Open();

            string SqlStr = "SELECT * FROM QuatMay"; 
            //Tao thong qua xau ket noi da mo 
            myDataAdapter = new SqlDataAdapter(SqlStr, myConnection);
            myDataSet = new DataSet();
            myDataAdapter.Fill(myDataSet, "QuatMay");
            myTable = myDataSet.Tables["QuatMay"];
            //Chuyen len luoi 
            dataGridView1.DataSource = myTable;
            dataGridView1.AutoGenerateColumns = false;
        }
    }
}

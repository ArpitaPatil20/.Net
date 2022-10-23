using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Student_Information_System
{
    public partial class frm_View_Student_List : Form
    {
        public frm_View_Student_List()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-UQSM4G5R;Initial Catalog=Student_Information_DB;Integrated Security=True");
       void Con_Open()
        {
            if (Con.State!=ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if(Con.State!=ConnectionState.Closed)
            {
                Con.Close();
            }
        }
        private void btn_Log_Out_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();
            ANS.Show();
            this.Hide();
        }
        private void btn_Add_New_Student_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student AND = new frm_Add_New_Student();
            AND.Show();
            this.Hide();
        }
        private void frm_View_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Information_DBDataSet3.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.student_Information_DBDataSet3.Student_Details);
            // TODO: This line of code loads data into the 'student_Information_DBDataSet2.Student_Details' table. You can move, or remove it, as needed.
        }
    }
}

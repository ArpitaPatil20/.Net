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
namespace Student_Management_System
{
    public partial class frm_Add_New_Student : Form
    {
        public frm_Add_New_Student()
        {
            InitializeComponent();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=LAPTOP-UQSM4G5R;Initial Catalog=Student_Management_System_DB;Integrated Security=True");
        void Con_Open()
        {
            if (Con.State != ConnectionState.Open)
            {
                Con.Open();
            }
        }
        void Con_Close()
        {
            if (Con.State != ConnectionState.Closed)
            {
                Con.Close();
            }
        }    
        private void btn_Search_Student_Details_Click(object sender, EventArgs e)
        {
            frm_Search_Student SS = new frm_Search_Student();
            SS.Show();
            this.Hide();
        }
       private void btn_View_All_Student_List_Click(object sender, EventArgs e)
        {
            frm_View_All_Student_List VASL = new frm_View_All_Student_List();
            VASL.Show();
            this.Hide();
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            DialogResult Res = MessageBox.Show("Are You Shoure Want To LogOut???", "LOGUT", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (Res == DialogResult.Yes)
            {
                frm_Student_Login SL = new frm_Student_Login();
                SL.Show();
                this.Hide();
            }
        }
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
          private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        int Auto_Incr()
        {
            int Cnt = 0;
            Con_Open();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = Con;
            Cmd.CommandText = "Select Count(*)From Student_Details";
            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());
            if (Cnt > 0)
            {
                Cmd.CommandText = "Select Max(Roll_No)From Student_Details";
                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
            }
            else
            {
                Cnt = 101;
            }
            Con_Close();
            return Cnt;
        }
        void clear_Controls()
        {
            tb_Roll_No.Text = Convert.ToString(Auto_Incr());
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "01/06/2003";
        }
        private void frm_Add_New_Student_Load(object sender, EventArgs e)
        {
            clear_Controls();
            tb_Name.Focus();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            Con_Open();
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = Con;
                cmd.CommandText = "Insert Into Student_Details(Name,Roll_No,DOB,Mobile_No,Course)Values(@Name,@RNo,@Dob,@MobNo,@Course)";
                cmd.Parameters.Add("Name", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Dob", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("MobNo", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;
                cmd.ExecuteNonQuery();
                MessageBox.Show("Record Save Succesfilly");
                clear_Controls();
            }
            else
            {
                MessageBox.Show("Fill All Fields");
            }
            Con_Close();
        }
    }
}  
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Students_Information_Managment_System
{
    public partial class frm_View_Student_Details : Form
    {
        public frm_View_Student_Details()
        {
            InitializeComponent();
        }
        
        private void frm_View_Student_Details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'student_Details_DBDataSet.Student_Information' table. You can move, or remove it, as needed.
            this.student_InformationTableAdapter.Fill(this.student_Details_DBDataSet.Student_Information);
        }
        private void btn_LogOut_Click(object sender, EventArgs e)
        {
            frm_Login_Form LF = new frm_Login_Form();
            LF.Show();
            this.Hide();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            frm_Add_New_Student ANS = new frm_Add_New_Student();
            ANS.Show();
            this.Hide();
        }
    }
}

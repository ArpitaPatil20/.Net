using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Student_Management_System
{
    public partial class frm_Student_Login : Form
    {
        public frm_Student_Login()
        {
            InitializeComponent();
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text == "Admin" && tb_Password.Text == "1234")
            {
                MessageBox.Show("Login Succesesful", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student AND = new frm_Add_New_Student();
                AND.Show();
                this.Hide();
            }
            else
            { 
                lbl_Error.Visible = true;
                lbl_Error.ForeColor = Color.Red;
            }
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();
        }
        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)||(e.KeyChar==(char)Keys.Back)||(e.KeyChar==(char)Keys.Space)))
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
    }
}


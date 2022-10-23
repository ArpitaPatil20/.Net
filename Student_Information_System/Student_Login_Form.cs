using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Student_Information_System
{
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }
        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_Username.Text=="Admin" && tb_Password.Text=="123")
            {
                MessageBox.Show("Login Succesessfull", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frm_Add_New_Student AND = new frm_Add_New_Student();
                AND.Show();
                this.Hide();
            }
            else
            {
                lbl_Error.Visible = true;
            }
            tb_Username.Clear();
            tb_Password.Clear();
            tb_Username.Focus();
        }
        private void only_Text(object sender, KeyPressEventArgs e)
        {
            if (! (char.IsLetter(e.KeyChar)||(e.KeyChar == (char)Keys.Back) ||(e.KeyChar==(char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
           if(!(char.IsDigit(e.KeyChar)||(e.KeyChar==(char)Keys.Back)||(e.KeyChar==(char)Keys.Space)))
           {
                 e.Handled = true;
           }
        }
    }
}
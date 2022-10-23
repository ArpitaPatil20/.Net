
namespace Student_Management_System
{
    partial class frm_Student_Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Student_Login));
            this.lbl_Login_Form = new System.Windows.Forms.Label();
            this.lbl_Username = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.tb_Username = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Login_Form
            // 
            this.lbl_Login_Form.AutoSize = true;
            this.lbl_Login_Form.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Login_Form.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Form.Location = new System.Drawing.Point(339, 88);
            this.lbl_Login_Form.Name = "lbl_Login_Form";
            this.lbl_Login_Form.Size = new System.Drawing.Size(376, 70);
            this.lbl_Login_Form.TabIndex = 0;
            this.lbl_Login_Form.Text = "  Login Form  ";
            // 
            // lbl_Username
            // 
            this.lbl_Username.AutoSize = true;
            this.lbl_Username.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Username.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Username.Location = new System.Drawing.Point(134, 233);
            this.lbl_Username.Name = "lbl_Username";
            this.lbl_Username.Size = new System.Drawing.Size(209, 51);
            this.lbl_Username.TabIndex = 1;
            this.lbl_Username.Text = "Username";
            // 
            // lbl_Password
            // 
            this.lbl_Password.AutoSize = true;
            this.lbl_Password.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Password.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.Location = new System.Drawing.Point(134, 408);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(198, 51);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            // 
            // tb_Username
            // 
            this.tb_Username.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Username.Location = new System.Drawing.Point(722, 233);
            this.tb_Username.MaxLength = 120;
            this.tb_Username.Name = "tb_Username";
            this.tb_Username.Size = new System.Drawing.Size(420, 58);
            this.tb_Username.TabIndex = 1;
            this.tb_Username.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(722, 405);
            this.tb_Password.MaxLength = 10;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '*';
            this.tb_Password.Size = new System.Drawing.Size(420, 58);
            this.tb_Password.TabIndex = 2;
            this.tb_Password.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_Submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Submit.ForeColor = System.Drawing.Color.Black;
            this.btn_Submit.Location = new System.Drawing.Point(462, 567);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(179, 72);
            this.btn_Submit.TabIndex = 3;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Error
            // 
            this.lbl_Error.AutoSize = true;
            this.lbl_Error.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.lbl_Error.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.ForeColor = System.Drawing.Color.Red;
            this.lbl_Error.Location = new System.Drawing.Point(427, 509);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(268, 20);
            this.lbl_Error.TabIndex = 7;
            this.lbl_Error.Text = "Enter Valid Username && Password";
            this.lbl_Error.Visible = false;
            // 
            // frm_Student_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 727);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Username);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_Username);
            this.Controls.Add(this.lbl_Login_Form);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Student_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Management System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login_Form;
        private System.Windows.Forms.Label lbl_Username;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.TextBox tb_Username;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Error;
    }
}


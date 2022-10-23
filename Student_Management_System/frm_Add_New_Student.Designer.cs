
namespace Student_Management_System
{
    partial class frm_Add_New_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Add_New_Student));
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.lbl_Add_New_Student = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.btn_Save = new System.Windows.Forms.Button();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_View_All_Student_List = new System.Windows.Forms.Button();
            this.btn_Search_Student_Details = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LogOut.ForeColor = System.Drawing.Color.Red;
            this.btn_LogOut.Location = new System.Drawing.Point(1043, 1);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(189, 59);
            this.btn_LogOut.TabIndex = 0;
            this.btn_LogOut.Text = "LogOut";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // lbl_Add_New_Student
            // 
            this.lbl_Add_New_Student.AutoSize = true;
            this.lbl_Add_New_Student.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Add_New_Student.Font = new System.Drawing.Font("Cambria", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Add_New_Student.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Add_New_Student.Location = new System.Drawing.Point(266, 28);
            this.lbl_Add_New_Student.Name = "lbl_Add_New_Student";
            this.lbl_Add_New_Student.Size = new System.Drawing.Size(525, 70);
            this.lbl_Add_New_Student.TabIndex = 0;
            this.lbl_Add_New_Student.Text = "  Add New Student  ";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Name.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(96, 149);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(129, 51);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.AutoSize = true;
            this.lbl_Roll_No.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.Location = new System.Drawing.Point(94, 250);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(163, 51);
            this.lbl_Roll_No.TabIndex = 3;
            this.lbl_Roll_No.Text = "Roll No";
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.AutoSize = true;
            this.lbl_DOB.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_DOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.Location = new System.Drawing.Point(94, 356);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(115, 51);
            this.lbl_DOB.TabIndex = 4;
            this.lbl_DOB.Text = "DOB";
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.AutoSize = true;
            this.lbl_Mobile_No.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.Location = new System.Drawing.Point(96, 447);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(216, 51);
            this.lbl_Mobile_No.TabIndex = 5;
            this.lbl_Mobile_No.Text = "Mobile No";
            // 
            // lbl_Course
            // 
            this.lbl_Course.AutoSize = true;
            this.lbl_Course.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_Course.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.Location = new System.Drawing.Point(105, 530);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(161, 51);
            this.lbl_Course.TabIndex = 6;
            this.lbl_Course.Text = "Course";
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.Green;
            this.btn_Save.Location = new System.Drawing.Point(507, 645);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(178, 70);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(669, 146);
            this.tb_Name.MaxLength = 120;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(433, 54);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(669, 247);
            this.tb_Roll_No.MaxLength = 5;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(433, 54);
            this.tb_Roll_No.TabIndex = 2;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.Location = new System.Drawing.Point(669, 444);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(433, 54);
            this.tb_Mobile_No.TabIndex = 4;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(669, 353);
            this.dtp_DOB.MaxDate = new System.DateTime(2003, 6, 1, 0, 0, 0, 0);
            this.dtp_DOB.MinDate = new System.DateTime(1990, 1, 1, 0, 0, 0, 0);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(433, 54);
            this.dtp_DOB.TabIndex = 3;
            this.dtp_DOB.Value = new System.DateTime(2003, 6, 1, 0, 0, 0, 0);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Cambria", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BAC",
            "MAC",
            "BAC CS",
            "MSC CS",
            "BCOM IT"});
            this.cmb_Course.Location = new System.Drawing.Point(669, 530);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(433, 55);
            this.cmb_Course.TabIndex = 5;
            // 
            // btn_View_All_Student_List
            // 
            this.btn_View_All_Student_List.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_View_All_Student_List.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_View_All_Student_List.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_View_All_Student_List.ForeColor = System.Drawing.Color.Green;
            this.btn_View_All_Student_List.Location = new System.Drawing.Point(737, 645);
            this.btn_View_All_Student_List.Name = "btn_View_All_Student_List";
            this.btn_View_All_Student_List.Size = new System.Drawing.Size(458, 70);
            this.btn_View_All_Student_List.TabIndex = 8;
            this.btn_View_All_Student_List.Text = "View All Student List";
            this.btn_View_All_Student_List.UseVisualStyleBackColor = false;
            this.btn_View_All_Student_List.Click += new System.EventHandler(this.btn_View_All_Student_List_Click);
            // 
            // btn_Search_Student_Details
            // 
            this.btn_Search_Student_Details.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn_Search_Student_Details.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Search_Student_Details.Font = new System.Drawing.Font("Cambria", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search_Student_Details.ForeColor = System.Drawing.Color.Green;
            this.btn_Search_Student_Details.Location = new System.Drawing.Point(25, 645);
            this.btn_Search_Student_Details.Name = "btn_Search_Student_Details";
            this.btn_Search_Student_Details.Size = new System.Drawing.Size(442, 70);
            this.btn_Search_Student_Details.TabIndex = 6;
            this.btn_Search_Student_Details.Text = "Search Student Details";
            this.btn_Search_Student_Details.UseVisualStyleBackColor = false;
            this.btn_Search_Student_Details.Click += new System.EventHandler(this.btn_Search_Student_Details_Click);
            // 
            // frm_Add_New_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1231, 727);
            this.Controls.Add(this.btn_View_All_Student_List);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.btn_Search_Student_Details);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Add_New_Student);
            this.Controls.Add(this.btn_LogOut);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Add_New_Student";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.frm_Add_New_Student_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Label lbl_Add_New_Student;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_View_All_Student_List;
        private System.Windows.Forms.Button btn_Search_Student_Details;
    }
}
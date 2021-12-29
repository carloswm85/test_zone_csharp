
namespace SchoolFormsApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtState = new System.Windows.Forms.TextBox();
            this.txtZip = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtTwitter = new System.Windows.Forms.TextBox();
            this.btnPushToText = new System.Windows.Forms.Button();
            this.btnTestTeacher = new System.Windows.Forms.Button();
            this.btnTestStudent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 31);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "School Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "State";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "ZIP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Phone";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 15);
            this.label7.TabIndex = 6;
            this.label7.Text = "Twitter";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(138, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 23);
            this.txtName.TabIndex = 7;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(138, 69);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 23);
            this.txtAddress.TabIndex = 8;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(138, 109);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(100, 23);
            this.txtCity.TabIndex = 9;
            // 
            // txtState
            // 
            this.txtState.Location = new System.Drawing.Point(138, 155);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(100, 23);
            this.txtState.TabIndex = 10;
            // 
            // txtZip
            // 
            this.txtZip.Location = new System.Drawing.Point(138, 199);
            this.txtZip.Name = "txtZip";
            this.txtZip.Size = new System.Drawing.Size(100, 23);
            this.txtZip.TabIndex = 11;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(138, 238);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 23);
            this.txtPhone.TabIndex = 12;
            this.txtPhone.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // txtTwitter
            // 
            this.txtTwitter.Location = new System.Drawing.Point(138, 274);
            this.txtTwitter.Name = "txtTwitter";
            this.txtTwitter.Size = new System.Drawing.Size(100, 23);
            this.txtTwitter.TabIndex = 13;
            // 
            // btnPushToText
            // 
            this.btnPushToText.Location = new System.Drawing.Point(129, 320);
            this.btnPushToText.Name = "btnPushToText";
            this.btnPushToText.Size = new System.Drawing.Size(109, 23);
            this.btnPushToText.TabIndex = 14;
            this.btnPushToText.Text = "Push to Text";
            this.btnPushToText.UseVisualStyleBackColor = true;
            this.btnPushToText.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTestTeacher
            // 
            this.btnTestTeacher.Location = new System.Drawing.Point(37, 379);
            this.btnTestTeacher.Name = "btnTestTeacher";
            this.btnTestTeacher.Size = new System.Drawing.Size(136, 23);
            this.btnTestTeacher.TabIndex = 15;
            this.btnTestTeacher.Text = "Test Teacher";
            this.btnTestTeacher.UseVisualStyleBackColor = true;
            this.btnTestTeacher.Click += new System.EventHandler(this.btnTestTeacher_Click);
            // 
            // btnTestStudent
            // 
            this.btnTestStudent.Location = new System.Drawing.Point(37, 418);
            this.btnTestStudent.Name = "btnTestStudent";
            this.btnTestStudent.Size = new System.Drawing.Size(136, 23);
            this.btnTestStudent.TabIndex = 16;
            this.btnTestStudent.Text = "Test Student";
            this.btnTestStudent.UseVisualStyleBackColor = true;
            this.btnTestStudent.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 487);
            this.Controls.Add(this.btnTestStudent);
            this.Controls.Add(this.btnTestTeacher);
            this.Controls.Add(this.btnPushToText);
            this.Controls.Add(this.txtTwitter);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtZip);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.TextBox txtZip;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtTwitter;
        private System.Windows.Forms.Button btnPushToText;
        private System.Windows.Forms.Button btnTestTeacher;
        private System.Windows.Forms.Button btnTestStudent;
    }
}


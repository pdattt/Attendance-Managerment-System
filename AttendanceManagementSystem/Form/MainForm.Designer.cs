namespace AttendanceManagementSystem
{
    partial class MainForm
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
            this.grInfo = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.mssv = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.grInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grInfo
            // 
            this.grInfo.Controls.Add(this.txtEmail);
            this.grInfo.Controls.Add(this.label2);
            this.grInfo.Controls.Add(this.txtName);
            this.grInfo.Controls.Add(this.txtId);
            this.grInfo.Controls.Add(this.label1);
            this.grInfo.Controls.Add(this.mssv);
            this.grInfo.Location = new System.Drawing.Point(570, 38);
            this.grInfo.Name = "grInfo";
            this.grInfo.Size = new System.Drawing.Size(434, 483);
            this.grInfo.TabIndex = 0;
            this.grInfo.TabStop = false;
            this.grInfo.Text = "Thông Tin";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(124, 196);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(216, 20);
            this.txtEmail.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 203);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Email:";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(124, 128);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(216, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(124, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(216, 20);
            this.txtId.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Họ và tên:";
            // 
            // mssv
            // 
            this.mssv.AutoSize = true;
            this.mssv.Location = new System.Drawing.Point(17, 75);
            this.mssv.Name = "mssv";
            this.mssv.Size = new System.Drawing.Size(73, 13);
            this.mssv.TabIndex = 0;
            this.mssv.Text = "Mã sinh viên: ";
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(1053, 78);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(75, 23);
            this.btnCheck.TabIndex = 1;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 566);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.grInfo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grInfo.ResumeLayout(false);
            this.grInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grInfo;
        private System.Windows.Forms.Label mssv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheck;
    }
}


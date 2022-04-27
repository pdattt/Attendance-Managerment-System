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
            this.btnExist = new System.Windows.Forms.Button();
            this.btnAttendee = new System.Windows.Forms.Button();
            this.btn = new System.Windows.Forms.Button();
            this.btnRFID = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExist
            // 
            this.btnExist.Location = new System.Drawing.Point(512, 412);
            this.btnExist.Name = "btnExist";
            this.btnExist.Size = new System.Drawing.Size(143, 44);
            this.btnExist.TabIndex = 0;
            this.btnExist.Text = "Đăng Xuất";
            this.btnExist.UseVisualStyleBackColor = true;
            this.btnExist.Click += new System.EventHandler(this.btnExist_Click);
            // 
            // btnAttendee
            // 
            this.btnAttendee.Location = new System.Drawing.Point(485, 140);
            this.btnAttendee.Name = "btnAttendee";
            this.btnAttendee.Size = new System.Drawing.Size(197, 51);
            this.btnAttendee.TabIndex = 1;
            this.btnAttendee.Text = "Quản Lý Người Sử Dụng";
            this.btnAttendee.UseVisualStyleBackColor = true;
            this.btnAttendee.Click += new System.EventHandler(this.btnAttendee_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(485, 233);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(197, 55);
            this.btn.TabIndex = 2;
            this.btn.Text = "Quản Lý Sự Kiện";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRFID
            // 
            this.btnRFID.Location = new System.Drawing.Point(485, 310);
            this.btnRFID.Name = "btnRFID";
            this.btnRFID.Size = new System.Drawing.Size(197, 54);
            this.btnRFID.TabIndex = 3;
            this.btnRFID.Text = "RFID Reader";
            this.btnRFID.UseVisualStyleBackColor = true;
            this.btnRFID.Click += new System.EventHandler(this.btnRFID_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 566);
            this.Controls.Add(this.btnRFID);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.btnAttendee);
            this.Controls.Add(this.btnExist);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExist;
        private System.Windows.Forms.Button btnAttendee;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnRFID;
    }
}


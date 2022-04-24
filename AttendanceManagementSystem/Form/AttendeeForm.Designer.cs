﻿namespace AttendanceManagementSystem
{
    partial class AttendeeForm
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
            this.gridAttendee = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAttendeeID = new System.Windows.Forms.TextBox();
            this.txtAttendeeName = new System.Windows.Forms.TextBox();
            this.txtAttendeeEmail = new System.Windows.Forms.TextBox();
            this.txtAttendeeCardID = new System.Windows.Forms.TextBox();
            this.txtAttendeeRole = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.gridCalendar = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAttendee
            // 
            this.gridAttendee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAttendee.Location = new System.Drawing.Point(114, 84);
            this.gridAttendee.Name = "gridAttendee";
            this.gridAttendee.Size = new System.Drawing.Size(1092, 283);
            this.gridAttendee.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(601, 408);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã người tham dự:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(601, 445);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(601, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(601, 523);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã thẻ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(601, 561);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vai trò:";
            // 
            // txtAttendeeID
            // 
            this.txtAttendeeID.Location = new System.Drawing.Point(738, 408);
            this.txtAttendeeID.Name = "txtAttendeeID";
            this.txtAttendeeID.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeID.TabIndex = 6;
            // 
            // txtAttendeeName
            // 
            this.txtAttendeeName.Location = new System.Drawing.Point(738, 445);
            this.txtAttendeeName.Name = "txtAttendeeName";
            this.txtAttendeeName.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeName.TabIndex = 7;
            // 
            // txtAttendeeEmail
            // 
            this.txtAttendeeEmail.Location = new System.Drawing.Point(738, 482);
            this.txtAttendeeEmail.Name = "txtAttendeeEmail";
            this.txtAttendeeEmail.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeEmail.TabIndex = 8;
            // 
            // txtAttendeeCardID
            // 
            this.txtAttendeeCardID.Location = new System.Drawing.Point(738, 523);
            this.txtAttendeeCardID.Name = "txtAttendeeCardID";
            this.txtAttendeeCardID.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeCardID.TabIndex = 9;
            // 
            // txtAttendeeRole
            // 
            this.txtAttendeeRole.Location = new System.Drawing.Point(738, 561);
            this.txtAttendeeRole.Name = "txtAttendeeRole";
            this.txtAttendeeRole.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeRole.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1043, 466);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 51);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1124, 465);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1124, 492);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gridCalendar
            // 
            this.gridCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCalendar.Location = new System.Drawing.Point(114, 383);
            this.gridCalendar.Name = "gridCalendar";
            this.gridCalendar.Size = new System.Drawing.Size(448, 247);
            this.gridCalendar.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(456, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "QUẢN LÝ NGƯỜI THAM DỰ";
            // 
            // AttendeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 651);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridCalendar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtAttendeeRole);
            this.Controls.Add(this.txtAttendeeCardID);
            this.Controls.Add(this.txtAttendeeEmail);
            this.Controls.Add(this.txtAttendeeName);
            this.Controls.Add(this.txtAttendeeID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridAttendee);
            this.Name = "AttendeeForm";
            this.Text = "AttendeeForm";
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAttendee;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAttendeeID;
        private System.Windows.Forms.TextBox txtAttendeeName;
        private System.Windows.Forms.TextBox txtAttendeeEmail;
        private System.Windows.Forms.TextBox txtAttendeeCardID;
        private System.Windows.Forms.TextBox txtAttendeeRole;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView gridCalendar;
        private System.Windows.Forms.Label label6;
    }
}
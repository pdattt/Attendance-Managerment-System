namespace AttendanceManagementSystem
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCardID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRole = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridAttendee
            // 
            this.gridAttendee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAttendee.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.colName,
            this.colEmail,
            this.colCardID,
            this.colRole});
            this.gridAttendee.Location = new System.Drawing.Point(169, 81);
            this.gridAttendee.Name = "gridAttendee";
            this.gridAttendee.Size = new System.Drawing.Size(994, 283);
            this.gridAttendee.TabIndex = 0;
            this.gridAttendee.SelectionChanged += new System.EventHandler(this.gridAttendee_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã người tham dự:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Họ và tên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Email:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Mã thẻ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Vai trò:";
            // 
            // txtAttendeeID
            // 
            this.txtAttendeeID.Location = new System.Drawing.Point(169, 37);
            this.txtAttendeeID.Name = "txtAttendeeID";
            this.txtAttendeeID.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeID.TabIndex = 6;
            // 
            // txtAttendeeName
            // 
            this.txtAttendeeName.Location = new System.Drawing.Point(169, 74);
            this.txtAttendeeName.Name = "txtAttendeeName";
            this.txtAttendeeName.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeName.TabIndex = 7;
            // 
            // txtAttendeeEmail
            // 
            this.txtAttendeeEmail.Location = new System.Drawing.Point(169, 111);
            this.txtAttendeeEmail.Name = "txtAttendeeEmail";
            this.txtAttendeeEmail.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeEmail.TabIndex = 8;
            // 
            // txtAttendeeCardID
            // 
            this.txtAttendeeCardID.Location = new System.Drawing.Point(169, 152);
            this.txtAttendeeCardID.Name = "txtAttendeeCardID";
            this.txtAttendeeCardID.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeCardID.TabIndex = 9;
            // 
            // txtAttendeeRole
            // 
            this.txtAttendeeRole.Location = new System.Drawing.Point(169, 190);
            this.txtAttendeeRole.Name = "txtAttendeeRole";
            this.txtAttendeeRole.Size = new System.Drawing.Size(247, 20);
            this.txtAttendeeRole.TabIndex = 10;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1006, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 76);
            this.btnAdd.TabIndex = 11;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1087, 451);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1087, 478);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // gridCalendar
            // 
            this.gridCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCalendar.Location = new System.Drawing.Point(169, 380);
            this.gridCalendar.Name = "gridCalendar";
            this.gridCalendar.Size = new System.Drawing.Size(376, 247);
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
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(28, 27);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 16;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(1087, 505);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 17;
            this.btnRefresh.Text = "Làm Mới";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAttendeeID);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtAttendeeName);
            this.groupBox1.Controls.Add(this.txtAttendeeEmail);
            this.groupBox1.Controls.Add(this.txtAttendeeRole);
            this.groupBox1.Controls.Add(this.txtAttendeeCardID);
            this.groupBox1.Location = new System.Drawing.Point(551, 370);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 257);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin nhập";
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "AttendeeID";
            this.ColID.HeaderText = "AttendeeID";
            this.ColID.Name = "ColID";
            this.ColID.Width = 150;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            this.colName.Width = 250;
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            this.colEmail.Width = 250;
            // 
            // colCardID
            // 
            this.colCardID.DataPropertyName = "CardID";
            this.colCardID.HeaderText = "CardID";
            this.colCardID.Name = "colCardID";
            this.colCardID.Width = 150;
            // 
            // colRole
            // 
            this.colRole.DataPropertyName = "Role";
            this.colRole.HeaderText = "Role";
            this.colRole.Name = "colRole";
            this.colRole.Width = 150;
            // 
            // AttendeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1312, 651);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gridCalendar);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridAttendee);
            this.Name = "AttendeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AttendeeForm";
            this.Load += new System.EventHandler(this.AttendeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCalendar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCardID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRole;
    }
}

namespace AttendanceManagementSystem
{
    partial class AttendeeListInEvent
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
            this.gridAttendance = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.btnImport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAttendance
            // 
            this.gridAttendance.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAttendance.Location = new System.Drawing.Point(12, 84);
            this.gridAttendance.Name = "gridAttendance";
            this.gridAttendance.ReadOnly = true;
            this.gridAttendance.RowHeadersWidth = 51;
            this.gridAttendance.RowTemplate.Height = 24;
            this.gridAttendance.Size = new System.Drawing.Size(758, 311);
            this.gridAttendance.TabIndex = 0;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(824, 84);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(138, 67);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(824, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(138, 67);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(194, 21);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(436, 39);
            this.Title.TabIndex = 3;
            this.Title.Text = "Danh sách người tham gia";
            // 
            // btnImport
            // 
            this.btnImport.Location = new System.Drawing.Point(824, 201);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(138, 67);
            this.btnImport.TabIndex = 4;
            this.btnImport.Text = "Thêm từ file excel";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // AttendeeListInEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 450);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridAttendance);
            this.Name = "AttendeeListInEvent";
            this.Text = "AttendeeListInEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AttendeeListInEvent_FormClosed);
            this.Load += new System.EventHandler(this.AttendeeListInEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendance)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAttendance;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Button btnImport;
    }
}
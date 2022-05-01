namespace AttendanceManagementSystem
{
    partial class EventClassManagementForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.gridEventClass = new System.Windows.Forms.DataGridView();
            this.radioBtnEvent = new System.Windows.Forms.RadioButton();
            this.radioBtnClass = new System.Windows.Forms.RadioButton();
            this.labelEvent = new System.Windows.Forms.Label();
            this.labelClass = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelEventID = new System.Windows.Forms.Label();
            this.labelEventName = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.labelStart = new System.Windows.Forms.Label();
            this.labelEnd = new System.Windows.Forms.Label();
            this.labelDateStart = new System.Windows.Forms.Label();
            this.labelDateEnd = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.txtLocation = new System.Windows.Forms.TextBox();
            this.txtStart = new System.Windows.Forms.TextBox();
            this.txtEnd = new System.Windows.Forms.TextBox();
            this.txtDateStart = new System.Windows.Forms.TextBox();
            this.txtDateEnd = new System.Windows.Forms.TextBox();
            this.labelClassID = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventClass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(39, 50);
            this.btnBack.Margin = new System.Windows.Forms.Padding(4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(100, 28);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gridEventClass
            // 
            this.gridEventClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEventClass.Location = new System.Drawing.Point(162, 129);
            this.gridEventClass.Margin = new System.Windows.Forms.Padding(4);
            this.gridEventClass.Name = "gridEventClass";
            this.gridEventClass.RowHeadersWidth = 51;
            this.gridEventClass.Size = new System.Drawing.Size(1310, 348);
            this.gridEventClass.TabIndex = 1;
            this.gridEventClass.SelectionChanged += new System.EventHandler(this.gridEventClass_SelectionChanged);
            // 
            // radioBtnEvent
            // 
            this.radioBtnEvent.AutoSize = true;
            this.radioBtnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEvent.Location = new System.Drawing.Point(39, 224);
            this.radioBtnEvent.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnEvent.Name = "radioBtnEvent";
            this.radioBtnEvent.Size = new System.Drawing.Size(85, 24);
            this.radioBtnEvent.TabIndex = 2;
            this.radioBtnEvent.TabStop = true;
            this.radioBtnEvent.Text = "Sự kiện";
            this.radioBtnEvent.UseVisualStyleBackColor = true;
            this.radioBtnEvent.CheckedChanged += new System.EventHandler(this.radioBtnEvent_CheckedChanged);
            this.radioBtnEvent.Click += new System.EventHandler(this.radioBtnEvent_Click);
            // 
            // radioBtnClass
            // 
            this.radioBtnClass.AutoSize = true;
            this.radioBtnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnClass.Location = new System.Drawing.Point(39, 334);
            this.radioBtnClass.Margin = new System.Windows.Forms.Padding(4);
            this.radioBtnClass.Name = "radioBtnClass";
            this.radioBtnClass.Size = new System.Drawing.Size(90, 24);
            this.radioBtnClass.TabIndex = 3;
            this.radioBtnClass.TabStop = true;
            this.radioBtnClass.Text = "Lớp học";
            this.radioBtnClass.UseVisualStyleBackColor = true;
            this.radioBtnClass.CheckedChanged += new System.EventHandler(this.radioBtnClass_CheckedChanged);
            this.radioBtnClass.Click += new System.EventHandler(this.radioBtnClass_Click);
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvent.Location = new System.Drawing.Point(876, 47);
            this.labelEvent.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(198, 52);
            this.labelEvent.TabIndex = 4;
            this.labelEvent.Text = "SỰ KIỆN";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(876, 46);
            this.labelClass.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(220, 52);
            this.labelClass.TabIndex = 5;
            this.labelClass.Text = "LỚP HỌC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(663, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 52);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ";
            // 
            // labelEventID
            // 
            this.labelEventID.AutoSize = true;
            this.labelEventID.Location = new System.Drawing.Point(256, 539);
            this.labelEventID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventID.Name = "labelEventID";
            this.labelEventID.Size = new System.Drawing.Size(80, 17);
            this.labelEventID.TabIndex = 7;
            this.labelEventID.Text = "Mã sự kiện:";
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(256, 583);
            this.labelEventName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(86, 17);
            this.labelEventName.TabIndex = 8;
            this.labelEventName.Text = "Tên sự kiện:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(260, 630);
            this.labelDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(45, 17);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Ngày:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(260, 673);
            this.labelLocation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(67, 17);
            this.labelLocation.TabIndex = 10;
            this.labelLocation.Text = "Địa điểm:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(260, 722);
            this.labelStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(86, 17);
            this.labelStart.TabIndex = 11;
            this.labelStart.Text = "Giờ bắt đầu:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(941, 544);
            this.labelEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(88, 17);
            this.labelEnd.TabIndex = 12;
            this.labelEnd.Text = "Giờ kết thúc:";
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Location = new System.Drawing.Point(941, 588);
            this.labelDateStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(97, 17);
            this.labelDateStart.TabIndex = 13;
            this.labelDateStart.Text = "Ngày bắt đầu:";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(941, 635);
            this.labelDateEnd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(99, 17);
            this.labelDateEnd.TabIndex = 14;
            this.labelDateEnd.Text = "Ngày kết thúc:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(945, 719);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1137, 719);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 28);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1322, 719);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(400, 535);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(292, 22);
            this.txtID.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(400, 580);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(292, 22);
            this.txtName.TabIndex = 20;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(400, 625);
            this.txtDate.Margin = new System.Windows.Forms.Padding(4);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(292, 22);
            this.txtDate.TabIndex = 21;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(400, 670);
            this.txtLocation.Margin = new System.Windows.Forms.Padding(4);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(292, 22);
            this.txtLocation.TabIndex = 22;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(400, 719);
            this.txtStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(292, 22);
            this.txtStart.TabIndex = 23;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(1093, 540);
            this.txtEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(328, 22);
            this.txtEnd.TabIndex = 24;
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(1093, 585);
            this.txtDateStart.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(328, 22);
            this.txtDateStart.TabIndex = 25;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(1093, 631);
            this.txtDateEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Size = new System.Drawing.Size(328, 22);
            this.txtDateEnd.TabIndex = 26;
            // 
            // labelClassID
            // 
            this.labelClassID.AutoSize = true;
            this.labelClassID.Location = new System.Drawing.Point(260, 539);
            this.labelClassID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClassID.Name = "labelClassID";
            this.labelClassID.Size = new System.Drawing.Size(81, 17);
            this.labelClassID.TabIndex = 28;
            this.labelClassID.Text = "Mã lớp học:";
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(260, 582);
            this.labelClassName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(87, 17);
            this.labelClassName.TabIndex = 29;
            this.labelClassName.Text = "Tên lớp học:";
            // 
            // EventClassManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1797, 804);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.labelClassID);
            this.Controls.Add(this.txtDateEnd);
            this.Controls.Add(this.txtDateStart);
            this.Controls.Add(this.txtEnd);
            this.Controls.Add(this.txtStart);
            this.Controls.Add(this.txtLocation);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.labelDateEnd);
            this.Controls.Add(this.labelDateStart);
            this.Controls.Add(this.labelEnd);
            this.Controls.Add(this.labelStart);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelEventName);
            this.Controls.Add(this.labelEventID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelClass);
            this.Controls.Add(this.labelEvent);
            this.Controls.Add(this.radioBtnClass);
            this.Controls.Add(this.radioBtnEvent);
            this.Controls.Add(this.gridEventClass);
            this.Controls.Add(this.btnBack);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "EventClassManagementForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EventClassManagementForm";
            this.Load += new System.EventHandler(this.EventClassManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridEventClass)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView gridEventClass;
        private System.Windows.Forms.RadioButton radioBtnEvent;
        private System.Windows.Forms.RadioButton radioBtnClass;
        private System.Windows.Forms.Label labelEvent;
        private System.Windows.Forms.Label labelClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelEventID;
        private System.Windows.Forms.Label labelEventName;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Label labelStart;
        private System.Windows.Forms.Label labelEnd;
        private System.Windows.Forms.Label labelDateStart;
        private System.Windows.Forms.Label labelDateEnd;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.TextBox txtStart;
        private System.Windows.Forms.TextBox txtEnd;
        private System.Windows.Forms.TextBox txtDateStart;
        private System.Windows.Forms.TextBox txtDateEnd;
        private System.Windows.Forms.Label labelClassID;
        private System.Windows.Forms.Label labelClassName;
    }
}
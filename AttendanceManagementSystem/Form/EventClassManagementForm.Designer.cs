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
            this.labelDateInWeek = new System.Windows.Forms.Label();
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
            this.txtDateInWeek = new System.Windows.Forms.TextBox();
            this.labelClassID = new System.Windows.Forms.Label();
            this.labelClassName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridEventClass)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(29, 41);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "<-";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gridEventClass
            // 
            this.gridEventClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEventClass.Location = new System.Drawing.Point(123, 101);
            this.gridEventClass.Name = "gridEventClass";
            this.gridEventClass.Size = new System.Drawing.Size(1160, 283);
            this.gridEventClass.TabIndex = 1;
            // 
            // radioBtnEvent
            // 
            this.radioBtnEvent.AutoSize = true;
            this.radioBtnEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEvent.Location = new System.Drawing.Point(29, 182);
            this.radioBtnEvent.Name = "radioBtnEvent";
            this.radioBtnEvent.Size = new System.Drawing.Size(73, 21);
            this.radioBtnEvent.TabIndex = 2;
            this.radioBtnEvent.TabStop = true;
            this.radioBtnEvent.Text = "Sự kiện";
            this.radioBtnEvent.UseVisualStyleBackColor = true;
            this.radioBtnEvent.CheckedChanged += new System.EventHandler(this.radioBtnEvent_CheckedChanged);
            // 
            // radioBtnClass
            // 
            this.radioBtnClass.AutoSize = true;
            this.radioBtnClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnClass.Location = new System.Drawing.Point(29, 271);
            this.radioBtnClass.Name = "radioBtnClass";
            this.radioBtnClass.Size = new System.Drawing.Size(77, 21);
            this.radioBtnClass.TabIndex = 3;
            this.radioBtnClass.TabStop = true;
            this.radioBtnClass.Text = "Lớp học";
            this.radioBtnClass.UseVisualStyleBackColor = true;
            this.radioBtnClass.CheckedChanged += new System.EventHandler(this.radioBtnClass_CheckedChanged);
            // 
            // labelEvent
            // 
            this.labelEvent.AutoSize = true;
            this.labelEvent.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvent.Location = new System.Drawing.Point(700, 41);
            this.labelEvent.Name = "labelEvent";
            this.labelEvent.Size = new System.Drawing.Size(154, 39);
            this.labelEvent.TabIndex = 4;
            this.labelEvent.Text = "SỰ KIỆN";
            // 
            // labelClass
            // 
            this.labelClass.AutoSize = true;
            this.labelClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelClass.Location = new System.Drawing.Point(700, 41);
            this.labelClass.Name = "labelClass";
            this.labelClass.Size = new System.Drawing.Size(172, 39);
            this.labelClass.TabIndex = 5;
            this.labelClass.Text = "LỚP HỌC";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(540, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "QUẢN LÝ";
            // 
            // labelEventID
            // 
            this.labelEventID.AutoSize = true;
            this.labelEventID.Location = new System.Drawing.Point(192, 438);
            this.labelEventID.Name = "labelEventID";
            this.labelEventID.Size = new System.Drawing.Size(62, 13);
            this.labelEventID.TabIndex = 7;
            this.labelEventID.Text = "Mã sự kiện:";
            // 
            // labelEventName
            // 
            this.labelEventName.AutoSize = true;
            this.labelEventName.Location = new System.Drawing.Point(192, 474);
            this.labelEventName.Name = "labelEventName";
            this.labelEventName.Size = new System.Drawing.Size(66, 13);
            this.labelEventName.TabIndex = 8;
            this.labelEventName.Text = "Tên sự kiện:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(195, 512);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(35, 13);
            this.labelDate.TabIndex = 9;
            this.labelDate.Text = "Ngày:";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(195, 547);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(52, 13);
            this.labelLocation.TabIndex = 10;
            this.labelLocation.Text = "Địa điểm:";
            // 
            // labelStart
            // 
            this.labelStart.AutoSize = true;
            this.labelStart.Location = new System.Drawing.Point(195, 587);
            this.labelStart.Name = "labelStart";
            this.labelStart.Size = new System.Drawing.Size(66, 13);
            this.labelStart.TabIndex = 11;
            this.labelStart.Text = "Giờ bắt đầu:";
            // 
            // labelEnd
            // 
            this.labelEnd.AutoSize = true;
            this.labelEnd.Location = new System.Drawing.Point(744, 442);
            this.labelEnd.Name = "labelEnd";
            this.labelEnd.Size = new System.Drawing.Size(68, 13);
            this.labelEnd.TabIndex = 12;
            this.labelEnd.Text = "Giờ kết thúc:";
            // 
            // labelDateStart
            // 
            this.labelDateStart.AutoSize = true;
            this.labelDateStart.Location = new System.Drawing.Point(744, 478);
            this.labelDateStart.Name = "labelDateStart";
            this.labelDateStart.Size = new System.Drawing.Size(75, 13);
            this.labelDateStart.TabIndex = 13;
            this.labelDateStart.Text = "Ngày bắt đầu:";
            // 
            // labelDateEnd
            // 
            this.labelDateEnd.AutoSize = true;
            this.labelDateEnd.Location = new System.Drawing.Point(744, 516);
            this.labelDateEnd.Name = "labelDateEnd";
            this.labelDateEnd.Size = new System.Drawing.Size(77, 13);
            this.labelDateEnd.TabIndex = 14;
            this.labelDateEnd.Text = "Ngày kết thúc:";
            // 
            // labelDateInWeek
            // 
            this.labelDateInWeek.AutoSize = true;
            this.labelDateInWeek.Location = new System.Drawing.Point(744, 551);
            this.labelDateInWeek.Name = "labelDateInWeek";
            this.labelDateInWeek.Size = new System.Drawing.Size(86, 13);
            this.labelDateInWeek.TabIndex = 15;
            this.labelDateInWeek.Text = "Ngày trong tuần:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(747, 584);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 16;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(891, 584);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Chỉnh sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1030, 584);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(300, 435);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(220, 20);
            this.txtID.TabIndex = 19;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(300, 471);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(220, 20);
            this.txtName.TabIndex = 20;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(300, 508);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(220, 20);
            this.txtDate.TabIndex = 21;
            // 
            // txtLocation
            // 
            this.txtLocation.Location = new System.Drawing.Point(300, 544);
            this.txtLocation.Name = "txtLocation";
            this.txtLocation.Size = new System.Drawing.Size(220, 20);
            this.txtLocation.TabIndex = 22;
            // 
            // txtStart
            // 
            this.txtStart.Location = new System.Drawing.Point(300, 584);
            this.txtStart.Name = "txtStart";
            this.txtStart.Size = new System.Drawing.Size(220, 20);
            this.txtStart.TabIndex = 23;
            // 
            // txtEnd
            // 
            this.txtEnd.Location = new System.Drawing.Point(858, 439);
            this.txtEnd.Name = "txtEnd";
            this.txtEnd.Size = new System.Drawing.Size(247, 20);
            this.txtEnd.TabIndex = 24;
            // 
            // txtDateStart
            // 
            this.txtDateStart.Location = new System.Drawing.Point(858, 475);
            this.txtDateStart.Name = "txtDateStart";
            this.txtDateStart.Size = new System.Drawing.Size(247, 20);
            this.txtDateStart.TabIndex = 25;
            // 
            // txtDateEnd
            // 
            this.txtDateEnd.Location = new System.Drawing.Point(858, 513);
            this.txtDateEnd.Name = "txtDateEnd";
            this.txtDateEnd.Size = new System.Drawing.Size(247, 20);
            this.txtDateEnd.TabIndex = 26;
            // 
            // txtDateInWeek
            // 
            this.txtDateInWeek.Location = new System.Drawing.Point(858, 548);
            this.txtDateInWeek.Name = "txtDateInWeek";
            this.txtDateInWeek.Size = new System.Drawing.Size(247, 20);
            this.txtDateInWeek.TabIndex = 27;
            // 
            // labelClassID
            // 
            this.labelClassID.AutoSize = true;
            this.labelClassID.Location = new System.Drawing.Point(195, 438);
            this.labelClassID.Name = "labelClassID";
            this.labelClassID.Size = new System.Drawing.Size(63, 13);
            this.labelClassID.TabIndex = 28;
            this.labelClassID.Text = "Mã lớp học:";
            // 
            // labelClassName
            // 
            this.labelClassName.AutoSize = true;
            this.labelClassName.Location = new System.Drawing.Point(195, 473);
            this.labelClassName.Name = "labelClassName";
            this.labelClassName.Size = new System.Drawing.Size(67, 13);
            this.labelClassName.TabIndex = 29;
            this.labelClassName.Text = "Tên lớp học:";
            // 
            // EventClassManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1348, 653);
            this.Controls.Add(this.labelClassName);
            this.Controls.Add(this.labelClassID);
            this.Controls.Add(this.txtDateInWeek);
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
            this.Controls.Add(this.labelDateInWeek);
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
        private System.Windows.Forms.Label labelDateInWeek;
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
        private System.Windows.Forms.TextBox txtDateInWeek;
        private System.Windows.Forms.Label labelClassID;
        private System.Windows.Forms.Label labelClassName;
    }
}
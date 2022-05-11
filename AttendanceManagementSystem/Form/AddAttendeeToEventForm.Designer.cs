
namespace AttendanceManagementSystem
{
    partial class AddAttendeeToEvent
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listAvailableAttendee = new System.Windows.Forms.ListBox();
            this.listAttendeeToJoin = new System.Windows.Forms.ListBox();
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(416, 248);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 39);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add >>";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.Location = new System.Drawing.Point(416, 312);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(112, 39);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "<<Remove";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // listAvailableAttendee
            // 
            this.listAvailableAttendee.FormattingEnabled = true;
            this.listAvailableAttendee.ItemHeight = 16;
            this.listAvailableAttendee.Location = new System.Drawing.Point(46, 71);
            this.listAvailableAttendee.Name = "listAvailableAttendee";
            this.listAvailableAttendee.Size = new System.Drawing.Size(311, 500);
            this.listAvailableAttendee.TabIndex = 4;
            // 
            // listAttendeeToJoin
            // 
            this.listAttendeeToJoin.FormattingEnabled = true;
            this.listAttendeeToJoin.ItemHeight = 16;
            this.listAttendeeToJoin.Location = new System.Drawing.Point(576, 71);
            this.listAttendeeToJoin.Name = "listAttendeeToJoin";
            this.listAttendeeToJoin.Size = new System.Drawing.Size(311, 500);
            this.listAttendeeToJoin.TabIndex = 5;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApply.ForeColor = System.Drawing.Color.LimeGreen;
            this.btnApply.Location = new System.Drawing.Point(416, 372);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(112, 47);
            this.btnApply.TabIndex = 6;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(416, 437);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(112, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.TabStop = false;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // AddAttendeeToEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 599);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.listAttendeeToJoin);
            this.Controls.Add(this.listAvailableAttendee);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Name = "AddAttendeeToEvent";
            this.Text = "AddAttendeeToEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAttendeeToEvent_FormClosed);
            this.Load += new System.EventHandler(this.AddAttendeeToEvent_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listAvailableAttendee;
        private System.Windows.Forms.ListBox listAttendeeToJoin;
        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
    }
}
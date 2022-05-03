
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
            this.gridAvailableAttendee = new System.Windows.Forms.DataGridView();
            this.gridAttendeeToJoin = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.listAvailableAttendee = new System.Windows.Forms.ListBox();
            this.listAttendeeToJoin = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridAvailableAttendee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendeeToJoin)).BeginInit();
            this.SuspendLayout();
            // 
            // gridAvailableAttendee
            // 
            this.gridAvailableAttendee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAvailableAttendee.Location = new System.Drawing.Point(46, 71);
            this.gridAvailableAttendee.Name = "gridAvailableAttendee";
            this.gridAvailableAttendee.RowHeadersWidth = 51;
            this.gridAvailableAttendee.RowTemplate.Height = 24;
            this.gridAvailableAttendee.Size = new System.Drawing.Size(311, 493);
            this.gridAvailableAttendee.TabIndex = 0;
            // 
            // gridAttendeeToJoin
            // 
            this.gridAttendeeToJoin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridAttendeeToJoin.Location = new System.Drawing.Point(576, 71);
            this.gridAttendeeToJoin.Name = "gridAttendeeToJoin";
            this.gridAttendeeToJoin.RowHeadersWidth = 51;
            this.gridAttendeeToJoin.RowTemplate.Height = 24;
            this.gridAttendeeToJoin.Size = new System.Drawing.Size(311, 493);
            this.gridAttendeeToJoin.TabIndex = 1;
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
            // 
            // listAvailableAttendee
            // 
            this.listAvailableAttendee.FormattingEnabled = true;
            this.listAvailableAttendee.ItemHeight = 16;
            this.listAvailableAttendee.Location = new System.Drawing.Point(46, 87);
            this.listAvailableAttendee.Name = "listAvailableAttendee";
            this.listAvailableAttendee.Size = new System.Drawing.Size(285, 436);
            this.listAvailableAttendee.TabIndex = 4;
            // 
            // listAttendeeToJoin
            // 
            this.listAttendeeToJoin.FormattingEnabled = true;
            this.listAttendeeToJoin.ItemHeight = 16;
            this.listAttendeeToJoin.Location = new System.Drawing.Point(576, 87);
            this.listAttendeeToJoin.Name = "listAttendeeToJoin";
            this.listAttendeeToJoin.Size = new System.Drawing.Size(285, 436);
            this.listAttendeeToJoin.TabIndex = 5;
            // 
            // AddAttendeeToEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 599);
            this.Controls.Add(this.listAttendeeToJoin);
            this.Controls.Add(this.listAvailableAttendee);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gridAttendeeToJoin);
            this.Controls.Add(this.gridAvailableAttendee);
            this.Name = "AddAttendeeToEvent";
            this.Text = "AddAttendeeToEvent";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddAttendeeToEvent_FormClosed);
            this.Load += new System.EventHandler(this.AddAttendeeToEvent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridAvailableAttendee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAttendeeToJoin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridAvailableAttendee;
        private System.Windows.Forms.DataGridView gridAttendeeToJoin;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.ListBox listAvailableAttendee;
        private System.Windows.Forms.ListBox listAttendeeToJoin;
    }
}
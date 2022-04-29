
namespace AttendanceRFIDCheckIn
{
    partial class AttendeeCheckIn
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
            this.gridCheckIn = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckIn)).BeginInit();
            this.SuspendLayout();
            // 
            // gridCheckIn
            // 
            this.gridCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCheckIn.Location = new System.Drawing.Point(12, 66);
            this.gridCheckIn.Name = "gridCheckIn";
            this.gridCheckIn.RowHeadersWidth = 51;
            this.gridCheckIn.RowTemplate.Height = 24;
            this.gridCheckIn.Size = new System.Drawing.Size(776, 363);
            this.gridCheckIn.TabIndex = 0;
            // 
            // AttendeeCheckIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridCheckIn);
            this.Name = "AttendeeCheckIn";
            this.Text = "AttendeeCheckIn";
            this.Load += new System.EventHandler(this.AttendeeCheckIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCheckIn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridCheckIn;
    }
}
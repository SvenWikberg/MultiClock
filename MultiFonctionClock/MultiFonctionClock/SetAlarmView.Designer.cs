namespace MultiFonctionClock
{
    partial class SetAlarmView
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.nudHour = new System.Windows.Forms.NumericUpDown();
            this.nudMin = new System.Windows.Forms.NumericUpDown();
            this.nudSec = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSec)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(28, 49);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(28, 78);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(114, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // nudHour
            // 
            this.nudHour.Location = new System.Drawing.Point(28, 23);
            this.nudHour.Maximum = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.nudHour.Name = "nudHour";
            this.nudHour.Size = new System.Drawing.Size(34, 20);
            this.nudHour.TabIndex = 3;
            this.nudHour.ValueChanged += new System.EventHandler(this.nudHour_ValueChanged);
            // 
            // nudMin
            // 
            this.nudMin.Location = new System.Drawing.Point(68, 23);
            this.nudMin.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudMin.Name = "nudMin";
            this.nudMin.Size = new System.Drawing.Size(34, 20);
            this.nudMin.TabIndex = 4;
            this.nudMin.ValueChanged += new System.EventHandler(this.nudMin_ValueChanged);
            // 
            // nudSec
            // 
            this.nudSec.Location = new System.Drawing.Point(108, 23);
            this.nudSec.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudSec.Name = "nudSec";
            this.nudSec.Size = new System.Drawing.Size(34, 20);
            this.nudSec.TabIndex = 5;
            this.nudSec.ValueChanged += new System.EventHandler(this.nudSec_ValueChanged);
            // 
            // SetAlarmView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(173, 125);
            this.Controls.Add(this.nudSec);
            this.Controls.Add(this.nudMin);
            this.Controls.Add(this.nudHour);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Name = "SetAlarmView";
            this.Text = "SetAlarmView";
            ((System.ComponentModel.ISupportInitialize)(this.nudHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSec)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.NumericUpDown nudHour;
        private System.Windows.Forms.NumericUpDown nudMin;
        private System.Windows.Forms.NumericUpDown nudSec;
    }
}
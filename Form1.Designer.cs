namespace Revit_SetPathMode
{
    partial class Form1
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.checkAll = new System.Windows.Forms.Button();
            this.checkNone = new System.Windows.Forms.Button();
            this.FarthestDevice = new System.Windows.Forms.Button();
            this.AllDevices = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(12, 12);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(285, 259);
            this.checkedListBox1.TabIndex = 0;
            // 
            // checkAll
            // 
            this.checkAll.Location = new System.Drawing.Point(12, 286);
            this.checkAll.Name = "checkAll";
            this.checkAll.Size = new System.Drawing.Size(141, 23);
            this.checkAll.TabIndex = 1;
            this.checkAll.Text = "Check All";
            this.checkAll.UseVisualStyleBackColor = true;
            this.checkAll.Click += new System.EventHandler(this.CheckAll_Click);
            // 
            // checkNone
            // 
            this.checkNone.Location = new System.Drawing.Point(156, 286);
            this.checkNone.Name = "checkNone";
            this.checkNone.Size = new System.Drawing.Size(141, 23);
            this.checkNone.TabIndex = 2;
            this.checkNone.Text = "Check None";
            this.checkNone.UseVisualStyleBackColor = true;
            this.checkNone.Click += new System.EventHandler(this.CheckNone_Click);
            // 
            // FarthestDevice
            // 
            this.FarthestDevice.Location = new System.Drawing.Point(156, 315);
            this.FarthestDevice.Name = "FarthestDevice";
            this.FarthestDevice.Size = new System.Drawing.Size(141, 42);
            this.FarthestDevice.TabIndex = 3;
            this.FarthestDevice.Text = "Farthest Device";
            this.FarthestDevice.UseVisualStyleBackColor = true;
            this.FarthestDevice.Click += new System.EventHandler(this.FarthestDevice_Click);
            // 
            // AllDevices
            // 
            this.AllDevices.Location = new System.Drawing.Point(12, 315);
            this.AllDevices.Name = "AllDevices";
            this.AllDevices.Size = new System.Drawing.Size(141, 42);
            this.AllDevices.TabIndex = 4;
            this.AllDevices.Text = "All Devices";
            this.AllDevices.UseVisualStyleBackColor = true;
            this.AllDevices.Click += new System.EventHandler(this.AllDevices_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 366);
            this.Controls.Add(this.AllDevices);
            this.Controls.Add(this.FarthestDevice);
            this.Controls.Add(this.checkNone);
            this.Controls.Add(this.checkAll);
            this.Controls.Add(this.checkedListBox1);
            this.Name = "Form1";
            this.Text = "Set Path Mode";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button checkAll;
        private System.Windows.Forms.Button checkNone;
        private System.Windows.Forms.Button FarthestDevice;
        private System.Windows.Forms.Button AllDevices;
    }
}
namespace Prototype_App
{
    partial class uc_PLCSetting
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPLCSetting = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnDisconnect = new System.Windows.Forms.Button();
            this.txtBoxIPAddress = new System.Windows.Forms.TextBox();
            this.lbIPAddress = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbPLCSetting
            // 
            this.lbPLCSetting.BackColor = System.Drawing.SystemColors.Info;
            this.lbPLCSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPLCSetting.Location = new System.Drawing.Point(0, 0);
            this.lbPLCSetting.Name = "lbPLCSetting";
            this.lbPLCSetting.Size = new System.Drawing.Size(818, 52);
            this.lbPLCSetting.TabIndex = 6;
            this.lbPLCSetting.Text = "PLCSetting";
            this.lbPLCSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(439, 103);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 29);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Location = new System.Drawing.Point(566, 103);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(109, 29);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtBoxIPAddress
            // 
            this.txtBoxIPAddress.Location = new System.Drawing.Point(160, 108);
            this.txtBoxIPAddress.Name = "txtBoxIPAddress";
            this.txtBoxIPAddress.Size = new System.Drawing.Size(260, 20);
            this.txtBoxIPAddress.TabIndex = 9;
            // 
            // lbIPAddress
            // 
            this.lbIPAddress.AutoSize = true;
            this.lbIPAddress.Location = new System.Drawing.Point(93, 114);
            this.lbIPAddress.Name = "lbIPAddress";
            this.lbIPAddress.Size = new System.Drawing.Size(64, 13);
            this.lbIPAddress.TabIndex = 10;
            this.lbIPAddress.Text = "IPAddress : ";
            // 
            // uc_PLCSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbIPAddress);
            this.Controls.Add(this.txtBoxIPAddress);
            this.Controls.Add(this.btnDisconnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lbPLCSetting);
            this.Name = "uc_PLCSetting";
            this.Size = new System.Drawing.Size(818, 533);
            this.Load += new System.EventHandler(this.uc_PLCSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPLCSetting;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnDisconnect;
        private System.Windows.Forms.TextBox txtBoxIPAddress;
        private System.Windows.Forms.Label lbIPAddress;
    }
}

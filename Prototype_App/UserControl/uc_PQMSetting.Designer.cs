namespace Prototype_App
{
    partial class uc_PQMSetting
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
            this.lbPQMSetting = new System.Windows.Forms.Label();
            this.lbURL = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxURL = new System.Windows.Forms.TextBox();
            this.txtBoxInterfaceID = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbLoad = new System.Windows.Forms.Button();
            this.checkMES = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbPQMSetting
            // 
            this.lbPQMSetting.BackColor = System.Drawing.SystemColors.Info;
            this.lbPQMSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPQMSetting.Location = new System.Drawing.Point(0, 0);
            this.lbPQMSetting.Name = "lbPQMSetting";
            this.lbPQMSetting.Size = new System.Drawing.Size(818, 52);
            this.lbPQMSetting.TabIndex = 7;
            this.lbPQMSetting.Text = "PQMSetting";
            this.lbPQMSetting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbURL
            // 
            this.lbURL.AutoSize = true;
            this.lbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbURL.Location = new System.Drawing.Point(163, 84);
            this.lbURL.Name = "lbURL";
            this.lbURL.Size = new System.Drawing.Size(56, 24);
            this.lbURL.TabIndex = 8;
            this.lbURL.Text = "URL :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "InterfaceID :";
            // 
            // txtBoxURL
            // 
            this.txtBoxURL.Enabled = false;
            this.txtBoxURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxURL.Location = new System.Drawing.Point(225, 84);
            this.txtBoxURL.Name = "txtBoxURL";
            this.txtBoxURL.Size = new System.Drawing.Size(341, 29);
            this.txtBoxURL.TabIndex = 10;
            // 
            // txtBoxInterfaceID
            // 
            this.txtBoxInterfaceID.Enabled = false;
            this.txtBoxInterfaceID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxInterfaceID.Location = new System.Drawing.Point(225, 130);
            this.txtBoxInterfaceID.Name = "txtBoxInterfaceID";
            this.txtBoxInterfaceID.Size = new System.Drawing.Size(341, 29);
            this.txtBoxInterfaceID.TabIndex = 11;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(292, 261);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 48);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbLoad
            // 
            this.lbLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoad.Location = new System.Drawing.Point(392, 261);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new System.Drawing.Size(81, 48);
            this.lbLoad.TabIndex = 13;
            this.lbLoad.Text = "Load";
            this.lbLoad.UseVisualStyleBackColor = true;
            this.lbLoad.Click += new System.EventHandler(this.lbLoad_Click);
            // 
            // checkMES
            // 
            this.checkMES.AutoSize = true;
            this.checkMES.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkMES.Location = new System.Drawing.Point(149, 194);
            this.checkMES.Name = "checkMES";
            this.checkMES.Size = new System.Drawing.Size(70, 28);
            this.checkMES.TabIndex = 14;
            this.checkMES.Text = "MES";
            this.checkMES.UseVisualStyleBackColor = true;
            this.checkMES.CheckedChanged += new System.EventHandler(this.checkMES_CheckedChanged);
            // 
            // uc_PQMSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.checkMES);
            this.Controls.Add(this.lbLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxInterfaceID);
            this.Controls.Add(this.txtBoxURL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbURL);
            this.Controls.Add(this.lbPQMSetting);
            this.Name = "uc_PQMSetting";
            this.Size = new System.Drawing.Size(818, 533);
            this.Load += new System.EventHandler(this.uc_PQMSetting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPQMSetting;
        private System.Windows.Forms.Label lbURL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxURL;
        private System.Windows.Forms.TextBox txtBoxInterfaceID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button lbLoad;
        private System.Windows.Forms.CheckBox checkMES;
    }
}

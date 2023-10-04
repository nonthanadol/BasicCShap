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
            // uc_PQMSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbPQMSetting);
            this.Name = "uc_PQMSetting";
            this.Size = new System.Drawing.Size(818, 533);
            this.Load += new System.EventHandler(this.uc_PQMSetting_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbPQMSetting;
    }
}

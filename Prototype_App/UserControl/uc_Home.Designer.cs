namespace Prototype_App
{
    partial class uc_Home
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
            this.lbHOME = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbHOME
            // 
            this.lbHOME.BackColor = System.Drawing.SystemColors.Info;
            this.lbHOME.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHOME.Location = new System.Drawing.Point(0, 0);
            this.lbHOME.Name = "lbHOME";
            this.lbHOME.Size = new System.Drawing.Size(818, 52);
            this.lbHOME.TabIndex = 5;
            this.lbHOME.Text = "HOME";
            this.lbHOME.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uc_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbHOME);
            this.Name = "uc_Home";
            this.Size = new System.Drawing.Size(818, 533);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbHOME;
    }
}

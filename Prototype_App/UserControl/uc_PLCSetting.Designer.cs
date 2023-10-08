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
            this.lbPLCModbusAddress = new System.Windows.Forms.Label();
            this.txtBoxDstatus = new System.Windows.Forms.TextBox();
            this.lbDstatus = new System.Windows.Forms.Label();
            this.lbDstatusCode = new System.Windows.Forms.Label();
            this.txtBoxDstatusCode = new System.Windows.Forms.TextBox();
            this.lbDpassQty = new System.Windows.Forms.Label();
            this.txtBoxDpassQty = new System.Windows.Forms.TextBox();
            this.lbDfailQty = new System.Windows.Forms.Label();
            this.txtBoxDfailQty = new System.Windows.Forms.TextBox();
            this.lbDerrCnt = new System.Windows.Forms.Label();
            this.txtBoxDerrCnt = new System.Windows.Forms.TextBox();
            this.lbDselfCheck = new System.Windows.Forms.Label();
            this.txtBoxDselfCheck = new System.Windows.Forms.TextBox();
            this.lbDcycleTime = new System.Windows.Forms.Label();
            this.txtBoxDcycleTime = new System.Windows.Forms.TextBox();
            this.lbDwaitingTime = new System.Windows.Forms.Label();
            this.txtBoxDwaitingTime = new System.Windows.Forms.TextBox();
            this.lbDerrTime = new System.Windows.Forms.Label();
            this.txtBoxDerrTime = new System.Windows.Forms.TextBox();
            this.lbDrunningTime = new System.Windows.Forms.Label();
            this.txtBoxDrunningTime = new System.Windows.Forms.TextBox();
            this.lbLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtBoxDbarcode = new System.Windows.Forms.TextBox();
            this.lbDbarcode = new System.Windows.Forms.Label();
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
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(417, 76);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(109, 29);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnDisconnect
            // 
            this.btnDisconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisconnect.Location = new System.Drawing.Point(544, 76);
            this.btnDisconnect.Name = "btnDisconnect";
            this.btnDisconnect.Size = new System.Drawing.Size(114, 29);
            this.btnDisconnect.TabIndex = 8;
            this.btnDisconnect.Text = "Disconnect";
            this.btnDisconnect.UseVisualStyleBackColor = true;
            this.btnDisconnect.Click += new System.EventHandler(this.btnDisconnect_Click);
            // 
            // txtBoxIPAddress
            // 
            this.txtBoxIPAddress.Enabled = false;
            this.txtBoxIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxIPAddress.Location = new System.Drawing.Point(138, 77);
            this.txtBoxIPAddress.Name = "txtBoxIPAddress";
            this.txtBoxIPAddress.Size = new System.Drawing.Size(260, 29);
            this.txtBoxIPAddress.TabIndex = 9;
            // 
            // lbIPAddress
            // 
            this.lbIPAddress.AutoSize = true;
            this.lbIPAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIPAddress.Location = new System.Drawing.Point(21, 77);
            this.lbIPAddress.Name = "lbIPAddress";
            this.lbIPAddress.Size = new System.Drawing.Size(111, 24);
            this.lbIPAddress.TabIndex = 10;
            this.lbIPAddress.Text = "IPAddress : ";
            // 
            // lbPLCModbusAddress
            // 
            this.lbPLCModbusAddress.BackColor = System.Drawing.SystemColors.Info;
            this.lbPLCModbusAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPLCModbusAddress.Location = new System.Drawing.Point(0, 141);
            this.lbPLCModbusAddress.Name = "lbPLCModbusAddress";
            this.lbPLCModbusAddress.Size = new System.Drawing.Size(818, 28);
            this.lbPLCModbusAddress.TabIndex = 11;
            this.lbPLCModbusAddress.Text = "PLC  Modbus  Address";
            this.lbPLCModbusAddress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBoxDstatus
            // 
            this.txtBoxDstatus.Enabled = false;
            this.txtBoxDstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDstatus.Location = new System.Drawing.Point(233, 191);
            this.txtBoxDstatus.Name = "txtBoxDstatus";
            this.txtBoxDstatus.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDstatus.TabIndex = 19;
            // 
            // lbDstatus
            // 
            this.lbDstatus.AutoSize = true;
            this.lbDstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDstatus.Location = new System.Drawing.Point(150, 194);
            this.lbDstatus.Name = "lbDstatus";
            this.lbDstatus.Size = new System.Drawing.Size(77, 20);
            this.lbDstatus.TabIndex = 20;
            this.lbDstatus.Text = "Dstatus : ";
            // 
            // lbDstatusCode
            // 
            this.lbDstatusCode.AutoSize = true;
            this.lbDstatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDstatusCode.Location = new System.Drawing.Point(112, 236);
            this.lbDstatusCode.Name = "lbDstatusCode";
            this.lbDstatusCode.Size = new System.Drawing.Size(115, 20);
            this.lbDstatusCode.TabIndex = 22;
            this.lbDstatusCode.Text = "DstatusCode : ";
            // 
            // txtBoxDstatusCode
            // 
            this.txtBoxDstatusCode.Enabled = false;
            this.txtBoxDstatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDstatusCode.Location = new System.Drawing.Point(233, 233);
            this.txtBoxDstatusCode.Name = "txtBoxDstatusCode";
            this.txtBoxDstatusCode.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDstatusCode.TabIndex = 21;
            // 
            // lbDpassQty
            // 
            this.lbDpassQty.AutoSize = true;
            this.lbDpassQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDpassQty.Location = new System.Drawing.Point(136, 284);
            this.lbDpassQty.Name = "lbDpassQty";
            this.lbDpassQty.Size = new System.Drawing.Size(91, 20);
            this.lbDpassQty.TabIndex = 24;
            this.lbDpassQty.Text = "DpassQty : ";
            // 
            // txtBoxDpassQty
            // 
            this.txtBoxDpassQty.Enabled = false;
            this.txtBoxDpassQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDpassQty.Location = new System.Drawing.Point(233, 278);
            this.txtBoxDpassQty.Name = "txtBoxDpassQty";
            this.txtBoxDpassQty.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDpassQty.TabIndex = 23;
            // 
            // lbDfailQty
            // 
            this.lbDfailQty.AutoSize = true;
            this.lbDfailQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDfailQty.Location = new System.Drawing.Point(150, 328);
            this.lbDfailQty.Name = "lbDfailQty";
            this.lbDfailQty.Size = new System.Drawing.Size(77, 20);
            this.lbDfailQty.TabIndex = 26;
            this.lbDfailQty.Text = "DfailQty : ";
            this.lbDfailQty.Click += new System.EventHandler(this.lbDfailQty_Click);
            // 
            // txtBoxDfailQty
            // 
            this.txtBoxDfailQty.Enabled = false;
            this.txtBoxDfailQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDfailQty.Location = new System.Drawing.Point(233, 325);
            this.txtBoxDfailQty.Name = "txtBoxDfailQty";
            this.txtBoxDfailQty.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDfailQty.TabIndex = 25;
            // 
            // lbDerrCnt
            // 
            this.lbDerrCnt.AutoSize = true;
            this.lbDerrCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDerrCnt.Location = new System.Drawing.Point(150, 373);
            this.lbDerrCnt.Name = "lbDerrCnt";
            this.lbDerrCnt.Size = new System.Drawing.Size(77, 20);
            this.lbDerrCnt.TabIndex = 28;
            this.lbDerrCnt.Text = "DerrCnt : ";
            // 
            // txtBoxDerrCnt
            // 
            this.txtBoxDerrCnt.Enabled = false;
            this.txtBoxDerrCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDerrCnt.Location = new System.Drawing.Point(233, 370);
            this.txtBoxDerrCnt.Name = "txtBoxDerrCnt";
            this.txtBoxDerrCnt.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDerrCnt.TabIndex = 27;
            // 
            // lbDselfCheck
            // 
            this.lbDselfCheck.AutoSize = true;
            this.lbDselfCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDselfCheck.Location = new System.Drawing.Point(435, 191);
            this.lbDselfCheck.Name = "lbDselfCheck";
            this.lbDselfCheck.Size = new System.Drawing.Size(103, 20);
            this.lbDselfCheck.TabIndex = 30;
            this.lbDselfCheck.Text = "DselfCheck : ";
            // 
            // txtBoxDselfCheck
            // 
            this.txtBoxDselfCheck.Enabled = false;
            this.txtBoxDselfCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDselfCheck.Location = new System.Drawing.Point(544, 188);
            this.txtBoxDselfCheck.Name = "txtBoxDselfCheck";
            this.txtBoxDselfCheck.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDselfCheck.TabIndex = 29;
            this.txtBoxDselfCheck.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lbDcycleTime
            // 
            this.lbDcycleTime.AutoSize = true;
            this.lbDcycleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDcycleTime.Location = new System.Drawing.Point(436, 233);
            this.lbDcycleTime.Name = "lbDcycleTime";
            this.lbDcycleTime.Size = new System.Drawing.Size(102, 20);
            this.lbDcycleTime.TabIndex = 32;
            this.lbDcycleTime.Text = "DcycleTime : ";
            // 
            // txtBoxDcycleTime
            // 
            this.txtBoxDcycleTime.Enabled = false;
            this.txtBoxDcycleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDcycleTime.Location = new System.Drawing.Point(544, 230);
            this.txtBoxDcycleTime.Name = "txtBoxDcycleTime";
            this.txtBoxDcycleTime.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDcycleTime.TabIndex = 31;
            // 
            // lbDwaitingTime
            // 
            this.lbDwaitingTime.AutoSize = true;
            this.lbDwaitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDwaitingTime.Location = new System.Drawing.Point(422, 325);
            this.lbDwaitingTime.Name = "lbDwaitingTime";
            this.lbDwaitingTime.Size = new System.Drawing.Size(116, 20);
            this.lbDwaitingTime.TabIndex = 34;
            this.lbDwaitingTime.Text = "DwaitingTime : ";
            // 
            // txtBoxDwaitingTime
            // 
            this.txtBoxDwaitingTime.Enabled = false;
            this.txtBoxDwaitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDwaitingTime.Location = new System.Drawing.Point(544, 322);
            this.txtBoxDwaitingTime.Name = "txtBoxDwaitingTime";
            this.txtBoxDwaitingTime.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDwaitingTime.TabIndex = 33;
            // 
            // lbDerrTime
            // 
            this.lbDerrTime.AutoSize = true;
            this.lbDerrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDerrTime.Location = new System.Drawing.Point(452, 373);
            this.lbDerrTime.Name = "lbDerrTime";
            this.lbDerrTime.Size = new System.Drawing.Size(86, 20);
            this.lbDerrTime.TabIndex = 36;
            this.lbDerrTime.Text = "DerrTime : ";
            // 
            // txtBoxDerrTime
            // 
            this.txtBoxDerrTime.Enabled = false;
            this.txtBoxDerrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDerrTime.Location = new System.Drawing.Point(544, 367);
            this.txtBoxDerrTime.Name = "txtBoxDerrTime";
            this.txtBoxDerrTime.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDerrTime.TabIndex = 35;
            // 
            // lbDrunningTime
            // 
            this.lbDrunningTime.AutoSize = true;
            this.lbDrunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDrunningTime.Location = new System.Drawing.Point(418, 281);
            this.lbDrunningTime.Name = "lbDrunningTime";
            this.lbDrunningTime.Size = new System.Drawing.Size(120, 20);
            this.lbDrunningTime.TabIndex = 39;
            this.lbDrunningTime.Text = "DrunningTime : ";
            // 
            // txtBoxDrunningTime
            // 
            this.txtBoxDrunningTime.Enabled = false;
            this.txtBoxDrunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDrunningTime.Location = new System.Drawing.Point(544, 278);
            this.txtBoxDrunningTime.Name = "txtBoxDrunningTime";
            this.txtBoxDrunningTime.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDrunningTime.TabIndex = 38;
            // 
            // lbLoad
            // 
            this.lbLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLoad.Location = new System.Drawing.Point(395, 460);
            this.lbLoad.Name = "lbLoad";
            this.lbLoad.Size = new System.Drawing.Size(81, 48);
            this.lbLoad.TabIndex = 41;
            this.lbLoad.Text = "Load";
            this.lbLoad.UseVisualStyleBackColor = true;
            this.lbLoad.Click += new System.EventHandler(this.lbLoad_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(295, 460);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 48);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtBoxDbarcode
            // 
            this.txtBoxDbarcode.Enabled = false;
            this.txtBoxDbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxDbarcode.Location = new System.Drawing.Point(544, 407);
            this.txtBoxDbarcode.Name = "txtBoxDbarcode";
            this.txtBoxDbarcode.Size = new System.Drawing.Size(97, 26);
            this.txtBoxDbarcode.TabIndex = 42;
            // 
            // lbDbarcode
            // 
            this.lbDbarcode.AutoSize = true;
            this.lbDbarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDbarcode.Location = new System.Drawing.Point(447, 410);
            this.lbDbarcode.Name = "lbDbarcode";
            this.lbDbarcode.Size = new System.Drawing.Size(91, 20);
            this.lbDbarcode.TabIndex = 43;
            this.lbDbarcode.Text = "Dbarcode : ";
            // 
            // uc_PLCSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.txtBoxDbarcode);
            this.Controls.Add(this.lbDbarcode);
            this.Controls.Add(this.lbLoad);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtBoxDrunningTime);
            this.Controls.Add(this.txtBoxDstatus);
            this.Controls.Add(this.lbDrunningTime);
            this.Controls.Add(this.txtBoxDerrTime);
            this.Controls.Add(this.txtBoxDstatusCode);
            this.Controls.Add(this.lbDerrTime);
            this.Controls.Add(this.lbDstatusCode);
            this.Controls.Add(this.txtBoxDwaitingTime);
            this.Controls.Add(this.txtBoxDpassQty);
            this.Controls.Add(this.lbDwaitingTime);
            this.Controls.Add(this.lbDpassQty);
            this.Controls.Add(this.txtBoxDcycleTime);
            this.Controls.Add(this.txtBoxDfailQty);
            this.Controls.Add(this.lbDcycleTime);
            this.Controls.Add(this.lbDfailQty);
            this.Controls.Add(this.txtBoxDselfCheck);
            this.Controls.Add(this.lbDerrCnt);
            this.Controls.Add(this.lbDselfCheck);
            this.Controls.Add(this.lbDstatus);
            this.Controls.Add(this.txtBoxDerrCnt);
            this.Controls.Add(this.lbPLCModbusAddress);
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
        private System.Windows.Forms.Label lbPLCModbusAddress;
        private System.Windows.Forms.TextBox txtBoxDstatus;
        private System.Windows.Forms.Label lbDstatus;
        private System.Windows.Forms.Label lbDstatusCode;
        private System.Windows.Forms.TextBox txtBoxDstatusCode;
        private System.Windows.Forms.Label lbDpassQty;
        private System.Windows.Forms.TextBox txtBoxDpassQty;
        private System.Windows.Forms.Label lbDfailQty;
        private System.Windows.Forms.TextBox txtBoxDfailQty;
        private System.Windows.Forms.Label lbDerrCnt;
        private System.Windows.Forms.TextBox txtBoxDerrCnt;
        private System.Windows.Forms.Label lbDselfCheck;
        private System.Windows.Forms.TextBox txtBoxDselfCheck;
        private System.Windows.Forms.Label lbDcycleTime;
        private System.Windows.Forms.TextBox txtBoxDcycleTime;
        private System.Windows.Forms.Label lbDwaitingTime;
        private System.Windows.Forms.TextBox txtBoxDwaitingTime;
        private System.Windows.Forms.Label lbDerrTime;
        private System.Windows.Forms.TextBox txtBoxDerrTime;
        private System.Windows.Forms.Label lbDrunningTime;
        private System.Windows.Forms.TextBox txtBoxDrunningTime;
        private System.Windows.Forms.Button lbLoad;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtBoxDbarcode;
        private System.Windows.Forms.Label lbDbarcode;
    }
}

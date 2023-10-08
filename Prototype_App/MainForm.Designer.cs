namespace Prototype_App
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.lbTitle = new System.Windows.Forms.Label();
            this.cotainerPanel = new System.Windows.Forms.Panel();
            this.controlPanel = new System.Windows.Forms.Panel();
            this.btnPLCSetting = new System.Windows.Forms.Button();
            this.btnPQMSetting = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.tblStatusMonitorPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbBarcode = new System.Windows.Forms.Label();
            this.lbValueBarcode = new System.Windows.Forms.Label();
            this.lbValueSelfCheck = new System.Windows.Forms.Label();
            this.lbSelfCheck = new System.Windows.Forms.Label();
            this.lbValueErrCnt = new System.Windows.Forms.Label();
            this.lbErrCnt = new System.Windows.Forms.Label();
            this.lbValueFailQty = new System.Windows.Forms.Label();
            this.lbFailQty = new System.Windows.Forms.Label();
            this.lbValuePassQty = new System.Windows.Forms.Label();
            this.lbPassQty = new System.Windows.Forms.Label();
            this.lbValueStatusCode = new System.Windows.Forms.Label();
            this.lbStatusCode = new System.Windows.Forms.Label();
            this.lbValueStatus = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbValuePQMconnect = new System.Windows.Forms.Label();
            this.lbValuePLCconnect = new System.Windows.Forms.Label();
            this.lbPLCconnect = new System.Windows.Forms.Label();
            this.lbPQMconnect = new System.Windows.Forms.Label();
            this.lbCycleTime = new System.Windows.Forms.Label();
            this.lbValueCycleTime = new System.Windows.Forms.Label();
            this.lbRunningTime = new System.Windows.Forms.Label();
            this.lbValueRunningTime = new System.Windows.Forms.Label();
            this.lbWaitingTime = new System.Windows.Forms.Label();
            this.lbValueWaitingTime = new System.Windows.Forms.Label();
            this.lbErrTime = new System.Windows.Forms.Label();
            this.lbValueErrTime = new System.Windows.Forms.Label();
            this.lbMonitorStatus = new System.Windows.Forms.Label();
            this.UpdateUI = new System.Windows.Forms.Timer(this.components);
            this.UpdatePQM = new System.Windows.Forms.Timer(this.components);
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.controlPanel.SuspendLayout();
            this.tblStatusMonitorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.titlePanel.Controls.Add(this.pictureBox1);
            this.titlePanel.Controls.Add(this.btnLogin);
            this.titlePanel.Controls.Add(this.lbTitle);
            this.titlePanel.Location = new System.Drawing.Point(1, 1);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1031, 63);
            this.titlePanel.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 63);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(965, 3);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(63, 57);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(349, 14);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(341, 37);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Prototype Application";
            // 
            // cotainerPanel
            // 
            this.cotainerPanel.Location = new System.Drawing.Point(214, 68);
            this.cotainerPanel.Name = "cotainerPanel";
            this.cotainerPanel.Size = new System.Drawing.Size(818, 533);
            this.cotainerPanel.TabIndex = 1;
            // 
            // controlPanel
            // 
            this.controlPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.controlPanel.Controls.Add(this.btnPLCSetting);
            this.controlPanel.Controls.Add(this.btnPQMSetting);
            this.controlPanel.Controls.Add(this.btnHome);
            this.controlPanel.Location = new System.Drawing.Point(214, 605);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(818, 86);
            this.controlPanel.TabIndex = 2;
            // 
            // btnPLCSetting
            // 
            this.btnPLCSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPLCSetting.Location = new System.Drawing.Point(170, 23);
            this.btnPLCSetting.Name = "btnPLCSetting";
            this.btnPLCSetting.Size = new System.Drawing.Size(95, 42);
            this.btnPLCSetting.TabIndex = 2;
            this.btnPLCSetting.Text = "PLCSetting";
            this.btnPLCSetting.UseVisualStyleBackColor = true;
            this.btnPLCSetting.Click += new System.EventHandler(this.btnPLCSetting_Click);
            // 
            // btnPQMSetting
            // 
            this.btnPQMSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPQMSetting.Location = new System.Drawing.Point(271, 23);
            this.btnPQMSetting.Name = "btnPQMSetting";
            this.btnPQMSetting.Size = new System.Drawing.Size(95, 42);
            this.btnPQMSetting.TabIndex = 1;
            this.btnPQMSetting.Text = "PQMSetting";
            this.btnPQMSetting.UseVisualStyleBackColor = true;
            this.btnPQMSetting.Click += new System.EventHandler(this.btnPQMSetting_Click);
            // 
            // btnHome
            // 
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.Location = new System.Drawing.Point(46, 23);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(95, 42);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // tblStatusMonitorPanel
            // 
            this.tblStatusMonitorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tblStatusMonitorPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tblStatusMonitorPanel.ColumnCount = 2;
            this.tblStatusMonitorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.48544F));
            this.tblStatusMonitorPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.51456F));
            this.tblStatusMonitorPanel.Controls.Add(this.lbBarcode, 0, 12);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueBarcode, 0, 12);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueSelfCheck, 1, 7);
            this.tblStatusMonitorPanel.Controls.Add(this.lbSelfCheck, 0, 7);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueErrCnt, 1, 6);
            this.tblStatusMonitorPanel.Controls.Add(this.lbErrCnt, 0, 6);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueFailQty, 1, 5);
            this.tblStatusMonitorPanel.Controls.Add(this.lbFailQty, 0, 5);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValuePassQty, 1, 4);
            this.tblStatusMonitorPanel.Controls.Add(this.lbPassQty, 0, 4);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueStatusCode, 1, 3);
            this.tblStatusMonitorPanel.Controls.Add(this.lbStatusCode, 0, 3);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueStatus, 1, 2);
            this.tblStatusMonitorPanel.Controls.Add(this.lbStatus, 0, 2);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValuePQMconnect, 1, 1);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValuePLCconnect, 1, 0);
            this.tblStatusMonitorPanel.Controls.Add(this.lbPLCconnect, 0, 0);
            this.tblStatusMonitorPanel.Controls.Add(this.lbPQMconnect, 0, 1);
            this.tblStatusMonitorPanel.Controls.Add(this.lbCycleTime, 0, 8);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueCycleTime, 1, 8);
            this.tblStatusMonitorPanel.Controls.Add(this.lbRunningTime, 0, 9);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueRunningTime, 1, 9);
            this.tblStatusMonitorPanel.Controls.Add(this.lbWaitingTime, 0, 10);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueWaitingTime, 1, 10);
            this.tblStatusMonitorPanel.Controls.Add(this.lbErrTime, 0, 11);
            this.tblStatusMonitorPanel.Controls.Add(this.lbValueErrTime, 1, 11);
            this.tblStatusMonitorPanel.Location = new System.Drawing.Point(4, 123);
            this.tblStatusMonitorPanel.Name = "tblStatusMonitorPanel";
            this.tblStatusMonitorPanel.RowCount = 13;
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tblStatusMonitorPanel.Size = new System.Drawing.Size(207, 531);
            this.tblStatusMonitorPanel.TabIndex = 3;
            // 
            // lbBarcode
            // 
            this.lbBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbBarcode.AutoSize = true;
            this.lbBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBarcode.Location = new System.Drawing.Point(19, 505);
            this.lbBarcode.Name = "lbBarcode";
            this.lbBarcode.Size = new System.Drawing.Size(65, 16);
            this.lbBarcode.TabIndex = 25;
            this.lbBarcode.Text = "Barcode :";
            this.lbBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueBarcode
            // 
            this.lbValueBarcode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueBarcode.AutoSize = true;
            this.lbValueBarcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueBarcode.Location = new System.Drawing.Point(147, 505);
            this.lbValueBarcode.Name = "lbValueBarcode";
            this.lbValueBarcode.Size = new System.Drawing.Size(16, 16);
            this.lbValueBarcode.TabIndex = 24;
            this.lbValueBarcode.Text = "...";
            this.lbValueBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueSelfCheck
            // 
            this.lbValueSelfCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueSelfCheck.AutoSize = true;
            this.lbValueSelfCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueSelfCheck.Location = new System.Drawing.Point(147, 300);
            this.lbValueSelfCheck.Name = "lbValueSelfCheck";
            this.lbValueSelfCheck.Size = new System.Drawing.Size(16, 16);
            this.lbValueSelfCheck.TabIndex = 15;
            this.lbValueSelfCheck.Text = "...";
            this.lbValueSelfCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbSelfCheck
            // 
            this.lbSelfCheck.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbSelfCheck.AutoSize = true;
            this.lbSelfCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelfCheck.Location = new System.Drawing.Point(15, 300);
            this.lbSelfCheck.Name = "lbSelfCheck";
            this.lbSelfCheck.Size = new System.Drawing.Size(74, 16);
            this.lbSelfCheck.TabIndex = 14;
            this.lbSelfCheck.Text = "SelfCheck :";
            this.lbSelfCheck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueErrCnt
            // 
            this.lbValueErrCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueErrCnt.AutoSize = true;
            this.lbValueErrCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueErrCnt.Location = new System.Drawing.Point(147, 259);
            this.lbValueErrCnt.Name = "lbValueErrCnt";
            this.lbValueErrCnt.Size = new System.Drawing.Size(16, 16);
            this.lbValueErrCnt.TabIndex = 13;
            this.lbValueErrCnt.Text = "...";
            this.lbValueErrCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbErrCnt
            // 
            this.lbErrCnt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbErrCnt.AutoSize = true;
            this.lbErrCnt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrCnt.Location = new System.Drawing.Point(27, 259);
            this.lbErrCnt.Name = "lbErrCnt";
            this.lbErrCnt.Size = new System.Drawing.Size(49, 16);
            this.lbErrCnt.TabIndex = 12;
            this.lbErrCnt.Text = "ErrCnt :";
            this.lbErrCnt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueFailQty
            // 
            this.lbValueFailQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueFailQty.AutoSize = true;
            this.lbValueFailQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueFailQty.Location = new System.Drawing.Point(147, 218);
            this.lbValueFailQty.Name = "lbValueFailQty";
            this.lbValueFailQty.Size = new System.Drawing.Size(16, 16);
            this.lbValueFailQty.TabIndex = 11;
            this.lbValueFailQty.Text = "...";
            this.lbValueFailQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbFailQty
            // 
            this.lbFailQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbFailQty.AutoSize = true;
            this.lbFailQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFailQty.Location = new System.Drawing.Point(24, 218);
            this.lbFailQty.Name = "lbFailQty";
            this.lbFailQty.Size = new System.Drawing.Size(55, 16);
            this.lbFailQty.TabIndex = 10;
            this.lbFailQty.Text = "FailQty :";
            this.lbFailQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValuePassQty
            // 
            this.lbValuePassQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValuePassQty.AutoSize = true;
            this.lbValuePassQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValuePassQty.Location = new System.Drawing.Point(147, 177);
            this.lbValuePassQty.Name = "lbValuePassQty";
            this.lbValuePassQty.Size = new System.Drawing.Size(16, 16);
            this.lbValuePassQty.TabIndex = 9;
            this.lbValuePassQty.Text = "...";
            this.lbValuePassQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPassQty
            // 
            this.lbPassQty.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPassQty.AutoSize = true;
            this.lbPassQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassQty.Location = new System.Drawing.Point(20, 177);
            this.lbPassQty.Name = "lbPassQty";
            this.lbPassQty.Size = new System.Drawing.Size(64, 16);
            this.lbPassQty.TabIndex = 8;
            this.lbPassQty.Text = "PassQty :";
            this.lbPassQty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueStatusCode
            // 
            this.lbValueStatusCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueStatusCode.AutoSize = true;
            this.lbValueStatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueStatusCode.Location = new System.Drawing.Point(147, 136);
            this.lbValueStatusCode.Name = "lbValueStatusCode";
            this.lbValueStatusCode.Size = new System.Drawing.Size(16, 16);
            this.lbValueStatusCode.TabIndex = 7;
            this.lbValueStatusCode.Text = "...";
            this.lbValueStatusCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStatusCode
            // 
            this.lbStatusCode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStatusCode.AutoSize = true;
            this.lbStatusCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusCode.Location = new System.Drawing.Point(10, 136);
            this.lbStatusCode.Name = "lbStatusCode";
            this.lbStatusCode.Size = new System.Drawing.Size(83, 16);
            this.lbStatusCode.TabIndex = 6;
            this.lbStatusCode.Text = "StatusCode :";
            this.lbStatusCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueStatus
            // 
            this.lbValueStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueStatus.AutoSize = true;
            this.lbValueStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueStatus.Location = new System.Drawing.Point(147, 95);
            this.lbValueStatus.Name = "lbValueStatus";
            this.lbValueStatus.Size = new System.Drawing.Size(16, 16);
            this.lbValueStatus.TabIndex = 5;
            this.lbValueStatus.Text = "...";
            this.lbValueStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbStatus
            // 
            this.lbStatus.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbStatus.AutoSize = true;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.Location = new System.Drawing.Point(27, 95);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(50, 16);
            this.lbStatus.TabIndex = 4;
            this.lbStatus.Text = "Status :";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValuePQMconnect
            // 
            this.lbValuePQMconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValuePQMconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValuePQMconnect.Location = new System.Drawing.Point(107, 46);
            this.lbValuePQMconnect.Name = "lbValuePQMconnect";
            this.lbValuePQMconnect.Size = new System.Drawing.Size(96, 32);
            this.lbValuePQMconnect.TabIndex = 3;
            this.lbValuePQMconnect.Text = "...";
            this.lbValuePQMconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValuePLCconnect
            // 
            this.lbValuePLCconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValuePLCconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValuePLCconnect.Location = new System.Drawing.Point(107, 5);
            this.lbValuePLCconnect.Name = "lbValuePLCconnect";
            this.lbValuePLCconnect.Size = new System.Drawing.Size(96, 32);
            this.lbValuePLCconnect.TabIndex = 1;
            this.lbValuePLCconnect.Text = "...";
            this.lbValuePLCconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPLCconnect
            // 
            this.lbPLCconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPLCconnect.AutoSize = true;
            this.lbPLCconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPLCconnect.Location = new System.Drawing.Point(9, 13);
            this.lbPLCconnect.Name = "lbPLCconnect";
            this.lbPLCconnect.Size = new System.Drawing.Size(85, 16);
            this.lbPLCconnect.TabIndex = 0;
            this.lbPLCconnect.Text = "PLCconnect :";
            this.lbPLCconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbPQMconnect
            // 
            this.lbPQMconnect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbPQMconnect.AutoSize = true;
            this.lbPQMconnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPQMconnect.Location = new System.Drawing.Point(7, 54);
            this.lbPQMconnect.Name = "lbPQMconnect";
            this.lbPQMconnect.Size = new System.Drawing.Size(90, 16);
            this.lbPQMconnect.TabIndex = 2;
            this.lbPQMconnect.Text = "PQMconnect :";
            this.lbPQMconnect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCycleTime
            // 
            this.lbCycleTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbCycleTime.AutoSize = true;
            this.lbCycleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCycleTime.Location = new System.Drawing.Point(13, 341);
            this.lbCycleTime.Name = "lbCycleTime";
            this.lbCycleTime.Size = new System.Drawing.Size(78, 16);
            this.lbCycleTime.TabIndex = 16;
            this.lbCycleTime.Text = "CycleTime :";
            this.lbCycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueCycleTime
            // 
            this.lbValueCycleTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueCycleTime.AutoSize = true;
            this.lbValueCycleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueCycleTime.Location = new System.Drawing.Point(147, 341);
            this.lbValueCycleTime.Name = "lbValueCycleTime";
            this.lbValueCycleTime.Size = new System.Drawing.Size(16, 16);
            this.lbValueCycleTime.TabIndex = 17;
            this.lbValueCycleTime.Text = "...";
            this.lbValueCycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRunningTime
            // 
            this.lbRunningTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbRunningTime.AutoSize = true;
            this.lbRunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRunningTime.Location = new System.Drawing.Point(5, 382);
            this.lbRunningTime.Name = "lbRunningTime";
            this.lbRunningTime.Size = new System.Drawing.Size(93, 16);
            this.lbRunningTime.TabIndex = 19;
            this.lbRunningTime.Text = "RunningTime :";
            this.lbRunningTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueRunningTime
            // 
            this.lbValueRunningTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueRunningTime.AutoSize = true;
            this.lbValueRunningTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueRunningTime.Location = new System.Drawing.Point(147, 382);
            this.lbValueRunningTime.Name = "lbValueRunningTime";
            this.lbValueRunningTime.Size = new System.Drawing.Size(16, 16);
            this.lbValueRunningTime.TabIndex = 18;
            this.lbValueRunningTime.Text = "...";
            this.lbValueRunningTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWaitingTime
            // 
            this.lbWaitingTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbWaitingTime.AutoSize = true;
            this.lbWaitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWaitingTime.Location = new System.Drawing.Point(7, 423);
            this.lbWaitingTime.Name = "lbWaitingTime";
            this.lbWaitingTime.Size = new System.Drawing.Size(89, 16);
            this.lbWaitingTime.TabIndex = 21;
            this.lbWaitingTime.Text = "WaitingTime :";
            this.lbWaitingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueWaitingTime
            // 
            this.lbValueWaitingTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueWaitingTime.AutoSize = true;
            this.lbValueWaitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueWaitingTime.Location = new System.Drawing.Point(147, 423);
            this.lbValueWaitingTime.Name = "lbValueWaitingTime";
            this.lbValueWaitingTime.Size = new System.Drawing.Size(16, 16);
            this.lbValueWaitingTime.TabIndex = 20;
            this.lbValueWaitingTime.Text = "...";
            this.lbValueWaitingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbErrTime
            // 
            this.lbErrTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbErrTime.AutoSize = true;
            this.lbErrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbErrTime.Location = new System.Drawing.Point(21, 464);
            this.lbErrTime.Name = "lbErrTime";
            this.lbErrTime.Size = new System.Drawing.Size(61, 16);
            this.lbErrTime.TabIndex = 23;
            this.lbErrTime.Text = "ErrTime :";
            this.lbErrTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbValueErrTime
            // 
            this.lbValueErrTime.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbValueErrTime.AutoSize = true;
            this.lbValueErrTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbValueErrTime.Location = new System.Drawing.Point(147, 464);
            this.lbValueErrTime.Name = "lbValueErrTime";
            this.lbValueErrTime.Size = new System.Drawing.Size(16, 16);
            this.lbValueErrTime.TabIndex = 22;
            this.lbValueErrTime.Text = "...";
            this.lbValueErrTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbMonitorStatus
            // 
            this.lbMonitorStatus.BackColor = System.Drawing.SystemColors.Info;
            this.lbMonitorStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMonitorStatus.Location = new System.Drawing.Point(4, 68);
            this.lbMonitorStatus.Name = "lbMonitorStatus";
            this.lbMonitorStatus.Size = new System.Drawing.Size(207, 52);
            this.lbMonitorStatus.TabIndex = 4;
            this.lbMonitorStatus.Text = "MonitorStatus";
            this.lbMonitorStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMonitorStatus.Click += new System.EventHandler(this.lbMonitorStatus_Click);
            // 
            // UpdateUI
            // 
            this.UpdateUI.Enabled = true;
            this.UpdateUI.Interval = 500;
            this.UpdateUI.Tick += new System.EventHandler(this.UpdateUI_Tick);
            // 
            // UpdatePQM
            // 
            this.UpdatePQM.Interval = 2000;
            this.UpdatePQM.Tick += new System.EventHandler(this.UpdatePQM_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 691);
            this.Controls.Add(this.lbMonitorStatus);
            this.Controls.Add(this.tblStatusMonitorPanel);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.cotainerPanel);
            this.Controls.Add(this.titlePanel);
            this.Name = "MainForm";
            this.Text = "Prototype App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.controlPanel.ResumeLayout(false);
            this.tblStatusMonitorPanel.ResumeLayout(false);
            this.tblStatusMonitorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Panel cotainerPanel;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.TableLayoutPanel tblStatusMonitorPanel;
        private System.Windows.Forms.Button btnPQMSetting;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Label lbMonitorStatus;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnPLCSetting;
        private System.Windows.Forms.Label lbValuePLCconnect;
        private System.Windows.Forms.Label lbPLCconnect;
        private System.Windows.Forms.Label lbPQMconnect;
        private System.Windows.Forms.Label lbValueSelfCheck;
        private System.Windows.Forms.Label lbSelfCheck;
        private System.Windows.Forms.Label lbValueErrCnt;
        private System.Windows.Forms.Label lbErrCnt;
        private System.Windows.Forms.Label lbValueFailQty;
        private System.Windows.Forms.Label lbFailQty;
        private System.Windows.Forms.Label lbValuePassQty;
        private System.Windows.Forms.Label lbPassQty;
        private System.Windows.Forms.Label lbValueStatusCode;
        private System.Windows.Forms.Label lbStatusCode;
        private System.Windows.Forms.Label lbValueStatus;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbValuePQMconnect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbCycleTime;
        private System.Windows.Forms.Label lbValueCycleTime;
        private System.Windows.Forms.Label lbRunningTime;
        private System.Windows.Forms.Label lbValueRunningTime;
        private System.Windows.Forms.Label lbWaitingTime;
        private System.Windows.Forms.Label lbValueWaitingTime;
        private System.Windows.Forms.Label lbErrTime;
        private System.Windows.Forms.Label lbValueErrTime;
        private System.Windows.Forms.Label lbBarcode;
        private System.Windows.Forms.Label lbValueBarcode;
        private System.Windows.Forms.Timer UpdateUI;
        private System.Windows.Forms.Timer UpdatePQM;
    }
}


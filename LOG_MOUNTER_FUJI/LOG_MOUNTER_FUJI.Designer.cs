namespace LOG_MOUNTER_FUJI
{
    partial class LOG_MOUNTER_FUJI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LOG_MOUNTER_FUJI));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.cBShowLogMain = new System.Windows.Forms.CheckBox();
            this.lbCycleTime = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbLastDate = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.lbPCBCount = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lbModelName = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btLoad = new System.Windows.Forms.Button();
            this.btStop = new System.Windows.Forms.Button();
            this.btStart = new System.Windows.Forms.Button();
            this.rTBResult = new System.Windows.Forms.RichTextBox();
            this.lbLine = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbTimeShow = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cBConnectSocock = new System.Windows.Forms.CheckBox();
            this.tBSocketIP = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tBSocketPort = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.btSet = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cBDetailMounter = new System.Windows.Forms.CheckBox();
            this.cBServer1 = new System.Windows.Forms.CheckBox();
            this.tbPassword1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbServer1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbUser1 = new System.Windows.Forms.TextBox();
            this.tbDBName1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLogPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btSave = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cBSocketLog = new System.Windows.Forms.CheckBox();
            this.btClearSocket = new System.Windows.Forms.Button();
            this.cBKeepAlive = new System.Windows.Forms.CheckBox();
            this.lbSocketStatus = new System.Windows.Forms.Label();
            this.btSocketStop = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.rTBResultRecceive = new System.Windows.Forms.RichTextBox();
            this.rTBResultStatus = new System.Windows.Forms.RichTextBox();
            this.btSocket = new System.Windows.Forms.Button();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.bgWSQL = new System.ComponentModel.BackgroundWorker();
            this.bgWSocket = new System.ComponentModel.BackgroundWorker();
            this.label4 = new System.Windows.Forms.Label();
            this.TbChkMat = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(478, 272);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage1.Controls.Add(this.TbChkMat);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cBShowLogMain);
            this.tabPage1.Controls.Add(this.lbCycleTime);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lbLastDate);
            this.tabPage1.Controls.Add(this.label19);
            this.tabPage1.Controls.Add(this.lbPCBCount);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.lbModelName);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.btLoad);
            this.tabPage1.Controls.Add(this.btStop);
            this.tabPage1.Controls.Add(this.btStart);
            this.tabPage1.Controls.Add(this.rTBResult);
            this.tabPage1.Controls.Add(this.lbLine);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.lbStatus);
            this.tabPage1.Controls.Add(this.lbTimeShow);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 246);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log Data";
            // 
            // cBShowLogMain
            // 
            this.cBShowLogMain.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cBShowLogMain.AutoSize = true;
            this.cBShowLogMain.Location = new System.Drawing.Point(390, 226);
            this.cBShowLogMain.Name = "cBShowLogMain";
            this.cBShowLogMain.Size = new System.Drawing.Size(74, 17);
            this.cBShowLogMain.TabIndex = 45;
            this.cBShowLogMain.Text = "Show Log";
            this.cBShowLogMain.UseVisualStyleBackColor = true;
            // 
            // lbCycleTime
            // 
            this.lbCycleTime.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbCycleTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbCycleTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCycleTime.Location = new System.Drawing.Point(389, 54);
            this.lbCycleTime.Name = "lbCycleTime";
            this.lbCycleTime.Size = new System.Drawing.Size(75, 22);
            this.lbCycleTime.TabIndex = 35;
            this.lbCycleTime.Text = "0 sec.";
            this.lbCycleTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "Cycle ::";
            // 
            // lbLastDate
            // 
            this.lbLastDate.BackColor = System.Drawing.Color.White;
            this.lbLastDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLastDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLastDate.Location = new System.Drawing.Point(115, 55);
            this.lbLastDate.Name = "lbLastDate";
            this.lbLastDate.Size = new System.Drawing.Size(198, 22);
            this.lbLastDate.TabIndex = 33;
            this.lbLastDate.Text = "-";
            this.lbLastDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(6, 55);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(103, 20);
            this.label19.TabIndex = 32;
            this.label19.Text = "Last Date ::";
            // 
            // lbPCBCount
            // 
            this.lbPCBCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbPCBCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbPCBCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPCBCount.Location = new System.Drawing.Point(389, 81);
            this.lbPCBCount.Name = "lbPCBCount";
            this.lbPCBCount.Size = new System.Drawing.Size(75, 22);
            this.lbPCBCount.TabIndex = 29;
            this.lbPCBCount.Text = "0";
            this.lbPCBCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(332, 81);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "Qty ::";
            // 
            // lbModelName
            // 
            this.lbModelName.BackColor = System.Drawing.Color.White;
            this.lbModelName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbModelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModelName.Location = new System.Drawing.Point(82, 33);
            this.lbModelName.Name = "lbModelName";
            this.lbModelName.Size = new System.Drawing.Size(382, 16);
            this.lbModelName.TabIndex = 25;
            this.lbModelName.Text = "No Porduction";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(6, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 20);
            this.label14.TabIndex = 24;
            this.label14.Text = "Model ::";
            // 
            // btLoad
            // 
            this.btLoad.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLoad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btLoad.Location = new System.Drawing.Point(389, 189);
            this.btLoad.Name = "btLoad";
            this.btLoad.Size = new System.Drawing.Size(75, 33);
            this.btLoad.TabIndex = 23;
            this.btLoad.Text = "Load";
            this.btLoad.UseVisualStyleBackColor = false;
            this.btLoad.Click += new System.EventHandler(this.btLoad_Click);
            // 
            // btStop
            // 
            this.btStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btStop.Location = new System.Drawing.Point(389, 150);
            this.btStop.Name = "btStop";
            this.btStop.Size = new System.Drawing.Size(75, 33);
            this.btStop.TabIndex = 22;
            this.btStop.Text = "Stop";
            this.btStop.UseVisualStyleBackColor = false;
            this.btStop.Click += new System.EventHandler(this.btStop_Click);
            // 
            // btStart
            // 
            this.btStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btStart.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btStart.Location = new System.Drawing.Point(390, 111);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(75, 33);
            this.btStart.TabIndex = 21;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = false;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // rTBResult
            // 
            this.rTBResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBResult.Location = new System.Drawing.Point(4, 150);
            this.rTBResult.Name = "rTBResult";
            this.rTBResult.Size = new System.Drawing.Size(379, 72);
            this.rTBResult.TabIndex = 20;
            this.rTBResult.Text = "";
            // 
            // lbLine
            // 
            this.lbLine.AutoSize = true;
            this.lbLine.BackColor = System.Drawing.Color.LimeGreen;
            this.lbLine.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbLine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbLine.Location = new System.Drawing.Point(6, 3);
            this.lbLine.Name = "lbLine";
            this.lbLine.Size = new System.Drawing.Size(63, 26);
            this.lbLine.TabIndex = 19;
            this.lbLine.Text = "#Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(319, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Time ::";
            // 
            // lbStatus
            // 
            this.lbStatus.BackColor = System.Drawing.Color.Red;
            this.lbStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbStatus.Location = new System.Drawing.Point(4, 81);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(309, 27);
            this.lbStatus.TabIndex = 11;
            this.lbStatus.Text = "Status...";
            this.lbStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTimeShow
            // 
            this.lbTimeShow.AutoSize = true;
            this.lbTimeShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeShow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbTimeShow.Location = new System.Drawing.Point(387, 3);
            this.lbTimeShow.Name = "lbTimeShow";
            this.lbTimeShow.Size = new System.Drawing.Size(80, 22);
            this.lbTimeShow.TabIndex = 16;
            this.lbTimeShow.Text = "00:00:00";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.btSet);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btSave);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 246);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Setting";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.cBConnectSocock);
            this.groupBox4.Controls.Add(this.tBSocketIP);
            this.groupBox4.Controls.Add(this.label20);
            this.groupBox4.Controls.Add(this.tBSocketPort);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(6, 167);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(458, 44);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Socket Server";
            // 
            // cBConnectSocock
            // 
            this.cBConnectSocock.AutoSize = true;
            this.cBConnectSocock.Enabled = false;
            this.cBConnectSocock.Location = new System.Drawing.Point(270, 15);
            this.cBConnectSocock.Name = "cBConnectSocock";
            this.cBConnectSocock.Size = new System.Drawing.Size(66, 17);
            this.cBConnectSocock.TabIndex = 12;
            this.cBConnectSocock.Text = "Socket";
            this.cBConnectSocock.UseVisualStyleBackColor = true;
            // 
            // tBSocketIP
            // 
            this.tBSocketIP.Enabled = false;
            this.tBSocketIP.Location = new System.Drawing.Point(49, 12);
            this.tBSocketIP.Name = "tBSocketIP";
            this.tBSocketIP.Size = new System.Drawing.Size(107, 20);
            this.tBSocketIP.TabIndex = 11;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(17, 15);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(26, 13);
            this.label20.TabIndex = 10;
            this.label20.Text = "IP ::";
            // 
            // tBSocketPort
            // 
            this.tBSocketPort.Enabled = false;
            this.tBSocketPort.Location = new System.Drawing.Point(203, 13);
            this.tBSocketPort.Name = "tBSocketPort";
            this.tBSocketPort.Size = new System.Drawing.Size(61, 20);
            this.tBSocketPort.TabIndex = 2;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label21.Location = new System.Drawing.Point(162, 16);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(35, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Port ::";
            // 
            // btSet
            // 
            this.btSet.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSet.Location = new System.Drawing.Point(356, 212);
            this.btSet.Name = "btSet";
            this.btSet.Size = new System.Drawing.Size(52, 25);
            this.btSet.TabIndex = 9;
            this.btSet.Text = "Set";
            this.btSet.UseVisualStyleBackColor = true;
            this.btSet.Click += new System.EventHandler(this.btSet_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.cBDetailMounter);
            this.groupBox2.Controls.Add(this.cBServer1);
            this.groupBox2.Controls.Add(this.tbPassword1);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.tbServer1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tbUser1);
            this.groupBox2.Controls.Add(this.tbDBName1);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(6, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(458, 89);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Server DB";
            // 
            // cBDetailMounter
            // 
            this.cBDetailMounter.AutoSize = true;
            this.cBDetailMounter.Location = new System.Drawing.Point(49, 66);
            this.cBDetailMounter.Name = "cBDetailMounter";
            this.cBDetailMounter.Size = new System.Drawing.Size(109, 17);
            this.cBDetailMounter.TabIndex = 47;
            this.cBDetailMounter.Text = "Detail Mounter";
            this.cBDetailMounter.UseVisualStyleBackColor = true;
            // 
            // cBServer1
            // 
            this.cBServer1.AutoSize = true;
            this.cBServer1.Checked = true;
            this.cBServer1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cBServer1.Location = new System.Drawing.Point(370, 41);
            this.cBServer1.Name = "cBServer1";
            this.cBServer1.Size = new System.Drawing.Size(73, 17);
            this.cBServer1.TabIndex = 12;
            this.cBServer1.Text = "Connect";
            this.cBServer1.UseVisualStyleBackColor = true;
            // 
            // tbPassword1
            // 
            this.tbPassword1.Enabled = false;
            this.tbPassword1.Location = new System.Drawing.Point(245, 39);
            this.tbPassword1.Name = "tbPassword1";
            this.tbPassword1.PasswordChar = '*';
            this.tbPassword1.Size = new System.Drawing.Size(119, 20);
            this.tbPassword1.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(2, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "User ::";
            // 
            // tbServer1
            // 
            this.tbServer1.Enabled = false;
            this.tbServer1.Location = new System.Drawing.Point(46, 13);
            this.tbServer1.Name = "tbServer1";
            this.tbServer1.Size = new System.Drawing.Size(126, 20);
            this.tbServer1.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(14, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "IP ::";
            // 
            // tbUser1
            // 
            this.tbUser1.Enabled = false;
            this.tbUser1.Location = new System.Drawing.Point(46, 39);
            this.tbUser1.Name = "tbUser1";
            this.tbUser1.Size = new System.Drawing.Size(126, 20);
            this.tbUser1.TabIndex = 3;
            // 
            // tbDBName1
            // 
            this.tbDBName1.Enabled = false;
            this.tbDBName1.Location = new System.Drawing.Point(246, 13);
            this.tbDBName1.Name = "tbDBName1";
            this.tbDBName1.Size = new System.Drawing.Size(192, 20);
            this.tbDBName1.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(178, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "DB Name ::";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(206, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(34, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "PW ::";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tbLogPath);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(461, 60);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Setting";
            // 
            // tbLogPath
            // 
            this.tbLogPath.Enabled = false;
            this.tbLogPath.Location = new System.Drawing.Point(74, 19);
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.Size = new System.Drawing.Size(364, 20);
            this.tbLogPath.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Log Path ::";
            // 
            // btSave
            // 
            this.btSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btSave.Location = new System.Drawing.Point(412, 212);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(52, 26);
            this.btSave.TabIndex = 6;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = true;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
            this.tabPage3.Controls.Add(this.cBSocketLog);
            this.tabPage3.Controls.Add(this.btClearSocket);
            this.tabPage3.Controls.Add(this.cBKeepAlive);
            this.tabPage3.Controls.Add(this.lbSocketStatus);
            this.tabPage3.Controls.Add(this.btSocketStop);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.rTBResultRecceive);
            this.tabPage3.Controls.Add(this.rTBResultStatus);
            this.tabPage3.Controls.Add(this.btSocket);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(470, 246);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Socket log";
            // 
            // cBSocketLog
            // 
            this.cBSocketLog.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cBSocketLog.AutoSize = true;
            this.cBSocketLog.Location = new System.Drawing.Point(329, 112);
            this.cBSocketLog.Name = "cBSocketLog";
            this.cBSocketLog.Size = new System.Drawing.Size(74, 17);
            this.cBSocketLog.TabIndex = 44;
            this.cBSocketLog.Text = "Show Log";
            this.cBSocketLog.UseVisualStyleBackColor = true;
            // 
            // btClearSocket
            // 
            this.btClearSocket.Location = new System.Drawing.Point(409, 108);
            this.btClearSocket.Name = "btClearSocket";
            this.btClearSocket.Size = new System.Drawing.Size(55, 21);
            this.btClearSocket.TabIndex = 43;
            this.btClearSocket.Text = "Clear";
            this.btClearSocket.UseVisualStyleBackColor = true;
            this.btClearSocket.Click += new System.EventHandler(this.BtClearSocket_Click);
            // 
            // cBKeepAlive
            // 
            this.cBKeepAlive.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.cBKeepAlive.AutoSize = true;
            this.cBKeepAlive.Location = new System.Drawing.Point(249, 112);
            this.cBKeepAlive.Name = "cBKeepAlive";
            this.cBKeepAlive.Size = new System.Drawing.Size(74, 17);
            this.cBKeepAlive.TabIndex = 42;
            this.cBKeepAlive.Text = "KeepAlive";
            this.cBKeepAlive.UseVisualStyleBackColor = true;
            // 
            // lbSocketStatus
            // 
            this.lbSocketStatus.AutoSize = true;
            this.lbSocketStatus.BackColor = System.Drawing.Color.Red;
            this.lbSocketStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold);
            this.lbSocketStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbSocketStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lbSocketStatus.Location = new System.Drawing.Point(6, 3);
            this.lbSocketStatus.Name = "lbSocketStatus";
            this.lbSocketStatus.Size = new System.Drawing.Size(69, 22);
            this.lbSocketStatus.TabIndex = 41;
            this.lbSocketStatus.Text = "Offline";
            // 
            // btSocketStop
            // 
            this.btSocketStop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSocketStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSocketStop.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSocketStop.Location = new System.Drawing.Point(392, 6);
            this.btSocketStop.Name = "btSocketStop";
            this.btSocketStop.Size = new System.Drawing.Size(75, 33);
            this.btSocketStop.TabIndex = 40;
            this.btSocketStop.Text = "Stop";
            this.btSocketStop.UseVisualStyleBackColor = false;
            this.btSocketStop.Click += new System.EventHandler(this.btSocketStop_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 116);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 13);
            this.label22.TabIndex = 39;
            this.label22.Text = "Receive";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(6, 28);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 13);
            this.label17.TabIndex = 38;
            this.label17.Text = "Status";
            // 
            // rTBResultRecceive
            // 
            this.rTBResultRecceive.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBResultRecceive.Location = new System.Drawing.Point(6, 135);
            this.rTBResultRecceive.Name = "rTBResultRecceive";
            this.rTBResultRecceive.Size = new System.Drawing.Size(461, 105);
            this.rTBResultRecceive.TabIndex = 36;
            this.rTBResultRecceive.Text = "";
            // 
            // rTBResultStatus
            // 
            this.rTBResultStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rTBResultStatus.Location = new System.Drawing.Point(6, 45);
            this.rTBResultStatus.Name = "rTBResultStatus";
            this.rTBResultStatus.Size = new System.Drawing.Size(461, 57);
            this.rTBResultStatus.TabIndex = 35;
            this.rTBResultStatus.Text = "";
            // 
            // btSocket
            // 
            this.btSocket.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btSocket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSocket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btSocket.Location = new System.Drawing.Point(311, 6);
            this.btSocket.Name = "btSocket";
            this.btSocket.Size = new System.Drawing.Size(75, 33);
            this.btSocket.TabIndex = 35;
            this.btSocket.Text = "Socket";
            this.btSocket.UseVisualStyleBackColor = false;
            this.btSocket.Click += new System.EventHandler(this.btSocket_Click);
            // 
            // timerMain
            // 
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // bgWSQL
            // 
            this.bgWSQL.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWSQL_DoWork);
            // 
            // bgWSocket
            // 
            this.bgWSocket.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgWSocket_DoWork);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 20);
            this.label4.TabIndex = 46;
            this.label4.Text = "Read Material ::";
            // 
            // TbChkMat
            // 
            this.TbChkMat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TbChkMat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TbChkMat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbChkMat.Location = new System.Drawing.Point(148, 115);
            this.TbChkMat.Name = "TbChkMat";
            this.TbChkMat.Size = new System.Drawing.Size(51, 22);
            this.TbChkMat.TabIndex = 47;
            this.TbChkMat.Text = "0";
            this.TbChkMat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LOG_MOUNTER_FUJI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(494, 290);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LOG_MOUNTER_FUJI";
            this.Text = "STBL LOG MOUNTER FUJI";
            this.Load += new System.EventHandler(this.LOG_MOUNTER_FUJI_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbLastDate;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lbPCBCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lbModelName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btLoad;
        private System.Windows.Forms.Button btStop;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.RichTextBox rTBResult;
        private System.Windows.Forms.Label lbLine;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbTimeShow;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cBConnectSocock;
        private System.Windows.Forms.TextBox tBSocketIP;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tBSocketPort;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cBServer1;
        private System.Windows.Forms.TextBox tbPassword1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbServer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbUser1;
        private System.Windows.Forms.TextBox tbDBName1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbLogPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btClearSocket;
        private System.Windows.Forms.CheckBox cBKeepAlive;
        private System.Windows.Forms.Label lbSocketStatus;
        private System.Windows.Forms.Button btSocketStop;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.RichTextBox rTBResultRecceive;
        private System.Windows.Forms.RichTextBox rTBResultStatus;
        private System.Windows.Forms.Button btSocket;
        private System.Windows.Forms.Timer timerMain;
        private System.ComponentModel.BackgroundWorker bgWSQL;
        private System.ComponentModel.BackgroundWorker bgWSocket;
        private System.Windows.Forms.CheckBox cBSocketLog;
        private System.Windows.Forms.Label lbCycleTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cBShowLogMain;
        private System.Windows.Forms.CheckBox cBDetailMounter;
        private System.Windows.Forms.Label TbChkMat;
        private System.Windows.Forms.Label label4;
    }
}


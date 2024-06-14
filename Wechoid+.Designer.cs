namespace WechoidPlus
{
    partial class WechoID
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WechoID));
            this.rCB_IPAdrress = new System.Windows.Forms.CheckBox();
            this.rCB_IDProm = new System.Windows.Forms.CheckBox();
            this.rCB_DiskID = new System.Windows.Forms.CheckBox();
            this.rCB_Hostname = new System.Windows.Forms.CheckBox();
            this.rCB_EthAddress = new System.Windows.Forms.CheckBox();
            this.rCB_ComputerID = new System.Windows.Forms.CheckBox();
            this.rCB_HddSerial = new System.Windows.Forms.CheckBox();
            this.rCB_StdCustom = new System.Windows.Forms.CheckBox();
            this.rCB_ProcID = new System.Windows.Forms.CheckBox();
            this.rCB_ExtCust = new System.Windows.Forms.CheckBox();
            this.rCB_CpuInfoString = new System.Windows.Forms.CheckBox();
            this.rCB_UUID = new System.Windows.Forms.CheckBox();
            this.rTB_IPAddress = new System.Windows.Forms.TextBox();
            this.rTB_IDPROM = new System.Windows.Forms.TextBox();
            this.rTB_DiskID = new System.Windows.Forms.TextBox();
            this.rTB_HostName = new System.Windows.Forms.TextBox();
            this.rTB_EthAddress = new System.Windows.Forms.TextBox();
            this.rTB_CompID = new System.Windows.Forms.TextBox();
            this.rTB_HDDSerial = new System.Windows.Forms.TextBox();
            this.rTB_StdCust = new System.Windows.Forms.TextBox();
            this.rTB_PrcID = new System.Windows.Forms.TextBox();
            this.rTB_ExtCust = new System.Windows.Forms.TextBox();
            this.rTB_CpuInfoString = new System.Windows.Forms.TextBox();
            this.rTB_UUID = new System.Windows.Forms.TextBox();
            this.radRepeatButton1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rTB_Code = new System.Windows.Forms.TextBox();
            this.rTB_Selector = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rCB_IPAdrress
            // 
            this.rCB_IPAdrress.AutoSize = true;
            this.rCB_IPAdrress.Location = new System.Drawing.Point(14, 25);
            this.rCB_IPAdrress.Name = "rCB_IPAdrress";
            this.rCB_IPAdrress.Size = new System.Drawing.Size(77, 17);
            this.rCB_IPAdrress.TabIndex = 0;
            this.rCB_IPAdrress.Text = "IP Address";
            this.rCB_IPAdrress.UseVisualStyleBackColor = true;
            this.rCB_IPAdrress.CheckStateChanged += new System.EventHandler(this.rCB_IPAdrress_ToggleStateChanged);
            // 
            // rCB_IDProm
            // 
            this.rCB_IDProm.AutoSize = true;
            this.rCB_IDProm.Location = new System.Drawing.Point(14, 51);
            this.rCB_IDProm.Name = "rCB_IDProm";
            this.rCB_IDProm.Size = new System.Drawing.Size(72, 17);
            this.rCB_IDProm.TabIndex = 1;
            this.rCB_IDProm.Text = "ID PROM";
            this.rCB_IDProm.UseVisualStyleBackColor = true;
            this.rCB_IDProm.CheckStateChanged += new System.EventHandler(this.rCB_IDProm_ToggleStateChanged);
            // 
            // rCB_DiskID
            // 
            this.rCB_DiskID.AutoSize = true;
            this.rCB_DiskID.Location = new System.Drawing.Point(14, 77);
            this.rCB_DiskID.Name = "rCB_DiskID";
            this.rCB_DiskID.Size = new System.Drawing.Size(61, 17);
            this.rCB_DiskID.TabIndex = 2;
            this.rCB_DiskID.Text = "Disk ID";
            this.rCB_DiskID.UseVisualStyleBackColor = true;
            this.rCB_DiskID.CheckStateChanged += new System.EventHandler(this.rCB_DiskID_ToggleStateChanged);
            // 
            // rCB_Hostname
            // 
            this.rCB_Hostname.AutoSize = true;
            this.rCB_Hostname.Location = new System.Drawing.Point(14, 103);
            this.rCB_Hostname.Name = "rCB_Hostname";
            this.rCB_Hostname.Size = new System.Drawing.Size(79, 17);
            this.rCB_Hostname.TabIndex = 3;
            this.rCB_Hostname.Text = "Host Name";
            this.rCB_Hostname.UseVisualStyleBackColor = true;
            this.rCB_Hostname.CheckStateChanged += new System.EventHandler(this.rCB_Hostname_ToggleStateChanged);
            // 
            // rCB_EthAddress
            // 
            this.rCB_EthAddress.AutoSize = true;
            this.rCB_EthAddress.Location = new System.Drawing.Point(14, 129);
            this.rCB_EthAddress.Name = "rCB_EthAddress";
            this.rCB_EthAddress.Size = new System.Drawing.Size(107, 17);
            this.rCB_EthAddress.TabIndex = 4;
            this.rCB_EthAddress.Text = "Ethernet Address";
            this.rCB_EthAddress.UseVisualStyleBackColor = true;
            this.rCB_EthAddress.CheckStateChanged += new System.EventHandler(this.rCB_EthAddress_ToggleStateChanged);
            // 
            // rCB_ComputerID
            // 
            this.rCB_ComputerID.AutoSize = true;
            this.rCB_ComputerID.Location = new System.Drawing.Point(14, 155);
            this.rCB_ComputerID.Name = "rCB_ComputerID";
            this.rCB_ComputerID.Size = new System.Drawing.Size(85, 17);
            this.rCB_ComputerID.TabIndex = 5;
            this.rCB_ComputerID.Text = "Computer ID";
            this.rCB_ComputerID.UseVisualStyleBackColor = true;
            this.rCB_ComputerID.CheckStateChanged += new System.EventHandler(this.rCB_ComputerID_ToggleStateChanged);
            // 
            // rCB_HddSerial
            // 
            this.rCB_HddSerial.AutoSize = true;
            this.rCB_HddSerial.Location = new System.Drawing.Point(14, 181);
            this.rCB_HddSerial.Name = "rCB_HddSerial";
            this.rCB_HddSerial.Size = new System.Drawing.Size(100, 17);
            this.rCB_HddSerial.TabIndex = 6;
            this.rCB_HddSerial.Text = "Hard disk Serial";
            this.rCB_HddSerial.UseVisualStyleBackColor = true;
            this.rCB_HddSerial.CheckStateChanged += new System.EventHandler(this.rCB_HddSerial_ToggleStateChanged);
            // 
            // rCB_StdCustom
            // 
            this.rCB_StdCustom.AutoSize = true;
            this.rCB_StdCustom.Location = new System.Drawing.Point(14, 207);
            this.rCB_StdCustom.Name = "rCB_StdCustom";
            this.rCB_StdCustom.Size = new System.Drawing.Size(107, 17);
            this.rCB_StdCustom.TabIndex = 7;
            this.rCB_StdCustom.Text = "Standard Custom";
            this.rCB_StdCustom.UseVisualStyleBackColor = true;
            this.rCB_StdCustom.CheckStateChanged += new System.EventHandler(this.rCB_StdCustom_ToggleStateChanged);
            // 
            // rCB_ProcID
            // 
            this.rCB_ProcID.AutoSize = true;
            this.rCB_ProcID.Location = new System.Drawing.Point(14, 233);
            this.rCB_ProcID.Name = "rCB_ProcID";
            this.rCB_ProcID.Size = new System.Drawing.Size(87, 17);
            this.rCB_ProcID.TabIndex = 8;
            this.rCB_ProcID.Text = "Processor ID";
            this.rCB_ProcID.UseVisualStyleBackColor = true;
            this.rCB_ProcID.CheckStateChanged += new System.EventHandler(this.rCB_ProcID_ToggleStateChanged);
            // 
            // rCB_ExtCust
            // 
            this.rCB_ExtCust.AutoSize = true;
            this.rCB_ExtCust.Location = new System.Drawing.Point(14, 311);
            this.rCB_ExtCust.Name = "rCB_ExtCust";
            this.rCB_ExtCust.Size = new System.Drawing.Size(109, 17);
            this.rCB_ExtCust.TabIndex = 9;
            this.rCB_ExtCust.Text = "Extended Custom";
            this.rCB_ExtCust.UseVisualStyleBackColor = true;
            this.rCB_ExtCust.CheckStateChanged += new System.EventHandler(this.rCB_ExtCust_ToggleStateChanged);
            // 
            // rCB_CpuInfoString
            // 
            this.rCB_CpuInfoString.AutoSize = true;
            this.rCB_CpuInfoString.Location = new System.Drawing.Point(14, 259);
            this.rCB_CpuInfoString.Name = "rCB_CpuInfoString";
            this.rCB_CpuInfoString.Size = new System.Drawing.Size(99, 17);
            this.rCB_CpuInfoString.TabIndex = 10;
            this.rCB_CpuInfoString.Text = "CPU Info String";
            this.rCB_CpuInfoString.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.rCB_CpuInfoString.UseVisualStyleBackColor = true;
            this.rCB_CpuInfoString.CheckStateChanged += new System.EventHandler(this.rCB_CpuInfoString_ToggleStateChanged);
            // 
            // rCB_UUID
            // 
            this.rCB_UUID.AutoSize = true;
            this.rCB_UUID.Location = new System.Drawing.Point(14, 285);
            this.rCB_UUID.Name = "rCB_UUID";
            this.rCB_UUID.Size = new System.Drawing.Size(53, 17);
            this.rCB_UUID.TabIndex = 11;
            this.rCB_UUID.Text = "UUID";
            this.rCB_UUID.UseVisualStyleBackColor = true;
            this.rCB_UUID.CheckStateChanged += new System.EventHandler(this.rCB_UUID_ToggleStateChanged);
            // 
            // rTB_IPAddress
            // 
            this.rTB_IPAddress.Location = new System.Drawing.Point(161, 23);
            this.rTB_IPAddress.Name = "rTB_IPAddress";
            this.rTB_IPAddress.ReadOnly = true;
            this.rTB_IPAddress.Size = new System.Drawing.Size(253, 20);
            this.rTB_IPAddress.TabIndex = 12;
            // 
            // rTB_IDPROM
            // 
            this.rTB_IDPROM.Location = new System.Drawing.Point(161, 49);
            this.rTB_IDPROM.Name = "rTB_IDPROM";
            this.rTB_IDPROM.ReadOnly = true;
            this.rTB_IDPROM.Size = new System.Drawing.Size(253, 20);
            this.rTB_IDPROM.TabIndex = 13;
            // 
            // rTB_DiskID
            // 
            this.rTB_DiskID.Location = new System.Drawing.Point(161, 75);
            this.rTB_DiskID.Name = "rTB_DiskID";
            this.rTB_DiskID.ReadOnly = true;
            this.rTB_DiskID.Size = new System.Drawing.Size(253, 20);
            this.rTB_DiskID.TabIndex = 14;
            // 
            // rTB_HostName
            // 
            this.rTB_HostName.Location = new System.Drawing.Point(161, 101);
            this.rTB_HostName.Name = "rTB_HostName";
            this.rTB_HostName.ReadOnly = true;
            this.rTB_HostName.Size = new System.Drawing.Size(253, 20);
            this.rTB_HostName.TabIndex = 15;
            // 
            // rTB_EthAddress
            // 
            this.rTB_EthAddress.Location = new System.Drawing.Point(161, 127);
            this.rTB_EthAddress.Name = "rTB_EthAddress";
            this.rTB_EthAddress.ReadOnly = true;
            this.rTB_EthAddress.Size = new System.Drawing.Size(253, 20);
            this.rTB_EthAddress.TabIndex = 16;
            // 
            // rTB_CompID
            // 
            this.rTB_CompID.Location = new System.Drawing.Point(161, 153);
            this.rTB_CompID.Name = "rTB_CompID";
            this.rTB_CompID.ReadOnly = true;
            this.rTB_CompID.Size = new System.Drawing.Size(253, 20);
            this.rTB_CompID.TabIndex = 17;
            // 
            // rTB_HDDSerial
            // 
            this.rTB_HDDSerial.Location = new System.Drawing.Point(161, 179);
            this.rTB_HDDSerial.Name = "rTB_HDDSerial";
            this.rTB_HDDSerial.ReadOnly = true;
            this.rTB_HDDSerial.Size = new System.Drawing.Size(253, 20);
            this.rTB_HDDSerial.TabIndex = 18;
            // 
            // rTB_StdCust
            // 
            this.rTB_StdCust.Location = new System.Drawing.Point(161, 205);
            this.rTB_StdCust.Name = "rTB_StdCust";
            this.rTB_StdCust.ReadOnly = true;
            this.rTB_StdCust.Size = new System.Drawing.Size(253, 20);
            this.rTB_StdCust.TabIndex = 19;
            // 
            // rTB_PrcID
            // 
            this.rTB_PrcID.Location = new System.Drawing.Point(161, 231);
            this.rTB_PrcID.Name = "rTB_PrcID";
            this.rTB_PrcID.ReadOnly = true;
            this.rTB_PrcID.Size = new System.Drawing.Size(253, 20);
            this.rTB_PrcID.TabIndex = 20;
            // 
            // rTB_ExtCust
            // 
            this.rTB_ExtCust.Location = new System.Drawing.Point(161, 309);
            this.rTB_ExtCust.Name = "rTB_ExtCust";
            this.rTB_ExtCust.ReadOnly = true;
            this.rTB_ExtCust.Size = new System.Drawing.Size(253, 20);
            this.rTB_ExtCust.TabIndex = 21;
            // 
            // rTB_CpuInfoString
            // 
            this.rTB_CpuInfoString.Location = new System.Drawing.Point(161, 257);
            this.rTB_CpuInfoString.Name = "rTB_CpuInfoString";
            this.rTB_CpuInfoString.ReadOnly = true;
            this.rTB_CpuInfoString.Size = new System.Drawing.Size(253, 20);
            this.rTB_CpuInfoString.TabIndex = 22;
            // 
            // rTB_UUID
            // 
            this.rTB_UUID.Location = new System.Drawing.Point(161, 283);
            this.rTB_UUID.Name = "rTB_UUID";
            this.rTB_UUID.ReadOnly = true;
            this.rTB_UUID.Size = new System.Drawing.Size(253, 20);
            this.rTB_UUID.TabIndex = 23;
            // 
            // radRepeatButton1
            // 
            this.radRepeatButton1.Location = new System.Drawing.Point(34, 485);
            this.radRepeatButton1.Name = "radRepeatButton1";
            this.radRepeatButton1.Size = new System.Drawing.Size(75, 23);
            this.radRepeatButton1.TabIndex = 24;
            this.radRepeatButton1.Text = "Reset";
            this.radRepeatButton1.UseVisualStyleBackColor = true;
            this.radRepeatButton1.Click += new System.EventHandler(this.radRepeatButton1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(180, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Code";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Selector";
            // 
            // rTB_Code
            // 
            this.rTB_Code.Location = new System.Drawing.Point(228, 69);
            this.rTB_Code.Name = "rTB_Code";
            this.rTB_Code.ReadOnly = true;
            this.rTB_Code.Size = new System.Drawing.Size(172, 20);
            this.rTB_Code.TabIndex = 27;
            // 
            // rTB_Selector
            // 
            this.rTB_Selector.Location = new System.Drawing.Point(81, 69);
            this.rTB_Selector.Name = "rTB_Selector";
            this.rTB_Selector.ReadOnly = true;
            this.rTB_Selector.Size = new System.Drawing.Size(75, 20);
            this.rTB_Selector.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(253, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 30;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(350, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 31;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Style";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.rCB_IDProm);
            this.groupBox1.Controls.Add(this.rCB_IPAdrress);
            this.groupBox1.Controls.Add(this.rCB_DiskID);
            this.groupBox1.Controls.Add(this.rCB_Hostname);
            this.groupBox1.Controls.Add(this.rCB_EthAddress);
            this.groupBox1.Controls.Add(this.rTB_UUID);
            this.groupBox1.Controls.Add(this.rCB_ComputerID);
            this.groupBox1.Controls.Add(this.rCB_HddSerial);
            this.groupBox1.Controls.Add(this.rTB_CpuInfoString);
            this.groupBox1.Controls.Add(this.rCB_StdCustom);
            this.groupBox1.Controls.Add(this.rCB_ProcID);
            this.groupBox1.Controls.Add(this.rCB_ExtCust);
            this.groupBox1.Controls.Add(this.rTB_ExtCust);
            this.groupBox1.Controls.Add(this.rCB_CpuInfoString);
            this.groupBox1.Controls.Add(this.rCB_UUID);
            this.groupBox1.Controls.Add(this.rTB_PrcID);
            this.groupBox1.Controls.Add(this.rTB_IPAddress);
            this.groupBox1.Controls.Add(this.rTB_StdCust);
            this.groupBox1.Controls.Add(this.rTB_IDPROM);
            this.groupBox1.Controls.Add(this.rTB_HDDSerial);
            this.groupBox1.Controls.Add(this.rTB_DiskID);
            this.groupBox1.Controls.Add(this.rTB_CompID);
            this.groupBox1.Controls.Add(this.rTB_HostName);
            this.groupBox1.Controls.Add(this.rTB_EthAddress);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(435, 464);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Locking Criteria";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.rTB_Selector);
            this.groupBox2.Controls.Add(this.rTB_Code);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(13, 349);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(404, 100);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Locking Data";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(183, 27);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(67, 17);
            this.radioButton2.TabIndex = 34;
            this.radioButton2.Text = "Old Style";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(83, 27);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(73, 17);
            this.radioButton1.TabIndex = 33;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "New Style";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.RadioButton_CheckedChanged);
            // 
            // WechoID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 517);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.radRepeatButton1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WechoID";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wechoid+";
            this.Load += new System.EventHandler(this.Form1_Initialized);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox rCB_IPAdrress;
        private System.Windows.Forms.CheckBox rCB_IDProm;
        private System.Windows.Forms.CheckBox rCB_DiskID;
        private System.Windows.Forms.CheckBox rCB_Hostname;
        private System.Windows.Forms.CheckBox rCB_EthAddress;
        private System.Windows.Forms.CheckBox rCB_ComputerID;
        private System.Windows.Forms.CheckBox rCB_HddSerial;
        private System.Windows.Forms.CheckBox rCB_StdCustom;
        private System.Windows.Forms.CheckBox rCB_ProcID;
        private System.Windows.Forms.CheckBox rCB_ExtCust;
        private System.Windows.Forms.CheckBox rCB_CpuInfoString;
        private System.Windows.Forms.CheckBox rCB_UUID;
        private System.Windows.Forms.TextBox rTB_IPAddress;
        private System.Windows.Forms.TextBox rTB_IDPROM;
        private System.Windows.Forms.TextBox rTB_DiskID;
        private System.Windows.Forms.TextBox rTB_HostName;
        private System.Windows.Forms.TextBox rTB_EthAddress;
        private System.Windows.Forms.TextBox rTB_CompID;
        private System.Windows.Forms.TextBox rTB_HDDSerial;
        private System.Windows.Forms.TextBox rTB_StdCust;
        private System.Windows.Forms.TextBox rTB_PrcID;
        private System.Windows.Forms.TextBox rTB_ExtCust;
        private System.Windows.Forms.TextBox rTB_CpuInfoString;
        private System.Windows.Forms.TextBox rTB_UUID;
        private System.Windows.Forms.Button radRepeatButton1;
        private System.Windows.Forms.TextBox rTB_Code;
        private System.Windows.Forms.TextBox rTB_Selector;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}
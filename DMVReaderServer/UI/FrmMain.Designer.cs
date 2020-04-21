namespace DMVReaderServer
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btClsoeServer = new System.Windows.Forms.Button();
            this.btServerSend = new System.Windows.Forms.Button();
            this.rtxtServerMsgList = new System.Windows.Forms.RichTextBox();
            this.txtServerMsg = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbServerMsgTips = new System.Windows.Forms.Label();
            this.btStartServer = new System.Windows.Forms.Button();
            this.txtServerProt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServerIP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btCloseClient = new System.Windows.Forms.Button();
            this.btClientSend = new System.Windows.Forms.Button();
            this.txtClientMsg = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rtxtClientList = new System.Windows.Forms.RichTextBox();
            this.lbClientMsgTips = new System.Windows.Forms.Label();
            this.btStartClient = new System.Windows.Forms.Button();
            this.txtClientProt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtClientIP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btClsoeServer);
            this.groupBox1.Controls.Add(this.btServerSend);
            this.groupBox1.Controls.Add(this.rtxtServerMsgList);
            this.groupBox1.Controls.Add(this.txtServerMsg);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lbServerMsgTips);
            this.groupBox1.Controls.Add(this.btStartServer);
            this.groupBox1.Controls.Add(this.txtServerProt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtServerIP);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(437, 347);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "服务器配置";
            // 
            // btClsoeServer
            // 
            this.btClsoeServer.Enabled = false;
            this.btClsoeServer.Location = new System.Drawing.Point(234, 49);
            this.btClsoeServer.Name = "btClsoeServer";
            this.btClsoeServer.Size = new System.Drawing.Size(86, 23);
            this.btClsoeServer.TabIndex = 14;
            this.btClsoeServer.Text = "关闭服务器";
            this.btClsoeServer.UseVisualStyleBackColor = true;
            this.btClsoeServer.Click += new System.EventHandler(this.btClsoeServer_Click);
            // 
            // btServerSend
            // 
            this.btServerSend.Location = new System.Drawing.Point(278, 300);
            this.btServerSend.Name = "btServerSend";
            this.btServerSend.Size = new System.Drawing.Size(75, 23);
            this.btServerSend.TabIndex = 13;
            this.btServerSend.Text = "发送";
            this.btServerSend.UseVisualStyleBackColor = true;
            this.btServerSend.Click += new System.EventHandler(this.btServerSend_Click);
            // 
            // rtxtServerMsgList
            // 
            this.rtxtServerMsgList.Location = new System.Drawing.Point(6, 90);
            this.rtxtServerMsgList.Name = "rtxtServerMsgList";
            this.rtxtServerMsgList.Size = new System.Drawing.Size(347, 205);
            this.rtxtServerMsgList.TabIndex = 6;
            this.rtxtServerMsgList.Text = "";
            // 
            // txtServerMsg
            // 
            this.txtServerMsg.Location = new System.Drawing.Point(68, 301);
            this.txtServerMsg.Name = "txtServerMsg";
            this.txtServerMsg.Size = new System.Drawing.Size(160, 21);
            this.txtServerMsg.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 310);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "消息文本：";
            // 
            // lbServerMsgTips
            // 
            this.lbServerMsgTips.AutoSize = true;
            this.lbServerMsgTips.Location = new System.Drawing.Point(87, 75);
            this.lbServerMsgTips.Name = "lbServerMsgTips";
            this.lbServerMsgTips.Size = new System.Drawing.Size(77, 12);
            this.lbServerMsgTips.TabIndex = 5;
            this.lbServerMsgTips.Text = "服务器未启动";
            // 
            // btStartServer
            // 
            this.btStartServer.Location = new System.Drawing.Point(234, 22);
            this.btStartServer.Name = "btStartServer";
            this.btStartServer.Size = new System.Drawing.Size(86, 23);
            this.btStartServer.TabIndex = 4;
            this.btStartServer.Text = "启动服务器";
            this.btStartServer.UseVisualStyleBackColor = true;
            this.btStartServer.Click += new System.EventHandler(this.btStartServer_Click);
            // 
            // txtServerProt
            // 
            this.txtServerProt.Location = new System.Drawing.Point(89, 51);
            this.txtServerProt.Name = "txtServerProt";
            this.txtServerProt.Size = new System.Drawing.Size(62, 21);
            this.txtServerProt.TabIndex = 3;
            this.txtServerProt.Text = "9999";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "服务器端口：";
            // 
            // txtServerIP
            // 
            this.txtServerIP.Location = new System.Drawing.Point(89, 24);
            this.txtServerIP.Name = "txtServerIP";
            this.txtServerIP.Size = new System.Drawing.Size(139, 21);
            this.txtServerIP.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "服务器IP：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btCloseClient);
            this.groupBox2.Controls.Add(this.btClientSend);
            this.groupBox2.Controls.Add(this.txtClientMsg);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.rtxtClientList);
            this.groupBox2.Controls.Add(this.lbClientMsgTips);
            this.groupBox2.Controls.Add(this.btStartClient);
            this.groupBox2.Controls.Add(this.txtClientProt);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtClientIP);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(437, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 347);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "客户端设置";
            // 
            // btCloseClient
            // 
            this.btCloseClient.Enabled = false;
            this.btCloseClient.Location = new System.Drawing.Point(235, 43);
            this.btCloseClient.Name = "btCloseClient";
            this.btCloseClient.Size = new System.Drawing.Size(86, 23);
            this.btCloseClient.TabIndex = 11;
            this.btCloseClient.Text = "断开连接";
            this.btCloseClient.UseVisualStyleBackColor = true;
            this.btCloseClient.Click += new System.EventHandler(this.btCloseClient_Click);
            // 
            // btClientSend
            // 
            this.btClientSend.Location = new System.Drawing.Point(289, 318);
            this.btClientSend.Name = "btClientSend";
            this.btClientSend.Size = new System.Drawing.Size(75, 23);
            this.btClientSend.TabIndex = 10;
            this.btClientSend.Text = "发送";
            this.btClientSend.UseVisualStyleBackColor = true;
            this.btClientSend.Click += new System.EventHandler(this.btClientSend_Click);
            // 
            // txtClientMsg
            // 
            this.txtClientMsg.Location = new System.Drawing.Point(69, 320);
            this.txtClientMsg.Name = "txtClientMsg";
            this.txtClientMsg.Size = new System.Drawing.Size(160, 21);
            this.txtClientMsg.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 323);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 8;
            this.label7.Text = "消息文本：";
            // 
            // rtxtClientList
            // 
            this.rtxtClientList.Location = new System.Drawing.Point(8, 84);
            this.rtxtClientList.Name = "rtxtClientList";
            this.rtxtClientList.Size = new System.Drawing.Size(356, 230);
            this.rtxtClientList.TabIndex = 7;
            this.rtxtClientList.Text = "";
            // 
            // lbClientMsgTips
            // 
            this.lbClientMsgTips.AutoSize = true;
            this.lbClientMsgTips.Location = new System.Drawing.Point(111, 69);
            this.lbClientMsgTips.Name = "lbClientMsgTips";
            this.lbClientMsgTips.Size = new System.Drawing.Size(77, 12);
            this.lbClientMsgTips.TabIndex = 6;
            this.lbClientMsgTips.Text = "客户端未启动";
            // 
            // btStartClient
            // 
            this.btStartClient.Location = new System.Drawing.Point(235, 15);
            this.btStartClient.Name = "btStartClient";
            this.btStartClient.Size = new System.Drawing.Size(86, 23);
            this.btStartClient.TabIndex = 5;
            this.btStartClient.Text = "启动客户端";
            this.btStartClient.UseVisualStyleBackColor = true;
            this.btStartClient.Click += new System.EventHandler(this.btStartClient_Click);
            // 
            // txtClientProt
            // 
            this.txtClientProt.Location = new System.Drawing.Point(113, 45);
            this.txtClientProt.Name = "txtClientProt";
            this.txtClientProt.Size = new System.Drawing.Size(116, 21);
            this.txtClientProt.TabIndex = 4;
            this.txtClientProt.Text = "9999";
            this.txtClientProt.TextChanged += new System.EventHandler(this.txtClientProt_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "远程服务器端口：";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtClientIP
            // 
            this.txtClientIP.Location = new System.Drawing.Point(113, 18);
            this.txtClientIP.Name = "txtClientIP";
            this.txtClientIP.Size = new System.Drawing.Size(116, 21);
            this.txtClientIP.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "远程服务器IP：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 347);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btClsoeServer;
        private System.Windows.Forms.Button btServerSend;
        private System.Windows.Forms.RichTextBox rtxtServerMsgList;
        private System.Windows.Forms.TextBox txtServerMsg;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbServerMsgTips;
        private System.Windows.Forms.Button btStartServer;
        private System.Windows.Forms.TextBox txtServerProt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServerIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btCloseClient;
        private System.Windows.Forms.Button btClientSend;
        private System.Windows.Forms.TextBox txtClientMsg;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RichTextBox rtxtClientList;
        private System.Windows.Forms.Label lbClientMsgTips;
        private System.Windows.Forms.Button btStartClient;
        private System.Windows.Forms.TextBox txtClientProt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtClientIP;
        private System.Windows.Forms.Label label4;
    }
}


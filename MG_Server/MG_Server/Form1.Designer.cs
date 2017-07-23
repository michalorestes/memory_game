namespace MG_Server
{
    partial class Server
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
            this.group_clients = new System.Windows.Forms.GroupBox();
            this.txt_playerInfo = new System.Windows.Forms.RichTextBox();
            this.lb_clients = new System.Windows.Forms.Label();
            this.txt_clients = new System.Windows.Forms.TextBox();
            this.lb_playersList = new System.Windows.Forms.ListBox();
            this.lb_playerInfo = new System.Windows.Forms.Label();
            this.txt_ip = new System.Windows.Forms.TextBox();
            this.lb_ip = new System.Windows.Forms.Label();
            this.txt_conPort = new System.Windows.Forms.TextBox();
            this.lb_conPort = new System.Windows.Forms.Label();
            this.group_ServerSettings = new System.Windows.Forms.GroupBox();
            this.lb_udp = new System.Windows.Forms.Label();
            this.btn_enableLocating = new System.Windows.Forms.Button();
            this.btn_initTCP = new System.Windows.Forms.Button();
            this.btn_listenTCP = new System.Windows.Forms.Button();
            this.btn_accept = new System.Windows.Forms.Button();
            this.lb_tcp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_output = new System.Windows.Forms.RichTextBox();
            this.btn_testSend = new System.Windows.Forms.Button();
            this.group_clients.SuspendLayout();
            this.group_ServerSettings.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_clients
            // 
            this.group_clients.Controls.Add(this.txt_playerInfo);
            this.group_clients.Controls.Add(this.lb_clients);
            this.group_clients.Controls.Add(this.txt_clients);
            this.group_clients.Controls.Add(this.lb_playersList);
            this.group_clients.Controls.Add(this.lb_playerInfo);
            this.group_clients.Location = new System.Drawing.Point(445, 14);
            this.group_clients.Name = "group_clients";
            this.group_clients.Size = new System.Drawing.Size(436, 218);
            this.group_clients.TabIndex = 21;
            this.group_clients.TabStop = false;
            this.group_clients.Text = "Connected Clients";
            // 
            // txt_playerInfo
            // 
            this.txt_playerInfo.Location = new System.Drawing.Point(179, 57);
            this.txt_playerInfo.Name = "txt_playerInfo";
            this.txt_playerInfo.ReadOnly = true;
            this.txt_playerInfo.Size = new System.Drawing.Size(249, 147);
            this.txt_playerInfo.TabIndex = 11;
            this.txt_playerInfo.Text = "";
            // 
            // lb_clients
            // 
            this.lb_clients.AutoSize = true;
            this.lb_clients.Location = new System.Drawing.Point(6, 28);
            this.lb_clients.Name = "lb_clients";
            this.lb_clients.Size = new System.Drawing.Size(72, 13);
            this.lb_clients.TabIndex = 8;
            this.lb_clients.Text = "No. of clients:";
            // 
            // txt_clients
            // 
            this.txt_clients.Location = new System.Drawing.Point(81, 28);
            this.txt_clients.Name = "txt_clients";
            this.txt_clients.ReadOnly = true;
            this.txt_clients.Size = new System.Drawing.Size(69, 20);
            this.txt_clients.TabIndex = 9;
            // 
            // lb_playersList
            // 
            this.lb_playersList.FormattingEnabled = true;
            this.lb_playersList.Location = new System.Drawing.Point(6, 57);
            this.lb_playersList.Name = "lb_playersList";
            this.lb_playersList.Size = new System.Drawing.Size(144, 147);
            this.lb_playersList.TabIndex = 10;
            this.lb_playersList.DoubleClick += new System.EventHandler(this.LBox_ClientsView);
            // 
            // lb_playerInfo
            // 
            this.lb_playerInfo.AutoSize = true;
            this.lb_playerInfo.Location = new System.Drawing.Point(176, 28);
            this.lb_playerInfo.Name = "lb_playerInfo";
            this.lb_playerInfo.Size = new System.Drawing.Size(63, 13);
            this.lb_playerInfo.TabIndex = 12;
            this.lb_playerInfo.Text = "Player\'s info";
            // 
            // txt_ip
            // 
            this.txt_ip.Location = new System.Drawing.Point(259, 70);
            this.txt_ip.Name = "txt_ip";
            this.txt_ip.ReadOnly = true;
            this.txt_ip.Size = new System.Drawing.Size(100, 20);
            this.txt_ip.TabIndex = 16;
            // 
            // lb_ip
            // 
            this.lb_ip.AutoSize = true;
            this.lb_ip.Location = new System.Drawing.Point(259, 53);
            this.lb_ip.Name = "lb_ip";
            this.lb_ip.Size = new System.Drawing.Size(57, 13);
            this.lb_ip.TabIndex = 15;
            this.lb_ip.Text = "Server IP: ";
            // 
            // txt_conPort
            // 
            this.txt_conPort.Location = new System.Drawing.Point(259, 109);
            this.txt_conPort.Name = "txt_conPort";
            this.txt_conPort.Size = new System.Drawing.Size(100, 20);
            this.txt_conPort.TabIndex = 14;
            this.txt_conPort.Text = "8000";
            // 
            // lb_conPort
            // 
            this.lb_conPort.AutoSize = true;
            this.lb_conPort.Location = new System.Drawing.Point(256, 92);
            this.lb_conPort.Name = "lb_conPort";
            this.lb_conPort.Size = new System.Drawing.Size(89, 13);
            this.lb_conPort.TabIndex = 13;
            this.lb_conPort.Text = "Connection Port: ";
            // 
            // group_ServerSettings
            // 
            this.group_ServerSettings.Controls.Add(this.btn_testSend);
            this.group_ServerSettings.Controls.Add(this.lb_udp);
            this.group_ServerSettings.Controls.Add(this.btn_enableLocating);
            this.group_ServerSettings.Controls.Add(this.txt_ip);
            this.group_ServerSettings.Controls.Add(this.btn_initTCP);
            this.group_ServerSettings.Controls.Add(this.lb_ip);
            this.group_ServerSettings.Controls.Add(this.btn_listenTCP);
            this.group_ServerSettings.Controls.Add(this.txt_conPort);
            this.group_ServerSettings.Controls.Add(this.btn_accept);
            this.group_ServerSettings.Controls.Add(this.lb_conPort);
            this.group_ServerSettings.Controls.Add(this.lb_tcp);
            this.group_ServerSettings.Location = new System.Drawing.Point(12, 14);
            this.group_ServerSettings.Name = "group_ServerSettings";
            this.group_ServerSettings.Size = new System.Drawing.Size(391, 218);
            this.group_ServerSettings.TabIndex = 22;
            this.group_ServerSettings.TabStop = false;
            this.group_ServerSettings.Text = "Server Settings";
            // 
            // lb_udp
            // 
            this.lb_udp.AutoSize = true;
            this.lb_udp.Location = new System.Drawing.Point(6, 28);
            this.lb_udp.Name = "lb_udp";
            this.lb_udp.Size = new System.Drawing.Size(103, 13);
            this.lb_udp.TabIndex = 4;
            this.lb_udp.Text = "UDP OPERATIONS";
            // 
            // btn_enableLocating
            // 
            this.btn_enableLocating.Location = new System.Drawing.Point(5, 53);
            this.btn_enableLocating.Name = "btn_enableLocating";
            this.btn_enableLocating.Size = new System.Drawing.Size(104, 52);
            this.btn_enableLocating.TabIndex = 0;
            this.btn_enableLocating.Text = "Enable Locating Server (UDP)";
            this.btn_enableLocating.UseVisualStyleBackColor = true;
            // 
            // btn_initTCP
            // 
            this.btn_initTCP.Location = new System.Drawing.Point(132, 53);
            this.btn_initTCP.Name = "btn_initTCP";
            this.btn_initTCP.Size = new System.Drawing.Size(104, 23);
            this.btn_initTCP.TabIndex = 1;
            this.btn_initTCP.Text = "Initialise TCP";
            this.btn_initTCP.UseVisualStyleBackColor = true;
            this.btn_initTCP.Click += new System.EventHandler(this.btn_initTCP_Click);
            // 
            // btn_listenTCP
            // 
            this.btn_listenTCP.Location = new System.Drawing.Point(132, 81);
            this.btn_listenTCP.Name = "btn_listenTCP";
            this.btn_listenTCP.Size = new System.Drawing.Size(104, 39);
            this.btn_listenTCP.TabIndex = 2;
            this.btn_listenTCP.Text = "Listen for connections";
            this.btn_listenTCP.UseVisualStyleBackColor = true;
            this.btn_listenTCP.Click += new System.EventHandler(this.btn_listenTCP_Click);
            // 
            // btn_accept
            // 
            this.btn_accept.Location = new System.Drawing.Point(132, 126);
            this.btn_accept.Name = "btn_accept";
            this.btn_accept.Size = new System.Drawing.Size(104, 41);
            this.btn_accept.TabIndex = 3;
            this.btn_accept.Text = "Accept incoming connections ";
            this.btn_accept.UseVisualStyleBackColor = true;
            this.btn_accept.Click += new System.EventHandler(this.btn_accept_Click);
            // 
            // lb_tcp
            // 
            this.lb_tcp.AutoSize = true;
            this.lb_tcp.Location = new System.Drawing.Point(133, 28);
            this.lb_tcp.Name = "lb_tcp";
            this.lb_tcp.Size = new System.Drawing.Size(101, 13);
            this.lb_tcp.TabIndex = 5;
            this.lb_tcp.Text = "TCP OPERATIONS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 249);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "SERVER OUTPUT";
            // 
            // txt_output
            // 
            this.txt_output.Location = new System.Drawing.Point(12, 265);
            this.txt_output.Name = "txt_output";
            this.txt_output.ReadOnly = true;
            this.txt_output.Size = new System.Drawing.Size(869, 221);
            this.txt_output.TabIndex = 20;
            this.txt_output.Text = "";
            // 
            // btn_testSend
            // 
            this.btn_testSend.Location = new System.Drawing.Point(259, 143);
            this.btn_testSend.Name = "btn_testSend";
            this.btn_testSend.Size = new System.Drawing.Size(75, 23);
            this.btn_testSend.TabIndex = 17;
            this.btn_testSend.Text = "TEST SEND";
            this.btn_testSend.UseVisualStyleBackColor = true;
            this.btn_testSend.Click += new System.EventHandler(this.btn_testSend_Click);
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 496);
            this.Controls.Add(this.group_clients);
            this.Controls.Add(this.group_ServerSettings);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_output);
            this.Name = "Server";
            this.Text = "Form1";
            this.group_clients.ResumeLayout(false);
            this.group_clients.PerformLayout();
            this.group_ServerSettings.ResumeLayout(false);
            this.group_ServerSettings.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox group_clients;
        private System.Windows.Forms.RichTextBox txt_playerInfo;
        private System.Windows.Forms.Label lb_clients;
        private System.Windows.Forms.TextBox txt_clients;
        private System.Windows.Forms.ListBox lb_playersList;
        private System.Windows.Forms.Label lb_playerInfo;
        private System.Windows.Forms.TextBox txt_ip;
        private System.Windows.Forms.Label lb_ip;
        private System.Windows.Forms.TextBox txt_conPort;
        private System.Windows.Forms.Label lb_conPort;
        private System.Windows.Forms.GroupBox group_ServerSettings;
        private System.Windows.Forms.Label lb_udp;
        public System.Windows.Forms.Button btn_enableLocating;
        private System.Windows.Forms.Button btn_initTCP;
        private System.Windows.Forms.Button btn_listenTCP;
        private System.Windows.Forms.Button btn_accept;
        private System.Windows.Forms.Label lb_tcp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txt_output;
        private System.Windows.Forms.Button btn_testSend;
    }
}


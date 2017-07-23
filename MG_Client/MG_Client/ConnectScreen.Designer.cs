namespace MG_Client
{
    partial class ConnectScreen
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
            this.txt_connectionPort = new System.Windows.Forms.TextBox();
            this.btn_connect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_port = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.lb_IP = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_connectionPort
            // 
            this.txt_connectionPort.Location = new System.Drawing.Point(235, 174);
            this.txt_connectionPort.Name = "txt_connectionPort";
            this.txt_connectionPort.Size = new System.Drawing.Size(100, 20);
            this.txt_connectionPort.TabIndex = 18;
            this.txt_connectionPort.Text = "8000";
            // 
            // btn_connect
            // 
            this.btn_connect.Location = new System.Drawing.Point(260, 214);
            this.btn_connect.Name = "btn_connect";
            this.btn_connect.Size = new System.Drawing.Size(75, 23);
            this.btn_connect.TabIndex = 17;
            this.btn_connect.Text = "Connect";
            this.btn_connect.UseVisualStyleBackColor = true;
            this.btn_connect.Click += new System.EventHandler(this.btn_connect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(56, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(430, 31);
            this.label1.TabIndex = 16;
            this.label1.Text = "Welcome To Social Memory Game";
            // 
            // lb_port
            // 
            this.lb_port.AutoSize = true;
            this.lb_port.Location = new System.Drawing.Point(181, 174);
            this.lb_port.Name = "lb_port";
            this.lb_port.Size = new System.Drawing.Size(29, 13);
            this.lb_port.TabIndex = 15;
            this.lb_port.Text = "Port:";
            // 
            // txt_name
            // 
            this.txt_name.Location = new System.Drawing.Point(235, 145);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(100, 20);
            this.txt_name.TabIndex = 14;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(181, 148);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(41, 13);
            this.lb_name.TabIndex = 13;
            this.lb_name.Text = "Name: ";
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(235, 116);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(100, 20);
            this.txt_IP.TabIndex = 12;
            // 
            // lb_IP
            // 
            this.lb_IP.AutoSize = true;
            this.lb_IP.Location = new System.Drawing.Point(181, 119);
            this.lb_IP.Name = "lb_IP";
            this.lb_IP.Size = new System.Drawing.Size(48, 13);
            this.lb_IP.TabIndex = 11;
            this.lb_IP.Text = "Your IP: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 19;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ConnectScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(544, 288);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_connectionPort);
            this.Controls.Add(this.btn_connect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_port);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.txt_IP);
            this.Controls.Add(this.lb_IP);
            this.Name = "ConnectScreen";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_connectionPort;
        private System.Windows.Forms.Button btn_connect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_port;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label lb_IP;
        private System.Windows.Forms.Button button1;
    }
}


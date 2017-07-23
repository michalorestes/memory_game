namespace MG_Client
{
    partial class MainScreen
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Ranking = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lBox_playersList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_invitePlayer = new System.Windows.Forms.Button();
            this.lb_welcome = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ranking,
            this.PlayerName,
            this.PlayerScore,
            this.Date});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(825, 694);
            this.dataGridView1.TabIndex = 0;
            // 
            // Ranking
            // 
            this.Ranking.HeaderText = "Ranking";
            this.Ranking.Name = "Ranking";
            this.Ranking.ReadOnly = true;
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Player Name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.ReadOnly = true;
            // 
            // PlayerScore
            // 
            this.PlayerScore.HeaderText = "Player Score";
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lBox_playersList);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.btn_invitePlayer);
            this.splitContainer1.Panel2.Controls.Add(this.lb_welcome);
            this.splitContainer1.Size = new System.Drawing.Size(1110, 694);
            this.splitContainer1.SplitterDistance = 825;
            this.splitContainer1.TabIndex = 1;
            // 
            // lBox_playersList
            // 
            this.lBox_playersList.FormattingEnabled = true;
            this.lBox_playersList.Location = new System.Drawing.Point(19, 100);
            this.lBox_playersList.Name = "lBox_playersList";
            this.lBox_playersList.Size = new System.Drawing.Size(239, 316);
            this.lBox_playersList.TabIndex = 3;
            this.lBox_playersList.DoubleClick += new System.EventHandler(this.lBox_playersList_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Location = new System.Drawing.Point(19, 439);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 232);
            this.panel1.TabIndex = 2;
            // 
            // btn_invitePlayer
            // 
            this.btn_invitePlayer.Location = new System.Drawing.Point(19, 58);
            this.btn_invitePlayer.Name = "btn_invitePlayer";
            this.btn_invitePlayer.Size = new System.Drawing.Size(75, 23);
            this.btn_invitePlayer.TabIndex = 1;
            this.btn_invitePlayer.Text = "Invite Player";
            this.btn_invitePlayer.UseVisualStyleBackColor = true;
            // 
            // lb_welcome
            // 
            this.lb_welcome.AutoSize = true;
            this.lb_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_welcome.Location = new System.Drawing.Point(14, 19);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(179, 26);
            this.lb_welcome.TabIndex = 0;
            this.lb_welcome.Text = "Welcome Michal!";
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 694);
            this.Controls.Add(this.splitContainer1);
            this.Name = "MainScreen";
            this.Text = "MainScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ranking;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListBox lBox_playersList;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Button btn_invitePlayer;
        public System.Windows.Forms.Label lb_welcome;
    }
}
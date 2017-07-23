namespace MG_Client
{
    partial class GameScreen
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
            this.lb_playingAgainst = new System.Windows.Forms.Label();
            this.panel_tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.card16 = new MG_Client.Card();
            this.card15 = new MG_Client.Card();
            this.card14 = new MG_Client.Card();
            this.card13 = new MG_Client.Card();
            this.card12 = new MG_Client.Card();
            this.card11 = new MG_Client.Card();
            this.card10 = new MG_Client.Card();
            this.card9 = new MG_Client.Card();
            this.card8 = new MG_Client.Card();
            this.card7 = new MG_Client.Card();
            this.card6 = new MG_Client.Card();
            this.card5 = new MG_Client.Card();
            this.card4 = new MG_Client.Card();
            this.card3 = new MG_Client.Card();
            this.card2 = new MG_Client.Card();
            this.card1 = new MG_Client.Card();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lb_opponentsScore = new System.Windows.Forms.Label();
            this.lb_myScore = new System.Windows.Forms.Label();
            this.lb_turnTime = new System.Windows.Forms.Label();
            this.panel_tableLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_playingAgainst
            // 
            this.lb_playingAgainst.AutoSize = true;
            this.lb_playingAgainst.Location = new System.Drawing.Point(4, 13);
            this.lb_playingAgainst.Name = "lb_playingAgainst";
            this.lb_playingAgainst.Size = new System.Drawing.Size(116, 13);
            this.lb_playingAgainst.TabIndex = 0;
            this.lb_playingAgainst.Text = "You\'re playing against: ";
            // 
            // panel_tableLayout
            // 
            this.panel_tableLayout.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel_tableLayout.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.panel_tableLayout.ColumnCount = 4;
            this.panel_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_tableLayout.Controls.Add(this.card16, 3, 3);
            this.panel_tableLayout.Controls.Add(this.card15, 2, 3);
            this.panel_tableLayout.Controls.Add(this.card14, 1, 3);
            this.panel_tableLayout.Controls.Add(this.card13, 0, 3);
            this.panel_tableLayout.Controls.Add(this.card12, 3, 2);
            this.panel_tableLayout.Controls.Add(this.card11, 2, 2);
            this.panel_tableLayout.Controls.Add(this.card10, 1, 2);
            this.panel_tableLayout.Controls.Add(this.card9, 0, 2);
            this.panel_tableLayout.Controls.Add(this.card8, 3, 1);
            this.panel_tableLayout.Controls.Add(this.card7, 2, 1);
            this.panel_tableLayout.Controls.Add(this.card6, 1, 1);
            this.panel_tableLayout.Controls.Add(this.card5, 0, 1);
            this.panel_tableLayout.Controls.Add(this.card4, 3, 0);
            this.panel_tableLayout.Controls.Add(this.card3, 2, 0);
            this.panel_tableLayout.Controls.Add(this.card2, 1, 0);
            this.panel_tableLayout.Controls.Add(this.card1, 0, 0);
            this.panel_tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_tableLayout.ForeColor = System.Drawing.SystemColors.WindowText;
            this.panel_tableLayout.Location = new System.Drawing.Point(0, 0);
            this.panel_tableLayout.Name = "panel_tableLayout";
            this.panel_tableLayout.RowCount = 4;
            this.panel_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.panel_tableLayout.Size = new System.Drawing.Size(797, 662);
            this.panel_tableLayout.TabIndex = 0;
            // 
            // card16
            // 
            this.card16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card16.Icon = "ICON";
            this.card16.Location = new System.Drawing.Point(599, 500);
            this.card16.Name = "card16";
            this.card16.Size = new System.Drawing.Size(193, 157);
            this.card16.TabIndex = 15;
            this.card16.Click += new System.EventHandler(this.cardClick);
            // 
            // card15
            // 
            this.card15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card15.Icon = "ICON";
            this.card15.Location = new System.Drawing.Point(401, 500);
            this.card15.Name = "card15";
            this.card15.Size = new System.Drawing.Size(190, 157);
            this.card15.TabIndex = 14;
            this.card15.Click += new System.EventHandler(this.cardClick);
            // 
            // card14
            // 
            this.card14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card14.Icon = "ICON";
            this.card14.Location = new System.Drawing.Point(203, 500);
            this.card14.Name = "card14";
            this.card14.Size = new System.Drawing.Size(190, 157);
            this.card14.TabIndex = 13;
            this.card14.Click += new System.EventHandler(this.cardClick);
            // 
            // card13
            // 
            this.card13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card13.Icon = "ICON";
            this.card13.Location = new System.Drawing.Point(5, 500);
            this.card13.Name = "card13";
            this.card13.Size = new System.Drawing.Size(190, 157);
            this.card13.TabIndex = 12;
            this.card13.Click += new System.EventHandler(this.cardClick);
            // 
            // card12
            // 
            this.card12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card12.Icon = "ICON";
            this.card12.Location = new System.Drawing.Point(599, 335);
            this.card12.Name = "card12";
            this.card12.Size = new System.Drawing.Size(193, 157);
            this.card12.TabIndex = 11;
            this.card12.Click += new System.EventHandler(this.cardClick);
            // 
            // card11
            // 
            this.card11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card11.Icon = "ICON";
            this.card11.Location = new System.Drawing.Point(401, 335);
            this.card11.Name = "card11";
            this.card11.Size = new System.Drawing.Size(190, 157);
            this.card11.TabIndex = 10;
            this.card11.Click += new System.EventHandler(this.cardClick);
            // 
            // card10
            // 
            this.card10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card10.Icon = "ICON";
            this.card10.Location = new System.Drawing.Point(203, 335);
            this.card10.Name = "card10";
            this.card10.Size = new System.Drawing.Size(190, 157);
            this.card10.TabIndex = 9;
            this.card10.Click += new System.EventHandler(this.cardClick);
            // 
            // card9
            // 
            this.card9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card9.Icon = "ICON";
            this.card9.Location = new System.Drawing.Point(5, 335);
            this.card9.Name = "card9";
            this.card9.Size = new System.Drawing.Size(190, 157);
            this.card9.TabIndex = 8;
            this.card9.Click += new System.EventHandler(this.cardClick);
            // 
            // card8
            // 
            this.card8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card8.Icon = "ICON";
            this.card8.Location = new System.Drawing.Point(599, 170);
            this.card8.Name = "card8";
            this.card8.Size = new System.Drawing.Size(193, 157);
            this.card8.TabIndex = 7;
            this.card8.Click += new System.EventHandler(this.cardClick);
            // 
            // card7
            // 
            this.card7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card7.Icon = "ICON";
            this.card7.Location = new System.Drawing.Point(401, 170);
            this.card7.Name = "card7";
            this.card7.Size = new System.Drawing.Size(190, 157);
            this.card7.TabIndex = 6;
            this.card7.Click += new System.EventHandler(this.cardClick);
            // 
            // card6
            // 
            this.card6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card6.Icon = "ICON";
            this.card6.Location = new System.Drawing.Point(203, 170);
            this.card6.Name = "card6";
            this.card6.Size = new System.Drawing.Size(190, 157);
            this.card6.TabIndex = 5;
            this.card6.Click += new System.EventHandler(this.cardClick);
            // 
            // card5
            // 
            this.card5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card5.Icon = "ICON";
            this.card5.Location = new System.Drawing.Point(5, 170);
            this.card5.Name = "card5";
            this.card5.Size = new System.Drawing.Size(190, 157);
            this.card5.TabIndex = 4;
            this.card5.Click += new System.EventHandler(this.cardClick);
            // 
            // card4
            // 
            this.card4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card4.Icon = "ICON";
            this.card4.Location = new System.Drawing.Point(599, 5);
            this.card4.Name = "card4";
            this.card4.Size = new System.Drawing.Size(193, 157);
            this.card4.TabIndex = 3;
            this.card4.Click += new System.EventHandler(this.cardClick);
            // 
            // card3
            // 
            this.card3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card3.Icon = "ICON";
            this.card3.Location = new System.Drawing.Point(401, 5);
            this.card3.Name = "card3";
            this.card3.Size = new System.Drawing.Size(190, 157);
            this.card3.TabIndex = 2;
            this.card3.Click += new System.EventHandler(this.cardClick);
            // 
            // card2
            // 
            this.card2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card2.Icon = "ICON";
            this.card2.Location = new System.Drawing.Point(203, 5);
            this.card2.Name = "card2";
            this.card2.Size = new System.Drawing.Size(190, 157);
            this.card2.TabIndex = 1;
            this.card2.Click += new System.EventHandler(this.cardClick);
            // 
            // card1
            // 
            this.card1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.card1.Icon = "ICON";
            this.card1.Location = new System.Drawing.Point(5, 5);
            this.card1.Name = "card1";
            this.card1.Size = new System.Drawing.Size(190, 157);
            this.card1.TabIndex = 0;
            this.card1.Click += new System.EventHandler(this.cardClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel_tableLayout);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lb_turnTime);
            this.splitContainer1.Panel2.Controls.Add(this.lb_opponentsScore);
            this.splitContainer1.Panel2.Controls.Add(this.lb_myScore);
            this.splitContainer1.Panel2.Controls.Add(this.lb_playingAgainst);
            this.splitContainer1.Panel2.Click += new System.EventHandler(this.cardClick);
            this.splitContainer1.Size = new System.Drawing.Size(1042, 662);
            this.splitContainer1.SplitterDistance = 797;
            this.splitContainer1.TabIndex = 3;
            // 
            // lb_opponentsScore
            // 
            this.lb_opponentsScore.AutoSize = true;
            this.lb_opponentsScore.Location = new System.Drawing.Point(4, 88);
            this.lb_opponentsScore.Name = "lb_opponentsScore";
            this.lb_opponentsScore.Size = new System.Drawing.Size(96, 13);
            this.lb_opponentsScore.TabIndex = 2;
            this.lb_opponentsScore.Text = "Oppenents Score: ";
            // 
            // lb_myScore
            // 
            this.lb_myScore.AutoSize = true;
            this.lb_myScore.Location = new System.Drawing.Point(4, 52);
            this.lb_myScore.Name = "lb_myScore";
            this.lb_myScore.Size = new System.Drawing.Size(58, 13);
            this.lb_myScore.TabIndex = 1;
            this.lb_myScore.Text = "My Score: ";
            // 
            // lb_turnTime
            // 
            this.lb_turnTime.AutoSize = true;
            this.lb_turnTime.Location = new System.Drawing.Point(7, 127);
            this.lb_turnTime.Name = "lb_turnTime";
            this.lb_turnTime.Size = new System.Drawing.Size(57, 13);
            this.lb_turnTime.TabIndex = 3;
            this.lb_turnTime.Text = "Time Left: ";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1042, 662);
            this.Controls.Add(this.splitContainer1);
            this.Name = "GameScreen";
            this.Text = "GameScreen";
            this.panel_tableLayout.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_playingAgainst;
        private System.Windows.Forms.TableLayoutPanel panel_tableLayout;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private Card card1;
        private Card card16;
        private Card card15;
        private Card card14;
        private Card card13;
        private Card card12;
        private Card card11;
        private Card card10;
        private Card card9;
        private Card card8;
        private Card card7;
        private Card card6;
        private Card card5;
        private Card card4;
        private Card card3;
        private Card card2;
        private System.Windows.Forms.Label lb_opponentsScore;
        private System.Windows.Forms.Label lb_myScore;
        private System.Windows.Forms.Label lb_turnTime;
    }
}
namespace MG_Client
{
    partial class Card
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Card));
            this.lb_cover = new System.Windows.Forms.Label();
            this.lb_icon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_cover
            // 
            this.lb_cover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_cover.Font = new System.Drawing.Font("Webdings", 48F);
            this.lb_cover.Image = ((System.Drawing.Image)(resources.GetObject("lb_cover.Image")));
            this.lb_cover.Location = new System.Drawing.Point(0, 0);
            this.lb_cover.Name = "lb_cover";
            this.lb_cover.Size = new System.Drawing.Size(100, 150);
            this.lb_cover.TabIndex = 0;
            this.lb_cover.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_cover.Click += new System.EventHandler(this.click);
            // 
            // lb_icon
            // 
            this.lb_icon.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_icon.Font = new System.Drawing.Font("Webdings", 38F);
            this.lb_icon.Location = new System.Drawing.Point(0, 0);
            this.lb_icon.Name = "lb_icon";
            this.lb_icon.Size = new System.Drawing.Size(100, 150);
            this.lb_icon.TabIndex = 1;
            this.lb_icon.Text = "icon";
            this.lb_icon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_icon.Visible = false;
            // 
            // Card
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_cover);
            this.Controls.Add(this.lb_icon);
            this.Name = "Card";
            this.Size = new System.Drawing.Size(100, 150);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lb_cover;
        private System.Windows.Forms.Label lb_icon;
    }
}

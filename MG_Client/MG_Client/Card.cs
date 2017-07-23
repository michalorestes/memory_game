    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.Data;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Forms;


namespace MG_Client

{

    public partial class Card : UserControl

    {

        public string Icon
            {
                get
                {
                    return lb_icon.Text;
                }

                set
                {
                    lb_icon.Text = value;
                }
            }
        public int cardID { get; set; }

            
            public Card()
            {
                InitializeComponent();
                lb_icon.Text = "ICON";
                lb_icon.Visible = false;
                lb_cover.Visible = true;
            }


            public void clickCard()
            {
                lb_icon.Visible = !lb_icon.Visible;
                lb_cover.Visible = !lb_cover.Visible;
            }

        private void click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
    }

}

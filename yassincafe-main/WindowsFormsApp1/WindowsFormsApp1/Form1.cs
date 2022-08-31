using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
          

        }
      
   
                      
        public void loadform(object Form)
        {
            if (this.deskpanel.Controls.Count > 0)
                this.deskpanel.Controls.RemoveAt(0);

            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.deskpanel.Controls.Add(f);
            this.deskpanel.Tag = f;
            f.Show();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    

      

        private void btncafe_Click(object sender, EventArgs e)
        {
            loadform(new cafee());
            lbltitle.Text = "االمقهي";
        }
        private void btnsouk_Click(object sender, EventArgs e)
        {

            loadform(new sok());
            lbltitle.Text = "االسويقة";
        }

        private void deskpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

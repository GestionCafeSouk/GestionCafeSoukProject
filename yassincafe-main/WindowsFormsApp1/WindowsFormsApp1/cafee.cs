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
    public partial class cafee : Form
    {
        public cafee()
        {
            InitializeComponent();
        }
        cnx c = new cnx();
        public void act()
        {
            c.connecter();
            c.cmd.CommandText = " select * from cafe ";
            c.cmd.Connection = c.cn;
            c.dr = c.cmd.ExecuteReader();
            c.dt.Load(c.dr);
            dataGridCafe.DataSource = c.dt;
            c.deconnecter();
        }
        public void Ajoutercolonne()
        {
            DataGridViewButtonColumn btn = new DataGridViewButtonColumn();
            btn.Name = " Suppression ";
            btn.Text = " Supprimer ";
            btn.UseColumnTextForButtonValue = true;
            dataGridCafe.Columns.Add(btn);
        }
        

        private void cafee_Load(object sender, EventArgs e)
        {
            act();
            Ajoutercolonne();
        }

        private void btntact_Click(object sender, EventArgs e)
        {
            c.dt.Clear();
            act();
        }

        private void btnAjou_Click(object sender, EventArgs e)
        {
          
                c.connecter();
                c.cmd.CommandText = "insert into [cafe] values ('"+txtDakhl.Text+"','"+txtnaf.Text+"','"+ TimeInsert.Value + "')";
                c.cmd.Connection = c.cn;
                c.cmd.ExecuteNonQuery();
                MessageBox.Show("Lugne affecté");
                c.deconnecter();
                c.dt.Clear();
                act();
          
        }

        private void dataGridCafe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex!=3)
            {
                return;
            }
            if(MessageBox.Show("?تريد المسح ، هل أنت متأكد","Message",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                
            }
        }
    }
}

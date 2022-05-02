using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiOtomasyon
{
    public partial class Form1 : Form
    {
        public static string baglanti = "Data Source=W10; Initial Catalog=KisiTakipotomasyon; Integrated Security=True;";
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.ShowDialog();
        }

        private void kullanıcıEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            user_Registration ur = new user_Registration();
            ur.ShowDialog();
        }
        private void ürünİşlemleriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            product_Registration pr = new product_Registration();
            pr.ShowDialog();
        }

        private void kategoriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            category_Registration cr = new category_Registration();
            cr.ShowDialog();
        }

        private void müşteriEkleListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer_Registrartion cr = new customer_Registrartion();
            cr.ShowDialog();
        }

        private void satışEkleListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sales_Transactions st = new sales_Transactions();
            st.ShowDialog();
        }

        private void firmaEkleListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            company_Registration cr = new company_Registration();
            cr.ShowDialog();
        }
    }
}

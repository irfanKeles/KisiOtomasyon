using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;

namespace KisiOtomasyon
{
    public partial class category_Registration : Form
    {
        public category_Registration()
        {
            InitializeComponent();
        }
        //----- Kategori id güncelleme sayfası için alındı
        public static int cateId = 0;
        //----- KATEGORİ İŞLEMLERİ / LİSTELEME / EKELME / SİLME / ARAMA 
        public void cateList()
        {
            try
            {
                string sql_text = "select Kategori_id as 'Kategori No', Kategori_adi as 'Kategori Ad' from kategori";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cateGrid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori Listenirken HATA !" + ex);
            }

        }
        private void cateAdd(string name)
        {
            try
            {
                string sql_text = "insert into kategori values('" + name + "')";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Kategori Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori Eklenirken HATA !" + ex);
            }
            finally
            {
                cateList();
            }
        }
        private void cateDelete(int id)
        {
            try
            {
                DialogResult msj = new DialogResult();
                msj = MessageBox.Show("Kategoriyi Silmek İstiyormusunuz ?", "Silme İşlemi.", MessageBoxButtons.YesNo);
                if (msj == DialogResult.Yes)
                {
                    string sql_text = "delete from kategori where Kategori_id=" + id;
                    SqlConnection con = new SqlConnection(Form1.baglanti);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori Silinirken Hata ! " + ex);
            }
            finally
            {
                cateList();
            }
        }
        private void search(string name)
        {
            try
            {
                string sql_text = "select Kategori_id as 'Kategori No', Kategori_adi as 'Kategori Ad' " +
                                  " from kategori " +
                                  " where Kategori_adi like '%" + name + "%'";

                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                da.Fill(dt);
                cateGrid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme sırasında HATA !" + ex);
            }
        }
        //----- TEXTBOX TEMİZLEME İŞLEMLERİ
        private void clear()
        {
            txt_cate.Clear();
        }
        //----- PANEL ARKAPLAN RENKLERİ
        private void panelBg()
        {
            this.pnl_top_userlist.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.pnl_cate_add.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.panel_search.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void category_Registration_Load(object sender, EventArgs e)
        {
            panelBg();
            cateList();
            txt_cate.Focus();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cateGrid.CurrentRow.Cells["Kategori No"].Value);
            cateDelete(id);
        }
        private void txt_cate_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_cate_search.Text != "" || txt_cate_search.Text == "")
            {
                string text = txt_cate_search.Text;
                search(text);
            }
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cateId = Convert.ToInt32(cateGrid.CurrentRow.Cells["Kategori No"].Value);
            category_Update cu = new category_Update();
            cu.Show();
        }
        private void btn_cate_add_Click(object sender, EventArgs e)
        {
            if (txt_cate.Text != "")
            {
                string name = txt_cate.Text;
                cateAdd(name);
            }
            else
            {
                MessageBox.Show("Kategori Adı Boş Geçilemez !");
            }
            clear();
        }

        private void category_Registration_Activated(object sender, EventArgs e)
        {
            cateList();
        }
    }
}

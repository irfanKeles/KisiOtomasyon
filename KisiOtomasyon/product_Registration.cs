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
    public partial class product_Registration : Form
    {
        public product_Registration()
        {
            InitializeComponent();
        }
        //----- ÜRÜN İD/ KATEGORİ DEĞERİ ALMA İŞLEMLERİ
        public static int productId = 0;
        public static string proCatagoryName = "";
        //----- ÜRÜN LİSTELEME / SİLME / ARAMA / EKELME
        private void productList()
        {
            try
            {
                string sql_text = "select Urun_id as 'Ürün No', Urun_ad as 'Ürün Ad', " +
                                   " Urun_aciklama as 'Ürün Açıklama', Urun_fiyat as 'Ürün Fiyat', " +
                                   " Kategori_adi as 'Kategori' " +
                                   " from urun" +
                                   " inner join kategori on urun.ref_katagori = kategori.Kategori_id ";
                //  " left join kategori on urun.Urun_id=kategori.Kategori_id";

                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                pro_grid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürünler Listenirken HATA ! " + ex);
            }
        }
        private void productAdd(string name, string explanation, int money, int cate)
        {
            try
            {
                string sql_text = "insert into urun values('" + name + "','" + explanation + "','" + money + "','" + cate + "')";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                clear();
                MessageBox.Show("Ürün Başarıyla Kayıt Edilmiştir");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün EKleme Sırasında HATA ! " + ex);
            }
            finally
            {
                productList();
            }
        }
        private void productDelete(int id)
        {
            try
            {
                if (id != 0)
                {
                    DialogResult msj = new DialogResult();
                    msj = MessageBox.Show("Silkmek İstediğinize Eminmisiniz ?", "Silme işlemi", MessageBoxButtons.YesNo);
                    if (msj == DialogResult.Yes)
                    {
                        string sql = "delete from urun where Urun_id=" + id;
                        SqlConnection con = new SqlConnection(Form1.baglanti);
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Silinirken HATA !" + ex);
            }
            finally
            {
                productList();
            }
        }
        private void search(string data)
        {
            try
            {
                string sql_text = "select Urun_id as 'Ürün No', Urun_ad as 'Ürün Ad', " +
                               " Urun_aciklama as 'Ürün Açıklama', Urun_fiyat as 'Ürün Fiyat', " +
                               " Kategori_adi as 'Kategori' " +
                               " from urun " +
                               " left join kategori on urun.Urun_id=kategori.Kategori_id " +
                               " where Urun_ad like '%" + data + "%' " +
                               " or Urun_aciklama like '%" + data + "%' or Urun_fiyat like '%" + data + "%' "+
                               " or Kategori_adi like '%" + data + "%'";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                pro_grid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme sırasında HATA !" + ex);
            }
        }
        //----- KATEGORİ LİSTESİNİN ÇEKİLMESİ
        private void getCateCmd()
        {
            try
            {
                string sql_text = "select * from kategori";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cbb_cate.DataSource = ds.Tables[0];
                cbb_cate.DisplayMember = "Kategori_adi";
                cbb_cate.ValueMember = "Kategori_id";
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler Yüklenemedi !" + ex);
            }
        }
        //----- PANELLERİN ARKAPLAN RENGİ
        private void panelBg()
        {
            this.pnl_user_regis.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.pnl_top_userlist.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        //----- TEXTBOXLARIN TEMİZLENMESİ
        private void clear()
        {
            txt_pro_name.Text = "";
            txt_sell.Text = "";
            ric_explanation.Text = "";
        }
        private void product_Registration_Load(object sender, EventArgs e)
        {
            panelBg();
            productList();
            getCateCmd();
        }
        private void btn_prduct_add_Click(object sender, EventArgs e)
        {
            if (txt_pro_name.Text != "" && txt_sell.Text != "")
            {
                string name, explanation;
                int money, cate;
                name = txt_pro_name.Text;
                explanation = ric_explanation.Text;
                money = Convert.ToInt32(txt_sell.Text);
                cate = Convert.ToInt32(cbb_cate.SelectedValue);
                productAdd(name, explanation, money, cate);
            }
            else
            {
                MessageBox.Show("Lütfen ilgili Alanları Doldurunuz");
            }
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int productId = Convert.ToInt32(pro_grid.CurrentRow.Cells["Ürün No"].Value);
            productDelete(productId);
        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "" || txt_search.Text == "")
            {
                string data = txt_search.Text;
                search(data);
            }
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            productId = Convert.ToInt32(pro_grid.CurrentRow.Cells["Ürün No"].Value);
            proCatagoryName = pro_grid.CurrentRow.Cells["Kategori"].Value.ToString();
            product_Update pd = new product_Update();
            pd.Show();
        }
        private void product_Registration_Activated(object sender, EventArgs e)
        {
            productList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace KisiOtomasyon
{
    public partial class sales_Transactions : Form
    {
        public sales_Transactions()
        {
            InitializeComponent();
        }
        //----- KULLANICI ADI / ŞİFRESİ / İD NO ALMA İŞLEMİ
        string loginUserName = LoginForm.userLoginName;
        string loginUserPass = LoginForm.userLoginPass;
        int userId = 0;
        //----- ürün id / birimfiyat / adet / toplam tutar (sıralı şekilde) alınmıtır 
        int productId = 0;
        int productMuch = 0;
        int piece = 0;
        int sum = 0;
        //----- MÜŞTERİ LİSTELEME / ARAMA
        private void getCustomerList()
        {
            try
            {

                string sql_text = "select Musteri_id as 'No', Musteri_ad +' '+ Musteri_Soyad as 'Ad Soyad', " +
                                  " Musteri_tel as 'Tel No', Musteri_adres as 'Adres',firma_ad as 'Firma',Sehir_ad as 'Şehir' " +
                                  "  from musteri" +
                                  " inner join sehir on musteri.Musteri_sehir=sehir.Sehir_id " +
                                  " inner join firma on musteri.ref_firma = firma.firma_id";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                cus_grid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Müşteri Listelenirken HATA !" + ex);
            }
        }
        private void customerSearch(string data)
        {
            try
            {
                string sql_text = "select Musteri_id as 'No', Musteri_ad +' '+ Musteri_Soyad as 'Ad Soyad', " +
                                  " Musteri_tel as 'Tel No', Musteri_adres as 'Adres',firma_ad as 'Firma',Sehir_ad as 'Şehir' " +
                                  "  from musteri" +
                                  " inner join sehir on musteri.Musteri_sehir=sehir.Sehir_id " +
                                  " inner join firma on musteri.ref_firma = firma.firma_id " +
                                  " where Musteri_ad like '%" + data + "%' or Musteri_Soyad like '%" + data + "%' "+
                                  " or Musteri_adres like '%" + data + "%'  " +
                                  " or Sehir_ad like '%" + data + "%' or firma_ad like '%" + data + "%' or Musteri_tel like '%" + data + "%' ";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cus_grid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama Yaparken HATA !" + ex);
            }
        }
        //----- PERSONEL BİGİLERİNİ GETİRME VE LABELE EKLEME
        private void salesPoerson()
        {
            lbl_sell_title.Text = loginUserName;
        }
        private void getUser(string username, string pass)
        {
            try
            {
                if (username != "" && pass != "")
                {
                    string sql_text = "select * from kullanici where Kullanici_Ad='" + username + "' and Kullanici_Sifre='" + pass + "'";

                    SqlConnection con = new SqlConnection(Form1.baglanti);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        userId = Convert.ToInt32(dr["Kisi_id"]);
                        int admin = Convert.ToInt32(dr["Kullanici_Admin"]);
                        if (admin == 1)
                        {
                            lbl_admin.Text = "Yönetici";
                        }
                        else
                        {
                            lbl_admin.Text = "Kullanıcı";
                        }
                        lbl_sell_title.Text = dr["Kullanici_Ad"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Yüklenemedi !" + ex);
            }
        }
        //----- SATIŞ ARAMA / LİSTEEME /  EKLEME / SİLME
        private void sealSearch(string data)
        {
            try
            {
                string sql_text = "select Satis_id as 'No',Urun_ad as 'Ürün',Satis_adet as 'Adet', Kategori_adi as 'Kategori',Satis_tutar as 'Satış F.', " +
                              " Satis_aciklama as 'Açıklama', Satis_tarih as 'Satis T.', " +
                              " Musteri_ad +' '+ Musteri_soyad as 'Alıcı', Sehir_ad as 'Şehir', " +
                              " Kullanici_Ad as 'Satıcı'  from satis " +
                              " inner join musteri on satis.ref_musteri=musteri.Musteri_id " +
                              " inner join kullanici on satis.ref_kullanici= kullanici.Kisi_id " +
                              " inner join urun on satis.ref_urun=urun.Urun_id " +
                              " inner join sehir on sehir.Sehir_id = musteri.Musteri_sehir " +
                              " inner join kategori on urun.ref_katagori=kategori.Kategori_id " +
                              " where Urun_ad like '%" + data + "%' or Kategori_adi like '%" + data + "%' "+
                              " or Satis_aciklama like '%" + data + "%' or Satis_tarih like '%" + data + "%' "+
                              " or Musteri_ad like '%" + data + "%' or Musteri_soyad like '%" + data + "%' "+
                              " or Sehir_ad like '%" + data + "%' or Kullanici_Ad like '%" + data + "%' ";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                sell_grid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama Yaparken HATA !" + ex);
            }
        }
        private void getSealList()
        {
            try
            {
                string sql_text = "select Satis_id as 'No', Urun_ad as 'Ürün',Satis_adet as 'Stş.Adet', Kategori_adi as 'Kategori',Urun_fiyat as 'Birim F.', Satis_tutar as 'Toplam T.', " +
                                  " Satis_aciklama as 'Açıklama', Satis_tarih as 'Satis T.', " +
                                  " Musteri_ad +' '+ Musteri_soyad as 'Alıcı', Sehir_ad as 'Şehir', " +
                                  " Kullanici_Ad as 'Satıcı'  from satis " +
                                  " inner join musteri on satis.ref_musteri=musteri.Musteri_id " +
                                  " inner join kullanici on satis.ref_kullanici= kullanici.Kisi_id " +
                                  " inner join urun on satis.ref_urun=urun.Urun_id " +
                                  " inner join sehir on sehir.Sehir_id = musteri.Musteri_sehir " +
                                  " inner join kategori on urun.ref_katagori=kategori.Kategori_id";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                sell_grid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Liste Yüklenirken HATA !" + ex);
            }
        }
        private void addSeal(int userId, int piece, string date, string explanation, int customer, int productId, int sum)
        {
            try
            {
                if (userId != 0)
                {
                    string sql_text = "insert into satis values('" + piece + "', " +
                                      " '" + sum + "','" + date + "','" + explanation + "', " +
                                      " '" + customer + "','" + productId + "', " +
                                      " '" + userId + "')";
                    SqlConnection con = new SqlConnection(Form1.baglanti);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                    MessageBox.Show("Satış Başarılı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Sırasında HATA !" + ex);
            }
            finally
            {
                getSealList();
            }
        }
        private void deleteSales(int id)
        {
            try
            {
                if (id != 0)
                {
                    DialogResult ms = new DialogResult();
                    ms = MessageBox.Show("Silmek İstediğinize Eminmisinz ? ", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (ms == DialogResult.Yes)
                    {
                        string sql_text = "delete from satis where Satis_id=" + id;
                        SqlConnection con = new SqlConnection(Form1.baglanti);
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sql_text, con);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Silme İşlemi Başarılı");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme Sırasında HATA !" + ex);
            }
            finally
            {
                getSealList();
            }
        }
        //----- ÜRÜN LİSTELEME / ARAMA
        private void getProductList()
        {
            try
            {
                string sql_text = "select Urun_id as 'No', Urun_ad as 'Ürün Ad', " +
                                   " Urun_aciklama as 'Ürün Açıklama', Urun_fiyat as 'Ürün Fiyat', " +
                                   " Kategori_adi as 'Kategori' " +
                                   " from urun" +
                                   " inner join kategori on urun.ref_katagori = kategori.Kategori_id ";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                product_grid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Listelemede HATA!" + ex);
            }
        }
        private void productSearch(string data)
        {
            try
            {
                string sql_text = "select Urun_id as 'Ürün No', Urun_ad as 'Ürün Ad', " +
                               " Urun_aciklama as 'Ürün Açıklama', Urun_fiyat as 'Ürün Fiyat', " +
                               " Kategori_adi as 'Kategori' " +
                               " from urun" +
                               " inner join kategori on urun.ref_katagori = kategori.Kategori_id " +
                               " where Urun_fiyat like '%" + data + "%' or Kategori_adi like '%" + data + "%' "+
                               " or Urun_ad like '%" + data + "%' or Urun_aciklama like '%" + data + "%' ";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                product_grid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Listelemede HATA!" + ex);
            }
        }
        //----- PANELLERİN ARKA PPLAN RENGİ
        private void panelBg()
        {
            pnl_grid.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_product_grid.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_top_userlist.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_sell_content.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_product_head.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_sales_head.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_sell_content.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_cus_head.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_custom.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        //----- TEXTBOXLARITEMİXLEME
        private void textClear()
        {
            txt_pro_piece.Clear();
            ric_sael.Clear();
            txt_pro_piece.Focus();
        }
        private void sales_Transactions_Load(object sender, EventArgs e)
        {
            getUser(loginUserName, loginUserPass);
            panelBg();
            salesPoerson();
            getSealList();
            getCustomerList();
            getProductList();
        }
        private void btn_sales_Click(object sender, EventArgs e)
        {
            string explanation, date;
            int customer;
            productId = Convert.ToInt32(product_grid.CurrentRow.Cells["No"].Value);
            productMuch = Convert.ToInt32(product_grid.CurrentRow.Cells["Ürün Fiyat"].Value);
            piece = Convert.ToInt32(txt_pro_piece.Text);
            sum = piece * productMuch;
            explanation = ric_sael.Text;
            date = dateSeal.Text;
            customer = Convert.ToInt32(cus_grid.CurrentRow.Cells["No"].Value);
            addSeal(userId, piece, date, explanation, customer, productId, sum);
            textClear();
        }

        private void txt_sale_seach_TextChanged(object sender, EventArgs e)
        {
            if (txt_sale_seach.Text == "" || txt_sale_seach.Text != "")
            {
                string data = txt_sale_seach.Text;
                sealSearch(data);
            }
        }

        private void txt_pro_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_pro_search.Text == "" || txt_pro_search.Text != "")
            {
                string data = txt_pro_search.Text;
                productSearch(data);
            }
        }

        private void sİlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(sell_grid.CurrentRow.Cells["No"].Value);
            deleteSales(id);
        }

        private void txt_cus_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_cus_search.Text !="" || txt_cus_search.Text =="")
            {
                string data = txt_cus_search.Text;
                customerSearch(data);
            }
        }
    }
}

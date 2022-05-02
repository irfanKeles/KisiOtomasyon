using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KisiOtomasyon
{
    public partial class product_Update : Form
    {
        public product_Update()
        {
            InitializeComponent();
        }
        //----- ÜRÜB İD SININ ALINMASI / KATEGORİ DEĞERİNİN ALINMASI
        int getProductId = product_Registration.productId;
        string getProCateName = product_Registration.proCatagoryName;
        //----- AKTEGORİNİN LİSTELENMESİ
        private void getCategory()
        {
            try
            {
                if (getProCateName != "")
                {
                    string sql_text = "select * from kategori";
                    SqlConnection connect = new SqlConnection(Form1.baglanti);
                    connect.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, connect);
                    cmd.CommandType = CommandType.Text;
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = cmd;
                    DataSet ds = new DataSet();
                    da.Fill(ds);
                    cbb_cate.DataSource = ds.Tables[0];
                    cbb_cate.DisplayMember = "Kategori_adi";
                    cbb_cate.ValueMember = "Kategori_id";
                    //----------------------------------------------
                    string tetx = "Select Kategori_id from kategori where Kategori_adi='" + getProCateName + "'";
                    SqlCommand cmds = new SqlCommand(tetx, connect);
                    cmds.CommandType = CommandType.Text;
                    SqlDataReader dr = cmds.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows == true)
                    {
                        cbb_cate.SelectedValue = dr["Kategori_id"];
                    }
                    connect.Close();
                }
                else
                {
                    MessageBox.Show("Kategori Numarası Alınamadı");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategoriler Yüklenirken HATA !" + ex);
            }
        }
        //----- ÜRÜNÜN İD YE GÖRE TEXBOXLARA AKTARILMASI VE GÜNCELLEME
        private void getProduct(int id)
        {
            try
            {
                if (id != 0)
                {
                    string sql_text = "select * from urun where Urun_id=" + id;
                    SqlConnection con = new SqlConnection(Form1.baglanti);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows == true)
                    {
                        lbl_product_title_name.Text = dr["Urun_ad"].ToString();
                        txt_pro_name.Text = dr["Urun_ad"].ToString();
                        txt_sell.Text = dr["Urun_fiyat"].ToString();
                        ric_explanation.Text = dr["urun_aciklama"].ToString();
                    }
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Ürün No Alınamadı !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Yüklenirken HATA !" + ex);
            }
        }
        private void updateProduct(int id, string name, string explanation, int money, int cate)
        {
            try
            {
                string sql_text = "update urun set Urun_ad='" + name + "', " +
                                   " Urun_aciklama='" + explanation + "',Urun_fiyat='" + money + "', " +
                                   " ref_katagori='" + cate + "'" +
                                   " where Urun_id=" + id;
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Güncelleme Tamamlandı ");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ürün Güncelleme Sırasında HATA !" + ex);
            }
        }
        //----- PANEL ARKAPLAN RENHİ
        private void panelBg()
        {
            this.pnl_user_regis.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.pnl_usr_top_update.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void product_Update_Load(object sender, EventArgs e)
        {
            panelBg();
            getProduct(getProductId);
            getCategory();
        }
        private void btn_prduct_update_Click(object sender, EventArgs e)
        {
            if (getProductId != 0)
            {
                string name, explanation;
                int money, cate;
                name = txt_pro_name.Text;
                explanation = ric_explanation.Text;
                money = Convert.ToInt32(txt_sell.Text);
                cate = Convert.ToInt32(cbb_cate.SelectedValue);
                updateProduct(getProductId, name, explanation, money, cate);
            }
        }
    }
}

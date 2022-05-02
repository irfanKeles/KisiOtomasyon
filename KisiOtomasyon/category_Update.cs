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
    public partial class category_Update : Form
    {
        public category_Update()
        {
            InitializeComponent();
        }
        //----- Kategori id si alındı 
        int getCateId = category_Registration.cateId;
        //----- Kategori id ye göre Kategri adı alınıp title ve txt ölümüne yazdırıldı
        private void getCategoriyData(int id)
        {
            try
            {
                if (id != 0)
                {
                    string sql_text = "select Kategori_adi from kategori where Kategori_id=" + id;
                    SqlConnection con = new SqlConnection(Form1.baglanti);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows == true)
                    {
                        lbl_titlr_cate_name.Text = dr["Kategori_adi"].ToString();
                        txt_category_update.Text = dr["Kategori_adi"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kategori yüklenirken HATA ! " + ex);
            }
        }
        //----- KATEGORİ GÜNCELLEME İŞLEMİ
        private void categoriyUpdate(int id, string name)
        {
            try
            {
                string sql_text = "update kategori set Kategori_adi='" + name + "' where Kategori_id=" + id;
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Güncelleme işlemi başarılı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında HATA!" + ex);
            }
        }
        //----- PANEL ARKAPLAN RENGİ
        private void panelBg()
        {
            pnl_cate_update.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_usr_top_update.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void category_Update_Load(object sender, EventArgs e)
        {
            panelBg();
            getCategoriyData(getCateId);
        }
        private void btn_cate_update_Click(object sender, EventArgs e)
        {
            if (txt_category_update.Text != "" && getCateId != 0)
            {
                string name = txt_category_update.Text;
                categoriyUpdate(getCateId,name);
            }
        }
    }
}

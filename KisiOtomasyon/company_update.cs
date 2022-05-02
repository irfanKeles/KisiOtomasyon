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
    public partial class company_update : Form
    {
        public company_update()
        {
            InitializeComponent();
        }
        //----- firma id si alındı
        int companyId = company_Registration.companyID;
        string city = company_Registration.cityName;
        //----- ŞEHİRLER COMBOBOX A YÜKLENDİ
        private void getCityList()
        {
            try
            {
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                string sql_text = "select * from sehir";
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cbb_city.DataSource = ds.Tables[0];
                cbb_city.DisplayMember = "Sehir_ad";
                cbb_city.ValueMember = "Sehir_id";
                //-----------------------------------------------------------------------
                string sql_tetx = "Select Sehir_id from sehir where Sehir_ad='"+ city + "'";
                SqlCommand cmds = new SqlCommand(sql_tetx, con);
                cmds.CommandType = CommandType.Text;
                SqlDataReader dr = cmds.ExecuteReader();
                dr.Read();
                if (dr.HasRows == true)
                {
                    cbb_city.SelectedValue = dr["Sehir_id"];
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şehirler Yüklenirken HATA !" + ex);
            }
        }
        //----- FİRMA VERİLERİ ÇEKİLDİ / DÜNCELLENDİ
        private void getCompany(int id)
        {
            try
            {
                if (id != 0)
                {
                    string sql_text = "select * from firma where firma_id=" + id;
                    SqlConnection con = new SqlConnection(Form1.baglanti);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        lbl_com_name.Text = dr["firma_ad"].ToString();
                        txt_company_name.Text = dr["firma_ad"].ToString();
                        txt_company_mail.Text = dr["firma_mail"].ToString();
                        txt_company_tel.Text = dr["firma_tel"].ToString();
                        ric_company_adress.Text = dr["firma_adres"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler Yüklenirken HATA! " + ex);
            }
        }
        private void updateCompany(int id, string name, string mail, string phone, string adress, int city)
        {
            try
            {
                string sql_text = "update firma set firma_ad='" + name + "', " +
                                  " firma_mail='" + mail + "',firma_tel='" + phone + "', " +
                                  " firma_adres='" + adress + "',ref_sehir='" + city + "' " +
                                  "  where firma_id=" + id;
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Güncelleme İşlemi Tamamlandı");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kayıt Güncellenirken HATA ! " + ex);
            }
        }
        //----- PANEL ARKA PLAN REKLERİ
        private void panelBg()
        {
            pnl_cus_regis.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_top_userlist.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void company_update_Load(object sender, EventArgs e)
        {
            getCompany(companyId);
            panelBg();
            getCityList();
        }

        private void btn_company_update_Click(object sender, EventArgs e)
        {
            string name, mail, phone, adress;
            int city;
            name = txt_company_name.Text;
            mail = txt_company_mail.Text;
            phone = txt_company_tel.Text;
            adress = ric_company_adress.Text;
            city = Convert.ToInt32(cbb_city.SelectedValue);
            updateCompany(companyId, name, mail, phone, adress, city);
        }
    }
}

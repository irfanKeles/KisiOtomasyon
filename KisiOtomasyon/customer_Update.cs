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
    public partial class customer_Update : Form
    {
        public customer_Update()
        {
            InitializeComponent();
        }
        //----- müşteri id si alındı 
        int getCustomerId = customer_Registrartion.customerId;
        string companyName = customer_Registrartion.comapnyName;
        string cityName = customer_Registrartion.customerCity;
        //----- ŞEHİR / FİRMA LİSTESİ COMBOBOX A LSİTELENDİ
        private void getity()
        {
            try
            {
                string sql_text = "select * from sehir";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cbb_city.DataSource = ds.Tables[0];
                cbb_city.DisplayMember = "Sehir_ad";
                cbb_city.ValueMember = "Sehir_id";
                //--------------------------------------------------------------
                string tetx = "Select Sehir_id from sehir where Sehir_ad='" + cityName + "'";
                SqlCommand cmds = new SqlCommand(tetx, con);
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
                MessageBox.Show("Sehirler Yüklenirken HATA !" + ex);
            }
        }
        private void getCompany()
        {
            try
            {
                string sql_text = "select * from firma";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataSet ds = new DataSet();
                da.Fill(ds);
                cbb_company.DataSource = ds.Tables[0];
                cbb_company.DisplayMember = "firma_ad";
                cbb_company.ValueMember = "firma_id";
                //----------------------------------------------------------
                //--------------------------------------------------------------
                string tetx = "Select firma_id from firma where firma_ad='" + companyName + "'";
                SqlCommand cmds = new SqlCommand(tetx, con);
                cmds.CommandType = CommandType.Text;
                SqlDataReader dr = cmds.ExecuteReader();
                dr.Read();
                if (dr.HasRows == true)
                {
                    cbb_company.SelectedValue = dr["firma_id"];
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şehirler Yüklenirken HATA !" + ex);
            }
        }
        //----- MÜŞTERİ VERİLERİ ÇEKİLDİ / DÜNCELLENDİ
        private void getCustomer(int id)
        {
            try
            {
                if (id != 0)
                {
                    string sql_text = "select * from musteri where Musteri_id=" + id;
                    SqlConnection con = new SqlConnection(Form1.baglanti);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        lbl_head_cus_name.Text = Convert.ToString(dr["Musteri_ad"] + " " + dr["Musteri_soyad"]);
                        txt_cus_name.Text = dr["Musteri_ad"].ToString();
                        txt_cus_surname.Text = dr["Musteri_soyad"].ToString();
                        txt_cus_phone.Text = dr["Musteri_tel"].ToString();
                        txt_cus_tc.Text = dr["Musteri_tc"].ToString();
                        ric_cus_adress.Text = dr["Musteri_adres"].ToString();
                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Veriler Yüklenirken HATA! " + ex);
            }
        }
        private void updateCustomer(int id, string name, string surname, string phone, string adress, string tc, int city, int company)
        {
            try
            {
                string sql_text = "update musteri set Musteri_ad='" + name + "', " +
                                  " Musteri_soyad='" + surname + "',Musteri_tel='" + phone + "', " +
                                  " Musteri_adres='" + adress + "',Musteri_tc='" + tc + "', " +
                                  " Musteri_sehir='" + city + "', ref_firma='" + company + "' where Musteri_id=" + id;
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
        //----- PANEL ARKA PLAN RENKLERİ
        private void panelBg()
        {
            this.pnl_top_userlist.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.pnl_cus_context.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void customer_Update_Load(object sender, EventArgs e)
        {
            panelBg();
            getity();
            getCompany();
            getCustomer(getCustomerId);
        }
        private void btn_customer_update_Click(object sender, EventArgs e)
        {
            string name, surname, phone, tc, adress;
            int city, company;
            name = txt_cus_name.Text;
            surname = txt_cus_surname.Text;
            phone = txt_cus_phone.Text;
            tc = txt_cus_tc.Text;
            adress = ric_cus_adress.Text;
            city = Convert.ToInt32(cbb_city.SelectedValue);
            company = Convert.ToInt32(cbb_company.SelectedValue);
            updateCustomer(getCustomerId, name, surname, phone, adress, tc, city, company);
        }
    }
}

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
    public partial class customer_Registrartion : Form
    {
        public customer_Registrartion()
        {
            InitializeComponent();
        }
        //----- Müşteri id ve Şehir id alındı
        public static int customerId = 0;
        public static string customerCity="";
        public static string comapnyName = "";
        //----- TEXBOXLARIN TEMİZLEME İŞLEMİ
        private void clear()
        {
            txt_cus_tc.Text = "";
            txt_cus_name.Text = "";
            txt_cus_surname.Text = "";
            txt_cus_phone.Text = "";
            ric_cus_adress.Text = "";
        }
        //----- ŞEHİRLER / FİRMALAR COMBOBOX İLE LİSTELENDİ
        private void getCity()
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
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şehirler Yüklenirken HATA !" + ex);
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
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Şehirler Yüklenirken HATA !" + ex);
            }
        }
        //----- MÜŞTERİ İŞLEMLERİ / ARAMA / LİSTELEME / EKLEME / SİLME
        private void search(string data)
        {
            try
            {
                string sql_text = "select Musteri_id as 'No', Musteri_ad as 'İsim', " +
                             " Musteri_Soyad as 'Soyisim', Musteri_tel as 'Tel No', Musteri_tc as 'Tc No', Musteri_adres as 'Adres',firma_ad as 'Firma',  Sehir_ad as 'Şehir' " +
                             "  from musteri " +
                             " inner join sehir on musteri.Musteri_sehir=sehir.Sehir_id " +
                             " inner join firma on musteri.ref_firma=firma.firma_id " +
                             " where Musteri_ad like '%" + data + "%' or  Musteri_Soyad like '%" + data + "%' " +
                             " or Musteri_tel like '%" + data + "%' or  Musteri_tc like '%" + data + "%' " +
                             " or Musteri_adres like '%" + data + "%' or  firma_ad like '%" + data + "%' or  Sehir_ad like '%" + data + "%' ";
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
        private void cusList()
        {
            try
            {
                string sql_text = "select Musteri_id as 'No', Musteri_ad as 'İsim', " +
                                  " Musteri_Soyad as 'Soyisim', Musteri_tel as 'Tel No', Musteri_tc as 'Tc No', Musteri_adres as 'Adres',firma_ad as 'Firma',Sehir_ad as 'Şehir' " +
                                  "  from musteri" +
                                  " inner join sehir on musteri.Musteri_sehir=sehir.Sehir_id " +
                                  " inner join firma on musteri.ref_firma = firma.firma_id";
                // " left join sehir on musteri.Musteri_sehir=sehir.Sehir_id";
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
                MessageBox.Show("Listeme Sırasında HATA !" + ex);
            }
        }
        private void cusAdd(string name, string surname, string phone, string adress, string tc, int city,int company)
        {
            try
            {
                string sql_text = "insert into musteri values('" + name + "','" + surname + "'," +
                                   "'" + phone + "','" + adress + "','" + tc + "','" + city + "','"+company+"')";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                clear();
                MessageBox.Show("Müşteri Eklendi");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Sırasında HATA ! " + ex);
            }
            finally
            {
                cusList();
            }
        }
        private void cusDelete(int id)
        {
            try
            {
                if (id != 0)
                {
                    DialogResult ms = new DialogResult();
                    ms = MessageBox.Show("Silmek Üzeresiniz ?", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (ms == DialogResult.Yes)
                    {
                        string sql_text = "delete from musteri where Musteri_id=" + id;
                        SqlConnection con = new SqlConnection(Form1.baglanti);
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sql_text, con);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Silme İşlemi Sırasında HATA!" + ex);
            }
            finally
            {
                cusList();
            }
        }
        //----- PANEL ARKAPLAN RENKLERİ
        private void panelBg()
        {
            this.pnl_cus_regis.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.pnl_top_customerList.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void customer_Registrartion_Load(object sender, EventArgs e)
        {
            getCompany();
            panelBg();
            cusList();
            getCity();
            txt_cus_name.Focus();

        }
        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "" || txt_search.Text == "")
            {
                string data = txt_search.Text;
                search(data);
            }
        }
        private void btn_customer_add_Click(object sender, EventArgs e)
        {
            if (txt_cus_name.Text != "" && txt_cus_surname.Text != "" &&
                          txt_cus_phone.Text != "" && txt_cus_tc.Text != "")
            {
                string name, surname, phone, tc, adress;
                int city,company;
                name = txt_cus_name.Text;
                surname = txt_cus_surname.Text;
                phone = txt_cus_phone.Text;
                tc = txt_cus_tc.Text;
                adress = ric_cus_adress.Text;
                city = Convert.ToInt32(cbb_city.SelectedValue);
                company = Convert.ToInt32(cbb_company.SelectedValue);
                cusAdd(name, surname, phone, adress, tc, city,company);
            }
            else
            {
                MessageBox.Show("Lütfen ilgili Alanları Doldurunuz");
            }
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(cus_grid.CurrentRow.Cells["No"].Value);
            cusDelete(id);
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customerId = Convert.ToInt32(cus_grid.CurrentRow.Cells["No"].Value);
            customerCity = Convert.ToString(cus_grid.CurrentRow.Cells["Şehir"].Value);
            comapnyName = Convert.ToString(cus_grid.CurrentRow.Cells["Firma"].Value);
            customer_Update cusUp = new customer_Update();
            cusUp.ShowDialog();
        }
        private void customer_Registrartion_Activated(object sender, EventArgs e)
        {
            cusList();
        }
    }
}

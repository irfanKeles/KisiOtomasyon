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
    public partial class company_Registration : Form
    {
        public company_Registration()
        {
            InitializeComponent();
        }
        public static int companyID = 0;
        public static string cityName = "";
        //----- ŞEHİRLER COMBOBOX A YÜKLENDİ
        private void getCityList()
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
        //----- FİRMA / LİSTELEME / EKLEME / SİLME / ARAMA
        private void companyList()
        {
            try
            {
                string sql_text = "select firma_id as 'Firma No', firma_Ad as'F. İsim', firma_mail as 'F. Mail', " +
                                  " firma_tel as 'F. Tel', firma_adres as 'F. Adres', Sehir_ad as 'Şehir' " +
                                  " from firma inner join sehir on sehir.Sehir_id = firma.ref_sehir ";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                company_grid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeme Sırasında HATA !" + ex);
            }
        }
        private void companyAdd(string name, string mail, string phone, string adres, int city)
        {
            try
            {
                string sql_text = "insert into firma values('" + name + "','" + mail + "','" + phone + "','" + adres + "','" + city + "')";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Kayıt Ekleme Başarılı");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ekleme Sırasında hATA !" + ex);
            }
            finally
            {
                companyList();
            }
        }
        private void companyDelete(int id)
        {
            try
            {
                if (id != 0)
                {
                    DialogResult ms = new DialogResult();
                    ms = MessageBox.Show("Silmek İstediğinize eminmisiniz ?", "Silme İşlemi", MessageBoxButtons.YesNo);
                    if (ms == DialogResult.Yes)
                    {
                        string sql_text = "delete from firma where firma_id=" + id;
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
                MessageBox.Show("Silme işleminde HATA !" + ex);
            }
            finally
            {
                companyList();
            }
        }
        private void search(string data)
        {
            try
            {
                string sql_text = "select firma_id as 'Firma No', firma_Ad as'F. İsiç', firma_mail as 'F. Mial', " +
                                  " firma_tel as 'F. Tel', firma_adres as 'F. Adres', Sehir_ad as 'Şehir' " +
                                  " from firma " +
                                  " inner join sehir on sehir.Sehir_id = firma.ref_sehir " +
                                  " where firma_ad like  '%" + data + "%' or  firma_mail like '%" + data + "%' " +
                                  " or firma_tel like  '%" + data + "%' or  firma_adres like '%" + data + "%' " +
                                  " or Sehir_ad like  '%" + data + "%' ";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                company_grid.DataSource = dt;
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Arama Sırasında HATA !" + ex);
            }
        }
        //----- PANEL ARKAPLAN RENKGİ
        private void panelBg()
        {
            pnl_cus_regis.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_grid.BackColor = Color.FromArgb(100, 0, 0, 0);
            pnl_top_customerList.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        //----- TEXTBOX TEMİXLEME
        private void textClear()
        {
            txt_company_mail.Clear();
            txt_company_name.Clear();
            txt_company_tel.Clear();
            ric_company_adress.Clear();
        }
        private void company_Registration_Load(object sender, EventArgs e)
        {
            panelBg();
            companyList();
            getCityList();
        }

        private void btn_company_add_Click(object sender, EventArgs e)
        {
            cbb_city.Focus();
            if (txt_company_mail.Text != "" && txt_company_name.Text != "" &&
                txt_company_tel.Text != "")
            {
                string name, mail, phone, adres;
                name = txt_company_name.Text;
                mail = txt_company_mail.Text;
                phone = txt_company_tel.Text;
                adres = ric_company_adress.Text;
                int city = Convert.ToInt32(cbb_city.SelectedValue);
                companyAdd(name, mail, phone, adres, city);
                textClear();
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
            }
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            if (txt_search.Text != "" || txt_search.Text == "")
            {
                string data = txt_search.Text;
                search(data);
            }
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int comId = Convert.ToInt32(company_grid.CurrentRow.Cells["Firma No"].Value);
            companyDelete(comId);
        }
        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            companyID = Convert.ToInt32(company_grid.CurrentRow.Cells["Firma No"].Value);
            cityName = company_grid.CurrentRow.Cells["Şehir"].Value.ToString();
            company_update cu = new company_update();
            cu.Show();
        }
        private void company_Registration_Activated(object sender, EventArgs e)
        {
            companyList();
        }
    }
}

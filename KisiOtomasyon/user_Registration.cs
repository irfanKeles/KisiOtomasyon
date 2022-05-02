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
    public partial class user_Registration : Form
    {
        public user_Registration()
        {
            InitializeComponent();
        }
        //----- KULLANICI İD Sİ ALINDI
        public static int userId = 0;
        //----- KULLANICI İŞLEMLERİ / LİSTELEME / SİLME / ARAMA / EKLEME
        private void userList()
        {

            try
            {
                SqlConnection con = new SqlConnection(Form1.baglanti);
                string sql = "select Kisi_id as 'Kul. No', Kullanici_Ad as 'Kul. Adı', " +
                             " Kullanici_Sifre as 'Kul. Şifre', " +
                             " case Kullanici_Durum when 0 then 'Pasif' else 'Aktif' end as 'Kul. Durum', " +
                             " case Kullanici_Admin when 0 then 'Kullanıcı' when 1 then 'Yönetici' end as 'Kul. Yetki'" +
                             " from kullanici";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter(sql, con);
                DataSet ds = new DataSet();
                da.Fill(ds);
                userLİstGrid.DataSource = ds.Tables[0];
                con.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show("Listelinirken Sorun Oluştu !" + ex);
            }
        }
        private void delete(int id)
        {
            try
            {
                if (id != 0)
                {
                    DialogResult msj = new DialogResult();
                    msj = MessageBox.Show("Silmek İstediğinize Eminmisiniz ?", "Silme İşlemi.", MessageBoxButtons.YesNo);
                    if (msj == DialogResult.Yes)
                    {
                        string sql_text = "delete from kullanici where Kisi_id=" + id;
                        SqlConnection con = new SqlConnection(Form1.baglanti);
                        con.Open();
                        SqlCommand cmd = new SqlCommand(sql_text, con);
                        cmd.ExecuteNonQuery();
                        cmd.Dispose();
                        con.Close();
                        MessageBox.Show("Kullanıcı SİLİNDİ");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Silerken HATA !" + ex);
            }
            finally
            {
                userList();
            }
        }
        private void search(string data)
        {
            try
            {
                string sql_text = "select Kisi_id as 'Kul. No', Kullanici_Ad as 'Kul. Adı', " +
                             " Kullanici_Sifre as 'Kul. Şifre', " +
                             " case Kullanici_Durum when 0 then 'Pasif' else 'Aktif' end as 'Kul. Durum', " +
                             " case Kullanici_Admin when 0 then 'Kullanıcı' when 1 then 'Yönetici' end as 'Kul. Yetki'" +
                             " from kullanici where Kullanici_Ad like '%" + data + "%'";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sql_text, con);
                da.Fill(dt);
                userLİstGrid.DataSource = dt;
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Listeleme sırasında HATA!" + ex);
            }
        }
        private void userSave(string username, string password, bool status, bool admin)
        {
            try
            {
                SqlConnection con = new SqlConnection(Form1.baglanti);
                string data_stirng = "Insert Into kullanici values('" + username + "','" + password + "','" + status + "','" + admin + "')";
                con.Open();
                SqlCommand cmd = new SqlCommand(data_stirng, con);
                cmd.ExecuteNonQuery();
                con.Dispose();
                con.Close();
                MessageBox.Show("Kullanıcı Kayıtı Başarılı");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Ekleme Sırasında HATA!" + ex.Message);
            }
            finally
            {
                userList();
            }
        }
        //----- KULLANICI ADMIN / YÖNETİCİ - KULLANICI DURUMUNUN BELİRLENMESİ
        private void userAdminYesNo(int id, string admin, bool value)
        {
            try
            {
                SqlConnection con = new SqlConnection(Form1.baglanti);
                if (admin == "Yönetici" && value == false)
                {
                    string sql_text = "update kullanici set Kullanici_Admin=0 where Kisi_id=" + id;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (admin == "Kullanıcı" && value == true)
                {
                    string sql_text = "update kullanici set Kullanici_Admin=1 where Kisi_id=" + id;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Yetkisi Güncellenirken HATA !" + ex);
            }
            finally
            {
                userList();
            }
        }
        //----- KULLANICI STATÜ /  AKTİF - PASİF DURUMUNUN BELİRLENMESİ
        private void userStatusYesNo(int id, string status, bool value)
        {
            try
            {
                SqlConnection con = new SqlConnection(Form1.baglanti);
                if (status == "Aktif" && value == false)
                {
                    string sql_text = "Update kullanici set Kullanici_Durum=0 where Kisi_id=" + id;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
                if (status == "Pasif" && value == true)
                {
                    string sql_text = "Update kullanici set Kullanici_Durum=1 where Kisi_id=" + id;
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_text, con);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı Durumu Değişikliğinde HATA !" + ex);
            }
            finally
            {
                userList();
            }
        }
        //----- TEXTXBOXLARIN TEMİXLENME İŞLEMİ
        private void clears()
        {
            txt_pw_regis.Text = "";
            txt_uN_regis.Text = "";
        }
        //----- PANEL ARKAPLAN RENKLERİ
        private void panelBg()
        {
            this.pnl_user_regis.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.pnl_top_userlist.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void btn_user_registration_Click(object sender, EventArgs e)
        {
            if (txt_pw_regis.Text != "" && txt_uN_regis.Text != "")
            {
                string username, password;
                bool status, admin;
                username = txt_uN_regis.Text.Trim().ToString();
                password = txt_pw_regis.Text.Trim().ToString();
                if (u_statu_ok.Checked == true)
                    status = true;
                else
                    status = false;
                if (u_admin_ok.Checked == true)
                    admin = true;
                else
                    admin = false;
                userSave(username, password, status, admin);
            }
            else
            {
                MessageBox.Show("Lütfen İlgili Alanları Doldurunuz !");
            }
            clears();
            txt_uN_regis.Focus();
        }
        private void user_Registration_Load(object sender, EventArgs e)
        {
            panelBg();
            txt_uN_regis.Focus();
            u_admin_no.Select();
            u_statu_ok.Select();
            userList();
        }
        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userLİstGrid.CurrentRow.Cells["Kul. No"].Value);
            delete(id);
        }
        //----- ADMİN VE YÖNETİCİ İŞLEMLERİ
        bool adminValue = false;
        private void yöneticiToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userLİstGrid.CurrentRow.Cells["Kul. No"].Value);
            string admin = userLİstGrid.CurrentRow.Cells["Kul. Yetki"].Value.ToString();
            if (adminValue == false)
            {
                adminValue = true;
                userAdminYesNo(id, admin, adminValue);
            }
        }
        private void kullanıcıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userLİstGrid.CurrentRow.Cells["Kul. No"].Value);
            string admin = userLİstGrid.CurrentRow.Cells["Kul. Yetki"].Value.ToString();
            adminValue = false;
            userAdminYesNo(id, admin, adminValue);
        }
        //----- AKTİF PASİF İŞLEMLERİ
        bool statuValue = false;
        private void aktifToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userLİstGrid.CurrentRow.Cells["Kul. No"].Value);
            string status = userLİstGrid.CurrentRow.Cells["Kul. Durum"].Value.ToString();
            if (statuValue == false)
            {
                statuValue = true;
                userStatusYesNo(id, status, statuValue);
            }
        }
        private void pasifToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(userLİstGrid.CurrentRow.Cells["Kul. No"].Value);
            string status = userLİstGrid.CurrentRow.Cells["Kul. Durum"].Value.ToString();
            statuValue = false;
            userStatusYesNo(id, status, statuValue);
        }
        private void txt_searxh_TextChanged(object sender, EventArgs e)
        {
            if (txt_searxh.Text != "" || txt_searxh.Text == "")
            {
                string data = txt_searxh.Text;
                search(data);
            }
        }
        private void yöneticiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userId = Convert.ToInt32(userLİstGrid.CurrentRow.Cells["Kul. No"].Value);
            user_Update ud = new user_Update();
            ud.Show();
        }
        private void user_Registration_Activated(object sender, EventArgs e)
        {
            userList();
        }
    }
}

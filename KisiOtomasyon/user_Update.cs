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
    public partial class user_Update : Form
    {
        public user_Update()
        {
            InitializeComponent();
        }
        //----- KULLANICI İD Sİ ALINDI
        int getUserId = user_Registration.userId;
        //----- KAULLANICI BİLGİLERİ TEXTLERE ÇEKİLDİ / GÜNCELLENDİ
        private void userGetData(int id)
        {
            try
            {
                if (id != 0)
                {
                    string sql_tetx = "Select * from kullanici where Kisi_id=" + id;
                    SqlConnection con = new SqlConnection(Form1.baglanti);
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql_tetx, con);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows == true)
                    {
                        txt_uN_regis.Text = dr["Kullanici_Ad"].ToString(); ;
                        lbl_user_name.Text = dr["Kullanici_Ad"].ToString();
                        txt_pw_regis.Text = dr["Kullanici_Sifre"].ToString();
                        if (Convert.ToBoolean(dr["Kullanici_Durum"]) == true)
                            u_statu_ok.Checked = true;
                        else
                            u_statu_no.Checked = true;

                        if (Convert.ToBoolean(dr["Kullanici_Admin"]) == true)
                            u_admin_ok.Checked = true;
                        else
                            u_admin_no.Checked = true;

                    }
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Yüklenirken HATA!" + ex);
            }

        }
        private void userUpdate(int id, string username, string password, bool status, bool admin)
        {
            try
            {
                string sql_text = "update kullanici set Kullanici_Ad='" + username + "',Kullanici_Sifre='" + password + "', " +
                                  " Kullanici_Durum='" + status + "', Kullanici_Admin='" + admin + "' where Kisi_id=" + id;
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                con.Close();
                MessageBox.Show("Bilgiler Başarıyla güncellendi");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme sırasında HATA!" + ex);
            }
        }
        //----- PANEL ARKA PLANRENKLERİ 
        private void paneBg()
        {
            this.pnl_user_regis.BackColor = Color.FromArgb(100, 0, 0, 0);
            this.pnl_usr_top_update.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
        private void user_Update_Load(object sender, EventArgs e)
        {
            paneBg();
            userGetData(getUserId);
        }
        private void btn_user_update_Click(object sender, EventArgs e)
        {
            if (txt_uN_regis.Text != "" && txt_pw_regis.Text != "" && getUserId != 0)
            {
                string username, pasword;
                bool status, admin;
                username = txt_uN_regis.Text;
                pasword = txt_pw_regis.Text;
                if (u_statu_ok.Checked == true)
                    status = true;
                else
                    status = false;
                if (u_admin_ok.Checked == true)
                    admin = true;
                else
                    admin = false;
                userUpdate(getUserId, username, pasword, status, admin);
            }
        }
    }
}

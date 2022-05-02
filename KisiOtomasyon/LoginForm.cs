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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        //----- KULLANICI ADI VE ŞİFRESİ ALINDI
        public static string userLoginName = "";
        public static string userLoginPass = "";
        //----- TEXTXBOXLARIN TEMİZLENMESİ
        private void clear()
        {
            txt_userName.Clear();
            txt_userPass.Clear();
        }
        //----- GİRİŞ İŞLEMİNİN YAPILMASI
        private void login(string username , string password)
        {
            try
            {
                string sql_text = "select * from kullanici  where Kullanici_Ad='"+username+"' and Kullanici_Sifre='"+password+"'";
                SqlConnection con = new SqlConnection(Form1.baglanti);
                con.Open();
                SqlCommand cmd = new SqlCommand(sql_text, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    userLoginName = username;
                    userLoginPass = password;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre YALNIŞ !");
                    clear();
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Giriş Yaparken HATA !" + ex);
            }
        }
        //----- ÇIKIŞ HALİNDE PROENİN KAPATILMASI
        private void app_close()
        {
            Application.Exit();
        }
        //----- TEXTBOXLARIN İÇİNDEKİ YAZININ GELMESİ
        private void placeholder()
        {
            txt_userName.Text = "Kullanıcı Adı: ";
            txt_userPass.Text = "Şifre: ";
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            // PANEL ARKAPLAN RENGİ
            pnl_login.BackColor = Color.FromArgb(100, 0, 0, 0);
            placeholder();
            txt_userName.Focus();
        }
        private void btn_close_Click(object sender, EventArgs e)
        {
            app_close();
        }
        private void txt_userPass_Click(object sender, EventArgs e)
        {
            txt_userPass.Text = "";
            lbl_pass.Visible = true;
            if (txt_userName.Text == "")
            {
                txt_userName.Text = "Kullanıcı Adı:";
                lbl_userName.Visible = false;
            }
        }
        private void txt_userName_Click(object sender, EventArgs e)
        {
            txt_userName.Text = "";
            lbl_userName.Visible = true;
            if (txt_userPass.Text == "")
            {
                txt_userPass.Text = "Şifre";
                lbl_pass.Visible = false;
            }
        }
        private void btn_login_Click(object sender, EventArgs e)
        {
            string username, pass;
            if (txt_userName.Text != "" && txt_userPass.Text != "")
            {
                username = txt_userName.Text.Trim().ToString();
                pass = txt_userPass.Text.Trim().ToString();
                login(username,pass);
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre boş geçilemez");
            }
        }
    }
}

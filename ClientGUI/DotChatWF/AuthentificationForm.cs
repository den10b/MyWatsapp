using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DotChatWF
{
  public partial class AuthentificationForm : Form
  {
        public MainForm mForm;
        public class AuthData
        {
            public string login { get; set; }
            public string password { get; set; }
        }
        public AuthentificationForm()
    {
      InitializeComponent();
    }
        private void AuthentificationForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AuthData auth_data = new AuthData();
            string login = nameBox.Text;
            string pass = passBox.Text;
            auth_data.login = login;
            auth_data.password = pass;
            WebRequest req = WebRequest.Create("http://localhost:5000/api/reg");
                req.Method = "POST"; 
                string postData = JsonConvert.SerializeObject(auth_data);
                req.ContentType = "application/json";
                StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
                reqStream.Write(postData);
                reqStream.Close();
                HttpWebResponse resp = (HttpWebResponse)req.GetResponse();
                StreamReader sr = new StreamReader(resp.GetResponseStream(), Encoding.GetEncoding("utf-8"));
                string content = sr.ReadToEnd();
                sr.Close();
                int int_token = Convert.ToInt32(content, 10);
            if (int_token != -2) {
                MessageBox.Show("Такого логина не существует");
            }
            else if (int_token == -1)
            {
                MessageBox.Show("Неверный пароль к данному логину");
            }
            else { 
                mForm.int_token = int_token;
                    mForm.TextBox_username.Text = auth_data.login;
                    mForm.Show();
                    this.Visible = false;
                }
        }
        private void AuthentificationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
        private void AuthentificationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            mForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

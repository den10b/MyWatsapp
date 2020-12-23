using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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
            public int token { get; set; }
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
            string stream;
            string file = @"C:\Users\den10\source\repos\MyWatsapp\Server\Server\data_sessions.json";
            using (StreamReader sr = new StreamReader(file))
            {
                stream = sr.ReadToEnd();
            }
            var m = JsonExtensions.ToObject<Temperatures>(stream);
            int tst = 0;
            for (int i = 0; i != m.ListTokens.Count(); i++)
            {
                if (login == m.ListTokens[i].Login)
                {
                    if (pass == m.ListTokens[i].Password)
                    {
                        var token = m.ListTokens[i].Token;
                        tst = 1;
                        WebRequest req = WebRequest.Create("http://localhost:5000/api/Auth");
                        req.Method = "POST";
                        int token1 = Convert.ToInt32(token);
                        auth_data.token = token1;
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
                        mForm.int_token = int_token;
                        mForm.TextBox_username.Text = auth_data.login;
                        mForm.Show();
                        this.Visible = false;
                    }
                    else {
                        MessageBox.Show("Неверный пароль");
                        tst = 1;
                    }
                
                }
            }
           if (tst!=1) MessageBox.Show("Логин не зарегистрирован");
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
        public partial class Temperatures
        {
            [JsonProperty("list_tokens")]
            public ListToken[] ListTokens { get; set; }
        }
        public partial class ListToken
        {
            [JsonProperty("token")]
            public long Token { get; set; }
            [JsonProperty("login")]
            public string Login { get; set; }
            [JsonProperty("password")]
            public string Password { get; set; }
        }
    }
    public static class JsonExtensions
    {
        public static T ToObject<T>(this string jsonText)
        {
            return JsonConvert.DeserializeObject<T>(jsonText);
        }
    }

}

﻿using Newtonsoft.Json;
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

    public partial class MainForm : Form
    {
        
        // Глобальные переменные
        int lastMsgID = 0;
        AuthentificationForm AuthForm;
        RegistartionForm RegForm;
        public TextBox TextBox_username;
        public int int_token;
        public Message messages;



        public MainForm()
        {
            InitializeComponent();
        }

        private void updateLoop_Tick(object sender, EventArgs e)
        {
            Message msg = GetMessage(lastMsgID);
            if (msg != null) {
                listMessages.Items.Add($"[{msg.username}] {msg.text}");
                lastMsgID++;
            }
        }

        private void btnSend_Click(object sender, EventArgs e) {
            if (int_token == 0)
            {
               MessageBox.Show("Войдите или зарегистрируйтесь");
            }
            else 
            { 
                SendMessage(new Message() {  username = fieldUsername.Text,text = fieldMessage.Text, });
                fieldMessage.Clear();
            }
    }

        // Отправляет сообщение на сервер
        void SendMessage(Message msg)
        {
            WebRequest req = WebRequest.Create("http://localhost:5000/api/chat");
            req.Method = "POST";
            string postData = JsonConvert.SerializeObject(msg);
            req.ContentType = "application/json";
            StreamWriter reqStream = new StreamWriter(req.GetRequestStream());
            reqStream.Write(postData);
            reqStream.Close();
            req.GetResponse();
        }

        // Получает сообщение с сервера
        Message GetMessage(int id)
        {
            try
            {
                WebRequest req = WebRequest.Create($"http://localhost:5000/api/chat/{id}");
                WebResponse resp = req.GetResponse();
                string smsg = new StreamReader(resp.GetResponseStream()).ReadToEnd();

                if (smsg == "Not found") return null;
                return JsonConvert.DeserializeObject<Message>(smsg);
            } catch {
                return null;
            }
        }



    private void MainForm_Load(object sender, EventArgs e)
    {
            string Height1 = File.ReadLines("Config.Json").Skip(4).First();
            string Width1 = File.ReadLines("Config.Json").Skip(7).First();
            int W = Convert.ToInt32(Width1);
            int H = Convert.ToInt32(Height1);
            this.Size = new Size(W, H);
            int_token = 0;
      TextBox_username = fieldUsername;

        }
        private void btnAuth_Click(object sender, EventArgs e)
        {
            AuthForm = new AuthentificationForm();
            AuthForm.mForm = this;
            AuthForm.Show();
            this.Visible = false;
    }
        private void btnReg_Click(object sender, EventArgs e)
        {
            RegForm = new RegistartionForm();
            RegForm.mForm = this;
      RegForm.Show();
      this.Visible = false;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      Message msg = GetMessage(lastMsgID);
      if (msg != null)
      {
        listMessages.Items.Add($"[{msg.username}] {msg.text}");
        lastMsgID++;
      }

    }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    [Serializable]
    public class Message
    {
        public string username = "";
        public string text = "";
        public DateTime timestamp;
    }
}

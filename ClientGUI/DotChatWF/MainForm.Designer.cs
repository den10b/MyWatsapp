namespace DotChatWF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listMessages = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fieldUsername = new System.Windows.Forms.TextBox();
            this.fieldMessage = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.updateLoop = new System.Windows.Forms.Timer(this.components);
            this.btnAuth = new System.Windows.Forms.Button();
            this.btnReg = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // listMessages
            // 
            this.listMessages.Font = new System.Drawing.Font("Galatea-MediumItalic", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listMessages.FormattingEnabled = true;
            this.listMessages.ItemHeight = 14;
            this.listMessages.Location = new System.Drawing.Point(9, 10);
            this.listMessages.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listMessages.Name = "listMessages";
            this.listMessages.Size = new System.Drawing.Size(583, 270);
            this.listMessages.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Macho-SemiBoldItalic", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(119, 300);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Macho-SemiBoldItalic", 9.749999F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(89, 328);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Сообщение";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // fieldUsername
            // 
            this.fieldUsername.AutoCompleteCustomSource.AddRange(new string[] {
            "You are not logged in"});
            this.fieldUsername.Location = new System.Drawing.Point(168, 301);
            this.fieldUsername.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fieldUsername.Name = "fieldUsername";
            this.fieldUsername.ReadOnly = true;
            this.fieldUsername.Size = new System.Drawing.Size(267, 20);
            this.fieldUsername.TabIndex = 3;
            this.fieldUsername.Text = "You are not logged in";
            // 
            // fieldMessage
            // 
            this.fieldMessage.Location = new System.Drawing.Point(168, 328);
            this.fieldMessage.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fieldMessage.Multiline = true;
            this.fieldMessage.Name = "fieldMessage";
            this.fieldMessage.Size = new System.Drawing.Size(311, 63);
            this.fieldMessage.TabIndex = 4;
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.btnSend.BackgroundImage = global::DotChatWF.Properties.Resources._12;
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.Location = new System.Drawing.Point(503, 399);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(88, 80);
            this.btnSend.TabIndex = 5;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // updateLoop
            // 
            this.updateLoop.Interval = 1000;
            this.updateLoop.Tick += new System.EventHandler(this.updateLoop_Tick);
            // 
            // btnAuth
            // 
            this.btnAuth.Font = new System.Drawing.Font("ObelixPro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAuth.Location = new System.Drawing.Point(9, 399);
            this.btnAuth.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAuth.Name = "btnAuth";
            this.btnAuth.Size = new System.Drawing.Size(97, 38);
            this.btnAuth.TabIndex = 6;
            this.btnAuth.Text = "Войти";
            this.btnAuth.UseVisualStyleBackColor = true;
            this.btnAuth.Click += new System.EventHandler(this.btnAuth_Click);
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("ObelixPro", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReg.Location = new System.Drawing.Point(9, 441);
            this.btnReg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(239, 38);
            this.btnReg.TabIndex = 7;
            this.btnReg.Text = "Зарегистрироваться";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(602, 487);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.btnAuth);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.fieldMessage);
            this.Controls.Add(this.fieldUsername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listMessages);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "ВатсАпп";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox fieldUsername;
        private System.Windows.Forms.TextBox fieldMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Timer updateLoop;
    private System.Windows.Forms.Button btnAuth;
    private System.Windows.Forms.Button btnReg;
    private System.Windows.Forms.Timer timer1;
  }
}


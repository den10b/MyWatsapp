﻿namespace DotChatWF
{
  partial class RegistartionForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistartionForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TBPass2 = new System.Windows.Forms.TextBox();
            this.TBPass1 = new System.Windows.Forms.TextBox();
            this.fieldUserName = new System.Windows.Forms.TextBox();
            this.btnReg2serv = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Macho-SemiBoldItalic", 12F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(8, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 26);
            this.label3.TabIndex = 13;
            this.label3.Text = "Повторите пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Macho-SemiBoldItalic", 12F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(8, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 26);
            this.label2.TabIndex = 12;
            this.label2.Text = "Пароль:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Macho-SemiBoldItalic", 12F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(8, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 26);
            this.label1.TabIndex = 11;
            this.label1.Text = "Имя пользователя:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TBPass2
            // 
            this.TBPass2.Location = new System.Drawing.Point(8, 161);
            this.TBPass2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPass2.Name = "TBPass2";
            this.TBPass2.PasswordChar = '*';
            this.TBPass2.Size = new System.Drawing.Size(208, 20);
            this.TBPass2.TabIndex = 10;
            // 
            // TBPass1
            // 
            this.TBPass1.Location = new System.Drawing.Point(8, 98);
            this.TBPass1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TBPass1.Name = "TBPass1";
            this.TBPass1.PasswordChar = '*';
            this.TBPass1.Size = new System.Drawing.Size(208, 20);
            this.TBPass1.TabIndex = 9;
            // 
            // fieldUserName
            // 
            this.fieldUserName.Location = new System.Drawing.Point(8, 33);
            this.fieldUserName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fieldUserName.Name = "fieldUserName";
            this.fieldUserName.Size = new System.Drawing.Size(208, 20);
            this.fieldUserName.TabIndex = 8;
            // 
            // btnReg2serv
            // 
            this.btnReg2serv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnReg2serv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReg2serv.BackgroundImage")));
            this.btnReg2serv.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReg2serv.Location = new System.Drawing.Point(269, 45);
            this.btnReg2serv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReg2serv.Name = "btnReg2serv";
            this.btnReg2serv.Size = new System.Drawing.Size(133, 136);
            this.btnReg2serv.TabIndex = 7;
            this.btnReg2serv.UseVisualStyleBackColor = false;
            this.btnReg2serv.Click += new System.EventHandler(this.btnReg2serv_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Macho-SemiBoldItalic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(239, 17);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 26);
            this.label4.TabIndex = 14;
            this.label4.Text = "ЗАРЕГИСТРИРОВАТЬСЯ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // RegistartionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(435, 215);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TBPass2);
            this.Controls.Add(this.TBPass1);
            this.Controls.Add(this.fieldUserName);
            this.Controls.Add(this.btnReg2serv);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistartionForm";
            this.Text = "Регистрация";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistartionForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistartionForm_FormClosed);
            this.Load += new System.EventHandler(this.RegistartionForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox TBPass2;
    private System.Windows.Forms.TextBox TBPass1;
    private System.Windows.Forms.TextBox fieldUserName;
    private System.Windows.Forms.Button btnReg2serv;
        private System.Windows.Forms.Label label4;
    }
}

namespace Server_Manager
{
    partial class Form1
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
            this.guna2GroupBox1 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2GroupBox2 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox3 = new Guna.UI2.WinForms.Guna2GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.pluginmanagerButton = new Guna.UI2.WinForms.Guna2Button();
            this.modmanagerButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2GroupBox1.SuspendLayout();
            this.guna2GroupBox2.SuspendLayout();
            this.guna2GroupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2GroupBox1
            // 
            this.guna2GroupBox1.Controls.Add(this.label2);
            this.guna2GroupBox1.Controls.Add(this.label1);
            this.guna2GroupBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox1.Location = new System.Drawing.Point(12, 12);
            this.guna2GroupBox1.Name = "guna2GroupBox1";
            this.guna2GroupBox1.ShadowDecoration.Parent = this.guna2GroupBox1;
            this.guna2GroupBox1.Size = new System.Drawing.Size(389, 85);
            this.guna2GroupBox1.TabIndex = 0;
            this.guna2GroupBox1.Text = "Информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Версия майнкрафта:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(8, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ядро: null";
            // 
            // guna2GroupBox2
            // 
            this.guna2GroupBox2.Controls.Add(this.listBox1);
            this.guna2GroupBox2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox2.Location = new System.Drawing.Point(12, 103);
            this.guna2GroupBox2.Name = "guna2GroupBox2";
            this.guna2GroupBox2.ShadowDecoration.Parent = this.guna2GroupBox2;
            this.guna2GroupBox2.Size = new System.Drawing.Size(185, 130);
            this.guna2GroupBox2.TabIndex = 2;
            this.guna2GroupBox2.Text = "Плагины";
            // 
            // listBox1
            // 
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(4, 46);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 75);
            this.listBox1.TabIndex = 0;
            // 
            // guna2Button1
            // 
            this.guna2Button1.CheckedState.Parent = this.guna2Button1;
            this.guna2Button1.CustomImages.Parent = this.guna2Button1;
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.HoverState.Parent = this.guna2Button1;
            this.guna2Button1.Location = new System.Drawing.Point(12, 239);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.ShadowDecoration.Parent = this.guna2Button1;
            this.guna2Button1.Size = new System.Drawing.Size(118, 25);
            this.guna2Button1.TabIndex = 3;
            this.guna2Button1.Text = "Запустить сервер";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2GroupBox3
            // 
            this.guna2GroupBox3.Controls.Add(this.listBox2);
            this.guna2GroupBox3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.guna2GroupBox3.Location = new System.Drawing.Point(221, 103);
            this.guna2GroupBox3.Name = "guna2GroupBox3";
            this.guna2GroupBox3.ShadowDecoration.Parent = this.guna2GroupBox3;
            this.guna2GroupBox3.Size = new System.Drawing.Size(185, 130);
            this.guna2GroupBox3.TabIndex = 3;
            this.guna2GroupBox3.Text = "Моды";
            // 
            // listBox2
            // 
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(4, 46);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(176, 75);
            this.listBox2.TabIndex = 0;
            // 
            // pluginmanagerButton
            // 
            this.pluginmanagerButton.CheckedState.Parent = this.pluginmanagerButton;
            this.pluginmanagerButton.CustomImages.Parent = this.pluginmanagerButton;
            this.pluginmanagerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.pluginmanagerButton.ForeColor = System.Drawing.Color.White;
            this.pluginmanagerButton.HoverState.Parent = this.pluginmanagerButton;
            this.pluginmanagerButton.Location = new System.Drawing.Point(136, 239);
            this.pluginmanagerButton.Name = "pluginmanagerButton";
            this.pluginmanagerButton.ShadowDecoration.Parent = this.pluginmanagerButton;
            this.pluginmanagerButton.Size = new System.Drawing.Size(147, 25);
            this.pluginmanagerButton.TabIndex = 4;
            this.pluginmanagerButton.Text = "Управление плагинами";
            this.pluginmanagerButton.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // modmanagerButton
            // 
            this.modmanagerButton.CheckedState.Parent = this.modmanagerButton;
            this.modmanagerButton.CustomImages.Parent = this.modmanagerButton;
            this.modmanagerButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.modmanagerButton.ForeColor = System.Drawing.Color.White;
            this.modmanagerButton.HoverState.Parent = this.modmanagerButton;
            this.modmanagerButton.Location = new System.Drawing.Point(291, 239);
            this.modmanagerButton.Name = "modmanagerButton";
            this.modmanagerButton.ShadowDecoration.Parent = this.modmanagerButton;
            this.modmanagerButton.Size = new System.Drawing.Size(115, 25);
            this.modmanagerButton.TabIndex = 5;
            this.modmanagerButton.Text = "Управление модами";
            this.modmanagerButton.Click += new System.EventHandler(this.modmanagerButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 269);
            this.Controls.Add(this.modmanagerButton);
            this.Controls.Add(this.pluginmanagerButton);
            this.Controls.Add(this.guna2GroupBox3);
            this.Controls.Add(this.guna2Button1);
            this.Controls.Add(this.guna2GroupBox2);
            this.Controls.Add(this.guna2GroupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Server manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2GroupBox1.ResumeLayout(false);
            this.guna2GroupBox1.PerformLayout();
            this.guna2GroupBox2.ResumeLayout(false);
            this.guna2GroupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox2;
        private System.Windows.Forms.ListBox listBox1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GroupBox guna2GroupBox3;
        private System.Windows.Forms.ListBox listBox2;
        private Guna.UI2.WinForms.Guna2Button pluginmanagerButton;
        private Guna.UI2.WinForms.Guna2Button modmanagerButton;
    }
}


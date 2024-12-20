namespace FootballClubSystem
{
    partial class RegisterForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.btnMatches = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegisterSubmit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.button1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnMatches, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.button2, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnRegisterSubmit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnRegister, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.button4, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.22222F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(776, 426);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtEmail, 3);
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtEmail.Location = new System.Drawing.Point(201, 149);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(373, 31);
            this.txtEmail.TabIndex = 13;
            this.txtEmail.Text = "Логин";
            // 
            // button4
            // 
            this.button4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(571, 17);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 59);
            this.button4.TabIndex = 9;
            this.button4.Text = "Регистрация";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // btnMatches
            // 
            this.btnMatches.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMatches.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnMatches.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMatches.Location = new System.Drawing.Point(317, 348);
            this.btnMatches.Name = "btnMatches";
            this.btnMatches.Size = new System.Drawing.Size(134, 59);
            this.btnMatches.TabIndex = 4;
            this.btnMatches.Text = "Матчи";
            this.btnMatches.UseVisualStyleBackColor = false;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnRegister.Location = new System.Drawing.Point(62, 17);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(132, 59);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Вход";
            this.btnRegister.UseVisualStyleBackColor = false;
            // 
            // btnRegisterSubmit
            // 
            this.btnRegisterSubmit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegisterSubmit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegisterSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.btnRegisterSubmit.Location = new System.Drawing.Point(259, 252);
            this.btnRegisterSubmit.Name = "btnRegisterSubmit";
            this.btnRegisterSubmit.Size = new System.Drawing.Size(250, 59);
            this.btnRegisterSubmit.TabIndex = 12;
            this.btnRegisterSubmit.Text = "Зарегистрироваться";
            this.btnRegisterSubmit.UseVisualStyleBackColor = false;
            // 
            // txtName
            // 
            this.txtName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtName, 3);
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtName.Location = new System.Drawing.Point(201, 102);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(373, 31);
            this.txtName.TabIndex = 10;
            this.txtName.Text = "Имя";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.SetColumnSpan(this.txtPassword, 3);
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.txtPassword.Location = new System.Drawing.Point(201, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(373, 31);
            this.txtPassword.TabIndex = 14;
            this.txtPassword.Text = "Пароль";
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button2.Image = global::FootballClubSystem.Properties.Resources.WINWORD_puHMQkkwmL;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(577, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 59);
            this.button2.TabIndex = 5;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.button1.Location = new System.Drawing.Point(61, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Новости";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnMatches;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Button btnRegisterSubmit;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button button1;
    }
}
namespace ЛР_1_Маска_ввода_и_валидация_Email
{
    partial class FormAddUsers
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
            this.components = new System.ComponentModel.Container();
            this.ButtonBack = new System.Windows.Forms.Button();
            this.TextMain_FormUsers = new System.Windows.Forms.Label();
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox2 = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.First_NameTextBox = new System.Windows.Forms.TextBox();
            this.Second_NameTextBox = new System.Windows.Forms.TextBox();
            this.PhonemaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.RoleIDComboBox = new System.Windows.Forms.ComboBox();
            this.BindingSourceRole = new System.Windows.Forms.BindingSource(this.components);
            this.RadioButtonMen = new System.Windows.Forms.RadioButton();
            this.RadioButtonWoman = new System.Windows.Forms.RadioButton();
            this.Buttonadd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceRole)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonBack
            // 
            this.ButtonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ButtonBack.Location = new System.Drawing.Point(12, 12);
            this.ButtonBack.Name = "ButtonBack";
            this.ButtonBack.Size = new System.Drawing.Size(100, 40);
            this.ButtonBack.TabIndex = 0;
            this.ButtonBack.TabStop = false;
            this.ButtonBack.Text = "Назад";
            this.ButtonBack.UseVisualStyleBackColor = true;
            this.ButtonBack.Click += new System.EventHandler(this.ButtonBack_Click);
            // 
            // TextMain_FormUsers
            // 
            this.TextMain_FormUsers.AutoSize = true;
            this.TextMain_FormUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TextMain_FormUsers.Location = new System.Drawing.Point(244, 27);
            this.TextMain_FormUsers.Name = "TextMain_FormUsers";
            this.TextMain_FormUsers.Size = new System.Drawing.Size(336, 25);
            this.TextMain_FormUsers.TabIndex = 1;
            this.TextMain_FormUsers.Text = "Добавление Нового Пользователя";
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LoginTextBox.Location = new System.Drawing.Point(147, 123);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(208, 26);
            this.LoginTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTextBox.Location = new System.Drawing.Point(147, 179);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(208, 26);
            this.PasswordTextBox.TabIndex = 3;
            // 
            // PasswordTextBox2
            // 
            this.PasswordTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PasswordTextBox2.Location = new System.Drawing.Point(147, 245);
            this.PasswordTextBox2.Name = "PasswordTextBox2";
            this.PasswordTextBox2.PasswordChar = '*';
            this.PasswordTextBox2.Size = new System.Drawing.Size(208, 26);
            this.PasswordTextBox2.TabIndex = 4;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.EmailTextBox.Location = new System.Drawing.Point(147, 309);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(208, 26);
            this.EmailTextBox.TabIndex = 5;
            // 
            // First_NameTextBox
            // 
            this.First_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.First_NameTextBox.Location = new System.Drawing.Point(534, 126);
            this.First_NameTextBox.Name = "First_NameTextBox";
            this.First_NameTextBox.Size = new System.Drawing.Size(183, 26);
            this.First_NameTextBox.TabIndex = 6;
            // 
            // Second_NameTextBox
            // 
            this.Second_NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Second_NameTextBox.Location = new System.Drawing.Point(534, 179);
            this.Second_NameTextBox.Name = "Second_NameTextBox";
            this.Second_NameTextBox.Size = new System.Drawing.Size(183, 26);
            this.Second_NameTextBox.TabIndex = 7;
            // 
            // PhonemaskedTextBox
            // 
            this.PhonemaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PhonemaskedTextBox.ForeColor = System.Drawing.Color.Transparent;
            this.PhonemaskedTextBox.Location = new System.Drawing.Point(147, 377);
            this.PhonemaskedTextBox.Mask = "+7 (000) 000-00-00";
            this.PhonemaskedTextBox.Name = "PhonemaskedTextBox";
            this.PhonemaskedTextBox.Size = new System.Drawing.Size(208, 26);
            this.PhonemaskedTextBox.TabIndex = 8;
            // 
            // RoleIDComboBox
            // 
            this.RoleIDComboBox.DataSource = this.BindingSourceRole;
            this.RoleIDComboBox.DisplayMember = "Name";
            this.RoleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RoleIDComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.RoleIDComboBox.FormattingEnabled = true;
            this.RoleIDComboBox.Location = new System.Drawing.Point(534, 240);
            this.RoleIDComboBox.Name = "RoleIDComboBox";
            this.RoleIDComboBox.Size = new System.Drawing.Size(183, 28);
            this.RoleIDComboBox.TabIndex = 9;
            this.RoleIDComboBox.ValueMember = "ID";
            // 
            // BindingSourceRole
            // 
            this.BindingSourceRole.DataSource = typeof(ЛР_1_Маска_ввода_и_валидация_Email.DBContext.Roles);
            // 
            // RadioButtonMen
            // 
            this.RadioButtonMen.AutoSize = true;
            this.RadioButtonMen.Checked = true;
            this.RadioButtonMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RadioButtonMen.Location = new System.Drawing.Point(534, 314);
            this.RadioButtonMen.Name = "RadioButtonMen";
            this.RadioButtonMen.Size = new System.Drawing.Size(83, 21);
            this.RadioButtonMen.TabIndex = 10;
            this.RadioButtonMen.TabStop = true;
            this.RadioButtonMen.Text = "Мужской";
            this.RadioButtonMen.UseVisualStyleBackColor = true;
            // 
            // RadioButtonWoman
            // 
            this.RadioButtonWoman.AutoSize = true;
            this.RadioButtonWoman.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.RadioButtonWoman.Location = new System.Drawing.Point(632, 314);
            this.RadioButtonWoman.Name = "RadioButtonWoman";
            this.RadioButtonWoman.Size = new System.Drawing.Size(85, 21);
            this.RadioButtonWoman.TabIndex = 11;
            this.RadioButtonWoman.Text = "Женский";
            this.RadioButtonWoman.UseVisualStyleBackColor = true;
            // 
            // Buttonadd
            // 
            this.Buttonadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Buttonadd.Location = new System.Drawing.Point(632, 377);
            this.Buttonadd.Name = "Buttonadd";
            this.Buttonadd.Size = new System.Drawing.Size(119, 49);
            this.Buttonadd.TabIndex = 12;
            this.Buttonadd.Text = "Добавить";
            this.Buttonadd.UseVisualStyleBackColor = true;
            this.Buttonadd.Click += new System.EventHandler(this.Buttonadd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Пароль:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Повтор пароля:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(8, 315);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Эл.почта:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(12, 383);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Телефон:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(421, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Имя:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(421, 185);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Фамилия:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(421, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Роль:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.Location = new System.Drawing.Point(421, 315);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "Пол:";
            // 
            // FormAddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buttonadd);
            this.Controls.Add(this.RadioButtonWoman);
            this.Controls.Add(this.RadioButtonMen);
            this.Controls.Add(this.RoleIDComboBox);
            this.Controls.Add(this.PhonemaskedTextBox);
            this.Controls.Add(this.Second_NameTextBox);
            this.Controls.Add(this.First_NameTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.PasswordTextBox2);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.LoginTextBox);
            this.Controls.Add(this.TextMain_FormUsers);
            this.Controls.Add(this.ButtonBack);
            this.Name = "FormAddUsers";
            this.Text = "FormAddUsers";
            this.Load += new System.EventHandler(this.FormAddUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSourceRole)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonBack;
        private System.Windows.Forms.Label TextMain_FormUsers;
        private System.Windows.Forms.TextBox LoginTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox2;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.TextBox First_NameTextBox;
        private System.Windows.Forms.TextBox Second_NameTextBox;
        private System.Windows.Forms.MaskedTextBox PhonemaskedTextBox;
        private System.Windows.Forms.ComboBox RoleIDComboBox;
        private System.Windows.Forms.RadioButton RadioButtonMen;
        private System.Windows.Forms.RadioButton RadioButtonWoman;
        private System.Windows.Forms.Button Buttonadd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource BindingSourceRole;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
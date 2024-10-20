namespace ЛР_1_Маска_ввода_и_валидация_Email
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
            this.Label_Main = new System.Windows.Forms.Label();
            this.Table = new System.Windows.Forms.DataGridView();
            this.Add_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Table)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Main
            // 
            this.Label_Main.AutoSize = true;
            this.Label_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.Label_Main.Location = new System.Drawing.Point(215, 9);
            this.Label_Main.Name = "Label_Main";
            this.Label_Main.Size = new System.Drawing.Size(402, 39);
            this.Label_Main.TabIndex = 0;
            this.Label_Main.Text = "Таблица пользователей";
            // 
            // Table
            // 
            this.Table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Table.Location = new System.Drawing.Point(29, 64);
            this.Table.Name = "Table";
            this.Table.Size = new System.Drawing.Size(750, 304);
            this.Table.TabIndex = 1;
            // 
            // Add_Button
            // 
            this.Add_Button.Location = new System.Drawing.Point(201, 386);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(439, 38);
            this.Add_Button.TabIndex = 2;
            this.Add_Button.Text = "Добавить";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Add_Button);
            this.Controls.Add(this.Table);
            this.Controls.Add(this.Label_Main);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label_Main;
        private System.Windows.Forms.DataGridView Table;
        private System.Windows.Forms.Button Add_Button;
    }
}


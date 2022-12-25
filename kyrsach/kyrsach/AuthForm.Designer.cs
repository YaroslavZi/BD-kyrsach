
namespace kyrsach
{
    partial class Authorization
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
            this.saveButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passTB = new System.Windows.Forms.TextBox();
            this.loginTB = new System.Windows.Forms.TextBox();
            this.regButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(117, 367);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(170, 56);
            this.saveButton.TabIndex = 0;
            this.saveButton.Text = "Войти";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(65, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(65, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль";
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTB.Location = new System.Drawing.Point(183, 247);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(148, 26);
            this.passTB.TabIndex = 3;
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.Location = new System.Drawing.Point(183, 147);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(148, 26);
            this.loginTB.TabIndex = 4;
            // 
            // regButton
            // 
            this.regButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regButton.Location = new System.Drawing.Point(117, 457);
            this.regButton.Name = "regButton";
            this.regButton.Size = new System.Drawing.Size(170, 38);
            this.regButton.TabIndex = 5;
            this.regButton.Text = "Зарегистрироваться";
            this.regButton.UseVisualStyleBackColor = true;
            this.regButton.Click += new System.EventHandler(this.regButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(131, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Авторизация";
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 563);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.regButton);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.Button regButton;
        private System.Windows.Forms.Label label3;
    }
}


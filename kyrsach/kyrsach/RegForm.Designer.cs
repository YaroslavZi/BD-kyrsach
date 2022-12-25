
namespace kyrsach
{
    partial class RegForm
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
            this.loginTB = new System.Windows.Forms.TextBox();
            this.passTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginTB
            // 
            this.loginTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginTB.Location = new System.Drawing.Point(163, 163);
            this.loginTB.Name = "loginTB";
            this.loginTB.Size = new System.Drawing.Size(180, 26);
            this.loginTB.TabIndex = 9;
            // 
            // passTB
            // 
            this.passTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passTB.Location = new System.Drawing.Point(163, 255);
            this.passTB.Name = "passTB";
            this.passTB.Size = new System.Drawing.Size(180, 26);
            this.passTB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(59, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Логин";
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(121, 410);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(153, 56);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(129, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Регистрация";
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 534);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.loginTB);
            this.Controls.Add(this.passTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveButton);
            this.Name = "RegForm";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTB;
        private System.Windows.Forms.TextBox passTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label label3;
    }
}

namespace kyrsach
{
    partial class AddProvidersForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AddWorkLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(177, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 13;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PhoneTB
            // 
            this.PhoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTB.Location = new System.Drawing.Point(258, 195);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(200, 24);
            this.PhoneTB.TabIndex = 12;
            // 
            // AddressTB
            // 
            this.AddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressTB.Location = new System.Drawing.Point(258, 134);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(200, 24);
            this.AddressTB.TabIndex = 11;
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(258, 70);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(200, 24);
            this.nameTB.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(56, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Адрес";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(56, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Номер телефона";
            // 
            // AddWorkLB
            // 
            this.AddWorkLB.AutoSize = true;
            this.AddWorkLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWorkLB.Location = new System.Drawing.Point(56, 72);
            this.AddWorkLB.Name = "AddWorkLB";
            this.AddWorkLB.Size = new System.Drawing.Size(183, 20);
            this.AddWorkLB.TabIndex = 7;
            this.AddWorkLB.Text = "Название организации";
            // 
            // AddProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 436);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddWorkLB);
            this.Name = "AddProvidersForm";
            this.Text = "Добавление поставщика";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label AddWorkLB;
    }
}
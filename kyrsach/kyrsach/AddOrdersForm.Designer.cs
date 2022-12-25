
namespace kyrsach
{
    partial class AddOrdersForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.salesDateTB = new System.Windows.Forms.TextBox();
            this.salesCountTB = new System.Windows.Forms.TextBox();
            this.productCB = new System.Windows.Forms.ComboBox();
            this.providerCB = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(413, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Дата заказа";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(413, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Количество";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(69, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Продукты";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(69, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Поставщик";
            // 
            // salesDateTB
            // 
            this.salesDateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesDateTB.Location = new System.Drawing.Point(529, 195);
            this.salesDateTB.Name = "salesDateTB";
            this.salesDateTB.Size = new System.Drawing.Size(179, 24);
            this.salesDateTB.TabIndex = 11;
            // 
            // salesCountTB
            // 
            this.salesCountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesCountTB.Location = new System.Drawing.Point(529, 88);
            this.salesCountTB.Name = "salesCountTB";
            this.salesCountTB.Size = new System.Drawing.Size(179, 24);
            this.salesCountTB.TabIndex = 10;
            // 
            // productCB
            // 
            this.productCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCB.FormattingEnabled = true;
            this.productCB.Location = new System.Drawing.Point(174, 88);
            this.productCB.Name = "productCB";
            this.productCB.Size = new System.Drawing.Size(179, 26);
            this.productCB.TabIndex = 9;
            // 
            // providerCB
            // 
            this.providerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.providerCB.FormattingEnabled = true;
            this.providerCB.Location = new System.Drawing.Point(174, 193);
            this.providerCB.Name = "providerCB";
            this.providerCB.Size = new System.Drawing.Size(179, 26);
            this.providerCB.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(321, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 16;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 417);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesDateTB);
            this.Controls.Add(this.salesCountTB);
            this.Controls.Add(this.productCB);
            this.Controls.Add(this.providerCB);
            this.Name = "AddOrdersForm";
            this.Text = "Добавление заказа";
            this.Load += new System.EventHandler(this.AddOrdersForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox salesDateTB;
        private System.Windows.Forms.TextBox salesCountTB;
        private System.Windows.Forms.ComboBox productCB;
        private System.Windows.Forms.ComboBox providerCB;
        private System.Windows.Forms.Button button1;
    }
}
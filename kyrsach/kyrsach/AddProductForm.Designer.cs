
namespace kyrsach
{
    partial class AddProductForm
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
            this.CBCategory = new System.Windows.Forms.ComboBox();
            this.CBName = new System.Windows.Forms.TextBox();
            this.CBCount = new System.Windows.Forms.TextBox();
            this.CBPrice = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveBut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBCategory
            // 
            this.CBCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCategory.FormattingEnabled = true;
            this.CBCategory.Location = new System.Drawing.Point(158, 91);
            this.CBCategory.Name = "CBCategory";
            this.CBCategory.Size = new System.Drawing.Size(164, 26);
            this.CBCategory.TabIndex = 0;
            // 
            // CBName
            // 
            this.CBName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBName.Location = new System.Drawing.Point(158, 219);
            this.CBName.Name = "CBName";
            this.CBName.Size = new System.Drawing.Size(164, 24);
            this.CBName.TabIndex = 1;
            // 
            // CBCount
            // 
            this.CBCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBCount.Location = new System.Drawing.Point(526, 91);
            this.CBCount.Name = "CBCount";
            this.CBCount.Size = new System.Drawing.Size(164, 24);
            this.CBCount.TabIndex = 2;
            // 
            // CBPrice
            // 
            this.CBPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBPrice.Location = new System.Drawing.Point(526, 217);
            this.CBPrice.Name = "CBPrice";
            this.CBPrice.Size = new System.Drawing.Size(164, 24);
            this.CBPrice.TabIndex = 3;
            this.CBPrice.TextChanged += new System.EventHandler(this.CBPrice_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(38, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Категория";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(38, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(415, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(415, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цена";
            // 
            // saveBut
            // 
            this.saveBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBut.Location = new System.Drawing.Point(307, 347);
            this.saveBut.Name = "saveBut";
            this.saveBut.Size = new System.Drawing.Size(125, 37);
            this.saveBut.TabIndex = 8;
            this.saveBut.Text = "Сохранить";
            this.saveBut.UseVisualStyleBackColor = true;
            this.saveBut.Click += new System.EventHandler(this.saveBut_Click);
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 423);
            this.Controls.Add(this.saveBut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBPrice);
            this.Controls.Add(this.CBCount);
            this.Controls.Add(this.CBName);
            this.Controls.Add(this.CBCategory);
            this.Name = "AddProductForm";
            this.Text = "Добавление товара";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBCategory;
        private System.Windows.Forms.TextBox CBName;
        private System.Windows.Forms.TextBox CBCount;
        private System.Windows.Forms.TextBox CBPrice;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveBut;
    }
}
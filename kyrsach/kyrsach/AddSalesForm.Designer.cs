
namespace kyrsach
{
    partial class AddSalesForm
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
            this.workerCB = new System.Windows.Forms.ComboBox();
            this.productCB = new System.Windows.Forms.ComboBox();
            this.salesCountTB = new System.Windows.Forms.TextBox();
            this.salesDateTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // workerCB
            // 
            this.workerCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workerCB.FormattingEnabled = true;
            this.workerCB.Location = new System.Drawing.Point(141, 96);
            this.workerCB.Name = "workerCB";
            this.workerCB.Size = new System.Drawing.Size(201, 26);
            this.workerCB.TabIndex = 0;
            // 
            // productCB
            // 
            this.productCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCB.FormattingEnabled = true;
            this.productCB.Location = new System.Drawing.Point(141, 213);
            this.productCB.Name = "productCB";
            this.productCB.Size = new System.Drawing.Size(201, 26);
            this.productCB.TabIndex = 1;
            // 
            // salesCountTB
            // 
            this.salesCountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesCountTB.Location = new System.Drawing.Point(525, 96);
            this.salesCountTB.Name = "salesCountTB";
            this.salesCountTB.Size = new System.Drawing.Size(201, 24);
            this.salesCountTB.TabIndex = 2;
            // 
            // salesDateTB
            // 
            this.salesDateTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesDateTB.Location = new System.Drawing.Point(525, 213);
            this.salesDateTB.Name = "salesDateTB";
            this.salesDateTB.Size = new System.Drawing.Size(201, 24);
            this.salesDateTB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(44, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Сотрудик";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(44, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Продукт";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(400, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(400, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата продажи";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(335, 351);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddSalesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.salesDateTB);
            this.Controls.Add(this.salesCountTB);
            this.Controls.Add(this.productCB);
            this.Controls.Add(this.workerCB);
            this.Name = "AddSalesForm";
            this.Text = "Добавление продажи";
            this.Load += new System.EventHandler(this.AddSalesForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox workerCB;
        private System.Windows.Forms.ComboBox productCB;
        private System.Windows.Forms.TextBox salesCountTB;
        private System.Windows.Forms.TextBox salesDateTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}
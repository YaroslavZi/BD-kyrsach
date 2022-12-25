
namespace kyrsach
{
    partial class MainForm
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
            this.productBut = new System.Windows.Forms.Button();
            this.salesBut = new System.Windows.Forms.Button();
            this.ordersBut = new System.Windows.Forms.Button();
            this.workersBut = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // productBut
            // 
            this.productBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productBut.Location = new System.Drawing.Point(109, 102);
            this.productBut.Name = "productBut";
            this.productBut.Size = new System.Drawing.Size(145, 65);
            this.productBut.TabIndex = 0;
            this.productBut.Text = "Товары";
            this.productBut.UseVisualStyleBackColor = true;
            this.productBut.Click += new System.EventHandler(this.productBut_Click);
            // 
            // salesBut
            // 
            this.salesBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.salesBut.Location = new System.Drawing.Point(109, 202);
            this.salesBut.Name = "salesBut";
            this.salesBut.Size = new System.Drawing.Size(145, 65);
            this.salesBut.TabIndex = 1;
            this.salesBut.Text = "Продажи";
            this.salesBut.UseVisualStyleBackColor = true;
            this.salesBut.Click += new System.EventHandler(this.salesBut_Click);
            // 
            // ordersBut
            // 
            this.ordersBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ordersBut.Location = new System.Drawing.Point(109, 298);
            this.ordersBut.Name = "ordersBut";
            this.ordersBut.Size = new System.Drawing.Size(145, 64);
            this.ordersBut.TabIndex = 2;
            this.ordersBut.Text = "Заказы";
            this.ordersBut.UseVisualStyleBackColor = true;
            this.ordersBut.Click += new System.EventHandler(this.ordersBut_Click);
            // 
            // workersBut
            // 
            this.workersBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workersBut.Location = new System.Drawing.Point(109, 484);
            this.workersBut.Name = "workersBut";
            this.workersBut.Size = new System.Drawing.Size(145, 64);
            this.workersBut.TabIndex = 3;
            this.workersBut.Text = "Сотрудники";
            this.workersBut.UseVisualStyleBackColor = true;
            this.workersBut.Click += new System.EventHandler(this.workersBut_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(109, 389);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 64);
            this.button1.TabIndex = 4;
            this.button1.Text = "Поставщики";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(137, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 29);
            this.label1.TabIndex = 5;
            this.label1.Text = "Меню";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 573);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.workersBut);
            this.Controls.Add(this.ordersBut);
            this.Controls.Add(this.salesBut);
            this.Controls.Add(this.productBut);
            this.Name = "MainForm";
            this.Text = "Меню";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button productBut;
        private System.Windows.Forms.Button salesBut;
        private System.Windows.Forms.Button ordersBut;
        private System.Windows.Forms.Button workersBut;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

namespace kyrsach
{
    partial class OrdersForm
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
            this.editBut = new System.Windows.Forms.Button();
            this.removeBut = new System.Windows.Forms.Button();
            this.addBut = new System.Windows.Forms.Button();
            this.prodLV = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProviderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrderDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchTB = new System.Windows.Forms.TextBox();
            this.searchCB = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // editBut
            // 
            this.editBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBut.Location = new System.Drawing.Point(546, 378);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(97, 46);
            this.editBut.TabIndex = 12;
            this.editBut.Text = "Изменить";
            this.editBut.UseVisualStyleBackColor = true;
            this.editBut.Click += new System.EventHandler(this.editBut_Click);
            // 
            // removeBut
            // 
            this.removeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeBut.Location = new System.Drawing.Point(691, 378);
            this.removeBut.Name = "removeBut";
            this.removeBut.Size = new System.Drawing.Size(97, 46);
            this.removeBut.TabIndex = 11;
            this.removeBut.Text = "Удалить";
            this.removeBut.UseVisualStyleBackColor = true;
            this.removeBut.Click += new System.EventHandler(this.removeBut_Click);
            // 
            // addBut
            // 
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(395, 378);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(97, 46);
            this.addBut.TabIndex = 10;
            this.addBut.Text = "Добавить";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // prodLV
            // 
            this.prodLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.ProductName,
            this.ProviderName,
            this.Count,
            this.OrderDate});
            this.prodLV.GridLines = true;
            this.prodLV.HideSelection = false;
            this.prodLV.Location = new System.Drawing.Point(12, 26);
            this.prodLV.Name = "prodLV";
            this.prodLV.Size = new System.Drawing.Size(776, 323);
            this.prodLV.TabIndex = 9;
            this.prodLV.UseCompatibleStateImageBehavior = false;
            this.prodLV.View = System.Windows.Forms.View.Details;
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // ProductName
            // 
            this.ProductName.Text = "Товар";
            this.ProductName.Width = 161;
            // 
            // ProviderName
            // 
            this.ProviderName.Text = "Поставщик";
            this.ProviderName.Width = 160;
            // 
            // Count
            // 
            this.Count.Text = "Кол-во";
            this.Count.Width = 100;
            // 
            // OrderDate
            // 
            this.OrderDate.Text = "Дата заказа";
            this.OrderDate.Width = 186;
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.Location = new System.Drawing.Point(12, 397);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(238, 23);
            this.searchTB.TabIndex = 13;
            this.searchTB.TextChanged += new System.EventHandler(this.searchTB_TextChanged);
            // 
            // searchCB
            // 
            this.searchCB.AutoSize = true;
            this.searchCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCB.Location = new System.Drawing.Point(12, 370);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(169, 21);
            this.searchCB.TabIndex = 14;
            this.searchCB.Text = "Поиск по поставщику";
            this.searchCB.UseVisualStyleBackColor = true;
            this.searchCB.CheckedChanged += new System.EventHandler(this.searchCB_CheckedChanged);
            // 
            // OrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchCB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.editBut);
            this.Controls.Add(this.removeBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.prodLV);
            this.Name = "OrdersForm";
            this.Text = "Заказы";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.Button removeBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.ListView prodLV;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader ProviderName;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader OrderDate;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.TextBox searchTB;
        private System.Windows.Forms.CheckBox searchCB;
    }
}
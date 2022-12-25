
namespace kyrsach
{
    partial class ProductsForm
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
            this.prodLV = new System.Windows.Forms.ListView();
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Category = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBut = new System.Windows.Forms.Button();
            this.removeBut = new System.Windows.Forms.Button();
            this.editBut = new System.Windows.Forms.Button();
            this.addCategory = new System.Windows.Forms.Button();
            this.searchCB = new System.Windows.Forms.CheckBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // prodLV
            // 
            this.prodLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ProductID,
            this.Category,
            this.ProductName,
            this.Count,
            this.Price});
            this.prodLV.GridLines = true;
            this.prodLV.HideSelection = false;
            this.prodLV.Location = new System.Drawing.Point(12, 12);
            this.prodLV.Name = "prodLV";
            this.prodLV.Size = new System.Drawing.Size(776, 323);
            this.prodLV.TabIndex = 0;
            this.prodLV.UseCompatibleStateImageBehavior = false;
            this.prodLV.View = System.Windows.Forms.View.Details;
            // 
            // ProductID
            // 
            this.ProductID.Text = "ID";
            this.ProductID.Width = 39;
            // 
            // Category
            // 
            this.Category.Text = "Категория";
            this.Category.Width = 193;
            // 
            // ProductName
            // 
            this.ProductName.Text = "Название";
            this.ProductName.Width = 237;
            // 
            // Count
            // 
            this.Count.Text = "Кол-во";
            this.Count.Width = 116;
            // 
            // Price
            // 
            this.Price.Text = "Цена";
            this.Price.Width = 119;
            // 
            // addBut
            // 
            this.addBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBut.Location = new System.Drawing.Point(260, 383);
            this.addBut.Name = "addBut";
            this.addBut.Size = new System.Drawing.Size(97, 46);
            this.addBut.TabIndex = 1;
            this.addBut.Text = "Добавить";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // removeBut
            // 
            this.removeBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeBut.Location = new System.Drawing.Point(511, 383);
            this.removeBut.Name = "removeBut";
            this.removeBut.Size = new System.Drawing.Size(97, 46);
            this.removeBut.TabIndex = 2;
            this.removeBut.Text = "Удалить";
            this.removeBut.UseVisualStyleBackColor = true;
            this.removeBut.Click += new System.EventHandler(this.removeBut_Click);
            // 
            // editBut
            // 
            this.editBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBut.Location = new System.Drawing.Point(387, 383);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(97, 46);
            this.editBut.TabIndex = 3;
            this.editBut.Text = "Изменить";
            this.editBut.UseVisualStyleBackColor = true;
            this.editBut.Click += new System.EventHandler(this.editBut_Click);
            // 
            // addCategory
            // 
            this.addCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCategory.Location = new System.Drawing.Point(652, 383);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(136, 46);
            this.addCategory.TabIndex = 4;
            this.addCategory.Text = "Добавить категорию";
            this.addCategory.UseVisualStyleBackColor = true;
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // searchCB
            // 
            this.searchCB.AutoSize = true;
            this.searchCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCB.Location = new System.Drawing.Point(12, 383);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(155, 21);
            this.searchCB.TabIndex = 16;
            this.searchCB.Text = "Поиск по названию";
            this.searchCB.UseVisualStyleBackColor = true;
            this.searchCB.CheckedChanged += new System.EventHandler(this.searchCB_CheckedChanged);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.Location = new System.Drawing.Point(12, 406);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(215, 23);
            this.searchTB.TabIndex = 15;
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.searchCB);
            this.Controls.Add(this.searchTB);
            this.Controls.Add(this.addCategory);
            this.Controls.Add(this.editBut);
            this.Controls.Add(this.removeBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.prodLV);
            this.Name = "ProductsForm";
            this.Text = "Товар";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView prodLV;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.Button removeBut;
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader Category;
        private System.Windows.Forms.ColumnHeader ProductName;
        private System.Windows.Forms.ColumnHeader Count;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.Button addCategory;
        private System.Windows.Forms.CheckBox searchCB;
        private System.Windows.Forms.TextBox searchTB;
    }
}
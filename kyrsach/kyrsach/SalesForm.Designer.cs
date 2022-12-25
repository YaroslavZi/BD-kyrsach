
namespace kyrsach
{
    partial class SalesForm
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
            this.SaleID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WorkerID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ProductID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalesCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SalesDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchCB = new System.Windows.Forms.CheckBox();
            this.searchTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // editBut
            // 
            this.editBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBut.Location = new System.Drawing.Point(546, 378);
            this.editBut.Name = "editBut";
            this.editBut.Size = new System.Drawing.Size(97, 46);
            this.editBut.TabIndex = 8;
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
            this.removeBut.TabIndex = 7;
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
            this.addBut.TabIndex = 6;
            this.addBut.Text = "Добавить";
            this.addBut.UseVisualStyleBackColor = true;
            this.addBut.Click += new System.EventHandler(this.addBut_Click);
            // 
            // prodLV
            // 
            this.prodLV.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaleID,
            this.WorkerID,
            this.ProductID,
            this.SalesCount,
            this.SalesDate});
            this.prodLV.GridLines = true;
            this.prodLV.HideSelection = false;
            this.prodLV.Location = new System.Drawing.Point(12, 26);
            this.prodLV.Name = "prodLV";
            this.prodLV.Size = new System.Drawing.Size(776, 323);
            this.prodLV.TabIndex = 5;
            this.prodLV.UseCompatibleStateImageBehavior = false;
            this.prodLV.View = System.Windows.Forms.View.Details;
            // 
            // SaleID
            // 
            this.SaleID.Text = "ID";
            this.SaleID.Width = 39;
            // 
            // WorkerID
            // 
            this.WorkerID.Text = "Сотрудник";
            this.WorkerID.Width = 216;
            // 
            // ProductID
            // 
            this.ProductID.Text = "Продукт";
            this.ProductID.Width = 261;
            // 
            // SalesCount
            // 
            this.SalesCount.Text = "Кол-во";
            this.SalesCount.Width = 86;
            // 
            // SalesDate
            // 
            this.SalesDate.Text = "Дата продажи";
            this.SalesDate.Width = 130;
            // 
            // searchCB
            // 
            this.searchCB.AutoSize = true;
            this.searchCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchCB.Location = new System.Drawing.Point(13, 371);
            this.searchCB.Name = "searchCB";
            this.searchCB.Size = new System.Drawing.Size(166, 21);
            this.searchCB.TabIndex = 16;
            this.searchCB.Text = "Поиск по сотруднику";
            this.searchCB.UseVisualStyleBackColor = true;
            this.searchCB.CheckedChanged += new System.EventHandler(this.searchCB_CheckedChanged);
            // 
            // searchTB
            // 
            this.searchTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTB.Location = new System.Drawing.Point(13, 398);
            this.searchTB.Name = "searchTB";
            this.searchTB.Size = new System.Drawing.Size(239, 23);
            this.searchTB.TabIndex = 15;
            // 
            // SalesForm
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
            this.Name = "SalesForm";
            this.Text = " ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.Button removeBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.ListView prodLV;
        private System.Windows.Forms.ColumnHeader SaleID;
        private System.Windows.Forms.ColumnHeader WorkerID;
        private System.Windows.Forms.ColumnHeader ProductID;
        private System.Windows.Forms.ColumnHeader SalesCount;
        private System.Windows.Forms.ColumnHeader SalesDate;
        private System.Windows.Forms.CheckBox searchCB;
        private System.Windows.Forms.TextBox searchTB;
    }
}
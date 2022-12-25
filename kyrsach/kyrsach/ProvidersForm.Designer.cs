
namespace kyrsach
{
    partial class ProvidersForm
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
            this.ProviderID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OrganizationName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // editBut
            // 
            this.editBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editBut.Location = new System.Drawing.Point(357, 376);
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
            this.removeBut.Location = new System.Drawing.Point(629, 376);
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
            this.addBut.Location = new System.Drawing.Point(66, 376);
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
            this.ProviderID,
            this.OrganizationName,
            this.PhoneNumber,
            this.Address});
            this.prodLV.GridLines = true;
            this.prodLV.HideSelection = false;
            this.prodLV.Location = new System.Drawing.Point(12, 26);
            this.prodLV.Name = "prodLV";
            this.prodLV.Size = new System.Drawing.Size(776, 323);
            this.prodLV.TabIndex = 5;
            this.prodLV.UseCompatibleStateImageBehavior = false;
            this.prodLV.View = System.Windows.Forms.View.Details;
            // 
            // ProviderID
            // 
            this.ProviderID.Text = "ID";
            this.ProviderID.Width = 39;
            // 
            // OrganizationName
            // 
            this.OrganizationName.Text = "Название Компании";
            this.OrganizationName.Width = 218;
            // 
            // PhoneNumber
            // 
            this.PhoneNumber.Text = "Номер ";
            this.PhoneNumber.Width = 219;
            // 
            // Address
            // 
            this.Address.Text = "Адрес";
            this.Address.Width = 152;
            // 
            // ProvidersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.editBut);
            this.Controls.Add(this.removeBut);
            this.Controls.Add(this.addBut);
            this.Controls.Add(this.prodLV);
            this.Name = "ProvidersForm";
            this.Text = "Поставщики";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button editBut;
        private System.Windows.Forms.Button removeBut;
        private System.Windows.Forms.Button addBut;
        private System.Windows.Forms.ListView prodLV;
        private System.Windows.Forms.ColumnHeader ProviderID;
        private System.Windows.Forms.ColumnHeader OrganizationName;
        private System.Windows.Forms.ColumnHeader PhoneNumber;
        private System.Windows.Forms.ColumnHeader Address;
    }
}
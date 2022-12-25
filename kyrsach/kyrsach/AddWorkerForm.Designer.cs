
namespace kyrsach
{
    partial class AddWorkerForm
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
            this.AddWorkLB = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.AddressTB = new System.Windows.Forms.TextBox();
            this.PhoneTB = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddWorkLB
            // 
            this.AddWorkLB.AutoSize = true;
            this.AddWorkLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddWorkLB.Location = new System.Drawing.Point(46, 77);
            this.AddWorkLB.Name = "AddWorkLB";
            this.AddWorkLB.Size = new System.Drawing.Size(47, 20);
            this.AddWorkLB.TabIndex = 0;
            this.AddWorkLB.Text = "ФИО";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(46, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(46, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Телефон";
            // 
            // nameTB
            // 
            this.nameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameTB.Location = new System.Drawing.Point(176, 75);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(202, 24);
            this.nameTB.TabIndex = 3;
            // 
            // AddressTB
            // 
            this.AddressTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddressTB.Location = new System.Drawing.Point(176, 141);
            this.AddressTB.Name = "AddressTB";
            this.AddressTB.Size = new System.Drawing.Size(202, 24);
            this.AddressTB.TabIndex = 4;
            // 
            // PhoneTB
            // 
            this.PhoneTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PhoneTB.Location = new System.Drawing.Point(176, 213);
            this.PhoneTB.Name = "PhoneTB";
            this.PhoneTB.Size = new System.Drawing.Size(202, 24);
            this.PhoneTB.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(147, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Сохранить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddWorkerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.PhoneTB);
            this.Controls.Add(this.AddressTB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddWorkLB);
            this.Name = "AddWorkerForm";
            this.Text = "Добавление сотрудника";
            this.Load += new System.EventHandler(this.AddWorkerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddWorkLB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.TextBox AddressTB;
        private System.Windows.Forms.TextBox PhoneTB;
        private System.Windows.Forms.Button button1;
    }
}
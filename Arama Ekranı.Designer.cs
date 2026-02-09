namespace WindowsFormsApp1
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbAracMarka = new System.Windows.Forms.ComboBox();
            this.cmbAracModel = new System.Windows.Forms.ComboBox();
            this.txtAracPlaka = new System.Windows.Forms.TextBox();
            this.txtFiyatMaks = new System.Windows.Forms.TextBox();
            this.txtFiyatMin = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(58, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Plaka:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(92, 175);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Marka:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(92, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(8, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fiyat Maksimum:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(20, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "Fiyat Minimum:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Colonna MT", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(88, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(164, 43);
            this.label6.TabIndex = 5;
            this.label6.Text = "Filtreler";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(334, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(801, 438);
            this.dataGridView1.TabIndex = 6;
            // 
            // cmbAracMarka
            // 
            this.cmbAracMarka.FormattingEnabled = true;
            this.cmbAracMarka.Location = new System.Drawing.Point(168, 175);
            this.cmbAracMarka.Name = "cmbAracMarka";
            this.cmbAracMarka.Size = new System.Drawing.Size(151, 24);
            this.cmbAracMarka.TabIndex = 7;
            this.cmbAracMarka.SelectedIndexChanged += new System.EventHandler(this.cmbAracMarka_SelectedIndexChanged);
            // 
            // cmbAracModel
            // 
            this.cmbAracModel.FormattingEnabled = true;
            this.cmbAracModel.Location = new System.Drawing.Point(168, 212);
            this.cmbAracModel.Name = "cmbAracModel";
            this.cmbAracModel.Size = new System.Drawing.Size(151, 24);
            this.cmbAracModel.TabIndex = 8;
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(168, 138);
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(151, 22);
            this.txtAracPlaka.TabIndex = 9;
            // 
            // txtFiyatMaks
            // 
            this.txtFiyatMaks.Location = new System.Drawing.Point(168, 248);
            this.txtFiyatMaks.Name = "txtFiyatMaks";
            this.txtFiyatMaks.Size = new System.Drawing.Size(151, 22);
            this.txtFiyatMaks.TabIndex = 10;
            // 
            // txtFiyatMin
            // 
            this.txtFiyatMin.Location = new System.Drawing.Point(168, 285);
            this.txtFiyatMin.Name = "txtFiyatMin";
            this.txtFiyatMin.Size = new System.Drawing.Size(151, 22);
            this.txtFiyatMin.TabIndex = 11;
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(168, 327);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(151, 34);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Bul";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1147, 462);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtFiyatMin);
            this.Controls.Add(this.txtFiyatMaks);
            this.Controls.Add(this.txtAracPlaka);
            this.Controls.Add(this.cmbAracModel);
            this.Controls.Add(this.cmbAracMarka);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "MECH Otomobil Arama Ekranı";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbAracMarka;
        private System.Windows.Forms.ComboBox cmbAracModel;
        private System.Windows.Forms.TextBox txtAracPlaka;
        private System.Windows.Forms.TextBox txtFiyatMaks;
        private System.Windows.Forms.TextBox txtFiyatMin;
        private System.Windows.Forms.Button btnFind;
    }
}
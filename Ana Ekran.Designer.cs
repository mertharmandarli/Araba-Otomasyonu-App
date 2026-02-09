namespace WindowsFormsApp1
{
    partial class Form1
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
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtAracPlaka = new System.Windows.Forms.TextBox();
            this.txtAracFiyat = new System.Windows.Forms.TextBox();
            this.txtAracMarka = new System.Windows.Forms.TextBox();
            this.txtAracYılı = new System.Windows.Forms.TextBox();
            this.txtAracHasarKaydı = new System.Windows.Forms.TextBox();
            this.txtAracModel = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnList = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIlanDurumu = new System.Windows.Forms.TextBox();
            this.btnPlakaCagir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(50, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Araç Plakası:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(42, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Araç Markası:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(53, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Araç Model:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(82, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Araç Yılı:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(66, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Araç Fiyat:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(14, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Araç Hasar Kaydı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 37);
            this.label7.TabIndex = 6;
            this.label7.Text = "MECH Otomobil";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(335, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(836, 528);
            this.dataGridView1.TabIndex = 7;
            // 
            // txtAracPlaka
            // 
            this.txtAracPlaka.Location = new System.Drawing.Point(157, 93);
            this.txtAracPlaka.Name = "txtAracPlaka";
            this.txtAracPlaka.Size = new System.Drawing.Size(155, 22);
            this.txtAracPlaka.TabIndex = 8;
            // 
            // txtAracFiyat
            // 
            this.txtAracFiyat.Location = new System.Drawing.Point(157, 124);
            this.txtAracFiyat.Name = "txtAracFiyat";
            this.txtAracFiyat.Size = new System.Drawing.Size(155, 22);
            this.txtAracFiyat.TabIndex = 9;
            // 
            // txtAracMarka
            // 
            this.txtAracMarka.Location = new System.Drawing.Point(157, 152);
            this.txtAracMarka.Name = "txtAracMarka";
            this.txtAracMarka.Size = new System.Drawing.Size(155, 22);
            this.txtAracMarka.TabIndex = 10;
            // 
            // txtAracYılı
            // 
            this.txtAracYılı.Location = new System.Drawing.Point(157, 236);
            this.txtAracYılı.Name = "txtAracYılı";
            this.txtAracYılı.Size = new System.Drawing.Size(155, 22);
            this.txtAracYılı.TabIndex = 11;
            // 
            // txtAracHasarKaydı
            // 
            this.txtAracHasarKaydı.Location = new System.Drawing.Point(157, 208);
            this.txtAracHasarKaydı.Name = "txtAracHasarKaydı";
            this.txtAracHasarKaydı.Size = new System.Drawing.Size(155, 22);
            this.txtAracHasarKaydı.TabIndex = 12;
            // 
            // txtAracModel
            // 
            this.txtAracModel.Location = new System.Drawing.Point(157, 180);
            this.txtAracModel.Name = "txtAracModel";
            this.txtAracModel.Size = new System.Drawing.Size(155, 22);
            this.txtAracModel.TabIndex = 13;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(166, 382);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(137, 35);
            this.btnInsert.TabIndex = 14;
            this.btnInsert.Text = "Ekle";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(166, 423);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(137, 35);
            this.btnUpdate.TabIndex = 15;
            this.btnUpdate.Text = "Güncelleme";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(166, 464);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(137, 35);
            this.btnDelete.TabIndex = 16;
            this.btnDelete.Text = "Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(166, 505);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(137, 35);
            this.btnFind.TabIndex = 17;
            this.btnFind.Text = "Bul";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnList
            // 
            this.btnList.Location = new System.Drawing.Point(166, 341);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(137, 35);
            this.btnList.TabIndex = 20;
            this.btnList.Text = "Listele";
            this.btnList.UseVisualStyleBackColor = true;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(46, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 22);
            this.label8.TabIndex = 18;
            this.label8.Text = "İlan Durumu:";
            // 
            // txtIlanDurumu
            // 
            this.txtIlanDurumu.Location = new System.Drawing.Point(157, 264);
            this.txtIlanDurumu.Name = "txtIlanDurumu";
            this.txtIlanDurumu.Size = new System.Drawing.Size(155, 22);
            this.txtIlanDurumu.TabIndex = 19;
            // 
            // btnPlakaCagir
            // 
            this.btnPlakaCagir.Location = new System.Drawing.Point(166, 300);
            this.btnPlakaCagir.Name = "btnPlakaCagir";
            this.btnPlakaCagir.Size = new System.Drawing.Size(137, 35);
            this.btnPlakaCagir.TabIndex = 21;
            this.btnPlakaCagir.Text = "Plakaya Göre Bul";
            this.btnPlakaCagir.UseVisualStyleBackColor = true;
            this.btnPlakaCagir.Click += new System.EventHandler(this.btnPlakaCagir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(137)))), ((int)(((byte)(204)))));
            this.ClientSize = new System.Drawing.Size(1181, 552);
            this.Controls.Add(this.btnPlakaCagir);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.txtIlanDurumu);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtAracModel);
            this.Controls.Add(this.txtAracHasarKaydı);
            this.Controls.Add(this.txtAracYılı);
            this.Controls.Add(this.txtAracMarka);
            this.Controls.Add(this.txtAracFiyat);
            this.Controls.Add(this.txtAracPlaka);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "MECH Otomobil Ana Ekran";
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtAracPlaka;
        private System.Windows.Forms.TextBox txtAracFiyat;
        private System.Windows.Forms.TextBox txtAracMarka;
        private System.Windows.Forms.TextBox txtAracYılı;
        private System.Windows.Forms.TextBox txtAracHasarKaydı;
        private System.Windows.Forms.TextBox txtAracModel;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIlanDurumu;
        private System.Windows.Forms.Button btnPlakaCagir;
    }
}


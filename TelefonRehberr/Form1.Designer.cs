
namespace TelefonRehberr
{
    partial class Rehber
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Rehber));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableRehberBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonRehberDataSet = new TelefonRehberr.TelefonRehberDataSet();
            this.table_RehberTableAdapter = new TelefonRehberr.TelefonRehberDataSetTableAdapters.Table_RehberTableAdapter();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.buttonclear = new System.Windows.Forms.Button();
            this.buttondelete = new System.Windows.Forms.Button();
            this.buttonupdate = new System.Windows.Forms.Button();
            this.buttonadd = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxsoyad = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRehberBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(32, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(968, 304);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Telefonlar Rehber";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.telefonDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tableRehberBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(4, 20);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(960, 280);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "İd";
            this.idDataGridViewTextBoxColumn.HeaderText = "İd";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "Ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "Ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "Soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "Soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // telefonDataGridViewTextBoxColumn
            // 
            this.telefonDataGridViewTextBoxColumn.DataPropertyName = "Telefon";
            this.telefonDataGridViewTextBoxColumn.HeaderText = "Telefon";
            this.telefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telefonDataGridViewTextBoxColumn.Name = "telefonDataGridViewTextBoxColumn";
            this.telefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            // 
            // tableRehberBindingSource
            // 
            this.tableRehberBindingSource.DataMember = "Table_Rehber";
            this.tableRehberBindingSource.DataSource = this.telefonRehberDataSet;
            // 
            // telefonRehberDataSet
            // 
            this.telefonRehberDataSet.DataSetName = "TelefonRehberDataSet";
            this.telefonRehberDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // table_RehberTableAdapter
            // 
            this.table_RehberTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Coral;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.groupBox2.Controls.Add(this.maskedTextBox1);
            this.groupBox2.Controls.Add(this.buttonclear);
            this.groupBox2.Controls.Add(this.buttondelete);
            this.groupBox2.Controls.Add(this.buttonupdate);
            this.groupBox2.Controls.Add(this.buttonadd);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textboxmail);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textboxsoyad);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textboxad);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textboxid);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(1008, 19);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(342, 300);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Yeni Kişi";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(132, 137);
            this.maskedTextBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.maskedTextBox1.Mask = "0000000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(171, 23);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(int);
            // 
            // buttonclear
            // 
            this.buttonclear.Location = new System.Drawing.Point(177, 257);
            this.buttonclear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonclear.Name = "buttonclear";
            this.buttonclear.Size = new System.Drawing.Size(100, 28);
            this.buttonclear.TabIndex = 13;
            this.buttonclear.Text = "Temizle";
            this.buttonclear.UseVisualStyleBackColor = true;
            this.buttonclear.Click += new System.EventHandler(this.buttonclear_Click);
            // 
            // buttondelete
            // 
            this.buttondelete.Location = new System.Drawing.Point(69, 257);
            this.buttondelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttondelete.Name = "buttondelete";
            this.buttondelete.Size = new System.Drawing.Size(100, 28);
            this.buttondelete.TabIndex = 12;
            this.buttondelete.Text = "Sil";
            this.buttondelete.UseVisualStyleBackColor = true;
            this.buttondelete.Click += new System.EventHandler(this.buttondelete_Click);
            // 
            // buttonupdate
            // 
            this.buttonupdate.Location = new System.Drawing.Point(177, 222);
            this.buttonupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonupdate.Name = "buttonupdate";
            this.buttonupdate.Size = new System.Drawing.Size(100, 28);
            this.buttonupdate.TabIndex = 11;
            this.buttonupdate.Text = "Güncelle";
            this.buttonupdate.UseVisualStyleBackColor = true;
            this.buttonupdate.Click += new System.EventHandler(this.buttonupdate_Click);
            // 
            // buttonadd
            // 
            this.buttonadd.Location = new System.Drawing.Point(69, 222);
            this.buttonadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonadd.Name = "buttonadd";
            this.buttonadd.Size = new System.Drawing.Size(100, 28);
            this.buttonadd.TabIndex = 10;
            this.buttonadd.Text = "Ekle";
            this.buttonadd.UseVisualStyleBackColor = true;
            this.buttonadd.Click += new System.EventHandler(this.buttonadd_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "TELEFON NO  :";
            // 
            // textboxmail
            // 
            this.textboxmail.Location = new System.Drawing.Point(131, 169);
            this.textboxmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxmail.Name = "textboxmail";
            this.textboxmail.Size = new System.Drawing.Size(172, 23);
            this.textboxmail.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "MAİL :";
            // 
            // textboxsoyad
            // 
            this.textboxsoyad.Location = new System.Drawing.Point(132, 105);
            this.textboxsoyad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxsoyad.Name = "textboxsoyad";
            this.textboxsoyad.Size = new System.Drawing.Size(172, 23);
            this.textboxsoyad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "SOYAD :";
            // 
            // textboxad
            // 
            this.textboxad.Location = new System.Drawing.Point(132, 73);
            this.textboxad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxad.Name = "textboxad";
            this.textboxad.Size = new System.Drawing.Size(172, 23);
            this.textboxad.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD :";
            // 
            // textboxid
            // 
            this.textboxid.Location = new System.Drawing.Point(132, 41);
            this.textboxid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textboxid.Name = "textboxid";
            this.textboxid.Size = new System.Drawing.Size(172, 23);
            this.textboxid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID :";
            // 
            // Rehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Coral;
            this.ClientSize = new System.Drawing.Size(1377, 334);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Rehber";
            this.Text = "E-Telefon";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableRehberBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonRehberDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private TelefonRehberDataSet telefonRehberDataSet;
        private System.Windows.Forms.BindingSource tableRehberBindingSource;
        private TelefonRehberDataSetTableAdapters.Table_RehberTableAdapter table_RehberTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonclear;
        private System.Windows.Forms.Button buttondelete;
        private System.Windows.Forms.Button buttonupdate;
        private System.Windows.Forms.Button buttonadd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxsoyad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
    }
}


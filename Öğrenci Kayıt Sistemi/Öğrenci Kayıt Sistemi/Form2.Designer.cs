namespace Öğrenci_Kayıt_Sistemi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ögrenciIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciSOYADDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogumTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kayitTarihiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ögrenciTablesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ögrenciKayitSistemiDataSet = new Öğrenci_Kayıt_Sistemi.ÖgrenciKayitSistemiDataSet();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ögrenciTablesTableAdapter = new Öğrenci_Kayıt_Sistemi.ÖgrenciKayitSistemiDataSetTableAdapters.ÖgrenciTablesTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrenciTablesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrenciKayitSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 291);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "KAYITLAR";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ögrenciIDDataGridViewTextBoxColumn,
            this.ögrenciADDataGridViewTextBoxColumn,
            this.ögrenciSOYADDataGridViewTextBoxColumn,
            this.dogumTarihiDataGridViewTextBoxColumn,
            this.mailDataGridViewTextBoxColumn,
            this.kayitTarihiDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ögrenciTablesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(811, 256);
            this.dataGridView1.TabIndex = 0;
            // 
            // ögrenciIDDataGridViewTextBoxColumn
            // 
            this.ögrenciIDDataGridViewTextBoxColumn.DataPropertyName = "ÖgrenciID";
            this.ögrenciIDDataGridViewTextBoxColumn.HeaderText = "ÖgrenciID";
            this.ögrenciIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ögrenciIDDataGridViewTextBoxColumn.Name = "ögrenciIDDataGridViewTextBoxColumn";
            this.ögrenciIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.ögrenciIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // ögrenciADDataGridViewTextBoxColumn
            // 
            this.ögrenciADDataGridViewTextBoxColumn.DataPropertyName = "ÖgrenciAD";
            this.ögrenciADDataGridViewTextBoxColumn.HeaderText = "ÖgrenciAD";
            this.ögrenciADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ögrenciADDataGridViewTextBoxColumn.Name = "ögrenciADDataGridViewTextBoxColumn";
            this.ögrenciADDataGridViewTextBoxColumn.Width = 125;
            // 
            // ögrenciSOYADDataGridViewTextBoxColumn
            // 
            this.ögrenciSOYADDataGridViewTextBoxColumn.DataPropertyName = "ÖgrenciSOYAD";
            this.ögrenciSOYADDataGridViewTextBoxColumn.HeaderText = "ÖgrenciSOYAD";
            this.ögrenciSOYADDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ögrenciSOYADDataGridViewTextBoxColumn.Name = "ögrenciSOYADDataGridViewTextBoxColumn";
            this.ögrenciSOYADDataGridViewTextBoxColumn.Width = 125;
            // 
            // dogumTarihiDataGridViewTextBoxColumn
            // 
            this.dogumTarihiDataGridViewTextBoxColumn.DataPropertyName = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.HeaderText = "DogumTarihi";
            this.dogumTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dogumTarihiDataGridViewTextBoxColumn.Name = "dogumTarihiDataGridViewTextBoxColumn";
            this.dogumTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // mailDataGridViewTextBoxColumn
            // 
            this.mailDataGridViewTextBoxColumn.DataPropertyName = "Mail";
            this.mailDataGridViewTextBoxColumn.HeaderText = "Mail";
            this.mailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mailDataGridViewTextBoxColumn.Name = "mailDataGridViewTextBoxColumn";
            this.mailDataGridViewTextBoxColumn.Width = 125;
            // 
            // kayitTarihiDataGridViewTextBoxColumn
            // 
            this.kayitTarihiDataGridViewTextBoxColumn.DataPropertyName = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.HeaderText = "KayitTarihi";
            this.kayitTarihiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.kayitTarihiDataGridViewTextBoxColumn.Name = "kayitTarihiDataGridViewTextBoxColumn";
            this.kayitTarihiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ögrenciTablesBindingSource
            // 
            this.ögrenciTablesBindingSource.DataMember = "ÖgrenciTables";
            this.ögrenciTablesBindingSource.DataSource = this.ögrenciKayitSistemiDataSet;
            // 
            // ögrenciKayitSistemiDataSet
            // 
            this.ögrenciKayitSistemiDataSet.DataSetName = "ÖgrenciKayitSistemiDataSet";
            this.ögrenciKayitSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(2, 296);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(814, 133);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // ögrenciTablesTableAdapter
            // 
            this.ögrenciTablesTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(805, 429);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Corbel", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Öğrenci Listesi";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrenciTablesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ögrenciKayitSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private ÖgrenciKayitSistemiDataSet ögrenciKayitSistemiDataSet;
        private System.Windows.Forms.BindingSource ögrenciTablesBindingSource;
        private ÖgrenciKayitSistemiDataSetTableAdapters.ÖgrenciTablesTableAdapter ögrenciTablesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ögrenciSOYADDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogumTarihiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kayitTarihiDataGridViewTextBoxColumn;
    }
}
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iMGDBSRVDataSet = new WindowsFormsApp1.IMGDBSRVDataSet();
            this.tblFilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblFilesTableAdapter = new WindowsFormsApp1.IMGDBSRVDataSetTableAdapters.tblFilesTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtCreatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.binFileDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGDBSRVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.dtCreatedDataGridViewTextBoxColumn,
            this.binFileDataGridViewImageColumn});
            this.dataGridView1.DataSource = this.tblFilesBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(518, 394);
            this.dataGridView1.TabIndex = 0;
            // 
            // iMGDBSRVDataSet
            // 
            this.iMGDBSRVDataSet.DataSetName = "IMGDBSRVDataSet";
            this.iMGDBSRVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblFilesBindingSource
            // 
            this.tblFilesBindingSource.DataMember = "tblFiles";
            this.tblFilesBindingSource.DataSource = this.iMGDBSRVDataSet;
            // 
            // tblFilesTableAdapter
            // 
            this.tblFilesTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // dtCreatedDataGridViewTextBoxColumn
            // 
            this.dtCreatedDataGridViewTextBoxColumn.DataPropertyName = "dtCreated";
            this.dtCreatedDataGridViewTextBoxColumn.HeaderText = "dtCreated";
            this.dtCreatedDataGridViewTextBoxColumn.Name = "dtCreatedDataGridViewTextBoxColumn";
            // 
            // binFileDataGridViewImageColumn
            // 
            this.binFileDataGridViewImageColumn.DataPropertyName = "binFile";
            this.binFileDataGridViewImageColumn.HeaderText = "binFile";
            this.binFileDataGridViewImageColumn.Name = "binFileDataGridViewImageColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 394);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iMGDBSRVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFilesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private IMGDBSRVDataSet iMGDBSRVDataSet;
        private System.Windows.Forms.BindingSource tblFilesBindingSource;
        private IMGDBSRVDataSetTableAdapters.tblFilesTableAdapter tblFilesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtCreatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn binFileDataGridViewImageColumn;
    }
}


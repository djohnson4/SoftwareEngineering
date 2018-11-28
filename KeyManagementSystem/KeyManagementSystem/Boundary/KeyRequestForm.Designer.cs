namespace KeyManagementSystem.Boundary
{
    partial class KeyRequestForm
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
            this.availableKeysList = new System.Windows.Forms.DataGridView();
            this.keyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kEYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new KeyManagementSystem.Database1DataSet();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kEYTableAdapter = new KeyManagementSystem.Database1DataSetTableAdapters.KEYTableAdapter();
            this.tableAdapterManager = new KeyManagementSystem.Database1DataSetTableAdapters.TableAdapterManager();
            this.requestKey = new System.Windows.Forms.Button();
            this.logOff = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.availableKeysList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kEYBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // availableKeysList
            // 
            this.availableKeysList.AutoGenerateColumns = false;
            this.availableKeysList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.availableKeysList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyIDDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.availableKeysList.DataSource = this.kEYBindingSource;
            this.availableKeysList.Location = new System.Drawing.Point(178, 96);
            this.availableKeysList.Name = "availableKeysList";
            this.availableKeysList.Size = new System.Drawing.Size(445, 150);
            this.availableKeysList.TabIndex = 1;
            this.availableKeysList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // keyIDDataGridViewTextBoxColumn
            // 
            this.keyIDDataGridViewTextBoxColumn.DataPropertyName = "keyID";
            this.keyIDDataGridViewTextBoxColumn.HeaderText = "keyID";
            this.keyIDDataGridViewTextBoxColumn.Name = "keyIDDataGridViewTextBoxColumn";
            // 
            // lastUpdatedDataGridViewTextBoxColumn
            // 
            this.lastUpdatedDataGridViewTextBoxColumn.DataPropertyName = "lastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.HeaderText = "lastUpdated";
            this.lastUpdatedDataGridViewTextBoxColumn.Name = "lastUpdatedDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // userIDDataGridViewTextBoxColumn
            // 
            this.userIDDataGridViewTextBoxColumn.DataPropertyName = "userID";
            this.userIDDataGridViewTextBoxColumn.HeaderText = "userID";
            this.userIDDataGridViewTextBoxColumn.Name = "userIDDataGridViewTextBoxColumn";
            // 
            // kEYBindingSource
            // 
            this.kEYBindingSource.DataMember = "KEY";
            this.kEYBindingSource.DataSource = this.database1DataSet;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // kEYTableAdapter
            // 
            this.kEYTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.KEYTableAdapter = this.kEYTableAdapter;
            this.tableAdapterManager.SESSIONTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = KeyManagementSystem.Database1DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.USERTableAdapter = null;
            // 
            // requestKey
            // 
            this.requestKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestKey.Location = new System.Drawing.Point(335, 270);
            this.requestKey.Name = "requestKey";
            this.requestKey.Size = new System.Drawing.Size(126, 37);
            this.requestKey.TabIndex = 2;
            this.requestKey.Text = "Request Key";
            this.requestKey.UseVisualStyleBackColor = true;
            this.requestKey.Click += new System.EventHandler(this.button1_Click);
            // 
            // logOff
            // 
            this.logOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOff.Location = new System.Drawing.Point(358, 325);
            this.logOff.Name = "logOff";
            this.logOff.Size = new System.Drawing.Size(75, 29);
            this.logOff.TabIndex = 3;
            this.logOff.Text = "Log Off";
            this.logOff.UseVisualStyleBackColor = true;
            // 
            // KeyRequestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logOff);
            this.Controls.Add(this.requestKey);
            this.Controls.Add(this.availableKeysList);
            this.Name = "KeyRequestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Key Request & Tracking System";
            this.Load += new System.EventHandler(this.KeyRequestForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.availableKeysList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kEYBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource kEYBindingSource;
        private Database1DataSetTableAdapters.KEYTableAdapter kEYTableAdapter;
        private Database1DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView availableKeysList;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button requestKey;
        private System.Windows.Forms.Button logOff;
    }
}
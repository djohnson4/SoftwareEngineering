namespace KeyManagementSystem.Boundary
{
    partial class UpdateKeyStatusForm
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
            this.database1DataSet = new KeyManagementSystem.Database1DataSet();
            this.kEYBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kEYTableAdapter = new KeyManagementSystem.Database1DataSetTableAdapters.KEYTableAdapter();
            this.keyIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastUpdatedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.approveRequest = new System.Windows.Forms.Button();
            this.logOff = new System.Windows.Forms.Button();
            this.keyReturn = new System.Windows.Forms.Button();
            this.checkOut = new System.Windows.Forms.Button();
            this.denyRequest = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kEYBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.keyIDDataGridViewTextBoxColumn,
            this.lastUpdatedDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.userIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.kEYBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(187, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 206);
            this.dataGridView1.TabIndex = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // kEYBindingSource
            // 
            this.kEYBindingSource.DataMember = "KEY";
            this.kEYBindingSource.DataSource = this.database1DataSet;
            // 
            // kEYTableAdapter
            // 
            this.kEYTableAdapter.ClearBeforeFill = true;
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
            // approveRequest
            // 
            this.approveRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approveRequest.Location = new System.Drawing.Point(201, 293);
            this.approveRequest.Name = "approveRequest";
            this.approveRequest.Size = new System.Drawing.Size(180, 32);
            this.approveRequest.TabIndex = 1;
            this.approveRequest.Text = "Approve Request";
            this.approveRequest.UseVisualStyleBackColor = true;
            // 
            // logOff
            // 
            this.logOff.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOff.Location = new System.Drawing.Point(328, 395);
            this.logOff.Name = "logOff";
            this.logOff.Size = new System.Drawing.Size(180, 32);
            this.logOff.TabIndex = 3;
            this.logOff.Text = "Log Off";
            this.logOff.UseVisualStyleBackColor = true;
            // 
            // keyReturn
            // 
            this.keyReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.keyReturn.Location = new System.Drawing.Point(438, 348);
            this.keyReturn.Name = "keyReturn";
            this.keyReturn.Size = new System.Drawing.Size(180, 32);
            this.keyReturn.TabIndex = 4;
            this.keyReturn.Text = "Key Return";
            this.keyReturn.UseVisualStyleBackColor = true;
            // 
            // checkOut
            // 
            this.checkOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkOut.Location = new System.Drawing.Point(201, 348);
            this.checkOut.Name = "checkOut";
            this.checkOut.Size = new System.Drawing.Size(180, 32);
            this.checkOut.TabIndex = 5;
            this.checkOut.Text = "Check Out";
            this.checkOut.UseVisualStyleBackColor = true;
            // 
            // denyRequest
            // 
            this.denyRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.denyRequest.Location = new System.Drawing.Point(438, 293);
            this.denyRequest.Name = "denyRequest";
            this.denyRequest.Size = new System.Drawing.Size(180, 32);
            this.denyRequest.TabIndex = 6;
            this.denyRequest.Text = "Deny Request";
            this.denyRequest.UseVisualStyleBackColor = true;
            // 
            // UpdateKeyStatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.denyRequest);
            this.Controls.Add(this.checkOut);
            this.Controls.Add(this.keyReturn);
            this.Controls.Add(this.logOff);
            this.Controls.Add(this.approveRequest);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UpdateKeyStatusForm";
            this.Text = "Key Request & Tracking System";
            this.Load += new System.EventHandler(this.UpdateKeyStatusForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kEYBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.BindingSource kEYBindingSource;
        private Database1DataSetTableAdapters.KEYTableAdapter kEYTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn keyIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastUpdatedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button approveRequest;
        private System.Windows.Forms.Button logOff;
        private System.Windows.Forms.Button keyReturn;
        private System.Windows.Forms.Button checkOut;
        private System.Windows.Forms.Button denyRequest;
    }
}
namespace APIUI
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.groupBox4 = new System.Windows.Forms.GroupBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.textBoxIPAddress = new System.Windows.Forms.TextBox();
      this.textBoxNote = new System.Windows.Forms.TextBox();
      this.textBoxUserId = new System.Windows.Forms.TextBox();
      this.groupBox3 = new System.Windows.Forms.GroupBox();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      this.groupBox2 = new System.Windows.Forms.GroupBox();
      this.checkBoxGetTrackingNumber = new System.Windows.Forms.CheckBox();
      this.checkBoxGetSpecialPricedItems = new System.Windows.Forms.CheckBox();
      this.checkBoxGetSalesOrder = new System.Windows.Forms.CheckBox();
      this.checkBoxGetRecommendedItems = new System.Windows.Forms.CheckBox();
      this.checkBoxGetRealtimeItemStatus = new System.Windows.Forms.CheckBox();
      this.checkBoxGetMultipleItemDetail = new System.Windows.Forms.CheckBox();
      this.checkBoxGetMasterInventoryList = new System.Windows.Forms.CheckBox();
      this.checkBoxGetInventoryListChanges = new System.Windows.Forms.CheckBox();
      this.checkBoxGetImageUrls = new System.Windows.Forms.CheckBox();
      this.checkBoxGetDailySales = new System.Windows.Forms.CheckBox();
      this.checkBoxGetCommonlyReplacedItems = new System.Windows.Forms.CheckBox();
      this.checkBoxGetBomList = new System.Windows.Forms.CheckBox();
      this.checkBoxGetBomComponents = new System.Windows.Forms.CheckBox();
      this.checkBoxPostOrder = new System.Windows.Forms.CheckBox();
      this.checkBoxItem = new System.Windows.Forms.CheckBox();
      this.label4 = new System.Windows.Forms.Label();
      this.buttonLoad = new System.Windows.Forms.Button();
      this.buttonCreate = new System.Windows.Forms.Button();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.buttonReset = new System.Windows.Forms.Button();
      this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.noteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.iPAddressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.webServiceAccessBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.hspp1devo3DataSet1 = new APIUI.hspp1devo3DataSet1();
      this.webServiceAccessTableAdapter = new APIUI.hspp1devo3DataSet1TableAdapters.WebServiceAccessTableAdapter();
      this.groupBox1.SuspendLayout();
      this.groupBox4.SuspendLayout();
      this.groupBox3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.groupBox2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.webServiceAccessBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.hspp1devo3DataSet1)).BeginInit();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.groupBox4);
      this.groupBox1.Controls.Add(this.groupBox3);
      this.groupBox1.Controls.Add(this.groupBox2);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(582, 407);
      this.groupBox1.TabIndex = 5;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "User Interface";
      // 
      // groupBox4
      // 
      this.groupBox4.Controls.Add(this.label3);
      this.groupBox4.Controls.Add(this.label2);
      this.groupBox4.Controls.Add(this.label1);
      this.groupBox4.Controls.Add(this.textBoxIPAddress);
      this.groupBox4.Controls.Add(this.textBoxNote);
      this.groupBox4.Controls.Add(this.textBoxUserId);
      this.groupBox4.Location = new System.Drawing.Point(7, 268);
      this.groupBox4.Name = "groupBox4";
      this.groupBox4.Size = new System.Drawing.Size(323, 124);
      this.groupBox4.TabIndex = 2;
      this.groupBox4.TabStop = false;
      this.groupBox4.Text = "User Information";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 75);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(58, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "IP Address";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 49);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(35, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Name";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 23);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(40, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "UserID";
      // 
      // textBoxIPAddress
      // 
      this.textBoxIPAddress.Location = new System.Drawing.Point(142, 72);
      this.textBoxIPAddress.Name = "textBoxIPAddress";
      this.textBoxIPAddress.Size = new System.Drawing.Size(175, 20);
      this.textBoxIPAddress.TabIndex = 2;
      // 
      // textBoxNote
      // 
      this.textBoxNote.Location = new System.Drawing.Point(142, 46);
      this.textBoxNote.Name = "textBoxNote";
      this.textBoxNote.Size = new System.Drawing.Size(175, 20);
      this.textBoxNote.TabIndex = 1;
      // 
      // textBoxUserId
      // 
      this.textBoxUserId.Location = new System.Drawing.Point(142, 20);
      this.textBoxUserId.Name = "textBoxUserId";
      this.textBoxUserId.Size = new System.Drawing.Size(175, 20);
      this.textBoxUserId.TabIndex = 0;
      // 
      // groupBox3
      // 
      this.groupBox3.Controls.Add(this.dataGridView1);
      this.groupBox3.Location = new System.Drawing.Point(7, 20);
      this.groupBox3.Name = "groupBox3";
      this.groupBox3.Size = new System.Drawing.Size(323, 242);
      this.groupBox3.TabIndex = 1;
      this.groupBox3.TabStop = false;
      this.groupBox3.Text = "Load Existing Accounts";
      // 
      // dataGridView1
      // 
      this.dataGridView1.AllowUserToAddRows = false;
      this.dataGridView1.AllowUserToDeleteRows = false;
      this.dataGridView1.AutoGenerateColumns = false;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.noteDataGridViewTextBoxColumn,
            this.iPAddressDataGridViewTextBoxColumn});
      this.dataGridView1.DataSource = this.webServiceAccessBindingSource;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
      this.dataGridView1.Location = new System.Drawing.Point(9, 18);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.ReadOnly = true;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.dataGridView1.Size = new System.Drawing.Size(308, 218);
      this.dataGridView1.TabIndex = 0;
      // 
      // groupBox2
      // 
      this.groupBox2.Controls.Add(this.checkBoxGetTrackingNumber);
      this.groupBox2.Controls.Add(this.checkBoxGetSpecialPricedItems);
      this.groupBox2.Controls.Add(this.checkBoxGetSalesOrder);
      this.groupBox2.Controls.Add(this.checkBoxGetRecommendedItems);
      this.groupBox2.Controls.Add(this.checkBoxGetRealtimeItemStatus);
      this.groupBox2.Controls.Add(this.checkBoxGetMultipleItemDetail);
      this.groupBox2.Controls.Add(this.checkBoxGetMasterInventoryList);
      this.groupBox2.Controls.Add(this.checkBoxGetInventoryListChanges);
      this.groupBox2.Controls.Add(this.checkBoxGetImageUrls);
      this.groupBox2.Controls.Add(this.checkBoxGetDailySales);
      this.groupBox2.Controls.Add(this.checkBoxGetCommonlyReplacedItems);
      this.groupBox2.Controls.Add(this.checkBoxGetBomList);
      this.groupBox2.Controls.Add(this.checkBoxGetBomComponents);
      this.groupBox2.Controls.Add(this.checkBoxPostOrder);
      this.groupBox2.Controls.Add(this.checkBoxItem);
      this.groupBox2.Location = new System.Drawing.Point(336, 19);
      this.groupBox2.Name = "groupBox2";
      this.groupBox2.Size = new System.Drawing.Size(240, 373);
      this.groupBox2.TabIndex = 0;
      this.groupBox2.TabStop = false;
      this.groupBox2.Text = "Options";
      // 
      // checkBoxGetTrackingNumber
      // 
      this.checkBoxGetTrackingNumber.AutoSize = true;
      this.checkBoxGetTrackingNumber.Location = new System.Drawing.Point(17, 341);
      this.checkBoxGetTrackingNumber.Name = "checkBoxGetTrackingNumber";
      this.checkBoxGetTrackingNumber.Size = new System.Drawing.Size(122, 17);
      this.checkBoxGetTrackingNumber.TabIndex = 29;
      this.checkBoxGetTrackingNumber.Text = "GetTrackingNumber";
      this.checkBoxGetTrackingNumber.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetSpecialPricedItems
      // 
      this.checkBoxGetSpecialPricedItems.AutoSize = true;
      this.checkBoxGetSpecialPricedItems.Location = new System.Drawing.Point(17, 318);
      this.checkBoxGetSpecialPricedItems.Name = "checkBoxGetSpecialPricedItems";
      this.checkBoxGetSpecialPricedItems.Size = new System.Drawing.Size(133, 17);
      this.checkBoxGetSpecialPricedItems.TabIndex = 28;
      this.checkBoxGetSpecialPricedItems.Text = "GetSpecialPricedItems";
      this.checkBoxGetSpecialPricedItems.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetSalesOrder
      // 
      this.checkBoxGetSalesOrder.AutoSize = true;
      this.checkBoxGetSalesOrder.Location = new System.Drawing.Point(17, 295);
      this.checkBoxGetSalesOrder.Name = "checkBoxGetSalesOrder";
      this.checkBoxGetSalesOrder.Size = new System.Drawing.Size(95, 17);
      this.checkBoxGetSalesOrder.TabIndex = 27;
      this.checkBoxGetSalesOrder.Text = "GetSalesOrder";
      this.checkBoxGetSalesOrder.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetRecommendedItems
      // 
      this.checkBoxGetRecommendedItems.AutoSize = true;
      this.checkBoxGetRecommendedItems.Location = new System.Drawing.Point(17, 272);
      this.checkBoxGetRecommendedItems.Name = "checkBoxGetRecommendedItems";
      this.checkBoxGetRecommendedItems.Size = new System.Drawing.Size(140, 17);
      this.checkBoxGetRecommendedItems.TabIndex = 26;
      this.checkBoxGetRecommendedItems.Text = "GetRecommendedItems";
      this.checkBoxGetRecommendedItems.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetRealtimeItemStatus
      // 
      this.checkBoxGetRealtimeItemStatus.AutoSize = true;
      this.checkBoxGetRealtimeItemStatus.Location = new System.Drawing.Point(17, 249);
      this.checkBoxGetRealtimeItemStatus.Name = "checkBoxGetRealtimeItemStatus";
      this.checkBoxGetRealtimeItemStatus.Size = new System.Drawing.Size(134, 17);
      this.checkBoxGetRealtimeItemStatus.TabIndex = 25;
      this.checkBoxGetRealtimeItemStatus.Text = "GetRealtimeItemStatus";
      this.checkBoxGetRealtimeItemStatus.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetMultipleItemDetail
      // 
      this.checkBoxGetMultipleItemDetail.AutoSize = true;
      this.checkBoxGetMultipleItemDetail.Location = new System.Drawing.Point(17, 226);
      this.checkBoxGetMultipleItemDetail.Name = "checkBoxGetMultipleItemDetail";
      this.checkBoxGetMultipleItemDetail.Size = new System.Drawing.Size(126, 17);
      this.checkBoxGetMultipleItemDetail.TabIndex = 24;
      this.checkBoxGetMultipleItemDetail.Text = "GetMultipleItemDetail";
      this.checkBoxGetMultipleItemDetail.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetMasterInventoryList
      // 
      this.checkBoxGetMasterInventoryList.AutoSize = true;
      this.checkBoxGetMasterInventoryList.Location = new System.Drawing.Point(17, 203);
      this.checkBoxGetMasterInventoryList.Name = "checkBoxGetMasterInventoryList";
      this.checkBoxGetMasterInventoryList.Size = new System.Drawing.Size(135, 17);
      this.checkBoxGetMasterInventoryList.TabIndex = 23;
      this.checkBoxGetMasterInventoryList.Text = "GetMasterInventoryList";
      this.checkBoxGetMasterInventoryList.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetInventoryListChanges
      // 
      this.checkBoxGetInventoryListChanges.AutoSize = true;
      this.checkBoxGetInventoryListChanges.Location = new System.Drawing.Point(17, 180);
      this.checkBoxGetInventoryListChanges.Name = "checkBoxGetInventoryListChanges";
      this.checkBoxGetInventoryListChanges.Size = new System.Drawing.Size(145, 17);
      this.checkBoxGetInventoryListChanges.TabIndex = 22;
      this.checkBoxGetInventoryListChanges.Text = "GetInventoryListChanges";
      this.checkBoxGetInventoryListChanges.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetImageUrls
      // 
      this.checkBoxGetImageUrls.AutoSize = true;
      this.checkBoxGetImageUrls.Location = new System.Drawing.Point(17, 157);
      this.checkBoxGetImageUrls.Name = "checkBoxGetImageUrls";
      this.checkBoxGetImageUrls.Size = new System.Drawing.Size(90, 17);
      this.checkBoxGetImageUrls.TabIndex = 21;
      this.checkBoxGetImageUrls.Text = "GetImageUrls";
      this.checkBoxGetImageUrls.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetDailySales
      // 
      this.checkBoxGetDailySales.AutoSize = true;
      this.checkBoxGetDailySales.Location = new System.Drawing.Point(17, 134);
      this.checkBoxGetDailySales.Name = "checkBoxGetDailySales";
      this.checkBoxGetDailySales.Size = new System.Drawing.Size(92, 17);
      this.checkBoxGetDailySales.TabIndex = 20;
      this.checkBoxGetDailySales.Text = "GetDailySales";
      this.checkBoxGetDailySales.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetCommonlyReplacedItems
      // 
      this.checkBoxGetCommonlyReplacedItems.AutoSize = true;
      this.checkBoxGetCommonlyReplacedItems.Location = new System.Drawing.Point(17, 111);
      this.checkBoxGetCommonlyReplacedItems.Name = "checkBoxGetCommonlyReplacedItems";
      this.checkBoxGetCommonlyReplacedItems.Size = new System.Drawing.Size(162, 17);
      this.checkBoxGetCommonlyReplacedItems.TabIndex = 19;
      this.checkBoxGetCommonlyReplacedItems.Text = "GetCommonlyReplacedItems";
      this.checkBoxGetCommonlyReplacedItems.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetBomList
      // 
      this.checkBoxGetBomList.AutoSize = true;
      this.checkBoxGetBomList.Location = new System.Drawing.Point(17, 88);
      this.checkBoxGetBomList.Name = "checkBoxGetBomList";
      this.checkBoxGetBomList.Size = new System.Drawing.Size(80, 17);
      this.checkBoxGetBomList.TabIndex = 18;
      this.checkBoxGetBomList.Text = "GetBomList";
      this.checkBoxGetBomList.UseVisualStyleBackColor = true;
      // 
      // checkBoxGetBomComponents
      // 
      this.checkBoxGetBomComponents.AutoSize = true;
      this.checkBoxGetBomComponents.Location = new System.Drawing.Point(17, 65);
      this.checkBoxGetBomComponents.Name = "checkBoxGetBomComponents";
      this.checkBoxGetBomComponents.Size = new System.Drawing.Size(123, 17);
      this.checkBoxGetBomComponents.TabIndex = 17;
      this.checkBoxGetBomComponents.Text = "GetBomComponents";
      this.checkBoxGetBomComponents.UseVisualStyleBackColor = true;
      // 
      // checkBoxPostOrder
      // 
      this.checkBoxPostOrder.AutoSize = true;
      this.checkBoxPostOrder.Location = new System.Drawing.Point(17, 42);
      this.checkBoxPostOrder.Name = "checkBoxPostOrder";
      this.checkBoxPostOrder.Size = new System.Drawing.Size(73, 17);
      this.checkBoxPostOrder.TabIndex = 16;
      this.checkBoxPostOrder.Text = "PostOrder";
      this.checkBoxPostOrder.UseVisualStyleBackColor = true;
      // 
      // checkBoxItem
      // 
      this.checkBoxItem.AutoSize = true;
      this.checkBoxItem.Location = new System.Drawing.Point(17, 19);
      this.checkBoxItem.Name = "checkBoxItem";
      this.checkBoxItem.Size = new System.Drawing.Size(46, 17);
      this.checkBoxItem.TabIndex = 15;
      this.checkBoxItem.Text = "Item";
      this.checkBoxItem.UseVisualStyleBackColor = true;
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(153, 430);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(35, 13);
      this.label4.TabIndex = 10;
      this.label4.Text = "label4";
      // 
      // buttonLoad
      // 
      this.buttonLoad.Location = new System.Drawing.Point(435, 425);
      this.buttonLoad.Name = "buttonLoad";
      this.buttonLoad.Size = new System.Drawing.Size(75, 23);
      this.buttonLoad.TabIndex = 9;
      this.buttonLoad.Text = "Load";
      this.buttonLoad.UseVisualStyleBackColor = true;
      this.buttonLoad.Click += new System.EventHandler(this.buttonLoad_Click);
      // 
      // buttonCreate
      // 
      this.buttonCreate.Location = new System.Drawing.Point(516, 425);
      this.buttonCreate.Name = "buttonCreate";
      this.buttonCreate.Size = new System.Drawing.Size(75, 23);
      this.buttonCreate.TabIndex = 8;
      this.buttonCreate.Text = "Create";
      this.buttonCreate.UseVisualStyleBackColor = true;
      this.buttonCreate.Click += new System.EventHandler(this.buttonCreate_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Location = new System.Drawing.Point(12, 425);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(75, 23);
      this.buttonDelete.TabIndex = 11;
      this.buttonDelete.Text = "Delete User";
      this.buttonDelete.UseVisualStyleBackColor = true;
      this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Location = new System.Drawing.Point(94, 430);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(59, 13);
      this.label5.TabIndex = 12;
      this.label5.Text = "Record ID:";
      // 
      // buttonReset
      // 
      this.buttonReset.Location = new System.Drawing.Point(354, 425);
      this.buttonReset.Name = "buttonReset";
      this.buttonReset.Size = new System.Drawing.Size(75, 23);
      this.buttonReset.TabIndex = 13;
      this.buttonReset.Text = "Reset";
      this.buttonReset.UseVisualStyleBackColor = true;
      this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
      // 
      // userIdDataGridViewTextBoxColumn
      // 
      this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
      this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
      this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
      this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
      this.userIdDataGridViewTextBoxColumn.Width = 60;
      // 
      // noteDataGridViewTextBoxColumn
      // 
      this.noteDataGridViewTextBoxColumn.DataPropertyName = "Note";
      this.noteDataGridViewTextBoxColumn.HeaderText = "Name";
      this.noteDataGridViewTextBoxColumn.Name = "noteDataGridViewTextBoxColumn";
      this.noteDataGridViewTextBoxColumn.ReadOnly = true;
      this.noteDataGridViewTextBoxColumn.Width = 105;
      // 
      // iPAddressDataGridViewTextBoxColumn
      // 
      this.iPAddressDataGridViewTextBoxColumn.DataPropertyName = "IPAddress";
      this.iPAddressDataGridViewTextBoxColumn.HeaderText = "IPAddress";
      this.iPAddressDataGridViewTextBoxColumn.Name = "iPAddressDataGridViewTextBoxColumn";
      this.iPAddressDataGridViewTextBoxColumn.ReadOnly = true;
      // 
      // webServiceAccessBindingSource
      // 
      this.webServiceAccessBindingSource.DataMember = "WebServiceAccess";
      this.webServiceAccessBindingSource.DataSource = this.hspp1devo3DataSet1;
      // 
      // hspp1devo3DataSet1
      // 
      this.hspp1devo3DataSet1.DataSetName = "hspp1devo3DataSet1";
      this.hspp1devo3DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // webServiceAccessTableAdapter
      // 
      this.webServiceAccessTableAdapter.ClearBeforeFill = true;
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(606, 461);
      this.Controls.Add(this.buttonReset);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.buttonLoad);
      this.Controls.Add(this.buttonCreate);
      this.Controls.Add(this.groupBox1);
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Form2";
      this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
      this.Load += new System.EventHandler(this.Form2_Load);
      this.groupBox1.ResumeLayout(false);
      this.groupBox4.ResumeLayout(false);
      this.groupBox4.PerformLayout();
      this.groupBox3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.groupBox2.ResumeLayout(false);
      this.groupBox2.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.webServiceAccessBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.hspp1devo3DataSet1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxIPAddress;
		private System.Windows.Forms.TextBox textBoxNote;
		private System.Windows.Forms.TextBox textBoxUserId;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox checkBoxGetTrackingNumber;
		private System.Windows.Forms.CheckBox checkBoxGetSpecialPricedItems;
		private System.Windows.Forms.CheckBox checkBoxGetSalesOrder;
		private System.Windows.Forms.CheckBox checkBoxGetRecommendedItems;
		private System.Windows.Forms.CheckBox checkBoxGetRealtimeItemStatus;
		private System.Windows.Forms.CheckBox checkBoxGetMultipleItemDetail;
		private System.Windows.Forms.CheckBox checkBoxGetMasterInventoryList;
		private System.Windows.Forms.CheckBox checkBoxGetInventoryListChanges;
		private System.Windows.Forms.CheckBox checkBoxGetImageUrls;
		private System.Windows.Forms.CheckBox checkBoxGetDailySales;
		private System.Windows.Forms.CheckBox checkBoxGetCommonlyReplacedItems;
		private System.Windows.Forms.CheckBox checkBoxGetBomList;
		private System.Windows.Forms.CheckBox checkBoxGetBomComponents;
		private System.Windows.Forms.CheckBox checkBoxPostOrder;
		private System.Windows.Forms.CheckBox checkBoxItem;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button buttonLoad;
    private System.Windows.Forms.Button buttonCreate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button buttonReset;
    private hspp1devo3DataSet1 hspp1devo3DataSet1;
    private System.Windows.Forms.BindingSource webServiceAccessBindingSource;
    private hspp1devo3DataSet1TableAdapters.WebServiceAccessTableAdapter webServiceAccessTableAdapter;
    private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn noteDataGridViewTextBoxColumn;
    private System.Windows.Forms.DataGridViewTextBoxColumn iPAddressDataGridViewTextBoxColumn;
	}
}


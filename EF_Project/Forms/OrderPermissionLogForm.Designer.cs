namespace EF_Project.Forms
{
    partial class OrderPermissionLogForm
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
            this.orderComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.labelprod = new System.Windows.Forms.Label();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.labelsupp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // orderComboBox
            // 
            this.orderComboBox.FormattingEnabled = true;
            this.orderComboBox.Location = new System.Drawing.Point(333, 351);
            this.orderComboBox.Name = "orderComboBox";
            this.orderComboBox.Size = new System.Drawing.Size(129, 21);
            this.orderComboBox.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(241, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Order Permission";
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(333, 305);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(129, 21);
            this.productComboBox.TabIndex = 104;
            // 
            // labelprod
            // 
            this.labelprod.AutoSize = true;
            this.labelprod.Location = new System.Drawing.Point(262, 309);
            this.labelprod.Name = "labelprod";
            this.labelprod.Size = new System.Drawing.Size(44, 13);
            this.labelprod.TabIndex = 103;
            this.labelprod.Text = "Product";
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(88, 351);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(129, 21);
            this.supplierComboBox.TabIndex = 100;
            // 
            // labelsupp
            // 
            this.labelsupp.AutoSize = true;
            this.labelsupp.Location = new System.Drawing.Point(13, 355);
            this.labelsupp.Name = "labelsupp";
            this.labelsupp.Size = new System.Drawing.Size(45, 13);
            this.labelsupp.TabIndex = 99;
            this.labelsupp.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 267);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 98;
            this.label1.Tag = "";
            this.label1.Text = "Date";
            // 
            // dateTime
            // 
            this.dateTime.CustomFormat = "yyyy--MM-dd";
            this.dateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTime.Location = new System.Drawing.Point(333, 263);
            this.dateTime.Name = "dateTime";
            this.dateTime.Size = new System.Drawing.Size(129, 20);
            this.dateTime.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(286, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 25);
            this.label5.TabIndex = 96;
            this.label5.Text = "Orders Permission LOG";
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(88, 263);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(129, 21);
            this.idComboBox.TabIndex = 95;
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 267);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(562, 347);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 21);
            this.btnBack.TabIndex = 93;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(88, 305);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(129, 20);
            this.quantityTextBox.TabIndex = 91;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(672, 267);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(672, 347);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 21);
            this.btnDisplay.TabIndex = 89;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(12, 49);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(776, 175);
            this.orderDataGridView.TabIndex = 88;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(562, 267);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 21);
            this.btnAdd.TabIndex = 87;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OrderPermissionLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.orderComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.labelprod);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.labelsupp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.btnAdd);
            this.MaximumSize = new System.Drawing.Size(816, 447);
            this.MinimumSize = new System.Drawing.Size(816, 447);
            this.Name = "OrderPermissionLogForm";
            this.Text = "OrderPermissionLog";
            this.Load += new System.EventHandler(this.OrderPermissionLog_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox orderComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label labelprod;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.Label labelsupp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button btnAdd;
    }
}
namespace EF_Project.Forms
{
    partial class TransferForm
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
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.toStoreComboBox = new System.Windows.Forms.ComboBox();
            this.labelprod = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.expireDateTime = new System.Windows.Forms.DateTimePicker();
            this.supplierComboBox = new System.Windows.Forms.ComboBox();
            this.labelsupp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.productionDateTime = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.transferDataGridView = new System.Windows.Forms.DataGridView();
            this.btnTransfer = new System.Windows.Forms.Button();
            this.fromStorecomboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transferDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(398, 342);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(129, 21);
            this.productComboBox.TabIndex = 106;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 105;
            this.label7.Text = "Product Name";
            // 
            // toStoreComboBox
            // 
            this.toStoreComboBox.FormattingEnabled = true;
            this.toStoreComboBox.Location = new System.Drawing.Point(398, 296);
            this.toStoreComboBox.Name = "toStoreComboBox";
            this.toStoreComboBox.Size = new System.Drawing.Size(129, 21);
            this.toStoreComboBox.TabIndex = 104;
            // 
            // labelprod
            // 
            this.labelprod.AutoSize = true;
            this.labelprod.Location = new System.Drawing.Point(303, 300);
            this.labelprod.Name = "labelprod";
            this.labelprod.Size = new System.Drawing.Size(48, 13);
            this.labelprod.TabIndex = 103;
            this.labelprod.Text = "To Store";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(296, 393);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 102;
            this.label6.Tag = "";
            this.label6.Text = "Expire Date";
            // 
            // expireDateTime
            // 
            this.expireDateTime.CustomFormat = "yyyy--MM-dd";
            this.expireDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireDateTime.Location = new System.Drawing.Point(398, 389);
            this.expireDateTime.Name = "expireDateTime";
            this.expireDateTime.Size = new System.Drawing.Size(129, 20);
            this.expireDateTime.TabIndex = 101;
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(121, 346);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(129, 21);
            this.supplierComboBox.TabIndex = 100;
            // 
            // labelsupp
            // 
            this.labelsupp.AutoSize = true;
            this.labelsupp.Location = new System.Drawing.Point(45, 350);
            this.labelsupp.Name = "labelsupp";
            this.labelsupp.Size = new System.Drawing.Size(45, 13);
            this.labelsupp.TabIndex = 99;
            this.labelsupp.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 397);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 98;
            this.label1.Tag = "";
            this.label1.Text = "Production Date";
            // 
            // productionDateTime
            // 
            this.productionDateTime.CustomFormat = "yyyy--MM-dd";
            this.productionDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.productionDateTime.Location = new System.Drawing.Point(121, 393);
            this.productionDateTime.Name = "productionDateTime";
            this.productionDateTime.Size = new System.Drawing.Size(129, 20);
            this.productionDateTime.TabIndex = 97;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(339, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 25);
            this.label5.TabIndex = 96;
            this.label5.Text = "Transfers";
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(121, 259);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(129, 21);
            this.idComboBox.TabIndex = 95;
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 94;
            this.label4.Text = "ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(601, 356);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(77, 33);
            this.btnBack.TabIndex = 93;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(304, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 92;
            this.label3.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(398, 255);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(129, 20);
            this.quantityTextBox.TabIndex = 91;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(711, 271);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(77, 33);
            this.btnUpdate.TabIndex = 90;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(711, 356);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(77, 33);
            this.btnDisplay.TabIndex = 89;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // transferDataGridView
            // 
            this.transferDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transferDataGridView.Location = new System.Drawing.Point(12, 52);
            this.transferDataGridView.Name = "transferDataGridView";
            this.transferDataGridView.Size = new System.Drawing.Size(776, 175);
            this.transferDataGridView.TabIndex = 88;
            // 
            // btnTransfer
            // 
            this.btnTransfer.Location = new System.Drawing.Point(601, 271);
            this.btnTransfer.Name = "btnTransfer";
            this.btnTransfer.Size = new System.Drawing.Size(77, 33);
            this.btnTransfer.TabIndex = 87;
            this.btnTransfer.Text = "Transfer";
            this.btnTransfer.UseVisualStyleBackColor = true;
            this.btnTransfer.Click += new System.EventHandler(this.btnTransfer_Click);
            // 
            // fromStorecomboBox
            // 
            this.fromStorecomboBox.FormattingEnabled = true;
            this.fromStorecomboBox.Location = new System.Drawing.Point(121, 300);
            this.fromStorecomboBox.Name = "fromStorecomboBox";
            this.fromStorecomboBox.Size = new System.Drawing.Size(129, 21);
            this.fromStorecomboBox.TabIndex = 108;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 107;
            this.label2.Text = "From Store";
            // 
            // TransferForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 464);
            this.Controls.Add(this.fromStorecomboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.productComboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.toStoreComboBox);
            this.Controls.Add(this.labelprod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.expireDateTime);
            this.Controls.Add(this.supplierComboBox);
            this.Controls.Add(this.labelsupp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.productionDateTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.transferDataGridView);
            this.Controls.Add(this.btnTransfer);
            this.MaximumSize = new System.Drawing.Size(835, 503);
            this.MinimumSize = new System.Drawing.Size(835, 503);
            this.Name = "TransferForm";
            this.Text = "TransferForm";
            this.Load += new System.EventHandler(this.TransferForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.transferDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox toStoreComboBox;
        private System.Windows.Forms.Label labelprod;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker expireDateTime;
        private System.Windows.Forms.ComboBox supplierComboBox;
        private System.Windows.Forms.Label labelsupp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker productionDateTime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView transferDataGridView;
        private System.Windows.Forms.Button btnTransfer;
        private System.Windows.Forms.ComboBox fromStorecomboBox;
        private System.Windows.Forms.Label label2;
    }
}
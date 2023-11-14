namespace EF_Project.Forms
{
    partial class SupplyPermissionLogForm
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
            this.suppPerLogDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.expireDateTime = new System.Windows.Forms.DateTimePicker();
            this.productComboBox = new System.Windows.Forms.ComboBox();
            this.labelprod = new System.Windows.Forms.Label();
            this.suppPercomboBox = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.suppPerLogDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // supplierComboBox
            // 
            this.supplierComboBox.FormattingEnabled = true;
            this.supplierComboBox.Location = new System.Drawing.Point(88, 352);
            this.supplierComboBox.Name = "supplierComboBox";
            this.supplierComboBox.Size = new System.Drawing.Size(129, 21);
            this.supplierComboBox.TabIndex = 80;
            // 
            // labelsupp
            // 
            this.labelsupp.AutoSize = true;
            this.labelsupp.Location = new System.Drawing.Point(13, 356);
            this.labelsupp.Name = "labelsupp";
            this.labelsupp.Size = new System.Drawing.Size(45, 13);
            this.labelsupp.TabIndex = 79;
            this.labelsupp.Text = "Supplier";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 262);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 78;
            this.label1.Tag = "";
            this.label1.Text = "Production Date";
            // 
            // productionDateTime
            // 
            this.productionDateTime.CustomFormat = "yyyy--MM-dd";
            this.productionDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.productionDateTime.Location = new System.Drawing.Point(368, 258);
            this.productionDateTime.Name = "productionDateTime";
            this.productionDateTime.Size = new System.Drawing.Size(129, 20);
            this.productionDateTime.TabIndex = 77;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(286, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 25);
            this.label5.TabIndex = 76;
            this.label5.Text = "Supply Permission LOG";
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(88, 258);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(129, 21);
            this.idComboBox.TabIndex = 75;
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 73;
            this.label4.Text = "ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(562, 352);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 21);
            this.btnBack.TabIndex = 72;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 71;
            this.label3.Text = "Quantity";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(88, 300);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(129, 20);
            this.quantityTextBox.TabIndex = 69;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(672, 300);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 21);
            this.btnUpdate.TabIndex = 68;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(672, 352);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 21);
            this.btnDisplay.TabIndex = 67;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // suppPerLogDataGridView
            // 
            this.suppPerLogDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.suppPerLogDataGridView.Location = new System.Drawing.Point(12, 44);
            this.suppPerLogDataGridView.Name = "suppPerLogDataGridView";
            this.suppPerLogDataGridView.Size = new System.Drawing.Size(776, 175);
            this.suppPerLogDataGridView.TabIndex = 66;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(562, 300);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 21);
            this.btnAdd.TabIndex = 65;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(550, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 82;
            this.label6.Tag = "";
            this.label6.Text = "Expire Date";
            // 
            // expireDateTime
            // 
            this.expireDateTime.CustomFormat = "yyyy--MM-dd";
            this.expireDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireDateTime.Location = new System.Drawing.Point(634, 258);
            this.expireDateTime.Name = "expireDateTime";
            this.expireDateTime.Size = new System.Drawing.Size(129, 20);
            this.expireDateTime.TabIndex = 81;
            // 
            // productComboBox
            // 
            this.productComboBox.FormattingEnabled = true;
            this.productComboBox.Location = new System.Drawing.Point(368, 300);
            this.productComboBox.Name = "productComboBox";
            this.productComboBox.Size = new System.Drawing.Size(129, 21);
            this.productComboBox.TabIndex = 84;
            // 
            // labelprod
            // 
            this.labelprod.AutoSize = true;
            this.labelprod.Location = new System.Drawing.Point(285, 304);
            this.labelprod.Name = "labelprod";
            this.labelprod.Size = new System.Drawing.Size(44, 13);
            this.labelprod.TabIndex = 83;
            this.labelprod.Text = "Product";
            // 
            // suppPercomboBox
            // 
            this.suppPercomboBox.FormattingEnabled = true;
            this.suppPercomboBox.Location = new System.Drawing.Point(368, 352);
            this.suppPercomboBox.Name = "suppPercomboBox";
            this.suppPercomboBox.Size = new System.Drawing.Size(129, 21);
            this.suppPercomboBox.TabIndex = 86;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(260, 349);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 26);
            this.label7.TabIndex = 85;
            this.label7.Text = "Supply Permission \r\n        Serial\r\n";
            // 
            // SupplyPermissionLogForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.suppPercomboBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.productComboBox);
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
            this.Controls.Add(this.suppPerLogDataGridView);
            this.Controls.Add(this.btnAdd);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 447);
            this.Name = "SupplyPermissionLogForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupplyPermissionLog";
            this.Load += new System.EventHandler(this.SupplyPermissionLogForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.suppPerLogDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.DataGridView suppPerLogDataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker expireDateTime;
        private System.Windows.Forms.ComboBox productComboBox;
        private System.Windows.Forms.Label labelprod;
        private System.Windows.Forms.ComboBox suppPercomboBox;
        private System.Windows.Forms.Label label7;
    }
}
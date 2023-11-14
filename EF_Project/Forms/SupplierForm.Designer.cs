namespace EF_Project.Forms
{
    partial class SupplierForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.supplierDataGridView = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.faxTextBox = new System.Windows.Forms.TextBox();
            this.mobileTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(345, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Supplier";
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(89, 284);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(129, 21);
            this.idComboBox.TabIndex = 45;
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 288);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 43;
            this.label4.Text = "ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(259, 444);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 42;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(89, 337);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(129, 20);
            this.nameTextBox.TabIndex = 38;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(419, 386);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 37;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(419, 444);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 36;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // supplierDataGridView
            // 
            this.supplierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDataGridView.Location = new System.Drawing.Point(12, 28);
            this.supplierDataGridView.Name = "supplierDataGridView";
            this.supplierDataGridView.Size = new System.Drawing.Size(776, 236);
            this.supplierDataGridView.TabIndex = 35;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(20, 341);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 33;
            this.labelName.Text = "Name";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(259, 386);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 34;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(264, 288);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(264, 341);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Mobile";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(333, 284);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(129, 20);
            this.phoneTextBox.TabIndex = 47;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 55;
            this.label7.Text = "Fax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(542, 288);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Mail";
            // 
            // urlTextBox
            // 
            this.urlTextBox.Location = new System.Drawing.Point(89, 389);
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Size = new System.Drawing.Size(129, 20);
            this.urlTextBox.TabIndex = 52;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 51;
            this.label9.Text = "URL";
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(610, 281);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(129, 20);
            this.mailTextBox.TabIndex = 56;
            // 
            // faxTextBox
            // 
            this.faxTextBox.Location = new System.Drawing.Point(610, 341);
            this.faxTextBox.Name = "faxTextBox";
            this.faxTextBox.Size = new System.Drawing.Size(129, 20);
            this.faxTextBox.TabIndex = 58;
            // 
            // mobileTextBox
            // 
            this.mobileTextBox.Location = new System.Drawing.Point(333, 338);
            this.mobileTextBox.Name = "mobileTextBox";
            this.mobileTextBox.Size = new System.Drawing.Size(129, 20);
            this.mobileTextBox.TabIndex = 60;
            // 
            // SupplierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 511);
            this.Controls.Add(this.mobileTextBox);
            this.Controls.Add(this.faxTextBox);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.urlTextBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.supplierDataGridView);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnAdd);
            this.MaximumSize = new System.Drawing.Size(804, 550);
            this.MinimumSize = new System.Drawing.Size(804, 550);
            this.Name = "SupplierForm";
            this.Text = "SupplierForm";
            this.Load += new System.EventHandler(this.SupplierForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.supplierDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView supplierDataGridView;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox mailTextBox;
        private System.Windows.Forms.TextBox faxTextBox;
        private System.Windows.Forms.TextBox mobileTextBox;
    }
}
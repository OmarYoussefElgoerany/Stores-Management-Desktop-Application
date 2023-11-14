namespace EF_Project.Forms
{
    partial class OrderPermissionForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.storeIDComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.serialTextBox = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.orderDataGridView = new System.Windows.Forms.DataGridView();
            this.btnAdd = new System.Windows.Forms.Button();
            this.customerCmboBox = new System.Windows.Forms.ComboBox();
            this.Customer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 62;
            this.label1.Text = "Date";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "yyyy--MM-dd";
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(107, 287);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(124, 20);
            this.dateTimePicker.TabIndex = 61;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(286, 11);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 25);
            this.label5.TabIndex = 60;
            this.label5.Text = "Order Permission";
            // 
            // idComboBox
            // 
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(105, 95);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(129, 21);
            this.idComboBox.TabIndex = 59;
            this.idComboBox.SelectedIndexChanged += new System.EventHandler(this.idComboBox_SelectedIndexChanged);
            // 
            // storeIDComboBox
            // 
            this.storeIDComboBox.FormattingEnabled = true;
            this.storeIDComboBox.Location = new System.Drawing.Point(105, 192);
            this.storeIDComboBox.Name = "storeIDComboBox";
            this.storeIDComboBox.Size = new System.Drawing.Size(129, 21);
            this.storeIDComboBox.TabIndex = 58;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "ID";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(291, 417);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 56;
            this.btnBack.Text = " Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "SerialNumber";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Store Name";
            // 
            // serialTextBox
            // 
            this.serialTextBox.Location = new System.Drawing.Point(105, 142);
            this.serialTextBox.Name = "serialTextBox";
            this.serialTextBox.Size = new System.Drawing.Size(129, 20);
            this.serialTextBox.TabIndex = 53;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(516, 345);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 52;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(516, 417);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 51;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // orderDataGridView
            // 
            this.orderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderDataGridView.Location = new System.Drawing.Point(274, 62);
            this.orderDataGridView.Name = "orderDataGridView";
            this.orderDataGridView.Size = new System.Drawing.Size(514, 246);
            this.orderDataGridView.TabIndex = 50;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 345);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 49;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // customerCmboBox
            // 
            this.customerCmboBox.FormattingEnabled = true;
            this.customerCmboBox.Location = new System.Drawing.Point(105, 242);
            this.customerCmboBox.Name = "customerCmboBox";
            this.customerCmboBox.Size = new System.Drawing.Size(129, 21);
            this.customerCmboBox.TabIndex = 64;
            // 
            // Customer
            // 
            this.Customer.AutoSize = true;
            this.Customer.Location = new System.Drawing.Point(6, 246);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(82, 13);
            this.Customer.TabIndex = 63;
            this.Customer.Text = "Customer Name";
            // 
            // OrderPermissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.customerCmboBox);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(this.storeIDComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.serialTextBox);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.orderDataGridView);
            this.Controls.Add(this.btnAdd);
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "OrderPermissionForm";
            this.Text = "OrderPermissionForm";
            this.Load += new System.EventHandler(this.OrderPermissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.ComboBox storeIDComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox serialTextBox;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.DataGridView orderDataGridView;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox customerCmboBox;
        private System.Windows.Forms.Label Customer;
    }
}
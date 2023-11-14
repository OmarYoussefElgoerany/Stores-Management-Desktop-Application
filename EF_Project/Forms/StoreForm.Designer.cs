namespace EF_Project
{
    partial class StoreForm
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.storeDataGridView = new System.Windows.Forms.DataGridView();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.NametextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(241, 293);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(16, 123);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name";
            // 
            // storeDataGridView
            // 
            this.storeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.storeDataGridView.Location = new System.Drawing.Point(229, 36);
            this.storeDataGridView.Name = "storeDataGridView";
            this.storeDataGridView.Size = new System.Drawing.Size(397, 223);
            this.storeDataGridView.TabIndex = 4;
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(469, 365);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(75, 23);
            this.btnDisplay.TabIndex = 5;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(469, 293);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 6;
            this.btnEdit.Text = "Update";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // NametextBox
            // 
            this.NametextBox.Location = new System.Drawing.Point(85, 123);
            this.NametextBox.Name = "NametextBox";
            this.NametextBox.Size = new System.Drawing.Size(129, 20);
            this.NametextBox.TabIndex = 7;
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(85, 165);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(129, 20);
            this.addressTextBox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Manger";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Address";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(244, 365);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "ID";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(85, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(129, 21);
            this.comboBox1.TabIndex = 16;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(85, 82);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(129, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label5.Location = new System.Drawing.Point(224, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Stores";
            // 
            // StoreForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(634, 461);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.NametextBox);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.storeDataGridView);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnAdd);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(650, 500);
            this.MinimumSize = new System.Drawing.Size(650, 500);
            this.Name = "StoreForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StoreForm";
            this.Load += new System.EventHandler(this.StoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.storeDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.DataGridView storeDataGridView;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.TextBox NametextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label5;
    }
}
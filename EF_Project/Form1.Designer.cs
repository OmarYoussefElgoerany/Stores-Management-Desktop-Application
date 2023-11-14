namespace EF_Project
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.sectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.store = new System.Windows.Forms.ToolStripMenuItem();
            this.product = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSupplier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyPermissionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supplyPermissionLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orrderPermissionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.orderPermissionLogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.permComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.storecomboBox = new System.Windows.Forms.ComboBox();
            this.btnShowEachStore = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnShowDate = new System.Windows.Forms.Button();
            this.btnShowAllProd = new System.Windows.Forms.Button();
            this.prodComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.proddateTime = new System.Windows.Forms.DateTimePicker();
            this.btnShowProd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnShowDteTrans = new System.Windows.Forms.Button();
            this.btnShowAllTrns = new System.Windows.Forms.Button();
            this.storeTransfercomboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.transferDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnShowTrns = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.productCmboBxExpire = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.expireDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnShowExpire = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectionToolStripMenuItem,
            this.editToolStripMenuItem,
            this.transferMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(868, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // sectionToolStripMenuItem
            // 
            this.sectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.store,
            this.product,
            this.MenuSupplier,
            this.menuCustomer});
            this.sectionToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            this.sectionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.sectionToolStripMenuItem.Text = "Sections";
            // 
            // store
            // 
            this.store.Name = "store";
            this.store.Size = new System.Drawing.Size(128, 22);
            this.store.Text = "Store";
            this.store.Click += new System.EventHandler(this.store_Click);
            // 
            // product
            // 
            this.product.Name = "product";
            this.product.Size = new System.Drawing.Size(128, 22);
            this.product.Text = "Product";
            this.product.Click += new System.EventHandler(this.product_Click);
            // 
            // MenuSupplier
            // 
            this.MenuSupplier.Name = "MenuSupplier";
            this.MenuSupplier.Size = new System.Drawing.Size(128, 22);
            this.MenuSupplier.Text = "Supplier";
            this.MenuSupplier.Click += new System.EventHandler(this.MenuSupplier_Click);
            // 
            // menuCustomer
            // 
            this.menuCustomer.Name = "menuCustomer";
            this.menuCustomer.Size = new System.Drawing.Size(128, 22);
            this.menuCustomer.Text = "Customer";
            this.menuCustomer.Click += new System.EventHandler(this.menuCustomer_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supplyPermissionMenu,
            this.supplyPermissionLogToolStripMenuItem,
            this.orrderPermissionMenu,
            this.orderPermissionLogToolStripMenuItem});
            this.editToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.editToolStripMenuItem.Text = "Permissions";
            // 
            // supplyPermissionMenu
            // 
            this.supplyPermissionMenu.Name = "supplyPermissionMenu";
            this.supplyPermissionMenu.Size = new System.Drawing.Size(191, 22);
            this.supplyPermissionMenu.Text = "SupplyPermission";
            this.supplyPermissionMenu.Click += new System.EventHandler(this.supplyPermissionMenu_Click);
            // 
            // supplyPermissionLogToolStripMenuItem
            // 
            this.supplyPermissionLogToolStripMenuItem.Name = "supplyPermissionLogToolStripMenuItem";
            this.supplyPermissionLogToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.supplyPermissionLogToolStripMenuItem.Text = "SupplyPermissionLog";
            this.supplyPermissionLogToolStripMenuItem.Click += new System.EventHandler(this.supplyPermissionLogToolStripMenuItem_Click);
            // 
            // orrderPermissionMenu
            // 
            this.orrderPermissionMenu.Name = "orrderPermissionMenu";
            this.orrderPermissionMenu.Size = new System.Drawing.Size(191, 22);
            this.orrderPermissionMenu.Text = "OrderPermission";
            this.orrderPermissionMenu.Click += new System.EventHandler(this.orrderPermissionMenu_Click);
            // 
            // orderPermissionLogToolStripMenuItem
            // 
            this.orderPermissionLogToolStripMenuItem.Name = "orderPermissionLogToolStripMenuItem";
            this.orderPermissionLogToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.orderPermissionLogToolStripMenuItem.Text = "OrderPermissionLog";
            this.orderPermissionLogToolStripMenuItem.Click += new System.EventHandler(this.orderPermissionLogToolStripMenuItem_Click);
            // 
            // transferMenuItem
            // 
            this.transferMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.transferMenuItem.Name = "transferMenuItem";
            this.transferMenuItem.Size = new System.Drawing.Size(70, 20);
            this.transferMenuItem.Text = "Transfers";
            this.transferMenuItem.Click += new System.EventHandler(this.transferMenuItem_Click);
            // 
            // formDateTimePicker
            // 
            this.formDateTimePicker.Location = new System.Drawing.Point(668, 27);
            this.formDateTimePicker.Name = "formDateTimePicker";
            this.formDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.formDateTimePicker.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnShowAll);
            this.groupBox1.Controls.Add(this.permComboBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.storecomboBox);
            this.groupBox1.Controls.Add(this.btnShowEachStore);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 53);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 73);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report of Each Store";
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(652, 36);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(75, 23);
            this.btnShowAll.TabIndex = 8;
            this.btnShowAll.Text = "ShowAll";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // permComboBox
            // 
            this.permComboBox.FormattingEnabled = true;
            this.permComboBox.Location = new System.Drawing.Point(146, 38);
            this.permComboBox.Name = "permComboBox";
            this.permComboBox.Size = new System.Drawing.Size(121, 21);
            this.permComboBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Choose Permission";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose Store";
            // 
            // storecomboBox
            // 
            this.storecomboBox.FormattingEnabled = true;
            this.storecomboBox.Location = new System.Drawing.Point(383, 38);
            this.storecomboBox.Name = "storecomboBox";
            this.storecomboBox.Size = new System.Drawing.Size(121, 21);
            this.storecomboBox.TabIndex = 3;
            // 
            // btnShowEachStore
            // 
            this.btnShowEachStore.Location = new System.Drawing.Point(760, 36);
            this.btnShowEachStore.Name = "btnShowEachStore";
            this.btnShowEachStore.Size = new System.Drawing.Size(75, 23);
            this.btnShowEachStore.TabIndex = 0;
            this.btnShowEachStore.Text = "Show";
            this.btnShowEachStore.UseVisualStyleBackColor = true;
            this.btnShowEachStore.Click += new System.EventHandler(this.btnShowEachStore_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 339);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(847, 154);
            this.dataGridView1.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnShowDate);
            this.groupBox2.Controls.Add(this.btnShowAllProd);
            this.groupBox2.Controls.Add(this.prodComboBox);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.proddateTime);
            this.groupBox2.Controls.Add(this.btnShowProd);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(856, 63);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Report For Each Prodcut";
            // 
            // btnShowDate
            // 
            this.btnShowDate.Location = new System.Drawing.Point(522, 26);
            this.btnShowDate.Name = "btnShowDate";
            this.btnShowDate.Size = new System.Drawing.Size(105, 23);
            this.btnShowDate.TabIndex = 9;
            this.btnShowDate.Text = "ShowWithDate";
            this.btnShowDate.UseVisualStyleBackColor = true;
            this.btnShowDate.Click += new System.EventHandler(this.btnShowDate_Click);
            // 
            // btnShowAllProd
            // 
            this.btnShowAllProd.Location = new System.Drawing.Point(653, 26);
            this.btnShowAllProd.Name = "btnShowAllProd";
            this.btnShowAllProd.Size = new System.Drawing.Size(75, 23);
            this.btnShowAllProd.TabIndex = 8;
            this.btnShowAllProd.Text = "ShowAll";
            this.btnShowAllProd.UseVisualStyleBackColor = true;
            this.btnShowAllProd.Click += new System.EventHandler(this.btnShowAllProd_Click);
            // 
            // prodComboBox
            // 
            this.prodComboBox.FormattingEnabled = true;
            this.prodComboBox.Location = new System.Drawing.Point(146, 26);
            this.prodComboBox.Name = "prodComboBox";
            this.prodComboBox.Size = new System.Drawing.Size(121, 21);
            this.prodComboBox.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Choose Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Date";
            // 
            // proddateTime
            // 
            this.proddateTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.proddateTime.CustomFormat = "yyyy-dd--MM";
            this.proddateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.proddateTime.Location = new System.Drawing.Point(349, 27);
            this.proddateTime.Name = "proddateTime";
            this.proddateTime.Size = new System.Drawing.Size(121, 20);
            this.proddateTime.TabIndex = 1;
            // 
            // btnShowProd
            // 
            this.btnShowProd.Location = new System.Drawing.Point(745, 26);
            this.btnShowProd.Name = "btnShowProd";
            this.btnShowProd.Size = new System.Drawing.Size(75, 23);
            this.btnShowProd.TabIndex = 0;
            this.btnShowProd.Text = "Show";
            this.btnShowProd.UseVisualStyleBackColor = true;
            this.btnShowProd.Click += new System.EventHandler(this.btnShowProd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnShowDteTrans);
            this.groupBox3.Controls.Add(this.btnShowAllTrns);
            this.groupBox3.Controls.Add(this.storeTransfercomboBox);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.transferDateTime);
            this.groupBox3.Controls.Add(this.btnShowTrns);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(0, 201);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(856, 63);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Report For Each Product Transfer";
            // 
            // btnShowDteTrans
            // 
            this.btnShowDteTrans.Location = new System.Drawing.Point(522, 26);
            this.btnShowDteTrans.Name = "btnShowDteTrans";
            this.btnShowDteTrans.Size = new System.Drawing.Size(105, 23);
            this.btnShowDteTrans.TabIndex = 9;
            this.btnShowDteTrans.Text = "ShowWithDate";
            this.btnShowDteTrans.UseVisualStyleBackColor = true;
            this.btnShowDteTrans.Click += new System.EventHandler(this.btnShowDteTrans_Click);
            // 
            // btnShowAllTrns
            // 
            this.btnShowAllTrns.Location = new System.Drawing.Point(653, 26);
            this.btnShowAllTrns.Name = "btnShowAllTrns";
            this.btnShowAllTrns.Size = new System.Drawing.Size(75, 23);
            this.btnShowAllTrns.TabIndex = 8;
            this.btnShowAllTrns.Text = "ShowAll";
            this.btnShowAllTrns.UseVisualStyleBackColor = true;
            this.btnShowAllTrns.Click += new System.EventHandler(this.btnShowAllTrns_Click);
            // 
            // storeTransfercomboBox
            // 
            this.storeTransfercomboBox.FormattingEnabled = true;
            this.storeTransfercomboBox.Location = new System.Drawing.Point(146, 26);
            this.storeTransfercomboBox.Name = "storeTransfercomboBox";
            this.storeTransfercomboBox.Size = new System.Drawing.Size(121, 21);
            this.storeTransfercomboBox.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose Store";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Date";
            // 
            // transferDateTime
            // 
            this.transferDateTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.transferDateTime.CustomFormat = "yyyy-dd--MM";
            this.transferDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.transferDateTime.Location = new System.Drawing.Point(349, 27);
            this.transferDateTime.Name = "transferDateTime";
            this.transferDateTime.Size = new System.Drawing.Size(121, 20);
            this.transferDateTime.TabIndex = 1;
            // 
            // btnShowTrns
            // 
            this.btnShowTrns.Location = new System.Drawing.Point(745, 26);
            this.btnShowTrns.Name = "btnShowTrns";
            this.btnShowTrns.Size = new System.Drawing.Size(75, 23);
            this.btnShowTrns.TabIndex = 0;
            this.btnShowTrns.Text = "Show";
            this.btnShowTrns.UseVisualStyleBackColor = true;
            this.btnShowTrns.Click += new System.EventHandler(this.btnShowTrns_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button1);
            this.groupBox4.Controls.Add(this.productCmboBxExpire);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.expireDateTime);
            this.groupBox4.Controls.Add(this.btnShowExpire);
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(0, 270);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(856, 63);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Report For Products Expiration ";
            // 
            // productCmboBxExpire
            // 
            this.productCmboBxExpire.FormattingEnabled = true;
            this.productCmboBxExpire.Location = new System.Drawing.Point(146, 27);
            this.productCmboBxExpire.Name = "productCmboBxExpire";
            this.productCmboBxExpire.Size = new System.Drawing.Size(121, 21);
            this.productCmboBxExpire.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Choose Product";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 31);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Expire Date";
            // 
            // expireDateTime
            // 
            this.expireDateTime.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.expireDateTime.CustomFormat = "yyyy-dd--MM";
            this.expireDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.expireDateTime.Location = new System.Drawing.Point(383, 26);
            this.expireDateTime.Name = "expireDateTime";
            this.expireDateTime.Size = new System.Drawing.Size(121, 20);
            this.expireDateTime.TabIndex = 1;
            // 
            // btnShowExpire
            // 
            this.btnShowExpire.Location = new System.Drawing.Point(745, 27);
            this.btnShowExpire.Name = "btnShowExpire";
            this.btnShowExpire.Size = new System.Drawing.Size(75, 23);
            this.btnShowExpire.TabIndex = 0;
            this.btnShowExpire.Text = "Show";
            this.btnShowExpire.UseVisualStyleBackColor = true;
            this.btnShowExpire.Click += new System.EventHandler(this.btnShowExpire_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(622, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 24);
            this.button1.TabIndex = 9;
            this.button1.Text = "ShowAll";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 505);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.formDateTimePicker);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximumSize = new System.Drawing.Size(884, 544);
            this.MinimumSize = new System.Drawing.Size(884, 544);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem store;
        private System.Windows.Forms.ToolStripMenuItem product;
        private System.Windows.Forms.ToolStripMenuItem MenuSupplier;
        private System.Windows.Forms.ToolStripMenuItem menuCustomer;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem supplyPermissionMenu;
        private System.Windows.Forms.ToolStripMenuItem orrderPermissionMenu;
        private System.Windows.Forms.ToolStripMenuItem transferMenuItem;
        private System.Windows.Forms.DateTimePicker formDateTimePicker;
        private System.Windows.Forms.ToolStripMenuItem supplyPermissionLogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderPermissionLogToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnShowEachStore;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox storecomboBox;
        private System.Windows.Forms.ComboBox permComboBox;
        private System.Windows.Forms.Button btnShowAll;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnShowAllProd;
        private System.Windows.Forms.ComboBox prodComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker proddateTime;
        private System.Windows.Forms.Button btnShowProd;
        private System.Windows.Forms.Button btnShowDate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnShowDteTrans;
        private System.Windows.Forms.Button btnShowAllTrns;
        private System.Windows.Forms.ComboBox storeTransfercomboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker transferDateTime;
        private System.Windows.Forms.Button btnShowTrns;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox productCmboBxExpire;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker expireDateTime;
        private System.Windows.Forms.Button btnShowExpire;
        private System.Windows.Forms.Button button1;
    }
}


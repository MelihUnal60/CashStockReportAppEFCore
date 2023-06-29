namespace CashStockReportApp.Presentation.WinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtPrdName = new TextBox();
            txtPrdPrice = new TextBox();
            txtPrdAmt = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cbbPrdCtg = new ComboBox();
            btnAddPrd = new Button();
            txtCashierName = new TextBox();
            txtCashierGender = new TextBox();
            txtCashierSurname = new TextBox();
            txtCashierHDate = new TextBox();
            btnAddCashier = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            button2 = new Button();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            textBox12 = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            grdPrd = new DataGridView();
            grdOrders = new DataGridView();
            grdInvoices = new DataGridView();
            txtNewCtg = new TextBox();
            label21 = new Label();
            btnAddCtg = new Button();
            ((System.ComponentModel.ISupportInitialize)grdPrd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdInvoices).BeginInit();
            SuspendLayout();
            // 
            // txtPrdName
            // 
            txtPrdName.Location = new Point(350, 41);
            txtPrdName.Name = "txtPrdName";
            txtPrdName.Size = new Size(151, 27);
            txtPrdName.TabIndex = 0;
            // 
            // txtPrdPrice
            // 
            txtPrdPrice.Location = new Point(350, 138);
            txtPrdPrice.Name = "txtPrdPrice";
            txtPrdPrice.Size = new Size(151, 27);
            txtPrdPrice.TabIndex = 1;
            // 
            // txtPrdAmt
            // 
            txtPrdAmt.Location = new Point(350, 88);
            txtPrdAmt.Name = "txtPrdAmt";
            txtPrdAmt.Size = new Size(151, 27);
            txtPrdAmt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(272, 41);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(272, 138);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 4;
            label2.Text = "Fiyat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(272, 88);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(272, 191);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 6;
            label4.Text = "Kategori";
            // 
            // cbbPrdCtg
            // 
            cbbPrdCtg.FormattingEnabled = true;
            cbbPrdCtg.Location = new Point(350, 191);
            cbbPrdCtg.Name = "cbbPrdCtg";
            cbbPrdCtg.Size = new Size(151, 28);
            cbbPrdCtg.TabIndex = 7;
            // 
            // btnAddPrd
            // 
            btnAddPrd.Location = new Point(350, 240);
            btnAddPrd.Name = "btnAddPrd";
            btnAddPrd.Size = new Size(151, 29);
            btnAddPrd.TabIndex = 8;
            btnAddPrd.Text = "Ürün Ekle";
            btnAddPrd.UseVisualStyleBackColor = true;
            btnAddPrd.Click += btnAddPrd_Click;
            // 
            // txtCashierName
            // 
            txtCashierName.Location = new Point(655, 35);
            txtCashierName.Name = "txtCashierName";
            txtCashierName.Size = new Size(156, 27);
            txtCashierName.TabIndex = 9;
            // 
            // txtCashierGender
            // 
            txtCashierGender.Location = new Point(655, 132);
            txtCashierGender.Name = "txtCashierGender";
            txtCashierGender.Size = new Size(156, 27);
            txtCashierGender.TabIndex = 10;
            // 
            // txtCashierSurname
            // 
            txtCashierSurname.Location = new Point(655, 82);
            txtCashierSurname.Name = "txtCashierSurname";
            txtCashierSurname.Size = new Size(156, 27);
            txtCashierSurname.TabIndex = 11;
            // 
            // txtCashierHDate
            // 
            txtCashierHDate.Location = new Point(655, 186);
            txtCashierHDate.Name = "txtCashierHDate";
            txtCashierHDate.Size = new Size(156, 27);
            txtCashierHDate.TabIndex = 12;
            // 
            // btnAddCashier
            // 
            btnAddCashier.Location = new Point(655, 234);
            btnAddCashier.Name = "btnAddCashier";
            btnAddCashier.Size = new Size(156, 29);
            btnAddCashier.TabIndex = 13;
            btnAddCashier.Text = "Kasiyer Tanıt";
            btnAddCashier.UseVisualStyleBackColor = true;
            btnAddCashier.Click += btnAddCashier_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(572, 38);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 14;
            label5.Text = "İsim";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(572, 85);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 15;
            label6.Text = "Soyisim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(572, 139);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 16;
            label7.Text = "Cinsiyet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(564, 193);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 17;
            label8.Text = "İşbaşı Tarihi";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(907, 10);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(168, 27);
            textBox5.TabIndex = 18;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(907, 51);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(168, 27);
            textBox6.TabIndex = 19;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(907, 85);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(168, 27);
            textBox7.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(907, 234);
            button1.Name = "button1";
            button1.Size = new Size(168, 29);
            button1.TabIndex = 21;
            button1.Text = "Sipariş Formu Oluştur";
            button1.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(900, 62);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(832, 54);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 23;
            label10.Text = "Kargo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(832, 92);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 24;
            label11.Text = "Şehir";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(907, 58);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(817, 13);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 26;
            label13.Text = "Tplm Fiyat";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(1172, 125);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(149, 27);
            textBox10.TabIndex = 29;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(1174, 174);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(149, 27);
            textBox11.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(1113, 41);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 31;
            label14.Text = "Sip.No";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(1113, 82);
            label15.Name = "label15";
            label15.Size = new Size(40, 20);
            label15.TabIndex = 32;
            label15.Text = "Ürün";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(1107, 177);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 33;
            label16.Text = "Br.Fiyat";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(1113, 128);
            label17.Name = "label17";
            label17.Size = new Size(51, 20);
            label17.TabIndex = 34;
            label17.Text = "Miktar";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1172, 41);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 35;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1172, 82);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 36;
            // 
            // button2
            // 
            button2.Location = new Point(1172, 234);
            button2.Name = "button2";
            button2.Size = new Size(151, 29);
            button2.TabIndex = 37;
            button2.Text = "Siparişi Tamamla";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(907, 190);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(164, 27);
            textBox8.TabIndex = 38;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(907, 157);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(164, 27);
            textBox9.TabIndex = 39;
            // 
            // textBox12
            // 
            textBox12.Location = new Point(907, 121);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(164, 27);
            textBox12.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(837, 125);
            label18.Name = "label18";
            label18.Size = new Size(44, 20);
            label18.TabIndex = 41;
            label18.Text = "M.Ad";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(828, 164);
            label19.Name = "label19";
            label19.Size = new Size(66, 20);
            label19.TabIndex = 42;
            label19.Text = "M.Soyad";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(830, 197);
            label20.Name = "label20";
            label20.Size = new Size(44, 20);
            label20.TabIndex = 43;
            label20.Text = "M.Tel";
            // 
            // grdPrd
            // 
            grdPrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPrd.Location = new Point(12, 279);
            grdPrd.Name = "grdPrd";
            grdPrd.RowHeadersWidth = 51;
            grdPrd.RowTemplate.Height = 29;
            grdPrd.Size = new Size(247, 423);
            grdPrd.TabIndex = 44;
            // 
            // grdOrders
            // 
            grdOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdOrders.Location = new Point(321, 279);
            grdOrders.Name = "grdOrders";
            grdOrders.RowHeadersWidth = 51;
            grdOrders.RowTemplate.Height = 29;
            grdOrders.Size = new Size(550, 423);
            grdOrders.TabIndex = 45;
            // 
            // grdInvoices
            // 
            grdInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdInvoices.Location = new Point(924, 279);
            grdInvoices.Name = "grdInvoices";
            grdInvoices.RowHeadersWidth = 51;
            grdInvoices.RowTemplate.Height = 29;
            grdInvoices.Size = new Size(411, 423);
            grdInvoices.TabIndex = 46;
            // 
            // txtNewCtg
            // 
            txtNewCtg.Location = new Point(62, 42);
            txtNewCtg.Name = "txtNewCtg";
            txtNewCtg.Size = new Size(151, 27);
            txtNewCtg.TabIndex = 47;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(12, 44);
            label21.Name = "label21";
            label21.Size = new Size(44, 20);
            label21.TabIndex = 48;
            label21.Text = "K.Adı";
            // 
            // btnAddCtg
            // 
            btnAddCtg.Location = new Point(62, 93);
            btnAddCtg.Name = "btnAddCtg";
            btnAddCtg.Size = new Size(151, 29);
            btnAddCtg.TabIndex = 49;
            btnAddCtg.Text = "Kategori Ekle";
            btnAddCtg.UseVisualStyleBackColor = true;
            btnAddCtg.Click += btnAddCtg_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 765);
            Controls.Add(btnAddCtg);
            Controls.Add(label21);
            Controls.Add(txtNewCtg);
            Controls.Add(grdInvoices);
            Controls.Add(grdOrders);
            Controls.Add(grdPrd);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(textBox12);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(button2);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(btnAddCashier);
            Controls.Add(txtCashierHDate);
            Controls.Add(txtCashierSurname);
            Controls.Add(txtCashierGender);
            Controls.Add(txtCashierName);
            Controls.Add(btnAddPrd);
            Controls.Add(cbbPrdCtg);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtPrdAmt);
            Controls.Add(txtPrdPrice);
            Controls.Add(txtPrdName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)grdPrd).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdInvoices).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrdName;
        private TextBox txtPrdPrice;
        private TextBox txtPrdAmt;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cbbPrdCtg;
        private Button btnAddPrd;
        private TextBox txtCashierName;
        private TextBox txtCashierGender;
        private TextBox txtCashierSurname;
        private TextBox txtCashierHDate;
        private Button btnAddCashier;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox6;
        private TextBox textBox7;
        private Button button1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox textBox10;
        private TextBox textBox11;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Button button2;
        private TextBox textBox8;
        private TextBox textBox9;
        private TextBox textBox12;
        private Label label18;
        private Label label19;
        private Label label20;
        private DataGridView grdPrd;
        private DataGridView grdOrders;
        private DataGridView grdInvoices;
        private TextBox txtNewCtg;
        private Label label21;
        private Button btnAddCtg;
    }
}
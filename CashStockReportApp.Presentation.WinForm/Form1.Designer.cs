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
            txtOrdTotalPrice = new TextBox();
            txtOrdShip = new TextBox();
            txtOrdCity = new TextBox();
            button1 = new Button();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            txtOrderAmt = new TextBox();
            txtOrderUnitPrc = new TextBox();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            cbbOrderId = new ComboBox();
            cbbOrderPrd = new ComboBox();
            btnComplateOrder = new Button();
            txtCustomerPhone = new TextBox();
            txtCustomerSurname = new TextBox();
            txtCustomerName = new TextBox();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            grdPrd = new DataGridView();
            grdInfoList = new DataGridView();
            grdInvoices = new DataGridView();
            txtNewCtg = new TextBox();
            label21 = new Label();
            btnAddCtg = new Button();
            txtCstAdress = new TextBox();
            txtCstRegion = new TextBox();
            txtCstCity = new TextBox();
            cbbCstId = new ComboBox();
            label22 = new Label();
            label23 = new Label();
            label24 = new Label();
            label25 = new Label();
            cbbInvOrdId = new ComboBox();
            cbbInvCustomer = new ComboBox();
            cbbInvCashier = new ComboBox();
            txtInvAmt = new TextBox();
            Müşteri = new Label();
            label27 = new Label();
            label28 = new Label();
            label29 = new Label();
            btnInvoice = new Button();
            button2 = new Button();
            btnShowCustomers = new Button();
            btnOrderList = new Button();
            button5 = new Button();
            button6 = new Button();
            ((System.ComponentModel.ISupportInitialize)grdPrd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdInfoList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdInvoices).BeginInit();
            SuspendLayout();
            // 
            // txtPrdName
            // 
            txtPrdName.Location = new Point(82, 91);
            txtPrdName.Name = "txtPrdName";
            txtPrdName.Size = new Size(151, 27);
            txtPrdName.TabIndex = 0;
            // 
            // txtPrdPrice
            // 
            txtPrdPrice.Location = new Point(82, 188);
            txtPrdPrice.Name = "txtPrdPrice";
            txtPrdPrice.Size = new Size(151, 27);
            txtPrdPrice.TabIndex = 1;
            // 
            // txtPrdAmt
            // 
            txtPrdAmt.Location = new Point(82, 138);
            txtPrdAmt.Name = "txtPrdAmt";
            txtPrdAmt.Size = new Size(151, 27);
            txtPrdAmt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(4, 91);
            label1.Name = "label1";
            label1.Size = new Size(67, 20);
            label1.TabIndex = 3;
            label1.Text = "Ürün Adı";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(4, 188);
            label2.Name = "label2";
            label2.Size = new Size(40, 20);
            label2.TabIndex = 4;
            label2.Text = "Fiyat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 138);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 5;
            label3.Text = "Miktar";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 241);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 6;
            label4.Text = "Kategori";
            // 
            // cbbPrdCtg
            // 
            cbbPrdCtg.FormattingEnabled = true;
            cbbPrdCtg.Location = new Point(82, 241);
            cbbPrdCtg.Name = "cbbPrdCtg";
            cbbPrdCtg.Size = new Size(151, 28);
            cbbPrdCtg.TabIndex = 7;
            // 
            // btnAddPrd
            // 
            btnAddPrd.Location = new Point(82, 290);
            btnAddPrd.Name = "btnAddPrd";
            btnAddPrd.Size = new Size(151, 29);
            btnAddPrd.TabIndex = 8;
            btnAddPrd.Text = "Ürün Ekle";
            btnAddPrd.UseVisualStyleBackColor = true;
            btnAddPrd.Click += btnAddPrd_Click;
            // 
            // txtCashierName
            // 
            txtCashierName.Location = new Point(345, 38);
            txtCashierName.Name = "txtCashierName";
            txtCashierName.Size = new Size(156, 27);
            txtCashierName.TabIndex = 9;
            // 
            // txtCashierGender
            // 
            txtCashierGender.Location = new Point(345, 135);
            txtCashierGender.Name = "txtCashierGender";
            txtCashierGender.Size = new Size(156, 27);
            txtCashierGender.TabIndex = 10;
            // 
            // txtCashierSurname
            // 
            txtCashierSurname.Location = new Point(345, 88);
            txtCashierSurname.Name = "txtCashierSurname";
            txtCashierSurname.Size = new Size(156, 27);
            txtCashierSurname.TabIndex = 11;
            // 
            // txtCashierHDate
            // 
            txtCashierHDate.Location = new Point(345, 189);
            txtCashierHDate.Name = "txtCashierHDate";
            txtCashierHDate.Size = new Size(156, 27);
            txtCashierHDate.TabIndex = 12;
            // 
            // btnAddCashier
            // 
            btnAddCashier.Location = new Point(345, 237);
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
            label5.Location = new Point(262, 41);
            label5.Name = "label5";
            label5.Size = new Size(36, 20);
            label5.TabIndex = 14;
            label5.Text = "İsim";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(262, 88);
            label6.Name = "label6";
            label6.Size = new Size(60, 20);
            label6.TabIndex = 15;
            label6.Text = "Soyisim";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(262, 142);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 16;
            label7.Text = "Cinsiyet";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(237, 192);
            label8.Name = "label8";
            label8.Size = new Size(85, 20);
            label8.TabIndex = 17;
            label8.Text = "İşbaşı Tarihi";
            // 
            // txtOrdTotalPrice
            // 
            txtOrdTotalPrice.Location = new Point(616, 20);
            txtOrdTotalPrice.Name = "txtOrdTotalPrice";
            txtOrdTotalPrice.Size = new Size(168, 27);
            txtOrdTotalPrice.TabIndex = 18;
            // 
            // txtOrdShip
            // 
            txtOrdShip.Location = new Point(616, 61);
            txtOrdShip.Name = "txtOrdShip";
            txtOrdShip.Size = new Size(168, 27);
            txtOrdShip.TabIndex = 19;
            // 
            // txtOrdCity
            // 
            txtOrdCity.Location = new Point(616, 95);
            txtOrdCity.Name = "txtOrdCity";
            txtOrdCity.Size = new Size(168, 27);
            txtOrdCity.TabIndex = 20;
            // 
            // button1
            // 
            button1.Location = new Point(616, 244);
            button1.Name = "button1";
            button1.Size = new Size(168, 29);
            button1.TabIndex = 21;
            button1.Text = "Sipariş Formu Oluştur";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(609, 72);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 22;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(541, 64);
            label10.Name = "label10";
            label10.Size = new Size(49, 20);
            label10.TabIndex = 23;
            label10.Text = "Kargo";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(546, 102);
            label11.Name = "label11";
            label11.Size = new Size(42, 20);
            label11.TabIndex = 24;
            label11.Text = "Şehir";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(616, 68);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 25;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(526, 22);
            label13.Name = "label13";
            label13.Size = new Size(77, 20);
            label13.TabIndex = 26;
            label13.Text = "Tplm Fiyat";
            // 
            // txtOrderAmt
            // 
            txtOrderAmt.Location = new Point(857, 91);
            txtOrderAmt.Name = "txtOrderAmt";
            txtOrderAmt.Size = new Size(149, 27);
            txtOrderAmt.TabIndex = 29;
            // 
            // txtOrderUnitPrc
            // 
            txtOrderUnitPrc.Location = new Point(857, 128);
            txtOrderUnitPrc.Name = "txtOrderUnitPrc";
            txtOrderUnitPrc.Size = new Size(149, 27);
            txtOrderUnitPrc.TabIndex = 30;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(798, 17);
            label14.Name = "label14";
            label14.Size = new Size(53, 20);
            label14.TabIndex = 31;
            label14.Text = "Sip.No";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(811, 56);
            label15.Name = "label15";
            label15.Size = new Size(40, 20);
            label15.TabIndex = 32;
            label15.Text = "Ürün";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(794, 131);
            label16.Name = "label16";
            label16.Size = new Size(57, 20);
            label16.TabIndex = 33;
            label16.Text = "Br.Fiyat";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(800, 98);
            label17.Name = "label17";
            label17.Size = new Size(51, 20);
            label17.TabIndex = 34;
            label17.Text = "Miktar";
            // 
            // cbbOrderId
            // 
            cbbOrderId.FormattingEnabled = true;
            cbbOrderId.Location = new Point(857, 14);
            cbbOrderId.Name = "cbbOrderId";
            cbbOrderId.Size = new Size(151, 28);
            cbbOrderId.TabIndex = 35;
            // 
            // cbbOrderPrd
            // 
            cbbOrderPrd.FormattingEnabled = true;
            cbbOrderPrd.Location = new Point(857, 53);
            cbbOrderPrd.Name = "cbbOrderPrd";
            cbbOrderPrd.Size = new Size(151, 28);
            cbbOrderPrd.TabIndex = 36;
            // 
            // btnComplateOrder
            // 
            btnComplateOrder.Location = new Point(914, 165);
            btnComplateOrder.Name = "btnComplateOrder";
            btnComplateOrder.Size = new Size(260, 29);
            btnComplateOrder.TabIndex = 37;
            btnComplateOrder.Text = "Siparişi Tamamla";
            btnComplateOrder.UseVisualStyleBackColor = true;
            btnComplateOrder.Click += btnComplateOrder_Click;
            // 
            // txtCustomerPhone
            // 
            txtCustomerPhone.Location = new Point(616, 200);
            txtCustomerPhone.Name = "txtCustomerPhone";
            txtCustomerPhone.Size = new Size(164, 27);
            txtCustomerPhone.TabIndex = 38;
            // 
            // txtCustomerSurname
            // 
            txtCustomerSurname.Location = new Point(616, 167);
            txtCustomerSurname.Name = "txtCustomerSurname";
            txtCustomerSurname.Size = new Size(164, 27);
            txtCustomerSurname.TabIndex = 39;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(616, 131);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(164, 27);
            txtCustomerName.TabIndex = 40;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(546, 135);
            label18.Name = "label18";
            label18.Size = new Size(44, 20);
            label18.TabIndex = 41;
            label18.Text = "M.Ad";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(537, 174);
            label19.Name = "label19";
            label19.Size = new Size(66, 20);
            label19.TabIndex = 42;
            label19.Text = "M.Soyad";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(546, 207);
            label20.Name = "label20";
            label20.Size = new Size(44, 20);
            label20.TabIndex = 43;
            label20.Text = "M.Tel";
            // 
            // grdPrd
            // 
            grdPrd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdPrd.Location = new Point(12, 390);
            grdPrd.Name = "grdPrd";
            grdPrd.RowHeadersWidth = 51;
            grdPrd.RowTemplate.Height = 29;
            grdPrd.Size = new Size(247, 363);
            grdPrd.TabIndex = 44;
            // 
            // grdInfoList
            // 
            grdInfoList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdInfoList.Location = new Point(324, 390);
            grdInfoList.Name = "grdInfoList";
            grdInfoList.RowHeadersWidth = 51;
            grdInfoList.RowTemplate.Height = 29;
            grdInfoList.Size = new Size(550, 363);
            grdInfoList.TabIndex = 45;
            // 
            // grdInvoices
            // 
            grdInvoices.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdInvoices.Location = new Point(923, 390);
            grdInvoices.Name = "grdInvoices";
            grdInvoices.RowHeadersWidth = 51;
            grdInvoices.RowTemplate.Height = 29;
            grdInvoices.Size = new Size(411, 363);
            grdInvoices.TabIndex = 46;
            // 
            // txtNewCtg
            // 
            txtNewCtg.Location = new Point(82, 12);
            txtNewCtg.Name = "txtNewCtg";
            txtNewCtg.Size = new Size(151, 27);
            txtNewCtg.TabIndex = 47;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(32, 15);
            label21.Name = "label21";
            label21.Size = new Size(44, 20);
            label21.TabIndex = 48;
            label21.Text = "K.Adı";
            // 
            // btnAddCtg
            // 
            btnAddCtg.Location = new Point(82, 53);
            btnAddCtg.Name = "btnAddCtg";
            btnAddCtg.Size = new Size(151, 29);
            btnAddCtg.TabIndex = 49;
            btnAddCtg.Text = "Kategori Ekle";
            btnAddCtg.UseVisualStyleBackColor = true;
            btnAddCtg.Click += btnAddCtg_Click;
            // 
            // txtCstAdress
            // 
            txtCstAdress.Location = new Point(1077, 15);
            txtCstAdress.Name = "txtCstAdress";
            txtCstAdress.Size = new Size(221, 27);
            txtCstAdress.TabIndex = 50;
            // 
            // txtCstRegion
            // 
            txtCstRegion.Location = new Point(1077, 87);
            txtCstRegion.Name = "txtCstRegion";
            txtCstRegion.Size = new Size(151, 27);
            txtCstRegion.TabIndex = 51;
            // 
            // txtCstCity
            // 
            txtCstCity.Location = new Point(1077, 53);
            txtCstCity.Name = "txtCstCity";
            txtCstCity.Size = new Size(151, 27);
            txtCstCity.TabIndex = 52;
            // 
            // cbbCstId
            // 
            cbbCstId.FormattingEnabled = true;
            cbbCstId.Location = new Point(1077, 123);
            cbbCstId.Name = "cbbCstId";
            cbbCstId.Size = new Size(151, 28);
            cbbCstId.TabIndex = 53;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(1024, 19);
            label22.Name = "label22";
            label22.Size = new Size(47, 20);
            label22.TabIndex = 54;
            label22.Text = "Adres";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(1029, 53);
            label23.Name = "label23";
            label23.Size = new Size(42, 20);
            label23.TabIndex = 55;
            label23.Text = "Şehir";
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(1033, 88);
            label24.Name = "label24";
            label24.Size = new Size(38, 20);
            label24.TabIndex = 56;
            label24.Text = "Ülke";
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(1013, 126);
            label25.Name = "label25";
            label25.Size = new Size(58, 20);
            label25.TabIndex = 57;
            label25.Text = "Müşteri";
            // 
            // cbbInvOrdId
            // 
            cbbInvOrdId.FormattingEnabled = true;
            cbbInvOrdId.Location = new Point(1147, 238);
            cbbInvOrdId.Name = "cbbInvOrdId";
            cbbInvOrdId.Size = new Size(151, 28);
            cbbInvOrdId.TabIndex = 58;
            // 
            // cbbInvCustomer
            // 
            cbbInvCustomer.FormattingEnabled = true;
            cbbInvCustomer.Location = new Point(966, 289);
            cbbInvCustomer.Name = "cbbInvCustomer";
            cbbInvCustomer.Size = new Size(151, 28);
            cbbInvCustomer.TabIndex = 59;
            // 
            // cbbInvCashier
            // 
            cbbInvCashier.FormattingEnabled = true;
            cbbInvCashier.Location = new Point(1147, 289);
            cbbInvCashier.Name = "cbbInvCashier";
            cbbInvCashier.Size = new Size(151, 28);
            cbbInvCashier.TabIndex = 60;
            // 
            // txtInvAmt
            // 
            txtInvAmt.Location = new Point(966, 237);
            txtInvAmt.Name = "txtInvAmt";
            txtInvAmt.Size = new Size(151, 27);
            txtInvAmt.TabIndex = 61;
            // 
            // Müşteri
            // 
            Müşteri.AutoSize = true;
            Müşteri.Location = new Point(1013, 267);
            Müşteri.Name = "Müşteri";
            Müşteri.Size = new Size(58, 20);
            Müşteri.TabIndex = 62;
            Müşteri.Text = "Müşteri";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(1185, 266);
            label27.Name = "label27";
            label27.Size = new Size(56, 20);
            label27.TabIndex = 63;
            label27.Text = "Kasiyer";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(994, 214);
            label28.Name = "label28";
            label28.Size = new Size(91, 20);
            label28.TabIndex = 64;
            label28.Text = "Fatura Tutarı";
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(1185, 215);
            label29.Name = "label29";
            label29.Size = new Size(77, 20);
            label29.TabIndex = 65;
            label29.Text = "Sipariş No";
            // 
            // btnInvoice
            // 
            btnInvoice.Location = new Point(838, 244);
            btnInvoice.Name = "btnInvoice";
            btnInvoice.Size = new Size(94, 73);
            btnInvoice.TabIndex = 66;
            btnInvoice.Text = "Fatura Oluştur";
            btnInvoice.UseVisualStyleBackColor = true;
            btnInvoice.Click += btnInvoice_Click;
            // 
            // button2
            // 
            button2.Location = new Point(324, 344);
            button2.Name = "button2";
            button2.Size = new Size(155, 29);
            button2.TabIndex = 67;
            button2.Text = "Kasiyerler";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnShowCustomers
            // 
            btnShowCustomers.Location = new Point(512, 344);
            btnShowCustomers.Name = "btnShowCustomers";
            btnShowCustomers.Size = new Size(156, 29);
            btnShowCustomers.TabIndex = 68;
            btnShowCustomers.Text = "Müşteriler";
            btnShowCustomers.UseVisualStyleBackColor = true;
            btnShowCustomers.Click += btnShowCustomers_Click;
            // 
            // btnOrderList
            // 
            btnOrderList.Location = new Point(706, 344);
            btnOrderList.Name = "btnOrderList";
            btnOrderList.Size = new Size(168, 29);
            btnOrderList.TabIndex = 69;
            btnOrderList.Text = "Siparişler";
            btnOrderList.UseVisualStyleBackColor = true;
            btnOrderList.Click += btnOrderList_Click;
            // 
            // button5
            // 
            button5.Location = new Point(923, 347);
            button5.Name = "button5";
            button5.Size = new Size(194, 29);
            button5.TabIndex = 70;
            button5.Text = "Faturalar";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Location = new Point(1135, 347);
            button6.Name = "button6";
            button6.Size = new Size(199, 29);
            button6.TabIndex = 71;
            button6.Text = "Sipariş Detayları";
            button6.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1369, 765);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(btnOrderList);
            Controls.Add(btnShowCustomers);
            Controls.Add(button2);
            Controls.Add(btnInvoice);
            Controls.Add(label29);
            Controls.Add(label28);
            Controls.Add(label27);
            Controls.Add(Müşteri);
            Controls.Add(txtInvAmt);
            Controls.Add(cbbInvCashier);
            Controls.Add(cbbInvCustomer);
            Controls.Add(cbbInvOrdId);
            Controls.Add(label25);
            Controls.Add(label24);
            Controls.Add(label23);
            Controls.Add(label22);
            Controls.Add(cbbCstId);
            Controls.Add(txtCstCity);
            Controls.Add(txtCstRegion);
            Controls.Add(txtCstAdress);
            Controls.Add(btnAddCtg);
            Controls.Add(label21);
            Controls.Add(txtNewCtg);
            Controls.Add(grdInvoices);
            Controls.Add(grdInfoList);
            Controls.Add(grdPrd);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(txtCustomerName);
            Controls.Add(txtCustomerSurname);
            Controls.Add(txtCustomerPhone);
            Controls.Add(btnComplateOrder);
            Controls.Add(cbbOrderPrd);
            Controls.Add(cbbOrderId);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(txtOrderUnitPrc);
            Controls.Add(txtOrderAmt);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(button1);
            Controls.Add(txtOrdCity);
            Controls.Add(txtOrdShip);
            Controls.Add(txtOrdTotalPrice);
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
            ((System.ComponentModel.ISupportInitialize)grdInfoList).EndInit();
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
        private TextBox txtOrdTotalPrice;
        private TextBox txtOrdShip;
        private TextBox txtOrdCity;
        private Button button1;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private TextBox txtOrderAmt;
        private TextBox txtOrderUnitPrc;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private ComboBox cbbOrderId;
        private ComboBox cbbOrderPrd;
        private Button btnComplateOrder;
        private TextBox txtCustomerPhone;
        private TextBox txtCustomerSurname;
        private TextBox txtCustomerName;
        private Label label18;
        private Label label19;
        private Label label20;
        private DataGridView grdPrd;
        private DataGridView grdInfoList;
        private DataGridView grdInvoices;
        private TextBox txtNewCtg;
        private Label label21;
        private Button btnAddCtg;
        private TextBox txtCstAdress;
        private TextBox txtCstRegion;
        private TextBox txtCstCity;
        private ComboBox cbbCstId;
        private Label label22;
        private Label label23;
        private Label label24;
        private Label label25;
        private ComboBox cbbInvOrdId;
        private ComboBox cbbInvCustomer;
        private ComboBox cbbInvCashier;
        private TextBox txtInvAmt;
        private Label Müşteri;
        private Label label27;
        private Label label28;
        private Label label29;
        private Button btnInvoice;
        private Button button2;
        private Button btnShowCustomers;
        private Button btnOrderList;
        private Button button5;
        private Button button6;
    }
}
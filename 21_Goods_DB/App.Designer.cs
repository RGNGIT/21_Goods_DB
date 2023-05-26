namespace _21_Goods_DB
{
    partial class App
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
            tabControlMain = new TabControl();
            tabPage1 = new TabPage();
            buttonDeleteDir = new Button();
            dataGridViewDir = new DataGridView();
            buttonAddDir = new Button();
            tabControlDirs = new TabControl();
            tabPage3 = new TabPage();
            label1 = new Label();
            textBoxStreetType = new TextBox();
            tabPage4 = new TabPage();
            label2 = new Label();
            textBoxLocalityType = new TextBox();
            tabPage5 = new TabPage();
            comboBoxStreetType = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            textBoxStreetName = new TextBox();
            tabPage6 = new TabPage();
            comboBoxLocalityType = new ComboBox();
            label6 = new Label();
            label4 = new Label();
            textBoxLocalityName = new TextBox();
            tabPage7 = new TabPage();
            comboBoxStreet = new ComboBox();
            label10 = new Label();
            comboBoxLocality = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            textBoxCampus = new TextBox();
            label7 = new Label();
            textBoxHouseNum = new TextBox();
            tabPage2 = new TabPage();
            buttonDeleteGood = new Button();
            buttonAddGood = new Button();
            label12 = new Label();
            textBoxGoodAmount = new TextBox();
            label11 = new Label();
            textBoxGoodName = new TextBox();
            dataGridViewGoods = new DataGridView();
            tabPage8 = new TabPage();
            buttonDeleteOrg = new Button();
            buttonAddOrg = new Button();
            tabControlOrg = new TabControl();
            tabPage9 = new TabPage();
            label20 = new Label();
            textBoxOrgReq = new TextBox();
            comboBoxOrgAddress = new ComboBox();
            label19 = new Label();
            label18 = new Label();
            textBoxOrgFIO = new TextBox();
            label17 = new Label();
            textBoxOrgSite = new TextBox();
            label16 = new Label();
            textBoxOrgEmail = new TextBox();
            label15 = new Label();
            textBoxOrgPhone = new TextBox();
            label14 = new Label();
            textBoxOrgInn = new TextBox();
            label13 = new Label();
            textBoxOrgName = new TextBox();
            tabPage10 = new TabPage();
            textBoxPriceListDesc = new TextBox();
            label25 = new Label();
            textBoxPriceListValue = new TextBox();
            label24 = new Label();
            comboBoxPriceListGood = new ComboBox();
            label23 = new Label();
            label22 = new Label();
            dateTimePickerPriceListDate = new DateTimePicker();
            comboBoxPriceListOrg = new ComboBox();
            label21 = new Label();
            dataGridViewOrg = new DataGridView();
            tabPage11 = new TabPage();
            buttonDeletePhys = new Button();
            buttonAddPhys = new Button();
            tabControlPhys = new TabControl();
            tabPage12 = new TabPage();
            label29 = new Label();
            textBoxPassportWhoIssued = new TextBox();
            label28 = new Label();
            dateTimePickerPassportIssue = new DateTimePicker();
            label27 = new Label();
            textBoxPassportNumber = new TextBox();
            label26 = new Label();
            textBoxPassportSeries = new TextBox();
            tabPage13 = new TabPage();
            comboBoxPhysPassport = new ComboBox();
            label32 = new Label();
            label31 = new Label();
            textBoxPhysFIO = new TextBox();
            label30 = new Label();
            textBoxPhysINN = new TextBox();
            dataGridViewPhys = new DataGridView();
            tabPage14 = new TabPage();
            comboBoxOrderWho = new ComboBox();
            label36 = new Label();
            textBoxOrderAmount = new TextBox();
            comboBoxOrderGood = new ComboBox();
            label35 = new Label();
            label34 = new Label();
            dateTimePickerOrderDate = new DateTimePicker();
            comboBoxOrderWhoType = new ComboBox();
            label33 = new Label();
            buttonAddOrder = new Button();
            dataGridView1 = new DataGridView();
            dataGridViewBuffer = new DataGridView();
            tabControlMain.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDir).BeginInit();
            tabControlDirs.SuspendLayout();
            tabPage3.SuspendLayout();
            tabPage4.SuspendLayout();
            tabPage5.SuspendLayout();
            tabPage6.SuspendLayout();
            tabPage7.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoods).BeginInit();
            tabPage8.SuspendLayout();
            tabControlOrg.SuspendLayout();
            tabPage9.SuspendLayout();
            tabPage10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrg).BeginInit();
            tabPage11.SuspendLayout();
            tabControlPhys.SuspendLayout();
            tabPage12.SuspendLayout();
            tabPage13.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhys).BeginInit();
            tabPage14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuffer).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Controls.Add(tabPage8);
            tabControlMain.Controls.Add(tabPage11);
            tabControlMain.Controls.Add(tabPage14);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(855, 453);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(buttonDeleteDir);
            tabPage1.Controls.Add(dataGridViewDir);
            tabPage1.Controls.Add(buttonAddDir);
            tabPage1.Controls.Add(tabControlDirs);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(847, 425);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Справочники";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteDir
            // 
            buttonDeleteDir.ForeColor = Color.Red;
            buttonDeleteDir.Location = new Point(10, 367);
            buttonDeleteDir.Name = "buttonDeleteDir";
            buttonDeleteDir.Size = new Size(309, 23);
            buttonDeleteDir.TabIndex = 3;
            buttonDeleteDir.Text = "Удалить";
            buttonDeleteDir.UseVisualStyleBackColor = true;
            buttonDeleteDir.Click += buttonDelete_Click;
            // 
            // dataGridViewDir
            // 
            dataGridViewDir.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDir.Location = new Point(329, 6);
            dataGridViewDir.Name = "dataGridViewDir";
            dataGridViewDir.RowTemplate.Height = 25;
            dataGridViewDir.Size = new Size(512, 413);
            dataGridViewDir.TabIndex = 2;
            // 
            // buttonAddDir
            // 
            buttonAddDir.Location = new Point(10, 396);
            buttonAddDir.Name = "buttonAddDir";
            buttonAddDir.Size = new Size(309, 23);
            buttonAddDir.TabIndex = 1;
            buttonAddDir.Text = "Добавить";
            buttonAddDir.UseVisualStyleBackColor = true;
            buttonAddDir.Click += buttonAddDir_Click;
            // 
            // tabControlDirs
            // 
            tabControlDirs.Controls.Add(tabPage3);
            tabControlDirs.Controls.Add(tabPage4);
            tabControlDirs.Controls.Add(tabPage5);
            tabControlDirs.Controls.Add(tabPage6);
            tabControlDirs.Controls.Add(tabPage7);
            tabControlDirs.Location = new Point(6, 6);
            tabControlDirs.Name = "tabControlDirs";
            tabControlDirs.SelectedIndex = 0;
            tabControlDirs.Size = new Size(317, 355);
            tabControlDirs.TabIndex = 0;
            tabControlDirs.SelectedIndexChanged += tabControlDirs_SelectedIndexChanged;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label1);
            tabPage3.Controls.Add(textBoxStreetType);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(309, 327);
            tabPage3.TabIndex = 0;
            tabPage3.Text = "Тип улицы";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 3);
            label1.Name = "label1";
            label1.Size = new Size(90, 15);
            label1.TabIndex = 1;
            label1.Text = "Наименование";
            // 
            // textBoxStreetType
            // 
            textBoxStreetType.Location = new Point(3, 21);
            textBoxStreetType.Name = "textBoxStreetType";
            textBoxStreetType.Size = new Size(300, 23);
            textBoxStreetType.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(label2);
            tabPage4.Controls.Add(textBoxLocalityType);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(309, 327);
            tabPage4.TabIndex = 1;
            tabPage4.Text = "Тип НП";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 3;
            label2.Text = "Наименование";
            // 
            // textBoxLocalityType
            // 
            textBoxLocalityType.Location = new Point(3, 21);
            textBoxLocalityType.Name = "textBoxLocalityType";
            textBoxLocalityType.Size = new Size(300, 23);
            textBoxLocalityType.TabIndex = 2;
            // 
            // tabPage5
            // 
            tabPage5.Controls.Add(comboBoxStreetType);
            tabPage5.Controls.Add(label5);
            tabPage5.Controls.Add(label3);
            tabPage5.Controls.Add(textBoxStreetName);
            tabPage5.Location = new Point(4, 24);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(309, 327);
            tabPage5.TabIndex = 2;
            tabPage5.Text = "Улица";
            tabPage5.UseVisualStyleBackColor = true;
            // 
            // comboBoxStreetType
            // 
            comboBoxStreetType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStreetType.FormattingEnabled = true;
            comboBoxStreetType.Location = new Point(3, 66);
            comboBoxStreetType.Name = "comboBoxStreetType";
            comboBoxStreetType.Size = new Size(300, 23);
            comboBoxStreetType.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 48);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 6;
            label5.Text = "Тип";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 4);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 5;
            label3.Text = "Наименование";
            // 
            // textBoxStreetName
            // 
            textBoxStreetName.Location = new Point(3, 22);
            textBoxStreetName.Name = "textBoxStreetName";
            textBoxStreetName.Size = new Size(300, 23);
            textBoxStreetName.TabIndex = 4;
            // 
            // tabPage6
            // 
            tabPage6.Controls.Add(comboBoxLocalityType);
            tabPage6.Controls.Add(label6);
            tabPage6.Controls.Add(label4);
            tabPage6.Controls.Add(textBoxLocalityName);
            tabPage6.Location = new Point(4, 24);
            tabPage6.Name = "tabPage6";
            tabPage6.Padding = new Padding(3);
            tabPage6.Size = new Size(309, 327);
            tabPage6.TabIndex = 3;
            tabPage6.Text = "НП";
            tabPage6.UseVisualStyleBackColor = true;
            // 
            // comboBoxLocalityType
            // 
            comboBoxLocalityType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocalityType.FormattingEnabled = true;
            comboBoxLocalityType.Location = new Point(3, 66);
            comboBoxLocalityType.Name = "comboBoxLocalityType";
            comboBoxLocalityType.Size = new Size(300, 23);
            comboBoxLocalityType.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 48);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 8;
            label6.Text = "Тип";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 4);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 5;
            label4.Text = "Наименование";
            // 
            // textBoxLocalityName
            // 
            textBoxLocalityName.Location = new Point(3, 22);
            textBoxLocalityName.Name = "textBoxLocalityName";
            textBoxLocalityName.Size = new Size(300, 23);
            textBoxLocalityName.TabIndex = 4;
            // 
            // tabPage7
            // 
            tabPage7.Controls.Add(comboBoxStreet);
            tabPage7.Controls.Add(label10);
            tabPage7.Controls.Add(comboBoxLocality);
            tabPage7.Controls.Add(label9);
            tabPage7.Controls.Add(label8);
            tabPage7.Controls.Add(textBoxCampus);
            tabPage7.Controls.Add(label7);
            tabPage7.Controls.Add(textBoxHouseNum);
            tabPage7.Location = new Point(4, 24);
            tabPage7.Name = "tabPage7";
            tabPage7.Padding = new Padding(3);
            tabPage7.Size = new Size(309, 327);
            tabPage7.TabIndex = 4;
            tabPage7.Text = "Адрес";
            tabPage7.UseVisualStyleBackColor = true;
            // 
            // comboBoxStreet
            // 
            comboBoxStreet.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStreet.FormattingEnabled = true;
            comboBoxStreet.Location = new Point(3, 153);
            comboBoxStreet.Name = "comboBoxStreet";
            comboBoxStreet.Size = new Size(300, 23);
            comboBoxStreet.TabIndex = 13;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(3, 135);
            label10.Name = "label10";
            label10.Size = new Size(41, 15);
            label10.TabIndex = 12;
            label10.Text = "Улица";
            // 
            // comboBoxLocality
            // 
            comboBoxLocality.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxLocality.FormattingEnabled = true;
            comboBoxLocality.Location = new Point(3, 109);
            comboBoxLocality.Name = "comboBoxLocality";
            comboBoxLocality.Size = new Size(300, 23);
            comboBoxLocality.TabIndex = 11;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(3, 91);
            label9.Name = "label9";
            label9.Size = new Size(111, 15);
            label9.TabIndex = 10;
            label9.Text = "Населенный пункт";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(3, 47);
            label8.Name = "label8";
            label8.Size = new Size(47, 15);
            label8.TabIndex = 9;
            label8.Text = "Корпус";
            // 
            // textBoxCampus
            // 
            textBoxCampus.Location = new Point(3, 65);
            textBoxCampus.Name = "textBoxCampus";
            textBoxCampus.Size = new Size(300, 23);
            textBoxCampus.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(3, 3);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 7;
            label7.Text = "Номер дома";
            // 
            // textBoxHouseNum
            // 
            textBoxHouseNum.Location = new Point(3, 21);
            textBoxHouseNum.Name = "textBoxHouseNum";
            textBoxHouseNum.Size = new Size(300, 23);
            textBoxHouseNum.TabIndex = 6;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(buttonDeleteGood);
            tabPage2.Controls.Add(buttonAddGood);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(textBoxGoodAmount);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(textBoxGoodName);
            tabPage2.Controls.Add(dataGridViewGoods);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(847, 425);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Товары";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteGood
            // 
            buttonDeleteGood.ForeColor = Color.Red;
            buttonDeleteGood.Location = new Point(3, 367);
            buttonDeleteGood.Name = "buttonDeleteGood";
            buttonDeleteGood.Size = new Size(320, 23);
            buttonDeleteGood.TabIndex = 13;
            buttonDeleteGood.Text = "Удалить";
            buttonDeleteGood.UseVisualStyleBackColor = true;
            buttonDeleteGood.Click += buttonDeleteGood_Click;
            // 
            // buttonAddGood
            // 
            buttonAddGood.Location = new Point(3, 396);
            buttonAddGood.Name = "buttonAddGood";
            buttonAddGood.Size = new Size(320, 23);
            buttonAddGood.TabIndex = 12;
            buttonAddGood.Text = "Добавить";
            buttonAddGood.UseVisualStyleBackColor = true;
            buttonAddGood.Click += buttonAddGood_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(3, 47);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 11;
            label12.Text = "Количество";
            // 
            // textBoxGoodAmount
            // 
            textBoxGoodAmount.Location = new Point(3, 65);
            textBoxGoodAmount.Name = "textBoxGoodAmount";
            textBoxGoodAmount.Size = new Size(320, 23);
            textBoxGoodAmount.TabIndex = 10;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(3, 4);
            label11.Name = "label11";
            label11.Size = new Size(90, 15);
            label11.TabIndex = 9;
            label11.Text = "Наименование";
            // 
            // textBoxGoodName
            // 
            textBoxGoodName.Location = new Point(3, 22);
            textBoxGoodName.Name = "textBoxGoodName";
            textBoxGoodName.Size = new Size(320, 23);
            textBoxGoodName.TabIndex = 8;
            // 
            // dataGridViewGoods
            // 
            dataGridViewGoods.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewGoods.Location = new Point(329, 6);
            dataGridViewGoods.Name = "dataGridViewGoods";
            dataGridViewGoods.RowTemplate.Height = 25;
            dataGridViewGoods.Size = new Size(512, 413);
            dataGridViewGoods.TabIndex = 3;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(buttonDeleteOrg);
            tabPage8.Controls.Add(buttonAddOrg);
            tabPage8.Controls.Add(tabControlOrg);
            tabPage8.Controls.Add(dataGridViewOrg);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(847, 425);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "Организации";
            tabPage8.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteOrg
            // 
            buttonDeleteOrg.ForeColor = Color.Red;
            buttonDeleteOrg.Location = new Point(165, 396);
            buttonDeleteOrg.Name = "buttonDeleteOrg";
            buttonDeleteOrg.Size = new Size(158, 23);
            buttonDeleteOrg.TabIndex = 7;
            buttonDeleteOrg.Text = "Удалить";
            buttonDeleteOrg.UseVisualStyleBackColor = true;
            buttonDeleteOrg.Click += buttonDeleteOrg_Click;
            // 
            // buttonAddOrg
            // 
            buttonAddOrg.Location = new Point(8, 396);
            buttonAddOrg.Name = "buttonAddOrg";
            buttonAddOrg.Size = new Size(158, 23);
            buttonAddOrg.TabIndex = 6;
            buttonAddOrg.Text = "Добавить";
            buttonAddOrg.UseVisualStyleBackColor = true;
            buttonAddOrg.Click += buttonAddOrg_Click;
            // 
            // tabControlOrg
            // 
            tabControlOrg.Controls.Add(tabPage9);
            tabControlOrg.Controls.Add(tabPage10);
            tabControlOrg.Location = new Point(8, 6);
            tabControlOrg.Name = "tabControlOrg";
            tabControlOrg.SelectedIndex = 0;
            tabControlOrg.Size = new Size(315, 384);
            tabControlOrg.TabIndex = 5;
            tabControlOrg.SelectedIndexChanged += tabControlOrg_SelectedIndexChanged;
            // 
            // tabPage9
            // 
            tabPage9.Controls.Add(label20);
            tabPage9.Controls.Add(textBoxOrgReq);
            tabPage9.Controls.Add(comboBoxOrgAddress);
            tabPage9.Controls.Add(label19);
            tabPage9.Controls.Add(label18);
            tabPage9.Controls.Add(textBoxOrgFIO);
            tabPage9.Controls.Add(label17);
            tabPage9.Controls.Add(textBoxOrgSite);
            tabPage9.Controls.Add(label16);
            tabPage9.Controls.Add(textBoxOrgEmail);
            tabPage9.Controls.Add(label15);
            tabPage9.Controls.Add(textBoxOrgPhone);
            tabPage9.Controls.Add(label14);
            tabPage9.Controls.Add(textBoxOrgInn);
            tabPage9.Controls.Add(label13);
            tabPage9.Controls.Add(textBoxOrgName);
            tabPage9.Location = new Point(4, 24);
            tabPage9.Name = "tabPage9";
            tabPage9.Padding = new Padding(3);
            tabPage9.Size = new Size(307, 356);
            tabPage9.TabIndex = 0;
            tabPage9.Text = "Организация";
            tabPage9.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(3, 265);
            label20.Name = "label20";
            label20.Size = new Size(65, 15);
            label20.TabIndex = 17;
            label20.Text = "Реквизиты";
            // 
            // textBoxOrgReq
            // 
            textBoxOrgReq.Location = new Point(3, 283);
            textBoxOrgReq.Name = "textBoxOrgReq";
            textBoxOrgReq.Size = new Size(300, 23);
            textBoxOrgReq.TabIndex = 16;
            // 
            // comboBoxOrgAddress
            // 
            comboBoxOrgAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrgAddress.FormattingEnabled = true;
            comboBoxOrgAddress.Location = new Point(3, 327);
            comboBoxOrgAddress.Name = "comboBoxOrgAddress";
            comboBoxOrgAddress.Size = new Size(300, 23);
            comboBoxOrgAddress.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 309);
            label19.Name = "label19";
            label19.Size = new Size(40, 15);
            label19.TabIndex = 14;
            label19.Text = "Адрес";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(3, 223);
            label18.Name = "label18";
            label18.Size = new Size(203, 15);
            label18.TabIndex = 13;
            label18.Text = "ФИО представителя (через пробел)";
            // 
            // textBoxOrgFIO
            // 
            textBoxOrgFIO.Location = new Point(3, 241);
            textBoxOrgFIO.Name = "textBoxOrgFIO";
            textBoxOrgFIO.Size = new Size(300, 23);
            textBoxOrgFIO.TabIndex = 12;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(3, 179);
            label17.Name = "label17";
            label17.Size = new Size(33, 15);
            label17.TabIndex = 11;
            label17.Text = "Сайт";
            // 
            // textBoxOrgSite
            // 
            textBoxOrgSite.Location = new Point(3, 197);
            textBoxOrgSite.Name = "textBoxOrgSite";
            textBoxOrgSite.Size = new Size(300, 23);
            textBoxOrgSite.TabIndex = 10;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(3, 135);
            label16.Name = "label16";
            label16.Size = new Size(43, 15);
            label16.TabIndex = 9;
            label16.Text = "Эмейл";
            // 
            // textBoxOrgEmail
            // 
            textBoxOrgEmail.Location = new Point(3, 153);
            textBoxOrgEmail.Name = "textBoxOrgEmail";
            textBoxOrgEmail.Size = new Size(300, 23);
            textBoxOrgEmail.TabIndex = 8;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(3, 91);
            label15.Name = "label15";
            label15.Size = new Size(55, 15);
            label15.TabIndex = 7;
            label15.Text = "Телефон";
            // 
            // textBoxOrgPhone
            // 
            textBoxOrgPhone.Location = new Point(3, 109);
            textBoxOrgPhone.Name = "textBoxOrgPhone";
            textBoxOrgPhone.Size = new Size(300, 23);
            textBoxOrgPhone.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(3, 47);
            label14.Name = "label14";
            label14.Size = new Size(34, 15);
            label14.TabIndex = 5;
            label14.Text = "ИНН";
            // 
            // textBoxOrgInn
            // 
            textBoxOrgInn.Location = new Point(3, 65);
            textBoxOrgInn.Name = "textBoxOrgInn";
            textBoxOrgInn.Size = new Size(300, 23);
            textBoxOrgInn.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(3, 3);
            label13.Name = "label13";
            label13.Size = new Size(90, 15);
            label13.TabIndex = 3;
            label13.Text = "Наименование";
            // 
            // textBoxOrgName
            // 
            textBoxOrgName.Location = new Point(3, 21);
            textBoxOrgName.Name = "textBoxOrgName";
            textBoxOrgName.Size = new Size(300, 23);
            textBoxOrgName.TabIndex = 2;
            // 
            // tabPage10
            // 
            tabPage10.Controls.Add(textBoxPriceListDesc);
            tabPage10.Controls.Add(label25);
            tabPage10.Controls.Add(textBoxPriceListValue);
            tabPage10.Controls.Add(label24);
            tabPage10.Controls.Add(comboBoxPriceListGood);
            tabPage10.Controls.Add(label23);
            tabPage10.Controls.Add(label22);
            tabPage10.Controls.Add(dateTimePickerPriceListDate);
            tabPage10.Controls.Add(comboBoxPriceListOrg);
            tabPage10.Controls.Add(label21);
            tabPage10.Location = new Point(4, 24);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(307, 356);
            tabPage10.TabIndex = 1;
            tabPage10.Text = "Прайс-лист";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // textBoxPriceListDesc
            // 
            textBoxPriceListDesc.Location = new Point(3, 199);
            textBoxPriceListDesc.Multiline = true;
            textBoxPriceListDesc.Name = "textBoxPriceListDesc";
            textBoxPriceListDesc.Size = new Size(300, 151);
            textBoxPriceListDesc.TabIndex = 25;
            // 
            // label25
            // 
            label25.AutoSize = true;
            label25.Location = new Point(3, 181);
            label25.Name = "label25";
            label25.Size = new Size(102, 15);
            label25.TabIndex = 24;
            label25.Text = "Описание товара";
            // 
            // textBoxPriceListValue
            // 
            textBoxPriceListValue.Location = new Point(3, 154);
            textBoxPriceListValue.Name = "textBoxPriceListValue";
            textBoxPriceListValue.Size = new Size(300, 23);
            textBoxPriceListValue.TabIndex = 23;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(3, 136);
            label24.Name = "label24";
            label24.Size = new Size(67, 15);
            label24.TabIndex = 22;
            label24.Text = "Стоимость";
            // 
            // comboBoxPriceListGood
            // 
            comboBoxPriceListGood.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPriceListGood.FormattingEnabled = true;
            comboBoxPriceListGood.Location = new Point(3, 110);
            comboBoxPriceListGood.Name = "comboBoxPriceListGood";
            comboBoxPriceListGood.Size = new Size(300, 23);
            comboBoxPriceListGood.TabIndex = 21;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Location = new Point(3, 92);
            label23.Name = "label23";
            label23.Size = new Size(39, 15);
            label23.TabIndex = 20;
            label23.Text = "Товар";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(3, 47);
            label22.Name = "label22";
            label22.Size = new Size(156, 15);
            label22.TabIndex = 19;
            label22.Text = "Дата поступления позиции";
            // 
            // dateTimePickerPriceListDate
            // 
            dateTimePickerPriceListDate.Location = new Point(3, 65);
            dateTimePickerPriceListDate.Name = "dateTimePickerPriceListDate";
            dateTimePickerPriceListDate.Size = new Size(298, 23);
            dateTimePickerPriceListDate.TabIndex = 18;
            // 
            // comboBoxPriceListOrg
            // 
            comboBoxPriceListOrg.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPriceListOrg.FormattingEnabled = true;
            comboBoxPriceListOrg.Location = new Point(3, 21);
            comboBoxPriceListOrg.Name = "comboBoxPriceListOrg";
            comboBoxPriceListOrg.Size = new Size(300, 23);
            comboBoxPriceListOrg.TabIndex = 17;
            comboBoxPriceListOrg.SelectedValueChanged += comboBoxPriceListOrg_SelectedValueChanged;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(3, 3);
            label21.Name = "label21";
            label21.Size = new Size(79, 15);
            label21.TabIndex = 16;
            label21.Text = "Организация";
            // 
            // dataGridViewOrg
            // 
            dataGridViewOrg.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOrg.Location = new Point(329, 6);
            dataGridViewOrg.Name = "dataGridViewOrg";
            dataGridViewOrg.RowTemplate.Height = 25;
            dataGridViewOrg.Size = new Size(512, 413);
            dataGridViewOrg.TabIndex = 4;
            // 
            // tabPage11
            // 
            tabPage11.Controls.Add(buttonDeletePhys);
            tabPage11.Controls.Add(buttonAddPhys);
            tabPage11.Controls.Add(tabControlPhys);
            tabPage11.Controls.Add(dataGridViewPhys);
            tabPage11.Location = new Point(4, 24);
            tabPage11.Name = "tabPage11";
            tabPage11.Padding = new Padding(3);
            tabPage11.Size = new Size(847, 425);
            tabPage11.TabIndex = 3;
            tabPage11.Text = "Физ. Лицо";
            tabPage11.UseVisualStyleBackColor = true;
            // 
            // buttonDeletePhys
            // 
            buttonDeletePhys.ForeColor = Color.Red;
            buttonDeletePhys.Location = new Point(8, 367);
            buttonDeletePhys.Name = "buttonDeletePhys";
            buttonDeletePhys.Size = new Size(309, 23);
            buttonDeletePhys.TabIndex = 14;
            buttonDeletePhys.Text = "Удалить";
            buttonDeletePhys.UseVisualStyleBackColor = true;
            buttonDeletePhys.Click += button1_Click;
            // 
            // buttonAddPhys
            // 
            buttonAddPhys.Location = new Point(8, 396);
            buttonAddPhys.Name = "buttonAddPhys";
            buttonAddPhys.Size = new Size(309, 23);
            buttonAddPhys.TabIndex = 7;
            buttonAddPhys.Text = "Добавить";
            buttonAddPhys.UseVisualStyleBackColor = true;
            buttonAddPhys.Click += buttonAddPhys_Click;
            // 
            // tabControlPhys
            // 
            tabControlPhys.Controls.Add(tabPage12);
            tabControlPhys.Controls.Add(tabPage13);
            tabControlPhys.Location = new Point(8, 6);
            tabControlPhys.Name = "tabControlPhys";
            tabControlPhys.SelectedIndex = 0;
            tabControlPhys.Size = new Size(315, 355);
            tabControlPhys.TabIndex = 6;
            tabControlPhys.SelectedIndexChanged += tabControlPhys_SelectedIndexChanged;
            // 
            // tabPage12
            // 
            tabPage12.Controls.Add(label29);
            tabPage12.Controls.Add(textBoxPassportWhoIssued);
            tabPage12.Controls.Add(label28);
            tabPage12.Controls.Add(dateTimePickerPassportIssue);
            tabPage12.Controls.Add(label27);
            tabPage12.Controls.Add(textBoxPassportNumber);
            tabPage12.Controls.Add(label26);
            tabPage12.Controls.Add(textBoxPassportSeries);
            tabPage12.Location = new Point(4, 24);
            tabPage12.Name = "tabPage12";
            tabPage12.Padding = new Padding(3);
            tabPage12.Size = new Size(307, 327);
            tabPage12.TabIndex = 0;
            tabPage12.Text = "Паспорт";
            tabPage12.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            label29.AutoSize = true;
            label29.Location = new Point(3, 134);
            label29.Name = "label29";
            label29.Size = new Size(82, 15);
            label29.TabIndex = 23;
            label29.Text = "Кто выпустил";
            // 
            // textBoxPassportWhoIssued
            // 
            textBoxPassportWhoIssued.Location = new Point(3, 152);
            textBoxPassportWhoIssued.Name = "textBoxPassportWhoIssued";
            textBoxPassportWhoIssued.Size = new Size(300, 23);
            textBoxPassportWhoIssued.TabIndex = 22;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Location = new Point(3, 90);
            label28.Name = "label28";
            label28.Size = new Size(81, 15);
            label28.TabIndex = 21;
            label28.Text = "Дата выпуска";
            // 
            // dateTimePickerPassportIssue
            // 
            dateTimePickerPassportIssue.Location = new Point(3, 108);
            dateTimePickerPassportIssue.Name = "dateTimePickerPassportIssue";
            dateTimePickerPassportIssue.Size = new Size(298, 23);
            dateTimePickerPassportIssue.TabIndex = 20;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Location = new Point(3, 46);
            label27.Name = "label27";
            label27.Size = new Size(45, 15);
            label27.TabIndex = 7;
            label27.Text = "Номер";
            // 
            // textBoxPassportNumber
            // 
            textBoxPassportNumber.Location = new Point(3, 64);
            textBoxPassportNumber.Name = "textBoxPassportNumber";
            textBoxPassportNumber.Size = new Size(300, 23);
            textBoxPassportNumber.TabIndex = 6;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Location = new Point(3, 3);
            label26.Name = "label26";
            label26.Size = new Size(41, 15);
            label26.TabIndex = 5;
            label26.Text = "Серия";
            // 
            // textBoxPassportSeries
            // 
            textBoxPassportSeries.Location = new Point(3, 21);
            textBoxPassportSeries.Name = "textBoxPassportSeries";
            textBoxPassportSeries.Size = new Size(300, 23);
            textBoxPassportSeries.TabIndex = 4;
            // 
            // tabPage13
            // 
            tabPage13.Controls.Add(comboBoxPhysPassport);
            tabPage13.Controls.Add(label32);
            tabPage13.Controls.Add(label31);
            tabPage13.Controls.Add(textBoxPhysFIO);
            tabPage13.Controls.Add(label30);
            tabPage13.Controls.Add(textBoxPhysINN);
            tabPage13.Location = new Point(4, 24);
            tabPage13.Name = "tabPage13";
            tabPage13.Padding = new Padding(3);
            tabPage13.Size = new Size(307, 327);
            tabPage13.TabIndex = 1;
            tabPage13.Text = "Физ. Лицо";
            tabPage13.UseVisualStyleBackColor = true;
            // 
            // comboBoxPhysPassport
            // 
            comboBoxPhysPassport.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPhysPassport.FormattingEnabled = true;
            comboBoxPhysPassport.Location = new Point(3, 109);
            comboBoxPhysPassport.Name = "comboBoxPhysPassport";
            comboBoxPhysPassport.Size = new Size(300, 23);
            comboBoxPhysPassport.TabIndex = 17;
            // 
            // label32
            // 
            label32.AutoSize = true;
            label32.Location = new Point(3, 91);
            label32.Name = "label32";
            label32.Size = new Size(60, 15);
            label32.TabIndex = 16;
            label32.Text = "Пасспорт";
            // 
            // label31
            // 
            label31.AutoSize = true;
            label31.Location = new Point(3, 3);
            label31.Name = "label31";
            label31.Size = new Size(120, 15);
            label31.TabIndex = 15;
            label31.Text = "ФИО (через пробел)";
            // 
            // textBoxPhysFIO
            // 
            textBoxPhysFIO.Location = new Point(3, 21);
            textBoxPhysFIO.Name = "textBoxPhysFIO";
            textBoxPhysFIO.Size = new Size(300, 23);
            textBoxPhysFIO.TabIndex = 14;
            // 
            // label30
            // 
            label30.AutoSize = true;
            label30.Location = new Point(3, 47);
            label30.Name = "label30";
            label30.Size = new Size(34, 15);
            label30.TabIndex = 7;
            label30.Text = "ИНН";
            // 
            // textBoxPhysINN
            // 
            textBoxPhysINN.Location = new Point(3, 65);
            textBoxPhysINN.Name = "textBoxPhysINN";
            textBoxPhysINN.Size = new Size(300, 23);
            textBoxPhysINN.TabIndex = 6;
            // 
            // dataGridViewPhys
            // 
            dataGridViewPhys.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPhys.Location = new Point(329, 6);
            dataGridViewPhys.Name = "dataGridViewPhys";
            dataGridViewPhys.RowTemplate.Height = 25;
            dataGridViewPhys.Size = new Size(512, 413);
            dataGridViewPhys.TabIndex = 5;
            // 
            // tabPage14
            // 
            tabPage14.Controls.Add(comboBoxOrderWho);
            tabPage14.Controls.Add(label36);
            tabPage14.Controls.Add(textBoxOrderAmount);
            tabPage14.Controls.Add(comboBoxOrderGood);
            tabPage14.Controls.Add(label35);
            tabPage14.Controls.Add(label34);
            tabPage14.Controls.Add(dateTimePickerOrderDate);
            tabPage14.Controls.Add(comboBoxOrderWhoType);
            tabPage14.Controls.Add(label33);
            tabPage14.Controls.Add(buttonAddOrder);
            tabPage14.Controls.Add(dataGridView1);
            tabPage14.Location = new Point(4, 24);
            tabPage14.Name = "tabPage14";
            tabPage14.Padding = new Padding(3);
            tabPage14.Size = new Size(847, 425);
            tabPage14.TabIndex = 4;
            tabPage14.Text = "Заказы";
            tabPage14.UseVisualStyleBackColor = true;
            // 
            // comboBoxOrderWho
            // 
            comboBoxOrderWho.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderWho.FormattingEnabled = true;
            comboBoxOrderWho.Location = new Point(3, 51);
            comboBoxOrderWho.Name = "comboBoxOrderWho";
            comboBoxOrderWho.Size = new Size(320, 23);
            comboBoxOrderWho.TabIndex = 27;
            // 
            // label36
            // 
            label36.AutoSize = true;
            label36.Location = new Point(3, 165);
            label36.Name = "label36";
            label36.Size = new Size(72, 15);
            label36.TabIndex = 25;
            label36.Text = "Количество";
            // 
            // textBoxOrderAmount
            // 
            textBoxOrderAmount.Location = new Point(3, 183);
            textBoxOrderAmount.Name = "textBoxOrderAmount";
            textBoxOrderAmount.Size = new Size(320, 23);
            textBoxOrderAmount.TabIndex = 24;
            // 
            // comboBoxOrderGood
            // 
            comboBoxOrderGood.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderGood.FormattingEnabled = true;
            comboBoxOrderGood.Location = new Point(3, 139);
            comboBoxOrderGood.Name = "comboBoxOrderGood";
            comboBoxOrderGood.Size = new Size(320, 23);
            comboBoxOrderGood.TabIndex = 23;
            // 
            // label35
            // 
            label35.AutoSize = true;
            label35.Location = new Point(3, 121);
            label35.Name = "label35";
            label35.Size = new Size(39, 15);
            label35.TabIndex = 22;
            label35.Text = "Товар";
            // 
            // label34
            // 
            label34.AutoSize = true;
            label34.Location = new Point(3, 77);
            label34.Name = "label34";
            label34.Size = new Size(69, 15);
            label34.TabIndex = 21;
            label34.Text = "Дата заказа";
            // 
            // dateTimePickerOrderDate
            // 
            dateTimePickerOrderDate.Location = new Point(3, 95);
            dateTimePickerOrderDate.Name = "dateTimePickerOrderDate";
            dateTimePickerOrderDate.Size = new Size(320, 23);
            dateTimePickerOrderDate.TabIndex = 20;
            // 
            // comboBoxOrderWhoType
            // 
            comboBoxOrderWhoType.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrderWhoType.FormattingEnabled = true;
            comboBoxOrderWhoType.Items.AddRange(new object[] { "Физ. Лицо", "Организация" });
            comboBoxOrderWhoType.Location = new Point(3, 22);
            comboBoxOrderWhoType.Name = "comboBoxOrderWhoType";
            comboBoxOrderWhoType.Size = new Size(320, 23);
            comboBoxOrderWhoType.TabIndex = 17;
            comboBoxOrderWhoType.SelectedIndexChanged += comboBoxOrderWhoType_SelectedIndexChanged;
            // 
            // label33
            // 
            label33.AutoSize = true;
            label33.Location = new Point(3, 4);
            label33.Name = "label33";
            label33.Size = new Size(57, 15);
            label33.TabIndex = 16;
            label33.Text = "Заказчик";
            // 
            // buttonAddOrder
            // 
            buttonAddOrder.Location = new Point(6, 396);
            buttonAddOrder.Name = "buttonAddOrder";
            buttonAddOrder.Size = new Size(317, 23);
            buttonAddOrder.TabIndex = 8;
            buttonAddOrder.Text = "Добавить";
            buttonAddOrder.UseVisualStyleBackColor = true;
            buttonAddOrder.Click += buttonAddOrder_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(329, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(512, 413);
            dataGridView1.TabIndex = 6;
            // 
            // dataGridViewBuffer
            // 
            dataGridViewBuffer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuffer.Location = new Point(857, 24);
            dataGridViewBuffer.Name = "dataGridViewBuffer";
            dataGridViewBuffer.RowTemplate.Height = 25;
            dataGridViewBuffer.Size = new Size(424, 419);
            dataGridViewBuffer.TabIndex = 1;
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(851, 450);
            Controls.Add(dataGridViewBuffer);
            Controls.Add(tabControlMain);
            Name = "App";
            Text = "Form1";
            tabControlMain.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewDir).EndInit();
            tabControlDirs.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            tabPage6.ResumeLayout(false);
            tabPage6.PerformLayout();
            tabPage7.ResumeLayout(false);
            tabPage7.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewGoods).EndInit();
            tabPage8.ResumeLayout(false);
            tabControlOrg.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
            tabPage10.ResumeLayout(false);
            tabPage10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrg).EndInit();
            tabPage11.ResumeLayout(false);
            tabControlPhys.ResumeLayout(false);
            tabPage12.ResumeLayout(false);
            tabPage12.PerformLayout();
            tabPage13.ResumeLayout(false);
            tabPage13.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPhys).EndInit();
            tabPage14.ResumeLayout(false);
            tabPage14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuffer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPage1;
        private DataGridView dataGridViewDir;
        private Button buttonAddDir;
        private TabControl tabControlDirs;
        private TabPage tabPage3;
        private Label label1;
        private TextBox textBoxStreetType;
        private TabPage tabPage4;
        private Label label2;
        private TextBox textBoxLocalityType;
        private TabPage tabPage2;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private ComboBox comboBoxStreetType;
        private Label label5;
        private Label label3;
        private TextBox textBoxStreetName;
        private Label label4;
        private TextBox textBoxLocalityName;
        private DataGridView dataGridViewBuffer;
        private ComboBox comboBoxLocalityType;
        private Label label6;
        private ComboBox comboBoxStreet;
        private Label label10;
        private ComboBox comboBoxLocality;
        private Label label9;
        private Label label8;
        private TextBox textBoxCampus;
        private Label label7;
        private TextBox textBoxHouseNum;
        private Button buttonAddGood;
        private Label label12;
        private TextBox textBoxGoodAmount;
        private Label label11;
        private TextBox textBoxGoodName;
        private DataGridView dataGridViewGoods;
        private TabPage tabPage8;
        private DataGridView dataGridViewOrg;
        private Button buttonAddOrg;
        private TabControl tabControlOrg;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private ComboBox comboBoxOrgAddress;
        private Label label19;
        private Label label18;
        private TextBox textBoxOrgFIO;
        private Label label17;
        private TextBox textBoxOrgSite;
        private Label label16;
        private TextBox textBoxOrgEmail;
        private Label label15;
        private TextBox textBoxOrgPhone;
        private Label label14;
        private TextBox textBoxOrgInn;
        private Label label13;
        private TextBox textBoxOrgName;
        private Label label20;
        private TextBox textBoxOrgReq;
        private TextBox textBoxPriceListDesc;
        private Label label25;
        private TextBox textBoxPriceListValue;
        private Label label24;
        private ComboBox comboBoxPriceListGood;
        private Label label23;
        private Label label22;
        private DateTimePicker dateTimePickerPriceListDate;
        private ComboBox comboBoxPriceListOrg;
        private Label label21;
        private TabPage tabPage11;
        private DataGridView dataGridViewPhys;
        private TabControl tabControlPhys;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private Label label29;
        private TextBox textBoxPassportWhoIssued;
        private Label label28;
        private DateTimePicker dateTimePickerPassportIssue;
        private Label label27;
        private TextBox textBoxPassportNumber;
        private Label label26;
        private TextBox textBoxPassportSeries;
        private Button buttonAddPhys;
        private Label label31;
        private TextBox textBoxPhysFIO;
        private Label label30;
        private TextBox textBoxPhysINN;
        private ComboBox comboBoxPhysPassport;
        private Label label32;
        private TabPage tabPage14;
        private DataGridView dataGridView1;
        private ComboBox comboBoxOrderWhoType;
        private Label label33;
        private Button buttonAddOrder;
        private Label label36;
        private TextBox textBoxOrderAmount;
        private ComboBox comboBoxOrderGood;
        private Label label35;
        private Label label34;
        private DateTimePicker dateTimePickerOrderDate;
        private ComboBox comboBoxOrderWho;
        private Button buttonDeleteDir;
        private Button buttonDeleteGood;
        private Button buttonDeleteOrg;
        private Button buttonDeletePhys;
    }
}
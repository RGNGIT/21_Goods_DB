﻿namespace _21_Goods_DB
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
            buttonAddGood = new Button();
            label12 = new Label();
            textBoxGoodAmount = new TextBox();
            label11 = new Label();
            textBoxGoodName = new TextBox();
            dataGridViewGoods = new DataGridView();
            dataGridViewBuffer = new DataGridView();
            tabPage8 = new TabPage();
            dataGridViewOrg = new DataGridView();
            tabControl1 = new TabControl();
            tabPage9 = new TabPage();
            tabPage10 = new TabPage();
            buttonAddOrg = new Button();
            label13 = new Label();
            textBoxOrgName = new TextBox();
            label14 = new Label();
            textBoxOrgInn = new TextBox();
            label15 = new Label();
            textBoxOrgPhone = new TextBox();
            label16 = new Label();
            textBoxOrgEmail = new TextBox();
            label17 = new Label();
            textBoxOrgSite = new TextBox();
            label18 = new Label();
            textBoxOrgFIO = new TextBox();
            comboBoxOrgAddress = new ComboBox();
            label19 = new Label();
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuffer).BeginInit();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrg).BeginInit();
            tabControl1.SuspendLayout();
            tabPage9.SuspendLayout();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Controls.Add(tabPage1);
            tabControlMain.Controls.Add(tabPage2);
            tabControlMain.Controls.Add(tabPage8);
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(855, 453);
            tabControlMain.TabIndex = 0;
            tabControlMain.SelectedIndexChanged += tabControlMain_SelectedIndexChanged;
            // 
            // tabPage1
            // 
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
            tabControlDirs.Size = new Size(317, 384);
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
            tabPage3.Size = new Size(309, 356);
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
            tabPage4.Size = new Size(309, 356);
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
            tabPage5.Size = new Size(309, 356);
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
            tabPage6.Size = new Size(309, 356);
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
            tabPage7.Size = new Size(309, 356);
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
            // dataGridViewBuffer
            // 
            dataGridViewBuffer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBuffer.Location = new Point(857, 24);
            dataGridViewBuffer.Name = "dataGridViewBuffer";
            dataGridViewBuffer.RowTemplate.Height = 25;
            dataGridViewBuffer.Size = new Size(424, 419);
            dataGridViewBuffer.TabIndex = 1;
            // 
            // tabPage8
            // 
            tabPage8.Controls.Add(buttonAddOrg);
            tabPage8.Controls.Add(tabControl1);
            tabPage8.Controls.Add(dataGridViewOrg);
            tabPage8.Location = new Point(4, 24);
            tabPage8.Name = "tabPage8";
            tabPage8.Padding = new Padding(3);
            tabPage8.Size = new Size(847, 425);
            tabPage8.TabIndex = 2;
            tabPage8.Text = "Организации";
            tabPage8.UseVisualStyleBackColor = true;
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
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage9);
            tabControl1.Controls.Add(tabPage10);
            tabControl1.Location = new Point(8, 6);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(315, 384);
            tabControl1.TabIndex = 5;
            // 
            // tabPage9
            // 
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
            // tabPage10
            // 
            tabPage10.Location = new Point(4, 24);
            tabPage10.Name = "tabPage10";
            tabPage10.Padding = new Padding(3);
            tabPage10.Size = new Size(307, 356);
            tabPage10.TabIndex = 1;
            tabPage10.Text = "Прайс-лист";
            tabPage10.UseVisualStyleBackColor = true;
            // 
            // buttonAddOrg
            // 
            buttonAddOrg.Location = new Point(8, 396);
            buttonAddOrg.Name = "buttonAddOrg";
            buttonAddOrg.Size = new Size(311, 23);
            buttonAddOrg.TabIndex = 6;
            buttonAddOrg.Text = "Добавить";
            buttonAddOrg.UseVisualStyleBackColor = true;
            buttonAddOrg.Click += buttonAddOrg_Click;
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
            // comboBoxOrgAddress
            // 
            comboBoxOrgAddress.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxOrgAddress.FormattingEnabled = true;
            comboBoxOrgAddress.Location = new Point(3, 285);
            comboBoxOrgAddress.Name = "comboBoxOrgAddress";
            comboBoxOrgAddress.Size = new Size(300, 23);
            comboBoxOrgAddress.TabIndex = 15;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(3, 267);
            label19.Name = "label19";
            label19.Size = new Size(40, 15);
            label19.TabIndex = 14;
            label19.Text = "Адрес";
            // 
            // App
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1293, 450);
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
            ((System.ComponentModel.ISupportInitialize)dataGridViewBuffer).EndInit();
            tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOrg).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage9.ResumeLayout(false);
            tabPage9.PerformLayout();
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
        private TabControl tabControl1;
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
    }
}
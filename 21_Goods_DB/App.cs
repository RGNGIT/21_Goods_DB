using System.Windows.Forms.DataVisualization.Charting;

namespace _21_Goods_DB
{
    public partial class App : Form
    {
        public App()
        {
            // Ничего интересного, запуск проги и обновление первого грида со справками
            InitializeComponent();
            DirGridUpdater();
            chartTZ3.Series.Clear();
        }
        // Твоя строка подключения, сейчас здесь моя, надо будет поменять
        string connection = "Server=AORUS;Integrated Security=true;";
        // Добавление элемента в справочник
        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            // В зависимости от того, на какой странице справочника находимся, добавляем. Данные берем из текстбоксов 
            switch (tabControlDirs.SelectedIndex)
            {
                case 0: db.AddStreetType(textBoxStreetType.Text); break;
                case 1: db.AddLocalityType(textBoxLocalityType.Text); break;
                case 2: db.AddStreet(textBoxStreetName.Text, comboBoxStreetType.Text.Split(' ')[0]); break;
                case 3: db.AddLocality(textBoxLocalityName.Text, comboBoxLocalityType.Text.Split(' ')[0]); break;
                case 4: db.AddAddress(textBoxHouseNum.Text, textBoxCampus.Text, comboBoxStreet.Text.Split(' ')[0], comboBoxLocality.Text.Split(' ')[0]); break;
            }
            DirGridUpdater();
            db.connection.Close();
        }

        void GoodGridUpdater()
        {
            DatabaseWorks db = new(connection);
            // Обновлятор таблицы с товарами
            dataGridViewGoods.DataSource = db.ReturnTable("a.id, a.name as Наименование, a.amount as Количество", "Goods.dbo.Good as a", null!);
            db.connection.Close();
        }

        void DirGridUpdater()
        {
            DatabaseWorks db = new(connection);
            // Обновлятор таблицы со справочниками
            switch (tabControlDirs.SelectedIndex)
            {
                case 0: dataGridViewDir.DataSource = db.ReturnTable("a.id, a.name AS Наименование", "Goods.dbo.StreetType AS a", null!); break;
                case 1: dataGridViewDir.DataSource = db.ReturnTable("a.id, a.name AS Наименование", "Goods.dbo.LocalityType AS a", null!); break;
                case 2: dataGridViewDir.DataSource = db.ReturnTable("a.id, a.name AS Наименование, b.name AS 'Тип улицы'", "Goods.dbo.Street AS a, Goods.dbo.StreetType AS b", "WHERE a.streetTypeId = b.id"); break;
                case 3: dataGridViewDir.DataSource = db.ReturnTable("a.id, a.name AS Наименование, b.name AS 'Тип улицы'", "Goods.dbo.Locality AS a, Goods.dbo.LocalityType AS b", "WHERE a.localityTypeId = b.id"); break;
                case 4: dataGridViewDir.DataSource = db.ReturnTable("a.id, a.houseNumber as 'Номер дома', a.campus as Корпус, c.name as Улица, b.name as 'Населенный пункт'", "Goods.dbo.Address AS a, Goods.dbo.Locality AS b, Goods.dbo.Street as c", "WHERE a.localityId = b.id AND a.streetId = c.id"); break;
            }
            db.connection.Close();
        }

        void OrgAddressComboUpdater()
        {
            DatabaseWorks db = new(connection);
            comboBoxOrgAddress.Items.Clear();
            // Снова скучные обновляторы. Вобщем этот и подобные заполняют либо комбо боксы, либо таблицы данными из бд
            dataGridViewBuffer.DataSource = db.ReturnTable("a.id, c.name as lname, b.name as sname, a.houseNumber, a.campus", "Goods.dbo.Address as a, Goods.dbo.Street as b, Goods.dbo.Locality as c", "WHERE a.streetId = b.id AND a.localityId = c.id");
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxOrgAddress.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}, ул. {dataGridViewBuffer.Rows[i].Cells[2].Value}, д. {dataGridViewBuffer.Rows[i].Cells[3].Value}, корпус {dataGridViewBuffer.Rows[i].Cells[4].Value}");
            }
            db.connection.Close();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Автоматическая менюшка, которая делает что-то в зависимости от того, на какой мы вкладке
            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    DirGridUpdater();
                    break;
                case 1:
                    GoodGridUpdater();
                    break;
                case 2:
                    OrgAddressComboUpdater();
                    PriceListOrgComboUpdater();
                    PriceListGoodsComboUpdater();
                    OrgGridUpdater();
                    break;
                case 3:
                    PhysGridUpdater();
                    break;
                case 4:
                    UpdateOrderGoodCombo();
                    break;
                case 5:
                    TZUpdaters();
                    break;
            }
        }

        void UpdateTZ1GoodCombo()
        {
            DatabaseWorks db = new(connection);
            comboBoxTZ1Goods.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("a.id, a.name as Наименование", "Goods.dbo.Good as a", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxTZ1Goods.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        void TZUpdaters()
        {
            switch (tabControlTZ.SelectedIndex)
            {
                case 0:
                    UpdateTZ1GoodCombo();
                    break;
                case 1:
                    break;
                case 2:
                    UpdateTZ3Combo();
                    break;
            }
        }

        // Обновлятор
        void StreetTypeComboUpdater()
        {
            DatabaseWorks db = new(connection);
            comboBoxStreetType.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "Goods.dbo.StreetType", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxStreetType.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }
        // Обновлятор
        void LocalityTypeComboUpdater()
        {
            DatabaseWorks db = new(connection);
            comboBoxLocalityType.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "Goods.dbo.LocalityType", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxLocalityType.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }
        // Обновлятор
        void StreetComboUpdater()
        {
            DatabaseWorks db = new(connection);
            comboBoxStreet.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "Goods.dbo.Street", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxStreet.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }
        // Обновлятор
        void LocalityComboUpdater()
        {
            DatabaseWorks db = new(connection);
            comboBoxLocality.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "Goods.dbo.Locality", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxLocality.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }
        // Обновлятор
        void OrgGridUpdater()
        {
            DatabaseWorks db = new(connection);
            switch (tabControlOrg.SelectedIndex)
            {
                case 0:
                    dataGridViewOrg.DataSource = db.ReturnTable("id, name as Наименование, inn as ИНН, req as Реквизиты, phone as Телефон, email as Эмейл, site as Сайт, predName as 'Имя представителя', predSurname as 'Фамилия представителя'", "Goods.dbo.Organization", null!);
                    break;
                case 1:
                    dataGridViewOrg.DataSource = db.ReturnTable("b.id, c.name as 'Название товара', b.dateReleased as 'Дата выпуска', b.goodDesc as Описание, b.goodPrice as Стоимость", "Goods.dbo.PriceList_Organization as a, Goods.dbo.PriceList as b, Goods.dbo.Good as c", $"WHERE a.organizationId = '{comboBoxPriceListOrg.Text.Split(' ')[0]}' AND b.id = a.priceListId AND b.goodId = c.id");
                    dataGridViewBuffer.DataSource = db.ReturnTable("a.id", "Goods.dbo.PriceList as a", null!);
                    break;
            }
            db.connection.Close();
        }
        // Обновлятор
        void PriceListOrgComboUpdater()
        {
            comboBoxPriceListOrg.Items.Clear();
            DatabaseWorks db = new(connection);
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "Goods.dbo.Organization", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxPriceListOrg.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}. Реквизиты: {dataGridViewBuffer.Rows[i].Cells[9].Value}");
            }
            db.connection.Close();
        }
        // Обновлятор
        void PriceListGoodsComboUpdater()
        {
            comboBoxPriceListGood.Items.Clear();
            DatabaseWorks db = new(connection);
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "Goods.dbo.Good", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxPriceListGood.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        private void tabControlDirs_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Снова автоменюшка, только теперь подвкладок справочников
            DirGridUpdater();
            switch (tabControlDirs.SelectedIndex)
            {
                case 2:
                    StreetTypeComboUpdater();
                    break;
                case 3:
                    LocalityTypeComboUpdater();
                    break;
                case 4:
                    StreetComboUpdater();
                    LocalityComboUpdater();
                    break;
            }
        }

        private void buttonAddGood_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            // Добавить товар
            db.AddGood(textBoxGoodName.Text, textBoxGoodAmount.Text);
            GoodGridUpdater();
            db.connection.Close();
        }

        private void buttonAddOrg_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            switch (tabControlOrg.SelectedIndex)
            {
                // Добавить организацию
                case 0:
                    string[] FIO = textBoxOrgFIO.Text.Split(' ');
                    db.AddOrganization(textBoxOrgName.Text, textBoxOrgInn.Text, textBoxOrgPhone.Text, textBoxOrgEmail.Text, textBoxOrgSite.Text, FIO[1], FIO[0], FIO[2], comboBoxOrgAddress.Text.Split(' ')[0], textBoxOrgReq.Text);
                    break;
                // Добавить прайслист
                case 1:
                    db.AddPriceListItem(comboBoxPriceListOrg.Text.Split(' ')[comboBoxPriceListOrg.Text.Split(' ').Length - 1], dateTimePickerPriceListDate.Value.ToString("dd/MM/yyyy"), textBoxPriceListDesc.Text, textBoxPriceListValue.Text, comboBoxPriceListGood.Text.Split(' ')[0]);
                    int itemId = dataGridViewBuffer.Rows.Count > 1 ? int.Parse(dataGridViewBuffer.Rows[dataGridViewBuffer.Rows.Count - 2].Cells[0].Value.ToString()!) + 1 : -1;
                    db.ConnectItemOrg(itemId.ToString(), comboBoxPriceListOrg.Text.Split(' ')[0]);
                    break;
            }
            OrgGridUpdater();
            db.connection.Close();
        }
        // Вызов обновляторов
        private void tabControlOrg_SelectedIndexChanged(object sender, EventArgs e)
        {
            OrgAddressComboUpdater();
            PriceListOrgComboUpdater();
            PriceListGoodsComboUpdater();
            OrgGridUpdater();
        }

        private void comboBoxPriceListOrg_SelectedValueChanged(object sender, EventArgs e)
        {
            OrgGridUpdater();
        }
        // Обновлятор
        void PhysGridUpdater()
        {
            DatabaseWorks db = new(connection);
            switch (tabControlPhys.SelectedIndex)
            {
                case 0:
                    dataGridViewPhys.DataSource = db.ReturnTable("a.id, a.series as Серия, a.number as Номер, a.dateIssued as 'Дата выдачи', a.issuerName as 'Кто выпустил'", "Goods.dbo.Passport as a", null!);
                    break;
                case 1:
                    PhysPassportComboUpdater();
                    dataGridViewPhys.DataSource = db.ReturnTable("a.id, a.name as Имя, a.surname as Фамилия, a.patron as Отчество, a.inn as ИНН, b.series as Серия, b.number as Номер", "Goods.dbo.Phys as a, Goods.dbo.Passport as b", null!);
                    break;
            }
            db.connection.Close();
        }
        // Обновлятор
        void PhysPassportComboUpdater()
        {
            DatabaseWorks db = new(connection);
            comboBoxPhysPassport.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "Goods.dbo.Passport", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxPhysPassport.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} Серия: {dataGridViewBuffer.Rows[i].Cells[1].Value}. Номер: {dataGridViewBuffer.Rows[i].Cells[2].Value}");
            }
            db.connection.Close();
        }
        // Обновлятор
        void UpdateOrderWhoCombo(int type)
        {
            DatabaseWorks db = new(connection);
            comboBoxOrderWho.Items.Clear();
            switch (type)
            {
                case 0:
                    dataGridViewBuffer.DataSource = db.ReturnTable("a.id, a.surname, a.name, a.patron", "Goods.dbo.Phys as a", null!);
                    for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
                    {
                        comboBoxOrderWho.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value} {dataGridViewBuffer.Rows[i].Cells[2].Value} {dataGridViewBuffer.Rows[i].Cells[3].Value}");
                    }
                    break;
                case 1:
                    dataGridViewBuffer.DataSource = db.ReturnTable("a.id, a.name", "Goods.dbo.Organization as a", null!);
                    for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
                    {
                        comboBoxOrderWho.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
                    }
                    break;
            }
            db.connection.Close();
        }
        // Обновлятор
        void UpdateOrderGoodCombo()
        {
            DatabaseWorks db = new(connection);
            comboBoxOrderGood.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable(
                "a.id, a.name as gname, d.name as orgname, c.goodPrice",
                "Goods.dbo.Good as a, Goods.dbo.PriceList_Organization as b, Goods.dbo.PriceList as c, Goods.dbo.Organization as d",
                "WHERE a.id = c.goodId AND b.priceListId = c.id AND b.organizationId = d.id"
            );
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxOrderGood.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}. Предлагает \"{dataGridViewBuffer.Rows[i].Cells[2].Value}\" за '{dataGridViewBuffer.Rows[i].Cells[3].Value}'p.");
            }
            db.connection.Close();
        }

        private void buttonAddPhys_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            switch (tabControlPhys.SelectedIndex)
            {
                // Добавить паспорт
                case 0:
                    db.AddPassport(textBoxPassportSeries.Text, textBoxPassportNumber.Text, dateTimePickerPassportIssue.Value.ToString("dd/MM/yyyy"), textBoxPassportWhoIssued.Text);
                    break;
                case 1:
                    // Добавить физлицо
                    string[] FIO = textBoxPhysFIO.Text.Split(' ');
                    db.AddPhys(FIO[1], FIO[0], FIO[2], textBoxPhysINN.Text, comboBoxPhysPassport.Text.Split(' ')[0]);
                    break;
            }
            PhysGridUpdater();
            db.connection.Close();
        }
        // Вызов обновлятора
        private void tabControlPhys_SelectedIndexChanged(object sender, EventArgs e)
        {
            PhysGridUpdater();
        }

        int GenerateNumber()
        {
            Random rnd = new Random();
            return rnd.Next(0, 9999999);
        }

        void UpdateOrderGridPhys(string UnitId)
        {
            DatabaseWorks db = new(connection);
            dataGridViewOrders.DataSource = db.ReturnTable(
                "a.date as 'Дата заказа', a.sum as 'Сумма заказа', a.number as 'Номер заказа', a.amount as 'Количество', b.name as 'Товар'",
                "Goods.dbo.[Order] as a, Goods.dbo.Good as b",
                $"WHERE a.goodId = b.id AND a.physId = {UnitId}"
            );
            db.connection.Close();
        }

        void UpdateOrderGridOrg(string UnitId)
        {
            DatabaseWorks db = new(connection);
            dataGridViewOrders.DataSource = db.ReturnTable(
                "a.date as 'Дата заказа', a.sum as 'Сумма заказа', a.number as 'Номер заказа', a.amount as 'Количество', b.name as 'Товар'",
                "Goods.dbo.[Order] as a, Goods.dbo.Good as b",
                $"WHERE a.goodId = b.id AND a.organizationId = {UnitId}"
            );
            db.connection.Close();
        }

        private void buttonAddOrder_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            switch (comboBoxOrderWhoType.SelectedIndex)
            {
                case 0:
                    MessageBox.Show(db.AddOrder(
                        dateTimePickerOrderDate.Value.ToString("dd/MM/yyyy"),
                        (double.Parse(comboBoxOrderGood.Text.Split("'")[comboBoxOrderGood.Text.Split("'").Length - 2]) * int.Parse(textBoxOrderAmount.Text)).ToString(),
                        GenerateNumber().ToString(),
                        textBoxOrderAmount.Text,
                        dateTimePickerOrderDate.Value.ToString("dd/MM/yyyy"),
                        comboBoxOrderGood.Text.Split(" ")[0],
                        comboBoxOrderWho.Text.Split(" ")[0],
                        "NULL"
                        ));
                    UpdateOrderGridPhys(comboBoxOrderWho.Text.Split(" ")[0]);
                    break;
                case 1:
                    db.AddOrder(
                        dateTimePickerOrderDate.Value.ToString("dd/MM/yyyy"),
                        (double.Parse(comboBoxOrderGood.Text.Split("'")[comboBoxOrderGood.Text.Split("'").Length - 2]) * int.Parse(textBoxOrderAmount.Text)).ToString(),
                        GenerateNumber().ToString(),
                        textBoxOrderAmount.Text,
                        dateTimePickerOrderDate.Value.ToString("dd/MM/yyyy"),
                        comboBoxOrderGood.Text.Split(" ")[0],
                        "NULL",
                        comboBoxOrderWho.Text.Split(" ")[0]
                        );
                    UpdateOrderGridOrg(comboBoxOrderWho.Text.Split(" ")[0]);
                    break;
            }
            db.connection.Close();
        }
        // Вызов обновлятора
        private void comboBoxOrderWhoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateOrderWhoCombo(comboBoxOrderWhoType.SelectedIndex);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            string[] tables = new string[5]
            {
                "Goods.dbo.StreetType",
                "Goods.dbo.LocalityType",
                "Goods.dbo.Street",
                "Goods.dbo.Locality",
                "Goods.dbo.Address"
            };
            db.Delete(dataGridViewDir.SelectedRows[0].Cells[0].Value.ToString()!, tables[tabControlDirs.SelectedIndex]);
            DirGridUpdater();
            db.connection.Close();
        }

        private void buttonDeleteGood_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            db.Delete(dataGridViewGoods.SelectedRows[0].Cells[0].Value.ToString()!, "Goods.dbo.Good");
            GoodGridUpdater();
            db.connection.Close();
        }

        private void buttonDeleteOrg_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            string[] tables = new string[2]
            {
                "Goods.dbo.Organization",
                "Goods.dbo.PriceList"
            };
            db.Delete(dataGridViewOrg.SelectedRows[0].Cells[0].Value.ToString()!, tables[tabControlOrg.SelectedIndex]);
            OrgGridUpdater();
            db.connection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            string[] tables = new string[2]
            {
                "Goods.dbo.Passport",
                "Goods.dbo.Phys"
            };
            db.Delete(dataGridViewPhys.SelectedRows[0].Cells[0].Value.ToString()!, tables[tabControlPhys.SelectedIndex]);
            PhysGridUpdater();
            db.connection.Close();
        }

        private void comboBoxOrderWho_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxOrderWhoType.SelectedIndex)
            {
                case 0:
                    UpdateOrderGridPhys(comboBoxOrderWho.Text.Split(" ")[0]);
                    break;
                case 1:
                    UpdateOrderGridOrg(comboBoxOrderWho.Text.Split(" ")[0]);
                    break;
            }
        }

        private void comboBoxTZ1Goods_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
            dataGridViewTZ1Phys.DataSource = db.ReturnTable("b.name as 'Имя', b.surname as 'Фамилия', b.patron as 'Отчество', b.inn as 'ИНН'", $"Goods.dbo.[Order] as a, Goods.dbo.Phys as b", $"WHERE a.physId = b.id AND a.goodId = {comboBoxTZ1Goods.Text.Split(' ')[0]}");
            dataGridViewTZ1Org.DataSource = db.ReturnTable("b.name as 'Наименование', b.inn as 'ИНН'", $"Goods.dbo.[Order] as a, Goods.dbo.Organization as b", $"WHERE a.organizationId = b.id AND a.goodId = {comboBoxTZ1Goods.Text.Split(' ')[0]}");
            db.connection.Close();
        }

        void UpdateTZ3Combo()
        {
            DatabaseWorks db = new(connection);
            comboBoxTZ3.Items.Clear();
            dataGridViewBuffer.DataSource = db.ReturnTable("*", "Goods.dbo.Good", null!);
            for (int i = 0; i < dataGridViewBuffer.Rows.Count - 1; i++)
            {
                comboBoxTZ3.Items.Add($"{dataGridViewBuffer.Rows[i].Cells[0].Value} {dataGridViewBuffer.Rows[i].Cells[1].Value}");
            }
            db.connection.Close();
        }

        void UpdateTZ2Grid()
        {
            DatabaseWorks db = new(connection);
            dataGridViewTZ2.DataSource = db.ReturnTable(
                "a.name as Наименование, b.goodPrice as 'Стоимость'",
                "Goods.dbo.Good as a, Goods.dbo.PriceList as b",
                $"WHERE b.dateReleased BETWEEN '{dateTimePickerTZ2From.Value.ToString("dd/MM/yyyy")}' AND '{dateTimePickerTZ2To.Value.ToString("dd/MM/yyyy")}' AND b.goodId = a.id"
                );
            db.connection.Close();
        }

        private void dateTimePickerTZ2From_ValueChanged(object sender, EventArgs e)
        {
            UpdateTZ2Grid();
        }

        private void dateTimePickerTZ2To_ValueChanged(object sender, EventArgs e)
        {
            UpdateTZ2Grid();
        }

        private void tabControlTZ_SelectedIndexChanged(object sender, EventArgs e)
        {
            TZUpdaters();
        }

        void UpdateTZ3Chart()
        {
            chartTZ3.Series.Clear();
            int counter = 0;
            chartTZ3.Series.Add(new Series("Динамика стоимости")
            {
                ChartType = SeriesChartType.Spline,
                BorderWidth = 3
            });
            for (int i = 0; i < dataGridViewTZ3.Rows.Count - 1; i++)
            {
                chartTZ3.Series["Динамика стоимости"].Points.AddXY(++counter, float.Parse(dataGridViewTZ3.Rows[i].Cells[3].Value.ToString()!));
            }
        }

        void UpdateTZ3Grid()
        {
            DatabaseWorks db = new(connection);
            dataGridViewTZ3.DataSource = db.ReturnTable(
                "a.name as Наименование, b.dateReleased as 'Дата объявления', d.name as 'Организация', b.goodPrice as 'Стоимость'",
                "Goods.dbo.Good as a, Goods.dbo.PriceList as b, Goods.dbo.PriceList_Organization as c, Goods.dbo.Organization as d",
                $"WHERE b.dateReleased BETWEEN '{dateTimePickerTZ2From.Value.ToString("dd/MM/yyyy")}' AND '{dateTimePickerTZ2To.Value.ToString("dd/MM/yyyy")}' AND b.goodId = {comboBoxTZ3.Text.Split(' ')[0]} AND a.id = {comboBoxTZ3.Text.Split(' ')[0]} AND c.organizationId = d.id AND c.priceListId = b.id"
                );
            UpdateTZ3Chart();
            db.connection.Close();
        }

        private void comboBoxTZ3_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateTZ3Grid();
        }
    }
}
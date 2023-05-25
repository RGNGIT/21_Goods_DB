namespace _21_Goods_DB
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
            DirGridUpdater();
        }

        string connection = "Server=AORUS;Integrated Security=true;";

        private void buttonAddDir_Click(object sender, EventArgs e)
        {
            DatabaseWorks db = new(connection);
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
            dataGridViewGoods.DataSource = db.ReturnTable("a.name as Наименование, a.amount as Количество", "Goods.dbo.Good as a", null!);
            db.connection.Close();
        }

        void DirGridUpdater()
        {
            DatabaseWorks db = new(connection);
            switch (tabControlDirs.SelectedIndex)
            {
                case 0: dataGridViewDir.DataSource = db.ReturnTable("a.name AS Наименование", "Goods.dbo.StreetType AS a", null!); break;
                case 1: dataGridViewDir.DataSource = db.ReturnTable("a.name AS Наименование", "Goods.dbo.LocalityType AS a", null!); break;
                case 2: dataGridViewDir.DataSource = db.ReturnTable("a.name AS Наименование, b.name AS 'Тип улицы'", "Goods.dbo.Street AS a, Goods.dbo.StreetType AS b", "WHERE a.streetTypeId = b.id"); break;
                case 3: dataGridViewDir.DataSource = db.ReturnTable("a.name AS Наименование, b.name AS 'Тип улицы'", "Goods.dbo.Locality AS a, Goods.dbo.LocalityType AS b", "WHERE a.localityTypeId = b.id"); break;
                case 4: dataGridViewDir.DataSource = db.ReturnTable("a.houseNumber as 'Номер дома', a.campus as Корпус, c.name as Улица, b.name as 'Населенный пункт'", "Goods.dbo.Address AS a, Goods.dbo.Locality AS b, Goods.dbo.Street as c", "WHERE a.localityId = b.id AND a.streetId = c.id"); break;
            }
            db.connection.Close();
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (tabControlMain.SelectedIndex)
            {
                case 0:
                    DirGridUpdater();
                    break;
                case 1:
                    GoodGridUpdater();
                    break;
            }
        }

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

        private void tabControlDirs_SelectedIndexChanged(object sender, EventArgs e)
        {
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
            db.AddGood(textBoxGoodName.Text, textBoxGoodAmount.Text);
            GoodGridUpdater();
            db.connection.Close();
        }

        private void buttonAddOrg_Click(object sender, EventArgs e)
        {

        }
    }
}
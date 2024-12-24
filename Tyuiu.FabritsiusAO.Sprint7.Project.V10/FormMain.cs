using Tyuiu.FabritsiusAO.Sprint7.Project.V10.Lib;

namespace Tyuiu.FabritsiusAO.Sprint7.Project.V10
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_FAO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_FAO.Filter = "Значения, разделенные запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        string openFilePath;
        public bool fileOpened = false;

        //Общая функция поиска
        public void Search(DataGridView dataGrid, string searchValue, int searchableValue)
        {
            dataGrid.ClearSelection();
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[searchableValue].Value.ToString().ToUpper() == searchValue)
                {
                    dataGrid.FirstDisplayedScrollingRowIndex = row.Index;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        cell.Selected = true;
                    }
                }
            }
        }

        //Общее сокрытие рядов
        public void InvisibleRowsByColors(DataGridView dataGrid, Color color, bool rowVisibility)
        {
            foreach (DataGridViewRow row in dataGrid.Rows)
            {
                if (row.Cells[0].Style.BackColor == color)
                {
                    row.Visible = rowVisibility;
                }
            }
        }
        //Переключение видимости кнопок редактирования строк
        private void tabControlTable_FAO_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabControlTable_FAO.SelectedIndex == 1 && fileOpened)
            {
                this.buttonAddRow_FAO.Enabled = true;
                this.buttonDeleteMarkedRow_FAO.Enabled = true;
                checkBoxMarkRow_FAO.Enabled = true;
                if (checkBoxMarkRow_FAO.Checked)
                {
                    buttonMarkDelete_FAO.Enabled = true;
                    buttonUnmarkDelete_FAO.Enabled = true;
                }

            }
            else
            {
                this.buttonAddRow_FAO.Enabled = false;
                this.buttonDeleteMarkedRow_FAO.Enabled = false;
                checkBoxMarkRow_FAO.Enabled = false;
                buttonMarkDelete_FAO.Enabled = false;
                buttonUnmarkDelete_FAO.Enabled = false;
            }
        }

        //Поиск
        private void buttonReadOnlySearchOrderID_FAO_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxReadOnlySearchOrderID_FAO.Text;
            Search(dataGridViewReadOnly_FAO, searchValue, 0);
        }
        private void buttonReadOnlySearchUserID_FAO_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxReadOnlySearchUserID_FAO.Text;
            Search(dataGridViewReadOnly_FAO, searchValue, 1);
        }
        private void buttonEditSearchOrderID_FAO_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxEditSearchOrderID_FAO.Text;
            Search(dataGridViewEdit_FAO, searchValue, 0);
        }
        private void buttonEditSearchUserID_FAO_Click(object sender, EventArgs e)
        {
            string searchValue = textBoxEditSearchUserID_FAO.Text;
            Search(dataGridViewEdit_FAO, searchValue, 1);
        }


        private void checkBoxMarkRow_FAO_Checked(object sender, EventArgs e)
        {
            if (checkBoxMarkRow_FAO.CheckState == CheckState.Checked)
            {
                buttonMarkDelete_FAO.Enabled = true;
                buttonUnmarkDelete_FAO.Enabled = true;
                dataGridViewEdit_FAO.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            }
            else
            {
                buttonMarkDelete_FAO.Enabled = false;
                buttonUnmarkDelete_FAO.Enabled = false;
                dataGridViewEdit_FAO.SelectionMode = DataGridViewSelectionMode.CellSelect;
            }
        }
        //Добавление строки
        private void buttonAdd_FAO_Click(object sender, EventArgs e)
        {
            dataGridViewEdit_FAO.Rows.Add(0, 0, "01.01.2024", "ВВОД", 0, "ВВОД", 0, 0);
            foreach (DataGridViewCell cell in dataGridViewEdit_FAO.Rows[^1].Cells)
            {
                cell.Style.BackColor = Color.Aqua;
            }
        }
        //Окрашивание ячейки при изменении
        private void dataGridViewEdit_FAO_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewEdit_FAO.Rows[e.RowIndex].Cells[e.ColumnIndex];

                var previousValue = dataGridViewEdit_FAO.Rows[e.RowIndex].Cells[e.ColumnIndex].Tag;

                if (previousValue == null || !cell.Value.Equals(previousValue))
                {
                    cell.Style.BackColor = Color.Green;
                }

                cell.Tag = cell.Value;
            }
        }

        private void dataGridViewEdit_FAO_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewEdit_FAO.Rows[e.RowIndex].Cells[e.ColumnIndex];
                cell.Tag = cell.Value;
            }
        }
        //Проверка на пустое содержание ячейки
        private void dataGridViewEdit_FAO_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var cell = dataGridViewEdit_FAO.Rows[e.RowIndex].Cells[e.ColumnIndex];

                if (string.IsNullOrWhiteSpace(e.FormattedValue.ToString()))
                {
                    e.Cancel = true;

                    cell.Value = cell.Tag;
                }
            }
        }

        //Покраска выделенных ячеек на удаление
        private void buttonMarkDelete_FAO_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEdit_FAO.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.OrangeRed;
                }
            }
        }

        //Удаление строки
        private void buttonDeleteMarkedRow_FAO_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Вы уверены, что хотите удалить выделенные ряды? Это действие необратимо.", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirmResult == DialogResult.Yes)
            {
                for (int i = dataGridViewEdit_FAO.Rows.Count - 1; i >= 0; i--)
                {
                    if (dataGridViewEdit_FAO.Rows[i].Cells[0].Style.BackColor == Color.OrangeRed)
                    {
                        dataGridViewEdit_FAO.Rows.RemoveAt(i);
                    }
                }
            }
        }

        //Убирание покраски удаления
        private void buttonUnmarkDelete_FAO_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewEdit_FAO.SelectedRows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Style.BackColor == Color.OrangeRed)
                    {
                        cell.Style.BackColor = Color.FromKnownColor(KnownColor.ControlLightLight);
                    }
                }
            }
        }
        //Открытие файла
        private void buttonOpenFile_FAO_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            openFileDialogTask_FAO.ShowDialog();
            openFilePath = openFileDialogTask_FAO.FileName;

            string[,] arrayValues = ds.GetMatrix(openFilePath);

            dataGridViewReadOnly_FAO.RowCount = arrayValues.GetLength(0);
            dataGridViewEdit_FAO.RowCount = arrayValues.GetLength(0);

            dataGridViewReadOnly_FAO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridViewEdit_FAO.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

            buttonSaveFile_FAO.Enabled = true;
            fileOpened = true;

            for (int i = 0; i < dataGridViewReadOnly_FAO.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridViewReadOnly_FAO.Columns.Count; j++)
                {
                    if (j == 0 || j == 1 || j == 4 || j == 6 || j == 7)
                    {
                        dataGridViewEdit_FAO.Rows[i].Cells[j].Value = Convert.ToInt32(arrayValues[i, j]);
                        dataGridViewReadOnly_FAO.Rows[i].Cells[j].Value = Convert.ToInt32(arrayValues[i, j]);
                        dataGridViewEdit_FAO.Columns[j].ValueType = typeof(int);
                    }
                    else if (j == 2)
                    {
                        DateOnly date;
                        date = DateOnly.ParseExact(arrayValues[i, j], "dd.MM.yyyy", null);
                        dataGridViewEdit_FAO.Rows[i].Cells[j].Value = date;
                        dataGridViewReadOnly_FAO.Rows[i].Cells[j].Value = date;
                    }
                    else
                    {
                        dataGridViewEdit_FAO.Rows[i].Cells[j].Value = arrayValues[i, j].ToUpper();
                        dataGridViewReadOnly_FAO.Rows[i].Cells[j].Value = arrayValues[i, j].ToUpper();
                        dataGridViewEdit_FAO.Columns[j].ValueType = typeof(string);
                    }
                }
            }
            foreach (DataGridViewRow row in dataGridViewEdit_FAO.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    cell.Style.BackColor = Color.White;
                    cell.Tag = null;
                }
            }
        }

        private void buttonSaveFile_FAO_Click(object sender, EventArgs e)
        {

            saveFileDialogTask_FAO.FileName = "SaveDataFile.csv";
            saveFileDialogTask_FAO.Filter = "CSV Files (*.csv)|*.csv|All Files (*.*)|*.*";
            saveFileDialogTask_FAO.ShowDialog();
            if (saveFileDialogTask_FAO.FileName != "")
            {
                string path = saveFileDialogTask_FAO.FileName;
                FileInfo fileInfo = new FileInfo(path);
                if (fileInfo.Exists)
                {
                    File.Delete(path);
                }
                string str = "";
                for (int i = 0; i < dataGridViewEdit_FAO.RowCount; i++)
                {
                    for (int j = 0; j < dataGridViewEdit_FAO.ColumnCount; j++)
                    {
                        if (dataGridViewEdit_FAO.Rows[i].Cells[j].Style.BackColor == Color.Orange) break;

                        if (j != dataGridViewEdit_FAO.ColumnCount - 1)
                        {
                            str += dataGridViewEdit_FAO.Rows[i].Cells[j].Value + ";";
                        }
                        else
                        {
                            str += dataGridViewEdit_FAO.Rows[i].Cells[j].Value;
                        }
                    }
                    File.AppendAllText(path, str + Environment.NewLine);
                    str = "";
                }
            }
        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormStatistic formStatistic = new FormStatistic(dataGridViewEdit_FAO);
            formStatistic.ShowDialog();
        }
    }
}

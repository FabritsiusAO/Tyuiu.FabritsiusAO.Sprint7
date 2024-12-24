namespace Tyuiu.FabritsiusAO.Sprint7.Project.V10
{
    partial class FormMain
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTop_FAO = new Panel();
            groupBoxRowsEdit_FAO = new GroupBox();
            checkBoxMarkRow_FAO = new CheckBox();
            buttonUnmarkDelete_FAO = new Button();
            buttonMarkDelete_FAO = new Button();
            buttonDeleteMarkedRow_FAO = new Button();
            buttonAddRow_FAO = new Button();
            groupBoxTable_FAO = new GroupBox();
            buttonOpenFile_FAO = new Button();
            buttonSaveFile_FAO = new Button();
            panelFill_FAO = new Panel();
            tabControlTable_FAO = new TabControl();
            tabPageReadOnly_FAO = new TabPage();
            dataGridViewReadOnly_FAO = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            UserID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            OrderValue = new DataGridViewTextBoxColumn();
            ProductName = new DataGridViewTextBoxColumn();
            ProductCount = new DataGridViewTextBoxColumn();
            ProductPrice = new DataGridViewTextBoxColumn();
            tabControlReadOnlySearch_FAO = new TabControl();
            tabPageReadOnlySearchOrderID_FAO = new TabPage();
            buttonReadOnlySearchOrderID_FAO = new Button();
            textBoxReadOnlySearchOrderID_FAO = new TextBox();
            tabPageReadOnlySearchUserID_FAO = new TabPage();
            buttonReadOnlySearchUserID_FAO = new Button();
            textBoxReadOnlySearchUserID_FAO = new TextBox();
            tabPageEdit_FAO = new TabPage();
            dataGridViewEdit_FAO = new DataGridView();
            OrderIDedit = new DataGridViewTextBoxColumn();
            UserIDedit = new DataGridViewTextBoxColumn();
            OrderDateEdit = new DataGridViewTextBoxColumn();
            OrderStatusEdit = new DataGridViewTextBoxColumn();
            OrderValueEdit = new DataGridViewTextBoxColumn();
            ProductNameEdit = new DataGridViewTextBoxColumn();
            ProductCountEdit = new DataGridViewTextBoxColumn();
            ProductPriceEdit = new DataGridViewTextBoxColumn();
            tabControlEditSearch_FAO = new TabControl();
            tabPageEditSearchOrderID_FAO = new TabPage();
            buttonEditSearchOrderID_FAO = new Button();
            textBoxEditSearchOrderID_FAO = new TextBox();
            tabPageEditSearchUserID_FAO = new TabPage();
            buttonEditSearchUserID_FAO = new Button();
            textBoxEditSearchUserID_FAO = new TextBox();
            openFileDialogTask_FAO = new OpenFileDialog();
            toolTipTask_FAO = new ToolTip(components);
            saveFileDialogTask_FAO = new SaveFileDialog();
            menuStrip_FAO = new MenuStrip();
            статистикаToolStripMenuItem = new ToolStripMenuItem();
            помощьToolStripMenuItem = new ToolStripMenuItem();
            panelTop_FAO.SuspendLayout();
            groupBoxRowsEdit_FAO.SuspendLayout();
            groupBoxTable_FAO.SuspendLayout();
            panelFill_FAO.SuspendLayout();
            tabControlTable_FAO.SuspendLayout();
            tabPageReadOnly_FAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadOnly_FAO).BeginInit();
            tabControlReadOnlySearch_FAO.SuspendLayout();
            tabPageReadOnlySearchOrderID_FAO.SuspendLayout();
            tabPageReadOnlySearchUserID_FAO.SuspendLayout();
            tabPageEdit_FAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdit_FAO).BeginInit();
            tabControlEditSearch_FAO.SuspendLayout();
            tabPageEditSearchOrderID_FAO.SuspendLayout();
            tabPageEditSearchUserID_FAO.SuspendLayout();
            menuStrip_FAO.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop_FAO
            // 
            panelTop_FAO.Controls.Add(groupBoxRowsEdit_FAO);
            panelTop_FAO.Controls.Add(groupBoxTable_FAO);
            panelTop_FAO.Dock = DockStyle.Top;
            panelTop_FAO.Location = new Point(0, 24);
            panelTop_FAO.Margin = new Padding(3, 2, 3, 2);
            panelTop_FAO.Name = "panelTop_FAO";
            panelTop_FAO.Size = new Size(992, 104);
            panelTop_FAO.TabIndex = 0;
            // 
            // groupBoxRowsEdit_FAO
            // 
            groupBoxRowsEdit_FAO.Controls.Add(checkBoxMarkRow_FAO);
            groupBoxRowsEdit_FAO.Controls.Add(buttonUnmarkDelete_FAO);
            groupBoxRowsEdit_FAO.Controls.Add(buttonMarkDelete_FAO);
            groupBoxRowsEdit_FAO.Controls.Add(buttonDeleteMarkedRow_FAO);
            groupBoxRowsEdit_FAO.Controls.Add(buttonAddRow_FAO);
            groupBoxRowsEdit_FAO.Dock = DockStyle.Left;
            groupBoxRowsEdit_FAO.Location = new Point(200, 0);
            groupBoxRowsEdit_FAO.Name = "groupBoxRowsEdit_FAO";
            groupBoxRowsEdit_FAO.Size = new Size(441, 104);
            groupBoxRowsEdit_FAO.TabIndex = 2;
            groupBoxRowsEdit_FAO.TabStop = false;
            groupBoxRowsEdit_FAO.Text = "Строки";
            // 
            // checkBoxMarkRow_FAO
            // 
            checkBoxMarkRow_FAO.AutoSize = true;
            checkBoxMarkRow_FAO.Enabled = false;
            checkBoxMarkRow_FAO.Location = new Point(164, 33);
            checkBoxMarkRow_FAO.Name = "checkBoxMarkRow_FAO";
            checkBoxMarkRow_FAO.Size = new Size(128, 19);
            checkBoxMarkRow_FAO.TabIndex = 4;
            checkBoxMarkRow_FAO.Text = "Выделение строки";
            checkBoxMarkRow_FAO.UseVisualStyleBackColor = true;
            checkBoxMarkRow_FAO.CheckedChanged += checkBoxMarkRow_FAO_Checked;
            // 
            // buttonUnmarkDelete_FAO
            // 
            buttonUnmarkDelete_FAO.Enabled = false;
            buttonUnmarkDelete_FAO.Image = (Image)resources.GetObject("buttonUnmarkDelete_FAO.Image");
            buttonUnmarkDelete_FAO.Location = new Point(364, 33);
            buttonUnmarkDelete_FAO.Name = "buttonUnmarkDelete_FAO";
            buttonUnmarkDelete_FAO.Size = new Size(51, 45);
            buttonUnmarkDelete_FAO.TabIndex = 3;
            toolTipTask_FAO.SetToolTip(buttonUnmarkDelete_FAO, "Снять пометку на удаление");
            buttonUnmarkDelete_FAO.UseVisualStyleBackColor = true;
            buttonUnmarkDelete_FAO.Click += buttonUnmarkDelete_FAO_Click;
            // 
            // buttonMarkDelete_FAO
            // 
            buttonMarkDelete_FAO.Enabled = false;
            buttonMarkDelete_FAO.Image = (Image)resources.GetObject("buttonMarkDelete_FAO.Image");
            buttonMarkDelete_FAO.Location = new Point(307, 33);
            buttonMarkDelete_FAO.Name = "buttonMarkDelete_FAO";
            buttonMarkDelete_FAO.Size = new Size(51, 45);
            buttonMarkDelete_FAO.TabIndex = 3;
            toolTipTask_FAO.SetToolTip(buttonMarkDelete_FAO, "Пометить строку на удаление");
            buttonMarkDelete_FAO.UseVisualStyleBackColor = true;
            buttonMarkDelete_FAO.Click += buttonMarkDelete_FAO_Click;
            // 
            // buttonDeleteMarkedRow_FAO
            // 
            buttonDeleteMarkedRow_FAO.Enabled = false;
            buttonDeleteMarkedRow_FAO.Image = (Image)resources.GetObject("buttonDeleteMarkedRow_FAO.Image");
            buttonDeleteMarkedRow_FAO.Location = new Point(93, 33);
            buttonDeleteMarkedRow_FAO.Name = "buttonDeleteMarkedRow_FAO";
            buttonDeleteMarkedRow_FAO.Size = new Size(49, 45);
            buttonDeleteMarkedRow_FAO.TabIndex = 2;
            toolTipTask_FAO.SetToolTip(buttonDeleteMarkedRow_FAO, "Удалить помеченные строки");
            buttonDeleteMarkedRow_FAO.UseVisualStyleBackColor = true;
            buttonDeleteMarkedRow_FAO.Click += buttonDeleteMarkedRow_FAO_Click;
            // 
            // buttonAddRow_FAO
            // 
            buttonAddRow_FAO.Enabled = false;
            buttonAddRow_FAO.Image = (Image)resources.GetObject("buttonAddRow_FAO.Image");
            buttonAddRow_FAO.Location = new Point(23, 33);
            buttonAddRow_FAO.Name = "buttonAddRow_FAO";
            buttonAddRow_FAO.Size = new Size(49, 45);
            buttonAddRow_FAO.TabIndex = 0;
            toolTipTask_FAO.SetToolTip(buttonAddRow_FAO, "Добавить строку");
            buttonAddRow_FAO.UseVisualStyleBackColor = true;
            buttonAddRow_FAO.Click += buttonAdd_FAO_Click;
            // 
            // groupBoxTable_FAO
            // 
            groupBoxTable_FAO.Controls.Add(buttonOpenFile_FAO);
            groupBoxTable_FAO.Controls.Add(buttonSaveFile_FAO);
            groupBoxTable_FAO.Dock = DockStyle.Left;
            groupBoxTable_FAO.Location = new Point(0, 0);
            groupBoxTable_FAO.Name = "groupBoxTable_FAO";
            groupBoxTable_FAO.Size = new Size(200, 104);
            groupBoxTable_FAO.TabIndex = 1;
            groupBoxTable_FAO.TabStop = false;
            groupBoxTable_FAO.Text = "Таблица";
            // 
            // buttonOpenFile_FAO
            // 
            buttonOpenFile_FAO.Image = (Image)resources.GetObject("buttonOpenFile_FAO.Image");
            buttonOpenFile_FAO.Location = new Point(27, 33);
            buttonOpenFile_FAO.Margin = new Padding(3, 2, 3, 2);
            buttonOpenFile_FAO.Name = "buttonOpenFile_FAO";
            buttonOpenFile_FAO.Size = new Size(55, 45);
            buttonOpenFile_FAO.TabIndex = 0;
            toolTipTask_FAO.SetToolTip(buttonOpenFile_FAO, "Открыть файл");
            buttonOpenFile_FAO.UseVisualStyleBackColor = true;
            buttonOpenFile_FAO.Click += buttonOpenFile_FAO_Click;
            // 
            // buttonSaveFile_FAO
            // 
            buttonSaveFile_FAO.Enabled = false;
            buttonSaveFile_FAO.Image = (Image)resources.GetObject("buttonSaveFile_FAO.Image");
            buttonSaveFile_FAO.Location = new Point(112, 33);
            buttonSaveFile_FAO.Margin = new Padding(3, 2, 3, 2);
            buttonSaveFile_FAO.Name = "buttonSaveFile_FAO";
            buttonSaveFile_FAO.Size = new Size(55, 45);
            buttonSaveFile_FAO.TabIndex = 0;
            toolTipTask_FAO.SetToolTip(buttonSaveFile_FAO, "Сохранить файл");
            buttonSaveFile_FAO.UseVisualStyleBackColor = true;
            buttonSaveFile_FAO.Click += buttonSaveFile_FAO_Click;
            // 
            // panelFill_FAO
            // 
            panelFill_FAO.Controls.Add(tabControlTable_FAO);
            panelFill_FAO.Dock = DockStyle.Fill;
            panelFill_FAO.Location = new Point(0, 128);
            panelFill_FAO.Margin = new Padding(3, 2, 3, 2);
            panelFill_FAO.Name = "panelFill_FAO";
            panelFill_FAO.Size = new Size(992, 559);
            panelFill_FAO.TabIndex = 2;
            // 
            // tabControlTable_FAO
            // 
            tabControlTable_FAO.Controls.Add(tabPageReadOnly_FAO);
            tabControlTable_FAO.Controls.Add(tabPageEdit_FAO);
            tabControlTable_FAO.Dock = DockStyle.Fill;
            tabControlTable_FAO.Location = new Point(0, 0);
            tabControlTable_FAO.Name = "tabControlTable_FAO";
            tabControlTable_FAO.Padding = new Point(6, 15);
            tabControlTable_FAO.SelectedIndex = 0;
            tabControlTable_FAO.Size = new Size(992, 559);
            tabControlTable_FAO.TabIndex = 0;
            tabControlTable_FAO.SelectedIndexChanged += tabControlTable_FAO_SelectedIndexChanged;
            // 
            // tabPageReadOnly_FAO
            // 
            tabPageReadOnly_FAO.Controls.Add(dataGridViewReadOnly_FAO);
            tabPageReadOnly_FAO.Controls.Add(tabControlReadOnlySearch_FAO);
            tabPageReadOnly_FAO.Location = new Point(4, 48);
            tabPageReadOnly_FAO.Name = "tabPageReadOnly_FAO";
            tabPageReadOnly_FAO.Padding = new Padding(3);
            tabPageReadOnly_FAO.Size = new Size(984, 507);
            tabPageReadOnly_FAO.TabIndex = 0;
            tabPageReadOnly_FAO.Text = "Чтение";
            tabPageReadOnly_FAO.UseVisualStyleBackColor = true;
            // 
            // dataGridViewReadOnly_FAO
            // 
            dataGridViewReadOnly_FAO.AllowUserToAddRows = false;
            dataGridViewReadOnly_FAO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReadOnly_FAO.Columns.AddRange(new DataGridViewColumn[] { OrderID, UserID, OrderDate, OrderStatus, OrderValue, ProductName, ProductCount, ProductPrice });
            dataGridViewReadOnly_FAO.Dock = DockStyle.Fill;
            dataGridViewReadOnly_FAO.Location = new Point(3, 62);
            dataGridViewReadOnly_FAO.Margin = new Padding(3, 2, 3, 2);
            dataGridViewReadOnly_FAO.Name = "dataGridViewReadOnly_FAO";
            dataGridViewReadOnly_FAO.ReadOnly = true;
            dataGridViewReadOnly_FAO.RowHeadersVisible = false;
            dataGridViewReadOnly_FAO.RowHeadersWidth = 51;
            dataGridViewReadOnly_FAO.Size = new Size(978, 442);
            dataGridViewReadOnly_FAO.TabIndex = 0;
            // 
            // OrderID
            // 
            OrderID.HeaderText = "Номер заказа";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.ReadOnly = true;
            OrderID.Width = 75;
            // 
            // UserID
            // 
            UserID.HeaderText = "ID пользователя";
            UserID.MinimumWidth = 6;
            UserID.Name = "UserID";
            UserID.ReadOnly = true;
            UserID.Width = 125;
            // 
            // OrderDate
            // 
            OrderDate.HeaderText = "Дата исполнения";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.ReadOnly = true;
            OrderDate.Width = 125;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Статус заказа";
            OrderStatus.MinimumWidth = 6;
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Width = 125;
            // 
            // OrderValue
            // 
            OrderValue.HeaderText = "Стоимость заказа (руб.)";
            OrderValue.MinimumWidth = 6;
            OrderValue.Name = "OrderValue";
            OrderValue.ReadOnly = true;
            OrderValue.Width = 125;
            // 
            // ProductName
            // 
            ProductName.HeaderText = "Название товара";
            ProductName.MinimumWidth = 6;
            ProductName.Name = "ProductName";
            ProductName.ReadOnly = true;
            ProductName.Width = 125;
            // 
            // ProductCount
            // 
            ProductCount.HeaderText = "Количество (шт.)";
            ProductCount.MinimumWidth = 6;
            ProductCount.Name = "ProductCount";
            ProductCount.ReadOnly = true;
            ProductCount.Width = 125;
            // 
            // ProductPrice
            // 
            ProductPrice.HeaderText = "Стоимость товара (руб.)";
            ProductPrice.MinimumWidth = 6;
            ProductPrice.Name = "ProductPrice";
            ProductPrice.ReadOnly = true;
            ProductPrice.Width = 125;
            // 
            // tabControlReadOnlySearch_FAO
            // 
            tabControlReadOnlySearch_FAO.Controls.Add(tabPageReadOnlySearchOrderID_FAO);
            tabControlReadOnlySearch_FAO.Controls.Add(tabPageReadOnlySearchUserID_FAO);
            tabControlReadOnlySearch_FAO.Dock = DockStyle.Top;
            tabControlReadOnlySearch_FAO.Location = new Point(3, 3);
            tabControlReadOnlySearch_FAO.Name = "tabControlReadOnlySearch_FAO";
            tabControlReadOnlySearch_FAO.SelectedIndex = 0;
            tabControlReadOnlySearch_FAO.Size = new Size(978, 59);
            tabControlReadOnlySearch_FAO.TabIndex = 3;
            // 
            // tabPageReadOnlySearchOrderID_FAO
            // 
            tabPageReadOnlySearchOrderID_FAO.Controls.Add(buttonReadOnlySearchOrderID_FAO);
            tabPageReadOnlySearchOrderID_FAO.Controls.Add(textBoxReadOnlySearchOrderID_FAO);
            tabPageReadOnlySearchOrderID_FAO.Location = new Point(4, 24);
            tabPageReadOnlySearchOrderID_FAO.Name = "tabPageReadOnlySearchOrderID_FAO";
            tabPageReadOnlySearchOrderID_FAO.Padding = new Padding(3);
            tabPageReadOnlySearchOrderID_FAO.Size = new Size(970, 31);
            tabPageReadOnlySearchOrderID_FAO.TabIndex = 0;
            tabPageReadOnlySearchOrderID_FAO.Text = "По номеру";
            tabPageReadOnlySearchOrderID_FAO.UseVisualStyleBackColor = true;
            // 
            // buttonReadOnlySearchOrderID_FAO
            // 
            buttonReadOnlySearchOrderID_FAO.BackgroundImage = (Image)resources.GetObject("buttonReadOnlySearchOrderID_FAO.BackgroundImage");
            buttonReadOnlySearchOrderID_FAO.BackgroundImageLayout = ImageLayout.Stretch;
            buttonReadOnlySearchOrderID_FAO.Dock = DockStyle.Left;
            buttonReadOnlySearchOrderID_FAO.Location = new Point(198, 3);
            buttonReadOnlySearchOrderID_FAO.Name = "buttonReadOnlySearchOrderID_FAO";
            buttonReadOnlySearchOrderID_FAO.Size = new Size(33, 25);
            buttonReadOnlySearchOrderID_FAO.TabIndex = 3;
            buttonReadOnlySearchOrderID_FAO.UseVisualStyleBackColor = true;
            buttonReadOnlySearchOrderID_FAO.Click += buttonReadOnlySearchOrderID_FAO_Click;
            // 
            // textBoxReadOnlySearchOrderID_FAO
            // 
            textBoxReadOnlySearchOrderID_FAO.Dock = DockStyle.Left;
            textBoxReadOnlySearchOrderID_FAO.Location = new Point(3, 3);
            textBoxReadOnlySearchOrderID_FAO.Name = "textBoxReadOnlySearchOrderID_FAO";
            textBoxReadOnlySearchOrderID_FAO.PlaceholderText = "Поиск...";
            textBoxReadOnlySearchOrderID_FAO.Size = new Size(195, 23);
            textBoxReadOnlySearchOrderID_FAO.TabIndex = 0;
            // 
            // tabPageReadOnlySearchUserID_FAO
            // 
            tabPageReadOnlySearchUserID_FAO.Controls.Add(buttonReadOnlySearchUserID_FAO);
            tabPageReadOnlySearchUserID_FAO.Controls.Add(textBoxReadOnlySearchUserID_FAO);
            tabPageReadOnlySearchUserID_FAO.Location = new Point(4, 24);
            tabPageReadOnlySearchUserID_FAO.Name = "tabPageReadOnlySearchUserID_FAO";
            tabPageReadOnlySearchUserID_FAO.Padding = new Padding(3);
            tabPageReadOnlySearchUserID_FAO.Size = new Size(970, 31);
            tabPageReadOnlySearchUserID_FAO.TabIndex = 1;
            tabPageReadOnlySearchUserID_FAO.Text = "По ID пользователя";
            tabPageReadOnlySearchUserID_FAO.UseVisualStyleBackColor = true;
            // 
            // buttonReadOnlySearchUserID_FAO
            // 
            buttonReadOnlySearchUserID_FAO.BackgroundImage = (Image)resources.GetObject("buttonReadOnlySearchUserID_FAO.BackgroundImage");
            buttonReadOnlySearchUserID_FAO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonReadOnlySearchUserID_FAO.Dock = DockStyle.Left;
            buttonReadOnlySearchUserID_FAO.Location = new Point(198, 3);
            buttonReadOnlySearchUserID_FAO.Name = "buttonReadOnlySearchUserID_FAO";
            buttonReadOnlySearchUserID_FAO.Size = new Size(33, 25);
            buttonReadOnlySearchUserID_FAO.TabIndex = 4;
            buttonReadOnlySearchUserID_FAO.UseVisualStyleBackColor = true;
            buttonReadOnlySearchUserID_FAO.Click += buttonReadOnlySearchUserID_FAO_Click;
            // 
            // textBoxReadOnlySearchUserID_FAO
            // 
            textBoxReadOnlySearchUserID_FAO.Dock = DockStyle.Left;
            textBoxReadOnlySearchUserID_FAO.Location = new Point(3, 3);
            textBoxReadOnlySearchUserID_FAO.Name = "textBoxReadOnlySearchUserID_FAO";
            textBoxReadOnlySearchUserID_FAO.PlaceholderText = "Поиск...";
            textBoxReadOnlySearchUserID_FAO.Size = new Size(195, 23);
            textBoxReadOnlySearchUserID_FAO.TabIndex = 1;
            // 
            // tabPageEdit_FAO
            // 
            tabPageEdit_FAO.Controls.Add(dataGridViewEdit_FAO);
            tabPageEdit_FAO.Controls.Add(tabControlEditSearch_FAO);
            tabPageEdit_FAO.Location = new Point(4, 48);
            tabPageEdit_FAO.Name = "tabPageEdit_FAO";
            tabPageEdit_FAO.Padding = new Padding(3);
            tabPageEdit_FAO.Size = new Size(984, 507);
            tabPageEdit_FAO.TabIndex = 1;
            tabPageEdit_FAO.Text = "Редактирование";
            tabPageEdit_FAO.UseVisualStyleBackColor = true;
            // 
            // dataGridViewEdit_FAO
            // 
            dataGridViewEdit_FAO.AllowUserToAddRows = false;
            dataGridViewEdit_FAO.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEdit_FAO.Columns.AddRange(new DataGridViewColumn[] { OrderIDedit, UserIDedit, OrderDateEdit, OrderStatusEdit, OrderValueEdit, ProductNameEdit, ProductCountEdit, ProductPriceEdit });
            dataGridViewEdit_FAO.Dock = DockStyle.Fill;
            dataGridViewEdit_FAO.Location = new Point(3, 62);
            dataGridViewEdit_FAO.Margin = new Padding(3, 2, 3, 2);
            dataGridViewEdit_FAO.Name = "dataGridViewEdit_FAO";
            dataGridViewEdit_FAO.RowHeadersVisible = false;
            dataGridViewEdit_FAO.RowHeadersWidth = 51;
            dataGridViewEdit_FAO.Size = new Size(978, 442);
            dataGridViewEdit_FAO.TabIndex = 1;
            // 
            // OrderIDedit
            // 
            OrderIDedit.HeaderText = "Номер заказа";
            OrderIDedit.MinimumWidth = 6;
            OrderIDedit.Name = "OrderIDedit";
            OrderIDedit.Width = 75;
            // 
            // UserIDedit
            // 
            UserIDedit.HeaderText = "ID пользователя";
            UserIDedit.MinimumWidth = 6;
            UserIDedit.Name = "UserIDedit";
            UserIDedit.Width = 125;
            // 
            // OrderDateEdit
            // 
            OrderDateEdit.HeaderText = "Дата исполнения";
            OrderDateEdit.MinimumWidth = 6;
            OrderDateEdit.Name = "OrderDateEdit";
            OrderDateEdit.Width = 125;
            // 
            // OrderStatusEdit
            // 
            OrderStatusEdit.HeaderText = "Статус заказа";
            OrderStatusEdit.MinimumWidth = 6;
            OrderStatusEdit.Name = "OrderStatusEdit";
            OrderStatusEdit.Width = 125;
            // 
            // OrderValueEdit
            // 
            OrderValueEdit.HeaderText = "Стоимость заказа (руб.)";
            OrderValueEdit.MinimumWidth = 6;
            OrderValueEdit.Name = "OrderValueEdit";
            OrderValueEdit.Width = 125;
            // 
            // ProductNameEdit
            // 
            ProductNameEdit.HeaderText = "Название товара";
            ProductNameEdit.MinimumWidth = 6;
            ProductNameEdit.Name = "ProductNameEdit";
            ProductNameEdit.Width = 125;
            // 
            // ProductCountEdit
            // 
            ProductCountEdit.HeaderText = "Количество (шт.)";
            ProductCountEdit.MinimumWidth = 6;
            ProductCountEdit.Name = "ProductCountEdit";
            ProductCountEdit.Width = 125;
            // 
            // ProductPriceEdit
            // 
            ProductPriceEdit.HeaderText = "Стоимость товара (руб.)";
            ProductPriceEdit.MinimumWidth = 6;
            ProductPriceEdit.Name = "ProductPriceEdit";
            ProductPriceEdit.Width = 125;
            // 
            // tabControlEditSearch_FAO
            // 
            tabControlEditSearch_FAO.Controls.Add(tabPageEditSearchOrderID_FAO);
            tabControlEditSearch_FAO.Controls.Add(tabPageEditSearchUserID_FAO);
            tabControlEditSearch_FAO.Dock = DockStyle.Top;
            tabControlEditSearch_FAO.Location = new Point(3, 3);
            tabControlEditSearch_FAO.Name = "tabControlEditSearch_FAO";
            tabControlEditSearch_FAO.SelectedIndex = 0;
            tabControlEditSearch_FAO.Size = new Size(978, 59);
            tabControlEditSearch_FAO.TabIndex = 2;
            // 
            // tabPageEditSearchOrderID_FAO
            // 
            tabPageEditSearchOrderID_FAO.Controls.Add(buttonEditSearchOrderID_FAO);
            tabPageEditSearchOrderID_FAO.Controls.Add(textBoxEditSearchOrderID_FAO);
            tabPageEditSearchOrderID_FAO.Location = new Point(4, 24);
            tabPageEditSearchOrderID_FAO.Name = "tabPageEditSearchOrderID_FAO";
            tabPageEditSearchOrderID_FAO.Padding = new Padding(3);
            tabPageEditSearchOrderID_FAO.Size = new Size(970, 31);
            tabPageEditSearchOrderID_FAO.TabIndex = 0;
            tabPageEditSearchOrderID_FAO.Text = "По номеру";
            tabPageEditSearchOrderID_FAO.UseVisualStyleBackColor = true;
            // 
            // buttonEditSearchOrderID_FAO
            // 
            buttonEditSearchOrderID_FAO.BackgroundImage = (Image)resources.GetObject("buttonEditSearchOrderID_FAO.BackgroundImage");
            buttonEditSearchOrderID_FAO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditSearchOrderID_FAO.Dock = DockStyle.Left;
            buttonEditSearchOrderID_FAO.Location = new Point(198, 3);
            buttonEditSearchOrderID_FAO.Name = "buttonEditSearchOrderID_FAO";
            buttonEditSearchOrderID_FAO.Size = new Size(33, 25);
            buttonEditSearchOrderID_FAO.TabIndex = 4;
            buttonEditSearchOrderID_FAO.UseVisualStyleBackColor = true;
            buttonEditSearchOrderID_FAO.Click += buttonEditSearchOrderID_FAO_Click;
            // 
            // textBoxEditSearchOrderID_FAO
            // 
            textBoxEditSearchOrderID_FAO.Dock = DockStyle.Left;
            textBoxEditSearchOrderID_FAO.Location = new Point(3, 3);
            textBoxEditSearchOrderID_FAO.Name = "textBoxEditSearchOrderID_FAO";
            textBoxEditSearchOrderID_FAO.PlaceholderText = "Поиск...";
            textBoxEditSearchOrderID_FAO.Size = new Size(195, 23);
            textBoxEditSearchOrderID_FAO.TabIndex = 1;
            // 
            // tabPageEditSearchUserID_FAO
            // 
            tabPageEditSearchUserID_FAO.Controls.Add(buttonEditSearchUserID_FAO);
            tabPageEditSearchUserID_FAO.Controls.Add(textBoxEditSearchUserID_FAO);
            tabPageEditSearchUserID_FAO.Location = new Point(4, 24);
            tabPageEditSearchUserID_FAO.Name = "tabPageEditSearchUserID_FAO";
            tabPageEditSearchUserID_FAO.Padding = new Padding(3);
            tabPageEditSearchUserID_FAO.Size = new Size(970, 31);
            tabPageEditSearchUserID_FAO.TabIndex = 1;
            tabPageEditSearchUserID_FAO.Text = "По ID пользователя";
            tabPageEditSearchUserID_FAO.UseVisualStyleBackColor = true;
            // 
            // buttonEditSearchUserID_FAO
            // 
            buttonEditSearchUserID_FAO.BackgroundImage = (Image)resources.GetObject("buttonEditSearchUserID_FAO.BackgroundImage");
            buttonEditSearchUserID_FAO.BackgroundImageLayout = ImageLayout.Zoom;
            buttonEditSearchUserID_FAO.Dock = DockStyle.Left;
            buttonEditSearchUserID_FAO.Location = new Point(198, 3);
            buttonEditSearchUserID_FAO.Name = "buttonEditSearchUserID_FAO";
            buttonEditSearchUserID_FAO.Size = new Size(33, 25);
            buttonEditSearchUserID_FAO.TabIndex = 4;
            buttonEditSearchUserID_FAO.UseVisualStyleBackColor = true;
            buttonEditSearchUserID_FAO.Click += buttonEditSearchUserID_FAO_Click;
            // 
            // textBoxEditSearchUserID_FAO
            // 
            textBoxEditSearchUserID_FAO.Dock = DockStyle.Left;
            textBoxEditSearchUserID_FAO.Location = new Point(3, 3);
            textBoxEditSearchUserID_FAO.Name = "textBoxEditSearchUserID_FAO";
            textBoxEditSearchUserID_FAO.PlaceholderText = "Поиск...";
            textBoxEditSearchUserID_FAO.Size = new Size(195, 23);
            textBoxEditSearchUserID_FAO.TabIndex = 1;
            // 
            // openFileDialogTask_FAO
            // 
            openFileDialogTask_FAO.FileName = "DataFile";
            // 
            // toolTipTask_FAO
            // 
            toolTipTask_FAO.ToolTipIcon = ToolTipIcon.Info;
            toolTipTask_FAO.ToolTipTitle = "Подсказка";
            // 
            // menuStrip_FAO
            // 
            menuStrip_FAO.ImageScalingSize = new Size(20, 20);
            menuStrip_FAO.Items.AddRange(new ToolStripItem[] { статистикаToolStripMenuItem, помощьToolStripMenuItem });
            menuStrip_FAO.Location = new Point(0, 0);
            menuStrip_FAO.Name = "menuStrip_FAO";
            menuStrip_FAO.Size = new Size(992, 24);
            menuStrip_FAO.TabIndex = 1;
            menuStrip_FAO.Text = "menuStrip1";
            // 
            // статистикаToolStripMenuItem
            // 
            статистикаToolStripMenuItem.Name = "статистикаToolStripMenuItem";
            статистикаToolStripMenuItem.Size = new Size(80, 20);
            статистикаToolStripMenuItem.Text = "Статистика";
            статистикаToolStripMenuItem.Click += статистикаToolStripMenuItem_Click;
            // 
            // помощьToolStripMenuItem
            // 
            помощьToolStripMenuItem.Name = "помощьToolStripMenuItem";
            помощьToolStripMenuItem.Size = new Size(65, 20);
            помощьToolStripMenuItem.Text = "Справка";
            помощьToolStripMenuItem.Click += справкаToolStripMenuItem_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(992, 687);
            Controls.Add(panelFill_FAO);
            Controls.Add(panelTop_FAO);
            Controls.Add(menuStrip_FAO);
            MainMenuStrip = menuStrip_FAO;
            Margin = new Padding(3, 2, 3, 2);
            MinimumSize = new Size(1007, 724);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Заказы";
            panelTop_FAO.ResumeLayout(false);
            groupBoxRowsEdit_FAO.ResumeLayout(false);
            groupBoxRowsEdit_FAO.PerformLayout();
            groupBoxTable_FAO.ResumeLayout(false);
            panelFill_FAO.ResumeLayout(false);
            tabControlTable_FAO.ResumeLayout(false);
            tabPageReadOnly_FAO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReadOnly_FAO).EndInit();
            tabControlReadOnlySearch_FAO.ResumeLayout(false);
            tabPageReadOnlySearchOrderID_FAO.ResumeLayout(false);
            tabPageReadOnlySearchOrderID_FAO.PerformLayout();
            tabPageReadOnlySearchUserID_FAO.ResumeLayout(false);
            tabPageReadOnlySearchUserID_FAO.PerformLayout();
            tabPageEdit_FAO.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEdit_FAO).EndInit();
            tabControlEditSearch_FAO.ResumeLayout(false);
            tabPageEditSearchOrderID_FAO.ResumeLayout(false);
            tabPageEditSearchOrderID_FAO.PerformLayout();
            tabPageEditSearchUserID_FAO.ResumeLayout(false);
            tabPageEditSearchUserID_FAO.PerformLayout();
            menuStrip_FAO.ResumeLayout(false);
            menuStrip_FAO.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelTop_FAO;
        private Panel panelFill_FAO;
        private DataGridView dataGridViewReadOnly_FAO;
        private Button buttonOpenFile_FAO;
        private OpenFileDialog openFileDialogTask_FAO;
        private ToolTip toolTipTask_FAO;
        private SaveFileDialog saveFileDialogTask_FAO;
        private TabControl tabControlTable_FAO;
        private TabPage tabPageReadOnly_FAO;
        private TabPage tabPageEdit_FAO;
        private DataGridView dataGridViewEdit_FAO;
        private Button buttonSaveFile_FAO;
        private TabControl tabControlEditSearch_FAO;
        private TabPage tabPageEditSearchOrderID_FAO;
        private TabPage tabPageEditSearchUserID_FAO;
        private TabControl tabControlReadOnlySearch_FAO;
        private TabPage tabPageReadOnlySearchOrderID_FAO;
        private TextBox textBoxReadOnlySearchOrderID_FAO;
        private Button buttonReadOnlySearchOrderID_FAO;
        private TextBox textBoxEditSearchOrderID_FAO;
        private TextBox textBoxEditSearchUserID_FAO;
        private Button buttonEditSearchOrderID_FAO;
        private Button buttonEditSearchUserID_FAO;
        private MenuStrip menuStrip_FAO;
        private ToolStripMenuItem помощьToolStripMenuItem;
        private GroupBox groupBoxRowsEdit_FAO;
        private GroupBox groupBoxTable_FAO;
        private Button buttonAddRow_FAO;
        private Button buttonDeleteMarkedRow_FAO;
        private Button buttonMarkDelete_FAO;
        private Button buttonUnmarkDelete_FAO;
        private CheckBox checkBoxMarkRow_FAO;
        private DataGridViewTextBoxColumn OrderIDedit;
        private DataGridViewTextBoxColumn UserIDedit;
        private DataGridViewTextBoxColumn OrderDateEdit;
        private DataGridViewTextBoxColumn OrderStatusEdit;
        private DataGridViewTextBoxColumn OrderValueEdit;
        private DataGridViewTextBoxColumn ProductNameEdit;
        private DataGridViewTextBoxColumn ProductCountEdit;
        private DataGridViewTextBoxColumn ProductPriceEdit;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn UserID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderStatus;
        private DataGridViewTextBoxColumn OrderValue;
        private DataGridViewTextBoxColumn ProductName;
        private DataGridViewTextBoxColumn ProductCount;
        private DataGridViewTextBoxColumn ProductPrice;
        private TabPage tabPageReadOnlySearchUserID_FAO;
        private Button buttonReadOnlySearchUserID_FAO;
        private TextBox textBoxReadOnlySearchUserID_FAO;
        private ToolStripMenuItem статистикаToolStripMenuItem;
    }
}

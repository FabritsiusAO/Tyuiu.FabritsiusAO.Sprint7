namespace Tyuiu.FabritsiusAO.Sprint7.Project.V10
{
    partial class FormStatistic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxOrdersStatistic_FAO = new GroupBox();
            labelOrdersCount_FAO = new Label();
            labelDelivered_FAO = new Label();
            labelInTransit_FAO = new Label();
            labelAverageOrderValue_FAO = new Label();
            labelMinOrderValue_FAO = new Label();
            labelMaxOrderValue_FAO = new Label();
            labelMostPopularDateOfOrder_FAO = new Label();
            labelMostPopularUserID_FAO = new Label();
            groupBoxProduct_FAO = new GroupBox();
            labelAverageProductPrice_FAO = new Label();
            labelMinProductPrice_FAO = new Label();
            labelMaxProductPrice_FAO = new Label();
            labelMaxProductCount_FAO = new Label();
            labelMostPopularProduct_FAO = new Label();
            chartProductDiag_FAO = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxOrdersStatistic_FAO.SuspendLayout();
            groupBoxProduct_FAO.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductDiag_FAO).BeginInit();
            SuspendLayout();
            // 
            // groupBoxOrdersStatistic_FAO
            // 
            groupBoxOrdersStatistic_FAO.Controls.Add(labelOrdersCount_FAO);
            groupBoxOrdersStatistic_FAO.Controls.Add(labelDelivered_FAO);
            groupBoxOrdersStatistic_FAO.Controls.Add(labelInTransit_FAO);
            groupBoxOrdersStatistic_FAO.Controls.Add(labelAverageOrderValue_FAO);
            groupBoxOrdersStatistic_FAO.Controls.Add(labelMinOrderValue_FAO);
            groupBoxOrdersStatistic_FAO.Controls.Add(labelMaxOrderValue_FAO);
            groupBoxOrdersStatistic_FAO.Controls.Add(labelMostPopularDateOfOrder_FAO);
            groupBoxOrdersStatistic_FAO.Controls.Add(labelMostPopularUserID_FAO);
            groupBoxOrdersStatistic_FAO.Location = new Point(12, 12);
            groupBoxOrdersStatistic_FAO.Name = "groupBoxOrdersStatistic_FAO";
            groupBoxOrdersStatistic_FAO.Size = new Size(354, 228);
            groupBoxOrdersStatistic_FAO.TabIndex = 0;
            groupBoxOrdersStatistic_FAO.TabStop = false;
            groupBoxOrdersStatistic_FAO.Text = "Заказы";
            // 
            // labelOrdersCount_FAO
            // 
            labelOrdersCount_FAO.AutoSize = true;
            labelOrdersCount_FAO.Location = new Point(6, 193);
            labelOrdersCount_FAO.Name = "labelOrdersCount_FAO";
            labelOrdersCount_FAO.Size = new Size(86, 15);
            labelOrdersCount_FAO.TabIndex = 0;
            labelOrdersCount_FAO.Text = "Заказов всего:";
            // 
            // labelDelivered_FAO
            // 
            labelDelivered_FAO.AutoSize = true;
            labelDelivered_FAO.Location = new Point(6, 176);
            labelDelivered_FAO.Name = "labelDelivered_FAO";
            labelDelivered_FAO.Size = new Size(119, 15);
            labelDelivered_FAO.TabIndex = 0;
            labelDelivered_FAO.Text = "Заказов доставлено:";
            // 
            // labelInTransit_FAO
            // 
            labelInTransit_FAO.AutoSize = true;
            labelInTransit_FAO.Location = new Point(6, 159);
            labelInTransit_FAO.Name = "labelInTransit_FAO";
            labelInTransit_FAO.Size = new Size(90, 15);
            labelInTransit_FAO.TabIndex = 0;
            labelInTransit_FAO.Text = "Заказов в пути:";
            // 
            // labelAverageOrderValue_FAO
            // 
            labelAverageOrderValue_FAO.AutoSize = true;
            labelAverageOrderValue_FAO.Location = new Point(6, 118);
            labelAverageOrderValue_FAO.Name = "labelAverageOrderValue_FAO";
            labelAverageOrderValue_FAO.Size = new Size(154, 15);
            labelAverageOrderValue_FAO.TabIndex = 0;
            labelAverageOrderValue_FAO.Text = "Средняя стоимость заказа:";
            // 
            // labelMinOrderValue_FAO
            // 
            labelMinOrderValue_FAO.AutoSize = true;
            labelMinOrderValue_FAO.Location = new Point(6, 100);
            labelMinOrderValue_FAO.Name = "labelMinOrderValue_FAO";
            labelMinOrderValue_FAO.Size = new Size(187, 15);
            labelMinOrderValue_FAO.TabIndex = 0;
            labelMinOrderValue_FAO.Text = "Минимальная стоимость заказа:";
            // 
            // labelMaxOrderValue_FAO
            // 
            labelMaxOrderValue_FAO.AutoSize = true;
            labelMaxOrderValue_FAO.Location = new Point(6, 82);
            labelMaxOrderValue_FAO.Name = "labelMaxOrderValue_FAO";
            labelMaxOrderValue_FAO.Size = new Size(191, 15);
            labelMaxOrderValue_FAO.TabIndex = 0;
            labelMaxOrderValue_FAO.Text = "Максимальная стоимость заказа:";
            // 
            // labelMostPopularDateOfOrder_FAO
            // 
            labelMostPopularDateOfOrder_FAO.AutoSize = true;
            labelMostPopularDateOfOrder_FAO.Location = new Point(6, 46);
            labelMostPopularDateOfOrder_FAO.Name = "labelMostPopularDateOfOrder_FAO";
            labelMostPopularDateOfOrder_FAO.Size = new Size(184, 15);
            labelMostPopularDateOfOrder_FAO.TabIndex = 0;
            labelMostPopularDateOfOrder_FAO.Text = "Самая популярная дата заказов:";
            // 
            // labelMostPopularUserID_FAO
            // 
            labelMostPopularUserID_FAO.AutoSize = true;
            labelMostPopularUserID_FAO.Location = new Point(6, 28);
            labelMostPopularUserID_FAO.Name = "labelMostPopularUserID_FAO";
            labelMostPopularUserID_FAO.Size = new Size(213, 15);
            labelMostPopularUserID_FAO.TabIndex = 0;
            labelMostPopularUserID_FAO.Text = "Частовстречающийся пользователь: ";
            // 
            // groupBoxProduct_FAO
            // 
            groupBoxProduct_FAO.Controls.Add(labelAverageProductPrice_FAO);
            groupBoxProduct_FAO.Controls.Add(labelMinProductPrice_FAO);
            groupBoxProduct_FAO.Controls.Add(labelMaxProductPrice_FAO);
            groupBoxProduct_FAO.Controls.Add(labelMaxProductCount_FAO);
            groupBoxProduct_FAO.Controls.Add(labelMostPopularProduct_FAO);
            groupBoxProduct_FAO.Location = new Point(12, 246);
            groupBoxProduct_FAO.Name = "groupBoxProduct_FAO";
            groupBoxProduct_FAO.Size = new Size(354, 151);
            groupBoxProduct_FAO.TabIndex = 0;
            groupBoxProduct_FAO.TabStop = false;
            groupBoxProduct_FAO.Text = "Товары";
            // 
            // labelAverageProductPrice_FAO
            // 
            labelAverageProductPrice_FAO.AutoSize = true;
            labelAverageProductPrice_FAO.Location = new Point(6, 120);
            labelAverageProductPrice_FAO.Name = "labelAverageProductPrice_FAO";
            labelAverageProductPrice_FAO.Size = new Size(157, 15);
            labelAverageProductPrice_FAO.TabIndex = 0;
            labelAverageProductPrice_FAO.Text = "Средняя стоимость товара:";
            // 
            // labelMinProductPrice_FAO
            // 
            labelMinProductPrice_FAO.AutoSize = true;
            labelMinProductPrice_FAO.Location = new Point(6, 103);
            labelMinProductPrice_FAO.Name = "labelMinProductPrice_FAO";
            labelMinProductPrice_FAO.Size = new Size(190, 15);
            labelMinProductPrice_FAO.TabIndex = 0;
            labelMinProductPrice_FAO.Text = "Минимальная стоимость товара:";
            // 
            // labelMaxProductPrice_FAO
            // 
            labelMaxProductPrice_FAO.AutoSize = true;
            labelMaxProductPrice_FAO.Location = new Point(6, 86);
            labelMaxProductPrice_FAO.Name = "labelMaxProductPrice_FAO";
            labelMaxProductPrice_FAO.Size = new Size(194, 15);
            labelMaxProductPrice_FAO.TabIndex = 0;
            labelMaxProductPrice_FAO.Text = "Максимальная стоимость товара:";
            // 
            // labelMaxProductCount_FAO
            // 
            labelMaxProductCount_FAO.AutoSize = true;
            labelMaxProductCount_FAO.Location = new Point(6, 55);
            labelMaxProductCount_FAO.Name = "labelMaxProductCount_FAO";
            labelMaxProductCount_FAO.Size = new Size(201, 15);
            labelMaxProductCount_FAO.TabIndex = 0;
            labelMaxProductCount_FAO.Text = "Максимальное количество товара:";
            // 
            // labelMostPopularProduct_FAO
            // 
            labelMostPopularProduct_FAO.AutoSize = true;
            labelMostPopularProduct_FAO.Location = new Point(6, 28);
            labelMostPopularProduct_FAO.Name = "labelMostPopularProduct_FAO";
            labelMostPopularProduct_FAO.Size = new Size(156, 15);
            labelMostPopularProduct_FAO.TabIndex = 0;
            labelMostPopularProduct_FAO.Text = "Самый популярный товар:";
            // 
            // chartProductDiag_FAO
            // 
            chartArea1.Name = "ChartArea1";
            chartProductDiag_FAO.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartProductDiag_FAO.Legends.Add(legend1);
            chartProductDiag_FAO.Location = new Point(380, 16);
            chartProductDiag_FAO.Name = "chartProductDiag_FAO";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartProductDiag_FAO.Series.Add(series1);
            chartProductDiag_FAO.Size = new Size(502, 381);
            chartProductDiag_FAO.TabIndex = 1;
            chartProductDiag_FAO.Text = "chart1";
            title1.Name = "Title_FAO";
            title1.Text = "ОБЪЕМ ТОВАРОВ";
            chartProductDiag_FAO.Titles.Add(title1);
            // 
            // FormStatistic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(894, 422);
            Controls.Add(chartProductDiag_FAO);
            Controls.Add(groupBoxProduct_FAO);
            Controls.Add(groupBoxOrdersStatistic_FAO);
            MaximizeBox = false;
            MaximumSize = new Size(910, 461);
            MinimumSize = new Size(910, 461);
            Name = "FormStatistic";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Статистика";
            Load += FormStatistics_Load;
            groupBoxOrdersStatistic_FAO.ResumeLayout(false);
            groupBoxOrdersStatistic_FAO.PerformLayout();
            groupBoxProduct_FAO.ResumeLayout(false);
            groupBoxProduct_FAO.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartProductDiag_FAO).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxOrdersStatistic_FAO;
        private Label labelMostPopularDateOfOrder_FAO;
        private Label labelMostPopularUserID_FAO;
        private Label labelMaxOrderValue_FAO;
        private Label labelMinOrderValue_FAO;
        private Label labelAverageOrderValue_FAO;
        private Label labelOrdersCount_FAO;
        private Label labelDelivered_FAO;
        private Label labelInTransit_FAO;
        private GroupBox groupBoxProduct_FAO;
        private Label labelAverageProductPrice_FAO;
        private Label labelMinProductPrice_FAO;
        private Label labelMaxProductPrice_FAO;
        private Label labelMaxProductCount_FAO;
        private Label labelMostPopularProduct_FAO;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartProductDiag_FAO;
    }
}
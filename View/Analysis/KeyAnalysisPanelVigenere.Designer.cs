namespace security_lab1_csharp.View.Analysis
{
    partial class KeyAnalysisPanelVigenere
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartMonoFreq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxRowsData = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonoFreq)).BeginInit();
            this.SuspendLayout();
            // 
            // chartMonoFreq
            // 
            chartArea1.Name = "ChartArea1";
            this.chartMonoFreq.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartMonoFreq.Legends.Add(legend1);
            this.chartMonoFreq.Location = new System.Drawing.Point(3, 180);
            this.chartMonoFreq.Name = "chartMonoFreq";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Freq";
            this.chartMonoFreq.Series.Add(series1);
            this.chartMonoFreq.Size = new System.Drawing.Size(426, 290);
            this.chartMonoFreq.TabIndex = 9;
            this.chartMonoFreq.Text = "chartMonoFreq";
            // 
            // listBoxRowsData
            // 
            this.listBoxRowsData.FormattingEnabled = true;
            this.listBoxRowsData.HorizontalScrollbar = true;
            this.listBoxRowsData.Location = new System.Drawing.Point(3, 3);
            this.listBoxRowsData.Name = "listBoxRowsData";
            this.listBoxRowsData.Size = new System.Drawing.Size(426, 173);
            this.listBoxRowsData.TabIndex = 8;
            // 
            // KeyAnalysisVigenerePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chartMonoFreq);
            this.Controls.Add(this.listBoxRowsData);
            this.Name = "KeyAnalysisVigenerePanel";
            this.Size = new System.Drawing.Size(432, 475);
            ((System.ComponentModel.ISupportInitialize)(this.chartMonoFreq)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonoFreq;
        private System.Windows.Forms.ListBox listBoxRowsData;
    }
}

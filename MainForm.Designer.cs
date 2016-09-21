namespace security_lab1_csharp
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.nGramComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.textBoxSource = new System.Windows.Forms.RichTextBox();
            this.textBoxResult = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.listViewBi = new System.Windows.Forms.ListView();
            this.Bigram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bicount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTri = new System.Windows.Forms.ListView();
            this.Trigram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tricount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonImprove = new System.Windows.Forms.Button();
            this.listViewQuad = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBoxFullKey = new System.Windows.Forms.TextBox();
            this.buttonSetKey = new System.Windows.Forms.Button();
            this.buttonNGram = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageMono = new System.Windows.Forms.TabPage();
            this.tabPageVigenere = new System.Windows.Forms.TabPage();
            this.chartMonoFreq = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listBoxRowsData = new System.Windows.Forms.ListBox();
            this.buttonSetVigKey = new System.Windows.Forms.Button();
            this.textBoxVigKey = new System.Windows.Forms.TextBox();
            this.buttonGetVigKey = new System.Windows.Forms.Button();
            this.buttonSetKeySize = new System.Windows.Forms.Button();
            this.textBoxKeySize = new System.Windows.Forms.TextBox();
            this.buttonGetKeySize = new System.Windows.Forms.Button();
            this.tabPagePoly = new System.Windows.Forms.TabPage();
            this.buttonSetPolyKey = new System.Windows.Forms.Button();
            this.tabControlPoly = new System.Windows.Forms.TabControl();
            this.tabPagePolyCharts = new System.Windows.Forms.TabPage();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.tabPagePolyKeyDet = new System.Windows.Forms.TabPage();
            this.panelPolyKey = new System.Windows.Forms.Panel();
            this.buttonFindPoly = new System.Windows.Forms.Button();
            this.tabPagePolyKey = new System.Windows.Forms.TabPage();
            this.buttonPolyImprove = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageMono.SuspendLayout();
            this.tabPageVigenere.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonoFreq)).BeginInit();
            this.tabPagePoly.SuspendLayout();
            this.tabControlPoly.SuspendLayout();
            this.tabPagePolyCharts.SuspendLayout();
            this.tabPagePolyKeyDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // nGramComboBox
            // 
            this.nGramComboBox.Items.AddRange(new object[] {
            "Monogram",
            "Bigram",
            "Trigram",
            "Quadgram",
            "Quintgram"});
            this.nGramComboBox.Location = new System.Drawing.Point(69, 13);
            this.nGramComboBox.Name = "nGramComboBox";
            this.nGramComboBox.Size = new System.Drawing.Size(121, 21);
            this.nGramComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "N-gram";
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(236, 46);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(133, 23);
            this.buttonFind.TabIndex = 2;
            this.buttonFind.Text = "Find key with EA";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(694, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Source";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1145, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1347, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // groupBox
            // 
            this.groupBox.Location = new System.Drawing.Point(9, 71);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(139, 537);
            this.groupBox.TabIndex = 9;
            this.groupBox.TabStop = false;
            // 
            // textBoxSource
            // 
            this.textBoxSource.Location = new System.Drawing.Point(499, 94);
            this.textBoxSource.Name = "textBoxSource";
            this.textBoxSource.ReadOnly = true;
            this.textBoxSource.Size = new System.Drawing.Size(424, 528);
            this.textBoxSource.TabIndex = 10;
            this.textBoxSource.Text = "";
            this.textBoxSource.TextChanged += new System.EventHandler(this.textBoxSource_TextChanged);
            // 
            // textBoxResult
            // 
            this.textBoxResult.Location = new System.Drawing.Point(929, 94);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.ReadOnly = true;
            this.textBoxResult.Size = new System.Drawing.Size(424, 528);
            this.textBoxResult.TabIndex = 11;
            this.textBoxResult.Text = "";
            this.textBoxResult.TextChanged += new System.EventHandler(this.textBoxResult_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(196, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Iterations";
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(252, 14);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(45, 20);
            this.textBoxIterations.TabIndex = 13;
            this.textBoxIterations.Text = "1000";
            // 
            // listViewBi
            // 
            this.listViewBi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bigram,
            this.Bicount});
            this.listViewBi.Location = new System.Drawing.Point(155, 76);
            this.listViewBi.Name = "listViewBi";
            this.listViewBi.Size = new System.Drawing.Size(98, 528);
            this.listViewBi.TabIndex = 19;
            this.listViewBi.UseCompatibleStateImageBehavior = false;
            this.listViewBi.View = System.Windows.Forms.View.Details;
            // 
            // Bigram
            // 
            this.Bigram.Text = "Bigram";
            this.Bigram.Width = 44;
            // 
            // Bicount
            // 
            this.Bicount.Text = "Count";
            // 
            // listViewTri
            // 
            this.listViewTri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Trigram,
            this.Tricount});
            this.listViewTri.Location = new System.Drawing.Point(259, 76);
            this.listViewTri.Name = "listViewTri";
            this.listViewTri.Size = new System.Drawing.Size(98, 528);
            this.listViewTri.TabIndex = 20;
            this.listViewTri.UseCompatibleStateImageBehavior = false;
            this.listViewTri.View = System.Windows.Forms.View.Details;
            // 
            // Trigram
            // 
            this.Trigram.Text = "Trigram";
            this.Trigram.Width = 47;
            // 
            // Tricount
            // 
            this.Tricount.Text = "Count";
            // 
            // buttonImprove
            // 
            this.buttonImprove.Location = new System.Drawing.Point(375, 45);
            this.buttonImprove.Name = "buttonImprove";
            this.buttonImprove.Size = new System.Drawing.Size(107, 23);
            this.buttonImprove.TabIndex = 21;
            this.buttonImprove.Text = "Improve key (A*)";
            this.buttonImprove.UseVisualStyleBackColor = true;
            this.buttonImprove.Click += new System.EventHandler(this.buttonImprove_Click);
            // 
            // listViewQuad
            // 
            this.listViewQuad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewQuad.Location = new System.Drawing.Point(363, 76);
            this.listViewQuad.Name = "listViewQuad";
            this.listViewQuad.Size = new System.Drawing.Size(98, 528);
            this.listViewQuad.TabIndex = 22;
            this.listViewQuad.UseCompatibleStateImageBehavior = false;
            this.listViewQuad.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Quadgram";
            this.columnHeader1.Width = 47;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Count";
            // 
            // textBoxFullKey
            // 
            this.textBoxFullKey.Location = new System.Drawing.Point(9, 48);
            this.textBoxFullKey.Name = "textBoxFullKey";
            this.textBoxFullKey.Size = new System.Drawing.Size(139, 20);
            this.textBoxFullKey.TabIndex = 24;
            // 
            // buttonSetKey
            // 
            this.buttonSetKey.Location = new System.Drawing.Point(155, 47);
            this.buttonSetKey.Name = "buttonSetKey";
            this.buttonSetKey.Size = new System.Drawing.Size(75, 23);
            this.buttonSetKey.TabIndex = 25;
            this.buttonSetKey.Text = "Set key";
            this.buttonSetKey.UseVisualStyleBackColor = true;
            this.buttonSetKey.Click += new System.EventHandler(this.buttonSetKey_Click);
            // 
            // buttonNGram
            // 
            this.buttonNGram.Location = new System.Drawing.Point(316, 13);
            this.buttonNGram.Name = "buttonNGram";
            this.buttonNGram.Size = new System.Drawing.Size(133, 23);
            this.buttonNGram.TabIndex = 26;
            this.buttonNGram.Text = "Find key with N-gram";
            this.buttonNGram.UseVisualStyleBackColor = true;
            this.buttonNGram.Click += new System.EventHandler(this.buttonNGram_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageMono);
            this.tabControl1.Controls.Add(this.tabPageVigenere);
            this.tabControl1.Controls.Add(this.tabPagePoly);
            this.tabControl1.Location = new System.Drawing.Point(4, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(493, 652);
            this.tabControl1.TabIndex = 27;
            // 
            // tabPageMono
            // 
            this.tabPageMono.Controls.Add(this.label1);
            this.tabPageMono.Controls.Add(this.buttonNGram);
            this.tabPageMono.Controls.Add(this.nGramComboBox);
            this.tabPageMono.Controls.Add(this.buttonSetKey);
            this.tabPageMono.Controls.Add(this.buttonFind);
            this.tabPageMono.Controls.Add(this.textBoxFullKey);
            this.tabPageMono.Controls.Add(this.listViewQuad);
            this.tabPageMono.Controls.Add(this.groupBox);
            this.tabPageMono.Controls.Add(this.buttonImprove);
            this.tabPageMono.Controls.Add(this.listViewTri);
            this.tabPageMono.Controls.Add(this.listViewBi);
            this.tabPageMono.Controls.Add(this.label4);
            this.tabPageMono.Controls.Add(this.textBoxIterations);
            this.tabPageMono.Location = new System.Drawing.Point(4, 22);
            this.tabPageMono.Name = "tabPageMono";
            this.tabPageMono.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMono.Size = new System.Drawing.Size(485, 626);
            this.tabPageMono.TabIndex = 0;
            this.tabPageMono.Text = "Mono";
            this.tabPageMono.UseVisualStyleBackColor = true;
            // 
            // tabPageVigenere
            // 
            this.tabPageVigenere.Controls.Add(this.chartMonoFreq);
            this.tabPageVigenere.Controls.Add(this.listBoxRowsData);
            this.tabPageVigenere.Controls.Add(this.buttonSetVigKey);
            this.tabPageVigenere.Controls.Add(this.textBoxVigKey);
            this.tabPageVigenere.Controls.Add(this.buttonGetVigKey);
            this.tabPageVigenere.Controls.Add(this.buttonSetKeySize);
            this.tabPageVigenere.Controls.Add(this.textBoxKeySize);
            this.tabPageVigenere.Controls.Add(this.buttonGetKeySize);
            this.tabPageVigenere.Location = new System.Drawing.Point(4, 22);
            this.tabPageVigenere.Name = "tabPageVigenere";
            this.tabPageVigenere.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVigenere.Size = new System.Drawing.Size(485, 626);
            this.tabPageVigenere.TabIndex = 1;
            this.tabPageVigenere.Text = "Vigenere";
            this.tabPageVigenere.UseVisualStyleBackColor = true;
            // 
            // chartMonoFreq
            // 
            chartArea2.Name = "ChartArea1";
            this.chartMonoFreq.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartMonoFreq.Legends.Add(legend2);
            this.chartMonoFreq.Location = new System.Drawing.Point(7, 248);
            this.chartMonoFreq.Name = "chartMonoFreq";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Freq";
            this.chartMonoFreq.Series.Add(series2);
            this.chartMonoFreq.Size = new System.Drawing.Size(472, 372);
            this.chartMonoFreq.TabIndex = 7;
            this.chartMonoFreq.Text = "chartMonoFreq";
            // 
            // listBoxRowsData
            // 
            this.listBoxRowsData.FormattingEnabled = true;
            this.listBoxRowsData.HorizontalScrollbar = true;
            this.listBoxRowsData.Location = new System.Drawing.Point(7, 68);
            this.listBoxRowsData.Name = "listBoxRowsData";
            this.listBoxRowsData.Size = new System.Drawing.Size(472, 173);
            this.listBoxRowsData.TabIndex = 6;
            // 
            // buttonSetVigKey
            // 
            this.buttonSetVigKey.Location = new System.Drawing.Point(144, 38);
            this.buttonSetVigKey.Name = "buttonSetVigKey";
            this.buttonSetVigKey.Size = new System.Drawing.Size(52, 23);
            this.buttonSetVigKey.TabIndex = 5;
            this.buttonSetVigKey.Text = "Set key";
            this.buttonSetVigKey.UseVisualStyleBackColor = true;
            this.buttonSetVigKey.Click += new System.EventHandler(this.buttonSetVigKey_Click);
            // 
            // textBoxVigKey
            // 
            this.textBoxVigKey.Location = new System.Drawing.Point(65, 40);
            this.textBoxVigKey.Name = "textBoxVigKey";
            this.textBoxVigKey.Size = new System.Drawing.Size(73, 20);
            this.textBoxVigKey.TabIndex = 4;
            // 
            // buttonGetVigKey
            // 
            this.buttonGetVigKey.Location = new System.Drawing.Point(7, 38);
            this.buttonGetVigKey.Name = "buttonGetVigKey";
            this.buttonGetVigKey.Size = new System.Drawing.Size(52, 23);
            this.buttonGetVigKey.TabIndex = 3;
            this.buttonGetVigKey.Text = "Get key";
            this.buttonGetVigKey.UseVisualStyleBackColor = true;
            this.buttonGetVigKey.Click += new System.EventHandler(this.buttonGetVigKey_Click);
            // 
            // buttonSetKeySize
            // 
            this.buttonSetKeySize.Location = new System.Drawing.Point(121, 9);
            this.buttonSetKeySize.Name = "buttonSetKeySize";
            this.buttonSetKeySize.Size = new System.Drawing.Size(75, 23);
            this.buttonSetKeySize.TabIndex = 2;
            this.buttonSetKeySize.Text = "Set key size";
            this.buttonSetKeySize.UseVisualStyleBackColor = true;
            this.buttonSetKeySize.Click += new System.EventHandler(this.buttonSetKeySize_Click);
            // 
            // textBoxKeySize
            // 
            this.textBoxKeySize.Location = new System.Drawing.Point(88, 10);
            this.textBoxKeySize.Name = "textBoxKeySize";
            this.textBoxKeySize.Size = new System.Drawing.Size(27, 20);
            this.textBoxKeySize.TabIndex = 1;
            // 
            // buttonGetKeySize
            // 
            this.buttonGetKeySize.Location = new System.Drawing.Point(6, 8);
            this.buttonGetKeySize.Name = "buttonGetKeySize";
            this.buttonGetKeySize.Size = new System.Drawing.Size(75, 23);
            this.buttonGetKeySize.TabIndex = 0;
            this.buttonGetKeySize.Text = "Get key size";
            this.buttonGetKeySize.UseVisualStyleBackColor = true;
            this.buttonGetKeySize.Click += new System.EventHandler(this.buttonGetKeySize_Click);
            // 
            // tabPagePoly
            // 
            this.tabPagePoly.Controls.Add(this.buttonPolyImprove);
            this.tabPagePoly.Controls.Add(this.buttonSetPolyKey);
            this.tabPagePoly.Controls.Add(this.tabControlPoly);
            this.tabPagePoly.Controls.Add(this.buttonFindPoly);
            this.tabPagePoly.Location = new System.Drawing.Point(4, 22);
            this.tabPagePoly.Name = "tabPagePoly";
            this.tabPagePoly.Size = new System.Drawing.Size(485, 626);
            this.tabPagePoly.TabIndex = 2;
            this.tabPagePoly.Text = "Poly";
            this.tabPagePoly.UseVisualStyleBackColor = true;
            // 
            // buttonSetPolyKey
            // 
            this.buttonSetPolyKey.Location = new System.Drawing.Point(87, 4);
            this.buttonSetPolyKey.Name = "buttonSetPolyKey";
            this.buttonSetPolyKey.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPolyKey.TabIndex = 2;
            this.buttonSetPolyKey.Text = "Set key";
            this.buttonSetPolyKey.UseVisualStyleBackColor = true;
            this.buttonSetPolyKey.Click += new System.EventHandler(this.buttonSetPolyKey_Click);
            // 
            // tabControlPoly
            // 
            this.tabControlPoly.Controls.Add(this.tabPagePolyCharts);
            this.tabControlPoly.Controls.Add(this.tabPagePolyKeyDet);
            this.tabControlPoly.Controls.Add(this.tabPagePolyKey);
            this.tabControlPoly.Location = new System.Drawing.Point(5, 34);
            this.tabControlPoly.Name = "tabControlPoly";
            this.tabControlPoly.SelectedIndex = 0;
            this.tabControlPoly.Size = new System.Drawing.Size(477, 589);
            this.tabControlPoly.TabIndex = 1;
            // 
            // tabPagePolyCharts
            // 
            this.tabPagePolyCharts.Controls.Add(this.chartPanel);
            this.tabPagePolyCharts.Location = new System.Drawing.Point(4, 22);
            this.tabPagePolyCharts.Name = "tabPagePolyCharts";
            this.tabPagePolyCharts.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePolyCharts.Size = new System.Drawing.Size(469, 563);
            this.tabPagePolyCharts.TabIndex = 0;
            this.tabPagePolyCharts.Text = "Charts";
            this.tabPagePolyCharts.UseVisualStyleBackColor = true;
            // 
            // chartPanel
            // 
            this.chartPanel.AutoScroll = true;
            this.chartPanel.Location = new System.Drawing.Point(6, 6);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(457, 551);
            this.chartPanel.TabIndex = 1;
            // 
            // tabPagePolyKeyDet
            // 
            this.tabPagePolyKeyDet.Controls.Add(this.panelPolyKey);
            this.tabPagePolyKeyDet.Location = new System.Drawing.Point(4, 22);
            this.tabPagePolyKeyDet.Name = "tabPagePolyKeyDet";
            this.tabPagePolyKeyDet.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePolyKeyDet.Size = new System.Drawing.Size(469, 563);
            this.tabPagePolyKeyDet.TabIndex = 1;
            this.tabPagePolyKeyDet.Text = "Key detailed";
            this.tabPagePolyKeyDet.UseVisualStyleBackColor = true;
            // 
            // panelPolyKey
            // 
            this.panelPolyKey.AutoScroll = true;
            this.panelPolyKey.Location = new System.Drawing.Point(4, 7);
            this.panelPolyKey.Name = "panelPolyKey";
            this.panelPolyKey.Size = new System.Drawing.Size(462, 553);
            this.panelPolyKey.TabIndex = 0;
            // 
            // buttonFindPoly
            // 
            this.buttonFindPoly.Location = new System.Drawing.Point(5, 4);
            this.buttonFindPoly.Name = "buttonFindPoly";
            this.buttonFindPoly.Size = new System.Drawing.Size(75, 23);
            this.buttonFindPoly.TabIndex = 0;
            this.buttonFindPoly.Text = "Find key";
            this.buttonFindPoly.UseVisualStyleBackColor = true;
            this.buttonFindPoly.Click += new System.EventHandler(this.buttonFindPoly_Click);
            // 
            // tabPagePolyKey
            // 
            this.tabPagePolyKey.Location = new System.Drawing.Point(4, 22);
            this.tabPagePolyKey.Name = "tabPagePolyKey";
            this.tabPagePolyKey.Size = new System.Drawing.Size(469, 563);
            this.tabPagePolyKey.TabIndex = 2;
            this.tabPagePolyKey.Text = "Key";
            this.tabPagePolyKey.UseVisualStyleBackColor = true;
            // 
            // buttonPolyImprove
            // 
            this.buttonPolyImprove.Location = new System.Drawing.Point(403, 4);
            this.buttonPolyImprove.Name = "buttonPolyImprove";
            this.buttonPolyImprove.Size = new System.Drawing.Size(75, 23);
            this.buttonPolyImprove.TabIndex = 3;
            this.buttonPolyImprove.Text = "Improve key";
            this.buttonPolyImprove.UseVisualStyleBackColor = true;
            this.buttonPolyImprove.Click += new System.EventHandler(this.buttonPolyImprove_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1347, 693);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.textBoxSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Main Form";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPageMono.ResumeLayout(false);
            this.tabPageMono.PerformLayout();
            this.tabPageVigenere.ResumeLayout(false);
            this.tabPageVigenere.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartMonoFreq)).EndInit();
            this.tabPagePoly.ResumeLayout(false);
            this.tabControlPoly.ResumeLayout(false);
            this.tabPagePolyCharts.ResumeLayout(false);
            this.tabPagePolyKeyDet.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox nGramComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.RichTextBox textBoxSource;
        private System.Windows.Forms.RichTextBox textBoxResult;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxIterations;
        private System.Windows.Forms.ListView listViewBi;
        private System.Windows.Forms.ListView listViewTri;
        private System.Windows.Forms.ColumnHeader Bigram;
        private System.Windows.Forms.ColumnHeader Bicount;
        private System.Windows.Forms.ColumnHeader Trigram;
        private System.Windows.Forms.ColumnHeader Tricount;
        private System.Windows.Forms.Button buttonImprove;
        private System.Windows.Forms.ListView listViewQuad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.TextBox textBoxFullKey;
        private System.Windows.Forms.Button buttonSetKey;
        private System.Windows.Forms.Button buttonNGram;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageMono;
        private System.Windows.Forms.TabPage tabPageVigenere;
        private System.Windows.Forms.Button buttonSetKeySize;
        private System.Windows.Forms.TextBox textBoxKeySize;
        private System.Windows.Forms.Button buttonGetKeySize;
        private System.Windows.Forms.Button buttonSetVigKey;
        private System.Windows.Forms.TextBox textBoxVigKey;
        private System.Windows.Forms.Button buttonGetVigKey;
        private System.Windows.Forms.ListBox listBoxRowsData;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartMonoFreq;
        private System.Windows.Forms.TabPage tabPagePoly;
        private System.Windows.Forms.Button buttonFindPoly;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.TabControl tabControlPoly;
        private System.Windows.Forms.TabPage tabPagePolyCharts;
        private System.Windows.Forms.TabPage tabPagePolyKeyDet;
        private System.Windows.Forms.Panel panelPolyKey;
        private System.Windows.Forms.Button buttonSetPolyKey;
        private System.Windows.Forms.TabPage tabPagePolyKey;
        private System.Windows.Forms.Button buttonPolyImprove;
    }
}


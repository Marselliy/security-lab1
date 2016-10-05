namespace security_lab1_csharp.View.Analysis
{
    partial class KeyAnalysisPanelGlobal
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
            this.listViewQuad = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewTri = new System.Windows.Forms.ListView();
            this.Trigram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Tricount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewBi = new System.Windows.Forms.ListView();
            this.Bigram = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Bicount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMono = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewQuad
            // 
            this.listViewQuad.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewQuad.Location = new System.Drawing.Point(327, 9);
            this.listViewQuad.Name = "listViewQuad";
            this.listViewQuad.Size = new System.Drawing.Size(107, 462);
            this.listViewQuad.TabIndex = 26;
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
            this.columnHeader2.Width = 49;
            // 
            // listViewTri
            // 
            this.listViewTri.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Trigram,
            this.Tricount});
            this.listViewTri.Location = new System.Drawing.Point(219, 9);
            this.listViewTri.Name = "listViewTri";
            this.listViewTri.Size = new System.Drawing.Size(102, 462);
            this.listViewTri.TabIndex = 25;
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
            this.Tricount.Width = 50;
            // 
            // listViewBi
            // 
            this.listViewBi.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bigram,
            this.Bicount});
            this.listViewBi.Location = new System.Drawing.Point(111, 9);
            this.listViewBi.Name = "listViewBi";
            this.listViewBi.Size = new System.Drawing.Size(102, 462);
            this.listViewBi.TabIndex = 24;
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
            this.Bicount.Width = 53;
            // 
            // listViewMono
            // 
            this.listViewMono.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.listViewMono.Location = new System.Drawing.Point(3, 9);
            this.listViewMono.Name = "listViewMono";
            this.listViewMono.Size = new System.Drawing.Size(102, 462);
            this.listViewMono.TabIndex = 27;
            this.listViewMono.UseCompatibleStateImageBehavior = false;
            this.listViewMono.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Monogram";
            this.columnHeader3.Width = 58;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Count";
            this.columnHeader4.Width = 40;
            // 
            // KeyAnalysisPanelMono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewMono);
            this.Controls.Add(this.listViewQuad);
            this.Controls.Add(this.listViewTri);
            this.Controls.Add(this.listViewBi);
            this.Name = "KeyAnalysisPanelMono";
            this.Size = new System.Drawing.Size(437, 474);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewQuad;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView listViewTri;
        private System.Windows.Forms.ColumnHeader Trigram;
        private System.Windows.Forms.ColumnHeader Tricount;
        private System.Windows.Forms.ListView listViewBi;
        private System.Windows.Forms.ColumnHeader Bigram;
        private System.Windows.Forms.ColumnHeader Bicount;
        private System.Windows.Forms.ListView listViewMono;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}

namespace security_lab1_csharp.View.Improvement.ImproverPanels
{
    partial class KeyImproverPanelGenetics
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
            this.textBoxPopSize = new System.Windows.Forms.TextBox();
            this.trackBarMutRater = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMutRater)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBoxPopSize.Location = new System.Drawing.Point(221, 21);
            this.textBoxPopSize.Name = "textBox1";
            this.textBoxPopSize.Size = new System.Drawing.Size(54, 20);
            this.textBoxPopSize.TabIndex = 5;
            this.textBoxPopSize.Text = "100";
            // 
            // trackBar1
            // 
            this.trackBarMutRater.BackColor = System.Drawing.SystemColors.Window;
            this.trackBarMutRater.Location = new System.Drawing.Point(103, 21);
            this.trackBarMutRater.Maximum = 100;
            this.trackBarMutRater.Name = "trackBar1";
            this.trackBarMutRater.Size = new System.Drawing.Size(104, 45);
            this.trackBarMutRater.TabIndex = 4;
            this.trackBarMutRater.Value = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Population size";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mutation rate";
            // 
            // KeyImproverPanelGenetics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.textBoxPopSize);
            this.Controls.Add(this.trackBarMutRater);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KeyImproverPanelGenetics";
            this.Size = new System.Drawing.Size(296, 73);
            ((System.ComponentModel.ISupportInitialize)(this.trackBarMutRater)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TrackBar trackBarMutRater;
        private System.Windows.Forms.TextBox textBoxPopSize;
    }
}

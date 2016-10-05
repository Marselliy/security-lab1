namespace security_lab1_csharp.View.Improvement
{
    partial class KeyImprovementPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxIterCount = new System.Windows.Forms.TextBox();
            this.panelOptimizationMethod = new System.Windows.Forms.Panel();
            this.buttonImprove = new System.Windows.Forms.Button();
            this.textBoxOptions = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Optimization method";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Iteration count";
            // 
            // textBoxIterCount
            // 
            this.textBoxIterCount.Location = new System.Drawing.Point(323, 4);
            this.textBoxIterCount.Name = "textBoxIterCount";
            this.textBoxIterCount.Size = new System.Drawing.Size(40, 20);
            this.textBoxIterCount.TabIndex = 3;
            this.textBoxIterCount.Text = "100";
            // 
            // panelOptimizationMethod
            // 
            this.panelOptimizationMethod.AutoScroll = true;
            this.panelOptimizationMethod.Location = new System.Drawing.Point(4, 28);
            this.panelOptimizationMethod.Name = "panelOptimizationMethod";
            this.panelOptimizationMethod.Size = new System.Drawing.Size(438, 234);
            this.panelOptimizationMethod.TabIndex = 4;
            // 
            // buttonImprove
            // 
            this.buttonImprove.Location = new System.Drawing.Point(367, 483);
            this.buttonImprove.Name = "buttonImprove";
            this.buttonImprove.Size = new System.Drawing.Size(75, 23);
            this.buttonImprove.TabIndex = 5;
            this.buttonImprove.Text = "Improve key";
            this.buttonImprove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonImprove.UseVisualStyleBackColor = true;
            this.buttonImprove.Click += new System.EventHandler(this.buttonImprove_Click);
            // 
            // textBoxOptions
            // 
            this.textBoxOptions.Location = new System.Drawing.Point(4, 268);
            this.textBoxOptions.Multiline = true;
            this.textBoxOptions.Name = "textBoxOptions";
            this.textBoxOptions.Size = new System.Drawing.Size(438, 209);
            this.textBoxOptions.TabIndex = 6;
            // 
            // KeyImprovementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBoxOptions);
            this.Controls.Add(this.buttonImprove);
            this.Controls.Add(this.panelOptimizationMethod);
            this.Controls.Add(this.textBoxIterCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "KeyImprovementPanel";
            this.Size = new System.Drawing.Size(448, 514);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxIterCount;
        private System.Windows.Forms.Panel panelOptimizationMethod;
        private System.Windows.Forms.Button buttonImprove;
        private System.Windows.Forms.TextBox textBoxOptions;
    }
}

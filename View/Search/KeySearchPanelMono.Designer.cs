namespace security_lab1_csharp.View.Search
{
    partial class KeySearchPanelMono
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
            this.buttonFindKey = new System.Windows.Forms.Button();
            this.nGramComboBox = new System.Windows.Forms.ComboBox();
            this.buttonSetKey = new System.Windows.Forms.Button();
            this.textBoxMonoKey = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "N-gram";
            // 
            // buttonFindKey
            // 
            this.buttonFindKey.Location = new System.Drawing.Point(193, 9);
            this.buttonFindKey.Name = "buttonFindKey";
            this.buttonFindKey.Size = new System.Drawing.Size(75, 23);
            this.buttonFindKey.TabIndex = 33;
            this.buttonFindKey.Text = "Find key";
            this.buttonFindKey.UseVisualStyleBackColor = true;
            this.buttonFindKey.Click += new System.EventHandler(this.buttonFindKey_Click);
            // 
            // nGramComboBox
            // 
            this.nGramComboBox.Items.AddRange(new object[] {
            "Monogram",
            "Bigram",
            "Trigram",
            "Quadgram",
            "Quintgram"});
            this.nGramComboBox.Location = new System.Drawing.Point(66, 9);
            this.nGramComboBox.Name = "nGramComboBox";
            this.nGramComboBox.Size = new System.Drawing.Size(121, 21);
            this.nGramComboBox.TabIndex = 27;
            // 
            // buttonSetKey
            // 
            this.buttonSetKey.Location = new System.Drawing.Point(355, 42);
            this.buttonSetKey.Name = "buttonSetKey";
            this.buttonSetKey.Size = new System.Drawing.Size(75, 23);
            this.buttonSetKey.TabIndex = 32;
            this.buttonSetKey.Text = "Set key";
            this.buttonSetKey.UseVisualStyleBackColor = true;
            this.buttonSetKey.Click += new System.EventHandler(this.buttonSetKey_Click);
            // 
            // textBoxMonoKey
            // 
            this.textBoxMonoKey.Location = new System.Drawing.Point(6, 44);
            this.textBoxMonoKey.Name = "textBoxMonoKey";
            this.textBoxMonoKey.Size = new System.Drawing.Size(343, 20);
            this.textBoxMonoKey.TabIndex = 31;
            // 
            // KeySearchPanelMono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonFindKey);
            this.Controls.Add(this.nGramComboBox);
            this.Controls.Add(this.buttonSetKey);
            this.Controls.Add(this.textBoxMonoKey);
            this.Name = "KeySearchPanelMono";
            this.Size = new System.Drawing.Size(434, 348);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonFindKey;
        private System.Windows.Forms.ComboBox nGramComboBox;
        private System.Windows.Forms.Button buttonSetKey;
        private System.Windows.Forms.TextBox textBoxMonoKey;
    }
}

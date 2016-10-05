namespace security_lab1_csharp.View.Search
{
    partial class KeySearchPanelVigenere
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
            this.buttonSetVigKey = new System.Windows.Forms.Button();
            this.textBoxVigKey = new System.Windows.Forms.TextBox();
            this.buttonGetVigKey = new System.Windows.Forms.Button();
            this.textBoxKeySize = new System.Windows.Forms.TextBox();
            this.buttonGetKeySize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSetVigKey
            // 
            this.buttonSetVigKey.Location = new System.Drawing.Point(270, 33);
            this.buttonSetVigKey.Name = "buttonSetVigKey";
            this.buttonSetVigKey.Size = new System.Drawing.Size(52, 23);
            this.buttonSetVigKey.TabIndex = 11;
            this.buttonSetVigKey.Text = "Set key";
            this.buttonSetVigKey.UseVisualStyleBackColor = true;
            this.buttonSetVigKey.Click += new System.EventHandler(this.buttonSetVigKey_Click);
            // 
            // textBoxVigKey
            // 
            this.textBoxVigKey.Location = new System.Drawing.Point(62, 35);
            this.textBoxVigKey.Name = "textBoxVigKey";
            this.textBoxVigKey.Size = new System.Drawing.Size(202, 20);
            this.textBoxVigKey.TabIndex = 10;
            // 
            // buttonGetVigKey
            // 
            this.buttonGetVigKey.Location = new System.Drawing.Point(4, 33);
            this.buttonGetVigKey.Name = "buttonGetVigKey";
            this.buttonGetVigKey.Size = new System.Drawing.Size(52, 23);
            this.buttonGetVigKey.TabIndex = 9;
            this.buttonGetVigKey.Text = "Get key";
            this.buttonGetVigKey.UseVisualStyleBackColor = true;
            this.buttonGetVigKey.Click += new System.EventHandler(this.buttonGetVigKey_Click);
            // 
            // textBoxKeySize
            // 
            this.textBoxKeySize.Location = new System.Drawing.Point(85, 5);
            this.textBoxKeySize.Name = "textBoxKeySize";
            this.textBoxKeySize.Size = new System.Drawing.Size(27, 20);
            this.textBoxKeySize.TabIndex = 7;
            // 
            // buttonGetKeySize
            // 
            this.buttonGetKeySize.Location = new System.Drawing.Point(3, 3);
            this.buttonGetKeySize.Name = "buttonGetKeySize";
            this.buttonGetKeySize.Size = new System.Drawing.Size(75, 23);
            this.buttonGetKeySize.TabIndex = 6;
            this.buttonGetKeySize.Text = "Get key size";
            this.buttonGetKeySize.UseVisualStyleBackColor = true;
            this.buttonGetKeySize.Click += new System.EventHandler(this.buttonGetKeySize_Click);
            // 
            // KeySearchPanelVigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSetVigKey);
            this.Controls.Add(this.textBoxVigKey);
            this.Controls.Add(this.buttonGetVigKey);
            this.Controls.Add(this.textBoxKeySize);
            this.Controls.Add(this.buttonGetKeySize);
            this.Name = "KeySearchPanelVigenere";
            this.Size = new System.Drawing.Size(477, 472);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSetVigKey;
        private System.Windows.Forms.TextBox textBoxVigKey;
        private System.Windows.Forms.Button buttonGetVigKey;
        private System.Windows.Forms.TextBox textBoxKeySize;
        private System.Windows.Forms.Button buttonGetKeySize;
    }
}

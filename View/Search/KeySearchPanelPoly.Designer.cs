namespace security_lab1_csharp.View.Search
{
    partial class KeySearchPanelPoly
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
            this.buttonSetPolyKey = new System.Windows.Forms.Button();
            this.buttonFindPoly = new System.Windows.Forms.Button();
            this.panelPolyKey = new System.Windows.Forms.Panel();
            this.tabControlPoly = new System.Windows.Forms.TabControl();
            this.tabPagePolyKeyDet = new System.Windows.Forms.TabPage();
            this.tabPagePolyKey = new System.Windows.Forms.TabPage();
            this.tabControlPoly.SuspendLayout();
            this.tabPagePolyKeyDet.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSetPolyKey
            // 
            this.buttonSetPolyKey.Location = new System.Drawing.Point(85, 3);
            this.buttonSetPolyKey.Name = "buttonSetPolyKey";
            this.buttonSetPolyKey.Size = new System.Drawing.Size(75, 23);
            this.buttonSetPolyKey.TabIndex = 6;
            this.buttonSetPolyKey.Text = "Set key";
            this.buttonSetPolyKey.UseVisualStyleBackColor = true;
            this.buttonSetPolyKey.Click += new System.EventHandler(this.buttonSetPolyKey_Click);
            // 
            // buttonFindPoly
            // 
            this.buttonFindPoly.Location = new System.Drawing.Point(3, 3);
            this.buttonFindPoly.Name = "buttonFindPoly";
            this.buttonFindPoly.Size = new System.Drawing.Size(75, 23);
            this.buttonFindPoly.TabIndex = 4;
            this.buttonFindPoly.Text = "Find key";
            this.buttonFindPoly.UseVisualStyleBackColor = true;
            this.buttonFindPoly.Click += new System.EventHandler(this.buttonFindPoly_Click);
            // 
            // panelPolyKey
            // 
            this.panelPolyKey.AutoScroll = true;
            this.panelPolyKey.Location = new System.Drawing.Point(4, 7);
            this.panelPolyKey.Name = "panelPolyKey";
            this.panelPolyKey.Size = new System.Drawing.Size(462, 553);
            this.panelPolyKey.TabIndex = 0;
            // 
            // tabControlPoly
            // 
            this.tabControlPoly.Controls.Add(this.tabPagePolyKeyDet);
            this.tabControlPoly.Controls.Add(this.tabPagePolyKey);
            this.tabControlPoly.Location = new System.Drawing.Point(3, 33);
            this.tabControlPoly.Name = "tabControlPoly";
            this.tabControlPoly.SelectedIndex = 0;
            this.tabControlPoly.Size = new System.Drawing.Size(477, 589);
            this.tabControlPoly.TabIndex = 5;
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
            // tabPagePolyKey
            // 
            this.tabPagePolyKey.Location = new System.Drawing.Point(4, 22);
            this.tabPagePolyKey.Name = "tabPagePolyKey";
            this.tabPagePolyKey.Size = new System.Drawing.Size(469, 563);
            this.tabPagePolyKey.TabIndex = 2;
            this.tabPagePolyKey.Text = "Key";
            this.tabPagePolyKey.UseVisualStyleBackColor = true;
            // 
            // KeySearchPanelPoly
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonSetPolyKey);
            this.Controls.Add(this.buttonFindPoly);
            this.Controls.Add(this.tabControlPoly);
            this.Name = "KeySearchPanelPoly";
            this.Size = new System.Drawing.Size(481, 629);
            this.tabControlPoly.ResumeLayout(false);
            this.tabPagePolyKeyDet.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonSetPolyKey;
        private System.Windows.Forms.Button buttonFindPoly;
        private System.Windows.Forms.Panel panelPolyKey;
        private System.Windows.Forms.TabControl tabControlPoly;
        private System.Windows.Forms.TabPage tabPagePolyKeyDet;
        private System.Windows.Forms.TabPage tabPagePolyKey;
    }
}

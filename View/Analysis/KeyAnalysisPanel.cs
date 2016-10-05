using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using security_lab1_csharp.Core.Keys;

namespace security_lab1_csharp.View.Analysis
{
    public abstract class KeyAnalysisPanel : UserControl
    {
        protected string plainText;
        private Label label2;
        private ComboBox comboBox1;
        private Label label1;
        private Button buttonImprove;
        private TextBox textBoxIterations;
        protected string KeyTypeName;
        public abstract void UpdateKeyAnalysis(Key key);
        public abstract void ClearKeyAnalysis();

        public string GetKeyTypeName()
        {
            return KeyTypeName;
        }

        public void SetPlainText(string plainText)
        {
            this.plainText = plainText;
        }

        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonImprove = new System.Windows.Forms.Button();
            this.textBoxIterations = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Optimization method";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(115, 3);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Iterations";
            // 
            // buttonImprove
            // 
            this.buttonImprove.Location = new System.Drawing.Point(171, 30);
            this.buttonImprove.Name = "buttonImprove";
            this.buttonImprove.Size = new System.Drawing.Size(107, 23);
            this.buttonImprove.TabIndex = 28;
            this.buttonImprove.Text = "Improve key (A*)";
            this.buttonImprove.UseVisualStyleBackColor = true;
            // 
            // textBoxIterations
            // 
            this.textBoxIterations.Location = new System.Drawing.Point(350, 3);
            this.textBoxIterations.Name = "textBoxIterations";
            this.textBoxIterations.Size = new System.Drawing.Size(45, 20);
            this.textBoxIterations.TabIndex = 27;
            this.textBoxIterations.Text = "1000";
            // 
            // KeyAnalysisPanel
            // 
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonImprove);
            this.Controls.Add(this.textBoxIterations);
            this.Name = "KeyAnalysisPanel";
            this.Size = new System.Drawing.Size(476, 493);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

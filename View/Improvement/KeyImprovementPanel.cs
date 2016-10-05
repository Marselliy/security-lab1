using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using security_lab1_csharp.Core.KeyImpovers;
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.Core.Raters;
using security_lab1_csharp.View.Improvement.ImproverPanels;

namespace security_lab1_csharp.View.Improvement
{
    public partial class KeyImprovementPanel : UserControl
    {
        public string plainText;
        private KeyImproverPanel[] panels;
        public KeyImprovementPanel()
        {
            InitializeComponent();
            panels = KeyImproverPanelFactory.getPanels();
            for (var i = 0; i < panels.Count(); i++)
            {
                panels[i].Parent = panelOptimizationMethod;
                panels[i].Location = i > 0 ? new Point(0, panels[i - 1].Location.Y + panels[i - 1].Height) : new Point(0, 0);
                var rb = new RadioButton();
                
            }
        }
        public void SetPlainText(string plainText)
        {
            this.plainText = plainText;
        }

        private void buttonImprove_Click(object sender, EventArgs e)
        {
            var raterStrings = textBoxOptions.Text.Split('\r', '\n').Where(str => str.Length != 0).ToArray();
            var rater = new KeyRaterComplex(plainText, raterStrings.Select(str => KeyRaterFactory.FromString(str, plainText)).ToArray());
            if (ParentForm is MainFormNew)
            {
                var key = ((MainFormNew) ParentForm).key;
                foreach (var panel in panels)
                {
                    if (panel.Selected())
                    {
                        key = panel.GeImprover(rater).ImproveKey(key, int.Parse(textBoxIterCount.Text));
                    }
                }
                ((MainFormNew)ParentForm).SetKey(key);
            }
        }
    }
}

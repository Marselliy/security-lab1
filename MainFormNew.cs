using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.View.Analysis;
using security_lab1_csharp.View.Improvement;
using security_lab1_csharp.View.Search;

namespace security_lab1_csharp
{
    public partial class MainFormNew : Form
    {
        public Key key;
        private KeyAnalysisPanel[] keyAnalysisPanels;
        private KeySearchPanel[] keySearchPanels;
        private KeyImprovementPanel keyImprovementPanel;
        public MainFormNew()
        {
            InitializeComponent();
            keyAnalysisPanels = KeyAnalysisPanelFactory.getPanels();
            keySearchPanels = KeySearchPanelFactory.getPanels();
            keyImprovementPanel = new KeyImprovementPanel();
            foreach (var panel in keyAnalysisPanels)
            {
                var parentPage = new TabPage(panel.GetKeyTypeName());
                panel.Parent = parentPage;
                tabControlAnalysis.TabPages.Add(parentPage);
            }
            foreach (var panel in keySearchPanels)
            {
                var parentPage = new TabPage(panel.GetKeyTypeName());
                panel.Parent = parentPage;
                tabControlSearch.TabPages.Add(parentPage);
            }
            keyImprovementPanel.Parent = tabPageImprove;
            textBoxSource.TextChanged += SourceTextChanged;
            textBoxResult.TextChanged += ResultTextChanged;
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = "";
            Stream myStream = null;
            var openFileDialog1 = new OpenFileDialog
            {
                InitialDirectory = Directory.GetCurrentDirectory(),
                RestoreDirectory = true
            };


            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            try
            {
                if ((myStream = openFileDialog1.OpenFile()) == null) return;
                using (myStream)
                {
                    var sb = new StringBuilder();
                    var c = (char)myStream.ReadByte();
                    do
                    {
                        sb.Append(c);
                        c = (char)myStream.ReadByte();
                    }
                    while (c != 65535);
                    textBoxSource.Text = sb.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
            }
        }

        public void SourceTextChanged(object sender, EventArgs e)
        {
            foreach (var panel in keyAnalysisPanels)
            {
                panel.SetPlainText(textBoxSource.Text);
            }
            foreach (var panel in keySearchPanels)
            {
                panel.SetPlainText(textBoxSource.Text);
            }
            keyImprovementPanel.SetPlainText(textBoxSource.Text);
        }
        public void ResultTextChanged(object sender, EventArgs e)
        {
            foreach (var panel in keyAnalysisPanels)
            {
                panel.UpdateKeyAnalysis(key);
            }
        }
        public void SetKey(Key newKey)
        {
            key = newKey;
            textBoxResult.Text = key.ApplyKey(textBoxSource.Text);
            foreach (var panel in keySearchPanels)
            {
                panel.SetKey(key);
            }
        }
    }
}

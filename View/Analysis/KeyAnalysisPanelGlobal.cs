using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using security_lab1_csharp.Core.Keys;

namespace security_lab1_csharp.View.Analysis
{
    public partial class KeyAnalysisPanelGlobal : KeyAnalysisPanel
    {
        public KeyAnalysisPanelGlobal()
        {
            InitializeComponent();
            KeyTypeName = "Global";
        }

        public override void UpdateKeyAnalysis(Key key)
        {
            var cipherText = key.ApplyKey(plainText);
            var realMonoCountsList = Util.getSortedRealNGramCountList(cipherText, 1);
            var realBiCountsList   = Util.getSortedRealNGramCountList(cipherText, 2);
            var realTriCountsList  = Util.getSortedRealNGramCountList(cipherText, 3);
            var realQuadCountsList = Util.getSortedRealNGramCountList(cipherText, 4);

            ClearKeyAnalysis();

            foreach (var pair in realMonoCountsList)
            {
                ListViewItem lvi = new ListViewItem(pair.Key);
                lvi.SubItems.Add(pair.Value.ToString());
                listViewMono.Items.Add(lvi);
            }
            foreach (var pair in realBiCountsList)
            {
                ListViewItem lvi = new ListViewItem(pair.Key);
                lvi.SubItems.Add(pair.Value.ToString());
                listViewBi.Items.Add(lvi);
            }
            foreach (var pair in realTriCountsList)
            {
                ListViewItem lvi = new ListViewItem(pair.Key);
                lvi.SubItems.Add(pair.Value.ToString());
                listViewTri.Items.Add(lvi);
            }
            foreach (var pair in realQuadCountsList)
            {
                ListViewItem lvi = new ListViewItem(pair.Key);
                lvi.SubItems.Add(pair.Value.ToString());
                listViewQuad.Items.Add(lvi);
            }
        }

        public override void ClearKeyAnalysis()
        {
            listViewMono.Items.Clear();
            listViewBi.Items.Clear();
            listViewTri.Items.Clear();
            listViewQuad.Items.Clear();
        }
    }
}

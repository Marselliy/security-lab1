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
    public partial class KeyAnalysisPanelVigenere : KeyAnalysisPanel
    {
        public KeyAnalysisPanelVigenere()
        {
            InitializeComponent();
            KeyTypeName = "Vigenere";
        }

        public override void UpdateKeyAnalysis(Key key)
        {
            if (key is KeyVigenere)
            {
                List<KeyValuePair<string, double>>[] freqListArr = Util.getDataAnalysis(plainText, ((KeyVigenere)key).shifts.Length);

                ClearKeyAnalysis();

                foreach (List<KeyValuePair<string, double>> item in freqListArr)
                {
                    var text = "";
                    for (var j = 0; j < item.Count; j++)
                    {
                        text += item[j].Key + " (" + (char)('A' + (item[j].Key[0] - Util.sortedalphabet[j] + Util.alphabet.Length) % Util.alphabet.Length) + ")\t";
                    }
                    listBoxRowsData.Items.Add(text);
                    text = "";
                    for (var j = 0; j < item.Count; j++)
                    {
                        text += (item[j].Value * 100).ToString("0.00") + "%\t";
                    }
                    listBoxRowsData.Items.Add(text);
                    listBoxRowsData.Items.Add("");
                }
            }
            else
            {
                ClearKeyAnalysis();
            }
        }

        public override void ClearKeyAnalysis()
        {
            listBoxRowsData.Text = "";
            chartMonoFreq.Series[0].Points.Clear();
        }
    }
}

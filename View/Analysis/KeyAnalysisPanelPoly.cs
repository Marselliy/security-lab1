using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using security_lab1_csharp.Core.Keys;

namespace security_lab1_csharp.View.Analysis
{
    public partial class KeyAnalysisPanelPoly : KeyAnalysisPanel
    {
        private Chart[] freqsCharts;
        public KeyAnalysisPanelPoly()
        {
            InitializeComponent();
            KeyTypeName = "Poly";
            var letterFreqList = Util.getTheorNGramFrequency(1).ToList();
            freqsCharts = new Chart[Util.alphabet.Length];
            foreach (var c in Util.alphabet)
            {
                Chart chart = new Chart();
                chart.Width = 400;
                chart.Height = 200;
                chart.Location = new Point(10, 8 + (c - Util.alphabet[0]) *200);
                chart.Visible = true;
                var series = new Series
                {
                    Name = "Frequency",
                    Color = System.Drawing.Color.Green,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Column
                };
                var seriesTheor = new Series
                {
                    Name = "Frequency theor",
                    Color = System.Drawing.Color.Black,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Column
                };
                chart.Series.Add(series);
                chart.Series.Add(seriesTheor);
                letterFreqList.Sort(delegate (KeyValuePair < string, double > pair1,
                KeyValuePair < string, double > pair2)
                {
                    return pair1.Key.CompareTo(pair2.Key);
                });
                foreach (var pair in letterFreqList)
                {
                    chart.Series[1].Points.AddXY(pair.Key[0] - Util.alphabet[0], pair.Value);
                    chart.Series[1].Points[chart.Series[1].Points.Count - 1].AxisLabel = pair.Key[0] + "";
                }
                chart.Parent = chartPanel;
                var chartArea = new ChartArea();
                chartArea.AxisX.LabelStyle.Format = "";
                chartArea.AxisX.MajorGrid.LineColor = Color.LightGray;
                chartArea.AxisY.MajorGrid.LineColor = Color.LightGray;
                chartArea.AxisX.LabelStyle.Font = new Font("Consolas", 8);
                chartArea.AxisY.LabelStyle.Font = new Font("Consolas", 8);
                chartArea.AxisX.Interval = 1;
                chart.ChartAreas.Add(chartArea);
                chart.Invalidate();
                freqsCharts[c - Util.alphabet[0]] = chart;
            }
        }

        public override void UpdateKeyAnalysis(Key key)
        {
            if (key is KeyPoly)
            {
                var cipherText = key.ApplyKey(plainText);
                var polyKey = (KeyPoly) key;
                var freqsArr = Util.getPolyMonogramFrequencies(plainText, polyKey.maps.Length);

                ClearKeyAnalysis();


                for (var i = 0; i < freqsArr.Length; i++)
                {
                    freqsArr[i].Sort(
                    delegate (KeyValuePair<string, double> pair1,
                    KeyValuePair<string, double> pair2)
                    {
                        return pair1.Key.CompareTo(pair2.Key);
                    });
                    foreach (var pair in freqsArr[i])
                    {
                        freqsCharts[i].Series[0].Points.AddXY(pair.Key[0] - Util.alphabet[0], pair.Value);
                    }
                    for (var j = 0; j < freqsCharts[i].Series[0].Points.Count; j++)
                    {
                        freqsCharts[i].Series[0].Points[j].AxisLabel = (char)(Util.alphabet[0] + j) + "";
                    }
                }
            }
            else
            {
                ClearKeyAnalysis();
            }
        }

        public override void ClearKeyAnalysis()
        {
            foreach (var chart in freqsCharts)
            {
                chart.Series[0].Points.Clear();
            }
        }
    }
}

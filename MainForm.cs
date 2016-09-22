using security_lab1_csharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using security_lab1_csharp.Core.KeyFinders;
using security_lab1_csharp.Core.KeyImpovers;
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.Core.LengthFinders;
using security_lab1_csharp.Core.Raters;

namespace security_lab1_csharp
{
    public partial class MainForm : Form
    {
        private Key key = new KeyMono("ABCDEFGHIJKLMNOPQRSTUVWXYZ");
        private TextBox[] keyBoxes;
        private Label[] pLabels;
        private CheckBox[] fixedCheckBox;
        private Chart[] freqsCharts;
        private TextBox[][] polyKeyBoxes;
        private CheckBox[] highLightCheckBox;
        private TextBox[] polyKeyBoxesSimple;
        public MainForm()
        {
            List<KeyValuePair<string, double>> letterFreqList = Util.getTheorNGramFrequency(1).ToList();
            letterFreqList.Sort(
                delegate (KeyValuePair<string, double> pair1,
                KeyValuePair<string, double> pair2)
                {
                    return pair1.Key.CompareTo(pair2.Key);
                });
            Logger.init("log.txt");
            InitializeComponent();
            nGramComboBox.SelectedIndex = 0;
            keyBoxes = new TextBox[26];
            pLabels = new Label[26];
            fixedCheckBox = new CheckBox[26];
            freqsCharts = new Chart[26];
            polyKeyBoxes = new TextBox[26][];
            highLightCheckBox = new CheckBox[26];
            polyKeyBoxesSimple = new TextBox[26];
            for (char c = 'A'; c <= 'Z'; c++)
            {
                Label label = new Label();
                label.Text = c + " =>";
                label.Location = new Point(5, 8 + (c - 'A') * 20 + 5);
                label.Width = 30;
                label.Height = 15;
                label.Visible = true;
                label.Parent = groupBox;

                TextBox textBox = new TextBox();
                textBox.Text = c + "";
                textBox.Location = new Point(35, 5 + (c - 'A') * 20 + 5);
                textBox.Width = 20;
                textBox.Height = 15;
                textBox.Visible = true;
                textBox.Parent = groupBox;
                textBox.KeyUp += new KeyEventHandler(onKeyChanged);
                textBox.MaxLength = 1;
                keyBoxes[c - 'A'] = textBox;

                label = new Label();
                label.Text = "0";
                label.Location = new Point(70, 8 + (c - 'A') * 20 + 5);
                label.Width = 50;
                label.Height = 15;
                label.Visible = true;
                label.Parent = groupBox;
                pLabels[c - 'A'] = label;

                CheckBox checkBox = new CheckBox();
                checkBox.Text = "";
                checkBox.Location = new Point(120, 8 + (c - 'A') * 20 + 5);
                checkBox.Width = 30;
                checkBox.Height = 15;
                checkBox.Visible = true;
                checkBox.Parent = groupBox;
                fixedCheckBox[c - 'A'] = checkBox;

                Chart chart = new Chart();
                chart.Width = 400;
                chart.Height = 200;
                chart.Location = new Point(10, 8 + (c - 'A') * 200);
                chart.Visible = true;
                var series = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Frequency",
                    Color = System.Drawing.Color.Green,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Column
                };
                var seriesTheor = new System.Windows.Forms.DataVisualization.Charting.Series
                {
                    Name = "Frequency theor",
                    Color = System.Drawing.Color.Black,
                    IsVisibleInLegend = true,
                    IsXValueIndexed = true,
                    ChartType = SeriesChartType.Column
                };
                chart.Series.Add(series);
                chart.Series.Add(seriesTheor);
                //chart.Series[0].IsXValueIndexed = false;
                //chart.Series[1].IsXValueIndexed = false;
                foreach (KeyValuePair<string, double> pair in letterFreqList)
                {
                    chart.Series[1].Points.AddXY(pair.Key[0] - 'A', pair.Value);
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
                freqsCharts[c - 'A'] = chart;

                Label labelPolyRow = new Label();
                labelPolyRow.Text = "" + (c - 'A');
                labelPolyRow.Location = new Point(40, 30 + (c - 'A') * 20);
                labelPolyRow.Width = 25;
                labelPolyRow.Height = 15;
                labelPolyRow.Visible = true;
                labelPolyRow.Parent = panelPolyKey;

                Label labelPolyColumn = new Label();
                labelPolyColumn.Text = "" + c;
                labelPolyColumn.Location = new Point(65 + (c - 'A') * 20, 10);
                labelPolyColumn.Width = 15;
                labelPolyColumn.Height = 15;
                labelPolyColumn.Visible = true;
                labelPolyColumn.Parent = panelPolyKey;

                polyKeyBoxes[c - 'A'] = new TextBox[26];
                for (int i = 0; i < 26; i++)
                {
                    TextBox textBoxPolyKey = new TextBox();
                    textBoxPolyKey.Location = new Point(i * 20 + 65, 30 + (c - 'A') * 20);
                    textBoxPolyKey.Width = 20;
                    textBoxPolyKey.Height = 15;
                    textBoxPolyKey.Visible = true;
                    textBoxPolyKey.Parent = panelPolyKey;
                //    textBoxPolyKey.KeyUp += new KeyEventHandler(onKeyChanged);
                    textBoxPolyKey.MaxLength = 1;
                    polyKeyBoxes[c - 'A'][i] = textBoxPolyKey;
                }

                CheckBox checkBoxHighLight = new CheckBox();
                checkBoxHighLight.Text = "";
                checkBoxHighLight.Location = new Point(10, 30 + (c - 'A') * 20);
                checkBoxHighLight.Width = 30;
                checkBoxHighLight.Height = 15;
                checkBoxHighLight.Visible = true;
                checkBoxHighLight.Parent = panelPolyKey;
            //    checkBoxHighLight.CheckedChanged += new EventHandler(highlightChanged);
                highLightCheckBox[c - 'A'] = checkBoxHighLight;

                TextBox textBoxSimple = new TextBox();
                textBoxSimple.Location = new Point(15, 5 + (c - 'A') * 20 + 5);
                textBoxSimple.Width = 200;
                textBoxSimple.Height = 15;
                textBoxSimple.Visible = true;
                textBoxSimple.Parent = tabPagePolyKey;
                textBoxSimple.MaxLength = 26;
                polyKeyBoxesSimple[c - 'A'] = textBoxSimple;
            }
            Logger.log("--------- Program started ---------");
        //    nGramComboBox.SelectedIndexChanged += new EventHandler(onKeyChanged);
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxSource.Text = "";
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StringBuilder sb = new StringBuilder();
                            char c = (char)myStream.ReadByte();
                            do
                            {
                                sb.Append(c);
                                c = (char)myStream.ReadByte();
                            }
                            while (c != 65535);
                            textBoxSource.Text = sb.ToString();
                        }
                        Logger.log("File " + openFileDialog1.FileName + " loaded");

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }
        private void updateDecryptedText()
        {
            textBoxResult.Text = key.ApplyKey(textBoxSource.Text);
        }
        private void updateKeyDisplay(KeyMono key)
        {
            for (int i = 0; i < keyBoxes.Length; i++)
            {
                keyBoxes[i].Text = key.map[i] + "";
            }
            textBoxFullKey.Text = key.map;
            Logger.log("Key updated. New key: " + key);
        }
        private void setKey(KeyMono newKey)
        {
            key = newKey;
            updateDecryptedText();
            updateKeyDisplay(newKey);
        }
        private Key getKey()
        {
            return key;
        }

        private void onKeyChanged(object sender, EventArgs e)
        {
            string keyBuf = "";
            for (int i = 0; i < keyBoxes.Length; i++)
            {
                if (keyBoxes[i].Text.Length != 0)
                    keyBuf += keyBoxes[i].Text;
                else
                    keyBuf += (char)('A' + i);
            }
            key = new KeyMono(keyBuf);
            updateDecryptedText();
        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            //    string newkey = Crypter.findKeyByNgramFrequency((string)textBoxSource.Text.Clone(), nGramComboBox.SelectedIndex);
            KeyFinderMono keyFinder = new KeyFinderMono(nGramComboBox.SelectedIndex + 1);
            setKey((KeyMono) keyFinder.FindKey((string)textBoxSource.Text.Clone()));
        }

        private void textBoxSource_TextChanged(object sender, EventArgs e)
        {
            Dictionary<string, double> realFreq = Util.getRealNGramFrequency(textBoxSource.Text, 1);

            foreach (String symbol in realFreq.Keys)
            {
                double value;
                realFreq.TryGetValue(symbol, out value);
                
                pLabels[symbol[0] - 'A'].Text = (value * 100).ToString("0.0000") + "%";
            }
        }

        private void textBoxResult_TextChanged(object sender, EventArgs e)
        {
            List<KeyValuePair<string, double>> realMonoCountsList = Util.getSortedRealNGramFrequencyList(textBoxResult.Text, 1);
            List<KeyValuePair<string, long>> realBiCountsList = Util.getSortedRealNGramCountList(textBoxResult.Text, 2);
            List<KeyValuePair<string, long>> realTriCountsList = Util.getSortedRealNGramCountList(textBoxResult.Text, 3);
            List<KeyValuePair<string, long>> realQuadCountsList = Util.getSortedRealNGramCountList(textBoxResult.Text, 4);
            
            listViewBi.Items.Clear();
            listViewTri.Items.Clear();
            listViewQuad.Items.Clear();
            foreach (KeyValuePair<string, long> pair in realBiCountsList)
            {
                ListViewItem lvi = new ListViewItem(pair.Key);
                lvi.SubItems.Add(pair.Value.ToString());
                listViewBi.Items.Add(lvi);
            }
            foreach (KeyValuePair<string, long> pair in realTriCountsList)
            {
                ListViewItem lvi = new ListViewItem(pair.Key);
                lvi.SubItems.Add(pair.Value.ToString());
                listViewTri.Items.Add(lvi);
            }
            foreach (KeyValuePair<string, long> pair in realQuadCountsList)
            {
                ListViewItem lvi = new ListViewItem(pair.Key);
                lvi.SubItems.Add(pair.Value.ToString());
                listViewQuad.Items.Add(lvi);
            }

            chartMonoFreq.Series[0].Points.Clear();
            foreach (KeyValuePair<string, double> pair in realMonoCountsList)
            {
                chartMonoFreq.Series[0].Points.AddXY(pair.Key[0] - 'B', pair.Value);
            }
        }

        private void buttonImprove_Click(object sender, EventArgs e)
        {
            int iterCount = Int32.Parse(textBoxIterations.Text);
            KeyImproverAStar keyImprover = new KeyImproverAStar(new KeyRaterCount(3, textBoxSource.Text));
            setKey((KeyMono) keyImprover.ImproveKey(key, iterCount));
        }

        private void buttonLogToFile_Click(object sender, EventArgs e)
        {
            KeyFinderVigenere keyFinder = new KeyFinderVigenere();
            textBoxResult.Text = keyFinder.FindKey(textBoxSource.Text).ApplyKey(textBoxSource.Text);
        }

        private void buttonSetKey_Click(object sender, EventArgs e)
        {
            setKey(new KeyMono(textBoxFullKey.Text));
        }

        private void buttonNGram_Click(object sender, EventArgs e)
        {
            KeyFinderMono keyFinderMono = new KeyFinderMono(nGramComboBox.SelectedIndex + 1);
            setKey((KeyMono) keyFinderMono.FindKey(textBoxSource.Text));
        }

        private void buttonSetKeySize_Click(object sender, EventArgs e)
        {
            setVigenereData(textBoxSource.Text);
        }

        private void buttonGetKeySize_Click(object sender, EventArgs e)
        {
            textBoxKeySize.Text = "" + PolyKeyLengthFinder.getPolyKeyLength(textBoxSource.Text);
            setVigenereData(textBoxSource.Text);
        }

        private void setVigenereData(string data)
        {
            List<KeyValuePair<string, double>>[] freqListArr = Util.getDataAnalysis(textBoxSource.Text, Int32.Parse(textBoxKeySize.Text));
            listBoxRowsData.Items.Clear();
            for (int i = 0; i < freqListArr.Length; i++)
            {
                string text = "";
                for (int j = 0; j < freqListArr[i].Count; j++)
                {
                    text += freqListArr[i][j].Key + " (" + (char)('A' + (freqListArr[i][j].Key[0] - Util.sortedalphabet[j] + 26) % 26) + ")\t";
                }
                listBoxRowsData.Items.Add(text);
                text = "";
                for (int j = 0; j < freqListArr[i].Count; j++)
                {
                    text += (freqListArr[i][j].Value * 100).ToString("0.00") + "%\t";
                }
                listBoxRowsData.Items.Add(text);
                listBoxRowsData.Items.Add("");
            }
        }

        private void buttonGetVigKey_Click(object sender, EventArgs e)
        {
            KeyFinderVigenere keyFinder = new KeyFinderVigenere();
            KeyVigenere key = (KeyVigenere) keyFinder.FindKey(textBoxSource.Text);
            textBoxResult.Text = key.ApplyKey(textBoxSource.Text);
            textBoxVigKey.Text = key.shifts;
        }

        private void buttonSetVigKey_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = new KeyVigenere(textBoxVigKey.Text).ApplyKey(textBoxSource.Text);
        }

        private void buttonFindPoly_Click(object sender, EventArgs e)
        {
            KeyFinderPoly keyFinder = new KeyFinderPoly(new KeyImproverAStar(new KeyRaterCount(3, textBoxSource.Text)), 300);
            KeyPoly polyKey = (KeyPoly) keyFinder.FindKey(textBoxSource.Text);
            
            updatePolyData(polyKey);
            Logger.log("Text");
            Logger.log(textBoxResult.Text);
            Logger.log("");
        }

        private void buttonSetPolyKey_Click(object sender, EventArgs e)
        {
            string[] polyKey = null;
            if (tabControlPoly.SelectedIndex == 1)
            {
                for (int i = 0; i < polyKeyBoxes.Length; i++)
                {
                    if (polyKeyBoxes[i][0].Text.Length == 0)
                    {
                        polyKey = new string[i];
                        break;
                    }
                }
                for (int i = 0; i < polyKey.Length; i++)
                {
                    StringBuilder sb = new StringBuilder();
                    for (int j = 0; j < polyKeyBoxes[i].Length; j++)
                    {
                        sb = sb.Append(polyKeyBoxes[i][j].Text + "");
                    }
                    polyKey[i] = sb.ToString();
                }
            }
            else
            {
                for (int i = 0; i < polyKeyBoxesSimple.Length; i++)
                {
                    if (polyKeyBoxesSimple[i].Text.Length == 0)
                    {
                        polyKey = new string[i];
                        break;
                    }
                }
                for (int i = 0; i < polyKey.Length; i++)
                {
                    polyKey[i] = polyKeyBoxesSimple[i].Text;
                }
            }
            updatePolyData(new KeyPoly(polyKey));
        }
        private void updatePolyData(KeyPoly polyKey)
        {
            textBoxResult.Text = polyKey.ApplyKey(textBoxSource.Text);
            List<KeyValuePair<string, double>>[] freqsArr = Util.getPolyMonogramFrequencies(textBoxResult.Text, polyKey.maps.Length);

            for (int i = 0; i < freqsArr.Length; i++)
            {
                freqsCharts[i].Series[0].Points.Clear();
                foreach (KeyValuePair<string, double> pair in freqsArr[i])
                {
                    freqsCharts[i].Series[0].Points.AddXY(pair.Key[0] - 'A', pair.Value);
                }
                for (int j = 0; j < freqsCharts[i].Series[0].Points.Count; j++)
                {
                    freqsCharts[i].Series[0].Points[j].AxisLabel = (char)('A' + j) + "";
                }
            }

            for (int row = 0; row < polyKey.maps.Length; row++)
            {
                for (int col = 0; col < polyKey.maps[row].Length; col++)
                {
                    polyKeyBoxes[row][col].Text = polyKey.maps[row][col] + "";
                }
                polyKeyBoxesSimple[row].Text = polyKey.maps[row];
            }
        }
        private void highlightChanged(object sender, EventArgs e)
        {
            string text = textBoxResult.Text;

            int period = 1;
            for (int i = 0; i < polyKeyBoxes.Length; i++)
            {
                if (polyKeyBoxes[i][0].Text.Length == 0)
                {
                    period = i;
                    break;
                }
            }

            textBoxResult.Clear();

            for (int i = 0; i < text.Length; i++)
            {
                if (highLightCheckBox[i % period].Checked)
                {
                    AppendText(textBoxResult, text[i] + "", Color.Red);
                }
                else
                {
                    textBoxResult.AppendText(text[i] + "");
                }
            }
        }
        private static void AppendText(RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        private void buttonPolyImprove_Click(object sender, EventArgs e)
        {
            int iterCount = Int32.Parse(textBoxIterations.Text);
            string[] polyKey = null;
            for (int i = 0; i < polyKeyBoxesSimple.Length; i++)
            {
                if (polyKeyBoxesSimple[i].Text.Length == 0)
                {
                    polyKey = new string[i];
                    break;
                }
            }
            for (int i = 0; i < polyKey.Length; i++)
            {
                polyKey[i] = polyKeyBoxesSimple[i].Text;
            }
            KeyImproverAStar keyImprover = new KeyImproverAStar(new KeyRaterXi2(nGramComboBox.SelectedIndex + 1, textBoxSource.Text));
            KeyPoly newpolykey = (KeyPoly) keyImprover.ImproveKey(new KeyPoly(polyKey), iterCount);
            Logger.log("Found poly key");

            updatePolyData(newpolykey);
            Logger.log("Text");
            Logger.log(textBoxResult.Text);
            Logger.log("");
        }
    }
}

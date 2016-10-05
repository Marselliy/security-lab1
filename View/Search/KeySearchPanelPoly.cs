using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using security_lab1_csharp.Core.KeyFinders;
using security_lab1_csharp.Core.KeyImpovers;
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.Core.Raters;

namespace security_lab1_csharp.View.Search
{
    public partial class KeySearchPanelPoly : KeySearchPanel
    {
        private TextBox[][] polyKeyBoxes;
        private CheckBox[] highLightCheckBox;
        private TextBox[] polyKeyBoxesSimple;
        private KeyPoly tempKey;

        public KeySearchPanelPoly()
        {
            InitializeComponent();
            KeyTypeName = "Poly";
            polyKeyBoxes = new TextBox[Util.alphabet.Length][];
            highLightCheckBox = new CheckBox[Util.alphabet.Length];
            polyKeyBoxesSimple = new TextBox[Util.alphabet.Length];
            for (var c = 'A'; c <= 'Z'; c++)
            {
                var labelPolyRow = new Label();
                labelPolyRow.Text = "" + (c - Util.alphabet[0]);
                labelPolyRow.Location = new Point(40, 30 + (c - Util.alphabet[0]) * 20);
                labelPolyRow.Width = 25;
                labelPolyRow.Height = 15;
                labelPolyRow.Visible = true;
                labelPolyRow.Parent = panelPolyKey;

                var labelPolyColumn = new Label();
                labelPolyColumn.Text = "" + c;
                labelPolyColumn.Location = new Point(65 + (c - Util.alphabet[0]) * 20, 10);
                labelPolyColumn.Width = 15;
                labelPolyColumn.Height = 15;
                labelPolyColumn.Visible = true;
                labelPolyColumn.Parent = panelPolyKey;

                polyKeyBoxes[c - Util.alphabet[0]] = new TextBox[Util.alphabet.Length];
                for (var i = 0; i < Util.alphabet.Length; i++)
                {
                    var textBoxPolyKey = new TextBox();
                    textBoxPolyKey.Location = new Point(i * 20 + 65, 30 + (c - Util.alphabet[0]) * 20);
                    textBoxPolyKey.Width = 20;
                    textBoxPolyKey.Height = 15;
                    textBoxPolyKey.Visible = true;
                    textBoxPolyKey.Parent = panelPolyKey;
                    textBoxPolyKey.MaxLength = 1;
                    polyKeyBoxes[c - Util.alphabet[0]][i] = textBoxPolyKey;
                }

                var checkBoxHighLight = new CheckBox();
                checkBoxHighLight.Text = "";
                checkBoxHighLight.Location = new Point(10, 30 + (c - Util.alphabet[0]) * 20);
                checkBoxHighLight.Width = 30;
                checkBoxHighLight.Height = 15;
                checkBoxHighLight.Visible = true;
                checkBoxHighLight.Parent = panelPolyKey;
                highLightCheckBox[c - Util.alphabet[0]] = checkBoxHighLight;

                var textBoxSimple = new TextBox();
                textBoxSimple.Location = new Point(15, 5 + (c - Util.alphabet[0]) * 20 + 5);
                textBoxSimple.Width = 200;
                textBoxSimple.Height = 15;
                textBoxSimple.Visible = true;
                textBoxSimple.Parent = tabPagePolyKey;
                textBoxSimple.MaxLength = 26;
                polyKeyBoxesSimple[c - Util.alphabet[0]] = textBoxSimple;
            }
        }

        private void buttonFindPoly_Click(object sender, EventArgs e)
        {
            var keyFinder = new KeyFinderPoly(null, 0);
            tempKey = (KeyPoly)keyFinder.FindKey(plainText);
            for (var i = 0; i < tempKey.maps.Length; i++)
            {
                polyKeyBoxesSimple[i].Text = tempKey.maps[i];
                for (int j = 0; j < tempKey.maps[i].Length; j++)
                {
                    polyKeyBoxes[i][j].Text = tempKey.maps[i][j] + "";
                }
            }
            SetLastKey(tempKey);
        }

        private void buttonSetPolyKey_Click(object sender, EventArgs e)
        {
            string[] polyKey = null;
            if (tabControlPoly.SelectedIndex == 0)
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
            SetLastKey(new KeyPoly(polyKey));
        }

        public override void SetKey(Key key)
        {
            if (key is KeyPoly)
            {
                for (var i = 0; i < ((KeyPoly)key).maps.Length; i++)
                {
                    polyKeyBoxesSimple[i].Text = ((KeyPoly)key).maps[i];
                    for (int j = 0; j < ((KeyPoly)key).maps[i].Length; j++)
                    {
                        polyKeyBoxes[i][j].Text = ((KeyPoly)key).maps[i][j] + "";
                    }
                }
            }
        }
    }
}

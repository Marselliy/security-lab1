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
using security_lab1_csharp.Core.Keys;
using security_lab1_csharp.Core.LengthFinders;

namespace security_lab1_csharp.View.Search
{
    public partial class KeySearchPanelVigenere : KeySearchPanel
    {
        public KeySearchPanelVigenere()
        {
            InitializeComponent();
            KeyTypeName = "Vigenere";
        }

        private void buttonFindKey_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonGetKeySize_Click(object sender, EventArgs e)
        {
            textBoxKeySize.Text = "" + PolyKeyLengthFinder.getPolyKeyLength(plainText);
        }

        private void buttonGetVigKey_Click(object sender, EventArgs e)
        {
            var keyFinder = new KeyFinderVigenere();
            var key = (KeyVigenere)keyFinder.FindKey(plainText);
            textBoxVigKey.Text = key.shifts;
            SetLastKey(new KeyVigenere(textBoxVigKey.Text));
        }

        private void buttonSetVigKey_Click(object sender, EventArgs e)
        {
            SetLastKey(new KeyVigenere(textBoxVigKey.Text));
        }

        public override void SetKey(Key key)
        {
            if (key is KeyVigenere)
            {
                textBoxVigKey.Text = ((KeyVigenere) key).shifts;
            }
        }
    }
}

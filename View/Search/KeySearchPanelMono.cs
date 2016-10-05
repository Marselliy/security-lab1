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

namespace security_lab1_csharp.View.Search
{
    public partial class KeySearchPanelMono : KeySearchPanel
    {
        public KeySearchPanelMono()
        {
            InitializeComponent();
            nGramComboBox.SelectedIndex = 0;
            KeyTypeName = "Mono";
        }

        private void buttonFindKey_Click(object sender, EventArgs e)
        {
            var keyFinderMono = new KeyFinderMono(nGramComboBox.SelectedIndex + 1);
            var key = (KeyMono)keyFinderMono.FindKey(plainText);
            textBoxMonoKey.Text = key.map;
            SetLastKey(key);
        }

        private void buttonSetKey_Click(object sender, EventArgs e)
        {
            var key = new KeyMono(textBoxMonoKey.Text);
            SetLastKey(key);
        }

        public override void SetKey(Key key)
        {
            if (key is KeyMono)
            {
                textBoxMonoKey.Text = ((KeyMono)key).map;
            }
        }
    }
}

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
using security_lab1_csharp.Core.Raters;

namespace security_lab1_csharp.View.Improvement.ImproverPanels
{
    public partial class KeyImproverPanelGenetics : KeyImproverPanel
    {
        public KeyImproverPanelGenetics()
        {
            InitializeComponent();
            methodName = "Genetics";
            selector.Text = methodName;
        }

        public override KeyImprover GeImprover()
        {
            return new KeyImproverGenetics();
        }

        public override KeyImprover GeImprover(KeyRater rater)
        {
            KeyImproverGenetics improver = new KeyImproverGenetics();
            improver.SetMainKeyRater(rater);
            improver.SetMutationRate(((double)trackBarMutRater.Value) / trackBarMutRater.Maximum);
            improver.SetPopulationSize(int.Parse(textBoxPopSize.Text));
            improver.SetKeyRatersInitial(rater);
            return improver;
        }
    }
}

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
    public partial class KeyImproverPanelAStar : KeyImproverPanel
    {
        public KeyImproverPanelAStar()
        {
            InitializeComponent();
            methodName = "A*";
            selector.Text = methodName;
        }

        public override KeyImprover GeImprover()
        {
            return new KeyImproverAStar();
        }

        public override KeyImprover GeImprover(KeyRater rater)
        {
            return new KeyImproverAStar(rater);
        }
    }
}

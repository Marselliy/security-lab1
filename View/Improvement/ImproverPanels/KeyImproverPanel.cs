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
    public abstract partial class KeyImproverPanel : UserControl
    {
        protected string methodName;
        protected CheckBox selector;
        public KeyImproverPanel()
        {
            InitializeComponent();
            selector = new CheckBox
            {
                Location = new Point(5, 0),
                Parent = this
            };
        }

        public string GetMethodName()
        {
            return methodName;
        }

        public abstract KeyImprover GeImprover();
        public abstract KeyImprover GeImprover(KeyRater rater);

        public bool Selected()
        {
            return selector.Checked;
        }
    }
}

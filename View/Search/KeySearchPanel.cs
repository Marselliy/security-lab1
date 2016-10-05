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

namespace security_lab1_csharp.View.Search
{
    public abstract class KeySearchPanel : UserControl
    {
        protected string plainText;
        protected string KeyTypeName;

        public string GetKeyTypeName()
        {
            return KeyTypeName;
        }

        public void SetPlainText(string plainText)
        {
            this.plainText = plainText;
        }

        public void SetLastKey(Key key)
        {
            var parentForm = this.FindForm();
            if (parentForm is MainFormNew)
            {
                ((MainFormNew)parentForm).SetKey(key);
            }
        }

        public abstract void SetKey(Key key);
    }
}

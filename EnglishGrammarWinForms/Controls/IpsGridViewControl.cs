using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Telerik.WinControls.UI;

namespace EnglishGrammarWinForms.Controls
{
    public partial class IpsGridViewControl : UserControl
    {
        public IpsGridViewControl()
        {
            InitializeComponent();
        }

        [Category("GridView")]
        [Browsable(true)]
        public RadGridView GridView => gridView;
    }
}

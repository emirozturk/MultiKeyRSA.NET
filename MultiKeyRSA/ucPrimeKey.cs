using System.Windows.Forms;

namespace MultiKeyRSS
{
    public partial class ucPrimeKey : UserControl
    {
        public ucPrimeKey(string key)
        {
            InitializeComponent();
            lblKey.Text = key;
        }
        public string getValue()
        {
            return tbValue.Text;
        }
    }
}

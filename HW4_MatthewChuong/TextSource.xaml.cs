using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace HW4_MatthewChuong
{
    /// <summary>
    /// Interaction logic for TextSource.xaml
    /// </summary>
    public partial class TextSource : UserControl
    {

        //1 define a delegate
        //2 define a event based on that delegate
        //3 raise the event

        public event EventHandler<String> Submit;

        public TextSource()
        {
            InitializeComponent();
        }
        
        public void ClickedSubmitButton(object sender, RoutedEventArgs e)
        {
            OnClick(EditTxtSource.Text);
        }

        protected virtual void OnClick(String s)
        {
            Submit?.Invoke(this, s);
        }
    }
}

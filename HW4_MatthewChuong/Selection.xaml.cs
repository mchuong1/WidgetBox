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
    /// Interaction logic for Selection.xaml
    /// </summary>
    public partial class Selection : UserControl
    {
        //1 define a delegate
        //2 define a event based on that delegate
        //3 raise the event

        public Selection()
        {
            InitializeComponent();
        }

        public event EventHandler<String> Submit;

        public void ClickedButton(object sender, RoutedEventArgs e)
        {
            String log;
            if(rFrog.IsChecked == true)
            {
                 log = rFrog.Content.ToString();
                OnClick(log);
            }
            else if(rHole.IsChecked == true)
            {
                log = rHole.Content.ToString();
                OnClick(log);
            }
            else if(rLog.IsChecked == true)
            {
                log = rLog.Content.ToString();
                OnClick(log);
            }
            else if(rSea.IsChecked == true)
            {
                log = rSea.Content.ToString();
                OnClick(log);
            }
            else
            {
                Console.WriteLine("No radio button was selected");
            }
            
        }

        protected virtual void OnClick(String s)
        {
            Submit?.Invoke(this, s);
        }
    }
}

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
    /// Interaction logic for Pointer.xaml
    /// </summary>
    public partial class Pointer : UserControl
    {
        public Pointer()
        {
            InitializeComponent();
        }

        public event EventHandler<String> Submit;

        private void PointSubmit(object sender, RoutedEventArgs e)
        {
            String pointerlog = "x= "+ xSlider.Value.ToString() + " y= " + ySlider.Value.ToString() + " z= " + zSlider.Value.ToString();
            OnClick(pointerlog);
        }

        protected virtual void OnClick(String s)
        {
            Submit?.Invoke(this, s);
        }
    }
}

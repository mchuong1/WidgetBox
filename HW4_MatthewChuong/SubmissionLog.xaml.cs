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
    /// Interaction logic for SubmissionLog.xaml
    /// </summary>
    public partial class SubmissionLog : UserControl
    {
       
        public SubmissionLog()
        {
            InitializeComponent();
        }

        public void OnSubmitClick(object source, String s)
        {
            SubmissionLogText.Text += s + "\n";
        }

        public void LogSubmission(String s)
        {
            SubmissionLogText.Text += s + "\n";
        }
    }
}

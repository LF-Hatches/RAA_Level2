
using Autodesk.Revit.DB.Electrical;
using Microsoft.Win32;
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


namespace RAA_Level2
{
    /// <summary>
    /// Interaction logic for Window.xaml
    /// </summary>
    public partial class MyForm : Window
    {
        public MyForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Multiselect = false;
            //openFile.InitialDirectory = @"C:\";
            openFile.RestoreDirectory = true;
            openFile.Filter = "csv file (*.csv)|*.csv";

            if (openFile.ShowDialog() == true)
            {
                tbxFile.Text = openFile.FileName;
            }
            else
            {
                tbxFile.Text = "";
            }
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
            this.Close();
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
            this.Close();
        }
        public string GetTextBoxValue()
        {
            return tbxFile.Text;
        }
        public bool GetCheckbox1()
        {
            if (chbCheck1.IsChecked == true)
                return true;
            else
                return false;
        }
        public bool GetCheckbox2()
        {
            if (chbCheck2.IsChecked == true)
                return true;
            else
                return false;
        }
        public string GetGroup1()
        {
            if (rbImperial.IsChecked == true)
                return rbImperial.Content.ToString();
            else if (rbMetric.IsChecked == true)
                return rbMetric.Content.ToString();
            else
                return "";
        }

    }
}

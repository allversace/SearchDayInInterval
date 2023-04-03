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

namespace WpfApp9
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(selectedDayPicker.SelectedDate.HasValue && startPicker.SelectedDate.HasValue && endPicker.SelectedDate.HasValue)
            {
                DayOfWeek selecteDate = selectedDayPicker.SelectedDate.Value.DayOfWeek;
                DateTime dateTimeStart = startPicker.SelectedDate.Value;
                DateTime dateTimeEnd = endPicker.SelectedDate.Value;

                int count = Enumerable.Range(0, (dateTimeEnd - dateTimeStart).Days).Select(i => dateTimeStart.AddDays(i)).Count(d => d.DayOfWeek == selecteDate);
                result.Text = count.ToString();
            }
            else
            {
                MessageBox.Show("Параметры не выбраны");
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}

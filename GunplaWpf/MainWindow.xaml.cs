using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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

namespace GunplaWpf {
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window {
        GunplaRepository db = new GunplaRepository();

        public MainWindow() {
            InitializeComponent();
        }

        private void OnConnect(object sender, RoutedEventArgs e) {
            string error = db.Connect();
            if (error != null)
                MessageBox.Show(error);
            //else
            //    MessageBox.Show("MySQL 접속 성공");

            grid.DataContext = db.Mechanic();
        }

        private void OnAdd(object sender, RoutedEventArgs e) {
            MechanicWin m = new MechanicWin();
            if (m.ShowDialog() == false)
                return;

            db.Insert(m.NameMechanic, m.Model, m.Manufacturer, m.Armor, m.HeightMechanic, m.Weight);
        }
    }
}

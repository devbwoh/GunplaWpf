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
using System.Windows.Shapes;

namespace GunplaWpf {
    /// <summary>
    /// MechanicWin.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MechanicWin : Window {

        public string NameMechanic {
            get { return name.Text; }
        }

        public string Model {
            get { return model.Text; }
        }

        public string Manufacturer {
            get { return manufacturer.Text; }
        }

        public string Armor {
            get { return armor.Text; }
        }

        public double HeightMechanic {
            get {
                double h = 0.0;
                double.TryParse(height.Text, out h);
                return h; 
            }
        }

        public double Weight {
            get {
                double w = 0.0;
                double.TryParse(weight.Text, out w);
                return w;
            }
        }

        public MechanicWin() {
            InitializeComponent();
        }

        private void OnInsert(object sender, RoutedEventArgs e) {
            if (name.Text.Length == 0) {
                MessageBox.Show("Name을 입력해 주세요.");
                name.Focus();
                return;
            }

            if (model.Text.Length == 0) {
                MessageBox.Show("Model을 입력해 주세요.");
                model.Focus();
                return;
            }

            if (height.Text.Length == 0) {
                MessageBox.Show("Height를 입력해 주세요.");
                height.Focus();
                return;
            }

            double h = 0.0f;
            if (double.TryParse(height.Text, out h) == false) {
                MessageBox.Show("Height를 double 타입으로 입력해 주세요.");
                height.Focus();
                return;
            }

            if (weight.Text.Length == 0) {
                MessageBox.Show("Weight를 입력해 주세요.");
                weight.Focus();
                return;
            }

            double w = 0.0f;
            if (double.TryParse(weight.Text, out w) == false) {
                MessageBox.Show("Weight를 double 타입으로 입력해 주세요.");
                weight.Focus();
                return;
            }

            DialogResult = true;
        }

        private void OnCancel(object sender, RoutedEventArgs e) {
            DialogResult = false;
        }
    }
}

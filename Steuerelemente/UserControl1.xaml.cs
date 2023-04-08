using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Steuerelemente
{
    /// <summary>
    /// Interaktionslogik für UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl, INotifyPropertyChanged
    {
        public UserControl1()
        {
            InitializeComponent();
            DataContext = this;
        }


        private static CornerRadius _defaultCornerRadius = new CornerRadius(25.0);
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register(nameof(CornerRadius), typeof(CornerRadius), typeof(UserControl1), new PropertyMetadata(_defaultCornerRadius));




        private static Brush _onColor = Brushes.Green;
        public Brush OnColor
        {
            get { return (Brush)GetValue(OnColorProperty); }
            set { SetValue(OnColorProperty, value); PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OnColor")); }
        }

        // Using a DependencyProperty as the backing store for OnColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OnColorProperty =
            DependencyProperty.Register(nameof(OnColor), typeof(Brush), typeof(UserControl1), new PropertyMetadata(_onColor));

        private static Brush _offColor = Brushes.Red;
        public Brush OffColor
        {
            get => (Brush)GetValue(OffColorProperty);
            set { SetValue(OffColorProperty, value); PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OffColor")); }
        }

        // Using a DependencyProperty as the backing store for OnColor.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty OffColorProperty =
            DependencyProperty.Register(nameof(OffColor), typeof(Brush), typeof(UserControl1), new PropertyMetadata(_offColor));




        private static Thickness _defaultThickness = new Thickness(1);
        public Thickness myBorderThickness
        {
            get { return (Thickness)GetValue(myBorderThicknessProperty); }
            set { SetValue(myBorderThicknessProperty, value); PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("myBorderThickness")); }
        }

        // Using a DependencyProperty as the backing store for BorderThickness.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty myBorderThicknessProperty =
            DependencyProperty.Register(nameof(myBorderThickness), typeof(Thickness), typeof(UserControl1), new PropertyMetadata(_defaultThickness));



        public event PropertyChangedEventHandler PropertyChanged;
    }
}

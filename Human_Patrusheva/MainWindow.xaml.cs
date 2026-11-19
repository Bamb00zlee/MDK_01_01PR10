using System.Windows;
using System.Windows.Media;

namespace Human_Patrusheva
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static MediaPlayer MediaPlayer = new MediaPlayer();

        private Classes.Russian Russian = new Classes.Russian("Александр", @"C:\\Users\\Хонор\\Desktop\\Human_Patrusheva\\Human_Patrusheva\\Images\\ic_russian.png");
        private Classes.English English = new Classes.English("Aleksandr", @"C:\Users\Хонор\Desktop\Human_Patrusheva\Human_Patrusheva\Images\ic_english.png");

        public MainWindow()
        {
            InitializeComponent();
            Parent.Children.Add(new Elements.Item(Russian));
            Parent.Children.Add(new Elements.Item(English));
        }
    }
}

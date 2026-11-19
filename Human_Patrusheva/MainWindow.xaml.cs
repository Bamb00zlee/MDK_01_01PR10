using Human_Patrusheva.Elements;
using System;
using System.Threading.Tasks;
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

        private Elements.Item RussianItem;
        private Elements.Item EnglishItem;

        private bool _isDialogStarted = false; // Флаг, чтобы не запускать диалог дважды
        public MainWindow()
        {
            InitializeComponent();

            RussianItem = new Elements.Item(Russian);
            EnglishItem = new Elements.Item(English);

            Parent.Children.Add(RussianItem);
            Parent.Children.Add(EnglishItem);

            // Подписываемся на окончание песни (диалог будет переключаться тут)
            MediaPlayer.MediaEnded += MediaPlayer_MediaEnded;
        }

        private void For_dilog(object sender, RoutedEventArgs e)
        {
            if (_isDialogStarted) return;
            _isDialogStarted = true;
            RussianItem.SpeakItem();
        }

        private void MediaPlayer_MediaEnded(object sender, EventArgs e)
        {
            if (_isDialogStarted)
            {
                _isDialogStarted = false;
                EnglishItem.SpeakItem();
            }
        }
    }
}

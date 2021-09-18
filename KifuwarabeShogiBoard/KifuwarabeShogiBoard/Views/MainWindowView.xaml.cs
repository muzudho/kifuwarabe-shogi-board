namespace KifuwarabeShogiBoard.Views
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindowView.xaml
    /// </summary>
    public partial class MainWindowView : Window
    {
        public MainWindowView()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // ウィンドウを閉じます
            this.Close();
        }

        private void WindowMoveHandle_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }

        private void Rectangle_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {

        }
    }
}

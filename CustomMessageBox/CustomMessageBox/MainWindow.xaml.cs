using System.Windows;

namespace CustomMessageBox
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            var msgResult = MsgBox.Show("Heading", "Message content to show\nNew line1\n\nNew line2 with two enters", MessageImage.Information, MessageButtons.YesNoCancel);
            switch (msgResult)
            {
                case MsgBoxResult.Ok:
                    lbl1.Content = "OK";
                    break;
                case MsgBoxResult.Yes:
                    lbl1.Content = "YES";
                    break;
                case MsgBoxResult.No:
                    lbl1.Content = "NO";
                    break;
                case MsgBoxResult.Cancel:
                    lbl1.Content = "CANCEL";
                    break;
                default:
                    lbl1.Content = "NOTHING";
                    break;
            }

            MsgBox.Show("Text only");
            MsgBox.Show("Text and text again", "Text");
            MsgBox.Show("Text and buttons", MessageButtons.YesNoCancel);
            MsgBox.Show("Text with image", MessageImage.Warning);
        }
    }
}
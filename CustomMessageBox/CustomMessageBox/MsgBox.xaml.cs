using System;
using System.Windows;
using System.Windows.Media.Imaging;

namespace CustomMessageBox
{
    /// <summary>
    /// Enum for choosing button type shown in message box
    /// </summary>
    public enum MessageButtons
    {
        Ok = 0,
        YesNo,
        YesNoCancel
    }

    /// <summary>
    /// Enum for choosing message box image
    /// </summary>
    public enum MessageImage
    {
        Information = 0,
        Question,
        Warning,
        Error,
        Check,
        None
    }

    /// <summary>
    /// Enum for setting and retrieving resul Ok, Yes, No or Cancel
    /// </summary>
    public enum MsgBoxResult
    {
        Ok = 0,
        Yes,
        No,
        Cancel
    }

    public partial class MsgBox : Window
    {
        static MsgBox msgBox;
        static MsgBoxResult result = MsgBoxResult.No;

        public MsgBox()
        {
            InitializeComponent();
        }

        //Helper private method for setting image in MsgBox depend on MessageImage enum
        private static void SetImage(MessageImage image)
        {
            switch (image)
            {
                case MessageImage.Information:
                    msgBox.FillImage("Info.png");
                    break;
                case MessageImage.Question:
                    msgBox.FillImage("Question.png");
                    break;
                case MessageImage.Warning:
                    msgBox.FillImage("Warning.png");
                    break;
                case MessageImage.Error:
                    msgBox.FillImage("Error.png");
                    break;
                case MessageImage.Check:
                    msgBox.FillImage("Check.png");
                    break;
                case MessageImage.None:
                    msgBox.FillImage("Info.png");
                    break;
                default:
                    msgBox.Img_MsgBox.Visibility = Visibility.Collapsed;
                    break;
            }
        }

        //Creating BitmapImage from Uri and set as image source
        private void FillImage(string imageName)
        {
            Img_MsgBox.Source = new BitmapImage(new Uri($@"Images/{imageName}", UriKind.RelativeOrAbsolute));
        }

        //Show or collapse buttons depend on MessageButtons enum
        private static void SetButtons(MessageButtons buttons)
        {
            switch (buttons)
            {
                case MessageButtons.Ok:
                    msgBox.Btn_Yes.Visibility = Visibility.Collapsed;
                    msgBox.Btn_No.Visibility = Visibility.Collapsed;
                    msgBox.Btn_Cancel.Visibility = Visibility.Collapsed;
                    msgBox.Btn_Ok.Focus();
                    break;
                case MessageButtons.YesNo:
                    msgBox.Btn_Ok.Visibility = Visibility.Collapsed;
                    msgBox.Btn_Cancel.Visibility = Visibility.Collapsed;
                    msgBox.Btn_No.Focus();
                    break;
                case MessageButtons.YesNoCancel:
                    msgBox.Btn_Ok.Visibility = Visibility.Collapsed;
                    msgBox.Btn_Cancel.Focus();
                    break;
                default:
                    break;
            }
        }

        //First variant of static method Show
        public static MsgBoxResult Show(string caption, string msgContent, MessageImage image, MessageButtons buttons)
        {
            //First set static var of MsgBox with new object and set fields based on inputs
            msgBox = new MsgBox
            {
                Txt_Content = { Text = msgContent },
                Txt_Caption = { Text = caption }
            };
            SetButtons(buttons);
            SetImage(image);
            //Showing MsgBox as a dialog
            msgBox.ShowDialog();
            return result;
        }

        //Second variant
        public static MsgBoxResult Show(string caption, string msgContent, MessageImage image)
        {
            msgBox = new MsgBox
            {
                Txt_Content = { Text = msgContent },
                Txt_Caption = { Text = caption }
            };
            SetButtons(MessageButtons.Ok);
            SetImage(image);
            msgBox.ShowDialog();
            return result;
        }

        //Third variant
        public static MsgBoxResult Show(string caption, string msgContent, MessageButtons buttons)
        {
            msgBox = new MsgBox
            {
                Txt_Content = { Text = msgContent },
                Txt_Caption = { Text = caption }
            };
            SetButtons(buttons);
            msgBox.Img_MsgBox.Visibility = Visibility.Collapsed;
            msgBox.ShowDialog();
            return result;
        }

        //Fourth variant
        public static MsgBoxResult Show(string msgContent, MessageImage image, MessageButtons buttons)
        {
            msgBox = new MsgBox
            {
                Txt_Content = { Text = msgContent },
                Txt_Caption = { Visibility = Visibility.Collapsed }
            };
            SetButtons(buttons);
            SetImage(image);
            msgBox.ShowDialog();
            return result;
        }

        //Fifth variant
        public static MsgBoxResult Show(string msgContent, MessageImage image)
        {
            msgBox = new MsgBox
            {
                Txt_Content = { Text = msgContent },
                Txt_Caption = { Visibility = Visibility.Collapsed }
            };
            SetButtons(MessageButtons.Ok);
            SetImage(image);
            msgBox.ShowDialog();
            return result;
        }

        //Sixth variant
        public static MsgBoxResult Show(string msgContent, MessageButtons buttons)
        {
            msgBox = new MsgBox
            {
                Txt_Content = { Text = msgContent },
                Txt_Caption = { Visibility = Visibility.Collapsed }
            };
            SetButtons(buttons);
            msgBox.Img_MsgBox.Visibility = Visibility.Collapsed;
            msgBox.ShowDialog();
            return result;
        }

        //Seventh variant
        public static MsgBoxResult Show(string caption, string msgContent)
        {
            msgBox = new MsgBox
            {
                Txt_Content = { Text = msgContent },
                Txt_Caption = { Text = caption }
            };
            SetButtons(MessageButtons.Ok);
            msgBox.Img_MsgBox.Visibility = Visibility.Collapsed;
            msgBox.ShowDialog();
            return result;
        }

        //Eighth variant
        public static MsgBoxResult Show(string msgContent)
        {
            msgBox = new MsgBox
            {
                Txt_Content = { Text = msgContent },
                Txt_Caption = { Visibility = Visibility.Collapsed }
            };
            SetButtons(MessageButtons.Ok);
            msgBox.Img_MsgBox.Visibility = Visibility.Collapsed;
            msgBox.ShowDialog();
            return result;
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            //Checking from sender which button is clicked and set static variable for MsgBoxResult
            if (sender == Btn_Ok) result = MsgBoxResult.Ok;
            else if (sender == Btn_Yes) result = MsgBoxResult.Yes;
            else if (sender == Btn_No) result = MsgBoxResult.No;
            else result = MsgBoxResult.Cancel;
            msgBox.Close();
            msgBox = null;
        }
    }
}

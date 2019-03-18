using System;
using System.Windows;
using System.Windows.Controls;

namespace WPF_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ApplyBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ResetBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            string checkBoxContent = ((CheckBox) sender).Content.ToString();
            // Adds checkbox content to the textbox text
            LengthTextBox.Text += checkBoxContent;
        }

        private void CheckBox_UnChecked(object sender, RoutedEventArgs e)
        {
            // Removes the CheckBoxText from the LengthTextBox
            string text = LengthTextBox.Text;

            string checkBoxText = ((CheckBox)sender).Content.ToString();
            int wordStartIndex = text.IndexOf(checkBoxText, StringComparison.Ordinal);
            int wordLength = checkBoxText.Length;

            string newText = text.Remove(wordStartIndex, wordLength);
            LengthTextBox.Text = newText;
        }
    }
}

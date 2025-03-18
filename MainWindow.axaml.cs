using System.Linq;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace Ankieta;

public partial class MainWindow : Window
{
    string UserName;
    string Interest;
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private void SubmitButton_Click(object? sender, RoutedEventArgs e)
    {
        if (TextBoxName.Text != null) UserName = TextBoxName.Text;
        if (ComboBoxInterest.SelectionBoxItem != null) Interest = ComboBoxInterest.SelectionBoxItem.ToString();
    }
    
    private void ShowButton_Click(object? sender, RoutedEventArgs e)
    {
        CheckBox[] CheckBoxes = {CheckBox1, CheckBox2, CheckBox3}; 
        int numOfYes = CheckBoxes.Count(checkbox => checkbox.IsChecked == true);
        TextBlockShow.Text = $"{UserName}, zainteresowanie: {Interest}, liczba odpowiedzi na tak: {numOfYes}";
    }
}
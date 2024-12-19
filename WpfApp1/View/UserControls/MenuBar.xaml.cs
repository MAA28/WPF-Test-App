using System.Windows.Controls;

namespace WpfApp1.View.UserControls;

public partial class MenuBar : UserControl
{
    public MenuBar()
    {
        InitializeComponent();
    }

    private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
    {
        Console.Out.WriteLine("TextBoxBase_OnTextChanged()");
        Console.Out.WriteLine(tbInput.Text);
        tbOutput.Text = tbInput.Text;
    }
}
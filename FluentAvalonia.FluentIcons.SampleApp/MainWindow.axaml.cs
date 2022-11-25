using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace FluentAvalonia.FluentIcons.SampleApp
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
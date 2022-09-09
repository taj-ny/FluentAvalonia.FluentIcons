using Avalonia;
using FluentAvalonia.FluentIcons.Helpers;
using FluentAvalonia.UI.Controls;

namespace FluentAvalonia.FluentIcons;

public class FluentIcon : FAPathIcon
{
    public static readonly StyledProperty<FluentIconSymbol> IconProperty =
        AvaloniaProperty.Register<FluentIcon, FluentIconSymbol>(nameof(Icon));

    public FluentIconSymbol Icon
    {
        get => GetValue(IconProperty);
        set => SetValue(IconProperty, value);
    }

    protected override void OnPropertyChanged(AvaloniaPropertyChangedEventArgs change)
    {
        base.OnPropertyChanged(change);

        if (change.Property == IconProperty)
        {
            Data = IconHelper.GetPathGeometryFromIcon(Icon);
        }
    }
}
using Avalonia;
using Avalonia.Media;
using FluentAvalonia.FluentIcons.Helpers;
using FluentAvalonia.UI.Controls;

namespace FluentAvalonia.FluentIcons;

public class FluentIconSource : PathIconSource
{
    public static readonly StyledProperty<FluentIconSymbol> IconProperty =
        AvaloniaProperty.Register<FluentIconSource, FluentIconSymbol>(nameof(Icon));

    static FluentIconSource()
    {
        // Required for TabViewItem
        StretchProperty.OverrideDefaultValue<FluentIconSource>(Stretch.Fill);
    }

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
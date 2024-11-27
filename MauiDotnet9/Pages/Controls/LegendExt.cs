using Syncfusion.Maui.Toolkit.Charts;

namespace MauiDotnet9.Pages.Controls;

public class LegendExt : ChartLegend
{
    protected override double GetMaximumSizeCoefficient()
    {
        return 0.5;
    }
}

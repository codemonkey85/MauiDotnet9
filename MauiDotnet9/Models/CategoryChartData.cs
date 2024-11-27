namespace MauiDotnet9.Models;

public class CategoryChartData(string title, int count)
{
    public string Title { get; set; } = title;
    public int Count { get; set; } = count;
}

using System.Text.Json.Serialization;

namespace MauiDotnet9.Models;

public class Category
{
    public int ID { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Color { get; set; } = "#FF0000";

    [JsonIgnore]
    public Brush ColorBrush => new SolidColorBrush(Microsoft.Maui.Graphics.Color.FromArgb(Color));

    public override string ToString() => $"{Title}";
}

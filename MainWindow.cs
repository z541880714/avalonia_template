using Avalonia;
using Avalonia.Controls;
using Avalonia.Layout; // 👈 必须加这个！VerticalAlignment 和 HorizontalAlignment 在这里
using Avalonia.Markup.Declarative;
using Avalonia.Media;
using Avalonia.Interactivity;

namespace avalonia_template;

public class MainWindow : Window
{
    public MainWindow()
    {
        Title = "纯 C# 窗口";
        Width = 400;
        Height = 300;

        // 3. 直接构建 UI
        Content = new StackPanel()
            // ❌ 原来的 .Center() 报错，替换为下面两行标准写法：
            .VerticalAlignment(VerticalAlignment.Center) // 垂直居中
            .HorizontalAlignment(HorizontalAlignment.Center) // 水平居中
            .Spacing(20)
            .Children(
                new TextBlock()
                    .Text("XAML 已被删除！")
                    .FontSize(24)
                    // ❌ 原来的 .HCenter() 报错，替换为：
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .Foreground(Brushes.Green),
                new TextBlock()
                    .Text("这是纯粹的 C# 对象树")
                    // ❌ 原来的 .HCenter() 报错，替换为：
                    .HorizontalAlignment(HorizontalAlignment.Center)
            );
    }
}
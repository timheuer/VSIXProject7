using Microsoft.VisualStudio.Imaging;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace VSIXProject7;
public class MyToolWindow : BaseToolWindow<MyToolWindow>
{
    public override string GetTitle(int toolWindowId) => "My Tool Window";

    public override Type PaneType => typeof(Pane);

    public override Task<FrameworkElement> CreateAsync(int toolWindowId, CancellationToken cancellationToken)
    {
        return Task.FromResult<FrameworkElement>(new MyToolWindowControl());
    }

    [Guid("4a8d1fad-b080-4101-b37e-5784d30027b7")]
    internal class Pane : ToolkitToolWindowPane
    {
        public Pane()
        {
            BitmapImageMoniker = KnownMonikers.ToolWindow;
        }
    }
}
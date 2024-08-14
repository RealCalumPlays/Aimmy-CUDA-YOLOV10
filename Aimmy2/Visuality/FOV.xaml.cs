using Aimmy2.Class;
using Class;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Interop;
using System.Windows.Media;
using Application = System.Windows.Application;
using Color = System.Windows.Media.Color;

namespace Visuality
{
    /// <summary>
    /// Interaction logic for FOV.xaml
    /// </summary>
    public partial class FOV : Window
    {
        protected override void OnSourceInitialized(EventArgs e)
        {
            base.OnSourceInitialized(e);
            ClickThroughOverlay.MakeClickThrough(new WindowInteropHelper(this).Handle);
        }

        public FOV()
        {
            InitializeComponent();
            //new WinAPICaller().GetScreenWidth(this);

            Application.Current.Dispatcher.BeginInvoke(() => FOVStrictEnclosure.Margin = new Thickness(
                Convert.ToInt16((WinAPICaller.ScreenWidth / 2) / WinAPICaller.scalingFactorX) - 320,
                Convert.ToInt16((WinAPICaller.ScreenHeight / 2) / WinAPICaller.scalingFactorY) - 320,
                0, 0));

            PropertyChanger.ReceiveColor = UpdateFOVColor;
            PropertyChanger.ReceiveFOVSize = UpdateFOVSize;
        }
        public void MoveToMonitor(Screen selectedMonitor)
        {
            this.Left = selectedMonitor.Bounds.Left;
            this.Top = selectedMonitor.Bounds.Top;
            this.Width = selectedMonitor.Bounds.Width;
            this.Height = selectedMonitor.Bounds.Height;

            this.WindowState = WindowState.Maximized;
            this.Topmost = true;
        }
        private void UpdateFOVColor(Color NewColor) => Circle.Stroke = new SolidColorBrush(NewColor);

        private void UpdateFOVSize(double newdouble)
        {
            Circle.Width = Circle.Height = newdouble;
        }
    }
}
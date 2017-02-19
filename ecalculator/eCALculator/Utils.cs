using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace eCALculator
{
    static class Utils
    {
        public static void Afisare()
        {

            var notification = new System.Windows.Forms.NotifyIcon()
            {
                Visible = true,
                Icon = System.Drawing.SystemIcons.Information,
                BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Warning,
                BalloonTipTitle = "Depasire Calorii ",
                BalloonTipText = "Atentie esti un gras !",
            };

            // Display for 5 seconds.
            notification.ShowBalloonTip(5);

            //Thread.Sleep(10000);

            // The notification should be disposed when you don't need it anymore,
            // but doing so will immediately close the balloon if it's visible.
            notification.Dispose();
        }

        public static void shaorma()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"conf\fatshaming.wav");
            player.Play();
        }

 
[DllImport("user32.dll", CharSet = CharSet.Auto)]
    private static extern Int32 SystemParametersInfo(
    UInt32 action, UInt32 uParam, String vParam, UInt32 winIni);

    private static readonly UInt32 SPI_SETDESKWALLPAPER = 0x14;
    private static readonly UInt32 SPIF_UPDATEINIFILE = 0x01;
    private static readonly UInt32 SPIF_SENDWININICHANGE = 0x02;

    public static void SetWallpaper(string path)
    {
        SystemParametersInfo(SPI_SETDESKWALLPAPER, 0, path,
            SPIF_UPDATEINIFILE | SPIF_SENDWININICHANGE);
    }
}

    
}

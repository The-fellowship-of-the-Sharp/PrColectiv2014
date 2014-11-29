using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GraveyardManagement.CustomControls
{
    public class WatermarkTextBox : TextBox
    {
        private const uint EcmFirst = 0x1500;
        private const uint EmSetcuebanner = EcmFirst + 1;

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = false)]
        static extern IntPtr SendMessage(IntPtr hWnd, uint msg, uint wParam, [MarshalAs(UnmanagedType.LPWStr)] string lParam);

        private string _watermarkText;
        public string WatermarkText
        {
            get { return _watermarkText; }
            set
            {
                _watermarkText = value;
                SetWatermark(_watermarkText);
            }
        }

        private void SetWatermark(string watermarkText)
        {
            SendMessage(Handle, EmSetcuebanner, 0, watermarkText);
        }

    }
}

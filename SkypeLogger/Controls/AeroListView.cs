using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SkypeLogger.Controls
{
    class AeroListView : ListView
    {
        [DllImport("uxtheme", CharSet = CharSet.Unicode)]
        public static extern int SetWindowTheme(IntPtr hWnd, string textSubAppName, string textSubIdList);

        public AeroListView()
        {
            HandleCreated += AeroListView_HandleCreated;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DoubleBuffered = true;
            this.FullRowSelect = true;
            this.MultiSelect = true;
            this.View = System.Windows.Forms.View.Details;
        }

        private void AeroListView_HandleCreated(object sender, System.EventArgs e)
        {
            SetWindowTheme(this.Handle, "explorer", null);
        }
    }
}

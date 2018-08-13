using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AmamaNagigi.ExpCheckerPlugin
{
    public partial class ExpCheckerPluginOverlayConfigPanel : UserControl
    {
        private ExpCheckerPluginOverlay overlay;

        public ExpCheckerPluginOverlayConfigPanel(ExpCheckerPluginOverlay overlay)
        {
            InitializeComponent();

            this.overlay = overlay;
            this.expCheckerPluginOverlayConfigBindingSource.DataSource = this.overlay.Config;
        }

        private void buttonReload_Click(object sender, EventArgs e)
        {
            this.overlay.Overlay.Renderer.Reload();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.overlay.Overlay.Renderer.Browser.GetMainFrame().ExecuteJavaScript("getExp(100)", null, 0);
        }

        private void buttonDevTool_Click(object sender, EventArgs e)
        {
            this.overlay.Overlay.Renderer.showDevTools();
        }
    }
}

using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.ExpCheckerPlugin
{
    public class ExpCheckerPlugin : IOverlayAddon
    {
        public string Name => "ExpChecker";

        public string Description => "Check Exp Gain";

        public Type OverlayType => typeof(ExpCheckerPluginOverlay);

        public Type OverlayConfigType => typeof(ExpCheckerPluginOverlayConfig);

        public Type OverlayConfigControlType => typeof(ExpCheckerPluginOverlayConfigPanel);

        public System.Windows.Forms.Control CreateOverlayConfigControlInstance(IOverlay overlay)
        {
            return new ExpCheckerPluginOverlayConfigPanel((ExpCheckerPluginOverlay)overlay);
        }

        public IOverlayConfig CreateOverlayConfigInstance(string name)
        {
            return new ExpCheckerPluginOverlayConfig(name);
        }

        public IOverlay CreateOverlayInstance(IOverlayConfig config)
        {
            return new ExpCheckerPluginOverlay((ExpCheckerPluginOverlayConfig)config);
        }

        public void Dispose()
        {
         
        }

        public static string ResourceDirectory { get; set; }

        /// <summary>
        /// コンストラクタ
        /// (EnmityPluginよりコピーさせていただきました。)
        /// </summary>
        public ExpCheckerPlugin()
        {
            Assembly asm = Assembly.GetCallingAssembly();
            if (asm.Location == null || asm.Location == "")
            {
                // 場所がわからないなら自分の場所にする
                asm = Assembly.GetExecutingAssembly();
            }
            ResourceDirectory = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(asm.Location), "resources");
        }
    }
}

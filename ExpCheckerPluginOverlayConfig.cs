using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AmamaNagigi.ExpCheckerPlugin
{
    public class ExpCheckerPluginOverlayConfig : OverlayConfigBase
    {
        private ExpCheckerPluginOverlayConfig() : base(null)
        {
            Initialize();
        }

        public ExpCheckerPluginOverlayConfig(string name) : base(name)
        {
            Initialize();
        }

        public override Type OverlayType => typeof(ExpCheckerPluginOverlay);

        /// <summary>
        /// 初期値の設定
        /// </summary>
        private void Initialize()
        {
            Url = GetDefaultUrl();
        }

        /// <summary>
        /// HTMLパスの初期値を取得
        /// </summary>
        /// <returns></returns>
        private string GetDefaultUrl()
        {
            return new Uri(System.IO.Path.Combine(ExpCheckerPlugin.ResourceDirectory, "exp.html")).ToString();
        }
    }
}

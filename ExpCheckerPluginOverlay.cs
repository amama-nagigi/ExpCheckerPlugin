using Advanced_Combat_Tracker;
using RainbowMage.OverlayPlugin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AmamaNagigi.ExpCheckerPlugin
{
    public class ExpCheckerPluginOverlay : OverlayBase<ExpCheckerPluginOverlayConfig>
    {
        /// <summary>
        /// 経験値取得用正規表現
        /// </summary>
        //private static readonly Regex re = new Regex(@"(<exp>[0-9]+)(\(.*\))?ポイントの(エレメンタル)?経験値を得た。");
        private static readonly Regex re = new Regex(@"(?<exp>[0-9]+)(\(.*\))?ポイントの(エレメンタル)?経験値を得た。");

        public ExpCheckerPluginOverlay(ExpCheckerPluginOverlayConfig config) : base(config, config.Name)
        {
            // タイマー処理は行わない
            this.Stop();

            // イベントの登録
            ActGlobals.oFormActMain.OnLogLineRead += this.OnLogLineRead;
            Navigate(config.Url);
        }

        private void OnLogLineRead(bool isImport, LogLineEventArgs logInfo)
        {
            // プラグインからは経験値の情報のみを送信し、計算はHTML側で行う
            var match = re.Match(logInfo.logLine);
            if (match.Success)
            {
                var expString = match.Groups["exp"].Value;
                var exp = int.Parse(expString);

                ExecuteScript($"getExp({exp})");
            }
        }

        protected override void Update()
        {
            // updateでは何もしない
        }

        private void ExecuteScript(string script)
        {
            if (this.Overlay != null && this.Overlay.Renderer != null && this.Overlay.Renderer.Browser != null)
            {
                // スクリプト実行
                this.Overlay.Renderer.Browser.GetMainFrame().ExecuteJavaScript(script, null, 0);
            }
        }
    }
}

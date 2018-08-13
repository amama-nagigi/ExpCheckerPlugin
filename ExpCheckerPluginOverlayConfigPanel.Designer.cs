namespace AmamaNagigi.ExpCheckerPlugin
{
    partial class ExpCheckerPluginOverlayConfigPanel
    {
        /// <summary> 
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.buttonReload = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.checkBoxClickThru = new System.Windows.Forms.CheckBox();
            this.expCheckerPluginOverlayConfigBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBoxVisible = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxUrl = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonDevTool = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expCheckerPluginOverlayConfigBindingSource)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonReload
            // 
            this.buttonReload.Location = new System.Drawing.Point(3, 3);
            this.buttonReload.Name = "buttonReload";
            this.buttonReload.Size = new System.Drawing.Size(75, 23);
            this.buttonReload.TabIndex = 0;
            this.buttonReload.Text = "リロード";
            this.buttonReload.UseVisualStyleBackColor = true;
            this.buttonReload.Click += new System.EventHandler(this.buttonReload_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.checkBoxClickThru, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.checkBoxVisible, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel3, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(752, 369);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // checkBoxClickThru
            // 
            this.checkBoxClickThru.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxClickThru.AutoSize = true;
            this.checkBoxClickThru.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.expCheckerPluginOverlayConfigBindingSource, "IsClickThru", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxClickThru.Location = new System.Drawing.Point(123, 23);
            this.checkBoxClickThru.Name = "checkBoxClickThru";
            this.checkBoxClickThru.Size = new System.Drawing.Size(15, 14);
            this.checkBoxClickThru.TabIndex = 18;
            this.checkBoxClickThru.UseVisualStyleBackColor = true;
            // 
            // expCheckerPluginOverlayConfigBindingSource
            // 
            this.expCheckerPluginOverlayConfigBindingSource.DataSource = typeof(AmamaNagigi.ExpCheckerPlugin.ExpCheckerPluginOverlayConfig);
            // 
            // checkBoxVisible
            // 
            this.checkBoxVisible.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.checkBoxVisible.AutoSize = true;
            this.checkBoxVisible.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.expCheckerPluginOverlayConfigBindingSource, "IsVisible", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxVisible.Location = new System.Drawing.Point(123, 3);
            this.checkBoxVisible.Name = "checkBoxVisible";
            this.checkBoxVisible.Size = new System.Drawing.Size(15, 14);
            this.checkBoxVisible.TabIndex = 17;
            this.checkBoxVisible.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "オーバーレイを表示する";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "クリックを透過させる";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 12);
            this.label3.TabIndex = 13;
            this.label3.Text = "HTMLファイルパス";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.textBoxUrl);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(123, 43);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(626, 25);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // textBoxUrl
            // 
            this.textBoxUrl.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.textBoxUrl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expCheckerPluginOverlayConfigBindingSource, "Url", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxUrl.Location = new System.Drawing.Point(3, 3);
            this.textBoxUrl.Name = "textBoxUrl";
            this.textBoxUrl.Size = new System.Drawing.Size(379, 19);
            this.textBoxUrl.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(123, 109);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(626, 257);
            this.flowLayoutPanel2.TabIndex = 19;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.buttonReload);
            this.flowLayoutPanel3.Controls.Add(this.buttonDevTool);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(123, 74);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(626, 29);
            this.flowLayoutPanel3.TabIndex = 20;
            // 
            // buttonDevTool
            // 
            this.buttonDevTool.Location = new System.Drawing.Point(84, 3);
            this.buttonDevTool.Name = "buttonDevTool";
            this.buttonDevTool.Size = new System.Drawing.Size(75, 23);
            this.buttonDevTool.TabIndex = 1;
            this.buttonDevTool.Text = "Devツール";
            this.buttonDevTool.UseVisualStyleBackColor = true;
            this.buttonDevTool.Click += new System.EventHandler(this.buttonDevTool_Click);
            // 
            // ExpCheckerPluginOverlayConfigPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ExpCheckerPluginOverlayConfigPanel";
            this.Size = new System.Drawing.Size(752, 369);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.expCheckerPluginOverlayConfigBindingSource)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReload;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxClickThru;
        private System.Windows.Forms.BindingSource expCheckerPluginOverlayConfigBindingSource;
        private System.Windows.Forms.CheckBox checkBoxVisible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxUrl;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button buttonDevTool;
    }
}

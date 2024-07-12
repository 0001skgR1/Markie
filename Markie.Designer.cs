namespace Markie
{
    partial class MNForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ContainBx = new System.Windows.Forms.PictureBox();
            this.CtxMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TextCN = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ContainBx)).BeginInit();
            this.CtxMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContainBx
            // 
            this.ContainBx.Location = new System.Drawing.Point(0, 0);
            this.ContainBx.Name = "ContainBx";
            this.ContainBx.Size = new System.Drawing.Size(584, 301);
            this.ContainBx.TabIndex = 0;
            this.ContainBx.TabStop = false;
            // 
            // CtxMenu
            // 
            this.CtxMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.ClearToolStripMenuItem,
            this.modeToolStripMenuItem});
            this.CtxMenu.Name = "CtxMenu";
            this.CtxMenu.Size = new System.Drawing.Size(106, 92);
            this.CtxMenu.Text = "Main Functions";
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.CopyToolStripMenuItem.Text = "Copy";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.PasteToolStripMenuItem.Text = "Paste";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // ClearToolStripMenuItem
            // 
            this.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem";
            this.ClearToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.ClearToolStripMenuItem.Text = "Clear";
            this.ClearToolStripMenuItem.Click += new System.EventHandler(this.ClearToolStripMenuItem_Click);
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageModeToolStripMenuItem,
            this.textModeToolStripMenuItem});
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(105, 22);
            this.modeToolStripMenuItem.Text = "Mode";
            // 
            // imageModeToolStripMenuItem
            // 
            this.imageModeToolStripMenuItem.Name = "imageModeToolStripMenuItem";
            this.imageModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.imageModeToolStripMenuItem.Text = "Image Mode";
            this.imageModeToolStripMenuItem.Click += new System.EventHandler(this.ImageModeToolStripMenuItem_Click);
            // 
            // textModeToolStripMenuItem
            // 
            this.textModeToolStripMenuItem.Name = "textModeToolStripMenuItem";
            this.textModeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textModeToolStripMenuItem.Text = "Text Mode";
            this.textModeToolStripMenuItem.Click += new System.EventHandler(this.TextModeToolStripMenuItem_Click);
            // 
            // TextCN
            // 
            this.TextCN.Location = new System.Drawing.Point(0, 0);
            this.TextCN.Name = "TextCN";
            this.TextCN.Size = new System.Drawing.Size(584, 301);
            this.TextCN.TabIndex = 1;
            this.TextCN.Text = "";
            // 
            // MNForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 301);
            this.Controls.Add(this.TextCN);
            this.Controls.Add(this.ContainBx);
            this.Name = "MNForm";
            this.ShowIcon = false;
            this.Text = "Markie";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.ContainBx)).EndInit();
            this.CtxMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ContainBx;
        private System.Windows.Forms.ContextMenuStrip CtxMenu;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem textModeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox TextCN;
    }
}


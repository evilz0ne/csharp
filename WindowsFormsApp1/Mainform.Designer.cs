namespace Seabattle
{
    partial class Mainform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainform));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Save = new System.Windows.Forms.ToolStripMenuItem();
            this.tool = new System.Windows.Forms.ToolStrip();
            this.ship1 = new System.Windows.Forms.ToolStripButton();
            this.ship2 = new System.Windows.Forms.ToolStripButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ship3 = new System.Windows.Forms.ToolStripButton();
            this.ship4 = new System.Windows.Forms.ToolStripButton();
            this.menu.SuspendLayout();
            this.tool.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(392, 24);
            this.menu.TabIndex = 0;
            this.menu.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.выходToolStripMenuItem,
            this.Save});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.выходToolStripMenuItem.Text = "&Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // Save
            // 
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(141, 22);
            this.Save.Text = "&Сохранить...";
            this.Save.Click += new System.EventHandler(this.SaveToolStripMenuItem_Click);
            // 
            // tool
            // 
            this.tool.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ship1,
            this.ship2,
            this.ship3,
            this.ship4});
            this.tool.Location = new System.Drawing.Point(0, 24);
            this.tool.Name = "tool";
            this.tool.Size = new System.Drawing.Size(392, 25);
            this.tool.TabIndex = 1;
            this.tool.Text = "toolStrip1";
            this.tool.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // ship1
            // 
            this.ship1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ship1.Image = ((System.Drawing.Image)(resources.GetObject("ship1.Image")));
            this.ship1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ship1.Name = "ship1";
            this.ship1.Size = new System.Drawing.Size(23, 22);
            this.ship1.Text = "toolStripButton1";
            this.ship1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // ship2
            // 
            this.ship2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ship2.Image = ((System.Drawing.Image)(resources.GetObject("ship2.Image")));
            this.ship2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ship2.Name = "ship2";
            this.ship2.Size = new System.Drawing.Size(23, 22);
            this.ship2.Text = "ship2";
            this.ship2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "XML -файлы (*.xml)|*.xml|Все файлы (*.*)|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // ship3
            // 
            this.ship3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ship3.Image = ((System.Drawing.Image)(resources.GetObject("ship3.Image")));
            this.ship3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ship3.Name = "ship3";
            this.ship3.Size = new System.Drawing.Size(23, 22);
            this.ship3.Text = "toolStripButton1";
            // 
            // ship4
            // 
            this.ship4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ship4.Image = ((System.Drawing.Image)(resources.GetObject("ship4.Image")));
            this.ship4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ship4.Name = "ship4";
            this.ship4.Size = new System.Drawing.Size(23, 22);
            this.ship4.Text = "toolStripButton2";
            // 
            // Mainform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(392, 306);
            this.Controls.Add(this.tool);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "Mainform";
            this.Text = "Sea Battle";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.tool.ResumeLayout(false);
            this.tool.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStrip tool;
        private System.Windows.Forms.ToolStripButton ship1;
        private System.Windows.Forms.ToolStripMenuItem Save;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ToolStripButton ship2;
        private System.Windows.Forms.ToolStripButton ship3;
        private System.Windows.Forms.ToolStripButton ship4;
    }
}


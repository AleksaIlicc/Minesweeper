namespace MineSweeperApp
{
    partial class GlavnaMinesweeper
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
            this.components = new System.ComponentModel.Container();
            this.BtnSettings = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblSeconds = new System.Windows.Forms.Label();
            this.BtnEndGame = new System.Windows.Forms.Button();
            this.LblNumOfFlags = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trenutnoStanjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.konfiguracijuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LblMinutes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnSettings
            // 
            this.BtnSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSettings.Location = new System.Drawing.Point(290, 580);
            this.BtnSettings.Name = "BtnSettings";
            this.BtnSettings.Size = new System.Drawing.Size(133, 46);
            this.BtnSettings.TabIndex = 0;
            this.BtnSettings.Text = "Settings";
            this.BtnSettings.UseVisualStyleBackColor = true;
            this.BtnSettings.Click += new System.EventHandler(this.BtnSettings_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // LblSeconds
            // 
            this.LblSeconds.AutoSize = true;
            this.LblSeconds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSeconds.Location = new System.Drawing.Point(439, 34);
            this.LblSeconds.Name = "LblSeconds";
            this.LblSeconds.Size = new System.Drawing.Size(27, 20);
            this.LblSeconds.TabIndex = 1;
            this.LblSeconds.Text = "00";
            // 
            // BtnEndGame
            // 
            this.BtnEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEndGame.Location = new System.Drawing.Point(493, 580);
            this.BtnEndGame.Name = "BtnEndGame";
            this.BtnEndGame.Size = new System.Drawing.Size(133, 46);
            this.BtnEndGame.TabIndex = 2;
            this.BtnEndGame.Text = "End Game";
            this.BtnEndGame.UseVisualStyleBackColor = true;
            this.BtnEndGame.Click += new System.EventHandler(this.BtnEndGame_Click);
            // 
            // LblNumOfFlags
            // 
            this.LblNumOfFlags.AutoSize = true;
            this.LblNumOfFlags.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumOfFlags.Location = new System.Drawing.Point(304, 35);
            this.LblNumOfFlags.Name = "LblNumOfFlags";
            this.LblNumOfFlags.Size = new System.Drawing.Size(24, 18);
            this.LblNumOfFlags.TabIndex = 4;
            this.LblNumOfFlags.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Image = global::MineSweeperApp.Properties.Resources.icons8_bomb_18;
            this.label2.Location = new System.Drawing.Point(285, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(10);
            this.label2.Size = new System.Drawing.Size(20, 33);
            this.label2.TabIndex = 3;
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(939, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trenutnoStanjeToolStripMenuItem,
            this.konfiguracijuToolStripMenuItem});
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Sacuvaj";
            // 
            // trenutnoStanjeToolStripMenuItem
            // 
            this.trenutnoStanjeToolStripMenuItem.Name = "trenutnoStanjeToolStripMenuItem";
            this.trenutnoStanjeToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.trenutnoStanjeToolStripMenuItem.Text = "Trenutno Stanje";
            this.trenutnoStanjeToolStripMenuItem.Click += new System.EventHandler(this.trenutnoStanjeToolStripMenuItem_Click);
            // 
            // konfiguracijuToolStripMenuItem
            // 
            this.konfiguracijuToolStripMenuItem.Name = "konfiguracijuToolStripMenuItem";
            this.konfiguracijuToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.konfiguracijuToolStripMenuItem.Text = "Konfiguraciju";
            this.konfiguracijuToolStripMenuItem.Click += new System.EventHandler(this.konfiguracijuToolStripMenuItem_Click);
            // 
            // LblMinutes
            // 
            this.LblMinutes.AutoSize = true;
            this.LblMinutes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMinutes.Location = new System.Drawing.Point(408, 34);
            this.LblMinutes.Name = "LblMinutes";
            this.LblMinutes.Size = new System.Drawing.Size(27, 20);
            this.LblMinutes.TabIndex = 6;
            this.LblMinutes.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(13, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = ":";
            // 
            // GlavnaMinesweeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 638);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.LblMinutes);
            this.Controls.Add(this.LblNumOfFlags);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BtnEndGame);
            this.Controls.Add(this.LblSeconds);
            this.Controls.Add(this.BtnSettings);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GlavnaMinesweeper";
            this.Text = "Minesweeper";
            this.Load += new System.EventHandler(this.GlavnaMinesweeper_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSettings;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label LblSeconds;
        private System.Windows.Forms.Button BtnEndGame;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNumOfFlags;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trenutnoStanjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem konfiguracijuToolStripMenuItem;
        private System.Windows.Forms.Label LblMinutes;
        private System.Windows.Forms.Label label4;
    }
}


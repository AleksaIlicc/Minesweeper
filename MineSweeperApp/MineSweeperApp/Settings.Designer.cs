namespace MineSweeperApp
{
    partial class Settings
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
            this.BtnEasy = new System.Windows.Forms.Button();
            this.BtnNormal = new System.Windows.Forms.Button();
            this.BtnHard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TbBrojRedova = new System.Windows.Forms.TextBox();
            this.TbBrojKolona = new System.Windows.Forms.TextBox();
            this.TbBrojMina = new System.Windows.Forms.TextBox();
            this.BtnProsledi = new System.Windows.Forms.Button();
            this.BtnZatvori = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnEasy
            // 
            this.BtnEasy.BackColor = System.Drawing.Color.Silver;
            this.BtnEasy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEasy.Location = new System.Drawing.Point(35, 27);
            this.BtnEasy.Name = "BtnEasy";
            this.BtnEasy.Size = new System.Drawing.Size(82, 47);
            this.BtnEasy.TabIndex = 1;
            this.BtnEasy.Text = "EASY";
            this.BtnEasy.UseVisualStyleBackColor = false;
            this.BtnEasy.Click += new System.EventHandler(this.BtnEasy_Click);
            // 
            // BtnNormal
            // 
            this.BtnNormal.BackColor = System.Drawing.Color.Silver;
            this.BtnNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNormal.Location = new System.Drawing.Point(139, 27);
            this.BtnNormal.Name = "BtnNormal";
            this.BtnNormal.Size = new System.Drawing.Size(82, 47);
            this.BtnNormal.TabIndex = 2;
            this.BtnNormal.Text = "NORMAL";
            this.BtnNormal.UseVisualStyleBackColor = false;
            this.BtnNormal.Click += new System.EventHandler(this.BtnNormal_Click);
            // 
            // BtnHard
            // 
            this.BtnHard.BackColor = System.Drawing.Color.Silver;
            this.BtnHard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnHard.Location = new System.Drawing.Point(247, 27);
            this.BtnHard.Name = "BtnHard";
            this.BtnHard.Size = new System.Drawing.Size(82, 47);
            this.BtnHard.TabIndex = 3;
            this.BtnHard.Text = "HARD";
            this.BtnHard.UseVisualStyleBackColor = false;
            this.BtnHard.Click += new System.EventHandler(this.BtnHard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Row:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Columns:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bomb:";
            // 
            // TbBrojRedova
            // 
            this.TbBrojRedova.Location = new System.Drawing.Point(179, 104);
            this.TbBrojRedova.Multiline = true;
            this.TbBrojRedova.Name = "TbBrojRedova";
            this.TbBrojRedova.Size = new System.Drawing.Size(114, 24);
            this.TbBrojRedova.TabIndex = 6;
            this.TbBrojRedova.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbBrojRedova_KeyPress);
            // 
            // TbBrojKolona
            // 
            this.TbBrojKolona.Location = new System.Drawing.Point(179, 142);
            this.TbBrojKolona.Multiline = true;
            this.TbBrojKolona.Name = "TbBrojKolona";
            this.TbBrojKolona.Size = new System.Drawing.Size(114, 24);
            this.TbBrojKolona.TabIndex = 7;
            this.TbBrojKolona.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbBrojKolona_KeyPress);
            // 
            // TbBrojMina
            // 
            this.TbBrojMina.Location = new System.Drawing.Point(179, 181);
            this.TbBrojMina.Multiline = true;
            this.TbBrojMina.Name = "TbBrojMina";
            this.TbBrojMina.Size = new System.Drawing.Size(114, 24);
            this.TbBrojMina.TabIndex = 8;
            this.TbBrojMina.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbBrojMina_KeyPress);
            // 
            // BtnProsledi
            // 
            this.BtnProsledi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnProsledi.Location = new System.Drawing.Point(74, 230);
            this.BtnProsledi.Name = "BtnProsledi";
            this.BtnProsledi.Size = new System.Drawing.Size(85, 28);
            this.BtnProsledi.TabIndex = 9;
            this.BtnProsledi.Text = "Confirm";
            this.BtnProsledi.UseVisualStyleBackColor = true;
            this.BtnProsledi.Click += new System.EventHandler(this.BtnProsledi_Click);
            // 
            // BtnZatvori
            // 
            this.BtnZatvori.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnZatvori.Location = new System.Drawing.Point(179, 230);
            this.BtnZatvori.Name = "BtnZatvori";
            this.BtnZatvori.Size = new System.Drawing.Size(85, 28);
            this.BtnZatvori.TabIndex = 10;
            this.BtnZatvori.Text = "Return";
            this.BtnZatvori.UseVisualStyleBackColor = true;
            this.BtnZatvori.Click += new System.EventHandler(this.BtnZatvori_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 280);
            this.Controls.Add(this.BtnZatvori);
            this.Controls.Add(this.BtnProsledi);
            this.Controls.Add(this.TbBrojMina);
            this.Controls.Add(this.TbBrojKolona);
            this.Controls.Add(this.TbBrojRedova);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHard);
            this.Controls.Add(this.BtnNormal);
            this.Controls.Add(this.BtnEasy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEasy;
        private System.Windows.Forms.Button BtnNormal;
        private System.Windows.Forms.Button BtnHard;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbBrojRedova;
        private System.Windows.Forms.TextBox TbBrojKolona;
        private System.Windows.Forms.TextBox TbBrojMina;
        private System.Windows.Forms.Button BtnProsledi;
        private System.Windows.Forms.Button BtnZatvori;
    }
}
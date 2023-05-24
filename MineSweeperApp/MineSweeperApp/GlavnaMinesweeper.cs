using MineSweeperApp.Properties;
using Podaci;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


namespace MineSweeperApp
{
    public partial class GlavnaMinesweeper : Form
    {
        #region Atributes

        private int minutes, seconds;
        private const int START_X = 190, START_Y = 60;
        private int numOfFlags;
        private bool END_FLAG = false;
        private bool GAME_OVER = false;

        private Button[,] mat;
        private bool[,] isFlagged; // for xml

        #endregion

        #region Constructors

        public GlavnaMinesweeper()
        {
            InitializeComponent();
        }

        #endregion

        #region Methods
        public void Initialize()
        {
            Init();
            Matrica.NapraviNovuMatricu();
            SetNewNumOfFlags();
            UpdateLabelNumOfFlags();
            InitilazieIsFlagged();
        }
        public void Init()
        {
            if (mat != null)
            {
                foreach (var m in mat)
                    this.Controls.Remove(m);
                mat = null;
            }
            mat = new Button[GameSettings.BrojRedova, GameSettings.BrojKolona];
            int X = START_X;
            int Y = START_Y;
            int SIZE_OF_BLOCK = GameSettings.VelicinaPolja;
            for (int i = 0; i < GameSettings.BrojRedova; i++)
            {
                for (int j = 0; j < GameSettings.BrojKolona; j++)
                {
                    mat[i, j] = new Button();
                    mat[i, j].Size = new Size(SIZE_OF_BLOCK, SIZE_OF_BLOCK);
                    mat[i, j].Name = $"Btn{i},{j}";
                    mat[i, j].Text = "";
                    mat[i, j].Location = new Point(X, Y);
                    mat[i, j].MouseDown += Btn_MouseDown;
                    mat[i, j].Font = new Font("Arial", 12);

                    X += SIZE_OF_BLOCK;
                }
                Y += SIZE_OF_BLOCK;
                X = START_X;
            }
            foreach (var v in mat)
                this.Controls.Add(v);
        }
        private void InitilazieIsFlagged()
        {
            if (isFlagged != null)
                isFlagged = null;
            isFlagged = new bool[GameSettings.BrojRedova, GameSettings.BrojKolona];
        }
        private void SetNewNumOfFlags()
        {
            numOfFlags = GameSettings.BrojBombi;
        }
        private void UpdateLabelNumOfFlags()
        {
            LblNumOfFlags.Text = numOfFlags.ToString();
        }
        private void GetXandYCords(Button b, out int xCord, out int yCord)
        {
            xCord = -1;
            yCord = -1;
            string naziv = b.Name.ToString();
            Regex regex = new Regex(@"Btn(\d{1,2}),(\d{1,2})");
            Match match = regex.Match(naziv);
            if (match.Success)
            {
                xCord = int.Parse(match.Groups[1].Value);
                yCord = int.Parse(match.Groups[2].Value);
            }
        }
        public Color ColorCheck(int value)
        {
            if (value == 1)
            {
                return Color.Blue;
            }
            else if (value == 2)
            {
                return Color.Green;
            }
            else if (value == 3)
            {
                return Color.Red;
            }
            else if (value == 4)
            {
                return Color.DarkBlue;
            }
            else if (value == 5)
            {
                return Color.Maroon;
            }
            else if (value == 6)
            {
                return Color.Turquoise;
            }
            else if (value == 7)
            {
                return Color.Gray;
            }
            else if(value == 8)
            {
                return Color.Black;
            }
            return Color.White;
        }
        public void OtvoriSusedne(Button b)
        {
            int xCord, yCord;
            GetXandYCords(b,out xCord, out yCord);

            OtvoriSusedneHelper(xCord, yCord);
        }
        private void OtvoriSusedneHelper(int xCord, int yCord)
        {
            if (xCord < 0 || xCord >= GameSettings.BrojRedova || yCord < 0 || yCord >= GameSettings.BrojKolona)
                return;
            if (mat[xCord, yCord].Enabled == false)
                return;
            if (Matrica.GetValue(xCord, yCord) > 0 && Matrica.GetValue(xCord, yCord) < 10) {
                Btn_MouseDown(mat[xCord,yCord], new MouseEventArgs(MouseButtons.Left, 1, 0, 0, 0));
                return;
            }
            if (Matrica.GetValue(xCord, yCord) == (int)FieldValue.Bomb)
                return;
            if (Matrica.GetValue(xCord,yCord) == (int)FieldValue.Empty)
                mat[xCord,yCord].Enabled = false;
            mat[xCord, yCord].FlatStyle = FlatStyle.Flat;
            mat[xCord, yCord].FlatAppearance.BorderColor = SystemColors.AppWorkspace;
            OtvoriSusedneHelper(xCord + 1, yCord);
            OtvoriSusedneHelper(xCord, yCord + 1);
            OtvoriSusedneHelper(xCord- 1, yCord);
            OtvoriSusedneHelper(xCord, yCord -1);
            OtvoriSusedneHelper(xCord - 1, yCord - 1);
            OtvoriSusedneHelper(xCord + 1, yCord + 1);
            OtvoriSusedneHelper(xCord - 1, yCord + 1);
            OtvoriSusedneHelper(xCord + 1, yCord - 1);
        }
        private void GameOverCheck()
        {
            foreach (var but in mat)
            {
                if (but.Image != null || but.FlatStyle == FlatStyle.Flat)
                    continue;
                else
                    return;
            }
            timer1.Stop();
            MessageBox.Show("You win!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        #endregion

        #region EventHandlers

        private void Btn_MouseDown(object sender, MouseEventArgs e)
        {
            if (GAME_OVER && END_FLAG == false)
                return;

            if (!timer1.Enabled && GAME_OVER==false)
                timer1.Start();

            Button b = sender as Button;

            int xCord, yCord;
            GetXandYCords(b, out xCord, out yCord);

            if (e.Button == MouseButtons.Left) 
            {
                if (b.Image != null)
                    return;
                

                int value = Matrica.GetValue(xCord, yCord);

                if (value == (int)FieldValue.Bomb) // bomba
                {
                    b.Image = Properties.Resources.icons8_bomb_18;
                    timer1.Stop();
                    if (END_FLAG == false) { 
                        b.BackColor = Color.DarkRed;
                        MessageBox.Show("Game Over!", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    GAME_OVER = true;
                }
                else if (value == (int)FieldValue.Empty) // prazna
                {
                    OtvoriSusedne(b);
                }
                else // neki broj
                {
                    b.FlatStyle = FlatStyle.Flat;
                    b.FlatAppearance.BorderColor = SystemColors.ControlDark;
                    b.ForeColor = ColorCheck(value);
                    b.Text = value.ToString();
                }
                b.MouseDown -= Btn_MouseDown;
            }
            else if (e.Button == MouseButtons.Right)
            {
                if (b.FlatStyle == FlatStyle.Flat)
                    return;
                if (b.Image == null) // added
                { 
                    b.Image = Resources.icons8_flag_18;
                    numOfFlags--;
                    isFlagged[xCord, yCord] = true;
                }
                else // removed
                { 
                    b.Image = null;
                    numOfFlags++;
                    isFlagged[xCord, yCord] = false;
                }
                UpdateLabelNumOfFlags();
            }
            if (numOfFlags == 0 )
                GameOverCheck();

            ActiveControl = null;
        }
      
        private void BtnSettings_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            Settings settingsForm = new Settings();
            settingsForm.ShowDialog();
            if (settingsForm.DialogResult == DialogResult.OK)
            {
                minutes = 0; seconds = 0;
                UpdateClock();
                GAME_OVER = false;
                END_FLAG = false;
                Initialize();
            }
            else
            {
                timer1.Start();
            }
        }
        private void GlavnaMinesweeper_Load(object sender, EventArgs e)
        {
            GameSettings.BrojRedova = 9;
            GameSettings.BrojKolona = 9;
            GameSettings.BrojBombi = 10;
            Initialize();
        }

        private void BtnEndGame_Click(object sender, EventArgs e)
        {
            END_FLAG = true;
            SetNewNumOfFlags();
            UpdateLabelNumOfFlags();
            foreach (var but in mat)
            {
                if (but.Image != null)
                    but.Image = null;
                if (!but.Enabled)
                    continue;
                Btn_MouseDown(but, new MouseEventArgs(MouseButtons.Left,1,0,0,0));
            }
        }

        #endregion

        #region XML

        private void konfiguracijuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveGameConfiguration();
        }

        private void SaveGameConfiguration()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.Title = "Save Game Configuration";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                XmlDocument xmlDoc = new XmlDocument();

                XmlElement rootElement = xmlDoc.CreateElement("GameConfiguration");
                xmlDoc.AppendChild(rootElement);


                XmlElement dimensionsElement = xmlDoc.CreateElement("Dimensions");
                dimensionsElement.SetAttribute("Rows", GameSettings.BrojRedova.ToString());
                dimensionsElement.SetAttribute("Columns", GameSettings.BrojKolona.ToString());
                dimensionsElement.SetAttribute("Bombs",GameSettings.BrojBombi.ToString());
                rootElement.AppendChild(dimensionsElement);

                XmlElement minesElement = xmlDoc.CreateElement("Mines");
                XmlElement numsElement = xmlDoc.CreateElement("Nums");

                for (int i = 0; i < GameSettings.BrojRedova; i++)
                {
                    for (int j = 0; j < GameSettings.BrojKolona; j++)
                    {
                        int value = Matrica.GetValue(i, j);

                        if (value == (int)FieldValue.Bomb) // bomba
                        {
                            XmlElement mineElement = xmlDoc.CreateElement("Mine");
                            mineElement.SetAttribute("X", i.ToString());
                            mineElement.SetAttribute("Y", j.ToString());
                            minesElement.AppendChild(mineElement);
                        }
                        else // ostalo
                        {
                            XmlElement numElement = xmlDoc.CreateElement("Num");
                            numElement.SetAttribute("X", i.ToString());
                            numElement.SetAttribute("Y", j.ToString());
                            numsElement.AppendChild(numElement);
                        }
                    }
                }

                rootElement.AppendChild(minesElement);
                rootElement.AppendChild(numsElement);

                xmlDoc.Save(fileName);
            }
        }

        private void trenutnoStanjeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveGame();
        }

        private void SaveGame()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "XML Files (*.xml)|*.xml";
            saveFileDialog.Title = "Save Game";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;

                XmlDocument xmlDoc = new XmlDocument();

                XmlElement rootElement = xmlDoc.CreateElement("GameState");
                xmlDoc.AppendChild(rootElement);

                XmlElement flagsElement = xmlDoc.CreateElement("NumOfFlagsLeft");
                flagsElement.InnerText = numOfFlags.ToString();
                rootElement.AppendChild(flagsElement);

                for (int i = 0; i < GameSettings.BrojRedova; i++)
                {
                    for (int j = 0; j < GameSettings.BrojKolona; j++)
                    {
                        int value = Matrica.GetValue(i, j);

                        XmlElement componentElement = xmlDoc.CreateElement("Component");
                        componentElement.SetAttribute("X", i.ToString());
                        componentElement.SetAttribute("Y", j.ToString());
                        if (isFlagged[i,j]) // flag
                        {
                            componentElement.SetAttribute("Type", "Flag");
                        }
                        else if (value == (int)FieldValue.Empty && mat[i, j].FlatStyle == FlatStyle.Flat) // prazna
                        {
                            componentElement.SetAttribute("Type", "Empty");
                        }
                        else if (value > 0 && value < 10 && mat[i, j].FlatStyle == FlatStyle.Flat) // neki broj
                        {
                            componentElement.SetAttribute("Type", "Number");
                            componentElement.InnerText = value.ToString();
                        }
                        else
                        {
                            componentElement.SetAttribute("Type", "Not Opened");
                        }

                        rootElement.AppendChild(componentElement);
                    }
                }
                xmlDoc.Save(fileName);
            }
        }

        #endregion

        #region Timer

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds == 60)
            {
                minutes++;
                seconds = 0;
            }
            UpdateClock();
        }

        private void UpdateClock()
        {
            LblMinutes.Text = minutes.ToString();
            LblSeconds.Text = seconds.ToString();
        }

        #endregion

    }
}

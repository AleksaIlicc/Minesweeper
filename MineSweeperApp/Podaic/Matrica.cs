using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public enum FieldValue
    {
        Bomb = 10,
        Empty = 0
    }
    public class Matrica
    {
        #region Atributes

        private static int[,] mat;

        #endregion

        #region Methods

        public static void NapraviNovuMatricu()
        {
            if (mat!=null)
                mat = null;
            Initialize();
        }

        private static void Initialize()
        {
            mat = new int[GameSettings.BrojRedova, GameSettings.BrojRedova];
            PostaviBombe();
            PostaviBrojeve();
            Prikazi();
        }

        private static void PostaviBombe()
        {
            Random ran = new Random();
            for (int i = 0; i < GameSettings.BrojBombi; i++)
            {
                int randX = ran.Next(0,GameSettings.BrojRedova);
                int randY = ran.Next(0, GameSettings.BrojKolona);
                if (mat[randX, randY] == (int)FieldValue.Bomb)
                    i--;
                
                mat[randX, randY] = (int)FieldValue.Bomb;
            }
        }

        private static void PostaviBrojeve()
        {
            for (int i = 0; i < GameSettings.BrojRedova; i++)
            {
                for (int j = 0; j < GameSettings.BrojKolona; j++)
                {
                    if (mat[i, j] == (int)FieldValue.Bomb)
                        continue;
                    byte counter = 0; 
                    int startX = i - 1;
                    int startY = j - 1;
                    for (int z = 0; z < 3; z++) 
                    {
                        for (int y = 0; y < 3; y++) 
                        {
                            if (startX + z < 0 || startY + y < 0 || startX +z >= GameSettings.BrojRedova || startY + y>= GameSettings.BrojKolona)
                                continue;
                            if (startX + z  == i && startY + y== j)
                                continue;
                            if (mat[startX + z, startY+ y]== (int)FieldValue.Bomb)
                                counter++;
                        }
                    }
                    mat[i, j] = counter;
                }
            }
        }

        private static void Prikazi() // pomocni prikaz u konzoli
        {
            for (int i = 0; i < GameSettings.BrojRedova; i++)
            {
                for (int j = 0; j < GameSettings.BrojKolona; j++)
                {
                    Console.Write(mat[i,j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static int GetValue(int x, int y)
        {
            return mat[x,y];
        }

        #endregion

    }
}

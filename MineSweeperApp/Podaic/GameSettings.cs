using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podaci
{
    public class GameSettings
    {
        #region Atributes

        private static int brojKolona;
        private static int brojRedova;
        private static int brojBombi;

        #endregion

        #region Properties

        public static int BrojRedova{
            get 
            { 
                return brojRedova; 
            }
            set
            {
                brojRedova = value;
            }
        }
        public static int BrojKolona { 
            get
            {
                return brojKolona;
            } 
            set { brojKolona = value;}
        }
        public static int BrojBombi
        {
            get
            {
                return brojBombi;
            }
            set
            {
                brojBombi = value;
            }
        }
        public static int VelicinaPolja
        {
            get
            {
                if (brojKolona == 9 && brojKolona == brojRedova)
                {
                    return 55;
                }
                else if (brojKolona == 14 && brojKolona == brojRedova)
                {
                    return 35;
                }
                else return 25;
            }
        }

        #endregion

    }

}

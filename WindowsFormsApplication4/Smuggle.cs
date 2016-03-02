using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication4
{
    public class Smuggle
    {

        public int Count;
        public int Cloak;
        public int WinCount;

        public int LossCount;
      
        public int RandomTurnNumber;
        public bool isCloaked;

       
        public int NumberGenerate()
        {
            
        Random Random = new Random();
            int RandomTurnNumber = Random.Next(1, 7);
            return RandomTurnNumber;

        }
      
         



    }


}


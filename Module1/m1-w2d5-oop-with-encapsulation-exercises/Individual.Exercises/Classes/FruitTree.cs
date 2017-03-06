using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class FruitTree
    {


        private string typeOfFruit;
        private int piecesOfFruitLeft;

        public string TypeOfFruit
        {
            get { return typeOfFruit; }
        }
        public int PiecesOfFruitLeft
        {
            get { return piecesOfFruitLeft; }
        }

        public bool PickFruit(int numberOfPiecesToRemove)
        {
            bool result = false;
            if (piecesOfFruitLeft >= numberOfPiecesToRemove)
            {
                piecesOfFruitLeft -= numberOfPiecesToRemove;
                result = true;
            }
            return result;
 
        }

        public FruitTree(string typeOfFruit, int startingPiecesOfFruit)
        {
            this.typeOfFruit = typeOfFruit;
            this.piecesOfFruitLeft = startingPiecesOfFruit;
        }
    }
}

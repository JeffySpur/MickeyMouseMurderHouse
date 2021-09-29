using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainRoom
{
    public class MickeyRepository
    {
        public readonly List<CharacterTemplate> _CharacterList = new List<CharacterTemplate>();

        //Create Each Player's persona
        public bool CreateCharacter(CharacterTemplate character)
        {
            int startingCount = _CharacterList.Count;
            _CharacterList.Add(character);

            bool wasAdded = (_CharacterList.Count > startingCount) ? true : false;
            return wasAdded;
        }

        //Read Dialog from each seeded character? 
        public CharacterTemplate GetCharacterByName(string characterWanted)
        {
            foreach (CharacterTemplate character in _CharacterList)
            {
                if (character.Name.ToLower() == characterWanted.ToLower())
                { return character; }
            }
            return null;
        }


        //Accusing a murderer
        public void AccusationFly()
        {
            string murderer = "donald";
            string accusation;
            int guessCount = 0;
            bool outOfAccusations = false;

            while (accusation != murderer && !outOfAccusations)
            {
                if (guessCount <= 2)
                {
                    Console.WriteLine("Who do you accuse?");
                    accusation = Console.ReadLine().ToLower();
                    guessCount++;
                }
                else
                {
                    outOfAccusations = true;
                }
                if (outOfAccusations)
                {
                    Console.WriteLine("You have made too many false accusations!");
                }
            }



             
        }




    }
}

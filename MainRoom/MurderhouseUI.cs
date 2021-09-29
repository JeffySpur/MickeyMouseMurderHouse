using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainRoom
{
    class MurderhouseUI
   {
            
        public void Run()
        {
            SeedData();  //check helper methods

            RunMenu();
        }

        private void RunMenu()
        {
            bool isPlaying = true;
            while (isPlaying)
            {
                Console.Clear();
                Console.WriteLine(
                    "Welcome and Scenario Text. Join us detective!");
                PressAnyKey(); //check helper methods




            }

            //create player's detective character at beginning.  x2 if two are playing
            public void CreateDetective()
            {
                Console.Clear();
                CharacterTemplate newDetective = new CharacterTemplate();
                Console.WriteLine("What is your name?");
                newDetective.Name = Console.ReadLine();
                newDetective.Role = "Detective";

                //add to list?
            }

            Console.Clear();
            Console.WriteLine
                (
                "Who would you like to interrogate? \n" +
                "1. Daisy\n" +
                "2. Donald\n" +
                "3. Mickey\n" +
                "4. Minnie\n" +
                "5. Pete\n" +
                "Or are you ready to make an accusation? Be careful, 3 false accusations, and the crime will be assigned to you!" +
                "6. Yes!  J'accuse!"
                );

            string userPrimaryInput = Console.ReadLine();

            switch (userPrimaryInput)
            {
                case "1":
                   ShowDaisy();
                    break;
                case "2":
                    //ShowDonald();
                    break;
                case "3":
                    //ShowMickey();
                    break;
                case "4":
                    //ShowMinnie();
                    break;
                case "5":
                    //ShowPete();
                    break;
                case "6":
                    //AccusationsFly();
                    break;

            }

        }
    
     private void ShowDaisy()
        {

        }
    

        //helper stuff
    public void PressAnyKey()
    {
        Console.WriteLine("press key to continue");
        Console.ReadKey();
    }

    private void SeedData()
        {
            CharacterTemplate daisy = new CharacterTemplate("Daisy", "Child Star");
            daisy.Testimony = "testmonial things you're gonna right";

            CharacterTemplate donald = new CharacterTemplate("Donald", "Director");
            donald.Testimony = "testmonial things you're gonna right";

            CharacterTemplate mickey = new CharacterTemplate("Mickey", "Leading Man");
            mickey.Testimony = "testmonial things you're gonna right";

            CharacterTemplate pete = new CharacterTemplate("Pete", "Chef");
            pete.Testimony = "testmonial things you're gonna right";

            CharacterTemplate goofy = new CharacterTemplate("Goofy", "Bellhop");
            goofy.Testimony = "testmonial things you're gonna right";

            CharacterTemplate minnie = new CharacterTemplate("Minnie", "Starlet");
            minnie.Testimony = "testmonial things you're gonna right";


        }
    }

}

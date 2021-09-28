using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainRoom
{
    class MurderhouseUI
    {




        //helper stuff
    public void PressAnyKey()
    {
        console.WriteLine("press key to continue");
        console.ReadKey();
    }

    private void SeedData()
        {
            CharacterTemplate daisy = new CharacterTemplate("Daisy", 42, "Child Star");
            daisy.Testimony = "testmonial things you're gonna right";

            CharacterTemplate donald = new CharacterTemplate("Donald", 52, "Director");
            donald.Testimony = "testmonial things you're gonna right";

            CharacterTemplate mickey = new CharacterTemplate("Mickey", 90, "Leading Man");
            mickey.Testimony = "testmonial things you're gonna right";

            CharacterTemplate pete = new CharacterTemplate("Pete", 62, "Chef");
            pete.Testimony = "testmonial things you're gonna right";

            CharacterTemplate goofy = new CharacterTemplate("Goofy", 65, "Bellhop");
            goofy.Testimony = "testmonial things you're gonna right";

            CharacterTemplate minnie = new CharacterTemplate("Minnie", 85, "Starlet");
            minnie.Testimony = "testmonial things you're gonna right";


        }
    }

}

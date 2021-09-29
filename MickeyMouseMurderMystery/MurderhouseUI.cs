using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MainRoom
{
    class MurderhouseUI
    {
        private MickeyRepository _repo = new MickeyRepository();

        public void Run()
        {
            SeedData();  //check helper methods

            RunMenu();
        }


        private void RunMenu()
        {
            StartSetUp();
            bool isPlaying = true;
            while (isPlaying)
            {
                //finish
                //FirstChoiceMenu()
                //start
                bool activelyInterrogating = true;
                while (activelyInterrogating)
                {
                    Console.Clear();
                    Console.WriteLine
                        (
                        "Who would you like to interrogate? \n\n" +
                        "1. Daisy\n" +
                        "2. Donald\n" +
                        "3. Mickey\n" +
                        "4. Minnie\n" +
                        "5. Pete\n\n" +
                        "Or are you ready to make an accusation?\n Be careful, 3 false accusations, and the crime will be pinned on you!\n\n" +
                        "6. Yes!  J'accuse!\n \n \n" +
                        "7. I'm no detective!  Get me outta here!"
                        );

                    string userPrimaryInput = Console.ReadLine();

                    switch (userPrimaryInput)
                    {
                        case "1":
                            ShowDaisy();
                            break;
                        case "2":
                            ShowDonald();
                            break;
                        case "3":
                            ShowMickey();
                            break;
                        case "4":
                            ShowMinnie();
                            break;
                        case "5":
                            ShowPete();
                            break;
                        case "6":
                            activelyInterrogating = false;
                            AccusationsFly();
                            break;
                        case "7":
                            isPlaying = false;
                            break;
                        default:
                            Console.WriteLine("Hey idiot.  Pick a number.  You don't wanna die next!");
                            Console.ReadKey();
                            break;
                    }
                }
                //finish
            }

        }
        public void FirstChoiceMenu()
        {
            //start
            //finish
        }
        public void StartSetUp()
        {

            //start
            Console.Clear();
            Console.WriteLine("Welcome");
            //PressAnyKey(); //check helper methods
            Thread.Sleep(2000);


            Console.Clear();
            CharacterTemplate newDetective = new CharacterTemplate();
            Console.WriteLine("What is your name?");
            newDetective.Name = Console.ReadLine();
            newDetective.Role = "Detective";
            Console.WriteLine("Oh yes here you are on the guest list. Please come in.\n");
            Thread.Sleep(2000);
            Console.WriteLine("You sit down for dinner with six guests around the table\n");
            Thread.Sleep(2000);

            Console.WriteLine("The spread of food laid out before you looks amazing the food is glistening and smells delicious.\n");
            Thread.Sleep(2000);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("At the head of the table sits Mickey Mouse\n");
            Thread.Sleep(2000);

            Console.WriteLine("\"Oh boy! I’m sure glad you could all attend the party tonight. Huh-huh\"\n");
            Thread.Sleep(2000);

            Console.WriteLine("To his left Minnie chimes in:\n");
            Thread.Sleep(2000);

            Console.WriteLine("\"Oh yes Mickey has been preparing dinner all day and we were both so happy to have all of you here.\"\n");
            Thread.Sleep(2000);

            Console.WriteLine("\"Well we are both so happy to be invited and thank you for having us\", Donald says with his raspy voice\n");
            Thread.Sleep(2000);

            Console.WriteLine("\"Yes, Donald and I\", Daisy pipes in. \"I’ve been running the boys around all day being a parent is so exhausting it’s so nice to finally be an adult dinner party with no kids.\"\n");
            Thread.Sleep(2000);

            Console.WriteLine("\"Gawrsh a-hyuk my stomach sure is rumbling\", goofy said with his trademark chuckle and laugh.\n");
            Thread.Sleep(2000);
            Console.WriteLine("He reaches down for one of the delicious looking bacon wrapped shrimp. He bites into it.\n");
            Thread.Sleep(2000);

            Console.WriteLine("right at that moment….\n");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("\"Well that’s great because dinner is served\", the chef Pete says busting through the waiters doors with the main course in hand.\n");
            Thread.Sleep(2000);

            Console.WriteLine("As Pete begins to serve the main course the lights suddenly go out!\n");
            Thread.Sleep(2000);
            Console.ReadLine();
            Console.Clear();

            Console.WriteLine("A CRASH!!!");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("A SCREAM!!!");
            Thread.Sleep(2000);
            Console.Clear();

            Console.WriteLine("The lights flip back on in Goofy is laying dead in the floor!!!\n");
            Thread.Sleep(2000);

            Console.WriteLine("There is no blood.\n");
            Thread.Sleep(2000);

            Console.WriteLine("There is no sign of struggle.\n");
            Thread.Sleep(2000);

            Console.WriteLine("He’s not breathing!!\n");
            Thread.Sleep(2000);

            Console.WriteLine("Everyone there freaks out for an appropriate amount of time.Then the case turns cold everyone begins to turn on one another and begins pointing fingers.\n");
            Thread.Sleep(2000);

            Console.WriteLine("It is now your job to figure out who murdered goofy.Go talk to everyone and try to figure out who’s lying. Be careful with how many guesses you make. If you make three wrong guesses and the group will grow suspicious of you and you will be framed for the murder and taken to jail.\n");
            Thread.Sleep(2000);

            Console.WriteLine($"Good luck, { newDetective.Name}!");

            Console.ReadLine();


        }

        private void ShowDaisy()
        {
            bool daisyInterrogation = true;
            while (daisyInterrogation)
            {

                Console.Clear();
                Console.WriteLine("What to ask Daisy?\n" +
                   "1. Where were you when the lights went out?\n" +
                   "2. You said earlier that you and donald have been running around all day where have you guys been?\n" +
                   "3. Is there anything else you feel like I should know about?\n" +
                   "4. Question another suspect?\n\n");

                int selectQuestion = int.Parse(Console.ReadLine());
                CharacterTemplate daisy = _repo.GetCharacterByName("daisy");

                if (selectQuestion == 1)
                {
                    Console.WriteLine(daisy.Testimony);
                    Console.ReadKey();
                }
                else if (selectQuestion == 2)
                {
                    Console.WriteLine(daisy.Testimony2);
                    Console.ReadKey();
                }
                else if (selectQuestion == 3)
                {
                    Console.WriteLine(daisy.Testimony3);
                    Console.ReadKey();
                }
                else if (selectQuestion == 4)
                {
                    daisyInterrogation = false;
                }
                else
                {
                    Console.WriteLine("Please select question number 1, 2, or 3.");
                    Console.ReadKey();
                }
            }
            //FirstChoiceMenu()

        }
        private void ShowDonald()

        {
            bool donaldInterrogation = true;
            while (donaldInterrogation)
            {


                Console.Clear();
                Console.WriteLine("What to ask Donald?\n" +
                   "1. Where were you when the lights went out?\n" +
                   "2. What did you come here for earlier today?\n" +
                   "3. Whats with you asking pete for money?\n" +
                   "4. Question another supect.\n\n");

                int selectQuestion = int.Parse(Console.ReadLine());
                CharacterTemplate donald = _repo.GetCharacterByName("donald");

                if (selectQuestion == 1)
                {
                    Console.WriteLine(donald.Testimony);
                    Console.ReadKey();
                }
                else if (selectQuestion == 2)
                {
                    Console.WriteLine(donald.Testimony2);
                    Console.ReadKey();
                }
                else if (selectQuestion == 3)
                {
                    Console.WriteLine(donald.Testimony3);
                    Console.ReadKey();
                }
                else if (selectQuestion == 4)
                {
                    donaldInterrogation = false;
                }
                else
                {
                    Console.WriteLine("Please select question number 1, 2, or 3.");
                    Console.ReadKey();
                }
            }

        }
        private void ShowMickey()

        {
            bool mickeyInterrogation = true;
            while (mickeyInterrogation)
            {

                Console.Clear();
                Console.WriteLine("What to ask Mickey?\n" +
                   "1. Where were you when the lights went out?\n" +
                   "2. What were you doing today before this?\n" +
                   "3. Did you see anything suspicious today?\n" +
                   "4. Go interrogate another suspect.\n\n");

                int selectQuestion = int.Parse(Console.ReadLine());
                CharacterTemplate mickey = _repo.GetCharacterByName("Mickey");

                if (selectQuestion == 1)
                {
                    Console.WriteLine(mickey.Testimony);
                    Console.ReadKey();

                }
                else if (selectQuestion == 2)
                {
                    Console.WriteLine(mickey.Testimony2);
                    Console.ReadKey();
                }
                else if (selectQuestion == 3)
                {
                    Console.WriteLine(mickey.Testimony3);
                    Console.ReadKey();
                }
                else if (selectQuestion == 4)
                {
                    mickeyInterrogation = false;
                }
                else
                {
                    Console.WriteLine("Please select question number 1, 2, or 3.");
                    Console.ReadKey();
                }

            }
        }

        private void ShowMinnie()
        {
            bool minnieInterrogation = true;
            while (minnieInterrogation)
            {
                Console.Clear();
                Console.WriteLine("What to ask Minnie?\n" +
                   "1. Where were you when the lights went out?\n" +
                   "2. Mickey said you guys have been running around all day to different stores, is that true?\n" +
                   "3. Have you seen anything suspicious you feel like I should know?\n" +
                   "4. Go back and question someone else.\n\n");

                int selectQuestion = int.Parse(Console.ReadLine());
                CharacterTemplate minnie = _repo.GetCharacterByName("minnie");

                if (selectQuestion == 1)
                {
                    Console.WriteLine(minnie.Testimony);
                    Console.ReadKey();
                }
                else if (selectQuestion == 2)
                {
                    Console.WriteLine(minnie.Testimony2);
                    Console.ReadKey();
                }
                else if (selectQuestion == 3)
                {
                    Console.WriteLine(minnie.Testimony3);
                    Console.ReadKey();
                }
                else if (selectQuestion == 4)
                {
                    minnieInterrogation = false;
                }
                else
                {
                    Console.WriteLine("Please select question number 1, 2, or 3.");
                    Console.ReadKey();
                }

            }

        }
        private void ShowPete()
        {
            bool peteInterrogation = true;
            while (peteInterrogation)
            {

                Console.Clear();
                Console.WriteLine("What to ask Pete?\n" +
                   "1. Where were you when the lights went out?\n" +
                   "2. Have you been here all day?\n" +
                   "3. Anything else you would like to report?\n" +
                   "4. What happened earlier with the golf Game and the money?\n" +
                   "5. Go back and make your first accusation or go talk to someone else.\n\n");

                int selectQuestion = int.Parse(Console.ReadLine());
                CharacterTemplate pete = _repo.GetCharacterByName("Pete");

                if (selectQuestion == 1)
                {
                    Console.WriteLine(pete.Testimony);
                    Console.ReadKey();
                }
                else if (selectQuestion == 2)
                {
                    Console.WriteLine(pete.Testimony2);
                    Console.ReadKey();
                }
                else if (selectQuestion == 3)
                {
                    Console.WriteLine(pete.Testimony3);
                    Console.ReadKey();
                }
                else if (selectQuestion == 4)
                {
                    Console.WriteLine(pete.Testimony4);
                    Console.ReadKey();
                }
                else if (selectQuestion == 5)
                {
                    peteInterrogation = false;
                }
                else

                {
                    Console.WriteLine("Please select question number 1, 2, or 3.");
                    Console.ReadKey();
                }

            }
        }



        //Accusing a murderer
        public void AccusationsFly()
        {
            string murderer = "donald";
            string accusation = "";
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

        //helper stuff
        public void PressAnyKey()
        {
            Console.WriteLine("press key to continue");
            Console.ReadKey();
        }

        private void SeedData()
        {
            CharacterTemplate daisy = new CharacterTemplate("Daisy", "Child Star");
            daisy.Testimony = "I went to grab onto Donald and he stumbled the other way when I ran into him we crashed and hit the floor we were both so scared.";
            daisy.Testimony2 = "Well we ran all over the place today we drop the boys off at soccer and then I had to go get a new bow for my feathers. Then we came here so Donald could help Pete with some of the food.";
            daisy.Testimony3 = "Not that I know of Donald asked Pete to borrow some money earlier but I’m not sure what happened or why. But He had to say no because he didn’t have it.";
            _repo.CreateCharacter(daisy);

            CharacterTemplate donald = new CharacterTemplate("Donald", "Director");
            donald.Testimony = " I was sitting in between goofy and Daisy when the lights went out. Daisy jumped and crashed into me we fell onto the floor.";
            donald.Testimony2 = "We came to help clean up and I came to help Pete cook the Bacon Wrapped shrimp before i had to leave.";
            donald.Testimony3 = "I asked him for money to payback Goofy from last week’s golf game and he said No.I bet it was Pete he also owed goofy money.I would ask him.";
            _repo.CreateCharacter(donald);


            CharacterTemplate mickey = new CharacterTemplate("Mickey", "Leading Man");
            mickey.Testimony = "well I was standing at the head of the table of course oh boy was I scared. Huh-huh";
            mickey.Testimony2 = "Well Minnie and I have been out and about running around to different stores and preparing all day. At some point Pete did ask me for his paycheck early but I had to tell him No because I did not have it yet.";
            mickey.Testimony3 = "oh boy suspicious oh I don’t think so we all went golfing last week and goofy won. But nothing strange at all today. Huh-huh.";
            _repo.CreateCharacter(mickey);

            CharacterTemplate pete = new CharacterTemplate("Pete", "Chef");
            pete.Testimony = "Meeee why I was serving the main course… hands full. It couldn’t have been me boss I swears it.";
            pete.Testimony2 = "I’ve been preparing the food all day since 6 AM until now I’ve been in this kitchen.";
            pete.Testimony3 = "Earlier Donald stopped by to ask me for money. To pay back goofy I told him I didn’t have it he help me prepare some of the appetizers and then him and Daisy had to leave. Now as for the golf game goofy one Mickey me an Donald all owed him money after that. I owed him the least donald and mickey owed him the most.  I asked Mickey for it and he said he didn’t have it I bet you he did that mean old mouse.";
            pete.Testimony4 = "Anything else… Well just between you and me, it wasn’t me boss I’m telling you someone else did it… Yeah I owed him money but I wouldn’t kill him over that… That dumb mouse…";
            _repo.CreateCharacter(pete);


            CharacterTemplate minnie = new CharacterTemplate("Minnie", "Starlet");
            minnie.Testimony = "I jumped and hold onto Mickey he was right next to me we were both shaking.";
            minnie.Testimony2 = "Yes that’s exactly what we’ve been doing I went and bought this new dress and then Mickey had to go get some new shoes we had to get some things for the house and then we also had to buy dinner we’ve been out almost all day.";
            minnie.Testimony3 = "Nothing suspicious on my end I know the golf game got pretty intense last week the boys haven’t stopped talking about it. I think goofy won and I think Donald came in last but maybe it was Pete I don’t know.";
            _repo.CreateCharacter(minnie);


        }


    }

}

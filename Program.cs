using System;

namespace TextAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("One morning, while jogging in the park, you stop to take a rest by a scenic overlook.");
            Console.WriteLine("Just as you begin again, you notice something in the bushes.");
            Console.WriteLine("As you approach, you see something disturbing.  Blood.");
            Console.WriteLine("What do you donext!?!  If you want to investigate further, type YES.  IF you want to keep jogging, type RUN.");
            var bloodOrJog = Console.ReadLine();
            if (bloodOrJog == "YES" || bloodOrJog == "yes" || bloodOrJog == "Yes" || bloodOrJog == "ya")
            {
                Console.WriteLine("Despite your nervousness, you follow the blood trail and your suspicions are confirmed.");
                Console.WriteLine("It's a dead body.  It's a man's body and it appears to have been stabbed multiple times.");
                Console.WriteLine("You pull out your cell phone and dial 911");
                Console.WriteLine("The dispatcher tells you she's sendning the police and to stay with the body");
                Console.WriteLine("While waiting, you decide to look for identification on the man.  But, instead of a wallet...");
                Console.WriteLine("You find something else.  Money!  Lots and lots of stone cold cash!");
                Console.WriteLine("You look around.  You're completely alone. You could take some, or all of it, and no one would ever koww!");
                Console.WriteLine("So, do you take the money???  YES or NO");
                var takeMoney = Console.ReadLine();
                if (takeMoney == "YES" || takeMoney == "Yes" || takeMoney == "yes" || takeMoney == "ya")
                {
                    Console.WriteLine("You grab several handfuls of cash and shove it into your pants.");
                    Console.WriteLine("You figure this guy's dead.  What does he care?!?");
                    Console.WriteLine("he police take your statement and send you on your way");
                    Console.WriteLine("When you get home, you count the money. It's all $100 bills!  And it totals up to almost $20,000!!");
                    Console.WriteLine("The next day, the police are back at your house and ask you point blank if you found any money with the money.");
                    Console.WriteLine("Do you fess up and tell them about the money?  YES or NO");
                    var fessUp = Console.ReadLine();
                    if (fessUp == "YES" || fessUp == "Yes" || fessUp == "yes" || fessUp == "ya") 
                    {
                        Console.WriteLine("Smart move!!  Turns out the deceased was an undercover cop and he was killed in actionduring a sting");
                        Console.WriteLine("Had you of lied, you would have quickly become the cops number one suspect in his murder.");
                        Console.WriteLine("Since you fessed up, they give you a warning but you stay our of jail for now.");
                        Console.WriteLine("You do have to give the money back though :)");
                        Console.WriteLine("The End");
                    }
                    else
                    {
                        Console.WriteLine("You lie and tell them you didn't find any money.  Bad move!");
                        Console.WriteLine("Turns out, they had security camera footage of you entering the park around the time of the murder.");
                        Console.WriteLine("You just became their number one murder suspect");
                        Console.WriteLine("Not only that but you were already on parole which means back to jail you go!");
                        Console.WriteLine("In prison, you're stabbed to death for making eye contact with your cell mate");
                        Console.WriteLine("The End");
                    }
                }
                else
                {
                    Console.WriteLine("You decide not to take the money.  And it's good thing too!");
                    Console.WriteLine("They had security camera footage showing you entering the park around the time of the murder");
                    Console.WriteLine("Had you have lied, you would have quickly become the number one murder suspect.");
                    Console.WriteLine("For now, you get off with a warining.  Next time you'll do the right thing the first time.");
                    Console.WriteLine("The End");
                }
            }
                else // You run
                {
                Console.WriteLine("You panic and run.  You know it's probably not the right thing to do but you just want to go home");
                Console.WriteLine("You're sure it was a dead body which means someone else will eventually find it and call it in");
                Console.WriteLine("No big deal, right??");
                Console.WriteLine("The next day there is a knock on your door. It's the police and the want to ask some questions");
                Console.WriteLine("Mainly, were you anywhere near the park yesterday morning around 6am?");
                Console.WriteLine("Do you tell them that you were in the park?  YES or NO ");
                }
            var yesOrLie = Console.ReadLine();
            if (yesOrLie == "YES" || yesOrLie == "yes" || yesOrLie == "Yes" || yesOrLie == "ya") 
            {
                Console.WriteLine("You explain to the police that you were in the park and that you saw the blood but that you were scared so you left");
                Console.WriteLine("Smart move!  They had security camera footage showing you entering the park around the time of the murder");
                Console.WriteLine("Had you have lied, you would have quickly become the number one murder suspect.");
                Console.WriteLine("For now, you get off with a warining.  Next time you'll do the right thing the first time.");
                Console.WriteLine("The End");
            }
            else
            {
                Console.WriteLine("You lie and tell them you were at home all morning.  Bad Move!!");
                Console.WriteLine("Turns out, they had security camera footage of you entering the park around the time of the murder.");
                Console.WriteLine("You just became their number one murder suspect");
                Console.WriteLine("Not only that but you were already on parole which means back to jail you go!");
                Console.WriteLine("In prison, you're stabbed to death for making eye contact with your cell mate");
                Console.WriteLine("The End");
            }












        }

    }
}

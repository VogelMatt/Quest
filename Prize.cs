using System;

namespace Quest
{


    /*Create a method in the class called ShowPrize.
    1 The method should accept an Adventurer as a parameter.
    2 If the adventurer's Awesomeness is greater than zero, write the _text field to the console the same number of times as the value of the Awesomeness property.
    3 If the adventurer's Awesomeness is zero or less than zero, write a message of pity to the console.
    4 In Program.cs create an instance of the Prize.
    5 At the end of the quest (before you ask if the user wants to repeat the quest) call the ShowPrize method.*/
    public class Prize
    {
        private string _text;

        public Prize(string text)
        {
            _text = text;
        }


        public void ShowPrize(Adventurer adventurer)
        {
            if(adventurer.Awesomeness > 0)
            {
                for(int i = 1; i <= adventurer.Awesomeness; i++)
                {
                Console.WriteLine(_text);
                }
            }
            else
            {
                Console.WriteLine("I pity the Fool...that's you. You are the fool. ");
            }
        }

    }

}
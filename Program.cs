//Marcel Rodriguez
//10-19-22 4pm
//Mini Challenge 7 - Reverse it
//This program will take a string value and reverse it to output backwards
//Peer review - 

Console.Clear();

string end = "yes";

while(end == "yes" || end == "YES" || end == "Yes")
{

    bool isContainer = true;
    bool issaNumber;
    long validForReal = 0;
    string inputOne;

    while(isContainer == true)
    {
        Console.WriteLine("Please enter a number and i will reverse it");
        inputOne = Console.ReadLine();
        issaNumber = Int64.TryParse(inputOne, out validForReal);

        string inputReverse = string.Empty;

        if(issaNumber == true)
        {
            for(int i = inputOne.Length - 1; i>=0; i--)
            {
                inputReverse += inputOne[i];
            }
            Console.WriteLine(inputReverse);
            isContainer = false;
            
            long daNumber = 0;
            Console.WriteLine("_________________________________");
            Console.WriteLine("Aw you don't beleive it's an int? give me another number: ");


            bool containerAdd = false;
            bool isNumberCheck;
            while(containerAdd == false)
            {
                string numberChoice = Console.ReadLine();
                isNumberCheck = Int64.TryParse(numberChoice, out daNumber);

                if (isNumberCheck == true)
                {
                    containerAdd = true;
                }
                else
                {
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("That is not a number >_>");
                    Console.WriteLine("_________________________________");
                    Console.WriteLine("Please give me another number: ");
                }
            }
            long sum = validForReal + daNumber;
            Console.WriteLine("The sum of " +validForReal+ " and " +daNumber+ " equals " +sum);
            Console.WriteLine("BOOM, m a t h");
            Console.WriteLine("_________________________________");

        }
        else
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("That is not a number >_>");
            Console.WriteLine("_________________________________");
        }
    }

    string wordInput;
    bool isContainer2 = true;
    bool issaNumber2;
    long validForReal2 = 0;

    while(isContainer2 == true)
    {
        Console.WriteLine("Please enter a string and i will reverse it");
        wordInput = Console.ReadLine();
        issaNumber2 = Int64.TryParse(wordInput, out validForReal2);

        string wordReverse = string.Empty;

        if(issaNumber2 == false)
        {
            for(int j = wordInput.Length - 1; j>=0; j--)
            {
                wordReverse += wordInput[j];
            }
            Console.WriteLine(wordReverse);
            isContainer2 = false;
            Console.WriteLine("_________________________________");
            Console.WriteLine("yeah that's pretty much a string lol");

        }
        else
        {
            Console.WriteLine("_________________________________");
            Console.WriteLine("That is not a string >_>");
            Console.WriteLine("_________________________________");
        }
    }

    Console.WriteLine("Do you want to play again? yes/no");
    end = Console.ReadLine();
    Console.WriteLine("_________________________________");

}
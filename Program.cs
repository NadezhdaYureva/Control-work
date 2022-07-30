void PrintArray(string[] input)
{
    if (input.Length == 0) { System.Console.WriteLine("Массив не содержит подходящих строк."); }
    else
    {
        for (int i = 0; i < input.Length - 1; i++)
        {
            System.Console.Write($"{input[i]}, ");
        }
        System.Console.WriteLine($"{input[input.Length - 1]}.");
    }
}

string[] FindShorterStrings(string[] inputArray, int maxLength)
{
    int numberString = 0;
    for (int count = 0; count < inputArray.Length; count++)
    {
        if (inputArray[count].Length <= maxLength)
        {
            numberString++;
        }
    }
    string[] outputArray = new string[numberString];
    int positionInput = 0;
    for (int count = 0; count < numberString; count++)
    {
        while (inputArray[positionInput].Length > maxLength)
        {
            positionInput++;
        }
        outputArray[count] = inputArray[positionInput++];
    }
    return outputArray;
}

string[] initialArray = new string[] { "Monday", "Tuesday", "Wed", "Thu", "Friday", "Saturday", "Sun", "12," };
int maxLength = 3;
string[] newArray = FindShorterStrings(initialArray, maxLength);
PrintArray(newArray);



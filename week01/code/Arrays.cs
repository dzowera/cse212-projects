public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // step 1 is to create an array with size of the length
        double[] myArray = new double[length];

        // use loop to fill up the multiples of the number
        for (int i = 0; i < length; i++)
        {
            myArray[i] = number * (i + 1);
        }

        return myArray; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // first get the number of the data inside the list
        int size = data.Count();

        // check is amount is not greater than the size

        amount = amount % size;

        // we need to create an empty list so we cas store results
        List<int> reverseList = new List<int>();

        // add the numbers which are to the end of the list

        for (int i = size - amount; i < size; i++)
        {
            reverseList.Add(data[i]);
        }

        // add the rest to the end

        for (int i = 0; i < size - amount; i++)
        {
            reverseList.Add(data[i]);
        }

        // copy the data to the original list

        for (int i = 0; i < size; i++)
        {
            data[i] = reverseList[i];
        }
    }
}

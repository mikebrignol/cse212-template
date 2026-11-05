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
        // PLAN
        // 1: Create a new double array with the requested length
        // 2: Loop through each index of the array, starting from bracket 0
        // 3: For each index, calculate the multiple  by multiplying the supplied number by (index + 1)
        // 4: Store the calculated multiple at the current index
        // 5: Return the completed array

        double[] multiples = new double[length];
        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples; // replace this return statement with your own
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
        // PLAN
        // 1: Determine the index where the last elements begin
        // 2: Create a new list containing the last 'amount' elements
        // 3: Create a new list containing all elements before that index
        // 4: Clear the original list
        // 5: Add the last elements to the original list
        // 6: Add the first elements to the original list

        int splitIndex = data.Count - amount;
        List<int> lastPart = data.GetRange(splitIndex, amount);
        List<int> firstPart = data.GetRange(0, splitIndex);

        data.Clear();

        data.AddRange(lastPart);
        data.AddRange(firstPart);
    }
}

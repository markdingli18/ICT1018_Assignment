namespace DS
{
    public static class Sorting
    {
        //Shell Sort funcction.     
        public static void ShellSort(ref int[] arr, int n)
        {
            int i, j, pos, temp;
            pos = 3;
            while (pos > 0)
            {
                for (i = 0; i < n; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= pos) && (arr[j - pos] > temp))
                    {
                        arr[j] = arr[j - pos];
                        j = j - pos;
                    }
                    arr[j] = temp;
                }
                if (pos / 2 != 0)
                {
                    pos = pos / 2;
                }
                else if (pos == 1)
                { pos = 0; }
                else
                { pos = 1; }
            }
        }

        // Method receiving the array to sort and two integer parameters
        //Quick Sort funcction.
        public static void QuickSorting(ref int[] numbersArray, int lowestVal, int highestVal)
        {
            //Nothing to sort. The array is already sorted. Therefore nothing is returned.
            if (highestVal - lowestVal < 1)
            {
                return;
            }

            // The low integer parameter is being stored in an integer called left
            int left = lowestVal;

            // The high integer parameter is being stored in an integer called right
            int right = highestVal;

            // An integer variable called pivot is being assigned the array value of left
            // This means that the starting point will be from the left-most element
            int pivot = numbersArray[left];

            // A while-loop that will loop while the left value is less or equal to the right value
            while (left <= right)
            {

                // A while-loop that will loop to increase the left value while the left is less than the pivot
                while (numbersArray[left] < pivot)
                {
                    // Left value being increased by 1
                    left++;
                }

                // A while-loop that will loop to decrease the right value while the right is greater than the pivot
                while (numbersArray[right] > pivot)
                {
                    // Right value being decreased by 1
                    right--;
                }

                // If loop condition to check whether the left value is smaller or equal to the right value
                if (left <= right)
                {
                    // The left value is smaller or equal to the right value

                    // Calling the element swapping method to sort out the array
                    SwappingTheElements(ref numbersArray, left, right);

                    // Left value is being increased by 1
                    left++;

                    // Right value is being decreased by 1
                    right--;
                }
            }

            // Sorting using small values
            QuickSorting(ref numbersArray, lowestVal, right);

            // Sorting using big values
            QuickSorting(ref numbersArray, left, highestVal);
        }

        // Swapping the passed in elements using the array passed
        public static void SwappingTheElements(ref int[] numbersArray, int firstElement, int secondElement)
        {
            //Assigning the element A in the array in an integer variable
            int storeFirstElement = numbersArray[firstElement];

            //Assigning the secondElement to the firstElement
            numbersArray[firstElement] = numbersArray[secondElement];

            //Assigning the firstElement from the momentary storage into the secondElement
            numbersArray[secondElement] = storeFirstElement;
        }

        //Function to merge arrays
        public static int[] MergeArrays(int[] arrayA, int[] arrayB)
        {
            int[] arrayResult = new int[arrayA.Length + arrayB.Length];
            //index for result
            int n = 0;
            //index for arrayA
            int i = 0;
            //index for arrayB
            int j = 0;

            //until any one of arrays all elements are traversed
            while (i < arrayA.Length && j < arrayB.Length)
            {
                //comparing items of arrayA and arrayB
                if (arrayA[i] < arrayB[j])
                {
                    //inserting arrayA item since it is lower
                    arrayResult[n] = arrayA[i];
                    //incrementing i, because arrayA's item is traversed
                    i++;
                }
                else
                {
                    arrayResult[n] = arrayB[j];
                    j++;
                }
                //incrementing since one item has been inserted to result array
                n++;
            }
            //if any elements are left in arrayA, simply inserting all to result
            while (i < arrayA.Length)
            {
                arrayResult[n] = arrayA[i];
                i++;
                n++;
            }
            //if any elements are left in arrayB, simply inserting all to result
            while (j < arrayB.Length)
            {
                arrayResult[n] = arrayB[j];
                j++;
                n++;
            }

            return arrayResult;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAFESA_Enrolment_System.Model
{
    public class Utility
    {
        /*
         * Psuedocode for Sequential Search
         * 
         * foundAt = -1, counter = 0
         * 
         * Loop until foundAt is not -1 or counter is end of array length
         *      if target is found
         *          foundAt = counter
         *      increment counter
         * 
         * return foundAt
         */

        /// <summary>
        /// A generic method to perform sequential search.
        /// </summary>
        /// <typeparam name="T"> Generic Type </typeparam>
        /// <param name="array"> Array on which search is performed </param>
        /// <param name="target"> Target that is searched for </param>
        /// <returns>
        /// If target is found, returns the index at which it is found.
        /// Else, returns -1.
        /// </returns>
        public static int LinearSearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            // Variable to store the index at which target is found. -1, if not found
            int foundAt = -1, i = 0;

            // Loop until we found target or we are out of bounds of array
            while (foundAt == -1 && i < array.Length)
            {
                // If target is equal to array[i]
                if (target.CompareTo(array[i]) == 0)
                    foundAt = i;
                i++;
            }

            return foundAt;
        }

        /*
         * Psuedocode for Binary Search
         * 
         * min = 0, max = array length - 1
         * 
         * Loop as long as min <= max
         *      mid = average of min and max
         *      if target is in the middle
         *          return mid
         *      else if target is in the lower half
         *          max = mid - 1
         *      else target is in the upper half
         *          min = mid + 1
         * 
         * return -1
         */

        /// <summary>
        /// A generic method to perform binary search.
        /// </summary>
        /// <typeparam name="T"> Generic Type </typeparam>
        /// <param name="array"> Array on which search is performed </param>
        /// <param name="target"> Target that is searched for </param>
        /// <returns>
        /// If target is found, returns the index at which it is found.
        /// Else, returns -1.
        /// </returns>
        public static int BinarySearchArray<T>(T[] array, T target) where T : IComparable<T>
        {
            // Variables for storing min, mid, and max indices of each iteration
            int min = 0, mid, max = array.Length - 1;

            // Sort array to perform binary search
            Array.Sort(array);

            // Loop till we are out of bounds of array
            while (min <= max)
            {
                mid = (min + max) / 2;

                // Target is at the middle
                if (target.CompareTo(array[mid]) == 0)
                    return mid;

                // Target is in the lower half
                else if (target.CompareTo(array[mid]) < 0)
                    max = mid - 1;

                // Target is in the upper half
                else
                    min = mid + 1;
            }

            // If target is not found after looping through entire array
            return -1;
        }


        /*
         * Psuedocode for Selection Sort in Ascending Order
         * 
         * Variable for storing index of minimum element
         * 
         * Loop through array
         *      First element as the minimum element
         *      Loop through array starting from the element after the current element
         *          if current element is less than minimum element
         *              Index of minimum element as current index
         *      
         *      Swap the element at current element with element at minimum index
         */

        /// <summary>
        /// A generic method to perform selection sort in ascending order
        /// </summary>
        /// <typeparam name="T"> Generic Type </typeparam>
        /// <param name="myArray"> Array to be sorted </param>
        public static void SelectionSortAsc<T>(T[] myArray) where T : IComparable<T>
        {
            // Temporary variable
            T temp;
            // To store the index of the minimum element
            int minIndex;

            // Looping through the array
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                // Starting with considering the first element as the minimum element
                minIndex = i;

                // Looping from the element after the current element
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    // Comparing if the current element is less than minimum element
                    if (myArray[j].CompareTo(myArray[minIndex]) < 0)
                    {
                        // Current index is stored as the index of minimum element
                        minIndex = j;
                    }
                }

                // swap smallest element (at index min) with current element
                temp = myArray[minIndex];
                myArray[minIndex] = myArray[i];
                myArray[i] = temp;
            }
        }


        /*
         * Psuedocode for Selection Sort in Descending Order
         * 
         * Variable for storing index of maximum element
         * 
         * Loop through array
         *      First element as the maximum element
         *      Loop through array starting from the element after the current element
         *          if current element is greater than maximum element
         *              Index of maximum element as current index
         *      
         *      Swap the element at current element with element at maximum index
         */

        /// <summary>
        /// A generic method to perform selection sort in descending order
        /// </summary>
        /// <typeparam name="T"> Generic Type </typeparam>
        /// <param name="myArray"> Array to be sorted </param>
        public static void SelectionSortDesc<T>(T[] myArray) where T : IComparable<T>
        {
            // Temporary variable
            T temp;
            // To store the index of the maximum element
            int maxIndex;

            // Looping through the array
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                // Starting with considering the first element as the maximum element
                maxIndex = i;

                // Looping from the element after the current element
                for (int j = i + 1; j < myArray.Length; j++)
                {
                    // Comparing if the current element is greater than maximum element
                    if (myArray[j].CompareTo(myArray[maxIndex]) > 0)
                    {
                        // Current index is stored as the index of maximum element
                        maxIndex = j;
                    }
                }

                // swap largest element (at index max) with current element
                temp = myArray[maxIndex];
                myArray[maxIndex] = myArray[i];
                myArray[i] = temp;
            }
        }

        /*
         * Psuedocode for Bubble Sort in Descending Order
         * 
         * Variable for storing index of minimum element
         * 
         * Loop through array
         *      Loop through the unsorted portion of the array
         *          if current element is less than the next element
         *              Swap current element with the next
         

        /// <summary>
        /// A generic method to perform bubble sort in descending order
        /// </summary>
        /// <typeparam name="T"> Generic Type </typeparam>
        /// <param name="myArray"> Array to be sorted </param>
        public static void BubbleSortDesc<T>(T[] myArray) where T : IComparable<T>
        {
            // Temporary variable
            T temp;

            // Looping through the array
            for (int i = 0; i < myArray.Length - 1; i++)
            {
                // Looping through the array till the unsorted portion
                for (int j = 0; j < myArray.Length - 1 - i; j++)
                {
                    // Comparing if the current element is less than the next element to its right
                    if (myArray[j].CompareTo(myArray[j + 1]) < 0)
                    {
                        // Swap current element with its next
                        temp = myArray[j];
                        myArray[j] = myArray[j + 1];
                        myArray[j + 1] = temp;
                    }
                }
            }
        }
        */
        /*
        public static void DisplayArrayElements<T>(T[] myArray) where T: IComparable<T> 
        {
            // Populating studentArray
            for (int i = 0; i < myArray.Length; i++)
            {              
                Console.WriteLine("Student object at index {0} - ID: {1}", i, myArray[i]);
            }
        }
        */
    }
}

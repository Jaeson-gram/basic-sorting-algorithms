namespace Basic_Sorting_Algorithms
{
    class ArrayClass
    {
        //member variables, encapsulated
        private int[] arr;
        private int upperBound;
        private int elementsPosition;
        public ArrayClass(int size)
        {
            //Constructing the member variables
            arr = new int[size];
            upperBound = size - 1;
            elementsPosition = 0;
        }

        //To Add An Element To the Array
        public void Insert(int item)
        {
            //the new item is added to the position where the array starts initially, 0,
            //then the position is incremented by 1, then a new element is added at position 1, and so on

            arr[elementsPosition] = item;
            elementsPosition++;
        }

        //To Display The Elements In The Array
        public void DisplayElements()
        {
            for (int i = 0; i <= upperBound; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        //TO Insert An Item At A Certain Position
        public void insertAt(int index, int item)
        {
            //place the new item at the given index
            arr[index] = item;
        }

        //To Clear The Array
        public void Clear()
        {
            //for (int i = 0; i <= upperBound; i++)
            //    arr[i] = 0;
            //elementsPosition = 0;

            //for each item in the array, make the value 0, which is the default for an integer,
            //then reset the position.
            foreach (int item in arr)
            {
                arr[item] = 0;
                elementsPosition = 0;
            }
        }




        public void bubbleSort()
        {
            /*
            *           BUBBLE SORT:
                        The first sorting algorithm to examine is the bubble sort. The bubble sort is
                        one of the slowest sorting algorithms available, but it is also one of the simplest
                        sorts to understand and implement, which makes it an excellent candidate
                        for our first sorting algorithm.
                        The sort gets its name because values “float like a bubble” from one end of
                        the list to another. Assuming you are sorting a list of numbers in ascending
                        order, higher values float to the right whereas lower values float to the left.
                        This behavior is caused by moving through the list many times, comparing
                        adjacent values and swapping them if the value to the left is greater than the
                        value to the right.
            */


            int temporaryStorage;

            //the first loop.. loop through for the number of times as there are elementsPosition in the array.                 
            //for an array we did not create, the upperbound will be (array.Length - 1)
            for (int outer = upperBound; outer >= 1; outer--)
            {
                //and each time, loop through the whole array. so if there are 10 elements, loop 10x10 times. Just so no number is missed
                //ie. Completely loop to be sure that no number is left behind
                for (int inner = 0; inner <= outer - 1; inner++)
                {
                    //if the element in the previous position (from left) is greater than the one in the following position, swith them, so the smaller one come to the left
                    if ((int)arr[inner] > arr[inner + 1])
                    {
                        //temporarily store the greater number - so that we can safely use the smaller number to take its place.
                        temporaryStorage = arr[inner];

                        //let the smaller number take the place where the larger number was at
                        arr[inner] = arr[inner + 1];

                        //finally, fill the position that had the lesser number with the number you've stored in the temporary storage, which is the greater number. And keep switching 
                        //and each time, loop through the whole array. so if there are 10 elementsPosition, loop 10x10 times. Just so no number is missed
                        arr[inner + 1] = temporaryStorage;
                        /*
                                                To put it in perspective, imagine you had 3 buckets, one has an orange juice [inner], one a banana and milk juice[outer], and the other one empty[temporaryStorage]
                                                to switch the positions of the juices, you'll have to pour one juice - in our case the orange juice - in the empty cup, 
                                                then the banana x milk juice in the cup that had the orange juice, then the orange juice in the now available (empty) banana x milk juice cup
                                                that's like what we did above.
                         */
                    }
                }

                //our ArrayClass DisplayElements come in handy
                this.DisplayElements();
            }
        }

        public void selectionSort()
        {
            /*          
             *          The next sort to examine is the Selection sort. This sort works by starting at
             *          the beginning of the array, comparing the first element with the other elements
             *          in the array. The smallest element is placed in position 0, and the sort then
             *          begins again at position 1. This continues until each position except the last
             *          position has been the starting point for a new loop

             *          Two loops are used in the SelectionSort algorithm. The outer loop moves
             *          from the first element in the array to the next, and to last element, 
             *          pointing at each position where it stands as the starting point for comparison, 
             *          whereas the inner loop moves from the second element of the array to the last element, 
             *          looking for values that are smaller than the element currently being pointed at by the
             *          outer loop. After each iteration of the inner loop, the most minimum value
             *          in the array is assigned to its proper place in the array (the position where the outer loop currently is)
            */

            //2 variables to store our numbers and work with
            int minNumber, temporaryStorage;

            //loop through the array - outer loop
            for (int previousIndex = 0; previousIndex <= upperBound; previousIndex++)
            {
                //store the first number [number at index 0] in the var that should hold the smallest number. It initially is our smallest.
                minNumber = previousIndex;

                //make another loop, to monitor the number in front of our minimum number - inner loop
                for (int nextIndex = (previousIndex + 1); nextIndex <= upperBound; nextIndex++)
                {
                    //if the number in the position in front of our minimumNumber var is smaller than the number in our minimunNumber var,
                    //which is the number in the previousIndex
                    if (arr[nextIndex] < arr[minNumber])
                    {
                        //make the minimumNumber value the number in front of it, so we can use the number in that index 
                        minNumber = nextIndex;
                    }

                    /*                  switch the numbers, make the number in the previousIndex be the number it found smaller as NextIndex moved through
                                        (NOTE: We have now made the minNumber var be equal to the temporaryStorage, which holds the index where we initially started
                                        so that we don't have to alter the nextIndex as we move through the loop, it'll always start in front of our starting index, which will, after
                                        this loop, move up an index)*/
                    temporaryStorage = arr[previousIndex];

                    arr[previousIndex] = arr[minNumber];
                    arr[minNumber] = temporaryStorage;
                }

                this.DisplayElements();
            }




        }


        public void insertionSort()
        {

            /*          INSERTION SORT
             *          The Insertion sort is an analog to the way we normally sort things numerically
             *          or alphabetically. Let’s say that I have asked a class of students to turn in index
             *          card with their names, id numbers, and a short biographical sketch.The
             *          students return the cards in random order, but I want them to be alphabetized
             *          so I can build a seating chart.
             *          I take the cards back to my office, clear off my desk, and take the first card.
             *          The name on the card is Smith. I place it at the top left position of the desk
             *          and take the second card. It is Brown. I move Smith over to the right and
             *          put Brown in Smith’s place. The next card is Williams. It can be inserted at
             *          the right without having to shift any other cards. The next card is Acklin.
             *          It has to go at the beginning of the list, so each of the other cards must be
             *          shifted one position to the right to make room. That is how the Insertion sort works
            */

            //2 helper variables
            int inner, temporaryStorage;

            //loop through the array
            for (int outer = 0; outer <= upperBound; outer++)
            {
                //assign the remporary storage to the value of the current index in the loop, and the index should be assigned too too(inner = outer)

                temporaryStorage = arr[outer];
                inner = outer;

                //while the loop is 1 or above and the value in the index behind it is higher than the value in temporaryStorage where we store the current value
                //(which should be the same position where it is)
                while (inner > 0 && arr[inner - 1] >= temporaryStorage)
                {
                    //change it's value to the value of the index behind it, (and take it back one step so we can redo the comparison from the previous index)
                    arr[inner] = arr[inner - 1];
                    inner--;
                }

                //reset the value of the arrayValue at innerIndex to the former number since we've now replaced it with a new number.. 
                //since we changed its number to the one before it, we now give the one after it the number it had before, which the temporaryStorage holds
                arr[inner] = temporaryStorage;
                this.DisplayElements();
            }
            //then the code loops again, and so for all elements
        }
    }


}

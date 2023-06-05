namespace Basic_Sorting_Algorithms
{

    //WE NEED THIS CLASS TO STORE THE DATA WE ARE GOING TO BE SORTING
    //WE'LL ALSO NEED TO MAKE THE DATA RANDOM - IN ORDER TO DEMONSTRATE MOST EFFECTIVELY HOW THE DIFFERENTSORTING ALGORITHMS WORK
    //SO THAT OUR SORTING WILL BE REQUIRED, SO WE'LL BE ADDING THE RANDOM CLASS

    public class Program
    {
        static void Main(string[] args)
        {
            ArrayClass numbers = new ArrayClass(10);
            Random randomGenerator = new Random(100);

            for (int i = 0; i < 10; i++)
            {
                numbers.Insert((int)(randomGenerator.NextDouble() * 100));
            }
            //console.writeline("before bubble sort:");
            //numbers.displayelements();

            //console.writeline("\nduring (bubble) sort:");
            //numbers.bubblesort();

            //console.writeline("\nafter sort:");
            //numbers.displayelements();

            //console.writeline();
            //console.writeline();

            //Console.WriteLine("BEFORE SELECCTION SORT:");
            //numbers.DisplayElements();

            //Console.WriteLine("\nDURING (SELECTION) SORT:");
            //numbers.selectionSort();

            //Console.WriteLine("\nAFTER SORT:");
            //numbers.DisplayElements();

            //console.writeline();
            //console.writeline();

            Console.WriteLine("BEFORE INSERTION SORT:");
            numbers.DisplayElements();

            Console.WriteLine("\nDURING (INSERTION) SORT:");
            numbers.insertionSort();

            Console.WriteLine("\nAFTER SORT:");
            numbers.DisplayElements();
        }

    }
}
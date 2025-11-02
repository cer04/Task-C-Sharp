//when u want to run a prgrem remove the /**/ after the start and befor the end 
// have a good read 


//first qustion 
//calculates the average of all elements in an array,
//then prints only the numbers greater than the average.

//*************Start******************
/*using System.Linq;

Console.Write("enter the number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"enter number {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

double average = numbers.Average();
Console.WriteLine($"Average = {average}");

Console.WriteLine($"numbers greater than {average} :");
foreach (var num in numbers.Where(n => n > average))
{
    Console.WriteLine(num);
}


*/

//*************end******************



//2nd qustion 
// print numbers in reverse order.
//*************start******************

/*
Console.Write("enter the number of elements: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] numbers = new int[size];

for (int i = 0; i < size; i++)
{
    Console.Write($"Enter number {i + 1}: ");
    numbers[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("numbers in reverse order:");
for (int i = size - 1; i >= 0; i--)
{
    Console.WriteLine(numbers[i]);
}
*/

//*************end******************




//3rd qustion 
//first non repated chars in  a str
//*************Start******************
/*
Console.Write("Enter a string: ");
string input = Console.ReadLine();

foreach (char c in input)
{
    if (input.Count(x => x == c) == 1)
    {
        Console.WriteLine($"the character that has not been repeated is: {c}");
        break;
    }
}

*/
//*************end******************
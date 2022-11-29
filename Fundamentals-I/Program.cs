// 1. Create a loop that prints all values from 1-255.

for(int i = 1; i <= 255; i++)
{
    System.Console.WriteLine(i);
}

// 2. Create a new loop that generates 5 random numbers between 10 and 20
// and print out the sum of these values

Random randNum = new Random();
int sum = 0;

for(int i = 1; i <= 5; i++)
{
    sum += randNum.Next(10, 20);
}
System.Console.WriteLine(sum);

// 3. Create a new loop that prints all values from 1 to 100 that are divisible
// by 3 OR 5, but NOT both

for (int i = 1; i <= 100; i++)
{
    if (i % 3 == 0 || i % 5 == 0)
    {
        System.Console.WriteLine(i);
    }
}

// 4. Modify the previous loop to print "Fizz" for multiples of 3 and "Buzz"
// for multiples of 5

for (int i = 1; i <= 100; i++)
{
    if (i % 15 != 0)
    {    
        if (i % 3 == 0)
        {
            System.Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            System.Console.WriteLine("Buzz");
        }
        else
        {
            System.Console.WriteLine(i);
        }
    }
}

// 5. Modify the previous loop once more to now also print "FizzBuzz" for numbers
// that are multiples of both 3 and 5 

for (int i = 1; i <= 100; i++)
{
    if (i % 15 != 0)
    {    
        if (i % 3 == 0)
        {
            System.Console.WriteLine("Fizz");
        }
        else if (i % 5 == 0)
        {
            System.Console.WriteLine("Buzz");
        }
        else
        {
            System.Console.WriteLine(i);
        }
    }
    else
    {
        System.Console.WriteLine("FizzBuzz");
    } 
}
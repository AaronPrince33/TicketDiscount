int normalPrice = 50000, discount = 0, lastPrice = 0, levelUp = 0;
string inputDay;
int inputAge;

Console.Write("Input the day (Monday-Sunday): ");
inputDay = Console.ReadLine();

Console.Write("Input your age: ");
inputAge = int.Parse(Console.ReadLine());

if(inputDay == "Saturday" || inputDay == "Sunday")
{
    levelUp = 10000;
}

if(inputAge < 12 || inputAge > 60)
{
    discount = 10000;
}

lastPrice = normalPrice + levelUp -  discount;

Console.WriteLine($"The Last Price is Rp {lastPrice}");
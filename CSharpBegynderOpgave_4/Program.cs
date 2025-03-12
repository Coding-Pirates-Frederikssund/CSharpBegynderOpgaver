//Opgradér spillet fra Opgave_3 med et Loop sådan at man får flere forsøg når man gætter forkert

int input = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(input + 5);

if(input == 2)
{
	Console.WriteLine("Inputtet er = 2");
}


Console.ReadKey();























//Eksempel på while loop
int tæller = 0;
while (tæller < 20)
{
	Console.WriteLine(tæller);
	if (tæller == 3)
	{
		Console.WriteLine("Tallet er " + 3);
	}
}

while (true)
{
	Console.WriteLine();


}












//While loop der tæller til 10
int counter = 0;
while(counter <= 3)
{
	Console.WriteLine(counter);
	counter++;

	if(counter == 5001)
	{
		break;
	}
}
Console.ReadKey();

//Console.ReadKey();
//Console.WriteLine("");

//Eksempel på for loop
//for(int i = 2; i < 10; i += 7)
//{
//	Console.WriteLine(i);
//}
//Console.ReadKey();




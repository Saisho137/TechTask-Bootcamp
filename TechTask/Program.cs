
//Dot A coordinates 
Console.WriteLine("\nEnter coordinate x and y split by a \",\" of Dot A: ");
string[] dotA = Console.ReadLine().Split(',');
//Validation A
while (dotA.Length != 2 || !double.TryParse(dotA[0], out double x1) || !double.TryParse(dotA[1], out double y1) ) {
    Console.WriteLine("Invalid Input, try again");
    dotA = Console.ReadLine().Split(',');
}

//Dot B coordinates 
Console.WriteLine("\nEnter coordinate x and y split by a \",\" of Dot B: ");
string[] dotB = Console.ReadLine().Split(',');
//Validation B
while (dotB.Length != 2 || !double.TryParse(dotB[0], out double x2) || !double.TryParse(dotB[1], out double y2) ) {
    Console.WriteLine("Invalid Input, try again");
    dotB = Console.ReadLine().Split(',');
}

//Dot C coordinates 
Console.WriteLine("\nEnter coordinate x and y split by a \",\" of Dot A: ");
string[] dotC = Console.ReadLine().Split(',');
//Validation C
while (dotC.Length != 2 || !double.TryParse(dotC[0], out double x3) || !double.TryParse(dotC[1], out double y3) ) {
    Console.WriteLine("Invalid Input, try again");
    dotC = Console.ReadLine().Split(',');
}

//string [0: x, 1: y]

//Lenght of Triangle Sides
double lenghtAB = Math.Sqrt( Math.Pow( double.Parse(dotB[0]) - double.Parse(dotA[0] ), 2) 
    + Math.Pow(double.Parse(dotB[1]) - double.Parse(dotA[1]), 2) );
//
double lenghtBC = Math.Sqrt( Math.Pow(double.Parse(dotC[0]) - double.Parse(dotB[0]), 2)
    + Math.Pow(double.Parse(dotC[1]) - double.Parse(dotB[1]), 2) );
//
double lenghtCA = Math.Sqrt( Math.Pow(double.Parse(dotA[0]) - double.Parse(dotC[0]), 2)
    + Math.Pow(double.Parse(dotA[1]) - double.Parse(dotC[1]), 2) );
//
Console.WriteLine( "\nLenght of AB is: " + lenghtAB + " \nLenght of BC is: " + lenghtBC + " \nLenght of CA is: " + lenghtCA );

//Triangle Type

//Equilateral
if (lenghtAB == lenghtBC && lenghtBC == lenghtCA)
{
    Console.WriteLine("\nTRIANGLE IS \"Equilateral\"");
}
else { Console.WriteLine("\nTRIANGLE IS NOT \"Equilateral\""); }

//Isosceles
if (lenghtAB == lenghtBC || lenghtBC == lenghtCA || lenghtCA == lenghtAB)
{
    Console.WriteLine("\nTRIANGLE IS \"Isosceles\"");
}
else { Console.WriteLine("\nTRIANGLE IS NOT \"Isosceles\""); }

//Right
double delta = 0.0000001;//Precision range

if (Math.Pow(lenghtAB, 2) - Math.Pow(lenghtBC, 2) + Math.Pow(lenghtCA, 2) <= delta ||
    Math.Pow(lenghtBC, 2) - Math.Pow(lenghtAB, 2) + Math.Pow(lenghtCA, 2) <= delta ||
    Math.Pow(lenghtCA, 2) - Math.Pow(lenghtBC, 2) + Math.Pow(lenghtAB, 2) <= delta )
{
    Console.WriteLine("\nTRIANGLE IS \"Right\"");
} 
else { Console.WriteLine("\nTRIANGLE IS NOT \"Right\""); }

//Triangle perimeter
double perimeter = lenghtAB + lenghtBC + lenghtCA;
Console.WriteLine("\nPerimeter: \'" + perimeter + "\'\n");

//Even Numbers from 0 to Triangle perimeter
for ( int i = 0; i < perimeter; i += 2 )
{
    if ( perimeter - i > 2)
    {
        Console.Write( i + ", " );
    } else { Console.Write( i + "\n" );}
}
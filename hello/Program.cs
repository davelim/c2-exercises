// Input/Output
Console.WriteLine("What is your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello " + name);

// Numeric Types
double length, width, area;
Console.WriteLine("Enter length of rectangle: ");
length = double.Parse(Console.ReadLine());
Console.WriteLine("Enter width of rectangle: ");
width = double.Parse(Console.ReadLine());
area = length * width;
Console.WriteLine("Area of a " + length + " x " + width + " rectangle is " + area);

// More on Numeric Types
double miles, galons, MPG;
Console.WriteLine("Enter number of miles driven: ");
miles = double.Parse(Console.ReadLine());
Console.WriteLine("Enter gas consumed: ");
galons = double.Parse(Console.ReadLine());
MPG = miles / galons;
Console.WriteLine("Miles-per-gallon: " + MPG);

// Strings
string aliceStr = @"Alice was beginning to get very tired of sitting by her sister on the
bank, and of having nothing to do: once or twice she had peeped into the
book her sister was reading, but it had no pictures or conversations in
it, 'and what is the use of a book,' thought Alice 'without pictures or
conversation?'";
Console.WriteLine("Enter search term: ");
string searchStr = Console.ReadLine();
int idx = aliceStr.ToLower().IndexOf(searchStr.ToLower());
if (idx != -1) {
    Console.WriteLine($"Found '{searchStr}' of length {searchStr.Length} @ index {idx}.");
} else {
    Console.WriteLine($"Could not find '{searchStr}'.");
}
aliceStr = aliceStr.Remove(idx, searchStr.Length+1);
Console.WriteLine($"New string...\n{aliceStr}");
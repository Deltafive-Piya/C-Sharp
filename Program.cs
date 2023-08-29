Console.WriteLine("Fundamentals II Assignment");
Console.WriteLine();
//Three Basic Arrays---------------------------------------------------
// Create an integer array with the values 0 through 9 inside.
Console.WriteLine("1. Create 0-9 array: ");
int[] ArrayToTen = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

foreach (int each in ArrayToTen)
{
    Console.WriteLine(each);
}
Console.WriteLine();

// Create a string array with the names "Tim", "Martin", "Nikki", and "Sara".
Console.WriteLine("2. Create 4-name array: ");
string[] ArrayofFourNames = { "Tim", "Martin", "Nikki", "Sara" };

foreach (string each in ArrayofFourNames)
{
    Console.WriteLine(each);
}
Console.WriteLine();

// Create a boolean array of length 10. Then fill it with alternating true/false values, starting with true. (Tip: do this using logic! Do not hard-code the values in!)
Console.WriteLine("3. 10-alternating-boolean array: ");
bool[] TenBoolArray = new bool[10];

for (int each = 0; each < TenBoolArray.Length; each++)
{
    TenBoolArray[each] = each % 2 == 0; //counter modulo 2
}

foreach (bool ToF in TenBoolArray)
{
    Console.WriteLine(ToF);
}
Console.WriteLine();


//List of Flavors---------------------------------------------------
//Ice Cream Flavor Array
Console.WriteLine("4. Ice Cream List: ");
List<string> ICFlavors = new List<string>
{
    "Strawberry Cheesecake","Earl Grey","Moose Tracks","Birthday Cake","Butter Pecan","Peach Cobbler","Ube Sandaagii"
};

for (int i = 0; i < ICFlavors.Count; i++)
{
    Console.WriteLine($"Scoop[{i + 1}] = {ICFlavors[i]}");
}
Console.WriteLine();

// Output List Count
Console.WriteLine("5. Ice Cream Flavors Count: ");

Console.WriteLine($"We have a total of {ICFlavors.Count} flavors to chose from.");
Console.WriteLine();

// Output [2] in the List.
Console.WriteLine("6. Ice Cream Pick (3rd choice): ");
Console.WriteLine($"You have chosen: {ICFlavors[2]}");
Console.WriteLine();

// Now remove the third flavor using its index location.
Console.WriteLine("7. Removal of index target index [2]: ");
int IndexDeleteTarget = 2;
Console.WriteLine($"We will be removing '{ICFlavors[2]}'");
ICFlavors.RemoveAt(IndexDeleteTarget);
for (int i = 0; i < ICFlavors.Count; i++)
{
    Console.WriteLine($"Scoop[{i + 1}] = {ICFlavors[i]}");
}
Console.WriteLine();

// Output the length of the List again. It should now be one fewer.
Console.WriteLine("8. Show New ICFlavors Count: ");
Console.WriteLine($"Updated... We now have a total of {ICFlavors.Count} flavors to chose from.");


//User Dictionary---------------------------------------------------

// Create a dictionary that will store string keys and string values.


// Add key/value pairs to the dictionary where:


    // Each key is a name from your names array (this can be done by hand or using logic)


    // Each value is a randomly selected flavor from your flavors List (remember Random from earlier?)


// Loop through the dictionary and print out each user's name and their associated ice cream flavor.
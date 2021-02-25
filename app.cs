string aFriend = "John Doe";
Console.WriteLine("This also works " + aFriend);

// String Interpolation implemented.

Console.WriteLine($"The Name '{aFriend}' has {aFriend.Length} Number of characters");

// trimming here we go.
string an = "   This is My other string ";
Console.WriteLine($"[{an}]"); // don't know why this doesnt do the trimm trick here.

string trimmedGreeting = an.TrimStart();
Console.WriteLine(trimmedGreeting);

// Trim the trailing space at the end of the string.
trimmedGreeting = an.TrimEnd();
Console.WriteLine(trimmedGreeting);

// Trim from both start and end.
trimmedGreeting = an.Trim();
Console.WriteLine(trimmedGreeting);

// String Replace.
Console.WriteLine(an.Replace("other", "ANOTHER"));

// Let do a small conversion to upper case 
Console.WriteLine(an.ToUpper());

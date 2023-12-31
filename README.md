# NET.AI3
Repository for the .NET AI experiment

# Application Description
This application serves as a simple, yet effective string validator, which is implemented in a self-contained public class called StringValidator. The main functionality is provided by a static method, ValidateString, that allows developers to validate input strings against a specific pattern. This utility is designed to ensure string data meets certain security or formatting standards in a variety of application contexts, such as data validation, password strength checking, or pattern matching.

# Regex Implementation Description
The ValidateString method employs a regular expression, or regex, to determine if an input string matches a predefined pattern. The pattern used in this implementation requires that the string contains at least one lowercase letter, one uppercase letter, one digit, and one special character from a defined set. It also restricts the length of the string to a specified maximum. The regex pattern is constructed dynamically with the maximum length parameter to allow for flexibility. It uses positive lookaheads to ensure the existence of each required type of character, and it uses a negated whitespace character class to disallow any spaces within the string. The method Regex.IsMatch is then used to check whether the input string matches this pattern.

# Running the Application Locally
To run the developed application locally, follow these steps:

1) Ensure you have a compatible .NET environment installed on your local machine. If not, you can download and install the .NET SDK from Microsoft's official website.

2) Clone the repository containing the StringValidator class to your local machine.
git clone <repository_url>

3) Navigate into the directory of the cloned repository:
cd <directory_name>

4) Now, you can create a program to utilize the StringValidator class. A simple console application can be created for this purpose. Here's a sample program:

using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Enter a string to validate:");
        string input = Console.ReadLine();

        Console.WriteLine("Enter maximum length:");
        int maxLength = Convert.ToInt32(Console.ReadLine());

        bool result = StringValidator.ValidateString(input, maxLength);
        Console.WriteLine("Validation result: " + result);
    }
}

5) Finally, you can run your program with the .NET CLI:
dotnet run

Now you can test strings against the StringValidator's pattern right in your local environment!

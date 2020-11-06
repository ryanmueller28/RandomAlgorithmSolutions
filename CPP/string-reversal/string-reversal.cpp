#include <iostream>
#include <cstdlib>
#include <map>
#include <stack>
#include <string>
#include <cctype>

/**
 * 
 * @param - take an string to reverse
 * places special characters in a map
 * and everything in a stack
 * */
std::string ReverseString(std::string InString)
{
    std::string OutString = "";

    std::map<int, char> SpecialChars;

    std::stack<char> NormalChars;

    for (int i = 0; i < InString.length(); i++)
    {
        if (!isalnum(InString[i]))
        {
            SpecialChars.insert(std::pair<int, char>(i, InString[i]));
        }else
        {
            NormalChars.push(InString[i]);
        }
        
    }

    for (int i = 0; i < InString.length(); i++)
    {
        if (SpecialChars.count(i))
        {
            OutString += SpecialChars.at(i);
        }else
        {
            OutString += NormalChars.top();
            NormalChars.pop();
        }
        
    }

    return OutString;

}

int main(int argc, char** argv)
{
    std::string TestString;
    if (argc != 2)
    {
        std::cout << "The argument count is two!" << std::endl;
    }else
    {
        TestString = argv[1];
    }
    
    std::cout << ReverseString(TestString) << std::endl;

    return EXIT_SUCCESS;
}
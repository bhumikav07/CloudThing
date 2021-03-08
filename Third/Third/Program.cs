using System;

namespace Third
{
    class Program3
    {
        static void Main(string[] args)
        {
            string str , rev="";  
            Console.WriteLine("Enter string:");  
            str = Console.ReadLine();  
            for (int i = str.Length-1; i >=0; i--)  
            {  
                rev += str[i].ToString();  
            }  
            if (rev == str) 
            {  
                Console.WriteLine("The entered String is Palindrome \nEntered String was {0} and the Reverse of it is {1}", str, rev);  
            }  
            else  
            {  
                Console.WriteLine("The entered String is not Palindrome \nEntered String Was {0} and the Reverse of it is {1}", str, rev);  
            }
        }
    }
}
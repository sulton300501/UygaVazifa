
/*1-misol*/

/*using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string inputText = "Salom, elektron pochta manzili: user@example.com, telefon raqami: +998901234567. Yana bir pochta manzili: another.user@mail.com, telefon: 123-456-7890.";

        
        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        MatchCollection emailMatches = Regex.Matches(inputText, emailPattern);

        Console.WriteLine("Emaillar:");
        foreach (Match emailMatch in emailMatches)
        {
            Console.WriteLine(emailMatch.Value);
        }

        
        string phonePattern = @"\+?\d{1,3}?[-.●]?\(?\d{1,4}?\)?[-.●]?\d{1,5}[-.●]?\d{1,5}[-.●]?\d{1,9}";
        MatchCollection phoneMatches = Regex.Matches(inputText, phonePattern);

        Console.WriteLine("\nTelefon raqamlar:");
        foreach (Match phoneMatch in phoneMatches)
        {
            Console.WriteLine(phoneMatch.Value);
        }
    }
}
*/

/*1-misol*/



/*2-misol*/

/*
using System;
using System.Text.RegularExpressions;

class RegistrationValidator
{
    static void Main()
    {
        Console.WriteLine("Registratsiya uchun ma'lumotlarni kiriting:");

        Console.Write("Email: ");
        string email = Console.ReadLine();

        Console.Write("Telefon raqam: ");
        string phoneNumber = Console.ReadLine();

        Console.Write("Parol: ");
        string password = Console.ReadLine();

        Console.Write("Tug'ilgan sana (MM/DD/YYYY): ");
        string birthdate = Console.ReadLine();

        string emailPattern = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";
        if (!Regex.IsMatch(email, emailPattern))
        {
            Console.WriteLine("Noto'g'ri email formati!");
            return;
        }

        string phonePattern = @"\+998\d{9}";
        if (!Regex.IsMatch(phoneNumber, phonePattern))
        {
            Console.WriteLine("Noto'g'ri telefon raqami formati!");
            return;
        }

        string passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()+=_-{}[\]:;""'<>?,.]).{8,16}$";
        if (!Regex.IsMatch(password, passwordPattern))
        {
            Console.WriteLine("Noto'g'ri parol formati!");
            Console.WriteLine("Parol Uzunlik 8 dan 16 tagacha belgi. Kamida bitta kichik harf (az). Kamida bitta bosh harf (AZ). Kamida bitta raqam (0-9). Qo'llab-quvvatlanadigan maxsus belgilar: ! @ # $ % ^ & * () + = _ - {} []:; \" ' ? < > , .");
            return;
        }

        

        Console.WriteLine("Ma'lumotlaringiz muvaffaqiyatli tekshirildi! Registratsiya muvaffaqiyatli bajarildi.");
    }
}
*/

/*2-misol*/


/*3-misol*/

/*using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input1 = "AA@%^&CC";
        string result1 = RemoveSpecialCharacters(input1);
        Console.WriteLine($"Input: {input1}, Result: {result1}");

        string input2 = "Python";
        string result2 = RemoveSpecialCharacters(input2);
        Console.WriteLine($"Input: {input2}, Result: {result2}");

        string input3 = "w3resource.com";
        string result3 = RemoveSpecialCharacters(input3);
        Console.WriteLine($"Input: {input3}, Result: {result3}");
    }

    static string RemoveSpecialCharacters(string input)
    {
     
        string pattern = @"[^a-zA-Z0-9_\s]";
        string result = Regex.Replace(input, pattern, "");

        return result;
    }
}
*/

/*3-misol*/
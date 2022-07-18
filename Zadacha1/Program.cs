// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Первое решение

    // Console.WriteLine("Введите пятизначное число: ");
    // int number = Convert.ToInt32(Console.ReadLine());
    // int Number1 = number / 10000 % 10;
    // int Number2 = number / 1000 % 10;
    // int Number3 = number / 10 % 10;
    // int Number4 = number / 10000 % 10;
    // if (number <= 9999 || number > 99999)
    // {
    //     Console.WriteLine("Введено не пятизначное число");
    // }
    // else if (Number1 == Number4 && Number2 == Number3)
    // {
    //     Console.WriteLine("Число " + number + " является палиндромом");
    // }
    // else 
    // {
    //     Console.WriteLine("Число " + number + " не является палиндромом");
    // }

// Второе решение

// Console.WriteLine("Введите число: ");
// string number = Console.ReadLine();
// char[]arr = number.ToCharArray();
// Array.Reverse(arr);
// string number2 = new string(arr);
// if (number == number2)
// {
//     Console.WriteLine("Число " + number + " является палидромом");
// }
// else
// {
//     Console.WriteLine("Число " + number + " не является палидромом");
// }

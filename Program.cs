// // задание 1.1
// for (int i = 10; i >= 1; i--) {
//     Console.WriteLine(i);
// }
// // задание 1.2
// for (int i = 1; i <= 50; i++) {
//     if (i % 2 == 0) {
//         Console.WriteLine(i);
//     }
// }
// задание 2
// 
// Задание 3
// int number = Convert.ToInt32(Console.ReadLine());
// int positiveCount = 0;
// int negativeCount = 0;
// while (number != 0) {
//     if (number > 0) {
//         positiveCount++;
//     } else if (number < 0) {
//         negativeCount++;
//     }
//     number = Convert.ToInt32(Console.ReadLine());
// }
// Console.WriteLine($"Положительных чисел: {positiveCount}");
// Console.WriteLine($"Отрицательных чисел: {negativeCount}");
// Задание 4
// bool isUnlocked = false;
// for (int attempt = 1; attempt <= 3; attempt++) {
//     Console.Write("введите пароль: ");
//     string password = Console.ReadLine();
//     if (password == "qwerty") {
//         Console.WriteLine("доступ разрешён");
//         isUnlocked = true;
//         break;
//     }
// }
// if (!isUnlocked) {
//     Console.WriteLine("доступ заблокирован");
// }
// самостоятельные задания
// задание 5
// Console.Write("введите число от 1 до 9: ");
// int n = Convert.ToInt32(Console.ReadLine());
// for (int i = 1; i <= 10; i++) {
//     Console.WriteLine($"{n} x {i} = {n * i}");
// }
// Задание 6
// for (int i = 1; i <= 30; i++) {
//     if (i % 10 == 0 && i > 20) {
//         break;
//     }
//     if (i % 3 == 0) {
//         continue;
//     }
//     Console.WriteLine(i);
// }
// итоговая задача
int secret = 42;
bool isGuessed = false;
for (int attempt = 1; attempt <= 5; attempt++) {
    Console.Write($"попытка {attempt}. введите число: ");
    int guess = Convert.ToInt32(Console.ReadLine());

    if (guess == secret) {
        Console.WriteLine($"победа! попыток: {attempt}");
        isGuessed = true;
        break;
    } else if (guess < secret) {
        Console.WriteLine("больше");
    } else {
        Console.WriteLine("меньше");
    }
}

if (!isGuessed) {
    Console.WriteLine($"вы проиграли, число было {secret}");
}
// дополнительное задание
// Console.Write("введите целое положительное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int digitSum = 0;
// int digitCount = 0;
// while (num > 0) {
//     digitSum += num % 10;
//     digitCount++;
//     num /= 10;
// }
// Console.WriteLine($"сумма цифр: {digitSum}");
// Console.WriteLine($"количество цифр: {digitCount}");

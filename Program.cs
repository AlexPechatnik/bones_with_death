﻿// Intro
// Logo
// Press 1 start game
Console.WriteLine("___________________________LorGame________________________ ");
Console.WriteLine("Ты пробудился и застыл от ужаса. Твои глаза встретились с капюшоном, под которым угрожающе сверкали красные глаза. Эмоции настигли тебя, ты чувствовал страх, недоумение, отчаяние и неизбежность. Комната, в которой ты находился, погружена в мрачный мрак, редкие факелы, сиявшие на стенах, только подчеркивали угрюмость обстановки. В предательском холоде этого помещения, немая смерть медленно обернулась к тебе и настырно смотрела в глаза. Ты сидел за истлевшим от времени деревянным столом и, на минуту забыв, где ты находишься, погрузился в безысходность и отчаяние. Ты не знаешь, что происходит, почему ты находишься здесь со Смертью и что ждет тебя дальше. Но по неведомым причинам ты чувствуешь, неотвродимое.");
Console.WriteLine("______________________rules of the game____________________ ");
Console.WriteLine("Смерть: У тебя есть 3 очка, 3 добрых поступков, ты можешь сыграть со мной в игру, если победишь ты, я отпущу тебя и все что тут было ты забудешь как страшный сон, но если выйгрую я, твоя душа пойдет со мной, и да выбора у тебя нет");
int p = 3;// Ваши очки
int d = 3;// Очки смерти
int Count = 1;
Console.WriteLine("Смерть: Введи число от 1 до 6 и если твое число совпало с кубиком, +1 очко ");

while (p > 0)
{   
   
    
    Console.WriteLine($"___________________________________________________Бросок  {Count}");
    Console.WriteLine($"Игрок - {p} |||||||||||||| Смерть - {d} ");
    
    Console.Write("Выбери число ");
    int numA = int.Parse(Console.ReadLine());

    Random rnd = new Random();// Ставка смерти
    int numB = rnd.Next(1, 7);
    Console.WriteLine("Число смерти " + numB);
    Random rnc = new Random();// Кости
    int numC = rnc.Next(1, 7);
    Console.WriteLine("Кости " + numC);
    if (numA == numB)
    {
        Console.WriteLine("Смерть: хм... давай еще раз ");

    }
    if (numA == numC)
    {
        Console.WriteLine("Смерть: твоя взяла ");
        p = p + 1;
        d = d - 1;
        Console.WriteLine("Игрок " + p);
        Console.WriteLine("Смерть " + d);
    }
    if (numB == numC)
    {
        Console.WriteLine("Смерть: У ха ха ха... ");
        p = p - 1;
        d = d + 1;
        Console.WriteLine("Игрок " + p);
        Console.WriteLine("Смерть " + d);
    }   

    if (d == 0 )
    {
        Console.WriteLine("Смерть: Ты победил, и ты свободен, но помни, я всегда рядом...");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Вздрогнув, ты проснулся. Всматриваясь в окружение ты обнаружил, что заснул лицом на клваиатуре. Встав из-за компьютера ты подтянулся, жадно зевнул и вроде бы было, что-то важное, но звонок телефона стер все обрывки памяти...Ало..");
        return;
    }  
        Count++;
}
Console.ForegroundColor = ConsoleColor.Red; // Такая команда меняет цвет строки.
Console.WriteLine("Смерть: Идем со мной, нас уже заждались...");
Console.WriteLine("Ты ушел во тьму и даже не заметил, как растворился в ней и стал ее частью...");



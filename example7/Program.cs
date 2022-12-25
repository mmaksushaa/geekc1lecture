Console.Clear(); //Чистит консоль после запуска программы
//Console.SetCursorPosition(10, 4);//10 - кол-во пробелов 4 - строка на которой будет '+' (начальная строка = 0)
//Console.WriteLine("+");
int xa = 1; // Отступ точки 'а' по оси х (кол-во пробелов)
int ya = 1; // Отступ точки 'а' по оси у (кол-во enter)
int xb = 1;
int yb = 10;
int xc = 20;
int yc = 10;
Console.SetCursorPosition(xa, ya); 
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb); 
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc); 
Console.WriteLine("+");

int x = xa, y = xb;

int count = 0;
while(count < 10000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa)/2;
        y = (y + ya)/2;
    }

     if (what == 1)
    {
        x = (x + xb)/2;
        y = (y + yb)/2;
    }

     if (what == 2)
    {
        x = (x + xc)/2;
        y = (y + yc)/2;
    }
    Console.SetCursorPosition(x,y);
    Console.WriteLine("+");
    count = count + 1;

}
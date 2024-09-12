using System;

static void Main(string[] args)
{
    //Display display = new Display(3, 3);
    //display.FillScreenWith("#");
    //Console.WriteLine(display);
    //display.Pixel(2, 2, "O");
    //Console.WriteLine(display);
    //display.DrawLine(1,3,3,3);
    //Console.WriteLine(display);

    //Display display = new Display(50,50);
    //display.FillScreenWith("#");
    //display.DrawLine(3,4,44,45, "Y");
    //Console.WriteLine(display);

    int x=1; int y=1;
    Display display = new Display(300, 80);
    display.DrawLine(3, 3, 27, 27, "G");
    //Console.WriteLine(display);
    //display.FillScreenWith("`");
    while (true)
    {
        LoadAnimation(display, "#");
        LoadAnimation(display, "`");
    }
}
public static void LoadAnimation(Display display,string thing)
{
    int x = 1; int y = 1;
    int cx; int cy;
    (cx, cy) = display.GetCenter();
    while (x < display.GetWidth())
    {
        display.DrawLine(x, y, cx, cy, thing[0].ToString());
        x++;
        Console.WriteLine(display);
    }
    while (y < display.GetHeight())
    {
        display.DrawLine(x, y, cx, cy, thing[0].ToString());
        y++;
        Console.WriteLine(display);
    }
    while (x > 1)
    {
        display.DrawLine(x, y, cx, cy, thing[0].ToString());
        x--;
        Console.WriteLine(display);
    }
    while (y > 1)
    {
        display.DrawLine(x, y, cx, cy, thing[0].ToString());
        y--;
        Console.WriteLine(display);
    }
    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
}
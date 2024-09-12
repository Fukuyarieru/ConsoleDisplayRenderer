public class Display
{
    private int Resolution;
    private int Height;
    private int Width;
    private string Screen;

    public Display(int Width, int Height)
    {
        this.Width = Width;
        this.Height = Height;
        this.Clear();
    }
    public void Update(string Screen)
    {
        this.Screen = Screen;
    }
    public void Clear()
    {
        FillScreenWith(" ");
    }
    public void FillScreenWith(string thing)
    {
        string NewScreen = "";
        for (int i = 1; i <= Height; i++)
        {
            for (int j = 1; j <= Width; j++)
            {
                NewScreen += thing;
            }
            NewScreen += "\n";
        }
        Screen = NewScreen;
    }
    public (int,int) GetCenter()
    {
        return (Width/2,Height/2);
    }
    public void Pixel(int x, int y, string thing)
    {
        x--;
        y--;
        //string NewScreen = "";
        //x--;
        //y--;
        //for (int i = 0; i < Height; i++)
        //{
        //    for (int j = 0; j < Width; j++)
        //    {
        //        Console.WriteLine(NewScreen);
        //        //Console.WriteLine("NewScreen:\n"+NewScreen+"\nNewScreenLength: " + NewScreen.Length);
        //        if (i == y && j == x)
        //            NewScreen += thing;
        //        else if (!(Screen[(i * Height + j)] + Screen[(i * Height + j + 1)]).Equals("\n"))
        //            NewScreen += Screen[(i * Height + j)];
        //    }
        //    NewScreen += "\n";
        //}
        //Screen = NewScreen;

        // Create a new string builder for efficient string manipulation
        char[] screenArray = Screen.ToCharArray();

        // Calculate the index in the flat string (Screen) where (x, y) resides
        int index = y * (Width + 1) + x; // Width + 1 accounts for the newline at the end of each row

        // Replace the character at that index with the new character (thing)
        screenArray[index] = thing[0]; // Ensure that "thing" is a single character

        // Rebuild the screen from the updated character array
        Screen = new string(screenArray);

        //string NewScreen = "";
        //for (int i = 0; i < (x + y * Height); i++)
        //    NewScreen += Screen[i].ToString();
        //NewScreen += thing[0].ToString();
        //for (int i = (x + 1 + y * Height); i < Screen.Length; i++)
        //    NewScreen += Screen[i].ToString();
        //Screen = NewScreen;
    }
    public void DrawLine(int x1, int y1, int x2, int y2, string thing)
    {
        //int dy = Math.Abs(y1 - y2);
        //int sx = Math.Abs(x1 - x2) / dy; // speed X

        //for(int i=0;i<dy;i++)
        //{
        //    for (int j = 0; j < sx; j++)
        //    {
        //        this.Pixel(x1 + sx, y1 + dy,"*");
        //    }
        //}

        //while (x1 != x2)
        //{
        //    Pixel(x1, y1, "*");
        //}
        //int dy=Math.Abs(y2 - y1);
        //int dx = Math.Abs(x2 - x1);
        //double dxr = dx / dy;
        //double dyr = dy / dxr;
        //for(int i=Math.Min(x1,x2);i<Math.Max(x1,x2);i++)
        //{

        //}

        // Bresenham's line algorithm
        int dx = Math.Abs(x2 - x1);
        int dy = Math.Abs(y2 - y1);

        int sx = x1 < x2 ? 1 : -1; // Step direction for x
        int sy = y1 < y2 ? 1 : -1; // Step direction for y

        int err = dx - dy;

        while (true)
        {
            // Draw the pixel at the current position
            Pixel(x1, y1, thing[0].ToString());

            // If we have reached the end point, break the loop
            if (x1 == x2 && y1 == y2) break;

            // Calculate error and adjust x and y accordingly
            int e2 = 2 * err;

            if (e2 > -dy)
            {
                err -= dy;
                x1 += sx;
            }

            if (e2 < dx)
            {
                err += dx;
                y1 += sy;
            }
        }
    }
    public int GetWidth()
    {
        return Width;
    }
    public int GetHeight()
    {

        return Height;
    }
    public override string ToString()
    {
        return Screen;
    }
}
using System;
using Raylib_cs;

public class Key
{
    public Rectangle rec = new Rectangle();

    public int doorNumber;

    public Key(int x, int y, int w, int h, int num)
    {
        rec.x = x;
        rec.y = y;
        rec.width = w;
        rec.height = h;
        doorNumber = num;
    }

    public void Update()
    {

    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rec, Color.YELLOW);

    }
}

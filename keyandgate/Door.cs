using System;
using Raylib_cs;

public class Door
{
    public Rectangle rec = new Rectangle();

    public bool locked = true;

    public int doorNumber;

    public Door(int x, int y, int w, int h, int num)
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
        if (locked)
        {
            Raylib.DrawRectangleRec(rec, Color.BROWN);
        }
        else
        {
            Raylib.DrawRectangleRec(rec, Color.BLACK);
        }
    }
}

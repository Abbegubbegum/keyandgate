using System;
using Raylib_cs;

public class Player
{
    public Rectangle rec = new Rectangle();
    private float speed = 0.2f;

    public Key key = new Key(-1000, -1000, 0, 0, 0);

    public Player(int x, int y, int w, int h)
    {
        rec.x = x;
        rec.y = y;
        rec.width = w;
        rec.height = h;
    }

    public void Update()
    {
        Movement();
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rec, Color.RED);

    }
    private void Movement()
    {
        if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
        {
            rec.y -= speed;
            key.rec.y -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
        {
            rec.y += speed;
            key.rec.y += speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
        {
            rec.x -= speed;
            key.rec.x -= speed;

        }
        if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
        {
            rec.x += speed;
            key.rec.x += speed;

        }
    }
}

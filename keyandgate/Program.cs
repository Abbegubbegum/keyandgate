using System;
using Raylib_cs;

Raylib.InitWindow(800, 600, "yee");
Player p = new Player(100, 100, 24, 24);
Key k = new Key(500, 500, 25, 25, 1);
Door d = new Door(300, 500, 35, 100, 1);

string gameState = "game";


while (!Raylib.WindowShouldClose())
{
    if (gameState == "game")
    {
        //Logic
        p.Update();
        k.Update();
        d.Update();

        if (Raylib.CheckCollisionRecs(p.rec, k.rec))
        {
            p.key = k;
        }

        if (Raylib.CheckCollisionRecs(p.key.rec, d.rec) && p.key.doorNumber == d.doorNumber)
        {
            d.locked = false;
            p.key.rec.y = -15000;
        }

        if (Raylib.CheckCollisionRecs(p.rec, d.rec) && !d.locked)
        {
            gameState = "";
        }

        //Draw
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        d.Draw();
        k.Draw();
        p.Draw();
        Raylib.EndDrawing();
    }
    else
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.WHITE);
        Raylib.DrawText("OVER", 100, 100, 32, Color.BLACK);
        Raylib.EndDrawing();
    }
}


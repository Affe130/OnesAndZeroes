using Raylib_cs;
using System;

int windowWidth = 800;
int windowHeight = 480;

int fontSize = 20;

List<List<int>> table = new List<List<int>>();

for (int i = 0; i <= windowHeight / fontSize; i++)
{
    List<int> row = new();
    for (int j = 0; j <= windowWidth / fontSize; j++)
    {
        row.Add(0);
    }
    table.Add(row);
}

Raylib.SetTargetFPS(1000);
Raylib.InitWindow(windowWidth, windowHeight, "OnesAndZeroes");

int x = 0;
int y = 0;
int z = 0;

while (!Raylib.WindowShouldClose())
{
    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.BLACK);

    for (int i = 0; i <= windowHeight / fontSize; i++)
    {
        for (int j = 0; j <= windowWidth / fontSize; j++)
        {
            Raylib.DrawText($"{table[i][j]}", j * fontSize, i * fontSize, fontSize, Color.GREEN);
        }
    }

    //Raylib.DrawFPS(0, 0);
    Raylib.EndDrawing();

    if (z % 2 == 0)
    {
        Random random = new();
        table[y][x] = random.Next(2);
    }
    else
    {
        table[y][x] = 0;
    }

    x++;
    if (x > windowWidth / fontSize)
    {
        x = 0;
        y++;
    }
    if (y > windowHeight / fontSize)
    {
        y = 0;
        z++;
    }
}

Raylib.CloseWindow();

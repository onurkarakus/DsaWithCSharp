﻿using System.Text;

namespace ArraysCode.MultiDimensional.GameMap;

public static class GameMapArray
{
    public static void RunSample()
    {
        TerrainEnum[,] map = {
            {
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS
            },
            {
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS
            },
            {
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS
            },
            {
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS,
                TerrainEnum.GRASS
            },
            {
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.WALL,
                TerrainEnum.WALL,
                TerrainEnum.WALL
            },
            {
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.WALL,
                TerrainEnum.SAND,
                TerrainEnum.SAND
            },
            {
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.SAND,
                TerrainEnum.WALL,
                TerrainEnum.SAND,
                TerrainEnum.SAND
            },
            {
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WALL,
                TerrainEnum.SAND,
                TerrainEnum.SAND
            },
            {
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WALL,
                TerrainEnum.SAND,
                TerrainEnum.SAND
            },
            {
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WALL,
                TerrainEnum.WATER,
                TerrainEnum.WATER
            },
            {
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WATER,
                TerrainEnum.WALL,
                TerrainEnum.WATER,
                TerrainEnum.WATER
            }
        };

        Console.OutputEncoding = UTF8Encoding.UTF8;

        for (int row = 0; row < map.GetLength(0); row++)
        {
            for (int column = 0; column < map.GetLength(1); column++)
            {
                Console.ForegroundColor = map[row, column].GetColor();
                Console.Write(map[row, column].GetCharacter() + " ");
            }

            Console.WriteLine();
        }

        Console.ForegroundColor = ConsoleColor.Gray;
    }
}

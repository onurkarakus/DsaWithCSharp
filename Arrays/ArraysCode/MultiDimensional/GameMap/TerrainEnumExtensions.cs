namespace ArraysCode.MultiDimensional.GameMap;

public static class TerrainEnumExtensions
{
    public static ConsoleColor GetColor(this TerrainEnum terrain)
    {
        return terrain switch
        {
            TerrainEnum.GRASS => ConsoleColor.Green,
            TerrainEnum.SAND => ConsoleColor.Yellow,
            TerrainEnum.WATER => ConsoleColor.Blue,
            _ => ConsoleColor.DarkGray
        };
    }

    public static char GetCharacter(this TerrainEnum terrain)
    {
        return terrain switch
        {
            TerrainEnum.GRASS => '\u201c',
            TerrainEnum.SAND => '\u25cb',
            TerrainEnum.WATER => '\u2248',
            _ => '\u25cf'
        };
    }
}

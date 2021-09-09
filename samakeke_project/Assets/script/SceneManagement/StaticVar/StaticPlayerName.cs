public static class StaticPlayerName
{
    private static string playerName;

    public static string PropertyPlayerName { get => playerName; set => playerName = value; }
}

public static class StaticPlayerJobReference
{
    private static int playerJobStatus;

    public static int PropertyPlayerStatus { get => playerJobStatus; set => playerJobStatus = value; }
}
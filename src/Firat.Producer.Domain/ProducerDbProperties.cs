namespace Firat.Producer;

public static class ProducerDbProperties
{
    public static string DbTablePrefix { get; set; } = "Producer";

    public static string? DbSchema { get; set; } = null;

    public const string ConnectionStringName = "Producer";
}

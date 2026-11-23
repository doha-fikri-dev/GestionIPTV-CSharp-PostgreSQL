using Npgsql;

public class Connexion
{
    public static NpgsqlConnection GetConnection()
    {
        string chaine =
            "Host=localhost;" +
            "Port=5432;" +
            "Database=GestionScolarite;" +
            "Username=postgres;" +
            "Password=YOUR_PASSWORD";

        return new NpgsqlConnection(chaine);
    }
}
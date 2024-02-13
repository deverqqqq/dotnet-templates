namespace Template.Repository.Infrastructure;

public sealed class DataConstant : IDataConstant
{
    private readonly string _sqlConnectionString;

    public DataConstant(string connString)
    {
        this._sqlConnectionString = connString;
    }
    
    public IDbConnection GetConnection()
    {
        var connBuilder = new SqlConnectionStringBuilder("");
        // connBuilder.TrustServerCertificate = true;

        return new SqlConnection(connBuilder.ConnectionString);
    }
}
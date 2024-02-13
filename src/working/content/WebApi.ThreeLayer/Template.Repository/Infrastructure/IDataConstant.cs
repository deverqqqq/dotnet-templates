namespace Template.Repository.Infrastructure;

public interface IDataConstant
{
    IDbConnection GetConnection();
}
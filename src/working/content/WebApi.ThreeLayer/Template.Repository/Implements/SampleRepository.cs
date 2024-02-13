namespace Template.Repository.Implements;

internal sealed class SampleRepository : ISampleRepository
{
    private readonly Func<IDbConnection> _resolveConn;

    public SampleRepository(
        Func<IDbConnection> resolveConn)
    {
        this._resolveConn = resolveConn;
    }

    public IEnumerable<SampleDataModel> GetSomeSampleDatas()
    {
        return new List<SampleDataModel>
        {
            new SampleDataModel
            {
                ColumnA = "A1",
                ColumnB = "B1", 
                ColumnC = 1, 
                Details = new[]
                {
                    new SampleDetailDataModel
                    {
                        DetailInfoA = "DetailA1", 
                        DetailInfoB = "DetailB1", 
                        DetailInfoC = 1.11m
                    }
                }
            },
            new SampleDataModel
            {
                ColumnA = "A2",
                ColumnB = "B2", 
                ColumnC = 2, 
                Details = new[]
                {
                    new SampleDetailDataModel
                    {
                        DetailInfoA = "DetailA2", 
                        DetailInfoB = "DetailB2", 
                        DetailInfoC = 2.22m
                    }
                }
            },
            new SampleDataModel
            {
                ColumnA = "A3",
                ColumnB = "B3", 
                ColumnC = 3, 
                Details = new[]
                {
                    new SampleDetailDataModel
                    {
                        DetailInfoA = "DetailA3", 
                        DetailInfoB = "DetailB3", 
                        DetailInfoC = 3.33m
                    }
                }
            },
        };
    }
}
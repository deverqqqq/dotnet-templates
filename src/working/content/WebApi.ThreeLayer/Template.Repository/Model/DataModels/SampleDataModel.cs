namespace Template.Repository.Model.DataModels;

public class SampleDataModel
{
    public string ColumnA { get; set; }
    public string ColumnB { get; set; }
    public int ColumnC { get; set; }
    public IEnumerable<SampleDetailDataModel> Details { get; set; }
}

public class SampleDetailDataModel
{
    public string DetailInfoA { get; set; }
    public string DetailInfoB { get; set; }
    public decimal DetailInfoC { get; set; }
}
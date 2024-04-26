namespace CsvDataAccess.Builder;

public class Row
{
    private Dictionary<string, int> _intsData = new Dictionary<string, int>();
    private Dictionary<string, bool> _boolsData = new Dictionary<string, bool>();
    private Dictionary<string, decimal> _decimalsData= new Dictionary<string, decimal>();
    private Dictionary<string, string> _stringsData=new Dictionary<string, string>();

    public void AssignCell(string columnName, int value)
    {
        _intsData[columnName]= value;
    }
    public void AssignCell(string columnName, bool value)
    {
        _boolsData[columnName]= value;
    }
    public void AssignCell(string columnName, decimal value)
    {
        _decimalsData[columnName]= value;
    }
    public void AssignCell(string columnName, string value)
    {
        _stringsData[columnName]= value;
    }

    public object GetAtColumn(string columnName)
    {
        if (_boolsData.ContainsKey(columnName))
        {
            return _boolsData[columnName];
        }
        else if (_intsData.ContainsKey(columnName))
        {
            return _intsData[columnName];
        }
        
        else if (_decimalsData.ContainsKey(columnName))
        {
            return _decimalsData[columnName];
        }
        else if (_stringsData.ContainsKey(columnName))
        {
            return _stringsData[columnName];
        }
        return null;
    }
}
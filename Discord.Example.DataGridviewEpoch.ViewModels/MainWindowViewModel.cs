using System.Data;

namespace Discord.Example.DataGridviewEpoch.ViewModels;
public class MainWindowViewModel
{

    public MainWindowViewModel()
    {
        MyTable = new DataTable();

        MyTable.Columns.Add("Name");
        MyTable.Columns.Add("DateTime");

        for (int row = 0; row < 5; row++)
        {
            DataRow myRow = MyTable.NewRow();
            myRow["Name"] = $"Row: {row + 1}";
            myRow["DateTime"] = DateTimeOffset.Now.ToUnixTimeSeconds();
            MyTable.Rows.Add(myRow);
        }
    }

    public DataTable MyTable { get; }
}

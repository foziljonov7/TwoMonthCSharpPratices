namespace ThreeWeek.Advanced;

public class Subscriber
{
    private string _name;

    public Subscriber(string name)
    {
        _name = name;
    }

    public void OnNotifyReceived(object sender, EventArgs e)
    {
        Console.WriteLine($"{_name} nimadur bolyapdi broooooo.");
    }
}
namespace ThreeWeek.Advanced;

public class Publisher
{
    public delegate void NotifyEventHandler(object sender, EventArgs e);

    public event NotifyEventHandler Notify;

    public void DoSomething()
    {
        Console.WriteLine("Qandaydur ish bajarilmoqda...");

        OnNotify(EventArgs.Empty);
    }

    protected virtual void OnNotify(EventArgs e)
    {
        if(Notify != null)
        {
            Notify(this, e);
        }
    }
}
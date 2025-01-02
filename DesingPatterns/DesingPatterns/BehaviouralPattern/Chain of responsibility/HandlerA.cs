namespace ChainOfResponsibility;

public class HandlerA : IHandler
{
    public IHandler NextHandler { get; set; }

    public void SetNext(IHandler handler)
    {
        NextHandler = handler;
    }

    public void InvokeNext()
    {
        NextHandler?.HandleRequest();
    }

    public void HandleRequest()
    {
        Console.WriteLine("Executing handlerA logic");
        //specific logic for handlerA
        InvokeNext();
    }
}
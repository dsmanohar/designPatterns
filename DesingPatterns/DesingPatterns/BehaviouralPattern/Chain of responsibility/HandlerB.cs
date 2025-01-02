namespace ChainOfResponsibility;

public class HandlerB : IHandler
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
        Console.WriteLine("Executing handlerb logic");
        //specific logic for handlerb
        InvokeNext();
    }
}
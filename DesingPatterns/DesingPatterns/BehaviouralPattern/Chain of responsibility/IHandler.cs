namespace ChainOfResponsibility;

public interface IHandler
{
    IHandler NextHandler { get; set; }
    
    void SetNext(IHandler handler);

    void InvokeNext();

    void HandleRequest();
}
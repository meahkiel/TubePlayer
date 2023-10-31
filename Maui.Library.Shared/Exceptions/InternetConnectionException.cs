namespace Maui.Library.Shared.Exceptions;

public class InternetConnectionException : Exception
{
    public InternetConnectionException() : base("Internet is connection problem")
    {
        
    }

    public InternetConnectionException(string message) : base(message)
    {

    }

    public InternetConnectionException(string message,Exception ex) : base(message,ex) 
    {

    }
}

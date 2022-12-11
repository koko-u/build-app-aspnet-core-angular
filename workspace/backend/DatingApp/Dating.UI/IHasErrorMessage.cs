namespace Dating.UI;

public interface IHasErrorMessage
{
    string ErrorMessage { get; }

    
}

public static class HasErrorExtensions
{
    public static bool HasError<T>(this T errornessObj)
        where T : IHasErrorMessage
    {
        return !string.IsNullOrEmpty(errornessObj.ErrorMessage);
    }
}
namespace Dating.UI;

public sealed class ResponseData<T> : IHasErrorMessage
    where T : class
{
    public string ErrorMessage { get; } = string.Empty;

    public T? Data { get; }

    internal ResponseData(string errorMessage, T? data)
    {
        ErrorMessage = errorMessage;
        Data = data;
    }
}

public sealed class ResponseData : IHasErrorMessage
{
    public string ErrorMessage { get; } = string.Empty;

    internal ResponseData(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }


    public static ResponseData<T> Ok<T>(T data)
        where T : class
    {
        return new ResponseData<T>(string.Empty, data);
    }
    public static ResponseData<T> Err<T>(string errorMessage,
                                         Func<T?>? emptyValueGenerator = null)
        where T : class
    {
        var emptyValue = emptyValueGenerator?.Invoke() ?? null;
        return new ResponseData<T>(errorMessage, emptyValue);
    }

    public static ResponseData Ok()
    {
        return new ResponseData(string.Empty);
    }

    public static ResponseData Err(string errorMessage)
    {
        return new ResponseData(errorMessage);
    }
}
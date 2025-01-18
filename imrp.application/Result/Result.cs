namespace imrp.application.Result;

public class Result
{
    public bool IsSuccess { get; }
    public string Message { get; }

    protected Result(bool isSuccess, string message)
    {
        ValidateConstructor(isSuccess, message);
        
        IsSuccess = isSuccess;
        Message = message;
    }
    
    public static Result Success() => new Result(true, string.Empty);
    public static Result Failure(string message) => new Result(false, message);

    private static void ValidateConstructor(bool isSuccess, string message)
    {
        switch (isSuccess)
        {
            case true:
                if (!string.IsNullOrEmpty(message))
                    throw new InvalidOperationException("\"Success result cannot have an error message.\"");
                break;
            case false:
                if (string.IsNullOrEmpty(message))
                    throw new InvalidOperationException("Failure result must have an error message.");
                break;
        }
    }
}

public class Result<T> : Result
{
    public T Value { get; }

    protected Result(bool isSuccess, string message, T value) : base(isSuccess, message)
    {
        Value = value;
    }

    public static Result<T> Success(T value) => new Result<T>(true, string.Empty, value);
    public static Result<T> Failure(string message) => new Result<T>(false, message, default);
}

namespace simplewebserverlib;

public static class RequestProcessor
{
    public static AddResponse Process(AddRequest request)
    {
        int result = request.A + request.B + 0;
        return new AddResponse
        {
            AddRequest = request,
            Result = result
        };
    }

    public static string GetEnvironment()
    {
        return Environment.OSVersion.VersionString + "SuriyaMagiAgazhiHello";
    }
}

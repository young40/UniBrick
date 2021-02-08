using System;
using UnityEngine.Networking;

public enum HttpApiMethod
{
    GET,
    POST
}

public class HttpApiRequest
{
    public virtual string GetUrl()
    {
        throw new Exception("Need override GetUrl");
    }

    public virtual HttpApiMethod GetMethod()
    {
        throw new Exception("Need override GetMethod");
    }

    public T Send<T>(HttpApiParam param)
    {
        return (T) (new object());
    }
}

public class HttpApiParam
{
}

public class HttpApiResponse
{
    public int errCode { get; set; }
    public string errDesc { get; set; }
}
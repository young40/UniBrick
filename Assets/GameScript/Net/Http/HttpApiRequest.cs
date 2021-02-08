using System;
using Cysharp.Threading.Tasks;
using UnityEngine;
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

    protected async UniTask<T> Send<T>(HttpApiParam param) where T: HttpApiResponse
    {
        var resp = (T) Activator.CreateInstance(typeof(T));
        try
        {
            var req = new UnityWebRequest();

            req.method = this.GetMethod().ToString();
            req.url = this.GetUrl();

            await req.SendWebRequest();

            resp.errCode = 200;
            resp.errDesc = "Http OK";
        }
        catch (Exception e)
        {
            resp.errCode = -1;
            resp.errDesc = "Http Got ERROR";
            
            Debug.LogError(e);
        }

        return resp;
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
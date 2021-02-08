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
        var req = new UnityWebRequest();
        T resp;

        try
        {
            req.method = this.GetMethod().ToString();
            req.url = this.GetUrl();

            req.downloadHandler = new DownloadHandlerBuffer();

            await req.SendWebRequest();

            Debug.LogError(req.downloadHandler);
            Debug.LogError(req.downloadHandler.text);
            var txt = req.downloadHandler.text;

            Debug.LogError(txt);
            resp = JsonUtility.FromJson<T>(txt);

            Debug.LogError("AAAAA");
            Debug.LogError(req.error);
        }
        catch (Exception e)
        {
            resp = (T) Activator.CreateInstance(typeof(T));

            Debug.LogError("BBBBB");
            Debug.LogError(req.error);

            resp.errCode = -1;
            resp.errDesc = e.Message;

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
    public string errDesc;
    public int errCode;
}
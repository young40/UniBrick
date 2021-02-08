using Cysharp.Threading.Tasks;

namespace GameScript.Login
{
    public class RequestLogin: HttpApiRequest
    {
        public override string GetUrl()
        {
            // return "http://localhost:8889/1.php";
            return "http://localhost:8889/404.php";
            // return "https://www.baidu.com";
            // return "https://www.baidu.comxxx";
            //return "pszbt/v1/login";
        }
        
        public override HttpApiMethod GetMethod()
        {
            return HttpApiMethod.GET;
        }

        public UniTask<ResponseLogin> Send(ParamLogin param)
        {
            return base.Send<ResponseLogin>(param);
        }
    }

    public class ParamLogin : HttpApiParam
    {
        
    }

    public class ResponseLogin: HttpApiResponse
    {
        
    }
}
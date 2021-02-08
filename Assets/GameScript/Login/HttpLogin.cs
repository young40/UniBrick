namespace GameScript.Login
{
    public class RequestLogin: HttpApiRequest
    {
        public override string GetUrl()
        {
            return "pszbt/v1/login";
        }
        
        public override HttpApiMethod GetMethod()
        {
            return HttpApiMethod.GET;
        }

        public ResponseLogin Send(ParamLogin param)
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
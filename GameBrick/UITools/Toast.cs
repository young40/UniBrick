using TinaX;
using TinaX.UIKit;

namespace UITools
{
    public class Toast : XUIBehaviour
    {
        public static void Show(string msg)
        {
            var uiKit = XCore.GetMainInstance().GetService<IUIKit>();

            uiKit.OpenUIAsync("Assets/UI/Tools/Toast/Toast.prefab", new Toast(), ExceptionHandler.EntityException);
        }
    }
}

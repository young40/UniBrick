using System;
using TinaX;
using TinaX.UIKit;
using TinaX.UIKit.Animation;
using UniRx;
using UnityEngine.UI;

public class Toast: XUIBehaviour
{
    public Text txt_msg;
    public RectTransformAnchoredPositionTween ani_out;

    private string message;
    
    private Toast() {}
        
    public static void Show(string msg)
    {
        var uiKit = XCore.GetMainInstance().GetService<IUIKit>();

        uiKit.OpenUIAsync("Assets/UI/Tools/Toast/Toast.prefab", new Toast(msg), ExceptionHandler.EntityException);
    }

    public Toast(string msg)
    {
        this.message = msg;
    }

    public override void Start()
    {
        base.Start();

        txt_msg.text = message;

        this.ani_out.OnFinish += () =>
        {
            this.Close();
        };
    }
}

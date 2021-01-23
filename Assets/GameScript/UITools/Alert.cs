using TinaX;
using TinaX.UIKit;
using UniRx;
using UnityEngine.UI;

public class Alert: XUIBehaviour
{
    public Button btnOK;
    
    public static Alert aShow()
    {
        var newAlert = new Alert();

        var uikit = XCore.GetMainInstance().GetService<IUIKit>();

        uikit.OpenUIAsync("Assets/UI/Tools/Alert/Alert.prefab", newAlert, ExceptionHandler.EntityException);
        
        return newAlert;
    }

    public override void Start()
    {
        base.Start();

        btnOK.OnClickAsObservable().Subscribe(_ =>
        {
            this.Close();
        });
    }
}
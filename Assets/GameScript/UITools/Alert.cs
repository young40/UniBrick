using TinaX;
using TinaX.UIKit;
using UniRx;
using UnityEngine.UI;

public class Alert
{
    private AlertUI ui;

    private Alert() {}
    
    public static Alert Show()
    {
        var newAlert = new Alert();
        newAlert.ui = new AlertUI();

        var uikit = XCore.GetMainInstance().GetService<IUIKit>();

        uikit.OpenUIAsync("Assets/UI/Tools/Alert/Alert.prefab", newAlert.ui, ExceptionHandler.EntityException);
        
        return newAlert;
    }

    private class AlertUI: XUIBehaviour
    {
        public Button btnOK;

        public override void Start()
        {
            base.Start();

            btnOK.OnClickAsObservable().Subscribe(_ => { this.Close(); });
        }
    }
}
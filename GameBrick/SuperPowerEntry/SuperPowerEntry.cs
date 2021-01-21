using TinaX;
using TinaX.UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SuperPowerEntry: XUIBehaviour
{
    [Inject]
    public IUIKit UIKit { get; set; }
    public Button btn;
    // public Dropdown drop;
    // public Toggle toggle;

    public override void Start()
    {
        // base.Start();
        //
        btn.onClick.AddListener(async () =>
        {
            Debug.Log("wwwwwwwwwwwww");
        });
    }
}
using TinaX;
using TinaX.UIKit;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class SuperPowerEntry: XUIBehaviour
{
    [Inject]
    public IUIKit UIKit { get; set; }

    public Dropdown DropdownServerList;

    public override void Start()
    {
        new SPEServerList(DropdownServerList);

    }
}

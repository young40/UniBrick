using TinaX;
using TinaX.UIKit;
using UITools;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class SuperPowerEntry: XUIBehaviour
{
    [Inject]
    public IUIKit UIKit { get; set; }

    public Dropdown DropdownServerList;
    public Button ButtonTest;

    public override void Start()
    {
        new SPEServerList(DropdownServerList);

        ButtonTest.onClick.AddListener(delegate
        {
            Toast.Show("Hello @" + Random.Range(0, 10000));
        });
    }
}

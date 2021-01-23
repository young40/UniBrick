using TinaX;
using TinaX.UIKit;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace SuperPowerEntry
{
    public struct ServerInfo
    {
        public string name;
        public string ip;
        public int port;
    }

    public class SuperPowerEntry : XUIBehaviour
    {
        public Button ButtonTest;
        public Button btnTestAlert;

        public Dropdown DropdownServerList;

        public ReactiveCollection<ServerInfo> mList;
        [Inject] public IUIKit UIKit { get; set; }

        public override void Start()
        {
            mList = new ReactiveCollection<ServerInfo>();

            mList.ObserveAdd().Subscribe(addServer =>
            {
                int index = DropdownServerList.options.Count - 1;
                string txt = string.Format("{0} {1}:{2}", addServer.Value.name, addServer.Value.ip,
                    addServer.Value.port);
                DropdownServerList.options.Insert(DropdownServerList.options.Count - 1, new Dropdown.OptionData(txt));

                DropdownServerList.value = index;
                DropdownServerList.captionText.text = txt;
            });

            mList.Add(new ServerInfo {name = "测试服", ip = "1.1.1.1", port = 1234});
            mList.Add(new ServerInfo {name = "正式服", ip = "2.2.2.2", port = 5678});

            DropdownServerList.OnValueChangedAsObservable()
                .Where(index => index == DropdownServerList.options.Count - 1)
                .Subscribe(a =>
                {
                    var uikit = XCore.GetMainInstance().GetService<IUIKit>();

                    uikit.OpenUIAsync("Assets/UI/SuperPowerEntry/SPEManageServer.prefab",
                        new AddGameServer(mList),
                        new OpenUIParam() {UseMask = true, CloseByMask = true}, ExceptionHandler.EntityException);
                });

            ButtonTest.onClick.AddListener(delegate { Toast.Show("Hello @" + Random.Range(0, 10000)); });

            btnTestAlert.OnClickAsObservable().Subscribe(_ =>
            {
                Alert.Show();
            });
        }
    }
}
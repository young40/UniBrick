using System;
using TinaX;
using TinaX.UIKit;
using UniRx;
using UnityEngine.UI;
using Random = UnityEngine.Random;

namespace SuperPowerEntry
{
    public struct ServerInfo
    {
        public string name;
        public string ip;
        public int port;
    }

    public class SuperPowerEntryView : XUIBehaviour
    {
        public Button ButtonTest;
        public Button btnTestAlert;

        public Dropdown DropdownServerList;

        [Inject] public IUIKit UIKit { get; set; }

        public Action onAddGameServer;

        public override void Start()
        {
            DropdownServerList.OnValueChangedAsObservable()
                .Where(index => index == DropdownServerList.options.Count - 1)
                .Subscribe(_ => this.onAddGameServer?.Invoke());
            
            ButtonTest.onClick.AddListener(delegate { Toast.Show("Hello @" + Random.Range(0, 10000)); });

            btnTestAlert.OnClickAsObservable().Subscribe(_ =>
            {
                Alert.Show();
            });
        }

        public void AddGameServer(GameServerVO vo)
        {
            int index = DropdownServerList.options.Count - 1;
            DropdownServerList.options.Insert(DropdownServerList.options.Count - 1, new Dropdown.OptionData(vo.ToString()));
             
            DropdownServerList.value = index;
            DropdownServerList.captionText.text = vo.ToString();              
        }

        public void SelectFirstGameServer()
        {
            DropdownServerList.value = 0;
        }
    }
}
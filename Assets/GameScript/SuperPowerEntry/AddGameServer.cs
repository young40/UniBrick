using System;
using TinaX.UIKit;
using UniRx;
using UnityEngine.UI;

namespace SuperPowerEntry
{
    public class AddGameServer : XUIBehaviour
    {
        public InputField name;
        public InputField ip;
        public InputField port;

        public Button btnOK;

        private Action<string, string, int> callbakOK;
        private Action callbackError;

        public AddGameServer(Action<string, string, int> callbakOk, Action callbackError)
        {
            this.callbakOK = callbakOk;
            this.callbackError = callbackError;
        }

        public override void Start()
        {
            btnOK.onClick.AddListener(delegate
            {
                bool fieldOK = true;

                fieldOK = fieldOK && !string.IsNullOrEmpty(name.text);
                fieldOK = fieldOK && !string.IsNullOrEmpty(ip.text);
                fieldOK = fieldOK && !string.IsNullOrEmpty(port.text) && (Int32.Parse(port.text) > 0);

                if (fieldOK)
                {
                    callbakOK(name.text, ip.text, Int32.Parse(port.text));
                    this.Close();
                }
                else
                {
                    callbackError();
                    this.Close();
                }
            });
        }
    }
}

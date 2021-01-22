using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using TinaX.UIKit;
using TinaX.UIKit.Components;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

public class SPEManageServerList : XUIBehaviour
{
    public InputField name;
    public InputField ip;
    public InputField port;

    public Button btnOK;

    private ReactiveCollection<ServerInfo> mList;

    public SPEManageServerList(ReactiveCollection<ServerInfo> list)
    {
        this.mList = list;
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
                mList.Add(new ServerInfo
                {
                    name = name.text, 
                    ip = ip.text,
                    port = Int32.Parse(port.text)
                });
                this.Close();
            }
            else
            {
                this.Close();
            }
        });
    }
}
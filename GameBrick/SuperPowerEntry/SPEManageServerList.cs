using System;
using System.IO;
using TinaX.UIKit;
using TinaX.UIKit.Components;
using UniRx;
using UnityEngine;
using UnityEngine.UI;

namespace GameBrick.SuperPowerEntry
{
    public class SPEManageServerList: XUIBehaviour
    {
        public InputField name;
        public InputField ip;
        public InputField port;

        public Button btnOK;
        
        private Dropdown mDropdown;

        public SPEManageServerList(Dropdown dropdown)
        {
            mDropdown = dropdown;
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
                    mDropdown.options.RemoveAt(mDropdown.options.Count - 1);
                    
                    var newOption = string.Format("{0}({1}:{2}", name.text, ip.text, port.text);
                    mDropdown.options.Add(new Dropdown.OptionData(newOption));
                    mDropdown.captionText.text = newOption;
                    
                    mDropdown.options.Add(new Dropdown.OptionData("+新增服务器"));
                    
                    this.Close();
                }
                else
                {
                    mDropdown.value = 0;
                    this.Close();
                }
            });
        }
    }
}
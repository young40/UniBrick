using System.Collections.Generic;
using System.Collections;
using System.Collections.Specialized;
using GameBrick.SuperPowerEntry;
using TinaX;
using TinaX.UIKit;
using UnityEngine;
using UnityEngine.UI;

public class SPEServerList
{
    private Dropdown mDropdown;

    private ListDictionary list;
    
    public SPEServerList(Dropdown dropdown)
    {
        list = new ListDictionary();
        mDropdown = dropdown;
        
        list.Add("测试服", "1.1.1.1:8888");
        list.Add("线上服", "2.2.2.2:8888");
        
        mDropdown.ClearOptions();
        
        foreach (DictionaryEntry dict in list)
        {
            mDropdown.options.Add(new Dropdown.OptionData(string.Format("{0}({1})", dict.Key, dict.Value)));
        }

        mDropdown.options.Add(new Dropdown.OptionData("+新增服务器"));

        mDropdown.captionText.text = mDropdown.options[0].text;

        mDropdown.onValueChanged.AddListener(delegate(int value)
        {
            if (value == mDropdown.options.Count - 1)
            {
                this.OpenAddServerPanel();
            }
        });
    }

    private void OpenAddServerPanel()
    {
        var uikit = XCore.GetMainInstance().GetService<IUIKit>();
        
        uikit.OpenUIAsync("Assets/UI/SuperPowerEntry/SPEManageServer.prefab", new SPEManageServerList(mDropdown),
            new OpenUIParam(){UseMask = true, CloseByMask = true}, (entity, exception) =>
            {
                if (exception != null)
                {
                    Debug.LogException(exception);
                }
            });
    }
}
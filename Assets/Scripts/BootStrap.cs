using System;
using System.Collections;
using System.Collections.Generic;
using TinaX;
using TinaX.XILRuntime;
using TinaX.XILRuntime.Registers;
using UnityEngine;

public class BootStrap : IXBootstrap
{
    public void OnInit(IXCore core)
    {
        var xil = core.Services.Get<IXILRuntime>();
        this.RegisterILRuntimes(xil);
    }

    public void OnStart(IXCore core)
    {
    }

    public void OnQuit()
    {
    }

    public void OnAppRestart()
    {
    }

    private void RegisterILRuntimes(IXILRuntime appdomain)
    {
        appdomain.RegisterXComponent();
        appdomain.RegisterUIKit();

        appdomain.DelegateManager.RegisterMethodDelegate<Int32>();
        appdomain.DelegateManager.RegisterMethodDelegate<Int32, Int32>();
        appdomain.DelegateManager.RegisterMethodDelegate<System.Int64>();
        appdomain.DelegateManager.RegisterMethodDelegate<TinaX.VFSKit.ISceneAsset, TinaX.XException>();
        appdomain.DelegateManager.RegisterDelegateConvertor<TinaX.UIKit.DataBinding.BindableProperty<Int32>.ValueChangedDalegate>(act =>
        {
            return new TinaX.UIKit.DataBinding.BindableProperty<Int32>.ValueChangedDalegate((oldValue, newValue) =>
            {
                ((Action<System.Int32, System.Int32>)act)(oldValue, newValue);
            });
        });
        
        appdomain.DelegateManager.RegisterDelegateConvertor<UnityEngine.Events.UnityAction<System.Int32>>((act) =>
        {
            return new UnityEngine.Events.UnityAction<System.Int32>((arg0) =>
            {
                ((Action<System.Int32>)act)(arg0);
            });
        });
    }
}

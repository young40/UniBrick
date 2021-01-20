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

    private void RegisterILRuntimes(IXILRuntime xil)
    {
        xil.RegisterXComponent();
        xil.RegisterUIKit();

        xil.DelegateManager.RegisterMethodDelegate<Int32, Int32>();
        xil.DelegateManager.RegisterMethodDelegate<TinaX.VFSKit.ISceneAsset, TinaX.XException>();
        xil.DelegateManager.RegisterDelegateConvertor<TinaX.UIKit.DataBinding.BindableProperty<Int32>.ValueChangedDalegate>(act =>
        {
            return new TinaX.UIKit.DataBinding.BindableProperty<Int32>.ValueChangedDalegate((oldValue, newValue) =>
            {
                ((Action<System.Int32, System.Int32>)act)(oldValue, newValue);
            });
        });
    }
}

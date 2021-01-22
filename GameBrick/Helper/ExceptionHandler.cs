using System;
using TinaX;
using TinaX.UIKit;
using UnityEngine;

public class ExceptionHandler
{
    public static Action<IUIEntity, XException> EntityException = (entity, exception) =>
    {
        if (exception != null)
        {
            Debug.LogError(exception);
        }
    };
}
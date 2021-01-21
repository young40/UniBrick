using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;

using ILRuntime.CLR.TypeSystem;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter;
using ILRuntime.Runtime.Stack;
using ILRuntime.Reflection;
using ILRuntime.CLR.Utils;

namespace ILRuntime.Runtime.Generated
{
    unsafe class TinaX_UIKit_UIPage_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            FieldInfo field;
            Type[] args;
            Type type = typeof(TinaX.UIKit.UIPage);
            args = new Type[]{};
            method = type.GetMethod("get_SortingLayer", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SortingLayer_0);
            args = new Type[]{};
            method = type.GetMethod("get_SortingLayerValue", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SortingLayerValue_1);
            args = new Type[]{};
            method = type.GetMethod("get_SortingLayerName", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_SortingLayerName_2);
            args = new Type[]{};
            method = type.GetMethod("get_DestroyDelayTime", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, get_DestroyDelayTime_3);
            args = new Type[]{typeof(TinaX.XComponent.XBehaviour), typeof(System.Boolean)};
            method = type.GetMethod("TrySetXBehavior", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TrySetXBehavior_4);
            args = new Type[]{typeof(System.Object[])};
            method = type.GetMethod("SendOpenUIMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendOpenUIMessage_5);
            args = new Type[]{typeof(System.Object[])};
            method = type.GetMethod("SendCloseUIMessage", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, SendCloseUIMessage_6);
            args = new Type[]{};
            method = type.GetMethod("TryPlayExitAni", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, TryPlayExitAni_7);

            field = type.GetField("ScreenUI", flag);
            app.RegisterCLRFieldGetter(field, get_ScreenUI_0);
            app.RegisterCLRFieldSetter(field, set_ScreenUI_0);
            app.RegisterCLRFieldBinding(field, CopyToStack_ScreenUI_0, AssignFromStack_ScreenUI_0);
            field = type.GetField("FullScreenUI", flag);
            app.RegisterCLRFieldGetter(field, get_FullScreenUI_1);
            app.RegisterCLRFieldSetter(field, set_FullScreenUI_1);
            app.RegisterCLRFieldBinding(field, CopyToStack_FullScreenUI_1, AssignFromStack_FullScreenUI_1);
            field = type.GetField("SortingLayerId", flag);
            app.RegisterCLRFieldGetter(field, get_SortingLayerId_2);
            app.RegisterCLRFieldSetter(field, set_SortingLayerId_2);
            app.RegisterCLRFieldBinding(field, CopyToStack_SortingLayerId_2, AssignFromStack_SortingLayerId_2);
            field = type.GetField("AllowMultiple", flag);
            app.RegisterCLRFieldGetter(field, get_AllowMultiple_3);
            app.RegisterCLRFieldSetter(field, set_AllowMultiple_3);
            app.RegisterCLRFieldBinding(field, CopyToStack_AllowMultiple_3, AssignFromStack_AllowMultiple_3);
            field = type.GetField("UIMainHandler", flag);
            app.RegisterCLRFieldGetter(field, get_UIMainHandler_4);
            app.RegisterCLRFieldSetter(field, set_UIMainHandler_4);
            app.RegisterCLRFieldBinding(field, CopyToStack_UIMainHandler_4, AssignFromStack_UIMainHandler_4);
            field = type.GetField("UIShowAni", flag);
            app.RegisterCLRFieldGetter(field, get_UIShowAni_5);
            app.RegisterCLRFieldSetter(field, set_UIShowAni_5);
            app.RegisterCLRFieldBinding(field, CopyToStack_UIShowAni_5, AssignFromStack_UIShowAni_5);
            field = type.GetField("UIExitAni", flag);
            app.RegisterCLRFieldGetter(field, get_UIExitAni_6);
            app.RegisterCLRFieldSetter(field, set_UIExitAni_6);
            app.RegisterCLRFieldBinding(field, CopyToStack_UIExitAni_6, AssignFromStack_UIExitAni_6);
            field = type.GetField("OnPageDestroy", flag);
            app.RegisterCLRFieldGetter(field, get_OnPageDestroy_7);
            app.RegisterCLRFieldSetter(field, set_OnPageDestroy_7);
            app.RegisterCLRFieldBinding(field, CopyToStack_OnPageDestroy_7, AssignFromStack_OnPageDestroy_7);


            app.RegisterCLRCreateDefaultInstance(type, () => new TinaX.UIKit.UIPage());
            app.RegisterCLRCreateArrayInstance(type, s => new TinaX.UIKit.UIPage[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* get_SortingLayer_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TinaX.UIKit.UIPage instance_of_this_method = (TinaX.UIKit.UIPage)typeof(TinaX.UIKit.UIPage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SortingLayer;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_SortingLayerValue_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TinaX.UIKit.UIPage instance_of_this_method = (TinaX.UIKit.UIPage)typeof(TinaX.UIKit.UIPage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SortingLayerValue;

            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* get_SortingLayerName_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TinaX.UIKit.UIPage instance_of_this_method = (TinaX.UIKit.UIPage)typeof(TinaX.UIKit.UIPage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.SortingLayerName;

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* get_DestroyDelayTime_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TinaX.UIKit.UIPage instance_of_this_method = (TinaX.UIKit.UIPage)typeof(TinaX.UIKit.UIPage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.DestroyDelayTime;

            __ret->ObjectType = ObjectTypes.Float;
            *(float*)&__ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static StackObject* TrySetXBehavior_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Boolean @inject = ptr_of_this_method->Value == 1;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TinaX.XComponent.XBehaviour @xBehaviour = (TinaX.XComponent.XBehaviour)typeof(TinaX.XComponent.XBehaviour).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            TinaX.UIKit.UIPage instance_of_this_method = (TinaX.UIKit.UIPage)typeof(TinaX.UIKit.UIPage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TrySetXBehavior(@xBehaviour, @inject);

            return __ret;
        }

        static StackObject* SendOpenUIMessage_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object[] @args = (System.Object[])typeof(System.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TinaX.UIKit.UIPage instance_of_this_method = (TinaX.UIKit.UIPage)typeof(TinaX.UIKit.UIPage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendOpenUIMessage(@args);

            return __ret;
        }

        static StackObject* SendCloseUIMessage_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Object[] @args = (System.Object[])typeof(System.Object[]).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TinaX.UIKit.UIPage instance_of_this_method = (TinaX.UIKit.UIPage)typeof(TinaX.UIKit.UIPage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.SendCloseUIMessage(@args);

            return __ret;
        }

        static StackObject* TryPlayExitAni_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            TinaX.UIKit.UIPage instance_of_this_method = (TinaX.UIKit.UIPage)typeof(TinaX.UIKit.UIPage).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.TryPlayExitAni();

            return __ret;
        }


        static object get_ScreenUI_0(ref object o)
        {
            return ((TinaX.UIKit.UIPage)o).ScreenUI;
        }

        static StackObject* CopyToStack_ScreenUI_0(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((TinaX.UIKit.UIPage)o).ScreenUI;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_ScreenUI_0(ref object o, object v)
        {
            ((TinaX.UIKit.UIPage)o).ScreenUI = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_ScreenUI_0(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @ScreenUI = ptr_of_this_method->Value == 1;
            ((TinaX.UIKit.UIPage)o).ScreenUI = @ScreenUI;
            return ptr_of_this_method;
        }

        static object get_FullScreenUI_1(ref object o)
        {
            return ((TinaX.UIKit.UIPage)o).FullScreenUI;
        }

        static StackObject* CopyToStack_FullScreenUI_1(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((TinaX.UIKit.UIPage)o).FullScreenUI;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_FullScreenUI_1(ref object o, object v)
        {
            ((TinaX.UIKit.UIPage)o).FullScreenUI = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_FullScreenUI_1(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @FullScreenUI = ptr_of_this_method->Value == 1;
            ((TinaX.UIKit.UIPage)o).FullScreenUI = @FullScreenUI;
            return ptr_of_this_method;
        }

        static object get_SortingLayerId_2(ref object o)
        {
            return ((TinaX.UIKit.UIPage)o).SortingLayerId;
        }

        static StackObject* CopyToStack_SortingLayerId_2(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((TinaX.UIKit.UIPage)o).SortingLayerId;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method;
            return __ret + 1;
        }

        static void set_SortingLayerId_2(ref object o, object v)
        {
            ((TinaX.UIKit.UIPage)o).SortingLayerId = (System.Int32)v;
        }

        static StackObject* AssignFromStack_SortingLayerId_2(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Int32 @SortingLayerId = ptr_of_this_method->Value;
            ((TinaX.UIKit.UIPage)o).SortingLayerId = @SortingLayerId;
            return ptr_of_this_method;
        }

        static object get_AllowMultiple_3(ref object o)
        {
            return ((TinaX.UIKit.UIPage)o).AllowMultiple;
        }

        static StackObject* CopyToStack_AllowMultiple_3(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((TinaX.UIKit.UIPage)o).AllowMultiple;
            __ret->ObjectType = ObjectTypes.Integer;
            __ret->Value = result_of_this_method ? 1 : 0;
            return __ret + 1;
        }

        static void set_AllowMultiple_3(ref object o, object v)
        {
            ((TinaX.UIKit.UIPage)o).AllowMultiple = (System.Boolean)v;
        }

        static StackObject* AssignFromStack_AllowMultiple_3(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Boolean @AllowMultiple = ptr_of_this_method->Value == 1;
            ((TinaX.UIKit.UIPage)o).AllowMultiple = @AllowMultiple;
            return ptr_of_this_method;
        }

        static object get_UIMainHandler_4(ref object o)
        {
            return ((TinaX.UIKit.UIPage)o).UIMainHandler;
        }

        static StackObject* CopyToStack_UIMainHandler_4(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((TinaX.UIKit.UIPage)o).UIMainHandler;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UIMainHandler_4(ref object o, object v)
        {
            ((TinaX.UIKit.UIPage)o).UIMainHandler = (UnityEngine.Object)v;
        }

        static StackObject* AssignFromStack_UIMainHandler_4(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            UnityEngine.Object @UIMainHandler = (UnityEngine.Object)typeof(UnityEngine.Object).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((TinaX.UIKit.UIPage)o).UIMainHandler = @UIMainHandler;
            return ptr_of_this_method;
        }

        static object get_UIShowAni_5(ref object o)
        {
            return ((TinaX.UIKit.UIPage)o).UIShowAni;
        }

        static StackObject* CopyToStack_UIShowAni_5(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((TinaX.UIKit.UIPage)o).UIShowAni;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UIShowAni_5(ref object o, object v)
        {
            ((TinaX.UIKit.UIPage)o).UIShowAni = (TinaX.UIKit.Animation.UIAnimationBase)v;
        }

        static StackObject* AssignFromStack_UIShowAni_5(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            TinaX.UIKit.Animation.UIAnimationBase @UIShowAni = (TinaX.UIKit.Animation.UIAnimationBase)typeof(TinaX.UIKit.Animation.UIAnimationBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((TinaX.UIKit.UIPage)o).UIShowAni = @UIShowAni;
            return ptr_of_this_method;
        }

        static object get_UIExitAni_6(ref object o)
        {
            return ((TinaX.UIKit.UIPage)o).UIExitAni;
        }

        static StackObject* CopyToStack_UIExitAni_6(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((TinaX.UIKit.UIPage)o).UIExitAni;
            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_UIExitAni_6(ref object o, object v)
        {
            ((TinaX.UIKit.UIPage)o).UIExitAni = (TinaX.UIKit.Animation.UIAnimationBase)v;
        }

        static StackObject* AssignFromStack_UIExitAni_6(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            TinaX.UIKit.Animation.UIAnimationBase @UIExitAni = (TinaX.UIKit.Animation.UIAnimationBase)typeof(TinaX.UIKit.Animation.UIAnimationBase).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((TinaX.UIKit.UIPage)o).UIExitAni = @UIExitAni;
            return ptr_of_this_method;
        }

        static object get_OnPageDestroy_7(ref object o)
        {
            return ((TinaX.UIKit.UIPage)o).OnPageDestroy;
        }

        static StackObject* CopyToStack_OnPageDestroy_7(ref object o, ILIntepreter __intp, StackObject* __ret, IList<object> __mStack)
        {
            var result_of_this_method = ((TinaX.UIKit.UIPage)o).OnPageDestroy;
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static void set_OnPageDestroy_7(ref object o, object v)
        {
            ((TinaX.UIKit.UIPage)o).OnPageDestroy = (System.Action)v;
        }

        static StackObject* AssignFromStack_OnPageDestroy_7(ref object o, ILIntepreter __intp, StackObject* ptr_of_this_method, IList<object> __mStack)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            System.Action @OnPageDestroy = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            ((TinaX.UIKit.UIPage)o).OnPageDestroy = @OnPageDestroy;
            return ptr_of_this_method;
        }



        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new TinaX.UIKit.UIPage();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

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
    unsafe class TinaX_TimeMachine_Binding
    {
        public static void Register(ILRuntime.Runtime.Enviorment.AppDomain app)
        {
            BindingFlags flag = BindingFlags.Public | BindingFlags.Instance | BindingFlags.Static | BindingFlags.DeclaredOnly;
            MethodBase method;
            Type[] args;
            Type type = typeof(TinaX.TimeMachine);
            args = new Type[]{typeof(System.Action), typeof(System.Int32)};
            method = type.GetMethod("RegisterUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterUpdate_0);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("RemoveUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveUpdate_1);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveUpdate_2);
            args = new Type[]{typeof(System.Action), typeof(System.Int32)};
            method = type.GetMethod("RegisterLateUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterLateUpdate_3);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("RemoveLateUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveLateUpdate_4);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveLateUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveLateUpdate_5);
            args = new Type[]{typeof(System.Action), typeof(System.Int32)};
            method = type.GetMethod("RegisterFixedUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterFixedUpdate_6);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("RemoveFixedUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveFixedUpdate_7);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveFixedUpdate", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveFixedUpdate_8);
            args = new Type[]{typeof(System.Action), typeof(System.Int32)};
            method = type.GetMethod("RegisterUpdateAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterUpdateAction_9);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("RemoveUpdateAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveUpdateAction_10);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveUpdateAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveUpdateAction_11);
            args = new Type[]{typeof(System.Action), typeof(System.Int32)};
            method = type.GetMethod("RegisterLateUpdateAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterLateUpdateAction_12);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("RemoveLateUpdateAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveLateUpdateAction_13);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveLateUpdateAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveLateUpdateAction_14);
            args = new Type[]{typeof(System.Action), typeof(System.Int32)};
            method = type.GetMethod("RegisterFixedUpdateAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RegisterFixedUpdateAction_15);
            args = new Type[]{typeof(System.Action)};
            method = type.GetMethod("RemoveFixedUpdateAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveFixedUpdateAction_16);
            args = new Type[]{typeof(System.Int32)};
            method = type.GetMethod("RemoveFixedUpdateAction", flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, RemoveFixedUpdateAction_17);



            app.RegisterCLRCreateDefaultInstance(type, () => new TinaX.TimeMachine());
            app.RegisterCLRCreateArrayInstance(type, s => new TinaX.TimeMachine[s]);

            args = new Type[]{};
            method = type.GetConstructor(flag, null, args, null);
            app.RegisterCLRMethodRedirection(method, Ctor_0);

        }


        static StackObject* RegisterUpdate_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @order = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action @updateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = TinaX.TimeMachine.RegisterUpdate(@updateAction, @order);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveUpdate_1(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @updateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            TinaX.TimeMachine.RemoveUpdate(@updateAction);

            return __ret;
        }

        static StackObject* RemoveUpdate_2(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @action_id = ptr_of_this_method->Value;


            TinaX.TimeMachine.RemoveUpdate(@action_id);

            return __ret;
        }

        static StackObject* RegisterLateUpdate_3(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @order = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action @lateupdateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = TinaX.TimeMachine.RegisterLateUpdate(@lateupdateAction, @order);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveLateUpdate_4(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @lateupdateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            TinaX.TimeMachine.RemoveLateUpdate(@lateupdateAction);

            return __ret;
        }

        static StackObject* RemoveLateUpdate_5(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @action_id = ptr_of_this_method->Value;


            TinaX.TimeMachine.RemoveLateUpdate(@action_id);

            return __ret;
        }

        static StackObject* RegisterFixedUpdate_6(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @order = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action @fixedupdateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            var result_of_this_method = TinaX.TimeMachine.RegisterFixedUpdate(@fixedupdateAction, @order);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveFixedUpdate_7(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @fixedupdateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);


            TinaX.TimeMachine.RemoveFixedUpdate(@fixedupdateAction);

            return __ret;
        }

        static StackObject* RemoveFixedUpdate_8(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 1);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @action_id = ptr_of_this_method->Value;


            TinaX.TimeMachine.RemoveFixedUpdate(@action_id);

            return __ret;
        }

        static StackObject* RegisterUpdateAction_9(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @order = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action @updateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            TinaX.TimeMachine instance_of_this_method = (TinaX.TimeMachine)typeof(TinaX.TimeMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RegisterUpdateAction(@updateAction, @order);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveUpdateAction_10(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @updateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TinaX.TimeMachine instance_of_this_method = (TinaX.TimeMachine)typeof(TinaX.TimeMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveUpdateAction(@updateAction);

            return __ret;
        }

        static StackObject* RemoveUpdateAction_11(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @actionId = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TinaX.TimeMachine instance_of_this_method = (TinaX.TimeMachine)typeof(TinaX.TimeMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveUpdateAction(@actionId);

            return __ret;
        }

        static StackObject* RegisterLateUpdateAction_12(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @order = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action @lateupdateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            TinaX.TimeMachine instance_of_this_method = (TinaX.TimeMachine)typeof(TinaX.TimeMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RegisterLateUpdateAction(@lateupdateAction, @order);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveLateUpdateAction_13(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @lateupdateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TinaX.TimeMachine instance_of_this_method = (TinaX.TimeMachine)typeof(TinaX.TimeMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveLateUpdateAction(@lateupdateAction);

            return __ret;
        }

        static StackObject* RemoveLateUpdateAction_14(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @actionId = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TinaX.TimeMachine instance_of_this_method = (TinaX.TimeMachine)typeof(TinaX.TimeMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveLateUpdateAction(@actionId);

            return __ret;
        }

        static StackObject* RegisterFixedUpdateAction_15(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 3);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @order = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            System.Action @fixedupdateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 3);
            TinaX.TimeMachine instance_of_this_method = (TinaX.TimeMachine)typeof(TinaX.TimeMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            var result_of_this_method = instance_of_this_method.RegisterFixedUpdateAction(@fixedupdateAction, @order);

            object obj_result_of_this_method = result_of_this_method;
            if(obj_result_of_this_method is CrossBindingAdaptorType)
            {    
                return ILIntepreter.PushObject(__ret, __mStack, ((CrossBindingAdaptorType)obj_result_of_this_method).ILInstance);
            }
            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }

        static StackObject* RemoveFixedUpdateAction_16(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Action @fixedupdateAction = (System.Action)typeof(System.Action).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TinaX.TimeMachine instance_of_this_method = (TinaX.TimeMachine)typeof(TinaX.TimeMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveFixedUpdateAction(@fixedupdateAction);

            return __ret;
        }

        static StackObject* RemoveFixedUpdateAction_17(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* ptr_of_this_method;
            StackObject* __ret = ILIntepreter.Minus(__esp, 2);

            ptr_of_this_method = ILIntepreter.Minus(__esp, 1);
            System.Int32 @actionId = ptr_of_this_method->Value;

            ptr_of_this_method = ILIntepreter.Minus(__esp, 2);
            TinaX.TimeMachine instance_of_this_method = (TinaX.TimeMachine)typeof(TinaX.TimeMachine).CheckCLRTypes(StackObject.ToObject(ptr_of_this_method, __domain, __mStack));
            __intp.Free(ptr_of_this_method);

            instance_of_this_method.RemoveFixedUpdateAction(@actionId);

            return __ret;
        }




        static StackObject* Ctor_0(ILIntepreter __intp, StackObject* __esp, IList<object> __mStack, CLRMethod __method, bool isNewObj)
        {
            ILRuntime.Runtime.Enviorment.AppDomain __domain = __intp.AppDomain;
            StackObject* __ret = ILIntepreter.Minus(__esp, 0);

            var result_of_this_method = new TinaX.TimeMachine();

            return ILIntepreter.PushObject(__ret, __mStack, result_of_this_method);
        }


    }
}

﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class TestExportScriptWrap
{
	public static void Register(LuaState L)
	{
		L.BeginStaticLibs("TestExportScript");
		L.RegFunction("TestDelegate", TestDelegate);
		L.RegFunction("PrintGameobject", PrintGameobject);
		L.RegFunction("GetDictionary", GetDictionary);
		L.RegVar("myDelegate", get_myDelegate, set_myDelegate);
		L.RegVar("intDelegate", get_intDelegate, set_intDelegate);
		L.RegVar("cameraDelegate", get_cameraDelegate, set_cameraDelegate);
		L.RegFunction("CustomDelegate", TestExportScript_CustomDelegate);
		L.EndStaticLibs();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);

			if (count == 2 && TypeChecker.CheckTypes<System.Action<float>, float>(L, 1))
			{
				System.Action<float> arg0 = (System.Action<float>)ToLua.ToObject(L, 1);
				float arg1 = (float)LuaDLL.lua_tonumber(L, 2);
				TestExportScript.TestDelegate(arg0, arg1);
				return 0;
			}
			else if (count == 2 && TypeChecker.CheckTypes<TestExportScript.CustomDelegate, string>(L, 1))
			{
				TestExportScript.CustomDelegate arg0 = (TestExportScript.CustomDelegate)ToLua.ToObject(L, 1);
				string arg1 = ToLua.ToString(L, 2);
				TestExportScript.TestDelegate(arg0, arg1);
				return 0;
			}
			else
			{
				return LuaDLL.luaL_throw(L, "invalid arguments to method: TestExportScript.TestDelegate");
			}
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int PrintGameobject(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			UnityEngine.GameObject arg0 = (UnityEngine.GameObject)ToLua.CheckObject(L, 1, typeof(UnityEngine.GameObject));
			TestExportScript.PrintGameobject(arg0);
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetDictionary(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 0);
			System.Collections.Generic.Dictionary<int,string> o = TestExportScript.GetDictionary();
			ToLua.PushSealed(L, o);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_myDelegate(IntPtr L)
	{
		try
		{
			ToLua.Push(L, TestExportScript.myDelegate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_intDelegate(IntPtr L)
	{
		try
		{
			ToLua.Push(L, TestExportScript.intDelegate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_cameraDelegate(IntPtr L)
	{
		try
		{
			ToLua.Push(L, TestExportScript.cameraDelegate);
			return 1;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_myDelegate(IntPtr L)
	{
		try
		{
			TestExportScript.CustomDelegate arg0 = (TestExportScript.CustomDelegate)ToLua.CheckDelegate<TestExportScript.CustomDelegate>(L, 2);
			TestExportScript.myDelegate = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_intDelegate(IntPtr L)
	{
		try
		{
			System.Action<int> arg0 = (System.Action<int>)ToLua.CheckDelegate<System.Action<int>>(L, 2);
			TestExportScript.intDelegate = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_cameraDelegate(IntPtr L)
	{
		try
		{
			System.Action<UnityEngine.Camera> arg0 = (System.Action<UnityEngine.Camera>)ToLua.CheckDelegate<System.Action<UnityEngine.Camera>>(L, 2);
			TestExportScript.cameraDelegate = arg0;
			return 0;
		}
		catch (Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int TestExportScript_CustomDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateTraits<TestExportScript.CustomDelegate>.Create(func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateTraits<TestExportScript.CustomDelegate>.Create(func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}


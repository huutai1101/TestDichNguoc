using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class TestObject1
{
    public static int ID;
    public static string Name;
}

public class TestObject2
{
    public int ID;
    public string Name;
} 

public class Test3 : MonoBehaviour
{
    TestObject2 obj;

    public void TestStatic()
    {
        TestObject1.ID = 1;
        TestObject1.Name = "test static";
        Debug.Log(obj.ID);
        Debug.Log(obj.Name);
    }

    /*void Test3$$TestStatic(long param_1)

    {
        undefined4* puVar1;
        undefined8 uVar2;
        undefined4 uStack_24;

        if ((bRam0000000000fc4b9a & 1) == 0)
        {
            thunk_FUN_008578f8(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_008578f8(&int_TypeInfo);
            thunk_FUN_008578f8(&TestObject1_TypeInfo);
            thunk_FUN_008578f8(&StringLiteral_3190);
            bRam0000000000fc4b9a = 1;
        }
        puVar1 = *(undefined4**)(_TestObject1_TypeInfo + 0xb8);
        *puVar1 = 1;
        *(undefined8*)(puVar1 + 2) = _StringLiteral_3190;
        thunk_FUN_008acee0();
        if (*(long*)(param_1 + 0x20) != 0)
        {
            uStack_24 = *(undefined4*)(*(long*)(param_1 + 0x20) + 0x10);
            uVar2 = thunk_FUN_0086db2c(_int_TypeInfo, &uStack_24);
            if (*(int*)(_UnityEngine.Debug_TypeInfo + 0xe0) == 0)
            {
                thunk_FUN_0084c3a4(_UnityEngine.Debug_TypeInfo);
            }
            UnityEngine.Debug$$Log(uVar2, 0);
            if (*(long*)(param_1 + 0x20) != 0)
            {
                UnityEngine.Debug$$Log(*(undefined8*)(*(long*)(param_1 + 0x20) + 0x18), 0);
                return;
            }
        }
        *//* WARNING: Subroutine does not return *//*
        FUN_0081aed0();
    }*/

    public void TestNonStatic()
    {
        obj = new TestObject2();
        obj.ID = 1;
        obj.Name = "Test non static";
        Debug.Log(obj.ID);
        Debug.Log(obj.Name);
    }

/*    void Test3$$TestNonStatic(long param_1)

    {
        long lVar1;
        undefined8 uVar2;
        long* plVar3;
        undefined4 uStack_24;

        if ((bRam0000000000fc4b9b & 1) == 0)
        {
            thunk_FUN_008578f8(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_008578f8(&int_TypeInfo);
            thunk_FUN_008578f8(&TestObject2_TypeInfo);
            thunk_FUN_008578f8(&StringLiteral_1756);
            bRam0000000000fc4b9b = 1;
        }
        lVar1 = thunk_FUN_0086defc(_TestObject2_TypeInfo);
        System.Object$$.ctor(lVar1, 0);
        plVar3 = (long*)(param_1 + 0x20);
        *plVar3 = lVar1;
        thunk_FUN_008acee0(plVar3, lVar1);
        lVar1 = *plVar3;
        if (lVar1 != 0)
        {
            *(undefined4*)(lVar1 + 0x10) = 1;
            *(undefined8*)(lVar1 + 0x18) = _StringLiteral_1756;
            thunk_FUN_008acee0();
            if (*plVar3 != 0)
            {
                uStack_24 = *(undefined4*)(*plVar3 + 0x10);
                uVar2 = thunk_FUN_0086db2c(_int_TypeInfo, &uStack_24);
                if (*(int*)(_UnityEngine.Debug_TypeInfo + 0xe0) == 0)
                {
                    thunk_FUN_0084c3a4(_UnityEngine.Debug_TypeInfo);
                }
                UnityEngine.Debug$$Log(uVar2, 0);
                if (*plVar3 != 0)
                {
                    UnityEngine.Debug$$Log(*(undefined8*)(*plVar3 + 0x18), 0);
                    return;
                }
            }
        }
        *//* WARNING: Subroutine does not return *//*
        FUN_0081aed0();
    }*/
}

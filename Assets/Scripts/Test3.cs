using System.Runtime.InteropServices.WindowsRuntime;
using Unity.VisualScripting;
using UnityEngine;

public static class TestObject1
{
    public static int ID;
    public static string Name;

/*    [Token(Token = "0x4000001")]
    [FieldOffset(Offset = "0x0")]
    public static int ID;
    [Token(Token = "0x4000002")]
    [FieldOffset(Offset = "0x8")]
    public static string Name;*/
}

public class TestObject2
{
    public int ID;
    public string Name;

/*    [Token(Token = "0x4000003")]
    [FieldOffset(Offset = "0x10")]
    public int ID;

    [Token(Token = "0x4000004")]
    [FieldOffset(Offset = "0x18")]
    public string Name;*/
}

public class TestObject3
{
    public int ID;
    public int phone;
    public string Name;
    public string Address;

/*    [Token(Token = "0x4000005")]
    [FieldOffset(Offset = "0x10")]
    public int ID;

    [Token(Token = "0x4000006")]
    [FieldOffset(Offset = "0x14")]
    public int phone;

    [Token(Token = "0x4000007")]
    [FieldOffset(Offset = "0x18")]
    public string Name;

    [Token(Token = "0x4000008")]
    [FieldOffset(Offset = "0x20")]
    public string Address;*/
}

public class Test3 : MonoBehaviour
{
    TestObject2 obj;
    TestObject3 obj2;

/*    [Token(Token = "0x4000009")]
    [FieldOffset(Offset = "0x20")]
    private TestObject2 obj;

    [Token(Token = "0x400000A")]
    [FieldOffset(Offset = "0x28")]
    private TestObject3 obj2;*/

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

    //Origin function
    public void TestNonStatic2()
    {
        obj2 = new TestObject3();
        obj2.ID = 1;
        obj2.phone = 56899;
        obj2.Name = "Test non static";
        obj2.Address = "Le Van Si";
        Debug.Log(obj2.ID);
        Debug.Log(obj2.phone);
        Debug.Log(obj2.Name);
        Debug.Log(obj2.Address);
    }

    /*    undefined8 Test3$$TestNonStatic2(long param_1)

        {
            long lVar1;
            undefined8 uVar2;
            long* plVar3;
            undefined4 uStack_28;
            undefined4 uStack_24;

            if ((bRam0000000000fc615c & 1) == 0)
            {
                thunk_FUN_008580bc(&UnityEngine.Debug_TypeInfo);
                thunk_FUN_008580bc(&int_TypeInfo);
                thunk_FUN_008580bc(&TestObject3_TypeInfo);
                thunk_FUN_008580bc(&StringLiteral_1757);
                thunk_FUN_008580bc(&StringLiteral_1278);
                bRam0000000000fc615c = 1;
            }
            lVar1 = thunk_FUN_0086e6c0(_TestObject3_TypeInfo);
            System.Object$$.ctor(lVar1, 0);
            plVar3 = (long*)(param_1 + 0x28);
            *plVar3 = lVar1;
            thunk_FUN_008ad6a4(plVar3, lVar1);
            lVar1 = *plVar3;
            if (lVar1 != 0)
            {
                *(undefined8*)(lVar1 + 0x10) = 0xde4300000001;
                *(undefined8*)(lVar1 + 0x18) = _StringLiteral_1757;
                thunk_FUN_008ad6a4();
                if (*plVar3 != 0)
                {
                    *(undefined8*)(*plVar3 + 0x20) = _StringLiteral_1278;
                    thunk_FUN_008ad6a4();
                    if (*plVar3 != 0)
                    {
                        uStack_24 = *(undefined4*)(*plVar3 + 0x10);
                        uVar2 = thunk_FUN_0086e2f0(_int_TypeInfo, &uStack_24);
                        if (*(int*)(_UnityEngine.Debug_TypeInfo + 0xe0) == 0)
                        {
                            thunk_FUN_0084cb68(_UnityEngine.Debug_TypeInfo);
                        }
                        UnityEngine.Debug$$Log(uVar2, 0);
                        if (*plVar3 != 0)
                        {
                            uStack_28 = *(undefined4*)(*plVar3 + 0x14);
                            uVar2 = thunk_FUN_0086e2f0(_int_TypeInfo, &uStack_28);
                            UnityEngine.Debug$$Log(uVar2, 0);
                            if (*plVar3 != 0)
                            {
                                UnityEngine.Debug$$Log(*(undefined8*)(*plVar3 + 0x18), 0);
                                if (*plVar3 != 0)
                                {
                                    uVar2 = UnityEngine.Debug$$Log(*(undefined8*)(*plVar3 + 0x20), 0);
                                    return uVar2;
                                }
                            }
                        }
                    }
                }
            }
            uVar2 = FUN_0081b694();
            if ((bRam0000000000fc8498 & 1) == 0)
            {
                thunk_FUN_008580bc(&UnityEngine.Object_TypeInfo, 0);
                bRam0000000000fc8498 = 1;
            }
            if (*(int*)(_UnityEngine.Object_TypeInfo + 0xe0) == 0)
            {
                thunk_FUN_0084cb68();
            }
            return uVar2;
        }*/

    private void TestIf()
    {
        int value1 = 0;
        int value2 = 0;
        int value3 = 0;
        int random = UnityEngine.Random.Range(0, 3);

        if(random == 0)
        {
            value1 = 2;
            value2 = 1;
            value3 = 3;
            return;
        }
        else if(random == 1)
        {
            value1 = 3;
            value2 = 2;
            value3 = 1;
        }
         
        if (random == 2)
        {
            value1 = 1;
            value2 = 2;
            value3 = 3;
            return;
        }
        Debug.Log(value1);
        Debug.Log(value2);
        Debug.Log(value3);
    }

  /*  void Test3$$TestIf(void)
    {
        int iVar1;
        undefined8 uVar2;
        uint uStack_34;
        int iStack_28;
        undefined4 uStack_24;

        if ((bRam0000000000fc517d & 1) == 0)
        {
            thunk_FUN_00857b68(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_00857b68(&int_TypeInfo);
            bRam0000000000fc517d = 1;
        }
        iVar1 = UnityEngine.Random$$Range(0, 3, 0);
        if ((iVar1 != 0) && (iVar1 != 2))
        {
            uStack_24 = 3;
            if (iVar1 != 1)
            {
                uStack_24 = 0;
            }
            uVar2 = thunk_FUN_0086dd9c(int_TypeInfo, &uStack_24);
            if (*(int*)(UnityEngine.Debug_TypeInfo + 0xe0) == 0)
            {
                thunk_FUN_0084c614(UnityEngine.Debug_TypeInfo);
            }
            UnityEngine.Debug$$Log(uVar2, 0);
            iStack_28 = (uint)(iVar1 == 1) << 1; // = 2
            uVar2 = thunk_FUN_0086dd9c(int_TypeInfo, &iStack_28);
            UnityEngine.Debug$$Log(uVar2, 0);
            uStack_34 = (uint)(iVar1 == 1);// = 1
            uVar2 = thunk_FUN_0086dd9c(int_TypeInfo, &uStack_34);
            UnityEngine.Debug$$Log(uVar2, 0);
        }
        return;
    }*/
}

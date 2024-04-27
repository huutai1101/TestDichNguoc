using System;
using UnityEngine;

public class Test4 : MonoBehaviour
{
    string stringSplit = "abe dce";
    private void TestSwitch(int input)
    {
        int value1 = 0;
        int value2 = 0;
        switch(input)
        {
            case 0:
                value1 = 1;
                value2 = 1;
                break;
            case 1:
                value1 = 5;
                value2 = 5;
                break;
            default:
                value1 = -5;
                value2 = -5;
                break;
            case -1:
                return;
        }
        int sum = value1 + value2;
        Debug.Log(sum);
    }

/*    void Test4$$TestSwitch(undefined8 param_1, int param_2)
    {
        undefined8 uVar1;
        undefined4 uStack_14;

        if ((bRam0000000000fc560e & 1) == 0)
        {
            thunk_FUN_00857d70(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_00857d70(&int_TypeInfo);
            bRam0000000000fc560e = 1;
        }
        if (param_2 != -1)
        {
            if (param_2 == 1)
            {
                uStack_14 = 10;
            }
            else if (param_2 == 0)
            {
                uStack_14 = 2;
            }
            else
            {
                uStack_14 = 0xfffffff6;
            }
            uVar1 = thunk_FUN_0086dfa4(int_TypeInfo, &uStack_14);
            if (*(int*)(UnityEngine.Debug_TypeInfo + 0xe0) == 0)
            {
                thunk_FUN_0084c81c(UnityEngine.Debug_TypeInfo);
            }
            UnityEngine.Debug$$Log(uVar1, 0);
        }
        return;
    }*/

    private string TestStringSplit()
    {
        string[] split = stringSplit.Split(' ');
        string first = split[0];
        return first;
    }

/*    undefined8 Test4$$TestStringSplit(long param_1)

    {
        long lVar1;

        if ((*(long*)(param_1 + 0x20) != 0) &&
           (lVar1 = System.String$$Split(*(long*)(param_1 + 0x20), 0x20, 0, 0), lVar1 != 0)) {
            if (*(int*)(lVar1 + 0x18) != 0)
            {
                return *(undefined8*)(lVar1 + 0x20);
            }
            *//* WARNING: Subroutine does not return *//*
            FUN_0081b350();
        }
        *//* WARNING: Subroutine does not return *//*
        FUN_0081b348();
    }*/

    private string TestStringConcat()
    {
        string a = "Hello";
        string b = "My";
        string c = "World";
        string result = String.Concat(a, b, c);
        return result;
    }

/*    void Test4$$TestStringConcat(void)
    {
        if ((bRam0000000000fc560f & 1) == 0)
        {
            thunk_FUN_00857d70(&StringLiteral_1039);
            thunk_FUN_00857d70(&StringLiteral_2141);
            thunk_FUN_00857d70(&StringLiteral_1373);
            bRam0000000000fc560f = 1;
        }
        System.String$$Concat(_StringLiteral_1039, _StringLiteral_1373, _StringLiteral_2141, 0);
        return;
    }*/

    private string TestSubstring()
    {
        string sub = stringSplit.Substring(0, 2);
        return sub;
    }

/*    void Test4$$TestSubstring(long param_1)
    {
        if (*(long*)(param_1 + 0x20) != 0)
        {
            System.String$$Substring(*(long*)(param_1 + 0x20), 0, 2, 0);
            return;
        }
        *//* WARNING: Subroutine does not return *//*
        FUN_0081b348();
    }*/
}

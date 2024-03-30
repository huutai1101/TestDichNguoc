using System.Collections.Generic;
using UnityEngine;

public class Test2 : MonoBehaviour
{
    private void PhepCong()
    {
        int a = 5;
        int b = a + 3;
        Debug.Log(a);
        Debug.Log(b);
    }

   /* void Test2$$PhepCong(void)

    {
        undefined8 uVar1;
        undefined4 uStack_28;
        undefined4 uStack_24;

        if ((bRam0000000000fc5615 & 1) == 0)
        {
            thunk_FUN_00857c24(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_00857c24(&int_TypeInfo);
            bRam0000000000fc5615 = 1;
        }
        uStack_24 = 5;
        uVar1 = thunk_FUN_0086de58(int_TypeInfo, &uStack_24);
        if (*(int*)(UnityEngine.Debug_TypeInfo + 0xe0) == 0)
        {
            thunk_FUN_0084c6d0(UnityEngine.Debug_TypeInfo);
        }
        UnityEngine.Debug$$Log(uVar1, 0);
        uStack_28 = 8;
        uVar1 = thunk_FUN_0086de58(int_TypeInfo, &uStack_28);
        UnityEngine.Debug$$Log(uVar1, 0);
        return;
    }*/

    private void PhepCongChuoi()
    {
        string a = "Nguyen";
        string b = " Tai";
        string c = a + b;
        Debug.Log(c);
    }

/*    void Test2$$PhepCongChuoi(void)

    {
        undefined8 uVar1;

        if ((bRam0000000000fc5616 & 1) == 0)
        {
            thunk_FUN_00857c24(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_00857c24(&StringLiteral_28);
            thunk_FUN_00857c24(&StringLiteral_1391);
            bRam0000000000fc5616 = 1;
        }
        uVar1 = System.String$$Concat(_StringLiteral_1391, _StringLiteral_28, 0);
        if (*(int*)(UnityEngine.Debug_TypeInfo + 0xe0) == 0)
        {
            thunk_FUN_0084c6d0(UnityEngine.Debug_TypeInfo);
        }
        UnityEngine.Debug$$Log(uVar1, 0);
        return;
    }*/

    private void CongList()
    {
        List<int> a = new List<int>() { 1, 2, 3, };
        int tong = 0;
        for (int i = 0; i < a.Count; i++)
        {
            tong += a[i];
        }
        Debug.Log(tong);
    }

/*  void Test2$$CongList(void)
    {
        uint uVar1;
        int iVar2;
        long lVar3;
        undefined8 uVar4;
        long lVar5;
        long lVar6;
        int iVar7;
        int iVar8;
        int iStack_34;

        if ((DAT_00fc5617 & 1) == 0)
        {
            thunk_FUN_00857c24(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_00857c24(&int_TypeInfo);
            thunk_FUN_00857c24(&Method$System.Collections.Generic.List<int>.Add());
            thunk_FUN_00857c24(&Method$System.Collections.Generic.List<int>..ctor());
            thunk_FUN_00857c24(&Method$System.Collections.Generic.List<int>.get_Count());
            thunk_FUN_00857c24(&Method$System.Collections.Generic.List<int>.get_Item());
            thunk_FUN_00857c24(&System.Collections.Generic.List<int>_TypeInfo);
            DAT_00fc5617 = 1;
        }
        lVar3 = thunk_FUN_0086e228(System.Collections.Generic.List<int>_TypeInfo);
        System.Collections.Generic.List<int>$$.ctor
                  (lVar3, Method$System.Collections.Generic.List<int>..ctor());
        lVar6 = Method$System.Collections.Generic.List<int>.Add();
        if (lVar3 != 0)
        {
            lVar5 = *(long*)(lVar3 + 0x10);
            *(int*)(lVar3 + 0x1c) = *(int*)(lVar3 + 0x1c) + 1;
            if (lVar5 != 0)
            {
                uVar1 = *(uint*)(lVar3 + 0x18);
                if (uVar1 < *(uint*)(lVar5 + 0x18))
                {
                    *(uint*)(lVar3 + 0x18) = uVar1 + 1;
                    *(undefined4*)(lVar5 + (long)(int)uVar1 * 4 + 0x20) = 1;
                    *(int*)(lVar3 + 0x1c) = *(int*)(lVar3 + 0x1c) + 1;
                }
                else
                {
                    System.Collections.Generic.List<int>$$AddWithResize
                              (lVar3, 1, *(undefined8*)(*(long*)(*(long*)(lVar6 + 0x20) + 0xc0) + 0x70));
                    lVar6 = Method$System.Collections.Generic.List<int>.Add();
                    lVar5 = *(long*)(lVar3 + 0x10);
                    *(int*)(lVar3 + 0x1c) = *(int*)(lVar3 + 0x1c) + 1;
                    if (lVar5 == 0) goto LAB_009205d0;
                }
                uVar1 = *(uint*)(lVar3 + 0x18);
                if (uVar1 < *(uint*)(lVar5 + 0x18))
                {
                    *(uint*)(lVar3 + 0x18) = uVar1 + 1;
                    *(undefined4*)(lVar5 + (long)(int)uVar1 * 4 + 0x20) = 2;
                    *(int*)(lVar3 + 0x1c) = *(int*)(lVar3 + 0x1c) + 1;
                }
                else
                {
                    System.Collections.Generic.List<int>$$AddWithResize
                              (lVar3, 2, *(undefined8*)(*(long*)(*(long*)(lVar6 + 0x20) + 0xc0) + 0x70));
                    lVar6 = Method$System.Collections.Generic.List<int>.Add();
                    lVar5 = *(long*)(lVar3 + 0x10);
                    *(int*)(lVar3 + 0x1c) = *(int*)(lVar3 + 0x1c) + 1;
                    if (lVar5 == 0) goto LAB_009205d0;
                }
                uVar1 = *(uint*)(lVar3 + 0x18);
                if (uVar1 < *(uint*)(lVar5 + 0x18))
                {
                    *(uint*)(lVar3 + 0x18) = uVar1 + 1;
                    *(undefined4*)(lVar5 + (long)(int)uVar1 * 4 + 0x20) = 3;
                }
                else
                {
                    System.Collections.Generic.List<int>$$AddWithResize
                              (lVar3, 3, *(undefined8*)(*(long*)(*(long*)(lVar6 + 0x20) + 0xc0) + 0x70));
                }
                iVar8 = 0;
                if (0 < *(int*)(lVar3 + 0x18))
                {
                    iVar7 = 0;
                    do
                    {
                        iVar2 = System.Collections.Generic.List<int>$$get_Item
                                          (lVar3, iVar7, Method$System.Collections.Generic.List<int>.get_Item());
                        iVar7 = iVar7 + 1;
                        iVar8 = iVar2 + iVar8;
                    } while (iVar7 < *(int*)(lVar3 + 0x18));
                }
                iStack_34 = iVar8;
                uVar4 = thunk_FUN_0086de58(int_TypeInfo, &iStack_34);
                if (*(int*)(UnityEngine.Debug_TypeInfo + 0xe0) == 0)
                {
                    thunk_FUN_0084c6d0(UnityEngine.Debug_TypeInfo);
                }
                UnityEngine.Debug$$Log(uVar4, 0);
                return;
            }
        }
        LAB_009205d0:
        *//* WARNING: Subroutine does not return *//*
        FUN_0081b1fc();
    }*/

    private void CongMangArray()
    {
        int[] a = new int[] { 1, 2 };
        int tong = a[0] + a[1];
        Debug.Log(tong);
    }

    /*void Test2$$CongMangArray(void)
    {
        long lVar1;
        undefined8 uVar2;
        undefined4 uStack_14;

        if ((DAT_00fc5618 & 1) == 0)
        {
            thunk_FUN_00857c24(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_00857c24(&int[]_TypeInfo);
            thunk_FUN_00857c24(&int_TypeInfo);
            DAT_00fc5618 = 1;
        }
        lVar1 = FUN_0081b050(int[]_TypeInfo, 2);
        if (lVar1 != 0)
        {
            if ((*(int*)(lVar1 + 0x18) != 0) &&
               (*(undefined4*)(lVar1 + 0x20) = 1, *(int*)(lVar1 + 0x18) != 1))
            {
                *(undefined4*)(lVar1 + 0x24) = 2;
                uStack_14 = 3;
                uVar2 = thunk_FUN_0086de58(int_TypeInfo, &uStack_14);
                if (*(int*)(UnityEngine.Debug_TypeInfo + 0xe0) == 0)
                {
                    thunk_FUN_0084c6d0(UnityEngine.Debug_TypeInfo);
                }
                UnityEngine.Debug$$Log(uVar2, 0);
                return;
            }
            *//* WARNING: Subroutine does not return *//*
            FUN_0081b204();
        }
        *//* WARNING: Subroutine does not return *//*
        FUN_0081b1fc();
    }*/

    private void CongCharArray()
    {
        char[] a = new char[3] { 's', '7','D'};
        int kq1 = (int)(a[0] + a[1]);
        int kq2 = (int)(a[0]) + (int)(a[1]) + (int)(a[2]) + 7;
        Debug.Log(kq1);
        Debug.Log(kq2);
    }

    /* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

/*    undefined8 Test2$$CongCharArray(void)

    {
        int iVar1;
        uint uVar2;
        ushort uVar3;
        long lVar4;
        undefined8 uVar5;
        int iStack_28;
        int iStack_24;

        if ((bRam0000000000fc4b99 & 1) == 0)
        {
            FUN_0081ac94(&char[]_TypeInfo);
            FUN_0081ac94(&UnityEngine.Debug_TypeInfo);
            FUN_0081ac94(&int_TypeInfo);
            FUN_0081ac94(&
                         Field$< PrivateImplementationDetails > .614B285A8CE7F035B6B3764855262635C5ED525E77F13B F0B0C06A05E65C1F26
                        );
            bRam0000000000fc4b99 = 1;
        }
        lVar4 = FUN_0081ad24(_char[]_TypeInfo, 3);
        System.Runtime.CompilerServices.RuntimeHelpers$$InitializeArray
                  (lVar4,
                   _Field$< PrivateImplementationDetails > .614B285A8CE7F035B6B3764855262635C5ED525E77F13BF0B 0C06A05E65C1F26
                   , 0);
        if (lVar4 != 0)
        {
            uVar2 = *(uint*)(lVar4 + 0x18);
            if (((uVar2 != 1) && (uVar2 != 0)) && (2 < uVar2))
            {
                uVar3 = *(ushort*)(lVar4 + 0x24);
                iVar1 = (uint)*(ushort*)(lVar4 + 0x22) + (uint)*(ushort*)(lVar4 + 0x20);
                iStack_24 = iVar1;
                uVar5 = FUN_0081adb4(_int_TypeInfo, &iStack_24);
                if (*(int*)(_UnityEngine.Debug_TypeInfo + 0xe0) == 0)
                {
                    FUN_0081adac(_UnityEngine.Debug_TypeInfo);
                }
                UnityEngine.Debug$$Log(uVar5, 0);
                iStack_28 = iVar1 + (uint)uVar3 + 7;
                uVar5 = FUN_0081adb4(_int_TypeInfo, &iStack_28);
                uVar5 = UnityEngine.Debug$$Log(uVar5, 0);
                return uVar5;
            }
            FUN_0081aed8();
        }
        uVar5 = FUN_0081aed0();
        if ((bRam0000000000fc6ed8 & 1) == 0)
        {
            FUN_0081ac94(&UnityEngine.Object_TypeInfo, 0);
            bRam0000000000fc6ed8 = 1;
        }
        if (*(int*)(_UnityEngine.Object_TypeInfo + 0xe0) == 0)
        {
            FUN_0081adac();
        }
        return uVar5;
    }*/
}

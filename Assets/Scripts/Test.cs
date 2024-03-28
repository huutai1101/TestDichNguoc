using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private void MangArray()
    {
        int[] test = new int[6] { 1, 2, 3, 4, 5, 6 };
        int lengh = test.Length;
        int unit2 = test[1];
    }

    /*void Test$$MangArray(void)

    {
        long lVar1;

        if ((DAT_00fc4cf0 & 1) == 0)
        {
            thunk_FUN_00857a14(&int[]_TypeInfo);
            thunk_FUN_00857a14(&
                               Field$< PrivateImplementationDetails > .90D856B7ECAC90C26898AF8A46404297AA0EF657 68F62FDF8C3F08294BCBEE49
                              );
            DAT_00fc4cf0 = 1;
        }
        lVar1 = FUN_0081ae40(_int[]_TypeInfo, 6);
        System.Runtime.CompilerServices.RuntimeHelpers$$InitializeArray
                  (lVar1,
                   _Field$< PrivateImplementationDetails > .90D856B7ECAC90C26898AF8A46404297AA0EF65768F62FDF8 C3F08294BCBEE49
                   , 0);
        if (lVar1 != 0)
        {
            if (1 < *(uint*)(lVar1 + 0x18))
            {
                return;
            }
            *//* WARNING: Subroutine does not return *//*
            FUN_0081aff4();
        }
        *//* WARNING: Subroutine does not return *//*
        FUN_0081afec();
    }*/

    private void MangList()
    {
        List<int> test = new List<int>();
        test.Add(0);
        test.Add(1);
        for (int i = 0; i <= 3; i++)
        {
            test.Add(i + 2);
        }
        for (int i = 0; i < test.Count; i++)
        {
            Debug.Log(test[i]);
        }
    }

    /*  void Test$$MangList(void)

      {
          uint uVar1;
          long lVar2;
          undefined8 uVar3;
          long lVar4;
          long lVar5;
          int iVar6;
          undefined4 uStack_34;

          if ((DAT_00fc4cf1 & 1) == 0)
          {
              thunk_FUN_00857a14(&UnityEngine.Debug_TypeInfo);
              thunk_FUN_00857a14(&int_TypeInfo);
              thunk_FUN_00857a14(&Method$System.Collections.Generic.List<int>.Add());
              thunk_FUN_00857a14(&Method$System.Collections.Generic.List<int>..ctor());
              thunk_FUN_00857a14(&Method$System.Collections.Generic.List<int>.get_Count());
              thunk_FUN_00857a14(&Method$System.Collections.Generic.List<int>.get_Item());
              thunk_FUN_00857a14(&System.Collections.Generic.List<int>_TypeInfo);
              DAT_00fc4cf1 = 1;
          }
          lVar2 = thunk_FUN_0086e018(System.Collections.Generic.List<int>_TypeInfo);
          System.Collections.Generic.List<int>$$.ctor
                    (lVar2, Method$System.Collections.Generic.List<int>..ctor());
          lVar5 = Method$System.Collections.Generic.List<int>.Add();
          if (lVar2 != 0)
          {
              lVar4 = *(long*)(lVar2 + 0x10);
              *(int*)(lVar2 + 0x1c) = *(int*)(lVar2 + 0x1c) + 1;
              if (lVar4 != 0)
              {
                  uVar1 = *(uint*)(lVar2 + 0x18);
                  if (uVar1 < *(uint*)(lVar4 + 0x18))
                  {
                      *(uint*)(lVar2 + 0x18) = uVar1 + 1;
                      *(undefined4*)(lVar4 + (long)(int)uVar1 * 4 + 0x20) = 0;
                      *(int*)(lVar2 + 0x1c) = *(int*)(lVar2 + 0x1c) + 1;
                  }
                  else
                  {
                      System.Collections.Generic.List<int>$$AddWithResize
                                (lVar2, 0, *(undefined8*)(*(long*)(*(long*)(lVar5 + 0x20) + 0xc0) + 0x70));
                      lVar5 = Method$System.Collections.Generic.List<int>.Add();
                      lVar4 = *(long*)(lVar2 + 0x10);
                      *(int*)(lVar2 + 0x1c) = *(int*)(lVar2 + 0x1c) + 1;
                      if (lVar4 == 0) goto LAB_0091fd5c;
                  }
                  uVar1 = *(uint*)(lVar2 + 0x18);
                  if (uVar1 < *(uint*)(lVar4 + 0x18))
                  {
                      *(uint*)(lVar2 + 0x18) = uVar1 + 1;
                      *(undefined4*)(lVar4 + (long)(int)uVar1 * 4 + 0x20) = 1;
                  }
                  else
                  {
                      System.Collections.Generic.List<int>$$AddWithResize
                                (lVar2, 1, *(undefined8*)(*(long*)(*(long*)(lVar5 + 0x20) + 0xc0) + 0x70));
                  }
                  iVar6 = 2;
                  while (true)
                  {
                      lVar5 = Method$System.Collections.Generic.List<int>.Add();
                      lVar4 = *(long*)(lVar2 + 0x10);
                      *(int*)(lVar2 + 0x1c) = *(int*)(lVar2 + 0x1c) + 1;
                      if (lVar4 == 0) break;
                      uVar1 = *(uint*)(lVar2 + 0x18);
                      if (uVar1 < *(uint*)(lVar4 + 0x18))
                      {
                          *(uint*)(lVar2 + 0x18) = uVar1 + 1;
                          *(int*)(lVar4 + (long)(int)uVar1 * 4 + 0x20) = iVar6;
                      }
                      else
                      {
                          System.Collections.Generic.List<int>$$AddWithResize
                                    (lVar2, iVar6, *(undefined8*)(*(long*)(*(long*)(lVar5 + 0x20) + 0xc0) + 0x70));
                      }
                      iVar6 = iVar6 + 1;
                      if (iVar6 == 6)
                      {
                          if (0 < *(int*)(lVar2 + 0x18))
                          {
                              iVar6 = 0;
                              do
                              {
                                  uStack_34 = System.Collections.Generic.List<int>$$get_Item
                                  (lVar2, iVar6,
                                                         Method$System.Collections.Generic.List<int>.get_Item());
                                  uVar3 = thunk_FUN_0086dc48(int_TypeInfo, &uStack_34);
                                  if (*(int*)(UnityEngine.Debug_TypeInfo + 0xe0) == 0)
                                  {
                                      thunk_FUN_0084c4c0(UnityEngine.Debug_TypeInfo);
                                  }
                                  UnityEngine.Debug$$Log(uVar3, 0);
                                  iVar6 = iVar6 + 1;
                              } while (iVar6 < *(int*)(lVar2 + 0x18));
                          }
                          return;
                      }
                  }
              }
          }
          LAB_0091fd5c:
          *//* WARNING: Subroutine does not return *//*
          FUN_0081afec();
      }*/

    private void MangList2()
    {
        List<int> test = new List<int>();
        test.Add(0);
        test.Add(1);
        for (int i = 0; i < test.Count; i++)
        {
            Debug.Log(test[i]);
        }
    }

/*    void Test$$MangList2(void)

    {
        uint uVar1;
        long lVar2;
        undefined8 uVar3;
        long lVar4;
        long lVar5;
        int iVar6;
        undefined4 uStack_34;

        if ((bRam0000000000fc5612 & 1) == 0)
        {
            thunk_FUN_00857c24(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_00857c24(&int_TypeInfo);
            thunk_FUN_00857c24(&Method$System.Collections.Generic.List<int>.Add());
            thunk_FUN_00857c24(&Method$System.Collections.Generic.List<int>..ctor());
            thunk_FUN_00857c24(&Method$System.Collections.Generic.List<int>.get_Count());
            thunk_FUN_00857c24(&Method$System.Collections.Generic.List<int>.get_Item());
            thunk_FUN_00857c24(&System.Collections.Generic.List<int>_TypeInfo);
            bRam0000000000fc5612 = 1;
        }
        lVar2 = thunk_FUN_0086e228(_System.Collections.Generic.List<int>_TypeInfo);
        System.Collections.Generic.List<int>$$.ctor
                  (lVar2, _Method$System.Collections.Generic.List<int>..ctor());
        lVar5 = _Method$System.Collections.Generic.List<int>.Add();
        if (lVar2 != 0)
        {
            lVar4 = *(long*)(lVar2 + 0x10);
            *(int*)(lVar2 + 0x1c) = *(int*)(lVar2 + 0x1c) + 1;
            if (lVar4 != 0)
            {
                uVar1 = *(uint*)(lVar2 + 0x18);
                if (uVar1 < *(uint*)(lVar4 + 0x18))
                {
                    *(uint*)(lVar2 + 0x18) = uVar1 + 1;
                    *(undefined4*)(lVar4 + (long)(int)uVar1 * 4 + 0x20) = 0;
                    *(int*)(lVar2 + 0x1c) = *(int*)(lVar2 + 0x1c) + 1;
                }
                else
                {
                    System.Collections.Generic.List<int>$$AddWithResize
                              (lVar2, 0, *(undefined8*)(*(long*)(*(long*)(lVar5 + 0x20) + 0xc0) + 0x70));
                    lVar5 = _Method$System.Collections.Generic.List<int>.Add();
                    lVar4 = *(long*)(lVar2 + 0x10);
                    *(int*)(lVar2 + 0x1c) = *(int*)(lVar2 + 0x1c) + 1;
                    if (lVar4 == 0) goto LAB_00920164;
                }
                uVar1 = *(uint*)(lVar2 + 0x18);
                if (uVar1 < *(uint*)(lVar4 + 0x18))
                {
                    *(uint*)(lVar2 + 0x18) = uVar1 + 1;
                    *(undefined4*)(lVar4 + (long)(int)uVar1 * 4 + 0x20) = 1;
                }
                else
                {
                    System.Collections.Generic.List<int>$$AddWithResize
                              (lVar2, 1, *(undefined8*)(*(long*)(*(long*)(lVar5 + 0x20) + 0xc0) + 0x70));
                }
                if (0 < *(int*)(lVar2 + 0x18))
                {
                    iVar6 = 0;
                    do
                    {
                        uStack_34 = System.Collections.Generic.List<int>$$get_Item
                                              (lVar2, iVar6, _Method$System.Collections.Generic.List<int>.get_Item()
                                              );
                        uVar3 = thunk_FUN_0086de58(_int_TypeInfo, &uStack_34);
                        if (*(int*)(_UnityEngine.Debug_TypeInfo + 0xe0) == 0)
                        {
                            thunk_FUN_0084c6d0(_UnityEngine.Debug_TypeInfo);
                        }
                        UnityEngine.Debug$$Log(uVar3, 0);
                        iVar6 = iVar6 + 1;
                    } while (iVar6 < *(int*)(lVar2 + 0x18));
                }
                return;
            }
        }
        LAB_00920164:
        *//* WARNING: Subroutine does not return *//*
        FUN_0081b1fc();
    }*/

    private void MangChar()
    {
        char[] test = new char[6] { 'a', 'b', 'c', 'd', 'e', 'f' };
    }

/*    void Test$$MangChar(void)

    {
        undefined8 uVar1;

        if ((DAT_00fc4cf2 & 1) == 0)
        {
            thunk_FUN_00857a14(&char[]_TypeInfo);
            thunk_FUN_00857a14(&
                               Field$< PrivateImplementationDetails > .5920DEEC20B2AC7028FDCDB5747BB9B601985A67 852EA145782255AB2D09EFBD
                              );
            DAT_00fc4cf2 = 1;
        }
        uVar1 = FUN_0081ae40(char[]_TypeInfo, 6);
        System.Runtime.CompilerServices.RuntimeHelpers$$InitializeArray
                  (uVar1,
                   Field$< PrivateImplementationDetails > .5920DEEC20B2AC7028FDCDB5747BB9B601985A67852EA14578 2255AB2D09EFBD
                   , 0);
        return;
    }*/

    private void ChuoiString()
    {
        string test = "123456789";
        char[] test2 = test.ToCharArray(4,5);
    }

   /* void Test$$ChuoiString(void)

    {
        if ((DAT_00fc4cf3 & 1) == 0)
        {
            thunk_FUN_00857a14(&StringLiteral_337);
            DAT_00fc4cf3 = 1;
        }
        if (StringLiteral_337 != 0)
        {
            System.String$$ToCharArray(StringLiteral_337, 4, 5, 0);
            return;
        }
        *//* WARNING: Subroutine does not return *//*
        FUN_0081afec();
    }*/
}

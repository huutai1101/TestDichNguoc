using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.XR;

public class Test5 : MonoBehaviour
{
    private void DictionaryMoveNext()
    {
        Dictionary<string, int> myDictionary = new Dictionary<string, int>();
        myDictionary.Add("apple", 1);
        myDictionary.Add("banana", 2);
        myDictionary.Add("orange", 3);

        // Lấy trình duyệt cho Dictionary
        var enumerator = myDictionary.GetEnumerator();

        // Duyệt qua các cặp khóa-giá trị trong Dictionary
        while (enumerator.MoveNext())
        {
            var key = enumerator.Current.Key;
            var value = enumerator.Current.Value;
            Debug.Log("Key: " + key + ", Value: " + value);
        }
    }


    /* WARNING: Globals starting with '_' overlap smaller symbols at the same address */

/*    ulong Test5$$DictionaryMoveNext(void)
    {
        long lVar1;
        ulong uVar2;
        undefined8 uVar3;
        undefined8 uVar4;
        undefined8 uStack_70;
        undefined8 uStack_68;
        undefined8 uStack_60;
        undefined8 uStack_58;
        undefined8 uStack_50;
        undefined4 uStack_34;

        if ((bRam0000000000fc5b51 & 1) == 0)
        {
            thunk_FUN_00857f60(&UnityEngine.Debug_TypeInfo);
            thunk_FUN_00857f60(&Method$System.Collections.Generic.Dictionary < string, -int >.Add());
            thunk_FUN_00857f60(&Method$System.Collections.Generic.Dictionary < string, -int >.GetEnumerator());
            thunk_FUN_00857f60(&Method$System.Collections.Generic.Dictionary < string, -int > ..ctor());
            thunk_FUN_00857f60(&System.Collections.Generic.Dictionary < string, -int > _TypeInfo);
            thunk_FUN_00857f60(&
                               Method$System.Collections.Generic.Dictionary.Enumerator < string, -int >.MoveNext()
            );
            thunk_FUN_00857f60(&
                               Method$System.Collections.Generic.Dictionary.Enumerator < string, -int >.get_Curr ent()
                              );
            thunk_FUN_00857f60(&Method$System.Collections.Generic.KeyValuePair < string, -int >.get_Key());
            thunk_FUN_00857f60(&Method$System.Collections.Generic.KeyValuePair < string, -int >.get_Value());
            thunk_FUN_00857f60(&StringLiteral_1270);
            thunk_FUN_00857f60(&StringLiteral_198);
            thunk_FUN_00857f60(&StringLiteral_2250);
            thunk_FUN_00857f60(&StringLiteral_3033);
            thunk_FUN_00857f60(&StringLiteral_2284);
            bRam0000000000fc5b51 = 1;
        }
        uStack_50 = 0;
        uStack_68 = 0;
        uStack_70 = 0;
        uStack_58 = 0;
        uStack_60 = 0;
        uStack_34 = 0;
        lVar1 = thunk_FUN_0086e564(_System.Collections.Generic.Dictionary < string, -int > _TypeInfo);
        System.Collections.Generic.Dictionary<>$$.ctor
                  (lVar1, _Method$System.Collections.Generic.Dictionary < string, -int > ..ctor());
        if (lVar1 != 0)
        {
            System.Collections.Generic.Dictionary<>$$Add
                      (lVar1, _StringLiteral_2250, 1,
                       _Method$System.Collections.Generic.Dictionary < string, -int >.Add());
            System.Collections.Generic.Dictionary<>$$Add
                      (lVar1, _StringLiteral_2284, 2,
                       _Method$System.Collections.Generic.Dictionary < string, -int >.Add());
            System.Collections.Generic.Dictionary<>$$Add
                      (lVar1, _StringLiteral_3033, 3,
                       _Method$System.Collections.Generic.Dictionary < string, -int >.Add());
            System.Collections.Generic.Dictionary<>$$GetEnumerator
                      (&uStack_70, lVar1,
                       _Method$System.Collections.Generic.Dictionary < string, -int >.GetEnumerator());
            uVar2 = System.Collections.Generic.Dictionary.Enumerator<>$$MoveNext
                              (&uStack_70,
                               _Method$System.Collections.Generic.Dictionary.Enumerator < string, -int >.MoveNex t()
                              );
            uVar4 = uStack_60;
            while ((uVar2 & 1) != 0)
            {
                uStack_34 = (undefined4)uStack_58;
                uStack_60 = uVar4;
                uVar3 = System.Int32$$ToString(&uStack_34, 0);
                uVar4 = System.String$$Concat(_StringLiteral_1270, uVar4, _StringLiteral_198, uVar3, 0);
                if (*(int*)(_UnityEngine.Debug_TypeInfo + 0xe0) == 0)
                {
                    thunk_FUN_0084ca0c(_UnityEngine.Debug_TypeInfo);
                }
                UnityEngine.Debug$$Log(uVar4, 0);
                uVar2 = System.Collections.Generic.Dictionary.Enumerator<>$$MoveNext
                                  (&uStack_70,
                                   _Method$System.Collections.Generic.Dictionary.Enumerator < string, -int >.MoveN ext()
                                  );
                uVar4 = uStack_60;
            }
            return uVar2;
        }
        uVar2 = FUN_0081b538();
        if ((bRam0000000000fc7e98 & 1) == 0)
        {
            thunk_FUN_00857f60(&UnityEngine.Object_TypeInfo, 0);
            bRam0000000000fc7e98 = 1;
        }
        if (*(int*)(_UnityEngine.Object_TypeInfo + 0xe0) == 0)
        {
            thunk_FUN_0084ca0c();
        }
        return uVar2;
    }*/
}

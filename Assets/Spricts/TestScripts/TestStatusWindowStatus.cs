using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatusWindowStatus : MonoBehaviour
{

    //アイテムを持っているかどうかのフラグ
    [SerializeField]
    private bool[] _itemFlags = new bool[6];

    private TestStatusWindowItemDataBase _testStatusWindowItemDataBase;

    void Start()
    {
        _testStatusWindowItemDataBase = GetComponent<TestStatusWindowItemDataBase>();
        SetItemData("懐中電灯");
        SetItemData("ハンドガン");
    }

    //アイテムを持っているかどうか
    public bool GetItemFlag(int num)
    {
        return _itemFlags[num];
    }

    //アイテムをセット
    public void SetItemData(string name)
    {
        var itemDatas = _testStatusWindowItemDataBase.GetItemData();
        for(int i = 0; i < itemDatas.Length; i++)
        {
            if(itemDatas[i].GetItemName() == name)
            {
                _itemFlags[i] = true;
            }
        }
    }
}

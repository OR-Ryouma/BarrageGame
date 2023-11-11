using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatusWindowStatus : MonoBehaviour
{
    //�A�C�e���������Ă��邩�ǂ����̃t���O
    [SerializeField]
    private bool[] _itemFlags = new bool[6];

    private TestStatusWindowItemDataBase _testStatusWindowItemDataBase;

    void Start()
    {
        _testStatusWindowItemDataBase = GetComponent<TestStatusWindowItemDataBase>();
        SetItemData("�����d��");
        SetItemData("�n���h�K��");
    }

    //�A�C�e���������Ă��邩�ǂ���
    public bool GetItemFlag(int num)
    {
        return _itemFlags[num];
    }

    //�A�C�e�����Z�b�g
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

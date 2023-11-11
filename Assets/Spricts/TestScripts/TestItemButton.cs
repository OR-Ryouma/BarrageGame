using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestItemButton : MonoBehaviour
{
    private Text _infimationText;
    private TestStatusWindowItemDataBase _testStatusWindowItemDataBase;
    private int _itemNum;

    void Start()
    {
        _testStatusWindowItemDataBase = Camera.main.GetComponent<TestStatusWindowItemDataBase>();
        _infimationText = transform.parent.parent.parent.Find("Information/Text").GetComponent<Text>();
    }

    //�A�C�e���{�^�����I�����ꂽ����\��
    public void OnSelected()
    {
        _infimationText.text = _testStatusWindowItemDataBase.GetItemData()[_itemNum].GetItemInfomation();
    }
    //�A�C�e���{�^������ړ�����������폜
    public void OnDeselected()
    {
        _infimationText.text = "";
    }

    public void SetItemNum(int number)
    {
        _itemNum = number;
    }

    public int GetItemNum()
    {
        return _itemNum;
    }
}

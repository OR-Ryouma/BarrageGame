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

    //アイテムボタンが選択された情報を表示
    public void OnSelected()
    {
        _infimationText.text = _testStatusWindowItemDataBase.GetItemData()[_itemNum].GetItemInfomation();
    }
    //アイテムボタンから移動したら情報を削除
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

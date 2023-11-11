using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatusWindowItemData : MonoBehaviour
{
    //アイテムのImage画像
    private Sprite _itemSprite;
    //アイテムの名前
    private string _itemName;
    //アイテムのタイプ
    private TestStatusWindowItemDataBase.Item _itemType;
    //アイテムの情報
    private string _itemInfomation;

    public TestStatusWindowItemData(Sprite image, string itemName, TestStatusWindowItemDataBase.Item itemType, string information)
    {
        this._itemSprite = image;
        this._itemName = itemName;
        this._itemType = itemType;
        this._itemInfomation = information;
    }

    public Sprite GetItemSprite()
    {
        return _itemSprite;
    }

    public string GetItemName()
    {
        return _itemName;
    }

    public TestStatusWindowItemDataBase.Item GetItemType()
    {
        return _itemType;
    }

    public string GetItemInfomation()
    {
        return _itemInfomation;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatusWindowItemData : MonoBehaviour
{
    //�A�C�e����Image�摜
    private Sprite _itemSprite;
    //�A�C�e���̖��O
    private string _itemName;
    //�A�C�e���̃^�C�v
    private TestStatusWindowItemDataBase.Item _itemType;
    //�A�C�e���̏��
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

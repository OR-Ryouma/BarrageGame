using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStatusWindowItemDataBase : MonoBehaviour
{
    public enum Item
    {
        Sword,
        HandGun,
        ShotGun,
        UseItem
    };

    private TestStatusWindowItemData[] _itemLists = new TestStatusWindowItemData[4];

    void Awake()
    {
        //アイテムの全情報の作成
        _itemLists[0] = new TestStatusWindowItemData(Resources.Load("FlashLight", typeof(Sprite)) as Sprite, "懐中電灯", Item.Sword, "あれば便利なあたりを照らすライト");
        _itemLists[1] = new TestStatusWindowItemData(Resources.Load("Sword", typeof(Sprite)) as Sprite, "ナイフ", Item.Sword, "切れ味鋭いナイフ");
        _itemLists[2] = new TestStatusWindowItemData(Resources.Load("Sword", typeof(Sprite)) as Sprite, "ブロードソード", Item.Sword, "大剣");
        _itemLists[3] = new TestStatusWindowItemData(Resources.Load("Gun", typeof(Sprite)) as Sprite, "ハンドガン", Item.HandGun, "威力抜群ハンドガン");
    }

    public TestStatusWindowItemData[] GetItemData()
    {
        return _itemLists;
    }

    public int GetItemTotal()
    {
        return _itemLists.Length;
    }
}

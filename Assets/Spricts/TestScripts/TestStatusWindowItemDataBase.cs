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
        //�A�C�e���̑S���̍쐬
        _itemLists[0] = new TestStatusWindowItemData(Resources.Load("FlashLight", typeof(Sprite)) as Sprite, "�����d��", Item.Sword, "����Ε֗��Ȃ�������Ƃ炷���C�g");
        _itemLists[1] = new TestStatusWindowItemData(Resources.Load("Sword", typeof(Sprite)) as Sprite, "�i�C�t", Item.Sword, "�؂ꖡ�s���i�C�t");
        _itemLists[2] = new TestStatusWindowItemData(Resources.Load("Sword", typeof(Sprite)) as Sprite, "�u���[�h�\�[�h", Item.Sword, "�匕");
        _itemLists[3] = new TestStatusWindowItemData(Resources.Load("Gun", typeof(Sprite)) as Sprite, "�n���h�K��", Item.HandGun, "�З͔��Q�n���h�K��");
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

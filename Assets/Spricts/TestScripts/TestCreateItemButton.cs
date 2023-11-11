using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCreateItemButton : MonoBehaviour
{
    //主人公キャラのステータス
    private TestStatusWindowStatus _testStatusWindowStatus;
    //アイテムデータベース
    private TestStatusWindowItemDataBase _testStatusWindowItemDataBase;
    //アイテムボタンのプレハブ
    public GameObject _itemPrefab;
    //アイテムボタンを入れておくゲームオブジェクト
    private GameObject[] _item;

    //ゲームオブジェクトがアクティブになった時実行
    void OnEnable()
    {
        _testStatusWindowStatus = Camera.main.GetComponent<TestStatusWindowStatus>();
        _testStatusWindowItemDataBase = Camera.main.GetComponent<TestStatusWindowItemDataBase>();
        _item = new GameObject[_testStatusWindowItemDataBase.GetItemTotal()];

        //アイテム総数分のアイテムボタンを作成
        for(var i = 0; i < _testStatusWindowItemDataBase.GetItemTotal(); i++)
        {
            _item[i] = GameObject.Instantiate(_itemPrefab) as GameObject;
            _item[i].name = "Item" + i;
            //アイテムボタンの親要素をこのスクリプトが設定されているゲームオブジェクトにする
            _item[i].transform.SetParent(transform);
            //アイテムを持っているかどうか
            if(_testStatusWindowStatus.GetItemFlag(i))
            {
                //アイテムデータベースの情報からスプライトを取得しアイテムボタンのスプライトに設定
                _item[i].transform.GetChild(0).GetComponent<Image>().sprite = _testStatusWindowItemDataBase.GetItemData()[i].GetItemSprite();
            }
            else
            {
                //アイテムボタンのUI.Imageを不可視にし、マウスやキー操作で移動師にようにする
                _item[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
                _item[i].transform.GetChild(0).GetComponent<Button>().interactable = false;
            }
            //ボタンにユニークウナ番号を設定（アイテムデータベース番号と対応）
            _item[i].transform.GetChild(0).GetComponent<TestItemButton>().SetItemNum(i);
        }
    }

    void OnDisable()
    {
        //ゲームオブジェクトが非アクティブになる時作成したボタンインスタンスを削除
        for(var i = 0; i < _testStatusWindowItemDataBase.GetItemTotal(); i++)
        {
            Destroy(_item[i]);
        }
    }
}

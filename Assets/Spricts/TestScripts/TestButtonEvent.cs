using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TestButtonEvent : MonoBehaviour
{
    //インフォメーションテキストに表示する文字列
    [SerializeField]
    private string _informationString;
    //インフォメーションテキスト
    [SerializeField]
    private Text _informationText;
    //自身の親のCanvasGroup
    private CanvasGroup _canvasGroup;
    //前の画面に戻るボタン
    private GameObject _returnButton;

    // Start is called before the first frame update
    void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _returnButton = transform.parent.Find("Exit").gameObject;
    }

    void OnEnable()
    {
        //装備アイテム選択中にステータス画面を抜けた時にボタンを無効化したままの場合もあるので立ち上げ時に有効化する
        GetComponent<Button>().interactable = true;
    }

    //ボタンの上にマウスが入った時、またはキー操作で移動してきた時
    public void Onselected()
    {
        if (_canvasGroup == null || _canvasGroup.interactable)
        {
            //イベントシステムのフォーカスが他のゲームオブジェクトにある時このゲームオブジェクトにフォーカス
            if (EventSystem.current.currentSelectedGameObject != gameObject)
            {
                EventSystem.current.SetSelectedGameObject(gameObject);
            }
            _informationText.text = _informationString;
        }
    }

    //ボタンから移動した情報を削除
    public void OnDeselected()
    {
        _informationText.text = "";
    }

    //ステータスウインドウを非アクティブにする
    public void DisableWindow()
    {
        if (_canvasGroup == null || _canvasGroup.interactable)
        {
            //ウインドウを非アクティブにする
            transform.root.gameObject.SetActive(false);
        }
    }

    //他の画面を表示する
    public void WindowOnOff(GameObject window)
    {
        if(_canvasGroup == null || _canvasGroup.interactable)
        {
            Camera.main.GetComponent<TestOperationStatusWindow>().ChangeWindow(window);
        }
    }

    //前の画面に戻るボタンを選択状態にする
    public void SelectReturnButton()
    {
        EventSystem.current.SetSelectedGameObject(_returnButton);
    }

}

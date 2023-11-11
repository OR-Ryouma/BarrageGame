using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestOperationStatusWindow : MonoBehaviour
{
    [SerializeField]
    private GameObject _propertyWindow;
    //ステータスウインドウの全部の画面
    [SerializeField]
    private GameObject[] _windowLists;

    void Update()
    {
        //ステータスウインドウのオン・オフ
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            _propertyWindow.SetActive(!_propertyWindow.activeSelf);
            //MainWinddowをセット
            ChangeWindow(_windowLists[0]);
        }
    }

    //ステータス画面のウインドウのオン・オフメソッド
    public void ChangeWindow(GameObject window)
    {
        foreach(var item in _windowLists)
        {
            if(item == window)
            {
                item.SetActive(true);
                EventSystem.current.SetSelectedGameObject(null);
            }
            else
            {
                item.SetActive(false);
            }
            //それぞれのウインドウのMenuAreaの最初の子要素をアクティブな状態にする
            EventSystem.current.SetSelectedGameObject(window.transform.Find("MenuArea").GetChild(0).gameObject);
        }
    }
}

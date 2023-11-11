using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class TestOperationStatusWindow : MonoBehaviour
{
    [SerializeField]
    private GameObject _propertyWindow;
    //�X�e�[�^�X�E�C���h�E�̑S���̉��
    [SerializeField]
    private GameObject[] _windowLists;

    void Update()
    {
        //�X�e�[�^�X�E�C���h�E�̃I���E�I�t
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            _propertyWindow.SetActive(!_propertyWindow.activeSelf);
            //MainWinddow���Z�b�g
            ChangeWindow(_windowLists[0]);
        }
    }

    //�X�e�[�^�X��ʂ̃E�C���h�E�̃I���E�I�t���\�b�h
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
            //���ꂼ��̃E�C���h�E��MenuArea�̍ŏ��̎q�v�f���A�N�e�B�u�ȏ�Ԃɂ���
            EventSystem.current.SetSelectedGameObject(window.transform.Find("MenuArea").GetChild(0).gameObject);
        }
    }
}

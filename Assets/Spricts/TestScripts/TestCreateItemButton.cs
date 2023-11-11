using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestCreateItemButton : MonoBehaviour
{
    //��l���L�����̃X�e�[�^�X
    private TestStatusWindowStatus _testStatusWindowStatus;
    //�A�C�e���f�[�^�x�[�X
    private TestStatusWindowItemDataBase _testStatusWindowItemDataBase;
    //�A�C�e���{�^���̃v���n�u
    public GameObject _itemPrefab;
    //�A�C�e���{�^�������Ă����Q�[���I�u�W�F�N�g
    private GameObject[] _item;

    //�Q�[���I�u�W�F�N�g���A�N�e�B�u�ɂȂ��������s
    void OnEnable()
    {
        _testStatusWindowStatus = Camera.main.GetComponent<TestStatusWindowStatus>();
        _testStatusWindowItemDataBase = Camera.main.GetComponent<TestStatusWindowItemDataBase>();
        _item = new GameObject[_testStatusWindowItemDataBase.GetItemTotal()];

        //�A�C�e���������̃A�C�e���{�^�����쐬
        for(var i = 0; i < _testStatusWindowItemDataBase.GetItemTotal(); i++)
        {
            _item[i] = GameObject.Instantiate(_itemPrefab) as GameObject;
            _item[i].name = "Item" + i;
            //�A�C�e���{�^���̐e�v�f�����̃X�N���v�g���ݒ肳��Ă���Q�[���I�u�W�F�N�g�ɂ���
            _item[i].transform.SetParent(transform);
            //�A�C�e���������Ă��邩�ǂ���
            if(_testStatusWindowStatus.GetItemFlag(i))
            {
                //�A�C�e���f�[�^�x�[�X�̏�񂩂�X�v���C�g���擾���A�C�e���{�^���̃X�v���C�g�ɐݒ�
                _item[i].transform.GetChild(0).GetComponent<Image>().sprite = _testStatusWindowItemDataBase.GetItemData()[i].GetItemSprite();
            }
            else
            {
                //�A�C�e���{�^����UI.Image��s���ɂ��A�}�E�X��L�[����ňړ��t�ɂ悤�ɂ���
                _item[i].transform.GetChild(0).GetComponent<Image>().enabled = false;
                _item[i].transform.GetChild(0).GetComponent<Button>().interactable = false;
            }
            //�{�^���Ƀ��j�[�N�E�i�ԍ���ݒ�i�A�C�e���f�[�^�x�[�X�ԍ��ƑΉ��j
            _item[i].transform.GetChild(0).GetComponent<TestItemButton>().SetItemNum(i);
        }
    }

    void OnDisable()
    {
        //�Q�[���I�u�W�F�N�g����A�N�e�B�u�ɂȂ鎞�쐬�����{�^���C���X�^���X���폜
        for(var i = 0; i < _testStatusWindowItemDataBase.GetItemTotal(); i++)
        {
            Destroy(_item[i]);
        }
    }
}

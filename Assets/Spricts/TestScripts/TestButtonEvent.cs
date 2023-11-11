using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class TestButtonEvent : MonoBehaviour
{
    //�C���t�H���[�V�����e�L�X�g�ɕ\�����镶����
    [SerializeField]
    private string _informationString;
    //�C���t�H���[�V�����e�L�X�g
    [SerializeField]
    private Text _informationText;
    //���g�̐e��CanvasGroup
    private CanvasGroup _canvasGroup;
    //�O�̉�ʂɖ߂�{�^��
    private GameObject _returnButton;

    // Start is called before the first frame update
    void Start()
    {
        _canvasGroup = GetComponent<CanvasGroup>();
        _returnButton = transform.parent.Find("Exit").gameObject;
    }

    void OnEnable()
    {
        //�����A�C�e���I�𒆂ɃX�e�[�^�X��ʂ𔲂������Ƀ{�^���𖳌��������܂܂̏ꍇ������̂ŗ����グ���ɗL��������
        GetComponent<Button>().interactable = true;
    }

    //�{�^���̏�Ƀ}�E�X�����������A�܂��̓L�[����ňړ����Ă�����
    public void Onselected()
    {
        if (_canvasGroup == null || _canvasGroup.interactable)
        {
            //�C�x���g�V�X�e���̃t�H�[�J�X�����̃Q�[���I�u�W�F�N�g�ɂ��鎞���̃Q�[���I�u�W�F�N�g�Ƀt�H�[�J�X
            if (EventSystem.current.currentSelectedGameObject != gameObject)
            {
                EventSystem.current.SetSelectedGameObject(gameObject);
            }
            _informationText.text = _informationString;
        }
    }

    //�{�^������ړ����������폜
    public void OnDeselected()
    {
        _informationText.text = "";
    }

    //�X�e�[�^�X�E�C���h�E���A�N�e�B�u�ɂ���
    public void DisableWindow()
    {
        if (_canvasGroup == null || _canvasGroup.interactable)
        {
            //�E�C���h�E���A�N�e�B�u�ɂ���
            transform.root.gameObject.SetActive(false);
        }
    }

    //���̉�ʂ�\������
    public void WindowOnOff(GameObject window)
    {
        if(_canvasGroup == null || _canvasGroup.interactable)
        {
            Camera.main.GetComponent<TestOperationStatusWindow>().ChangeWindow(window);
        }
    }

    //�O�̉�ʂɖ߂�{�^����I����Ԃɂ���
    public void SelectReturnButton()
    {
        EventSystem.current.SetSelectedGameObject(_returnButton);
    }

}

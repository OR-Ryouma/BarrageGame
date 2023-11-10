using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutController : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    private float _positionX;

    // Start is called before the first frame update
    void Start()
    {
        _rb2D = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        //Player��ViewportPoint�ɒu���錻�ݒn�ix���������j���擾
        _positionX = Camera.main.WorldToViewportPoint(_rb2D.position).x;

        //���[�ɏo�邩�A�E�[�ɏo��Ȃ珈�����s��
        if(0 > _positionX || _positionX > 1)
        {
            //Debug.Log("Going out");
            //�Q�[�����Player�̈ʒu���X�V���Ċi�[
            _positionX = _rb2D.position.x;
            //�X�V���W�Ƃ��ėp����Temporary�ʒuVector���쐬
            Vector3 _tmpUpdate = GameObject.Find("Player").transform.position;
            //��ʊO�ɏo������x���������ɑ΂��Ă̏���
            if(_positionX < 20)
            {
                _tmpUpdate.x = 25f;
            }
            else
            {
                _tmpUpdate.x = 14.8f;
            }
            //�ʒu�̍X�V
            transform.position = _tmpUpdate;
        }
    }
}

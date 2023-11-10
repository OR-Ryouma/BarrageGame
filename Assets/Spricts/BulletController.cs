using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�K�v�ȃR���|�[�l���g�̒�`
[RequireComponent(typeof(Rigidbody2D))]

public class BulletController : MonoBehaviour
{
    //�e����ԑ���
    [SerializeField] float _speed = 10f;
    //�e�̐�������
    [SerializeField] float _lifeTime = 5f;

    private Rigidbody2D _rb2D = default;

    void Start()
    {
        //����ɔ�΂�
        _rb2D = GetComponent<Rigidbody2D>();
        _rb2D.velocity = Vector2.up * _speed;

        // �������Ԃ��o�߂����玩�����g��j������
        Destroy(this.gameObject, _lifeTime);
    }
}

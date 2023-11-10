using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//�K�v�ȃR���|�[�l���g�̒�`
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    //�㉺���E�ړ������
    float _movePower = 0;
    //�㉺���E�ړ������(N)
    [SerializeField] float _movePowerN = 5f;
    //�㉺���E�ړ������(S)
    [SerializeField] float _movePowerS = 3f;

    //�e�ۂ̃v���n�u
    [SerializeField] GameObject _bulletPrefab = default;

    //�e���̈ʒu��ݒ肷��I�u�W�F�N�g
    [SerializeField] Transform _muzzle = default;

    //�q�I�u�W�F�N�g�̊i�[�ꏊ
    GameObject _child;

    private Rigidbody2D _rb2D = default;

    //�����̓��͒l
    float _horizontal;
    float _vertical;

    //�ŏ��ɏo���������W
    Vector3 _initialPosition;

    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _child = transform.Find("HitClircle").gameObject;
        // �����ʒu���o���Ă���
        _initialPosition = this.transform.position;
    }

    void Update()
    {
        // ���͂��󂯎��
        _horizontal = Input.GetAxisRaw("HorizontalLR");
        _vertical = Input.GetAxisRaw("VerticalUD");

        if (Input.GetKey(KeyCode.Z))
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            bullet.transform.position = _muzzle.transform.position;
        }

        if(Input.GetKey(KeyCode.LeftShift))
        {
            _child.SetActive(true);
            _movePower = _movePowerS;
            
        }
        else
        {
            _child.SetActive(false);
            _movePower = _movePowerN;
        }


    }

    private void FixedUpdate()
    {
        // �͂�������̂� FixedUpdate �ōs��
        _rb2D.velocity = new Vector2(_horizontal * _movePower, _vertical * _movePower);
    }
}

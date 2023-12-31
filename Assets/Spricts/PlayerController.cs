﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//必要なコンポーネントの定義
[RequireComponent(typeof(Rigidbody2D))]

public class PlayerController : MonoBehaviour
{
    //上下左右移動する力
    float _movePower = 0;
    //上下左右移動する力(N)
    [SerializeField] float _movePowerN = 5f;
    //上下左右移動する力(S)
    [SerializeField] float _movePowerS = 3f;

    //弾丸のプレハブ
    [SerializeField] GameObject _bulletPrefab = default;

    //銃口の位置を設定するオブジェクト
    [SerializeField] Transform _muzzle = default;

    //子オブジェクトの格納場所
    GameObject _child;
    GameObject _godCapsule;

    private Rigidbody2D _rb2D = default;

    //方向の入力値
    float _horizontal;
    float _vertical;

    public bool _godMode;
    Color32 _color32;
    Color32 _gcolor32;
    SpriteRenderer _spriteRenderer;
    CircleCollider2D _circleCollider2D;

    //最初に出現した座標
    Vector3 _initialPosition;

    void Start()
    {
        _rb2D = GetComponent<Rigidbody2D>();
        _child = transform.Find("HitClircle").gameObject;
        _godCapsule = transform.Find("GodCapsule").gameObject;

        _spriteRenderer = GetComponent<SpriteRenderer>();
        _circleCollider2D = GetComponent<CircleCollider2D>();
        _color32 = _spriteRenderer.color;
        _gcolor32 = new Color32(_color32.r, _color32.g, _color32.b, 130);

        // 初期位置を覚えておく
        _initialPosition = this.transform.position;
    }

    void Update()
    {
        // 入力を受け取る
        _horizontal = Input.GetAxisRaw("HorizontalLR");
        _vertical = Input.GetAxisRaw("VerticalUD");

        if (Input.GetKey(KeyCode.Z))
        {
            GameObject bullet = Instantiate(_bulletPrefab);
            bullet.transform.position = _muzzle.transform.position;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            _child.SetActive(true);
            _movePower = _movePowerS;

        }
        else
        {
            _child.SetActive(false);
            _movePower = _movePowerN;
        }

        if(_godMode)
        {
            GodMode();
        }
        else
        {
            _godCapsule.SetActive(false);
            _spriteRenderer.color = _color32;
            _circleCollider2D.isTrigger = false;
        }
    }

    private void FixedUpdate()
    {
        // 力を加えるのは FixedUpdate で行う
        _rb2D.velocity = new Vector2(_horizontal * _movePower, _vertical * _movePower);
    }

    private void GodMode()
    {
        _godCapsule.SetActive(true);
        _spriteRenderer.color = _gcolor32;
        _circleCollider2D.isTrigger = true;
    }
}

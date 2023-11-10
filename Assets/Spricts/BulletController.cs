using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//必要なコンポーネントの定義
[RequireComponent(typeof(Rigidbody2D))]

public class BulletController : MonoBehaviour
{
    //弾が飛ぶ速さ
    [SerializeField] float _speed = 10f;
    //弾の生存時間
    [SerializeField] float _lifeTime = 5f;

    private Rigidbody2D _rb2D = default;

    void Start()
    {
        //上向に飛ばす
        _rb2D = GetComponent<Rigidbody2D>();
        _rb2D.velocity = Vector2.up * _speed;

        // 生存期間が経過したら自分自身を破棄する
        Destroy(this.gameObject, _lifeTime);
    }
}

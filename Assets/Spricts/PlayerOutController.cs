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
        //PlayerのViewportPointに置ける現在地（x方向成分）を取得
        _positionX = Camera.main.WorldToViewportPoint(_rb2D.position).x;

        //左端に出るか、右端に出るなら処理を行う
        if(0 > _positionX || _positionX > 1)
        {
            //Debug.Log("Going out");
            //ゲーム上のPlayerの位置を更新して格納
            _positionX = _rb2D.position.x;
            //更新座標として用いるTemporary位置Vectorを作成
            Vector3 _tmpUpdate = GameObject.Find("Player").transform.position;
            //画面外に出た時のx方向成分に対しての処理
            if(_positionX < 20)
            {
                _tmpUpdate.x = 25f;
            }
            else
            {
                _tmpUpdate.x = 14.8f;
            }
            //位置の更新
            transform.position = _tmpUpdate;
        }
    }
}

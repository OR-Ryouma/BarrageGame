using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutController : MonoBehaviour
{
    private Rigidbody2D _rb2D;
    private float _positionX;

    private GameObject _gameCameraObject;
    private Camera _gameCamera;

    float _xLimitMax = 25f;
    float _xLimitMin = 15f;
    float _yLimitMax = 4.5f;
    float _yLimitMin = -4.5f;

    // Start is called before the first frame update
    void Start()
    {
        _rb2D = gameObject.GetComponent<Rigidbody2D>();
        _gameCameraObject = GameObject.Find("Game Camera");
        _gameCamera = _gameCameraObject.GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        switch (GamesManager._instanceGames.limit_Type)
        {
            case GamesManager.Limit_Type.FrameLimit:
                FrameLimitMode();
                break;
            case GamesManager.Limit_Type.WarpLimit:
                WarpLimitMode();
                break;
            default:
                Debug.Log("NoType");
                break;
        }
    }

    private void FrameLimitMode()
    {
        //現在の位置
        Vector3 currentPos = transform.position;

        //Mathf.Clampで最小から最大を設定
        currentPos.x = Mathf.Clamp(currentPos.x, _xLimitMin, _xLimitMax);
        currentPos.y = Mathf.Clamp(currentPos.y, _yLimitMin, _yLimitMax);

        transform.position = currentPos;
    }

    private void WarpLimitMode()
    {
        //PlayerのViewportPointに置ける現在地（x方向成分）を取得
        _positionX = _gameCamera.WorldToViewportPoint(_rb2D.position).x;

        //現在の位置
        Vector3 currentPos = transform.position;
        currentPos.y = Mathf.Clamp(currentPos.y, _yLimitMin, _yLimitMax);
        transform.position = currentPos;

        //左端に出るか、右端に出るなら処理を行う
        if (0 > _positionX || _positionX > 1)
        {
            Debug.Log("Going out");
            //ゲーム上のPlayerの位置を更新して格納
            _positionX = _rb2D.position.x;
            //更新座標として用いるTemporary位置Vectorを作成
            Vector3 _tmpUpdate = transform.position;
            //画面外に出た時のx方向成分に対しての処理
            if (_positionX < 15)
            {
                _tmpUpdate.x = 25.2f;
            }
            else if (_positionX > 24)
            {
                _tmpUpdate.x = 14.8f;
            }
            //位置の更新
            transform.position = _tmpUpdate;
        }
    }
}

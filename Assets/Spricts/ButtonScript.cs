using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{

    private enum State
    {
        Start,
        ExtraStart,
        PracticeStart,
        Replay,
        Score,
        MusicRoom,
        Option
    };

    State state;

    public void StartButton()
    {
        state = State.Start;
        StartAnimation();
        StartCoroutine(WaitCoroutine());
    }

    public void ExtraStartButton()
    {
        state = State.ExtraStart;
        StartAnimation();
        StartCoroutine(WaitCoroutine());
    }

    public void PracticeStartButton()
    {
        state = State.PracticeStart;
        StartAnimation();
        StartCoroutine(WaitCoroutine());
    }

    public void ReplayButton()
    {
        state = State.Replay;
        StartAnimation();
        StartCoroutine(WaitCoroutine());
    }

    public void ScoreButton()
    {
        state = State.Score;
        StartAnimation();
        StartCoroutine(WaitCoroutine());
    }

    public void MusicRoomButton()
    {
        state = State.MusicRoom;
        StartAnimation();
        StartCoroutine(WaitCoroutine());
    }

    public void OptionButton()
    {
        state = State.Option;
        StartAnimation();
        StartCoroutine(WaitCoroutine());
    }

    public void QuitButton()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false; //ゲームプレイ終了
#else
        Application.Quit();//ゲームプレイ終了
#endif
    }

    public void StartAnimation()
    {
        GamesManager._instanceGames._startAnima = true;
    }

    private IEnumerator WaitCoroutine()
    {
        yield return new WaitForSeconds(1);

        switch(state)
        {
            case State.Start:
                SceneManager.LoadScene("SelectScene");
                break;
            case State.ExtraStart:
                //SceneManager.LoadScene("SelectScene");
                break;
            case State.PracticeStart:
                //SceneManager.LoadScene("SelectScene");
                break;
            case State.Replay:
                //SceneManager.LoadScene("SelectScene");
                break;
            case State.Score:
                //SceneManager.LoadScene("SelectScene");
                break;
            case State.MusicRoom:
                //SceneManager.LoadScene("SelectScene");
                break;
            case State.Option:
                //SceneManager.LoadScene("SelectScene");
                break;
            default:
                Debug.Log("defailt");
                break;
        }
    }
}

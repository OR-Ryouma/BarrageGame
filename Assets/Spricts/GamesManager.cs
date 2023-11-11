using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesManager : MonoBehaviour
{
    public static GamesManager _instanceGames = null;

    public bool _startAnima;

    public enum Difficulty
    {
        Easy,
        Normal,
        Hard,
        Expert,
        Master,
        Nightmare,
        Hell,
        Evil
    };

    public Difficulty difficulty = Difficulty.Easy;

    private void Awake()
    {
        if (_instanceGames == null)
        {
            _instanceGames = this;

            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }

        Debug.Log(difficulty);
    }
    
    public void Difficulties()
    {
        switch (difficulty)
        {
            case Difficulty.Easy:
                break;
            case Difficulty.Normal:
                break;
            case Difficulty.Hard:
                break;
            case Difficulty.Expert:
                break;
            case Difficulty.Master:
                break;
            case Difficulty.Nightmare:
                break;
            case Difficulty.Hell:
                break;
            case Difficulty.Evil:
                break;
            default:
                Debug.Log("defailt");
                break;
        }

        Debug.Log(difficulty);
    }
}

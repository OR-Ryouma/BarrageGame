using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyButtonScript : MonoBehaviour
{
    public void EasyButton()
    {
        GamesManager._instanceGames.difficulty = GamesManager.Difficulty.Easy;
        GamesManager._instanceGames.Difficulties();
    }

    public void NormalButton()
    {
        GamesManager._instanceGames.difficulty = GamesManager.Difficulty.Normal;
        GamesManager._instanceGames.Difficulties();
    }

    public void HardButton()
    {
        GamesManager._instanceGames.difficulty = GamesManager.Difficulty.Hard;
        GamesManager._instanceGames.Difficulties();
    }

    public void ExpartButton()
    {
        GamesManager._instanceGames.difficulty = GamesManager.Difficulty.Expert;
        GamesManager._instanceGames.Difficulties();
    }

    public void MasterButton()
    {
        GamesManager._instanceGames.difficulty = GamesManager.Difficulty.Master;
        GamesManager._instanceGames.Difficulties();
    }

    public void NightmareButton()
    {
        GamesManager._instanceGames.difficulty = GamesManager.Difficulty.Nightmare;
        GamesManager._instanceGames.Difficulties();
    }

    public void HellButton()
    {
        GamesManager._instanceGames.difficulty = GamesManager.Difficulty.Hell;
        GamesManager._instanceGames.Difficulties();
    }

    public void EvilButton()
    {
        GamesManager._instanceGames.difficulty = GamesManager.Difficulty.Evil;
        GamesManager._instanceGames.Difficulties();
    }

}

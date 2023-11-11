using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAnimation : MonoBehaviour
{
    private Animator _animator;

    // Start is called before the first frame update
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(GamesManager._instanceGames._startAnima)
        {
            _animator.SetBool("Next", true);
        }
    }
}

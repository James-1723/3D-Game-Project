using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public int puzzle = 0;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }



    public void IncreasePuzzleCount()
    {
        puzzle++;
        // 更新UI或其他任何相關操作
    }
}

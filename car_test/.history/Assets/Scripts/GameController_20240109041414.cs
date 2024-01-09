using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int puzzle = 0;

    public void IncreasePuzzleCount()
    {
        puzzle++;
        // 更新UI或其他任何相關操作
    }
}

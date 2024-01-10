using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene4Manage : MonoBehaviour
{
    private GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        gameController = GetComponent<GameController>();

    }

    // Update is called once per frame
    void Update()
    {
        if(GameController.puzzle==4){
            SceneManager.LoadScene("Scene4Trailer");
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField] public GameObject PauseMenuPannel;
    // Start is called before the first frame update
    
    public void Pause(){
        PauseMenuPannel.SetActive(true);
        Time.timeScale=0f;
    }

    public void Resume(){
        PauseMenuPannel.SetActive(false);
        Time.timeScale=1f;
    }

    public void Restart(){
        Time.timeScale=1f;
        SceneManager.LoadScene("GameCover");
    }

}

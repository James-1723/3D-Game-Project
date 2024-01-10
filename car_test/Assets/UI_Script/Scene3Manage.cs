using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Scene3Manage : MonoBehaviour
{
     private TimeManager timeManager;

    // Start is called before the first frame update
    void Start()
    {
        timeManager = GetComponent<TimeManager>();
   
    }

    // Update is called once per frame
   void Update()
    {
        if (TimeManager.timeRemaining == 0)
        {
            StartCoroutine(LoadSceneAfterDelay("Scene3Trailer", 1f));
        }
    }

    IEnumerator LoadSceneAfterDelay(string sceneName, float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(sceneName);
    }
}

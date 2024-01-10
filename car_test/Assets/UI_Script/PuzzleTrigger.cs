using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleTrigger : MonoBehaviour
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
        GameObject targetObject;
        Image imageComponent;

        switch (GameController.puzzle)
        {
            case 1:
                targetObject = GameObject.Find("pz1");
                imageComponent = targetObject?.GetComponent<Image>();
                if (imageComponent != null)
                {
                    imageComponent.enabled = true;
                }
                break;

            case 2:
                targetObject = GameObject.Find("pz2");
                imageComponent = targetObject?.GetComponent<Image>();
                if (imageComponent != null)
                {
                    imageComponent.enabled = true;
                }
                break;

            case 3:
                targetObject = GameObject.Find("pz3");
                imageComponent = targetObject?.GetComponent<Image>();
                if (imageComponent != null)
                {
                    imageComponent.enabled = true;
                }
                break;

            case 4:
                targetObject = GameObject.Find("pz4");
                imageComponent = targetObject?.GetComponent<Image>();
                if (imageComponent != null)
                {
                    imageComponent.enabled = true;
                }
                break;

            default:
                string[] targetObjectNames = { "pz1", "pz2", "pz3", "pz4" };

                foreach (string targetObjectName in targetObjectNames)
                {
                    targetObject = GameObject.Find(targetObjectName);
                    imageComponent = targetObject?.GetComponent<Image>();

                    if (imageComponent != null)
                    {
                        imageComponent.enabled = false;
                    }
                }
                break;
        }
    }
}

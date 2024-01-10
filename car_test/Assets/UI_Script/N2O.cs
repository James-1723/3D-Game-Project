using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class N2O : MonoBehaviour
{
    public Image guiImage; // Reference to your GUI Image component

    void Start()
    {
        // Make sure to assign your GUI Image component in the Unity Editor
        if (guiImage == null)
        {
            Debug.LogError("GUI Image component not assigned.");
        }
    }

    void Update(){
        if(Input.GetKeyDown(KeyCode.J)){
             guiImage.color =  Color.white;
        }
        if (Input.GetKeyUp(KeyCode.J)){
            guiImage.color = new Color(161f / 255f, 160f / 255f, 185f / 255f, 1f);
        }
    }
}

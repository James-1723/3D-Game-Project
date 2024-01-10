using UnityEngine;
using UnityEngine.UI;

public class SendToBack : MonoBehaviour
{
    void Start()
    {
        // 获取当前 GameObject 上的 Image 组件
        Image image = GetComponent<Image>();

        if (image != null && image.canvas != null)
        {
            // 设置 Sorting Layer 为一个较大的值，确保在最后渲染
            image.canvas.overrideSorting = true;
            image.canvas.sortingLayerName = "Background"; // 替换为你的 Sorting Layer 名称
        }
        else
        {
            Debug.LogError("This script should be attached to a GameObject with an Image component and a Canvas component.");
        }
    }
}

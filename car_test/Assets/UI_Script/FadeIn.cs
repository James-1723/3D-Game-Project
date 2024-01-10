using UnityEngine;

public class FadeIn : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public float fadeInTime = 100f;

    void Start()
    {
        if (canvasGroup == null)
        {
            canvasGroup = GetComponent<CanvasGroup>();
            if (canvasGroup == null)
            {
                Debug.LogError("CanvasGroup component not found or assigned.");
                return;
            }
        }

        // Start the fade-in process
        StartFadeIn();
    }

    void StartFadeIn()
    {
        // Set the alpha to 0 initially
        canvasGroup.alpha = 0f;

        // Use a coroutine to gradually increase the alpha over time
        StartCoroutine(FadeInCoroutine());
    }

    System.Collections.IEnumerator FadeInCoroutine()
    {
        float elapsedTime = 0f;

        while (elapsedTime < fadeInTime)
        {
            // Increase the alpha based on time
            canvasGroup.alpha = Mathf.Lerp(0f, 1f, elapsedTime / fadeInTime);

            // Increment the elapsed time
            elapsedTime += Time.deltaTime;

            // Wait for the next frame
            yield return null;
        }

        // Ensure the alpha is exactly 1 at the end
        canvasGroup.alpha = 1f;
    }
}
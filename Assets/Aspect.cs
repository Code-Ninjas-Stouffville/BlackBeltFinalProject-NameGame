using UnityEngine;
using UnityEngine.SceneManagement;

public class Aspect : MonoBehaviour
{
    public string targetSceneName = "PONG"; // Scene name to apply aspect ratio change
    public float targetAspect = 1.777778f;  // Desired aspect ratio (e.g., 16:9)

    private Camera mainCamera;

    private void Start()
    {
        // Get the main camera at the start of the scene
        mainCamera = Camera.main;
        if (mainCamera == null) return;

        // Reset the aspect ratio when the scene is loaded
        if (SceneManager.GetActiveScene().name == targetSceneName)
        {
            SetAspectRatio();
        }
        else
        {
            ResetAspectRatio();
        }
    }

    private void OnEnable()
    {
        // Subscribe to scene change events
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    private void OnDisable()
    {
        // Unsubscribe from scene events
        SceneManager.sceneLoaded -= OnSceneLoaded;
    }

    // Called when a new scene is loaded
    private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == targetSceneName)
        {
            // Apply the aspect ratio when the PONG scene is loaded
            SetAspectRatio();
        }
        else
        {
            // Reset the aspect ratio in all other scenes
            ResetAspectRatio();
        }
    }

    // Apply the target aspect ratio
    private void SetAspectRatio()
    {
        if (mainCamera == null) return;

        // Calculate the scale factor to match the desired aspect ratio
        float windowAspect = (float)Screen.width / (float)Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        if (scaleHeight < 1.0f)
        {
            // Adjust vertical scaling to maintain aspect ratio
            Rect rect = mainCamera.rect;
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
            mainCamera.rect = rect;
        }
        else
        {
            // Adjust horizontal scaling to maintain aspect ratio
            float scaleWidth = 1.0f / scaleHeight;
            Rect rect = mainCamera.rect;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;
            mainCamera.rect = rect;
        }
    }

    // Reset the aspect ratio to the default (1:1) when leaving the PONG scene
    private void ResetAspectRatio()
    {
        if (mainCamera == null) return;

        // Reset camera viewport to default
        Rect rect = mainCamera.rect;
        rect.width = 1.0f;
        rect.height = 1.0f;
        rect.x = 0;
        rect.y = 0;
        mainCamera.rect = rect;
    }
}

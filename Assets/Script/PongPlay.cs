using UnityEngine;
using UnityEngine.SceneManagement; // Required for SceneManager

public class PongPlay : MonoBehaviour
{
    // This method can be hooked up to the button's OnClick event
    public void LoadScene()
    {
        // Load the specified scene
        SceneManager.LoadScene(5);
    }
}
using UnityEngine;
using UnityEngine.SceneManagement; // Required for SceneManager

public class Return : MonoBehaviour
{
    // This method can be hooked up to the button's OnClick event
    public void LoadScene()
    {
        Time.timeScale = 1;
        // Load the specified scene
        SceneManager.LoadScene(0);
    }
}
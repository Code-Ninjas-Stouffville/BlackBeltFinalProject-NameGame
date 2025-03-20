using UnityEngine;
using UnityEngine.SceneManagement; // Required for SceneManager

public class Credit : MonoBehaviour
{
    // This method can be hooked up to the button's OnClick event
    public void LoadScene( int level)
    {
        // Load the specified scene
        SceneManager.LoadScene(level);
    }
}

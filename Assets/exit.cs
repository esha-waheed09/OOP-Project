using UnityEngine;

public class QuitWithEsc : MonoBehaviour
{
    void Update()
    {
        // Check if the Escape key is pressed
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitGame();
        }
    }

    void QuitGame()
    {
        // Quit the game
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Works in Unity Editor
#else
        Application.Quit(); // Works in the built application
#endif
    }
}

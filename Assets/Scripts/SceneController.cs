#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    private int menuSceneIndex = 0;
    private int gameSceneIndex = 1;
    
    public void LoadMenu()
    {
        SceneManager.LoadScene(menuSceneIndex);
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(gameSceneIndex);
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

}

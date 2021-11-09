using UnityEngine;
using UnityEngine.SceneManagement;
public class RestartButton : MonoBehaviour
{
    public string LevelToLoad;
    public void LoadLevel()
    {
        SceneManager.LoadScene(LevelToLoad);
    }
}
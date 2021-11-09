using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeLevel : MonoBehaviour
{
    public string LevelToLoad = "";
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player" & LevelToLoad != "")
        {
            SceneManager.LoadScene(LevelToLoad);
        }
    }
}
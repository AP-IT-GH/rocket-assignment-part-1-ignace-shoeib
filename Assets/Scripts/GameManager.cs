using UnityEngine;
public class GameManager : MonoBehaviour
{
    public GameObject Player;
    public GameObject GameOverCanvas;
    public AudioClip deathSound;
    private Health HealthPlayer;
    public enum GameStates
    {
        Playing,
        GameOver
    }
    public GameStates gameState = GameStates.Playing;
    void Start()
    {
        if (Player == null)
        {
            Player = GameObject.FindWithTag("Player");
        }
        HealthPlayer = Player.GetComponent<Health>();
    }
    void Update()
    {
        switch (gameState)
        {
            case GameStates.Playing:
                if (!HealthPlayer.isAlive)
                {
                    gameState = GameStates.GameOver;
                    GameOverCanvas.SetActive(true);
                    gameObject.GetComponent<AudioSource>().PlayOneShot(deathSound);
                }
                break;
        }
    }
}
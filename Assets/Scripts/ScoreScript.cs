using System;
using UnityEngine;
using UnityEngine.UI;
public class ScoreScript : MonoBehaviour
{
    public GameObject ScoreUI;
    public int Score;
    public AudioClip CoinSound;
    private bool collected;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" & !collected)
        {
            collected = true;
            other.GetComponent<AudioSource>().PlayOneShot(CoinSound);
            ScoreUI.GetComponent<Text>().text = Convert.ToString(Convert.ToInt32(ScoreUI.GetComponent<Text>().text) + Score);
            Destroy(gameObject);
        }
    }
}
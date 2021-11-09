using UnityEngine;
using UnityEngine.UI;

public class RocketDamage : MonoBehaviour
{
    public GameObject LivesText;
    public float Timer;
    public AudioClip DamageSound;
    public AudioSource DamageSource;

    private float time = 0;
    void Update()
    {
        time -= Time.deltaTime;
        if (transform.position.y < 0)
        {
            gameObject.GetComponent<Health>().healthPoints = 0;
            LivesText.GetComponent<Text>().text = "";
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (time <= 0 & other.tag != "Coin")
        {
            DamageSource.PlayOneShot(DamageSound);
            gameObject.GetComponent<Health>().healthPoints--;
            LivesText.GetComponent<Text>().text = LivesText.GetComponent<Text>().text.Substring(0, LivesText.GetComponent<Text>().text.Length - 2);
            time = Timer;
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        if (time <= 0 & other.transform.tag == "Enemy")
        {
            DamageSource.PlayOneShot(DamageSound);
            gameObject.GetComponent<Health>().healthPoints--;
            LivesText.GetComponent<Text>().text = LivesText.GetComponent<Text>().text.Substring(0, LivesText.GetComponent<Text>().text.Length - 2);
            time = Timer;
        }
    }
}
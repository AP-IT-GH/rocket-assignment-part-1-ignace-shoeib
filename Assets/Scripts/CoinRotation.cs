using UnityEngine;
public class CoinRotation : MonoBehaviour
{
    public float speed;
    void Update()
    {
        transform.Rotate(Vector3.up * speed * Time.deltaTime);
    }
}
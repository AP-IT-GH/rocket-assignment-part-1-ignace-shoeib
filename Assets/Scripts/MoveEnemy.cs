using UnityEngine;
using System.Collections;
public class MoveEnemy : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 10f;
    private bool collision = false;

    IEnumerator Start()
    {
        while (true)
        {
            do yield return null; while (MoveTowards(pointA));
            do yield return null; while (MoveTowards(pointB));
        }
    }

    bool MoveTowards(Transform target)
    {
        transform.position = Vector3.MoveTowards(
            transform.position,
            target.position,
            speed * Time.deltaTime);
        if (collision)
        {
            return false;
        }
        return transform.position != target.position;
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            this.collision = true;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.transform.CompareTag("Player"))
        {
            this.collision = false;
        }
    }
}
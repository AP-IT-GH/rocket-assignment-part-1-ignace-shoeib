using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
public class RocketController : MonoBehaviour
{
    public List<ParticleSystem> particleSystems;
    private Rigidbody rb;
    public float jumpPower;
    public float rotationPower;
    private bool jump;
    public AudioSource rocketSource;
    private void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        jump = CrossPlatformInputManager.GetButton("Jump");
        float h = CrossPlatformInputManager.GetAxis("Horizontal");
        if (jump)
        {
            rocketSource.enabled = true;
            rb.velocity += transform.up*jumpPower;
            for (int i = 0; i < particleSystems.Count; i++)
            {
                var e = particleSystems[i].emission;
                e.enabled = true;
            }
        }
        else
        {
            rocketSource.enabled = false;
            for (int i = 0; i < particleSystems.Count; i++)
            {
                var e = particleSystems[i].emission;
                e.enabled = false;
            }
        }
        rb.angularVelocity = new Vector3(h * rotationPower, 0, 0);
    }
}
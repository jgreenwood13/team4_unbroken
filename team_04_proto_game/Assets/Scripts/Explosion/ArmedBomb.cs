using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ArmedBomb : MonoBehaviour
{

    float delay;
    float countdown;
    bool hasExploded = false;

    public float radius = 5f;
    public float force = 700;

    public GameObject explosionEffect;
    public GameObject fire1;
    public GameObject fire2;
    public CountdownTimer timer; // connects countdown timer script to armed bomb script
    public AudioSource explodeSound;
    public AudioSource fireCrackling;
 
    // Start is called before the first frame update
    void Start()
    {
        delay = timer.timeLeft;
       //print(timer.timeLeft); 
       countdown = delay;
    }

    // Update is called once per frame
    void Update()
    {
        //print(countdown);
        //print(Time.deltaTime);
        countdown -= Time.deltaTime;

        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            // Debug.Log("Boom");
            hasExploded = true;
        }

    }

    void Explode()
    {
        // Show effect
        Instantiate(explosionEffect, transform.position, transform.rotation);
        explodeSound.Play();
        //Debug.Log("Boom");

        // Get nearby objects
       /* Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in colliders)
        {
            // Add force
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
            // Damage
            /*Destructible dest = nearbyObject.GetComponent<Destructible>();
            if (dest != null)
            {
                dest.Destroy();
            }
        }*/
        // Show fire effect (may need to stop once passed level)
        Instantiate(fire1, transform.position, transform.rotation);
        Instantiate(fire2, transform.position, transform.rotation);

        //fire.Play();
        fireCrackling.Play();

        // Remove bomb
        Destroy(gameObject);

    }
}

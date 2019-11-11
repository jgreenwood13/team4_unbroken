using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmedBomb : MonoBehaviour
{
    public float delay = 10f;
    float countdown;
    bool hasExploded = false;

    public float radius = 5f;
    public float force = 700;

    public GameObject explosionEffect;
    public ParticleSystem fire;
 
    // Start is called before the first frame update
    void Start()
    {
        //CountdownTimer timer = GetComponent<CountdownTimer>();
        //delay = timer.timeLeft;

        countdown = delay;
        //fire.gameObject.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {

        countdown -= Time.deltaTime;
        if (countdown <= 0f && !hasExploded)
        {
            Explode();
            //Debug.Log("Boom");
            hasExploded = true;
        }

    }


    void Explode()
    {
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Debug.Log("Boom");

        //Get nearby objects
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);
        foreach (Collider nearbyObject in colliders)
        {
            //Add force
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(force, transform.position, radius);
            }
            //Damage
            Destructible dest = nearbyObject.GetComponent<Destructible>();
            if (dest != null)
            {
                dest.Destroy();
            }
        }
        fire.Play();

        //Remove bomb
        Destroy(gameObject);
        //fire.Play();
        //Instantiate(fire, transform.position, transform.rotation);

    }
}

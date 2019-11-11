using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public GameObject destroyedVersions;

    public void Destroy()
    {
        Instantiate(destroyedVersions, transform.position, transform.rotation);

        Destroy(gameObject);
    }
}

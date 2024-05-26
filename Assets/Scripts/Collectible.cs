using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public virtual void Collected(GameObject gameobject){}

    void OnCollisionEnter(Collision collision)
    {
        Collected(collision.gameObject);
    }

    void OnTriggerEnter(Collider other)
    {
        Collected(other.gameObject);
    }
}

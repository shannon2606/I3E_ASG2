using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : Collectible
{
    public const float speedIncreaseVal = 2.0f;

    public override void Collected(GameObject gameobject)
    {
        StarterAssets.FirstPersonController firstPlayer = GameObject.FindWithTag("Player").GetComponent<StarterAssets.FirstPersonController>();
        if (firstPlayer != null)
        {
            firstPlayer.MoveSpeed += speedIncreaseVal;
            Debug.Log("Player's current speed " + speedIncreaseVal);
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Collectible
{
    public const float jumpIncreaseVal = 1.0f;

    public override void Collected(GameObject gameobject)
    {
        StarterAssets.FirstPersonController firstPlayer = gameobject.GetComponent<StarterAssets.FirstPersonController>();
        if (firstPlayer != null)
        {
            firstPlayer.JumpHeight += jumpIncreaseVal;
            Debug.Log("Player's current jump height " + jumpIncreaseVal);
            Destroy(gameObject);
        }
    }
}


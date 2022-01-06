using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.name == "Ball")
        {
            SpawnPlatform.Teleport();
        }
    }

}

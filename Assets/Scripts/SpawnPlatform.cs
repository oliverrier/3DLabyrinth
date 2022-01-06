using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    private static GameObject _Ball;
    private static GameObject _Platform;
    // Start is called before the first frame update
    void Start()
    {
        _Ball = GameObject.Find("Ball");
        _Platform = GameObject.Find("SpawnPlatform");
        Teleport();
    }

    public static void Teleport()
    {
        Vector3 spawnPlatformPosition = _Platform.transform.position;
        _Ball.transform.position = spawnPlatformPosition;
        _Ball.transform.position.Set(spawnPlatformPosition.x, spawnPlatformPosition.y + 2, spawnPlatformPosition.z);
    }
}

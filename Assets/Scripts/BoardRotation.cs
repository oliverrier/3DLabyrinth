using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardRotation : MonoBehaviour
{
    public float rotateSpeed = 50;

    // Update is called once per frame
    private void Update()
    {
        var rotateX = Input.GetAxis("Horizontal");
        var rotateZ = Input.GetAxis("Vertical");
        
        transform.Rotate(rotateX * Vector3.back * Time.deltaTime * rotateSpeed);
        transform.Rotate(rotateZ * Vector3.right * Time.deltaTime * rotateSpeed);
    }
}

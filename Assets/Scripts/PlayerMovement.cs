using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Vector3 initialScale = new Vector3(1, 1, 1);
    public Vector3 direction = Vector3.forward;
    public float speed = 1f;
    void Start()
    {
        transform.localScale = initialScale;
    }
    private void Update() 
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}

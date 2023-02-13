using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutomaticVehicle : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public Vector3 direction;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{

    public GameObject mainCamera;
    // Start is called before the first frame update
    public GameObject secondaryCamera;

    public float toggleCooldown = 0.5F;
    private bool camera;

    private float myTime = 0.0F;
    private float nextFire = 0.5F;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        myTime = myTime + Time.deltaTime;

        if (Input.GetButton("Fire1") && myTime > nextFire) {
            nextFire = myTime + toggleCooldown;
            camera = !camera;
            if (camera) {
                mainCamera.SetActive(true);
                secondaryCamera.SetActive(false);
            } else {
                secondaryCamera.SetActive(true);
                mainCamera.SetActive(false);
            }
        }
        
    }
}

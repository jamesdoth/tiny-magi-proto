using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shooting : MonoBehaviour
{
    private Camera mainCam;
    private Vector2 mousePos;
    private Vector3 worldMousePos;
    private Vector3 rotation;
    public GameObject bullet;
    public Transform bulletTransform;
    public bool canFire;
    private float timer;
    public float timeBetweenFiring;

    void Start()
    {
        GameObject mainCamObject = GameObject.FindGameObjectWithTag("MainCamera");
        if (mainCamObject != null)
        {
            mainCam = mainCamObject.GetComponent<Camera>();
        }
        else
        {
            Debug.LogError("Main camera not found in the scene.");
        }
    }

    private void Update()
    {
        mousePos = Mouse.current.position.ReadValue();

        worldMousePos = mainCam.ScreenToWorldPoint(mousePos);
        rotation = worldMousePos - transform.position;
        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0, 0, rotZ);

        if (!canFire )
        {
            timer += Time.deltaTime;
            if(timer > timeBetweenFiring )
            {
                canFire = true;
                timer = 0;
            }
        }

        if (Mouse.current.leftButton.isPressed && canFire)
        {
            canFire = false;
            Instantiate(bullet, bulletTransform.position, Quaternion.identity);
        }
    }
}

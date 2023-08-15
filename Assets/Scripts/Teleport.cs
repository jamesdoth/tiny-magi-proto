using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleport : MonoBehaviour
{
    private Vector3 mousePosition;
    private Vector3 worldMousePosition;

    private void Update()
    {

    }

    public void TeleportToMousePosition()
    {
        mousePosition = Mouse.current.position.ReadValue();
        worldMousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        worldMousePosition.z = transform.position.z; // Keep the same Z position as the player
        transform.position = worldMousePosition;
    }
}

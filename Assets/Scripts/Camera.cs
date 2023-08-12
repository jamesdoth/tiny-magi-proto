using UnityEngine;

public class Camera : MonoBehaviour
{
    [SerializeField] GameObject thingsToFollow;

    void LateUpdate()
    {
        transform.position = thingsToFollow.transform.position + new Vector3(0, 0, -10);
    }
}

using UnityEngine;

public class FollowTarget : MonoBehaviour
{
    public Transform target;

    void LateUpdate()
    {
        transform.position = target.position + new Vector3(0, 0, -10);
    }
}
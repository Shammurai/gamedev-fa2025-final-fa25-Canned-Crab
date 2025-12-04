using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform target;

    Vector3 posWorkshop = new Vector3(-0.44f, 0.1f, -10.0f);
    Vector3 posStorage = new Vector3(-0.44f, -10.87119f, -10.0f);

    // store a set of camera positions, then interpolate between positions
    // when moving to another room?

    private void LateUpdate()
    {
        transform.position = new Vector3(
            transform.position.x,
            Mathf.Clamp(target.position.y, posStorage.y, posWorkshop.y),
            transform.position.z
        );
    }
}

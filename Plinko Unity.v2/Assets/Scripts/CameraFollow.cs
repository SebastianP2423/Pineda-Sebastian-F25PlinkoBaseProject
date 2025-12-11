using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Camera camera;
    public GameObject player;
    public GameObject disc;
    public float lerpRate = 0.5f;

    void FixedUpdate()
    {
        Vector3 targetPosition;
        if (disc == null)
        {
            targetPosition = player.transform.position;
        }
        else
        {
            targetPosition = disc.transform.position;
        }
        targetPosition.x = camera.transform.position.x;
        targetPosition.z = camera.transform.position.z;

        camera.transform.position = Vector3.Lerp(camera.transform.position, targetPosition, lerpRate);
    }

    public void FollowDisc(GameObject disc)
    {

        this.disc = disc;
    }
}
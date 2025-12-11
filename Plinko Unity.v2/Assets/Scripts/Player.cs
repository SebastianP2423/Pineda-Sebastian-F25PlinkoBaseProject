using Unity.VisualScripting;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 1;
    public GameObject disc;
    public CameraFollow cameraFollow;
    private GameObject activeDisc;

    void Update()
    {
        Move();
        DropDisc();
        NotifyDiscDestroyed();
    }
    public void NotifyDiscDestroyed() 
    {
        activeDisc = null;
        if (cameraFollow != null) 
        {
            cameraFollow.FollowPlayer();
        }
    }
    
    void DropDisc()
    {
        
        if (Input.GetButtonDown("Fire1") && activeDisc == null)
        {
            Vector3 position = transform.position;
            Quaternion rotation = transform.rotation;
            activeDisc = Instantiate(disc, position, rotation);
            cameraFollow.FollowDisc(activeDisc);
        }
    }

    void Move()
    { 

        float movementX = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        Vector3 offset = new Vector3(movementX, 0, 0);
        transform.position += offset;
    }
}
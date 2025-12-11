using UnityEngine;

public class PlatformObstacle : MonoBehaviour
{
    public float speed = 10f;
    public float amplitude = 30f;
    private Rigidbody2D rb;
    private Vector2 startPos;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        if (rb == null)
       
        startPos = transform.position;
    }   


    void Update()
    {
        if (rb != null) 
        { 
            float x = Mathf.PingPong(Time.time * speed, amplitude);         // I found the "Mathf.PingPong" function under the static methods tab in the Unity API sir
            rb.MovePosition(new Vector2(startPos.x + x, rb.position.y));    // I also found this under Rigidbody2D since its capable of moving an rb to a specified position on the x axis which is what i needed
        }
    }
}

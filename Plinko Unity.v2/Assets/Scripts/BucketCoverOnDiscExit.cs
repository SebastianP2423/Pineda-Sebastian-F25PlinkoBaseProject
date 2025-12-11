using UnityEngine;

public class BucketCoveronDiscExit : MonoBehaviour
{
    public GameObject cover;

    private void Start()
    {
        if (cover != null) 
        {
            cover.SetActive(false);
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (!other.CompareTag("Disc")) return;

        if (cover != null) 
        {
            cover.SetActive(true);
        }
    }
}

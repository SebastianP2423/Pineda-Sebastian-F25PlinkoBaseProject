using UnityEngine;

public class DiscNotifier : MonoBehaviour
{
    private void OnDestroy()
    {
        Player player = Object.FindAnyObjectByType<Player>();
        if (player != null)
        {
            player.NotifyDiscDestroyed();
        }
    }
}

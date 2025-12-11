using UnityEngine;

public class DiscNotifier : MonoBehaviour
{
    private void OnDestroy()
    {
        Player player = FindFirstObjectByType<Player>();
        if (player != null)
        {
            player.NotifyDiscDestroyed();
        }
    }
}

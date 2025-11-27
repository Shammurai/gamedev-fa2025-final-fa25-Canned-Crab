using UnityEngine;

public class SpawnPoint : MonoBehaviour
{
    public string spawnName = "SpawnPoint";
    
    // TODO: Future Enhancement - Directional Spawning
    // Add: public enum SpawnDirection { North, South, East, West }
    // Add: public SpawnDirection spawnDirection;
    // This would allow matching spawn points to door directions for more logical room transitions

    private void Start()
    {
        // Check if this is where the player should spawn
        if (RoomManager.nextSpawnPoint == spawnName)
        {
            TeleportPlayer();
            RoomManager.nextSpawnPoint = "";  // Clear it
        }
    }

    private void TeleportPlayer()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        if (player != null)
        {
            // Use Rigidbody2D to teleport for proper physics handling
            Rigidbody2D rb = player.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                rb.position = transform.position;
            }
            else
            {
                player.transform.position = transform.position;
            }
            
            // Make sure camera follows immediately
            Camera.main.transform.position = new Vector3(transform.position.x, transform.position.y, Camera.main.transform.position.z);
        }
        else
        {
            Debug.LogWarning("Player not found! Make sure player has 'Player' tag.");
        }
    }

    // Optional: Draw gizmo in editor to see spawn points
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
}

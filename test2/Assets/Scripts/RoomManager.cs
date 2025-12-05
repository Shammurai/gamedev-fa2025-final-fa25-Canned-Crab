using UnityEngine;

public class RoomManager : MonoBehaviour
{
    public static RoomManager Instance;
    public static string nextSpawnPoint = "";
    
    // TODO: Future Enhancement - Directional Spawning
    // Add: public static string doorDirection = "";
    // This would store which direction the player entered from (North, South, East, West)

    private void Awake()
    {
        // Singleton pattern - persist between scenes
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}

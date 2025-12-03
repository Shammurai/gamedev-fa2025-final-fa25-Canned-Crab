using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    [Header("Door Settings")]
    public string targetSceneName;  // Name of the scene to load
    public string spawnPointName = "SpawnPoint";  // Name of spawn point in target scene
    public KeyCode interactKey = KeyCode.E;  // Key to press to enter door
    
    // TODO: Future Enhancement - Directional Spawning
    // Add: public enum DoorDirection { North, South, East, West }
    // Add: public DoorDirection doorDirection;
    // This would allow player to spawn facing the correct direction based on which door they entered

    [Header("Optional")]
    public bool showPrompt = true;
    public GameObject promptUI;  // Optional UI prompt (e.g., "Press E to enter")

    private bool playerNearby = false;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = true;
            if (showPrompt && promptUI != null)
            {
                promptUI.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerNearby = false;
            if (promptUI != null)
            {
                promptUI.SetActive(false);
            }
        }
    }

    private void Update()
    {
        if (playerNearby && Input.GetKeyDown(interactKey))
        {
            TransitionToRoom();
        }
    }

    private void TransitionToRoom()
    {
        if (string.IsNullOrEmpty(targetSceneName))
        {
            Debug.LogError("No target scene set for door!");
            return;
        }

        // Store spawn point info before loading scene
        RoomManager.nextSpawnPoint = spawnPointName;
        SceneManager.LoadScene(targetSceneName);
    }
}

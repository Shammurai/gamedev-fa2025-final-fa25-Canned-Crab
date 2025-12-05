using UnityEngine;

public class MinigameZone : MonoBehaviour
{

    private bool playerInZone = false;

    void Update()
    {
        if(playerInZone && Input.GetKeyDown(KeyCode.E))
        {
            //Debug.Log("test");

            MinigameManager.Instance.OpenMinigame();

            // closing minigame now handled by MinigameManager
            //MinigameManager.Instance.CloseMiniGame();
        }
        
        /*
        if(MinigameManager.Instance.IsMinigameOpen() && Input.GetKeyDown(KeyCode.Escape))
        {
            MinigameManager.Instance.CloseMiniGame();
        }
        */
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerInZone = false;
        } 
    }
}

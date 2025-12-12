using UnityEngine;

public class MinigameTrigger : MonoBehaviour
{
    public Minigame game;
    public GameObject interactPopup;

    private bool playerInRange = false;

    void Update()
    {
        if (!playerInRange) { return;  }

        // Only listen for input when player is in range
        if (Input.GetKeyDown(KeyCode.E))
        {
            interactPopup.SetActive(false);
            MinigameManager.Instance.StartMinigame(game);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            interactPopup.SetActive(true);
            MinigameManager.Instance.EndMinigame();
        }
    }


    // Detect player entering the trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = true;
            interactPopup.SetActive(true);
        }
    }

    // Detect player leaving the trigger
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            playerInRange = false;
            interactPopup.SetActive(false);
        }
    }
}

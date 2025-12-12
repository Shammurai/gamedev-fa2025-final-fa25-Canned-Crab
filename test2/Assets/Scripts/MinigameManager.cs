using UnityEngine;

public class MinigameManager : MonoBehaviour
{
    public static MinigameManager Instance;

    private Minigame currentMinigame;

    private void Awake()
    {
        Instance = this;
    }

    public void StartMinigame(Minigame minigame)
    {
        if (currentMinigame != null) return;

        currentMinigame = minigame;
        currentMinigame.gameObject.SetActive(true);
        currentMinigame.StartMinigame();

        Time.timeScale = 0f; // freeze world
    }

    public void EndMinigame()
    {
        if (currentMinigame == null) return;

        currentMinigame.EndMinigame();
        currentMinigame.gameObject.SetActive(false);

        currentMinigame = null;
        Time.timeScale = 1f;
    }
}

using UnityEngine.Rendering;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections.Generic;

public class MinigameManager : MonoBehaviour
{

    public static MinigameManager Instance; // This makes it a singleton
                                            // There can only be one instance of this object
    public GameObject minigameCanvas;
    public GameObject player;
    public bool pauseMinigame = true;


    private bool minigameOpen = false;
    private int clickCount;
    public int clickCountMax = 10;

    private void Awake()
    {
        // singleton initialization; there can only be one
        if (Instance == null)
        {
            Instance = this;
            minigameOpen = true;
        }
        else
        {
            Destroy(gameObject);
        }

        minigameCanvas.SetActive(false);
        clickCount = 0;

    }

    public void OpenMinigame()
    {
        minigameCanvas.SetActive(true);
        clickCount = 0;

        if (pauseMinigame)
        {
            Time.timeScale = 0.0f;
            if (player != null)
            {
                player.GetComponent<PlayerMovement>().enabled = false;
            }
        }
    }

    public void CloseMiniGame()
    {
        minigameCanvas.SetActive(false);

        if (pauseMinigame)
        {
            Time.timeScale = 1.0f;
            if (player != null)
            {
                player.GetComponent<PlayerMovement>().enabled = true;
            }
        }
    }

    public void OnButtonClick(Button button)
    {
        Canvas canvas = button.GetComponentInParent<Canvas>();

        if(canvas != null)
        {
            RectTransform canvasRect = canvas.GetComponent<RectTransform>();
            RectTransform buttonRect = button.GetComponent<RectTransform>();

            float canvasWidth = canvasRect.rect.width;
            float canvasHeight = canvasRect.rect.height;

            float buttonWidth = buttonRect.rect.width;
            float buttonHeight = buttonRect.rect.width;

            // randomize button position for each click
            Vector2 newPosition = GetRandomPosInBounds(canvasWidth, canvasHeight, buttonWidth, buttonHeight);

            buttonRect.anchoredPosition = newPosition;

            // shrink the button for each click
            Vector3 buttonScale = buttonRect.localScale;
            Vector3 changeScale = buttonScale / clickCountMax;

            buttonRect.localScale = buttonScale - changeScale;
        }


        incrementClicks();
    }

    private Vector2 GetRandomPosInBounds(float canvasWidth, float canvasHeight, float buttonWidth, float buttonHeight)
    {
        float randomX = Random.Range(buttonWidth - canvasWidth/2, canvasWidth/2 - buttonWidth);
        float randomY = Random.Range(buttonHeight - canvasHeight/2, canvasHeight/2 - buttonHeight);

        return new Vector2(randomX, randomY);
    }

    private void incrementClicks()
    {
        clickCount++;

        if(clickCount > clickCountMax)
        {
            CloseMiniGame();
        }
    }

    public bool IsMinigameOpen()
    {
        return minigameOpen;
    }


    public void CheckCanvasExit()
    {
    }

    private bool IsPointerOverUIObject()
    {
        PointerEventData pointerData = new PointerEventData(EventSystem.current)
        {
            position = Input.mousePosition
        };

        List<RaycastResult> results = new List<RaycastResult>();
        EventSystem.current.RaycastAll(pointerData, results);

        // literally just returns if cursor is over any UI item
        return results.Count > 0;

    }
}

using UnityEngine;
using UnityEngine.UI;

public class ShelfMinigame : Minigame
{
    [Header("UI")]
    public GameObject minigameUI;
    public RectTransform dustContainer;  

    [Header("Items")]
    public GameObject itemPrefab;
    public Sprite[] itemSprites;
    public int itemCount = 4;

    private int dustRemaining;

    public override void StartMinigame()
    {
        minigameUI.SetActive(true);

        dustRemaining = itemCount;

        foreach (Transform child in dustContainer)
            Destroy(child.gameObject);

        for (int i = 0; i < itemCount; i++)
        {
            SpawnDust();
        }
    }

    public override void EndMinigame()
    {
        minigameUI.SetActive(false);

    }

    private void SpawnDust()
    {
        GameObject dust = Instantiate(itemPrefab, dustContainer);

        // Random position
        RectTransform t = dust.GetComponent<RectTransform>();
        t.anchoredPosition = new Vector2(
            Random.Range(-dustContainer.rect.width / 2, dustContainer.rect.width / 2),
            Random.Range(-dustContainer.rect.height / 2, dustContainer.rect.height / 2)
        );

        Image img = dust.GetComponent<Image>();
        img.sprite = itemSprites[Random.Range(0, itemSprites.Length)];

        dust.GetComponent<Button>().onClick.AddListener(() =>
        {
            Destroy(dust);
            dustRemaining--;

            if (dustRemaining <= 0)
            {
                MinigameManager.Instance.EndMinigame();
            }
        });
    }
}

using UnityEngine;
using UnityEngine.UI;

public class DustingMinigame : Minigame
{
    [Header("UI")]
    public GameObject minigameUI;
    public RectTransform dustContainer;  

    [Header("Dust")]
    public GameObject dustPrefab;
    public Sprite[] dustSprites;
    public int dustCount = 10;

    private int dustRemaining;

    public override void StartMinigame()
    {
        minigameUI.SetActive(true);

        dustRemaining = dustCount;

        foreach (Transform child in dustContainer)
            Destroy(child.gameObject);

        for (int i = 0; i < dustCount; i++)
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
        GameObject dust = Instantiate(dustPrefab, dustContainer);

        // Random position
        RectTransform t = dust.GetComponent<RectTransform>();
        t.anchoredPosition = new Vector2(
            Random.Range(-dustContainer.rect.width / 2, dustContainer.rect.width / 2),
            Random.Range(-dustContainer.rect.height / 2, dustContainer.rect.height / 2)
        );

        Image img = dust.GetComponent<Image>();
        img.sprite = dustSprites[Random.Range(0, dustSprites.Length)];

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

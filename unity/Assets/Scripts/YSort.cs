using UnityEngine;


// This is how I enforce sprite layering for immersion and stuff. Anything with a sprite rendered
// that we want layered should have this script

[RequireComponent(typeof(SpriteRenderer))]
public class YSort : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // change this for custom objects
    public int sortingOffset = 0;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void LateUpdate()
    {
        // The 100 multiplication increases precision, since position.y is just a float on a small interval.
        // expanding the interval will increase the granularity by which we layer things
        spriteRenderer.sortingOrder = Mathf.RoundToInt(-(transform.position.y * 100)) + sortingOffset;
    }
}

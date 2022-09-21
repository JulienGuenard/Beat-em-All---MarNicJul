using UnityEngine;

public class SpriteOrder : MonoBehaviour
{
    public SpriteRenderer spriteR;
    public int offset;

    private void Update()
    {
        Order();
    }

    void Order()
    {
        spriteR.sortingOrder = (Mathf.RoundToInt(transform.position.y * 100f) * -1) - offset;
    }
}

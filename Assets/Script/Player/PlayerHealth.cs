using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public float lifeMax;
    float lifeCurrent;

    void Start()
    {
        lifeCurrent = lifeMax;
    }

    public void LifeCurrentAdd(float value)
    {
        lifeCurrent -= value;
    }
}

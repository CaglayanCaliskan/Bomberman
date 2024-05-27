
using UnityEngine;

public class Destructible : MonoBehaviour
{
    public float destrubtionTime = 1f;
    private void Start()
    {
        Destroy(gameObject, destrubtionTime);
    }
}

using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    public float SpinSpeed = 10f;
    public float updownspeed = 10f;

    void Update()
    {
        transform.Rotate(Vector3.up * SpinSpeed * Time.deltaTime);
        transform.Translate(Vector3.up * updownspeed * Time.deltaTime);
    }
}

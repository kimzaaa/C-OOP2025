using UnityEngine;

public class Coin : MonoBehaviour
{
    public float CoinVal = 5f;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Money.Instance.AddMoney(CoinVal);

            Destroy(gameObject);
        }
    }
}

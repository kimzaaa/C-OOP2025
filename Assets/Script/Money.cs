using UnityEngine;

public class Money : MonoBehaviour
{
    public static Money Instance { get; private set; }

    public float TotalMoney { get; private set; }
    public float MoneyShow = 0f;
    

    private void Awake()
    {
        Instance = this;
        TotalMoney = 0f;
    }

    public void AddMoney(float money)
    {
        TotalMoney += money;
    }
    void Update()
    {
        MoneyShow = TotalMoney;
    }
}

using UnityEngine;
using UnityEngine.Events;

public class PlayerController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private float jump = 20;
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private float rotationSpeed = 100.0f;

    public UnityEvent<int> OnMoneyChanged;

    private int _totalMoney;
    public int TotalMoney
    {
        get
        {
            Debug.Log("Someone Try To Get Money");
            return _totalMoney;
        }
        set
        {
            Debug.Log("Someone Try To Set Money");
            _totalMoney = Mathf.Max(0, value);
            MoneyShow = _totalMoney;
            if (OnMoneyChanged != null)
            {
                OnMoneyChanged.Invoke(_totalMoney);    
            }
        }
    }

    [SerializeField] private int MoneyShow;

    public int TotalHP = 100;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float translation = Input.GetAxis("Vertical") * speed;
        float rotation = Input.GetAxis("Horizontal") * rotationSpeed;

        translation *= Time.deltaTime;
        rotation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);

        if (Input.GetButton("Jump"))
        {
            rb.AddForce(transform.up * jump);
        }

        if (TotalHP <= 0)
        {
            Destroy(gameObject);
        }
    }

    public void UpdateMoney(int amount)
    {
        TotalMoney += amount;
    }
}

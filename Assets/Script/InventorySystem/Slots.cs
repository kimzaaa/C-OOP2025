using UnityEngine;
using UnityEngine.UI;

public class Slots : MonoBehaviour
{
    public ItemData SlotData;

    private Image _image;

    void Start()
    {
        _image = gameObject.GetComponent<Image>();
    }

    void Update()
    {
        if (SlotData != null)
        {
            _image.sprite = SlotData.Image;
        }
        else if(SlotData == null)
        {
            _image.sprite = null;
        }
    }
}

using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    [HideInInspector] public ItemData InputData;

    public PopUpEquip PopUpEquipUI;
    public Image ItemImage;
    public GameObject EquipMark;

    public void Init(ItemData data)
    {
        InputData = data;
        ItemImage.sprite = data.Image;
        ItemImage.enabled = true;

        ChangeEquip();
    }

    public void ChangeEquip()
    {
        if (InputData.IsEquipped)
        {
            EquipMark.SetActive(true);
        }
        else
        {
            EquipMark.SetActive(false);
        }
    }

    public void PopUp()
    {
        PopUpEquipUI.PopupSetting(this);
    }
}

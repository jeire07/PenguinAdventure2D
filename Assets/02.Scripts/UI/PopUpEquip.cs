using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PopUpEquip : MonoBehaviour
{
    [SerializeField] private TMP_Text infoText;
    [SerializeField] private Button confirmBtn;

    public void PopupSetting(ItemSlot slot)
    {
        if(slot.InputData.IsEquipped)
        {
            infoText.text = "������ �����Ͻðڽ��ϱ�?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() =>
            {
                slot.InputData.IsEquipped = false;
                slot.ChangeEquip();
            });
        }
        else
        {
            infoText.text = "�����Ͻðڽ��ϱ�?";
            confirmBtn.onClick.RemoveAllListeners();
            confirmBtn.onClick.AddListener(() =>
            {
                slot.InputData.IsEquipped = true;
                slot.ChangeEquip();
            });
        }
    }
}

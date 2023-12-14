using UnityEngine;
using TMPro;
using static TMPro.SpriteAssetUtilities.TexturePacker_JsonArray;

public class StatusUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _atkText;
    [SerializeField] private TMP_Text _defText;
    [SerializeField] private TMP_Text _hpText;
    [SerializeField] private TMP_Text _mpText;
    [SerializeField] private TMP_Text _speedText;
    [SerializeField] private TMP_Text _critRateText;

    private int _maxHp;
    private int _hp;
    private int _maxMp;
    private int _mp;
    private int _critPercent;

    // Start is called before the first frame update
    void Start()
    {
        GetChangedInfo();
    }

    private void OnEnable()
    {
        GetChangedInfo();
    }

    private void GetChangedInfo()
    {
        // Atk, Def
        _atkText.text = UserDataManager.Instance.userData.Atk.ToString();
        _defText.text = UserDataManager.Instance.userData.Def.ToString();

        // Hp
        _hp = UserDataManager.Instance.userData.Hp;
        _maxHp = UserDataManager.Instance.userData.MaxHp;
        _hpText.text = $"{_hp} / {_maxHp}";

        // Mp
        _mp = UserDataManager.Instance.userData.Mp;
        _maxMp = UserDataManager.Instance.userData.MaxMp;
        _mpText.text = $"{_mp} / {_maxMp}";

        // Critical
        _critPercent = UserDataManager.Instance.userData.CritPercent;
        _critRateText.text = $"{_critPercent} %";

        // Movement Speed
        _speedText.text = UserDataManager.Instance.userData.Speed.ToString();
    }
}

using UnityEngine;
using TMPro;

public class MainUI : MonoBehaviour
{
    [SerializeField] private TMP_Text _jobText;
    [SerializeField] private TMP_Text _userName;
    [SerializeField] private TMP_Text _levelValue;
    [SerializeField] private TMP_Text _expValue;
    [SerializeField] GameObject _expCurrent;
    [SerializeField] private TMP_Text _description;
    [SerializeField] private TMP_Text _meat;
    
    private int _currentExp;
    private int _maxExp;
    private float _expBarLength;

    //Start is called before the first frame update
    void Start()
    {
        // Job, UserName
        _jobText.text = UserDataManager.Instance.userData.Species.ToString();
        _userName.text = UserDataManager.Instance.userData.Name.ToString();

        // Description
        _description.text = UserDataManager.Instance.userData.Description;

        GetChangedInfo();
    }

    private void OnEnable()
    {
        GetChangedInfo();
    }

    private void GetChangedInfo()
    {
        // Level
        _levelValue.text = UserDataManager.Instance.userData.Level.ToString();

        // Exp value
        _currentExp = UserDataManager.Instance.userData.Exp;
        _maxExp = UserDataManager.Instance.userData.MaxExp;
        _expValue.text = $"{_currentExp} / {_maxExp}";

        // Exp Progress Bar
        _expBarLength = _currentExp / _maxExp;
        _expCurrent.transform.localScale = new Vector3(_expBarLength, 1.0f, 1.0f);

        // Meat (= substitute of gold)
        _meat.text = UserDataManager.Instance.userData.Meat.ToString();
    }
}

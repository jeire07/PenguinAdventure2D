using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MainUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _jobText;
    [SerializeField] private TextMeshProUGUI _userName;
    [SerializeField] private TextMeshProUGUI _levelValue;
    [SerializeField] private TextMeshProUGUI _ExpValue;
    [SerializeField] GameObject _ExpCurrent;

    private int _currentExp;
    private int _maxExp;
    private float _expBarLength;

    //Start is called before the first frame update
    void Start()
    {
        _currentExp = UserDataManager.Instance.userData.Exp;
        _maxExp = GameManager.Player.MaxExp;


        _jobText.text = GameManager.Player.Job.ToString();
        _userName.text = GameManager.Player.Name.ToString();
        _levelValue.text = GameManager.Player.Level.ToString();
        _ExpValue.text = $"{_currentExp} / {_maxExp}";
        _ExpCurrent.transform.localScale = new Vector3(_expBarLength, 1.0f, 1.0f);

    public string Nickname;
    public int Level;
    public int Exp;
    public string Description;
    public int Coin;

    public int Atk;
    public int Def;
    public int Hp;
    public int Mp;
    public float critRate;
}
}

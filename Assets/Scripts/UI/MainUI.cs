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

    private int currentExp;
    private int maxExp;

    // Start is called before the first frame update
    void Start()
    {
        _jobText.text = GameManager.Player.Job.ToString();
        _userName.text = GameManager.Player.Name.ToString();
        _levelValue.text = GameManager.Player.Level.ToString();
        currentExp = GameManager.Player.Exp;
        maxExp = GameManager.Player.MaxExp;
        _ExpValue.text = $"{currentExp} / {maxExp}");
    }
}

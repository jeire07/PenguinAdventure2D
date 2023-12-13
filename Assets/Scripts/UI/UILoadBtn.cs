using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UILoadBtn : MonoBehaviour
{
    TextMeshProUGUI _textMeshPro;
    string _textValue;

    // Start is called before the first frame update
    void Start()
    {
        // find TextMeshPro component in button
        _textMeshPro = GetComponentInChildren<TextMeshProUGUI>();

        // get TextMeshPro value
        if (_textMeshPro != null)
        {
            _textValue = $"{_textMeshPro.text}UI";
            Debug.Log("Text Value: " + _textValue);
        }
        else
        {
            Debug.LogError("TextMeshPro component not found in children.");
        }
    }

    public void LoadUI()
    {
        GameObject uiGameObject = GameObject.FindGameObjectWithTag(_textValue);
        uiGameObject.SetActive(true);
    }
}

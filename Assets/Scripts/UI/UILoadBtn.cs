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
        // find parent GameObject
        Transform myTransform = gameObject.transform;
        Transform GrandParentTransform = (myTransform.parent).parent;
        Debug.Log("Text Value: " + GrandParentTransform.name);

        // enable GameObject clicked by user
        Debug.Log("Text Value: " + _textValue);
        GameObject uiGameObject = GrandParentTransform.Find(_textValue).gameObject;

        Debug.Log("Text Value: " + uiGameObject.name);
        uiGameObject.SetActive(true);

        // disable parent GameObject for disable current UI
        GameObject parentObject = (myTransform.parent).gameObject;
        parentObject.SetActive(false);
    }
}

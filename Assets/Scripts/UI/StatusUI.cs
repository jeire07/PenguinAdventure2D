using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatusUI : MonoBehaviour
{
    private void OnEnable()
    {
        SetActiveRecursively(gameObject, true);
    }

    private void OnDisable()
    {
        SetActiveRecursively(gameObject, false);
    }

    public void SetActiveRecursively(GameObject obj, bool active)
    {
        obj.SetActive(active);

        // Recursively call for all child objects of the current object
        foreach (Transform child in obj.transform)
        {
            SetActiveRecursively(child.gameObject, active);
        }
    }
}

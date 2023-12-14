using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StatusUI : MonoBehaviour
{
    [SerializeField] TMP_Text textname;
    [SerializeField] TMP_Text textname;

    // Start is called before the first frame update
    void Start()
    {
        textname.text = "";
    }
}

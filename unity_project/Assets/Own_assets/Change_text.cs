using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Change_text : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetString("status");
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<TMPro.TextMeshProUGUI>().text = PlayerPrefs.GetString("status");

        if (PlayerPrefs.GetInt("color") == 1){
            GetComponent<TMPro.TextMeshProUGUI>().color = Color.yellow;
        }
    }
}

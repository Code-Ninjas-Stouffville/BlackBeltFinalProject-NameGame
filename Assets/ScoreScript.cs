using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ScoreScript : MonoBehaviour
{ public TextMeshProUGUI MyscoreText;
 public int ScoreNum;
    // Start is called before the first frame update
    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text =""+ScoreNum;
    }

    // Update is called once per frame
    void Update()
    {
        MyscoreText.text =""+ScoreNum;
    }
}

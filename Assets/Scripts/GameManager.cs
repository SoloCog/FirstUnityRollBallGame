using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private int playerGold;
    [SerializeField] private TextMeshProUGUI playerGoldText;
    [SerializeField] private TextMeshProUGUI RoundTimerText;

    private float RoundTimer;

    public int PlayerGold{
        set{
            playerGold += value;
        }
        get{
            return playerGold;
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        playerGoldText.text = "Gold " + playerGold.ToString() + "/6";
        RoundTimerText.text = RoundTimer.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        RoundTimer = Time.time;
        
        playerGoldText.text = "Gold " + playerGold.ToString() + "/6";
        RoundTimerText.text = Mathf.FloorToInt(RoundTimer % 60 ).ToString() +"." + Mathf.FloorToInt((RoundTimer % 1) * 100).ToString(); 
    }
}

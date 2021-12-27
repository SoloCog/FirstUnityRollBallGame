using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    
    [SerializeField] private int playerGold;

    //Would like to create an array that will hold how much gold is needed for each level
    //Will want to do this so it can change this per level
    //Will also need to see about updating DoorLockedScript to get goldRequiredForLevel auto instead of hard coded

    [SerializeField] private int goldRequiredForLevel;
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
        playerGoldText.text = "Gold " + playerGold.ToString() + "/" + goldRequiredForLevel;
        RoundTimerText.text = RoundTimer.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        RoundTimer = Time.time;
        
        playerGoldText.text = "Gold " + playerGold.ToString() + "/" + goldRequiredForLevel;
        RoundTimerText.text = Mathf.FloorToInt(RoundTimer % 60 ).ToString() +"." + Mathf.FloorToInt((RoundTimer % 1) * 100).ToString(); 
    }
}

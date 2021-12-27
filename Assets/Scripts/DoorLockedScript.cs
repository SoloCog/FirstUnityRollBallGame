using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorLockedScript : MonoBehaviour
{
    [SerializeField] private int playerGoldTotal;
    private bool enoughGold = false;

    [SerializeField] private GameObject door;
    [SerializeField] private float speed;
    private Rigidbody doorRigidbody;

    private int goldRequiredForDoor = 6;

    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        doorRigidbody = door.GetComponent<Rigidbody>();
        playerGoldTotal = gameManager.PlayerGold;
    }

    // Update is called once per frame
    void Update()
    {
        playerGoldTotal = gameManager.PlayerGold;
        if(playerGoldTotal >= goldRequiredForDoor){
            if (door.transform.position.y <= 5){
                openDoor();
            }
            if (door.transform.position.y >= 5){
                doorRigidbody.constraints = RigidbodyConstraints.FreezePositionY;
            }
            
        }
    }

    void openDoor(){
        doorRigidbody.AddForce(Vector3.up * speed *Time.deltaTime, ForceMode.Acceleration);
    }
}

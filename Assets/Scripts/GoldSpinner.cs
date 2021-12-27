using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldSpinner : MonoBehaviour
{
    [SerializeField] float speedToSpinGoldPickup;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(1,1,1) * Time.deltaTime * speedToSpinGoldPickup);
    }
}

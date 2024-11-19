using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EnemyController : MonoBehaviour
{
    //Stores all enemy's parameters
    public int health;
    public int Index;
    //Text that is ahead
    public TMP_Text hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Changes the text above enemy's head
        hp.text = health.ToString();
    }
}

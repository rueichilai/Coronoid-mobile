using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{

    public static int Rounds;

    public static int GamesPlayed;

    public static int TimesDied;
    // Start is called before the first frame update
    void Start()
    {
        GamesPlayed = 0;
        Rounds = 0;
        TimesDied = 0;
    }

    // Update is called once per frame
    void Update()
    {
          
    }


}

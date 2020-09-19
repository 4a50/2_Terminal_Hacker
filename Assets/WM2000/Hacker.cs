using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ShowMainMenu();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowMainMenu()
    {
        string greeting = "Parker";        
        Terminal.ClearScreen();        
        Terminal.WriteLine("Hello " + greeting + ".  The Matrix has you.");
        Terminal.WriteLine("Think about your way out.\nEach selection becomes more difficult.");
        Terminal.WriteLine("However, the rewards increase as well.\nChoose the hack...");
        Terminal.WriteLine("\n1) Library Server\n2) Bank Server\n3) CIA Operations.");
        Terminal.WriteLine("Choose your destiny:");
    }    
}

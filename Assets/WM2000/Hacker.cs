using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game State
    public int level;
    enum Screen { MainMenu, Password, MasterKey, Win};
    Screen currentScreen;
    public string userName = "Amy";
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
                
        Terminal.ClearScreen();        
        Terminal.WriteLine("Hello " + userName + ".  The Matrix has you.");
        Terminal.WriteLine("Think about your way out.\nEach selection becomes more difficult.");
        Terminal.WriteLine("However, the rewards increase as well.\nChoose the hack...");
        Terminal.WriteLine("\n1) Library Server\n2) Bank Server\n3) CIA Operations.");
        Terminal.WriteLine("Choose your destiny:");
        currentScreen = Screen.MainMenu;

        
    }
    
    void OnUserInput(string userInput)
    {
        print(userInput);
        if (userInput == "menu")
        {
            ShowMainMenu();
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(userInput);
        }
    }

    void RunMainMenu(string userInput)
    {
        if (userInput == "1")
        {
            level = 1;
            StartGame();
        }
        else if (userInput == "2")
        {
            level = 2;
            StartGame();
        }
        else if (userInput == "3")
        {
            level = 3;
            StartGame();
        }
       
        else if (userInput == "4a50")
        {
            Terminal.WriteLine("Hello Mr. JP.  MASTERKEY=selected");
            currentScreen = Screen.MasterKey;
        }
        else
        {
            Terminal.WriteLine("Invalid Choice.  Don't test me.");
        }
    }

    void StartGame()
    {
        currentScreen = Screen.Password;
        Terminal.WriteLine("You have selected level " + level);
        Terminal.WriteLine("Enter your passcode: ");
    }    
}

    
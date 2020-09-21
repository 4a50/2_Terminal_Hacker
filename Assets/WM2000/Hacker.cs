using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //Game Config Data
    string[] level1PassCodes = { "Dictionary", "Book", "Borrow", "Dewey", "quiet" };
    string[] level2PassCodes = { "Gringotts", "Vaultec", "goldingot", "autoteller", "combinations"  };
    string[] level3PassCodes = { "MKUltraGrad", "Pickering", "Espionage", "SpyRing", "blackops" };

    //Game State
    public int level;
    enum Screen { MainMenu, Password, MasterKey, Win};
    Screen currentScreen;
    public string userName = "Amy";
    string passwords;
    
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
        Terminal.WriteLine("Return by 'menu'");
    }    
    void OnUserInput(string userInput)
    {
        print(userInput);
        if (userInput == "menu")
        {
            currentScreen = Screen.MainMenu;
            ShowMainMenu();
            
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(userInput);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(userInput);
        }
    }
     

    void RunMainMenu(string userInput)
    {
        bool isValidLevelNumber = (userInput == "1" || userInput == "2" || userInput == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(userInput);            
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
        Terminal.ClearScreen();
        setPassword();
        Terminal.WriteLine("This is what we have found.\nYou will have to decode");
        Terminal.WriteLine(passwords.Anagram().ToUpper());
        Terminal.WriteLine("Enter your passcode: ");

    }
    void setPassword()
    {
        switch (level)
        {
            case 1:
                passwords = level1PassCodes[Random.Range(0, level1PassCodes.Length)].ToUpper();
                break;
            case 2:
                passwords = level2PassCodes[Random.Range(0, level2PassCodes.Length)].ToUpper();
                break;
            case 3:
                passwords = level3PassCodes[Random.Range(0, level3PassCodes.Length)].ToUpper();
                break;
            default:
                Debug.LogError("Invalid Level Number Dude!!");
                break;
        }
    }

    void CheckPassword(string userInput)
    {
        if (passwords == userInput)
        {
            Win();
        }        
         else
        {
            Terminal.WriteLine("Not Correct! They are closing in!");
        }
    }
    void Win()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
        Terminal.WriteLine("type --> menu to return");
        //Temporarily sends you back to the menuScreen to keep a loop for testing.
        currentScreen = Screen.MainMenu;
}
    void ShowLevelReward()
    {
        Terminal.WriteLine("--> Password Acknowldeged.");
        switch (level)
        {
            case 1:
                Terminal.WriteLine("-> Low Level Access Granted");
                Terminal.WriteLine(userName + ", they know!");
                Terminal.WriteLine("!!-> We have you!");
                Terminal.WriteLine("-->Cutting the Hardline<--");
                break;
            case 2:
                Terminal.WriteLine("-> Mid Level Access Granted");
                Terminal.WriteLine(userName + ", this is going to be tight!");
                Terminal.WriteLine("!!->" + userName.ToUpper() + " located.  Tracing");
                break;
            case 3:
                Terminal.WriteLine("-> Admin Level Access Granted");
                Terminal.WriteLine("Good job " + userName + "!");
                Terminal.WriteLine("We are setting up the exit pipeline!");
                Terminal.WriteLine(@"
|--------|
|        |
|--    --|
  |    |
  |    |
  |    |
  |    |
");
                break;
            default:
                Debug.LogError("Well Something got messed up.  There should be an proper input");
                break;                
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour

 {

    public static PlayerLevel Instance;


    [Header("Tweak Variables")]
    public float perLevelBonusPercentage = 0.1f; //ten percent
    public int perLevelAttackRatingIncrease = 10;
    public int perLevelDefenceRatingIncrease = 10; //can be determined at any time per prefab

    [Header("In-Game Variables")] //shouldnt be tweaked
    public float damageBonusPercentage = 1.0f;  //to be added per levelup
    public int attackRating = 20;
    public int defenseRating = 20;
    public int currentLevel = 1;
    public int maxLevel = 70;
    public int XP = 0;


    public static void AddXP(int amount)
    {

        Instance.XP+= amount;
        while (Instance.XP > PlayerLevel.GetNextLevelXPRequirement())
        {
            LevelUp();
           
        }
        if (Instance.currentLevel > Instance.maxLevel)
        {
            Instance.currentLevel = Instance.maxLevel;
        }

    }

    public static void LevelUp() //level up muthafucker

    {
        Instance.currentLevel++;
        Instance.damageBonusPercentage += Instance.perLevelBonusPercentage;
        Instance.attackRating += Instance.perLevelAttackRatingIncrease;
        Instance.defenseRating += Instance.perLevelDefenceRatingIncrease;


    }

    public static int GetNextLevelXPRequirement()
    {
        int returnValue = 10 * Instance.currentLevel * Instance.currentLevel;
        return returnValue;



    }


    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {

            Destroy(gameObject);
            return;
        

        }
        DontDestroyOnLoad(gameObject);

    }



    // Use this for initialization
    void Start ()

    {


		
	}

    private void OnGUI()
    {
        GUILayout.Label("Level: " + currentLevel);
        GUILayout.Label("XP: " + XP);
        GUILayout.Label("Next Level at: " + GetNextLevelXPRequirement());
    }



    // Update is called once per frame
    void Update ()

    {
	

        
	}
}

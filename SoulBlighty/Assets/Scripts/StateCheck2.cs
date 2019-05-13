using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class StateCheck2 : MonoBehaviour
{

    Image invArmor;
    Image invWeapon;
    public GameObject invParentArmor;
    public GameObject invParentWeapon;
    private Animator animController;
    public RuntimeAnimatorController[] UnarmedArray;
    public RuntimeAnimatorController[] OnlyClothingArray;
    public RuntimeAnimatorController[] OnlyWeaponArray;
    public RuntimeAnimatorController[] NormalClothingArray;
    public RuntimeAnimatorController[] CivilianClothingArray;
    public RuntimeAnimatorController[] BlueCloakArray;
    public RuntimeAnimatorController[] GreenCloakArray;
    public RuntimeAnimatorController[] BlackCloakArray;
    public RuntimeAnimatorController[] BlueJacketArray;
    public RuntimeAnimatorController[] BrownArmorArray;
    public RuntimeAnimatorController[] BlueArmorArray;
    public RuntimeAnimatorController[] GreenArmorArray;
    public RuntimeAnimatorController[] RedArmorArray;
    public RuntimeAnimatorController[] YellowArmorArray;
    private void Start()
    {
        invArmor = invParentArmor.GetComponent<Image>();
        invWeapon = invParentWeapon.GetComponent<Image>();
        animController = GetComponent<Animator>();
    }

    public void UpdateInventory()
    {
        //CHECK FOR ONLY ARMOR EQUIPPED
        if (invArmor.isActiveAndEnabled && !invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_normalclothing")
            {
                Debug.Log("Normal Clothing equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[0];
            }

            if (invArmor.sprite.name == "item_civilianclothing")
            {
                Debug.Log("Civilian Clothing equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[1];
            }

            if (invArmor.sprite.name == "item_bluejacket")
            {
                Debug.Log("Blue Jacket equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[2];
            }

            if (invArmor.sprite.name == "item_bluecloak")
            {
                Debug.Log("Blue Cloak equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[3];
            }

            if (invArmor.sprite.name == "item_greencloak")
            {
                Debug.Log("Green Cloak equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[4];
            }

            if (invArmor.sprite.name == "item_blackcloak")
            {
                Debug.Log("Black Cloak equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[5];
            }

            if (invArmor.sprite.name == "item_brownarmor")
            {
                Debug.Log("Brown Armor equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[6];
            }

            if (invArmor.sprite.name == "item_greenarmor")
            {
                Debug.Log("Green Armor equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[7];
            }

            if (invArmor.sprite.name == "item_bluearmor")
            {
                Debug.Log("Blue Armor equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[8];
            }

            if (invArmor.sprite.name == "item_yellowarmor")
            {
                Debug.Log("Yellow Armor equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[9];
            }

            if (invArmor.sprite.name == "item_redarmor")
            {
                Debug.Log("Red Armor equipped");
                animController.runtimeAnimatorController = OnlyClothingArray[10];
            }
        }

        //CHECK FOR ONLY WEAPON EQUIPPED
        if (!invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[0];
            }

            if (invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[1];
            }

            if (invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[2];
            }

            if (invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[3];
            }

            if (invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[4];
            }

            if (invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[5];
            }

            if (invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[6];
            }

            if (invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[7];
            }

            if (invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[8];
            }

            if (invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[9];
            }

            if (invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[10];
            }

            if (invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[11];
            }

            if (invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[12];
            }

            if (invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[13];
            }

            if (invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[14];
            }

            if (invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[15];
            }

            if (invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[16];
            }

            if (invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[17];
            }

            if (invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[18];
            }

            if (invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[19];
            }

            if (invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[20];
            }

            if (invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[21];
            }

            if (invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[22];
            }

            if (invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[23];
            }

            if (invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[24];
            }

            if (invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[25];
            }

            if (invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[26];
            }

            if (invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[27];
            }

            if (invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[28];
            }

            if (invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[29];
            }

            if (invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[30];
            }

            if (invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[31];
            }

            if (invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[32];
            }

            if (invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[33];
            }

            if (invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[34];
            }

            if (invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[35];
            }

            if (invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[36];
            }

            if (invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = OnlyWeaponArray[37];
            }
        }

        //CHECK FOR NORMAL CLOTHING AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = NormalClothingArray[0];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = NormalClothingArray[1];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = NormalClothingArray[2];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = NormalClothingArray[3];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = NormalClothingArray[4];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = NormalClothingArray[5];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = NormalClothingArray[6];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = NormalClothingArray[7];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = NormalClothingArray[8];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = NormalClothingArray[9];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = NormalClothingArray[10];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = NormalClothingArray[11];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = NormalClothingArray[12];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = NormalClothingArray[13];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = NormalClothingArray[14];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = NormalClothingArray[15];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = NormalClothingArray[16];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = NormalClothingArray[17];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = NormalClothingArray[18];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = NormalClothingArray[19];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = NormalClothingArray[20];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = NormalClothingArray[21];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = NormalClothingArray[22];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = NormalClothingArray[23];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = NormalClothingArray[24];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = NormalClothingArray[25];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = NormalClothingArray[26];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = NormalClothingArray[27];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = NormalClothingArray[28];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = NormalClothingArray[29];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = NormalClothingArray[30];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = NormalClothingArray[31];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = NormalClothingArray[32];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = NormalClothingArray[33];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = NormalClothingArray[34];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = NormalClothingArray[35];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = NormalClothingArray[36];
            }

            if (invArmor.sprite.name == "item_normalclothing" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = NormalClothingArray[37];
            }
        }

        //CHECK FOR CIVILIAN CLOTHING AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[87];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[88];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[89];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[90];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[91];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[92];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[93];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[94];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[95];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[96];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[97];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[98];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[99];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[100];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[101];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[102];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[103];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[104];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[105];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[106];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[107];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[108];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[109];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[110];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[111];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[112];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[113];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[114];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[115];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[116];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[117];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[118];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[119];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[120];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[121];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[122];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[123];
            }

            if (invArmor.sprite.name == "item_civilianclothing" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = CivilianClothingArray[124];
            }
        }

        //CHECK FOR BLUE CLOAK AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = BlueCloakArray[163];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = BlueCloakArray[164];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueCloakArray[165];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = BlueCloakArray[166];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = BlueCloakArray[167];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = BlueCloakArray[168];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = BlueCloakArray[169];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueCloakArray[170];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = BlueCloakArray[171];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = BlueCloakArray[172];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = BlueCloakArray[173];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = BlueCloakArray[174];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueCloakArray[175];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = BlueCloakArray[176];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = BlueCloakArray[1777];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = BlueCloakArray[178];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = BlueCloakArray[179];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueCloakArray[180];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = BlueCloakArray[181];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = BlueCloakArray[182];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = BlueCloakArray[183];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = BlueCloakArray[184];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueCloakArray[185];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = BlueCloakArray[186];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = BlueCloakArray[187];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = BlueCloakArray[188];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = BlueCloakArray[189];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueCloakArray[190];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = BlueCloakArray[191];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = BlueCloakArray[192];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = BlueCloakArray[193];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = BlueCloakArray[194];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueCloakArray[195];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = BlueCloakArray[196];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = BlueCloakArray[197];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = BlueCloakArray[198];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = BlueCloakArray[199];
            }

            if (invArmor.sprite.name == "item_bluecloak" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = BlueCloakArray[200];
            }
        }

        //CHECK FOR GREEN CLOAK AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = GreenCloakArray[201];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = GreenCloakArray[202];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenCloakArray[203];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = GreenCloakArray[204];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = GreenCloakArray[205];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = GreenCloakArray[206];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = GreenCloakArray[207];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenCloakArray[208];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = GreenCloakArray[209];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = GreenCloakArray[210];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = GreenCloakArray[211];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = GreenCloakArray[212];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenCloakArray[213];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = GreenCloakArray[214];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = GreenCloakArray[215];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = GreenCloakArray[216];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = GreenCloakArray[217];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenCloakArray[218];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = GreenCloakArray[219];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = GreenCloakArray[220];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = GreenCloakArray[221];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = GreenCloakArray[222];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenCloakArray[223];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = GreenCloakArray[224];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = GreenCloakArray[225];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = GreenCloakArray[226];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = GreenCloakArray[227];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenCloakArray[228];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = GreenCloakArray[229];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = GreenCloakArray[230];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = GreenCloakArray[231];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = GreenCloakArray[232];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenCloakArray[233];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = GreenCloakArray[234];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = GreenCloakArray[235];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = GreenCloakArray[236];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = GreenCloakArray[237];
            }

            if (invArmor.sprite.name == "item_greencloak" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = GreenCloakArray[238];
            }
        }

        //CHECK FOR BLACK CLOAK AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = BlackCloakArray[0];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = BlackCloakArray[1];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = BlackCloakArray[2];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = BlackCloakArray[3];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = BlackCloakArray[4];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = BlackCloakArray[5];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = BlackCloakArray[6];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = BlackCloakArray[7];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = BlackCloakArray[8];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = BlackCloakArray[9];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = BlackCloakArray[10];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = BlackCloakArray[11];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = BlackCloakArray[12];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = BlackCloakArray[13];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = BlackCloakArray[14];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = BlackCloakArray[15];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = BlackCloakArray[16];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = BlackCloakArray[17];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = BlackCloakArray[18];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = BlackCloakArray[19];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = BlackCloakArray[20];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = BlackCloakArray[21];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = BlackCloakArray[22];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = BlackCloakArray[23];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = BlackCloakArray[24];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = BlackCloakArray[25];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = BlackCloakArray[26];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = BlackCloakArray[27];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = BlackCloakArray[28];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = BlackCloakArray[29];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = BlackCloakArray[30];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = BlackCloakArray[31];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = BlackCloakArray[32];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = BlackCloakArray[33];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = BlackCloakArray[34];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = BlackCloakArray[35];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = BlackCloakArray[36];
            }

            if (invArmor.sprite.name == "item_blackcloak" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = BlackCloakArray[37];
            }
        }

        //CHECK FOR BLUE JACKET AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = BlueJacketArray[125];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = BlueJacketArray[126];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueJacketArray[127];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = BlueJacketArray[128];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = BlueJacketArray[129];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = BlueJacketArray[130];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = BlueJacketArray[131];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueJacketArray[132];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = BlueJacketArray[133];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = BlueJacketArray[134];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = BlueJacketArray[135];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = BlueJacketArray[136];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueJacketArray[137];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = BlueJacketArray[138];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = BlueJacketArray[139];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = BlueJacketArray[140];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = BlueJacketArray[141];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueJacketArray[142];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = BlueJacketArray[143];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = BlueJacketArray[144];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = BlueJacketArray[145];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = BlueJacketArray[146];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueJacketArray[147];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = BlueJacketArray[148];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = BlueJacketArray[149];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = BlueJacketArray[150];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = BlueJacketArray[151];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueJacketArray[152];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = BlueJacketArray[153];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = BlueJacketArray[154];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = BlueJacketArray[155];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = BlueJacketArray[156];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueJacketArray[157];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = BlueJacketArray[158];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = BlueJacketArray[159];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = BlueJacketArray[160];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = BlueJacketArray[161];
            }

            if (invArmor.sprite.name == "item_bluejacket" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = BlueJacketArray[162];
            }
        }

        //CHECK FOR BROWN ARMOR AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = BrownArmorArray[277];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = BrownArmorArray[278];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = BrownArmorArray[279];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = BrownArmorArray[280];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = BrownArmorArray[281];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = BrownArmorArray[282];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = BrownArmorArray[283];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = BrownArmorArray[284];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = BrownArmorArray[285];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = BrownArmorArray[286];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = BrownArmorArray[287];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = BrownArmorArray[288];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = BrownArmorArray[289];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = BrownArmorArray[290];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = BrownArmorArray[291];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = BrownArmorArray[292];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = BrownArmorArray[293];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = BrownArmorArray[294];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = BrownArmorArray[295];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = BrownArmorArray[296];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = BrownArmorArray[297];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = BrownArmorArray[298];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = BrownArmorArray[299];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = BrownArmorArray[300];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = BrownArmorArray[301];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = BrownArmorArray[302];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = BrownArmorArray[303];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = BrownArmorArray[304];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = BrownArmorArray[305];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = BrownArmorArray[306];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = BrownArmorArray[307];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = BrownArmorArray[308];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = BrownArmorArray[309];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = BrownArmorArray[310];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = BrownArmorArray[311];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = BrownArmorArray[312];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = BrownArmorArray[313];
            }

            if (invArmor.sprite.name == "item_brownarmor" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = BrownArmorArray[314];
            }
        }

        //CHECK FOR BLUE ARMOR AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = BlueArmorArray[429];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = BlueArmorArray[430];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueArmorArray[431];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = BlueArmorArray[432];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = BlueArmorArray[433];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = BlueArmorArray[434];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = BlueArmorArray[435];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueArmorArray[436];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = BlueArmorArray[437];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = BlueArmorArray[438];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = BlueArmorArray[439];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = BlueArmorArray[440];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueArmorArray[441];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = BlueArmorArray[442];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = BlueArmorArray[443];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = BlueArmorArray[444];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = BlueArmorArray[445];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueArmorArray[446];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = BlueArmorArray[447];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = BlueArmorArray[448];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = BlueArmorArray[449];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = BlueArmorArray[450];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueArmorArray[451];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = BlueArmorArray[452];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = BlueArmorArray[453];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = BlueArmorArray[454];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = BlueArmorArray[455];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueArmorArray[456];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = BlueArmorArray[457];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = BlueArmorArray[458];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = BlueArmorArray[459];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = BlueArmorArray[460];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = BlueArmorArray[461];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = BlueArmorArray[462];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = BlueArmorArray[463];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = BlueArmorArray[464];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = BlueArmorArray[465];
            }

            if (invArmor.sprite.name == "item_bluearmor" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = BlueArmorArray[466];
            }
        }

        //CHECK FOR GREEN ARMOR AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = GreenArmorArray[315];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = GreenArmorArray[316];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenArmorArray[317];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = GreenArmorArray[318];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = GreenArmorArray[319];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = GreenArmorArray[320];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = GreenArmorArray[321];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenArmorArray[322];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = GreenArmorArray[323];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = GreenArmorArray[324];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = GreenArmorArray[325];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = GreenArmorArray[326];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenArmorArray[327];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = GreenArmorArray[328];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = GreenArmorArray[329];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = GreenArmorArray[330];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = GreenArmorArray[331];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenArmorArray[332];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = GreenArmorArray[333];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = GreenArmorArray[334];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = GreenArmorArray[335];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = GreenArmorArray[336];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenArmorArray[337];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = GreenArmorArray[338];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = GreenArmorArray[339];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = GreenArmorArray[340];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = GreenArmorArray[341];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenArmorArray[342];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = GreenArmorArray[343];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = GreenArmorArray[344];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = GreenArmorArray[345];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = GreenArmorArray[346];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = GreenArmorArray[347];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = GreenArmorArray[348];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = GreenArmorArray[349];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = GreenArmorArray[350];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = GreenArmorArray[351];
            }

            if (invArmor.sprite.name == "item_greenarmor" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = GreenArmorArray[352];
            }
        }

        //CHECK FOR RED ARMOR AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = RedArmorArray[353];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = RedArmorArray[354];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = RedArmorArray[355];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = RedArmorArray[356];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = RedArmorArray[357];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = RedArmorArray[358];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = RedArmorArray[359];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = RedArmorArray[360];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = RedArmorArray[361];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = RedArmorArray[362];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = RedArmorArray[363];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = RedArmorArray[364];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = RedArmorArray[365];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = RedArmorArray[366];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = RedArmorArray[367];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = RedArmorArray[368];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = RedArmorArray[369];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = RedArmorArray[370];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = RedArmorArray[371];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = RedArmorArray[372];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = RedArmorArray[373];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = RedArmorArray[374];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = RedArmorArray[375];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = RedArmorArray[376];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = RedArmorArray[377];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = RedArmorArray[378];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = RedArmorArray[379];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = RedArmorArray[380];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = RedArmorArray[381];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = RedArmorArray[382];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = RedArmorArray[383];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = RedArmorArray[384];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = RedArmorArray[385];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = RedArmorArray[386];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = RedArmorArray[387];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = RedArmorArray[388];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = RedArmorArray[389];
            }

            if (invArmor.sprite.name == "item_redarmor" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = RedArmorArray[390];
            }
        }

        //CHECK FOR YELLOW ARMOR AND WEAPON EQUIPPED
        if (invArmor.isActiveAndEnabled && invWeapon.isActiveAndEnabled)
        {
            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_woodsword")
            {
                Debug.Log("Wooden Longsword equipped");
                animController.runtimeAnimatorController = YellowArmorArray[391];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_woodspear")
            {
                Debug.Log("Wooden Spear equipped");
                animController.runtimeAnimatorController = YellowArmorArray[392];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_woodswordandshield")
            {
                Debug.Log("Wooden Sword and Shield equipped");
                animController.runtimeAnimatorController = YellowArmorArray[393];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_woodbow")
            {
                Debug.Log("Wooden Bow equipped");
                animController.runtimeAnimatorController = YellowArmorArray[394];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_wooddaggers")
            {
                Debug.Log("Wooden Daggers equipped");
                animController.runtimeAnimatorController = YellowArmorArray[395];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_ironsword")
            {
                Debug.Log("Iron Longsword equipped");
                animController.runtimeAnimatorController = YellowArmorArray[396];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_ironspear")
            {
                Debug.Log("Iron Spear equipped");
                animController.runtimeAnimatorController = YellowArmorArray[397];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_ironswordandshield")
            {
                Debug.Log("Iron Sword and Shield equipped");
                animController.runtimeAnimatorController = YellowArmorArray[398];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_ironbow")
            {
                Debug.Log("Iron Bow equipped");
                animController.runtimeAnimatorController = YellowArmorArray[399];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_irondaggers")
            {
                Debug.Log("Iron Daggers equipped");
                animController.runtimeAnimatorController = YellowArmorArray[400];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_goldsword")
            {
                Debug.Log("Gold Longsword equipped");
                animController.runtimeAnimatorController = YellowArmorArray[401];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_goldspear")
            {
                Debug.Log("Gold Spear equipped");
                animController.runtimeAnimatorController = YellowArmorArray[402];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_goldswordandshield")
            {
                Debug.Log("Gold Sword and Shield equipped");
                animController.runtimeAnimatorController = YellowArmorArray[403];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_goldbow")
            {
                Debug.Log("Gold Bow equipped");
                animController.runtimeAnimatorController = YellowArmorArray[404];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_golddaggers")
            {
                Debug.Log("Gold Daggers equipped");
                animController.runtimeAnimatorController = YellowArmorArray[405];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_redsword")
            {
                Debug.Log("Red Longsword equipped");
                animController.runtimeAnimatorController = YellowArmorArray[406];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_redspear")
            {
                Debug.Log("Red Spear equipped");
                animController.runtimeAnimatorController = YellowArmorArray[407];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_redswordandshield")
            {
                Debug.Log("Red Sword and Shield equipped");
                animController.runtimeAnimatorController = YellowArmorArray[408];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_redbow")
            {
                Debug.Log("Red Bow equipped");
                animController.runtimeAnimatorController = YellowArmorArray[409];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_reddaggers")
            {
                Debug.Log("Red Daggers equipped");
                animController.runtimeAnimatorController = YellowArmorArray[410];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_poisonsword")
            {
                Debug.Log("Poison Longsword equipped");
                animController.runtimeAnimatorController = YellowArmorArray[411];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_poisonspear")
            {
                Debug.Log("Poison Spear equipped");
                animController.runtimeAnimatorController = YellowArmorArray[412];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_poisonswordandshield")
            {
                Debug.Log("Poison Sword and Shield equipped");
                animController.runtimeAnimatorController = YellowArmorArray[413];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_poisonbow")
            {
                Debug.Log("Poison Bow equipped");
                animController.runtimeAnimatorController = YellowArmorArray[414];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_poisondaggers")
            {
                Debug.Log("Poison Daggers equipped");
                animController.runtimeAnimatorController = YellowArmorArray[415];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_icesword")
            {
                Debug.Log("Ice Longsword equipped");
                animController.runtimeAnimatorController = YellowArmorArray[416];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_icespear")
            {
                Debug.Log("Ice Spear equipped");
                animController.runtimeAnimatorController = YellowArmorArray[417];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_iceswordandshield")
            {
                Debug.Log("Ice Sword and Shield equipped");
                animController.runtimeAnimatorController = YellowArmorArray[418];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_icebow")
            {
                Debug.Log("Ice Bow equipped");
                animController.runtimeAnimatorController = YellowArmorArray[419];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_icedaggers")
            {
                Debug.Log("Ice Daggers equipped");
                animController.runtimeAnimatorController = YellowArmorArray[420];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_orangesword")
            {
                Debug.Log("Orange Longsword equipped");
                animController.runtimeAnimatorController = YellowArmorArray[421];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_orangespear")
            {
                Debug.Log("Orange Spear equipped");
                animController.runtimeAnimatorController = YellowArmorArray[422];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_orangeswordandshield")
            {
                Debug.Log("Orange Sword and Shield equipped");
                animController.runtimeAnimatorController = YellowArmorArray[423];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_orangebow")
            {
                Debug.Log("Orange Bow equipped");
                animController.runtimeAnimatorController = YellowArmorArray[424];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_orangedaggers")
            {
                Debug.Log("Orange Daggers equipped");
                animController.runtimeAnimatorController = YellowArmorArray[425];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_heavensword")
            {
                Debug.Log("Heaven Cleaver equipped");
                animController.runtimeAnimatorController = YellowArmorArray[426];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_hellsword")
            {
                Debug.Log("Hell Cleaver equipped");
                animController.runtimeAnimatorController = YellowArmorArray[427];
            }

            if (invArmor.sprite.name == "item_yellowarmor" && invWeapon.sprite.name == "item_torch")
            {
                Debug.Log("Torch equipped");
                animController.runtimeAnimatorController = YellowArmorArray[428];
            }
        }
    }
}
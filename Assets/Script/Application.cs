using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Application : MonoBehaviour
{
    List<Character> characters = new List<Character>();

    public class Character
    {
        public Sprite icon;
        public string name;
        public Race race;
        public Classe classe;
        public int strength;
        public int dexterity;
        public int constitution;
        public int intelligence;
        public int wisdom;
        public int charisma;
    
        public enum Classe { Bard, Fighter };
        public enum Race { Aarakocra, Aasimar, Bugbear, Centaur,
            Dragonborn, Dwarf, Elf, FeralTiefling, Firbolg,
            Genasi,Gith, Gnome, Goblin, Goliath, HalfElf, Halfling,
            HalfOrc, Hobgoblin, Human, Kenku, Kobold, Lizardfolk,
            Minotaur, Orc, Tabaxi, Tiefling, Tortle, Triton, YuanTiTPureblood };
    }

    public GameObject mainMenu;
    public GameObject characterSheet;
    public GameObject characterCreationPage1;
    public GameObject characterCreationPage2;
    public GameObject characterCreationPage3;
    public GameObject characterCreationPage4;
    public GameObject characterCreationPage5;
    public GameObject characterCreationPage6;
    public GameObject characterCreationPage7;


    public Sprite iconSprite;
    public Text nameText;
    public Text raceText;
    public Text classeText;
    public Text strengthText;
    public Text dexterityText;
    public Text constitutionText;
    public Text intelligenceText;
    public Text wisdomText;
    public Text charismaText;

    public Text nameTextInput;

    int currentOpenCharacter; 
    private void Start()
    {
        SetUpCharacter();
    }


    public void LoadCharacter(int index) //Open the character sheet with index list
    {
        currentOpenCharacter = index;
        //sprite = characters[index].icon;
        characterSheet.SetActive(true);
        nameText.text = characters[index].name;
        raceText.text = characters[index].race.ToString();
        classeText.text = characters[index].classe.ToString();
        strengthText.text = "Strength " + characters[index].strength.ToString();
        dexterityText.text = "Dexterity " + characters[index].dexterity.ToString();
        constitutionText.text = "Constitution " + characters[index].constitution.ToString();
        intelligenceText.text = "Intelligence " + characters[index].intelligence.ToString();
        wisdomText.text = "Wisdom " + characters[index].wisdom.ToString();
        charismaText.text = "Charisma " + characters[index].charisma.ToString();
    }

    public void CreateCharacter(int index)
    {
        Character newChar =new Character();
        characters.Add(newChar);
        //SetUpCharacter();
    }

    public void SetUpCharacter()
    {
        if (characters.Count == 0)
        {
            Character newChar = new Character();
            characters.Add(newChar);
            //hard coded for testing, need to be removed
            characters[0].name = "Argon";
            characters[0].race = Character.Race.Dragonborn;
            characters[0].classe = Character.Classe.Bard;
            characters[0].strength = 16;
            characters[0].dexterity = 13;
            characters[0].constitution = 10;
            characters[0].intelligence = 10;
            characters[0].wisdom = 10;
            characters[0].charisma = 15;
        }
        return;
    }

    //Aarakocra, Aasimar, Bugbear, Centaur,
    //Dragonborn, Dwarf, Elf, FeralTiefling, Firbolg,
    //Genasi,Gith, Gnome, Goblin, Goliath, HalfElf, Halfling,
    //HalfOrc, Hobgoblin, Human, Kenku, Kobold, Lizardfolk,
    //Minotaur, Orc, Tabaxi, Tiefling, Tortle, Triton, YuanTiTPureblood

    public Dropdown raceDropdown;
    public void SelectRace(int index)
    {
        switch(raceDropdown.value)
        {
            case 0:
                break;
            case 1:
                characters[currentOpenCharacter].race = Character.Race.Aarakocra;
                break;
            case 2:
                characters[currentOpenCharacter].race = Character.Race.Aasimar;
                break;
            case 3:
                characters[currentOpenCharacter].race = Character.Race.Bugbear;
                break;
            case 4:
                characters[currentOpenCharacter].race = Character.Race.Centaur;
                break;
            case 5:
                characters[currentOpenCharacter].race = Character.Race.Dragonborn;
                break;
            case 6:
                characters[currentOpenCharacter].race = Character.Race.Dwarf;
                break;
            case 7:
                characters[currentOpenCharacter].race = Character.Race.Elf;
                break;
            case 8:
                characters[currentOpenCharacter].race = Character.Race.FeralTiefling;
                break;
            case 9:
                characters[currentOpenCharacter].race = Character.Race.Firbolg;
                break;
            case 10:
                characters[currentOpenCharacter].race = Character.Race.Genasi;
                break;
            case 11:
                characters[currentOpenCharacter].race = Character.Race.Gith;
                break;
            case 12:
                characters[currentOpenCharacter].race = Character.Race.Gnome;
                break;
            case 13:
                characters[currentOpenCharacter].race = Character.Race.Goblin;
                break;
            case 14:
                characters[currentOpenCharacter].race = Character.Race.Goliath;
                break;
            case 15:
                characters[currentOpenCharacter].race = Character.Race.HalfElf;
                break;
            case 16:
                characters[currentOpenCharacter].race = Character.Race.Halfling;
                break;
            case 17:
                characters[currentOpenCharacter].race = Character.Race.HalfOrc;
                break;
            case 18:
                characters[currentOpenCharacter].race = Character.Race.Hobgoblin;
                break;
            case 19:
                characters[currentOpenCharacter].race = Character.Race.Human;
                break;
            case 20:
                characters[currentOpenCharacter].race = Character.Race.Kenku;
                break;
            case 21:
                characters[currentOpenCharacter].race = Character.Race.Kobold;
                break;
            case 22:
                characters[currentOpenCharacter].race = Character.Race.Lizardfolk;
                break;
            case 23:
                characters[currentOpenCharacter].race = Character.Race.Minotaur;
                break;
            case 24:
                characters[currentOpenCharacter].race = Character.Race.Orc;
                break;
            case 25:
                characters[currentOpenCharacter].race = Character.Race.Tabaxi;
                break;
            case 26:
                characters[currentOpenCharacter].race = Character.Race.Tiefling;
                break;
            case 27:
                characters[currentOpenCharacter].race = Character.Race.Tortle;
                break;
            case 28:
                characters[currentOpenCharacter].race = Character.Race.Triton;
                break;
            case 29:
                characters[currentOpenCharacter].race = Character.Race.YuanTiTPureblood;
                break;
        }
        //selectedRace.text = characters[index].ToString();
        //characters[index].race = Character.Race.raceSelected;
    }

}

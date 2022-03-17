using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchCharacters.Repository
{
public enum PowerType { Attack, Defense, Tank, Healer }
public enum Gender { Male, Female, Omnic }


    public class Character
    {
        public string CharacterName { get; set; }
        public PowerType TypeOfPower {get; set; }
        public int DifficultyLevel { get; set; }
        public Gender Gender { get; set; }
        public bool IsCool { get; set; }

        public Character(string characterName, PowerType typeOfPower, int difficultyLevel, Gender gender, bool isCool)
        {
            CharacterName = characterName;
            TypeOfPower = typeOfPower;
            DifficultyLevel = difficultyLevel;
            Gender = gender;
            IsCool = IsCool;
        } 

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OverwatchCharacters.Repository
{
    public class OverwatchRepository
    {
        List<Character> _characterList = new List<Character>();

        //CRUD METHODS

        //Create a character

        public void AddCharacterToList(Character character)
        {
            _characterList.Add(character);
        }

        //READ

        public List<Character> GetAllCharacters()
        {
            return _characterList;
        }

        // public List<Character> GetCharactersFromUserInput()

        public void SeedData()
        {
            Character dva = new Character("D.Va", PowerType.Tank, 2, Gender.Female, true);
            Character orisa = new Character("Orisa", PowerType.Tank, 2, Gender.Omnic, false);
            Character reinhardt = new Character("Reinhardt", PowerType.Tank, 1, Gender.Male, true);
            Character roadhog = new Character("Roadhog", PowerType.Tank, 1, Gender.Male, false);
            Character sigma = new Character("Sigma", PowerType.Tank, 3, Gender.Male, false);
            Character winston = new Character("Winston", PowerType.Tank, 2, Gender.Male, false);
            Character wreckingBall = new Character("Wrecking Ball", PowerType.Tank, 3, Gender.Male, false);
            Character zarya = new Character ("Zarya", PowerType.Tank, 3, Gender.Female, false);
            Character ashe = new Character ("Ashe", PowerType.Attack, 2, Gender.Female, true);
            Character bastion = new Character ("Bastion", PowerType.Defense, 1, Gender.Omnic, true);
            Character mccree = new Character ("McCree", PowerType.Attack, 2, Gender.Male, true);
            Character doomfist = new Character ("Doomfist", PowerType.Attack, 3, Gender.Male, false);
            Character echo = new Character ("Echo", PowerType.Attack, 2, Gender.Female, true);
            Character genji = new Character ("Genji", PowerType.Attack, 3, Gender.Male, false);
            Character hanzo = new Character ("Hanzo", PowerType.Attack, 3, Gender.Male, true);
            Character junkrat = new Character ("Junkrat", PowerType.Defense, 2, Gender.Male, false);
            Character mei = new Character ("Mei", PowerType.Defense, 3, Gender.Female, false);
            Character pharah = new Character ("Pharah", PowerType.Attack, 1, Gender.Female, false);
            Character reaper = new Character ("Reaper", PowerType.Attack, 1, Gender.Male, true);
            Character soldier76 = new Character("Solder: 76", PowerType.Attack, 1, Gender.Male, true);
            Character sombra = new Character ("Sombra", PowerType.Attack, 3, Gender.Male, false);
            Character symmetra = new Character ("Symmetra", PowerType.Defense, 2, Gender.Female, false);
            Character torbjorn = new Character ("Torbjorn", PowerType.Defense, 2, Gender.Male, false);
            Character tracer = new Character ("Tracer", PowerType.Attack, 2, Gender.Female, true);
            Character widowmaker = new Character ("Widowmaker", PowerType.Defense, 2, Gender.Female, true);
            Character ana = new Character ("Ana", PowerType.Healer, 3, Gender.Female, true);
            Character baptiste = new Character ("Baptiste", PowerType.Healer, 3, Gender.Male, true);
            Character brigitte = new Character ("Brigitte", PowerType.Healer, 1, Gender.Female, false);
            Character lucio = new Character ("Lucio", PowerType.Healer, 2, Gender.Male, true);
            Character mercy = new Character ("Mercy", PowerType.Healer, 1, Gender.Female, true);
            Character moira = new Character ("Moira", PowerType.Healer, 2, Gender.Female, true);
            Character zenyatta = new Character ("Zenyatta", PowerType.Healer, 3, Gender.Omnic, true);
            

        }
    }
}


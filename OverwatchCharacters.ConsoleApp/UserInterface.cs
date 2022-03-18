using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using OverwatchCharacters.Repository;

namespace OverwatchCharacters.ConsoleApp
{
    public class UserInterface
    {
        //bool that the entire UserInterface can see - think of scope.
        bool isRunning = true;

        OverwatchRepository _characterList = new OverwatchRepository();

        CustomConsole _console = new CustomConsole();

        //Run() method.
        public void Run(){
                _characterList.SeedData();

                while (isRunning)
                {
                    _console.PrintMainMenu();
                    _console.EnterSelection();
                    string input = GetUserInput();

                    UserInputSwitchCase(input);
                }
            }

            private string GetUserInput()
            {
                return Console.ReadLine();
            }

            private void UserInputSwitchCase(string input)
            {
                switch (input)
                {
                    case "1":
                    CreateACharacter();
                    break;
                    case "2":
                    ViewAllCharacters();
                    break;
                    case "3":
                    SearchCharacter();
                    break;
                    case "4":
                    ExitApplication();
                    break;
                    default:
                    break;
                }
            }

            private void CreateACharacter()
            {
                _console.EnterAName();
                string characterName = GetUserInput();
                _console.PrintPowerType();
                _console.EnterSelection();
                string powerTypeInput = GetUserInput();
                PowerType powerType = PowerType.Attack;

                switch (powerTypeInput)
                {
                    case "1":
                        powerType = PowerType.Attack;
                        break;
                    case "2":
                        powerType = PowerType.Defense;
                        break;
                    case "3":
                        powerType = PowerType.Tank;
                        break;
                    case "4":
                        powerType = PowerType.Healer;
                        break;
                    default:
                        break;
                }

                _console.PrintDifficultyLevel();
                int difficultyLevel = Convert.ToInt32(GetUserInput());

                _console.PrintGenders();
                string genderInput = GetUserInput();
                Gender gender = Gender.Female;

                switch (genderInput)
                {
                    case "1":
                        gender = Gender.Female;
                        break;
                    case "2":
                        gender = Gender.Male;
                        break;
                    case "3":
                        gender = Gender.Omnic;
                        break;
                    default:
                        break;
                }

                _console.IsCool();

                bool isCool = Convert.ToBoolean(GetUserInput());

                Character newCharacter = new Character(characterName, powerType, difficultyLevel, gender, isCool);

                _characterList.AddCharacterToList(newCharacter);
                _console.PressAnyKeyToContinue();
            }
            private void ViewAllCharacters()
            {
                List<Character> _listOfCharacters = _characterList.GetAllCharacters();
                
                foreach(Character character in _listOfCharacters)
                {
                    _console.PrintCharacter(character);
                }
                _console.PressAnyKeyToContinue();
            }
            private void SearchCharacter()
            {
                _console.EnterAName();
                string userInputCharacterSearch = GetUserInput();
                Character character = _characterList.GetCharacterFromListByName(userInputCharacterSearch);

                    _console.PrintCharacter(character);
                    _console.PressAnyKeyToContinue();
            }

            private void ExitApplication()
            {
                isRunning = false;
                _console.ExitApplicationMessage();
            }
            //New Method

            }
            public class CustomConsole
            {
                public void PrintMainMenu()
                {
                    Console.WriteLine("\n1. Add a Character.\n" +
                    "2. View all Characters. \n" +
                    "3. Search Characters. \n" + 
                    "4. EXIT.");
                }

                public void PrintCharacter(Character character)
                {
                    Console.WriteLine($"\n{character.CharacterName.ToUpper()} \nGender: {character.Gender} \nPower Type: {character.TypeOfPower} \nDifficulty Level: {character.DifficultyLevel}\n" +
                    $"This character is cool: {character.IsCool}");
                }

                public void EnterSelection()
                {
                    Console.Write("Enter Selection: ");
                }

                public void EnterAName()
                {
                    Console.Write("Name: ");
                }

                public void PrintPowerType()
                {
                    Console.WriteLine("What type of Character?\n" +
                    "1. Attack\n" +
                    "2. Defense\n" +
                    "3. Tank\n" +
                    "4. Healer");
                }

                public void PrintDifficultyLevel()
                {
                    Console.WriteLine("Insert Difficulty Level (1-3): ");
                }

                public void IsCool()
                {
                    Console.Write("Is the character cool? (true or false): ");
                }

                public void PrintGenders()
                {
                    Console.WriteLine("Character's Gender:\n" +
                    "1. Male\n" +
                    "2. Female\n" +
                    "3. Omnic (Robot)");
                }

                public void PressAnyKeyToContinue()
                {
                    Console.Write("\nPress any key to continue....");
                    Console.ReadKey();
                }

                public void ExitApplicationMessage()
                {
                Console.Write("Press any key to EXIT.");
                Console.ReadKey();
                }
        }
    }

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
                    // CreateACharacter();
                    break;
                    case "2":
                    ViewAllCharacters();
                    break;
                    case "3":
                    SearchCharacter();
                    break;
                    case "4":
                    // ExitApplication();
                    break;
                    default:
                    break;
                }
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
                    Console.WriteLine($"\n{character.CharacterName.ToUpper()} \nGender: {character.Gender} \nPower Type: {character.TypeOfPower} \n Difficulty Level: {character.DifficultyLevel}\n" +
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

                public void IsCool()
                {
                    Console.Write("Do you want the character to be cool? (Y/N): ");
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

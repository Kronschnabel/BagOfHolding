//BOHConsole.cs
//
//This is the parent control of the entire program. It's just a big RichTextBox inside a panel.
//This class processes the commands and prints feedback to the console. It also has the ability to
//open the Party and Charcter windows. The class's methods are broken up into the following regions.
//
//Open Window(s) methods: Handles the initialization of the Console itself and the creation of its subwindows.
//          startup()
//          creatCharLists()
//          createWindows()
//          openPartyWindow()
//          openCharWindow()
//
//Misc. Utility methods: These methods have a range of functionality for various uses throughout the class.
//          printLine()
//          printFile()
//          caretPosInvalid()
//          resetCaretPos()
//          getCurrentLine()
//          setCurrentLine()
//          isArrowKey()
//          getChar()
//
//Command Utility methods: These methods handle processing the commands that the user enters.
//          processCommand()
//          processDieCommand()
//          processHelpCommand()
//
//Print Statement methods: These methods are used when you need to print a lot of text
//          printOpeningStatement()
//          printHelpStatement()
//          printCharHelpStatement()
//          printPartyHelpStatement()
//          printInvHelpStatement()
//          printSpellbookHelpStatement()
//          printFilesHelpStatement()
//          printDieHelpStatement()
//                      
//Event Handlers: 
//          console_box_KeyDown()
//          console_box_DoubleClick()
//          
//////////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BagOfHolding
{
    public partial class BOHConsole : Form
    {
        Window party_win;
        PartyWindow party_control;
        Window character_win;
        CharacterWindow char_control;

        List<Character> party;
        List<Character> npcs;

        List<string> cmdHistory;
        int historyIndex;

        public BOHConsole() {
            startup();
            printOpeningStatement();
        }

        #region Open Window(s) methods

        private void startup() {
            InitializeComponent();
            Show();
            IsAccessible = true;
            BringToFront();

            cmdHistory = new List<string>();
            console_box.Size = Screen.PrimaryScreen.WorkingArea.Size;

            createCharLists();
            createWindows();
        }

        private void createCharLists() {
            party = new List<Character>();
            npcs = new List<Character>();
        }

        private void createWindows() {
            character_win = new Window("char");
            char_control = new CharacterWindow();
            character_win.addControl(char_control);
            Controls.Add(character_win);

            party_win = new Window("party");
            party_control = new PartyWindow();
            party_win.addControl(party_control);
            Controls.Add(party_win);
            party_control.setParty(ref party);
        }

        private void openPartyWindow() {
            party_win.open();
            party_control.open();
        }

        private void openCharWindow() {
            character_win.open();
            char_control.open();
        }
        #endregion

        #region Misc. Utility methods

        private void printLine(string line) {
            console_box.AppendText("\n" + line);
        }

        private void printFile(string path) {
            foreach(string line in System.IO.File.ReadAllLines(path)) {
                printLine(line);
            }
        }

        private bool caretPosInvalid() {
            if(console_box.SelectionStart < (console_box.TextLength - console_box.Lines[console_box.Lines.Length - 1].Length))
                return true;
            return false;
        }

        private void resetCaretPos() {
            console_box.SelectionStart = console_box.TextLength;
        }

        private string getCurrentLine() {
            return console_box.Lines[console_box.Lines.Length - 1];
        }

        private void setCurrentLine(string l) {
            List<string> textBox = console_box.Lines.ToList();
            textBox.RemoveAt(textBox.Count - 1);
            textBox.Add(l);
            console_box.Lines = textBox.ToArray();
            resetCaretPos();
        }

        private bool isArrowKey(Keys k) {
            if(k == Keys.Up || k == Keys.Down || k == Keys.Left || k == Keys.Right)
                return true;
            return false;
        }

        private Character getChar(string s) {
            s = s.ToLower();
            string[] splitName;

            foreach(Character c in party) {
                splitName = c.getName().ToLower().Split(' ');
                if(splitName.Contains(s))
                    return c;
            }

            return null;
        }
        #endregion

        #region Command utility methods

        private void processCommand(string line) {
            if(line != null && !line.Equals("")) { 

                string[] sLine = line.Split(' ');
                cmdHistory.Add(line);
                Character c = getChar(sLine[0]);

                if(cmdHistory.Count > 1)
                    historyIndex = cmdHistory.Count - 1;

                if(line.Equals("char")) {
                    openCharWindow();
                }
                else if(line.Equals("party")) {
                    openPartyWindow();
                }
                else if(sLine[0].Equals("help")) {
                    processHelpCommand(sLine);
                }
                else if(line.Equals("quit")) {
                    Dispose();
                }

                if(c != null) {
                    char_control.setChar(ref c);
                    openCharWindow();
                }
                else if(sLine[0][0] == 'd' || sLine[0][0] == 'D') {
                    processDieCommand(sLine);
                }
            }
        }

        private void processDieCommand(string[] sLine) {
            bool multiRoll = false;
            bool sum = false;
            int sides;
            int rollCount = 1;

            sLine[0] = sLine[0].Remove(0, 1);
            string[] diceString = sLine[0].Split('*');
            sides = int.Parse(diceString[0]);

            if(diceString.Length == 2)
                rollCount = int.Parse(diceString[1]);

            if(rollCount <= 1)
                rollCount = 1;
            else
                multiRoll = true;


            foreach(string s in sLine) {
                if(multiRoll)
                    if(s.Equals("sum") || s.Equals("s"))
                        sum = true;
            }

            Die d = new Die(2494);

            if(rollCount == 1) {
                printLine("\nD" + sides + " Roll: " + d.roll(sides));
            }
            else if(sum) {
                int total = 0;

                printLine("\nD" + sides + " x" + rollCount + ":");
                while(rollCount > 0) {
                    int roll = d.roll(sides);
                    total += roll;
                    printLine("           " + roll);
                    rollCount -= 1;
                }

                printLine("\nTotal: " + total);
            }
            else {
                printLine("\nD" + sides + " x" + rollCount + ":");
                while(rollCount > 0) {
                    printLine("          " + d.roll(sides));
                    rollCount -= 1;
                }
            }
        }

        private void processHelpCommand(string[] sLine) {
            printLine("\n");
            if(sLine.Length == 1) {
                printHelpStatement();
            }
            else if(sLine[1].Equals("char")) {
                printCharHelpStatement();
            }
            else if(sLine[1].Equals("party")) {
                printPartyHelpStatement();
            }
            else if(sLine[1].Equals("inv")) {
                printInvHelpStatement();
            }
            else if(sLine[1].Equals("spellbook")) {
                printSpellbookHelpStatement();
            }
            else if(sLine[1].Equals("files")) {
                printFilesHelpStatement();
            }
            else if(sLine[1][0] == 'd' || sLine[1][0] == 'D') {
                printDieHelpStatement();
            }

            printLine("\n");
        }
        #endregion

        #region Print statement methods

        private void printOpeningStatement() {
            printFile("BOHTitle.txt");
            printLine("\nBag of Holding Roleplaying console v1.0");
            printLine("Developed by Matt Kronschnabel");
            printLine("------------------------------------------");
            printLine("Enter 'help' if you don't know what to do.\n");
        }

        private void printHelpStatement() {
            printLine("This console can simluate dice rolls and open a variety of windows for storing your tabletop RPG information. ");
            printLine("It is intended to be a DM tool for preparing and accessing your campaign's data, prior to and during play. You can");
            printLine("keep it hidden for yourself, or make it visible to your players via TV or projector. This program is not meant to");
            printLine("eliminate the use of pen/paper and physical dice, but to improve the DM's ability to keep the game flowing.\n");
            printLine("For detailed information on any of the following commands, type 'help [command]'");
            printLine("----------------------------------------------------------------------------------");
            printLine("Enter 'd#' to simulate a #-sided die roll.");
            printLine("Enter 'party' to open up the Party Window.");
            printLine("Enter 'char' to open up the Character Window.");
            printLine("Enter 'quit' to close the program.");

        }

        private void printCharHelpStatement() {
            printLine("The Character Window gives detailed information about a single character. Initially,");
            printLine("it contains a new character, but will retain the last character loaded after closing.");
            printLine("This window can be accessed via the Party Window by double-clicking the character's name.");
            printLine("If a character is already loaded into the party, you can open his/her Character Window");
            printLine("from the console, by entering their name as a command.\n");
            printLine("     -Access your character's spellbook and inventory. For more info enter 'help inv' or 'help spellbook'\n");
            printLine("     -The Character Window is the only place you can edit a character's classes and skills.\n");
            printLine("     -Use 'Skills>Add Pathfinder Skills...' from the dropdowns to fill up the skill panel.\n");
            printLine("     -Change your character's image or border-color by double clicking either.\n");
            printLine("     -Saving a new character without a specified location will save to the default folder under 'CharName.char'\n");
            printLine("     -Character files can be edited like regular text files, just be careful as the syntax can be delicate.");
            printLine("     (For more information on .char files enter 'help files'.)");
        }

        private void printPartyHelpStatement() {
            printLine("The Party Window functions very similarly to the Character Window, but allows you to");
            printLine("access and edit multiple characters. It can only be accessed via the 'party' command.\n");
            printLine("     -Load characters using 'File>Load>Load Characters...'\n");
            printLine("     -Create a new character using 'File>New>New Character...'\n");
            printLine("     -Save the current state of your party using 'File>Save>Save Party...' (This will overwrite the files you loaded.)\n");
            printLine("     -Use the 'Edit' dropdown to clear the party, saving optional.\n");
            printLine("     -Double click a character's name to open their character window.");
        }

        private void printInvHelpStatement() {
            printLine("The Inventory Window lets you manage a single character's inventory.");
            printLine("It can be accessed by either the Party or Character Windows, and can hold");
            printLine("items of three different categories: Regular Items, Weapons, and Armor.\n");
            printLine("     -Use 'File>New>New Item...' to create a new item in whichever category is currently selected.\n");
            printLine("     -Double click the name of an item to change its text color.\n");
            printLine("     -Double click the background of an item to change its background color.\n");
            printLine("     -Items are saved as a line of text in a .char file. (For more information on item syntax enter 'help files'.)");
        }

        private void printSpellbookHelpStatement() {
            printLine("The Spellbook Window lets you manage a single character's spellbook.");
            printLine("It can be accessed by either the Party or Character Windows, and has");
            printLine("a counter for keeping track of spell slots\n");
            printLine("     -Use 'File>New>New Spell...' to create a new spell.\n");
            printLine("     -Double click the name of an spell to change its text color.\n");
            printLine("     -Double click the background of a spell to change its background color.\n");
            printLine("     -Spells are saved as a line of text in a .char file. (For more information on item syntax enter 'help files'.)");
        }

        private void printFilesHelpStatement() {
            printLine("I still need to write this.");
        }

        private void printDieHelpStatement() {
            printLine("Dice rolls can be done using the following syntax:\n");
            printLine("     'dX(*Y) (sum)'");
            printLine("     The sections in parentesis are optional.");
            printLine("     X is the number of sides the die should have.");
            printLine("     Y is the number of times it should be rolled.");
            printLine("     Including 'sum' or 's' after the statement will return the total of the rolls.\n");
            printLine("EXAMPLES:");
            printLine("     'd20' : Returns a number between [1-20]");
            printLine("     'D3*4' : Returns 4 numbers between [1-3]");
            printLine("     'D4500*5 s : Returns 5 numbers between [1-4500], as well as their sum.");
            printLine("     'd2*23 sum : Returns 23 numbers between [1-2], as well as their sum.");
        }
        #endregion

        #region Event Handlers

        private void console_box_KeyDown(object sender, KeyEventArgs e) {
            if(isArrowKey(e.KeyCode)) {
                if(caretPosInvalid()) {
                    e.SuppressKeyPress = true;
                    resetCaretPos();
                }
                else if(e.KeyCode == Keys.Up && historyIndex >= 0) {
                    e.SuppressKeyPress = true;
                    setCurrentLine(cmdHistory[historyIndex--]);
                }
                else if(e.KeyCode == Keys.Down && historyIndex < cmdHistory.Count - 1) {
                    e.SuppressKeyPress = true;
                    setCurrentLine(cmdHistory[historyIndex++]);
                }
            }
            else if(e.KeyCode == Keys.Enter) {
                string command = getCurrentLine();
                resetCaretPos();
                processCommand(command);
            }
            else if(e.KeyCode == Keys.Back && getCurrentLine().Length < 1) {
                e.SuppressKeyPress = true;
            }
            else if(caretPosInvalid()) {
                resetCaretPos();
            }
        }

        private void console_box_DoubleClick(object sender, EventArgs e) {
            BringToFront();
        }
        #endregion
    }
}

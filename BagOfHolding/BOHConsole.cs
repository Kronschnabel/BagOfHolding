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
//          getCharacter()
//
//Command Utility methods: These methods handle processing the commands that the user enters.
//          processInput()
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
using System.Threading;
using System.Windows.Forms;

namespace BagOfHolding
{
    public partial class BOHConsole : Form
    {
        Window party_win;
        PartyWindow party_control;
        Window character_win;
        CharacterWindow char_control;
        Window settings_win;
        SettingsWindow settings_control;

        List<Character> party;
        List<Character> npcs;

        List<string> cmdHistory;
        int historyIndex;

        Die d = new Die();

        public BOHConsole() {
            startup();
        }

        #region Start Up methods

        private void startup() {
            InitializeComponent();
            Show();
            IsAccessible = true;
            BringToFront();

            cmdHistory = new List<string>();
            console_box.Size = Screen.PrimaryScreen.WorkingArea.Size;

            Properties.Settings.Default.PropertyChanged += new PropertyChangedEventHandler(settingsChanged);

            setColors();
            createCharLists();
            createWindows();
            printOpeningStatement();
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

            settings_win = new Window("settings");
            settings_control = new SettingsWindow();
            settings_win.addControl(settings_control);
            Controls.Add(settings_win);
        }

        #endregion

        #region Open Window methods

        private void openPartyWindow() {
            party_win.open();
            party_control.open();
        }

        private void openCharWindow() {
            character_win.open();
            char_control.open();
        }

        private void openSettingsWindow() {
            settings_win.open();
            settings_control.open();
        }

        #endregion

        #region Misc. Utility methods

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

        private Character getCharacter(string s) {
            s = s.ToLower();
            string[] splitName;

            foreach(Character c in party) {
                splitName = c.getName().ToLower().Split(' ');
                if(splitName.Contains(s))
                    return c;
            }

            return null;
        }

        private List<Character> charsFromCmd(Command cmd) {
            List<Character> referencedChars = new List<Character>();

            foreach(string command in cmd.getSLine()) {
                Character testChar = getCharacter(command);
                if(testChar != null)
                    referencedChars.Add(getCharacter(command));
            }

            return referencedChars;
        }

        private void setColors() {
            Color bC = Properties.Settings.Default.consoleBackColor;
            Color fC = Properties.Settings.Default.consoleForeColor;

            BackColor = bC;
            console_box.BackColor = bC;
            console_box.ForeColor = fC;
        }

        #region Print to Console methods
        private void print(string text) {
            console_box.AppendText(text);
        }

        private void printLine(string line) {
            console_box.AppendText("\n" + line);
        }

        private void printFile(string path) {
            foreach(string line in System.IO.File.ReadAllLines(path)) {
                printLine(line);
            }
        }
        #endregion

        #endregion

        #region Command utility methods

        private void processInput(string line) {
            if(line != null && !line.Equals("")) {
                line = line.ToLower();
                Command cmd = new Command(line);
                cmdHistory.Add(line);
                printLine("=========================================================");

                if(cmdHistory.Count >= 1)
                    historyIndex = cmdHistory.Count;

                if(line.Equals("char")) {
                    openCharWindow();
                }
                else if(line.Equals("party")) {
                    openPartyWindow();
                }
                else if(line.Equals("init") || line.Equals("initiative")) {
                    processCommand(new Command("p d20 +init"));
                }
                else if(line.Equals("heal")) {
                    processCommand(new Command("p hp= +hpT"));
                }
                else if(cmd.getSLine()[0].Equals("help")) {
                    processHelpCommand(cmd);
                }
                else if(cmd.getSLine()[0].Equals("color")) {
                    openSettingsWindow();
                }
                else if(line.Equals("quit")) {
                    Dispose();
                }
                else {
                    processCommand(cmd);
                }
            }
        }

        private void processCommand(Command cmd) {
            List<Character> referencedChars;
            printLine("");

            if(cmd.getParty())
                referencedChars = party;
            else
                referencedChars = charsFromCmd(cmd);

            if(referencedChars.Count > 0) {
                foreach(Character c in referencedChars) {
                    if(cmd.getModded())
                        cmd.calcMod(c);

                    if(cmd.getDie()) {
                        processDieCommand(cmd, d, c);
                    }
                    else if(cmd.getVarEdit()) {
                        Character temp = c;
                        printLine(temp.getName() + ": ");
                        editCharStats(cmd, cmd.getMod(), ref temp);
                        printLine("");
                    }
                    else {
                        Character temp = c;
                        char_control.setChar(ref temp);
                        openCharWindow();
                    }
                }
            }
            else if(cmd.getDie()) {
                if(cmd.getModded())
                    cmd.calcMod();

                processDieCommand(cmd, d);
            }
            else {
                printLine("Command not recognized.");
            }

        }

        private void fillRollResults(Command cmd, Die d, ref List<int> rolls, ref int total) {
            int mod = cmd.getMod();

            if(cmd.getMultiRoll()) {
                for(int rollCount = 0; rollCount < cmd.getRollCount(); rollCount++) {
                    int roll = d.roll(cmd.getSides());
                    rolls.Add(roll);
                    total += roll;
                }

                if(cmd.getMultiMod())
                    total += (mod * cmd.getRollCount());
                else
                    total += mod;
            }
            else {
                int roll = d.roll(cmd.getSides());
                rolls.Add(roll);
                total += (roll + mod);
            }
        }

        private void editCharStats(Command cmd, int total, ref Character referencedChar) {
            char op = cmd.getVar()[cmd.getVar().Length - 1];
            string var = cmd.getVar().Remove(cmd.getVar().Length - 1);
            int preEdit = 0;
            int postEdit = 0;

            referencedChar.statEditFromCommand(var, op, total, ref preEdit, ref postEdit);

            string composite = "    [{0} was: {1, -5} is now: {2, -5}]";
            print(string.Format(composite, var, preEdit, postEdit));
        }

        private void processDieCommand(Command cmd, Die d) {
            List<int> rolls = new List<int>();
            int total = 0;
            int mod = cmd.getMod();

            fillRollResults(cmd, d, ref rolls, ref total);
            printDieResults(cmd, rolls, total);
        }

        private void processDieCommand(Command cmd, Die d, Character c) {
            List<int> rolls = new List<int>();
            int total = 0;
            int mod = cmd.getMod();

            fillRollResults(cmd, d, ref rolls, ref total);
            printLine(c.getName() + "'s roll results: ");

            if(cmd.getVarEdit()) 
                editCharStats(cmd, total, ref c);

            printDieResults(cmd, rolls, total);
        }

        private void processHelpCommand(Command cmd) {
            printLine("\n");
            if(cmd.getSLine().Length == 1) {
                printHelpStatement();
            }
            else if(cmd.getSLine()[1].Equals("char")) {
                printCharHelpStatement();
            }
            else if(cmd.getSLine()[1].Equals("party")) {
                printPartyHelpStatement();
            }
            else if(cmd.getSLine()[1].Equals("inv")) {
                printInvHelpStatement();
            }
            else if(cmd.getSLine()[1].Equals("spellbook")) {
                printSpellbookHelpStatement();
            }
            else if(cmd.getSLine()[1].Equals("files")) {
                printFilesHelpStatement();
            }
            else if(cmd.getSLine()[1].Equals("e") || cmd.getSLine()[1].Contains("example")) {
                printFile("commandexamples.txt");
            }
            else {
                printFile("commandinfo.txt");
                printFile("commandexamples.txt");

                if(cmd.getVarEdit())
                    printFile("editstathelp.txt");

                if(cmd.getModded())
                    printFile("modhelp.txt");  
            }

            printLine("\n");
        }

        #endregion

        #region Print statement methods

        private void printDieResults(Command cmd, List<int> rolls, int total) {
            string composite;
            int moddedRoll;

            printLine(cmd.getRollCount() + " D" + cmd.getSides() + " Roll(s):");

            if((cmd.getModded() && !cmd.getSum()) || (cmd.getMultiMod() && cmd.getSum())) {
                print("                 Mod {" + cmd.getMod() + "}:\n");
                composite = "                 {0, -25}{1, 0}";
            }
            else {
                printLine("");
                composite = "                 {0, -25}";
            }

            foreach(int r in rolls) {
                if(cmd.getMultiMod() || (cmd.getModded() && !cmd.getSum()))
                    moddedRoll = r + cmd.getMod();
                else
                    moddedRoll = r;

                if(r == 1)
                    print(string.Format(composite, "**" + r + "**", moddedRoll));
                else if(r == cmd.getSides())
                    print(string.Format(composite, "!!" + r + "!!", moddedRoll));
                else
                    print(string.Format(composite, r, moddedRoll));

                if(rolls.Count > 1)
                    printLine("");
            }

            if(cmd.getSum()) {
                if(cmd.getMultiMod())
                    printLine("\nTotal: " + (total - (cmd.getMod() * cmd.getRollCount())) + " (+" + cmd.getMod() + ")* = " + total);
                else
                    printLine("\nTotal: " + (total - cmd.getMod()) + " (+" + cmd.getMod() + ") = " + total);
            }
            printLine("");
        }

        private void printOpeningStatement() {
            printFile("BOHTitle.txt");
            printLine("\nBag of Holding Roleplaying console v1.2 Beta");
            printLine("Enter 'help' if you don't know what to do.");
            printLine("-----------------------------------------------\n");
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
            printLine("Enter 'color' to change your color settings.");
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

        private void settingsChanged(object sender, PropertyChangedEventArgs e) {
            setColors();
        }

        private void console_box_KeyDown(object sender, KeyEventArgs e) {
            if(isArrowKey(e.KeyCode)) {
                if(caretPosInvalid()) {
                    e.SuppressKeyPress = true;
                    resetCaretPos();
                }
                else if(e.KeyCode == Keys.Up && historyIndex >= 0) {
                    e.SuppressKeyPress = true;

                    if(cmdHistory.Count > 0) {
                        if(historyIndex > 0)
                            historyIndex -= 1;

                        setCurrentLine(cmdHistory[historyIndex]);
                    }
                }
                else if(e.KeyCode == Keys.Down) {
                    e.SuppressKeyPress = true;

                    if(historyIndex < cmdHistory.Count) {
                        historyIndex += 1;

                        if(historyIndex == cmdHistory.Count)
                            setCurrentLine("");
                        else
                            setCurrentLine(cmdHistory[historyIndex]);
                    }
                }
            }
            else if(e.KeyCode == Keys.Enter) {
                string command = getCurrentLine();
                resetCaretPos();
                processInput(command);
            }
            else if(e.KeyCode == Keys.Back && getCurrentLine().Length < 1) {
                e.SuppressKeyPress = true;
            }
            else if(caretPosInvalid()) {
                resetCaretPos();
            }
        }

        private void console_box_DoubleClick(object sender, EventArgs e) {
            foreach(Control c in Controls) {
                Console.WriteLine(c.Name);
                if(c.Name.Equals("Window"))
                    c.Visible = false;
            }
        }

        #endregion
    }
}

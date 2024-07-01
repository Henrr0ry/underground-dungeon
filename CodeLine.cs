using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Underground_Dungeon
{
    public partial class CodeLine : Form
    {
        public CodeLine()
        {
            InitializeComponent();
        }
        bool codeTrue = false;
        string playerName = "player";

        private void CodeLine_Load(object sender, EventArgs e)
        {
            if (MainSetting.Default.SavingUser == 1)
                playerName = UserSaveSlot.Default.UserName1;
            if (MainSetting.Default.SavingUser == 2)
                playerName = UserSaveSlot.Default.UserName2;
            if (MainSetting.Default.SavingUser == 3)
                playerName = UserSaveSlot.Default.UserName3;
        }

        private void CodeLineAdd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CodelineHistory.SelectionStart = CodelineHistory.Text.Length;
                CodelineHistory.ScrollToCaret();
                CodelineHistory.SelectionColor = Color.Blue;
                CodelineHistory.SelectedText += Environment.NewLine +"<" + playerName + "> " + CodeLineAdd.Text;
                CodelineHistory.SelectionColor = Color.Green;
                if (CodeLineAdd.Text == "list")
                {
                    codeTrue = true;
                    CodelineHistory.SelectedText += Environment.NewLine + "-----------------------";
                    CodelineHistory.SelectedText += Environment.NewLine + "Commands List";
                    CodelineHistory.SelectedText += Environment.NewLine + "-----------------------";
                    CodelineHistory.SelectedText += Environment.NewLine + "LIST       - view all commands";
                    CodelineHistory.SelectedText += Environment.NewLine + "EXIT       - hide command prompt";
                    CodelineHistory.SelectedText += Environment.NewLine + "GAMEEXIT   - close application";
                    CodelineHistory.SelectedText += Environment.NewLine + "GOD        - set infinity heal";
                    CodelineHistory.SelectedText += Environment.NewLine + "HEAL       - add + 100 heal";
                    CodelineHistory.SelectedText += Environment.NewLine + "SAVECHEAT  - save cheat to again";
                    CodelineHistory.SelectedText += Environment.NewLine + "             load (F9)";
                    CodelineHistory.SelectedText += Environment.NewLine + "CLEAR      - clear saved cheats";
                    CodelineHistory.SelectedText += Environment.NewLine + "COIN       - set infinity coins";
                    CodelineHistory.SelectedText += Environment.NewLine + "SLAYER     - set 500 damage";
                    CodelineHistory.SelectedText += Environment.NewLine + "CMD OFF    - set off command propt";
                    CodelineHistory.SelectedText += Environment.NewLine + "-----------------------";
                }
                if (CodeLineAdd.Text == "gameexit")
                {
                    codeTrue = true;
                    Application.Exit();
                }
                if (CodeLineAdd.Text == "cmd off")
                {
                    codeTrue = true;
                    CodelineHistory.SelectionColor = Color.Red;
                    CodelineHistory.SelectedText += Environment.NewLine + "------------------------------";
                    CodelineHistory.SelectedText += Environment.NewLine + "---=COMMAND PROMPT SET OFF=---";
                    CodelineHistory.SelectedText += Environment.NewLine + "------------------------------";
                    MainSetting.Default.CMDonline = false;
                }
                if (CodeLineAdd.Text == "god")
                {
                    codeTrue = true;
                    SettingsCodeLine.Default.Heal = 99999999;
                    CodelineHistory.SelectedText += Environment.NewLine + "ACTIVATE GOD CHEAT";
                    CodelineHistory.SelectedText += Environment.NewLine + "player have infinity heal";
                }
                if (CodeLineAdd.Text == "heal")
                {
                    codeTrue = true;
                    SettingsCodeLine.Default.Heal += 100;
                    CodelineHistory.SelectedText += Environment.NewLine + "ACTIVATE HEAL CHEAT";
                    CodelineHistory.SelectedText += Environment.NewLine + "player have +100 heal";
                }
                if (CodeLineAdd.Text == "savecheat")
                {
                    codeTrue = true;
                    SettingsCodeLine.Default.Save();
                    CodelineHistory.SelectedText += Environment.NewLine + "CHEATS ARE BE SAVE;";
                    CodelineHistory.SelectedText += Environment.NewLine + "your progres have been load (F9)";
                }
                if (CodeLineAdd.Text == "coin")
                {
                    codeTrue = true;
                    SettingsCodeLine.Default.Coin = 99999999;
                    CodelineHistory.SelectedText += Environment.NewLine + "ACTIVATE COIN CHEAT";
                    CodelineHistory.SelectedText += Environment.NewLine + "player have infinity coins";
                }
                if (CodeLineAdd.Text == "clear")
                {
                    CodelineHistory.SelectionColor = Color.Red;
                    codeTrue = true;
                    SettingsCodeLine.Default.Coin = 0;
                    SettingsCodeLine.Default.Heal = 0;
                    SettingsCodeLine.Default.Damage = 0;
                    SettingsCodeLine.Default.Save();
                    CodelineHistory.SelectedText += Environment.NewLine + "CLEARED SAVE CHEATS";
                    CodelineHistory.SelectedText += Environment.NewLine + "your cheat save was clear(F9)";
                }
                if (CodeLineAdd.Text == "slayer")
                {
                    codeTrue = true;
                    SettingsCodeLine.Default.Damage = 500;
                    SettingsCodeLine.Default.Save();
                    CodelineHistory.SelectedText += Environment.NewLine + "ACTIVATE SLAYER CHEAT";
                    CodelineHistory.SelectedText += Environment.NewLine + "player have 500 damage";
                }
                if (!codeTrue)
                {
                    CodelineHistory.SelectionColor = Color.Red;
                    CodelineHistory.SelectedText += Environment.NewLine + "SYNTAX ERROR: " + CodeLineAdd.Text;
                }
                if (CodeLineAdd.Text == "exit")
                {
                    codeTrue = true;
                    this.Close();
                    return;
                }
                codeTrue = false;
                CodeLineAdd.Text = null;
                CodelineHistory.SelectionStart = CodelineHistory.Text.Length;
                CodelineHistory.ScrollToCaret();
            }
        }

    }
}

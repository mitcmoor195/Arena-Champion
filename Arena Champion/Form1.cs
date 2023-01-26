using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arena_Champion
{
    public partial class Form1 : Form
    {
        //Arena Champion
        //A quick arena fighting game
        //Mitchell Moore
        //Jan 24 2023


        Rectangle arenaEntrance = new Rectangle(240, 0, 55, 76);

        Rectangle player = new Rectangle(410, 500, 43, 65);

        List <int> playerparty = new List<int>();
        List<int> opponentparty = new List<int>();

        List <double> playerHealth = new List<double>();
        List<double> opponentHealth = new List<double>();

        //To calculate health in percentage
        List<double> playerHealthTotal = new List<double>();
        List<double> opponentHealthTotal = new List<double>();

        List<double> opponentDefense = new List<double>();
        List<double> playerDefense = new List<double>();

        List<double> playerAttack = new List<double>();
        List<double> opponentAttack = new List<double>();

        List<double> playerBattleSpeed = new List<double>();
        List<double> opponentSpeed = new List<double>();

        int playerSpeed = 5;
        string characterName;
        string opponentName;

        int battleCount = 0;
        double playerdamageDeal;
        double opponentdamageDeal;

        bool aDown = false;
        bool dDown = false;
        bool sDown = false;
        bool wDown = false;
        bool eDown = false;
        bool rDown = false;
        bool tDown = false;
        bool oneDown = false;
        bool twoDown = false;
        bool threeDown = false;
        bool escDown = false;
        bool spaceDown = false;

        Brush blackbrush = new SolidBrush(Color.Black);
        Brush redbrush = new SolidBrush(Color.Crimson);


        string gameScreen = "start";

        string battleChoice = "";

        Stopwatch delay = new Stopwatch();

        Random random = new Random();

        int attacknumber = 0;
        int opponentAttackchoice;

        double playerhealthPercentage = 1;
        double opponenthealthPercentage = 1;

        double holdingVariable;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.D1:
                    oneDown = false;
                    break;
                case Keys.E:
                    eDown = false;
                    break;
                case Keys.R:
                    rDown = false;
                    break;
                case Keys.T:
                    tDown = false;
                    break;
                case Keys.Escape:
                    escDown = false;
                    break;
                case Keys.Space:
                    spaceDown = false;
                    break;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.D1:
                    oneDown = true;
                    break;
                case Keys.E:
                    eDown = true;
                    break;
                case Keys.R:
                    rDown = true;
                    break;
                case Keys.T:
                    tDown = true;
                    break;
                case Keys.Escape:
                    escDown = true;
                    break;
                case Keys.Space:
                    spaceDown = true;
                    break;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }



        private void character1Button_Click(object sender, EventArgs e)
        {
            //add character values for character 1
            gameScreen = "overworld";
            playerparty.Add(1);

            playerHealth.Add(150);
            playerHealthTotal.Add(150);
            playerAttack.Add(10);
            playerDefense.Add(38);
            playerBattleSpeed.Add(50);

            characterName = "Tibald";
        }

        private void character2Button_Click(object sender, EventArgs e)
        {
            //add character values for character 2
            gameScreen = "overworld";
            playerparty.Add(2);

            playerHealth.Add(100);
            playerHealthTotal.Add(100);
            playerAttack.Add(35);
            playerDefense.Add(14);
            playerBattleSpeed.Add(80);

            characterName = "Natalia";
        }

        private void character3Button_Click(object sender, EventArgs e)
        {
            //add character values for character 3
            gameScreen = "overworld";
            playerparty.Add(3);

            playerHealth.Add(90);
            playerHealthTotal.Add(90);
            playerAttack.Add(20);
            playerDefense.Add(22);
            playerBattleSpeed.Add(100);

            characterName = "Vedori";
        }


        //this empty stuff breaks the code if removed, so that's why its here


       private void itemButton_Click(object sender, EventArgs e)
        {
            if (battleChoice == "attack")
            {

            }
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            
        }

        private void changepartyButton_Click(object sender, EventArgs e)
        {
            if (battleChoice == "attack")
            {

            }
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
          
     
        
        }



        private void gameTick2_Tick(object sender, EventArgs e)
        {
        }

        private void gameTick_Tick(object sender, EventArgs e)
        {
            //start game and move to character select screen if space is pressed on start screen
            if (gameScreen == "start")
            {
                if(spaceDown == true)
                {
                    gameScreen = "characterselect";
                }
            }
               
            
            //move player in overworld
                if(gameScreen == "overworld")
            {

                if (aDown == true && player.X > 0)
                {
                    player.X -= playerSpeed;
                }

                if (dDown == true && player.X < this.Width - player.Width)
                {
                    player.X += playerSpeed;
                }

                if (sDown == true && player.Y < this.Height - 26)
                {
                    player.Y += playerSpeed;
                }

                if (wDown == true && player.Y > 0)
                {
                    player.Y -= playerSpeed;
                }
            }

            // enter battle arena
            if (player.IntersectsWith(arenaEntrance))
            {
                gameScreen = "arenabattle";

                battleChoice = "";


                //clear stats from last battle
                opponentHealth.Clear();
                opponentparty.Clear();
                opponentDefense.Clear();
                opponentAttack.Clear();
                opponentSpeed.Clear();

                //assign enemy values based on how many wins player has
                switch (battleCount)
                {

                    case 0:
                        holdingVariable = random.Next(50, 111);

                        opponentHealth.Add(holdingVariable);
                        opponentHealth.Add(holdingVariable);
                        opponentDefense.Add(random.Next(14, 20));
                        opponentAttack.Add(random.Next(10, 20));
                        opponentSpeed.Add(random.Next(30, 55));
                        opponentparty.Add(1);
                       break;
                    case 1:
                        holdingVariable = random.Next(90, 151);

                        opponentHealth.Add(holdingVariable);
                        opponentHealth.Add(holdingVariable);
                        opponentDefense.Add(random.Next(14, 20));
                        opponentAttack.Add(random.Next(15, 20));
                        opponentSpeed.Add(random.Next(70, 150 ));
                        opponentparty.Add(2);
                        break;
                    case 2:
                        holdingVariable = random.Next(100, 176);

                        opponentHealth.Add(holdingVariable);
                        opponentHealth.Add(holdingVariable);
                        opponentDefense.Add(random.Next(10, 17));
                        opponentAttack.Add(random.Next(18, 29));
                        opponentSpeed.Add(random.Next(60, 99));
                        opponentparty.Add(4);
                        break;
                    case 3:
                        holdingVariable = random.Next(150, 161);

                        opponentHealth.Add(holdingVariable);
                        opponentHealth.Add(holdingVariable);
                        opponentDefense.Add(random.Next(19, 26));
                        opponentAttack.Add(random.Next(10, 20));
                        opponentSpeed.Add(random.Next(60, 87));
                        opponentparty.Add(3);
                        break;
                    case 4:
                        holdingVariable = random.Next(190, 201);

                        opponentHealth.Add(holdingVariable);
                        opponentHealth.Add(holdingVariable);
                        opponentDefense.Add(random.Next(27, 35));
                        opponentAttack.Add(29);
                        opponentSpeed.Add(random.Next(30, 105));
                        opponentparty.Add(5);
                        break;



                }


            // ensure health shows up correctly
                playerhealthPercentage = (playerHealth[0] / playerHealthTotal[0]);
                opponenthealthPercentage = (opponentHealth[0] / holdingVariable);

                // mover player rectangle in overworld so it doesn't constantly collide with the arena entrance
                player = new Rectangle(410, 500, 43, 65);

            }

                // do things in battle
                if (gameScreen == "arenabattle")
                {
                
                    if(oneDown == true)
                    {
                    battleChoice = "attack";
                    }


                }
                /*if (twoDown == true && gameScreen == "arenabattle" && battleChoice == "")
                {
                    battleChoice = "item";
                }
                if (threeDown == true && gameScreen == "arenabattle" && battleChoice == "")
                {
                    battleChoice = "change";
                }*/



                //do attacks after choosing attacks
                playerAttackAction();

                //make opponents do damage
                opponentAttackAction();

                //change health numbers
                healthChanges();

                //end turn
                turnEnd();





            //leave battle when completed
            //also check if player has required amount of wins to finish game
                if (battleChoice == "done" && escDown == true)
            {
                if(battleCount == 5)
                {
                    gameScreen = "end";

                    finishBackground.Visible = true;
                    congratulationsLabel.Visible = true;
                    congratulationsLabel.Text = "Congratulations!";
                    championLabel.Visible = true;
                    championLabel.Text = "You have become the arena champion";
                    exitLabel.Visible = true;
                    exitLabel.Text = "Press e to exit";
                }
                else if(battleCount < 5)
                {

                gameScreen = "overworld";

                    playerRestore();
                }

                }

               // change player and opponent character images to correct images in battle
            if(gameScreen == "arenabattle")
            {
                switch (playerparty[0])
                {
                    case 1:

                        playerCharacter.Image = Properties.Resources.Defend;
                        break;
                    case 2:
                        playerCharacter.Image = Properties.Resources.ranger_idle;
                        break;
                    case 3:
                        playerCharacter.Image = Properties.Resources.rogue_idle;
                        break;
                }
                switch (opponentparty[0])
                {
                    case 1:
                        opponentCharacter.Image = Properties.Resources.Enemy_1;
                        opponentName = "Asshin, of the Sand";
                        break;
                    case 2:
                        opponentCharacter.Image = Properties.Resources.enemy_2;
                        opponentName = "Bankei, of the Mountains";
                        break;
                    case 3:
                        opponentCharacter.Image = Properties.Resources.Enemy_3;
                        opponentName = "Gualtier, the Honourable";
                        break;
                    case 4:
                        opponentCharacter.Image = Properties.Resources.Enemy_4;
                        opponentName = "Kanlas, the Twisted Elf";
                        break;
                    case 5:
                        opponentCharacter.Image = Properties.Resources.Enemy_5;
                        opponentName = "The King";
                        break;
                }

            }

            // paint overworld background
            if(gameScreen == "overworld")
            {
                this.BackgroundImage = Properties.Resources.pixel_path_real;

            }
            else if(gameScreen == "arenabattle")
            {
                this.BackgroundImage = Properties.Resources.Arena_Back;
            }
            else
            {
                this.BackgroundImage = null;
                this.BackColor = Color.Black;
            }

            //if e is pressed at end of game exit game
            if(gameScreen == "end")
            {
                if(eDown == true)
                {
                    Application.Exit();
                }
            }
            Refresh();
        }

        //ensure proper labels are visible in proper screens
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            if(gameScreen == "start")
            {
                playerchoiceBackground.Visible = false;
                choosecharacterLabel.Visible = false;
                character1Background.Visible = false;
                character2Background.Visible = false;
                character3Background.Visible = false;
                character1Button.Visible = false;
                character2Button.Visible = false;
                character3Button.Visible = false;
                character1Button.Enabled = false;
                character2Button.Enabled = false;
                character3Button.Enabled = false;

                character1Picture.Visible = false;
                character1Nameplate.Visible = false;
                character1Infoplate.Visible = false;

                character2Picture.Visible = false;
                character2Nameplate.Visible = false;
                character2Infoplate.Visible = false;

                character3Picture.Visible = false;
                character3Nameplate.Visible = false;
                character3Infoplate.Visible = false;

                battleBackground.Visible = false;
                playerCharacter.Visible = false;
                playerhealthLabel.Visible = false;
                playernameLabel.Visible = false;
                opponentCharacter.Visible = false;
                opponenthealthLabel.Visible = false;
                opponentnameLabel.Visible = false;

                battleAnnouncingLabel.Visible = false;


                battlechoiceLabel1.Visible = false;
                battlechoiceLabel2.Visible = false;
                battlechoiceLabel3.Visible = false;

                greenLabel1.Visible = false;
                greenLabel2.Visible = false;
                greenLabel3.Visible = false;
                greenLabel4.Visible = false;
                pathLabel.Visible = false;

                finishBackground.Visible = true;
                congratulationsLabel.Visible = true;
                congratulationsLabel.Text = "Arena Champion";
                exitLabel.Visible = true;
                exitLabel.Text = "Press Space to Begin";

                startscreenPicture.Visible = true;
        }

            if (gameScreen == "characterselect")
            {
                playerchoiceBackground.Visible = true;
                choosecharacterLabel.Visible = true;
                character1Background.Visible = true;
                character2Background.Visible = true;
                character3Background.Visible = true;
                character1Button.Visible = true;
                character2Button.Visible = true;
                character3Button.Visible = true;
                character1Button.Enabled = true;
                character2Button.Enabled = true;
                character3Button.Enabled = true;

                character1Picture.Visible = true;
                character1Nameplate.Visible = true;
                character1Infoplate.Visible = true;

                character2Picture.Visible = true;
                character2Nameplate.Visible = true;
                character2Infoplate.Visible = true;

                character3Picture.Visible = true;
                character3Nameplate.Visible = true;
                character3Infoplate.Visible = true;

                battleBackground.Visible = false;
                playerCharacter.Visible = false;
                playerhealthLabel.Visible = false;
                playernameLabel.Visible = false;
                opponentCharacter.Visible = false;
                opponenthealthLabel.Visible = false;
                opponentnameLabel.Visible = false;

                battleAnnouncingLabel.Visible = false;


                battlechoiceLabel1.Visible = false;
                battlechoiceLabel2.Visible = false;
                battlechoiceLabel3.Visible = false;

                greenLabel1.Visible = false;
                greenLabel2.Visible = false;
                greenLabel3.Visible = false;
                greenLabel4.Visible = false;
                pathLabel.Visible = false;

                finishBackground.Visible = false;
                congratulationsLabel.Visible = false;
                championLabel.Visible = false;
                exitLabel.Visible = false;

                startscreenPicture.Visible = false;
            }
            if (gameScreen == "overworld")
            {
                e.Graphics.FillRectangle(blackbrush, arenaEntrance);

                e.Graphics.FillRectangle(redbrush, player);


                battleBackground.Visible = false;
                playerCharacter.Visible = false;
                playerhealthLabel.Visible = false;
                playernameLabel.Visible = false;
                opponentCharacter.Visible = false;
                opponenthealthLabel.Visible = false;
                opponentnameLabel.Visible = false;


                battlechoiceLabel1.Visible = false;
                battlechoiceLabel2.Visible = false;
                battlechoiceLabel3.Visible = false;
                battleAnnouncingLabel.Visible = false;


                playerchoiceBackground.Visible = false;
                choosecharacterLabel.Visible = false;
                character1Background.Visible = false;
                character2Background.Visible = false;
                character3Background.Visible = false;

                character1Button.Visible = false;
                character2Button.Visible = false;
                character3Button.Visible = false;
                character1Button.Enabled = false;
                character2Button.Enabled = false;
                character3Button.Enabled = false;

                character1Picture.Visible = false;
                character1Nameplate.Visible = false;
                character1Infoplate.Visible = false;

                character2Picture.Visible = false;
                character2Nameplate.Visible = false;
                character2Infoplate.Visible = false;

                character3Picture.Visible = false;
                character3Nameplate.Visible = false;
                character3Infoplate.Visible = false;

                finishBackground.Visible = false;
                congratulationsLabel.Visible = false;
                championLabel.Visible = false;
                exitLabel.Visible = false;

                startscreenPicture.Visible = false;

            }

            if (gameScreen == "arenabattle")
            {
                greenLabel1.Visible = false;
                greenLabel2.Visible = false;
                greenLabel3.Visible = false;
                greenLabel4.Visible = false;
                pathLabel.Visible = false;
                playerchoiceBackground.Visible = false;
                choosecharacterLabel.Visible = false;
                character1Background.Visible = false;
                character2Background.Visible = false;
                character3Background.Visible = false;
                character1Button.Visible = false;
                character2Button.Visible = false;
                character3Button.Visible = false;
                character1Button.Enabled = false;
                character2Button.Enabled = false;
                character3Button.Enabled = false;

                battleBackground.Visible = true;
                playerCharacter.Visible = true;

                character1Picture.Visible = false;
                character1Nameplate.Visible = false;
                character1Infoplate.Visible = false;

                character2Picture.Visible = false;
                character2Nameplate.Visible = false;
                character2Infoplate.Visible = false;

                character3Picture.Visible = false;
                character3Nameplate.Visible = false;
                character3Infoplate.Visible = false;

                finishBackground.Visible = false;
                congratulationsLabel.Visible = false;
                championLabel.Visible = false;
                exitLabel.Visible = false;


                playerhealthLabel.Visible = true;
                playernameLabel.Visible = true;

                playernameLabel.Text = $"{characterName}";

                opponentCharacter.Visible = true;
                opponenthealthLabel.Visible = true;

                opponentnameLabel.Text = $"{opponentName}";
                opponentnameLabel.Visible = true;
                battlechoiceLabel1.Visible = true;
                battlechoiceLabel2.Visible = true;
                battlechoiceLabel3.Visible = true;
                battleAnnouncingLabel.Visible = true;

                startscreenPicture.Visible = false;


                //change label texts when needed
                opponenthealthLabel.Text = $"{opponenthealthPercentage.ToString(".00%")}";
                playerhealthLabel.Text = $"{playerhealthPercentage.ToString(".00%")}";

                if (battleChoice == "")
                {
                    battlechoiceLabel1.Text = "Attack(1)";
                    battlechoiceLabel2.Text = "";
                    battlechoiceLabel3.Text = "";

                    battleAnnouncingLabel.Text = "Please choose an action";
                }

                //show battle end screen based on whose health reached 0
                if (battleChoice == "done")
                {
                    if (opponentHealth[0] == 0)
                    {
                        battleAnnouncingLabel.Text = "You have won the battle, congratulations! Please press Esc to exit the arena";

                    }

                    if (playerHealth[0] == 0)
                    {
                        battleAnnouncingLabel.Text = "You have been defeated, please press Esc to exit the arena";
                    }

                    attacknumber = 0;
                }

            }

            //change options to attack choices based on which character is being used
            if (battleChoice == "attack")
            {
                if (playerparty[0] == 1)
                {
                    battlechoiceLabel1.Text = "Sword Slash (E)";
                    battlechoiceLabel2.Text = "Armour Pierce (R)";
                    battlechoiceLabel3.Text = "Hilt Bash (T)";

                }

                if (playerparty[0] == 2)
                {
                    battlechoiceLabel1.Text = "Piercing Shot (E)";
                    battlechoiceLabel2.Text = "Triple Shot (R)";
                    battlechoiceLabel3.Text = "Long Shot (T)";
                }

                if (playerparty[0] == 3)
                {
                    battlechoiceLabel1.Text = "Backstab (E)";
                    battlechoiceLabel2.Text = "Knife Plunge (R)";
                    battlechoiceLabel3.Text = "Fight Dirty (T)";
                }
            }



            if (gameScreen == "end")
            {
                battleBackground.Visible = false;
                playerCharacter.Visible = false;
                playerhealthLabel.Visible = false;
                playernameLabel.Visible = false;
                opponentCharacter.Visible = false;
                opponenthealthLabel.Visible = false;
                opponentnameLabel.Visible = false;


                battlechoiceLabel1.Visible = false;
                battlechoiceLabel2.Visible = false;
                battlechoiceLabel3.Visible = false;
                battleAnnouncingLabel.Visible = false;


                playerchoiceBackground.Visible = false;
                choosecharacterLabel.Visible = false;
                character1Background.Visible = false;
                character2Background.Visible = false;
                character3Background.Visible = false;

                character1Button.Visible = false;
                character2Button.Visible = false;
                character3Button.Visible = false;
                character1Button.Enabled = false;
                character2Button.Enabled = false;
                character3Button.Enabled = false;

                character1Picture.Visible = false;
                character1Nameplate.Visible = false;
                character1Infoplate.Visible = false;

                character2Picture.Visible = false;
                character2Nameplate.Visible = false;
                character2Infoplate.Visible = false;

                character3Picture.Visible = false;
                character3Nameplate.Visible = false;
                character3Infoplate.Visible = false;

                startscreenPicture.Visible = false;


            }
        }
        //when player uses attack, calculate amount of damage it will deal
        public void playerAttackAction()
        {
            if (eDown == true && battleChoice == "attack" && attacknumber < 1)
            {
                attacknumber += 1;



                switch (playerparty[0])
                {
                    case 1:
                        playerdamageDeal = 3 * 11 * (playerAttack[0] / opponentDefense[0]);
                        break;
                    case 2:
                        playerdamageDeal = 3 * 10 * (playerAttack[0] / opponentDefense[0]);
                        break;
                    case 3:
                        playerdamageDeal = 3 * 14 * (playerAttack[0] / opponentDefense[0]);
                        break;
                }
            }

            if (rDown == true && battleChoice == "attack" && attacknumber < 1)
            {
                attacknumber += 1;




                switch (playerparty[0])
                {
                    case 1:
                        playerdamageDeal = 3 * 12 * (playerAttack[0] / opponentDefense[0]);
                        break;
                    case 2:
                        playerdamageDeal = (3 * 3 * (playerAttack[0] / opponentDefense[0])) * 3;
                        break;
                    case 3:
                        playerdamageDeal = 3 * 9 * (playerAttack[0] / opponentDefense[0]);
                        break;
                }
            }

            if (tDown == true && battleChoice == "attack" && attacknumber < 1)
            {
                attacknumber += 1;


                switch (playerparty[0])
                {
                    case 1:
                        playerdamageDeal = 3 * 12 * (playerAttack[0] / (opponentDefense[0] - 3));
                        break;
                    case 2:
                        playerdamageDeal = 3 * 19 * (playerAttack[0] / opponentDefense[0]);
                        break;
                    case 3:
                        playerdamageDeal = 3 * 16 * (playerAttack[0] / opponentDefense[0]);
                        break;
                }
            }
        }

        //calculate amount of damage opponent will do
        public void opponentAttackAction()
        {
            if (attacknumber == 1)
            {
                
                opponentAttackchoice = random.Next(1, 5);

                switch (opponentAttackchoice)
                {
                    case 1:
                        opponentdamageDeal = 3 * 4 * (opponentAttack[0] / playerDefense[0]);
                        break;
                    case 2:
                        opponentdamageDeal = 3 * 1 * (opponentAttack[0] / (playerDefense[0] - 5));
                        break;
                    case 3:
                        opponentdamageDeal = 3 * 10 * (opponentAttack[0] / playerDefense[0]);
                        break;
                    case 4:
                        opponentdamageDeal = 3 * 2 * (opponentAttack[0] / playerDefense[0]) * 4;
                        break;
                    case 5:
                        opponentdamageDeal = 3 * 15 * (opponentAttack[0] / playerDefense[0]);
                        break;


                }


                attacknumber += 1;

            }
        }

        // determine which character will hit first
        // deal damage to healths based on damages
        public void healthChanges()
        {
            if (attacknumber == 2)
            {
                //check speed to see who is faster
                if (playerBattleSpeed[0] > opponentSpeed[0])
                {
                    opponentHealth[0] -= playerdamageDeal;

                    if(opponentHealth[0] <= 0)
                    {
                        opponentHealth[0] = 0;

                        playerhealthPercentage = (playerHealth[0] / playerHealthTotal[0]);
                        opponenthealthPercentage = (opponentHealth[0] / holdingVariable);


                            battleChoice = "done";
                        battleCount += 1;
                        
                    }
                    else if (opponentHealth[0] > 0)
                    {
                        playerHealth[0] -= opponentdamageDeal;

                        if(playerHealth[0] <= 0)
                        {
                            playerHealth[0] = 0;

                            playerhealthPercentage = (playerHealth[0] / playerHealthTotal[0]);
                            opponenthealthPercentage = (opponentHealth[0] / holdingVariable);

                            battleChoice = "done";
                        }
                        else if (playerHealth[0] > 0)
                        {
                            playerhealthPercentage = (playerHealth[0] / playerHealthTotal[0]);
                            opponenthealthPercentage = (opponentHealth[0] / holdingVariable);
                            attacknumber += 1;
                        }
                    }
                }

                else if (playerBattleSpeed[0] < opponentSpeed[0])
                {
                    playerHealth[0] -= opponentdamageDeal;

                    if (playerHealth[0] <= 0)
                    {
                        playerHealth[0] = 0;

                        playerhealthPercentage = (playerHealth[0] / playerHealthTotal[0]);
                        opponenthealthPercentage = (opponentHealth[0] / holdingVariable);

                        battleChoice = "done";
                    }
                    else if (playerHealth[0] > 0)
                    {
                        opponentHealth[0] -= playerdamageDeal;

                        if (opponentHealth[0] <= 0)
                        {
                            opponentHealth[0] = 0;

                            playerhealthPercentage = (playerHealth[0] / playerHealthTotal[0]);
                            opponenthealthPercentage = (opponentHealth[0] / holdingVariable);

                            battleChoice = "done";
                            battleCount += 1;

                        }
                        else if (opponentHealth[0] > 0)
                        {
                            playerhealthPercentage = (playerHealth[0] / playerHealthTotal[0]);
                            opponenthealthPercentage = (opponentHealth[0] / holdingVariable);
                            attacknumber += 1;
                        }
                    }
                }


                
            }
        }

        //if no character is dead this will reset the screen with healths changed
        //if character is dead this will end the battle
        public void turnEnd()
        {
            if (attacknumber == 3)
            {

                if (playerHealth[0] == 0)
                {


                    battleChoice = "done";
                }
                else if (opponentHealth[0] == 0)
                {


                    battleChoice = "done";
                }
                else
                {
                    attacknumber += 1;

                }

            }

            if (attacknumber == 4)
            {
                attacknumber = 0;

                battleChoice = "";
            }
        }

        //reset player health after battle
        public void playerRestore()
        {
            playerHealth.RemoveAt(0);
            switch (playerparty[0])
            {
                case 1:
                    playerHealth.Add(150);
                    break;
                case 2:
                    playerHealth.Add(100);
                    break;
                case 3:
                    playerHealth.Add(90);
                    break;
            }


        }
    }
}

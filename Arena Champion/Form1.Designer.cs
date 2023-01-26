namespace Arena_Champion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.greenLabel1 = new System.Windows.Forms.Label();
            this.greenLabel2 = new System.Windows.Forms.Label();
            this.greenLabel4 = new System.Windows.Forms.Label();
            this.greenLabel3 = new System.Windows.Forms.Label();
            this.gameTick = new System.Windows.Forms.Timer(this.components);
            this.playernameLabel = new System.Windows.Forms.Label();
            this.playerhealthLabel = new System.Windows.Forms.Label();
            this.opponentnameLabel = new System.Windows.Forms.Label();
            this.opponenthealthLabel = new System.Windows.Forms.Label();
            this.playerchoiceBackground = new System.Windows.Forms.Label();
            this.choosecharacterLabel = new System.Windows.Forms.Label();
            this.character1Background = new System.Windows.Forms.Label();
            this.character2Background = new System.Windows.Forms.Label();
            this.character3Background = new System.Windows.Forms.Label();
            this.character1Button = new System.Windows.Forms.Button();
            this.character2Button = new System.Windows.Forms.Button();
            this.character3Button = new System.Windows.Forms.Button();
            this.gameTick2 = new System.Windows.Forms.Timer(this.components);
            this.battlechoiceLabel2 = new System.Windows.Forms.Label();
            this.battlechoiceLabel1 = new System.Windows.Forms.Label();
            this.battlechoiceLabel3 = new System.Windows.Forms.Label();
            this.battleAnnouncingLabel = new System.Windows.Forms.Label();
            this.playerCharacter = new System.Windows.Forms.PictureBox();
            this.battleBackgroundfake = new System.Windows.Forms.Label();
            this.battleBackground = new System.Windows.Forms.PictureBox();
            this.pathLabel = new System.Windows.Forms.Label();
            this.pathPicture = new System.Windows.Forms.PictureBox();
            this.opponentCharacter = new System.Windows.Forms.PictureBox();
            this.overworldCharacter = new System.Windows.Forms.PictureBox();
            this.character1Picture = new System.Windows.Forms.PictureBox();
            this.character2Picture = new System.Windows.Forms.PictureBox();
            this.character3Picture = new System.Windows.Forms.PictureBox();
            this.character1Nameplate = new System.Windows.Forms.Label();
            this.character2Nameplate = new System.Windows.Forms.Label();
            this.character3Nameplate = new System.Windows.Forms.Label();
            this.character1Infoplate = new System.Windows.Forms.Label();
            this.character2Infoplate = new System.Windows.Forms.Label();
            this.character3Infoplate = new System.Windows.Forms.Label();
            this.finishBackground = new System.Windows.Forms.Label();
            this.congratulationsLabel = new System.Windows.Forms.Label();
            this.championLabel = new System.Windows.Forms.Label();
            this.exitLabel = new System.Windows.Forms.Label();
            this.startscreenPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.overworldCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character1Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.character3Picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startscreenPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // greenLabel1
            // 
            this.greenLabel1.BackColor = System.Drawing.Color.Transparent;
            this.greenLabel1.Location = new System.Drawing.Point(0, 437);
            this.greenLabel1.Name = "greenLabel1";
            this.greenLabel1.Size = new System.Drawing.Size(489, 264);
            this.greenLabel1.TabIndex = 0;
            this.greenLabel1.Visible = false;
            // 
            // greenLabel2
            // 
            this.greenLabel2.BackColor = System.Drawing.Color.Transparent;
            this.greenLabel2.Location = new System.Drawing.Point(661, 437);
            this.greenLabel2.Name = "greenLabel2";
            this.greenLabel2.Size = new System.Drawing.Size(489, 264);
            this.greenLabel2.TabIndex = 1;
            this.greenLabel2.Visible = false;
            // 
            // greenLabel4
            // 
            this.greenLabel4.BackColor = System.Drawing.Color.Transparent;
            this.greenLabel4.Location = new System.Drawing.Point(0, -1);
            this.greenLabel4.Name = "greenLabel4";
            this.greenLabel4.Size = new System.Drawing.Size(374, 264);
            this.greenLabel4.TabIndex = 2;
            this.greenLabel4.Visible = false;
            // 
            // greenLabel3
            // 
            this.greenLabel3.BackColor = System.Drawing.Color.Transparent;
            this.greenLabel3.Location = new System.Drawing.Point(776, -1);
            this.greenLabel3.Name = "greenLabel3";
            this.greenLabel3.Size = new System.Drawing.Size(374, 264);
            this.greenLabel3.TabIndex = 3;
            this.greenLabel3.Visible = false;
            // 
            // gameTick
            // 
            this.gameTick.Enabled = true;
            this.gameTick.Interval = 20;
            this.gameTick.Tick += new System.EventHandler(this.gameTick_Tick);
            // 
            // playernameLabel
            // 
            this.playernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.playernameLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playernameLabel.ForeColor = System.Drawing.Color.White;
            this.playernameLabel.Location = new System.Drawing.Point(82, 228);
            this.playernameLabel.Name = "playernameLabel";
            this.playernameLabel.Size = new System.Drawing.Size(183, 23);
            this.playernameLabel.TabIndex = 9;
            this.playernameLabel.Text = "label1";
            this.playernameLabel.Visible = false;
            // 
            // playerhealthLabel
            // 
            this.playerhealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.playerhealthLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerhealthLabel.ForeColor = System.Drawing.Color.White;
            this.playerhealthLabel.Location = new System.Drawing.Point(82, 251);
            this.playerhealthLabel.Name = "playerhealthLabel";
            this.playerhealthLabel.Size = new System.Drawing.Size(183, 23);
            this.playerhealthLabel.TabIndex = 10;
            this.playerhealthLabel.Text = "label2";
            this.playerhealthLabel.Visible = false;
            // 
            // opponentnameLabel
            // 
            this.opponentnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.opponentnameLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponentnameLabel.ForeColor = System.Drawing.Color.White;
            this.opponentnameLabel.Location = new System.Drawing.Point(776, 228);
            this.opponentnameLabel.Name = "opponentnameLabel";
            this.opponentnameLabel.Size = new System.Drawing.Size(280, 23);
            this.opponentnameLabel.TabIndex = 11;
            this.opponentnameLabel.Text = "label1";
            this.opponentnameLabel.Visible = false;
            // 
            // opponenthealthLabel
            // 
            this.opponenthealthLabel.BackColor = System.Drawing.Color.Transparent;
            this.opponenthealthLabel.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.opponenthealthLabel.ForeColor = System.Drawing.Color.White;
            this.opponenthealthLabel.Location = new System.Drawing.Point(776, 251);
            this.opponenthealthLabel.Name = "opponenthealthLabel";
            this.opponenthealthLabel.Size = new System.Drawing.Size(183, 23);
            this.opponenthealthLabel.TabIndex = 12;
            this.opponenthealthLabel.Text = "label1";
            this.opponenthealthLabel.Visible = false;
            // 
            // playerchoiceBackground
            // 
            this.playerchoiceBackground.BackColor = System.Drawing.Color.Gray;
            this.playerchoiceBackground.Location = new System.Drawing.Point(-3, -1);
            this.playerchoiceBackground.Name = "playerchoiceBackground";
            this.playerchoiceBackground.Size = new System.Drawing.Size(1167, 709);
            this.playerchoiceBackground.TabIndex = 19;
            this.playerchoiceBackground.Text = "label1";
            // 
            // choosecharacterLabel
            // 
            this.choosecharacterLabel.BackColor = System.Drawing.Color.Black;
            this.choosecharacterLabel.Font = new System.Drawing.Font("Baskerville Old Face", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choosecharacterLabel.ForeColor = System.Drawing.Color.White;
            this.choosecharacterLabel.Location = new System.Drawing.Point(12, 9);
            this.choosecharacterLabel.Name = "choosecharacterLabel";
            this.choosecharacterLabel.Size = new System.Drawing.Size(1126, 102);
            this.choosecharacterLabel.TabIndex = 20;
            this.choosecharacterLabel.Text = "Choose Your Character";
            this.choosecharacterLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // character1Background
            // 
            this.character1Background.BackColor = System.Drawing.Color.Black;
            this.character1Background.Location = new System.Drawing.Point(17, 150);
            this.character1Background.Name = "character1Background";
            this.character1Background.Size = new System.Drawing.Size(303, 435);
            this.character1Background.TabIndex = 21;
            this.character1Background.Text = "label1";
            // 
            // character2Background
            // 
            this.character2Background.BackColor = System.Drawing.Color.Black;
            this.character2Background.Location = new System.Drawing.Point(427, 150);
            this.character2Background.Name = "character2Background";
            this.character2Background.Size = new System.Drawing.Size(303, 435);
            this.character2Background.TabIndex = 22;
            this.character2Background.Text = "label2";
            // 
            // character3Background
            // 
            this.character3Background.BackColor = System.Drawing.Color.Black;
            this.character3Background.Location = new System.Drawing.Point(835, 150);
            this.character3Background.Name = "character3Background";
            this.character3Background.Size = new System.Drawing.Size(303, 435);
            this.character3Background.TabIndex = 23;
            this.character3Background.Text = "label3";
            // 
            // character1Button
            // 
            this.character1Button.BackColor = System.Drawing.Color.Black;
            this.character1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.character1Button.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character1Button.ForeColor = System.Drawing.Color.White;
            this.character1Button.Location = new System.Drawing.Point(32, 612);
            this.character1Button.Name = "character1Button";
            this.character1Button.Size = new System.Drawing.Size(271, 76);
            this.character1Button.TabIndex = 24;
            this.character1Button.Text = "Choose Tibald";
            this.character1Button.UseVisualStyleBackColor = false;
            this.character1Button.Click += new System.EventHandler(this.character1Button_Click);
            // 
            // character2Button
            // 
            this.character2Button.BackColor = System.Drawing.Color.Black;
            this.character2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.character2Button.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character2Button.ForeColor = System.Drawing.Color.White;
            this.character2Button.Location = new System.Drawing.Point(446, 612);
            this.character2Button.Name = "character2Button";
            this.character2Button.Size = new System.Drawing.Size(271, 76);
            this.character2Button.TabIndex = 25;
            this.character2Button.Text = "Choose Natalia";
            this.character2Button.UseVisualStyleBackColor = false;
            this.character2Button.Click += new System.EventHandler(this.character2Button_Click);
            // 
            // character3Button
            // 
            this.character3Button.BackColor = System.Drawing.Color.Black;
            this.character3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.character3Button.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character3Button.ForeColor = System.Drawing.Color.White;
            this.character3Button.Location = new System.Drawing.Point(852, 612);
            this.character3Button.Name = "character3Button";
            this.character3Button.Size = new System.Drawing.Size(271, 76);
            this.character3Button.TabIndex = 26;
            this.character3Button.Text = "Choose Vedori";
            this.character3Button.UseVisualStyleBackColor = false;
            this.character3Button.Click += new System.EventHandler(this.character3Button_Click);
            // 
            // gameTick2
            // 
            this.gameTick2.Enabled = true;
            this.gameTick2.Interval = 20;
            this.gameTick2.Tick += new System.EventHandler(this.gameTick2_Tick);
            // 
            // battlechoiceLabel2
            // 
            this.battlechoiceLabel2.BackColor = System.Drawing.Color.Transparent;
            this.battlechoiceLabel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.battlechoiceLabel2.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battlechoiceLabel2.ForeColor = System.Drawing.Color.White;
            this.battlechoiceLabel2.Location = new System.Drawing.Point(309, 588);
            this.battlechoiceLabel2.Name = "battlechoiceLabel2";
            this.battlechoiceLabel2.Size = new System.Drawing.Size(243, 100);
            this.battlechoiceLabel2.TabIndex = 27;
            this.battlechoiceLabel2.Text = "label1";
            this.battlechoiceLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // battlechoiceLabel1
            // 
            this.battlechoiceLabel1.BackColor = System.Drawing.Color.Transparent;
            this.battlechoiceLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.battlechoiceLabel1.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battlechoiceLabel1.ForeColor = System.Drawing.Color.White;
            this.battlechoiceLabel1.Location = new System.Drawing.Point(12, 588);
            this.battlechoiceLabel1.Name = "battlechoiceLabel1";
            this.battlechoiceLabel1.Size = new System.Drawing.Size(243, 100);
            this.battlechoiceLabel1.TabIndex = 28;
            this.battlechoiceLabel1.Text = "label1";
            this.battlechoiceLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // battlechoiceLabel3
            // 
            this.battlechoiceLabel3.BackColor = System.Drawing.Color.Transparent;
            this.battlechoiceLabel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.battlechoiceLabel3.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.battlechoiceLabel3.ForeColor = System.Drawing.Color.White;
            this.battlechoiceLabel3.Location = new System.Drawing.Point(611, 588);
            this.battlechoiceLabel3.Name = "battlechoiceLabel3";
            this.battlechoiceLabel3.Size = new System.Drawing.Size(243, 100);
            this.battlechoiceLabel3.TabIndex = 29;
            this.battlechoiceLabel3.Text = "label1";
            this.battlechoiceLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // battleAnnouncingLabel
            // 
            this.battleAnnouncingLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.battleAnnouncingLabel.Location = new System.Drawing.Point(427, 437);
            this.battleAnnouncingLabel.Name = "battleAnnouncingLabel";
            this.battleAnnouncingLabel.Size = new System.Drawing.Size(303, 69);
            this.battleAnnouncingLabel.TabIndex = 31;
            this.battleAnnouncingLabel.Text = "label1";
            this.battleAnnouncingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.battleAnnouncingLabel.Visible = false;
            // 
            // playerCharacter
            // 
            this.playerCharacter.BackColor = System.Drawing.Color.Transparent;
            this.playerCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playerCharacter.Image = global::Arena_Champion.Properties.Resources.Knight_1;
            this.playerCharacter.Location = new System.Drawing.Point(82, 293);
            this.playerCharacter.Name = "playerCharacter";
            this.playerCharacter.Size = new System.Drawing.Size(183, 240);
            this.playerCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerCharacter.TabIndex = 32;
            this.playerCharacter.TabStop = false;
            this.playerCharacter.Visible = false;
            // 
            // battleBackgroundfake
            // 
            this.battleBackgroundfake.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.battleBackgroundfake.Image = global::Arena_Champion.Properties.Resources.Arena_Back;
            this.battleBackgroundfake.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.battleBackgroundfake.Location = new System.Drawing.Point(-6, -1);
            this.battleBackgroundfake.Name = "battleBackgroundfake";
            this.battleBackgroundfake.Size = new System.Drawing.Size(860, 566);
            this.battleBackgroundfake.TabIndex = 6;
            this.battleBackgroundfake.Visible = false;
            // 
            // battleBackground
            // 
            this.battleBackground.BackgroundImage = global::Arena_Champion.Properties.Resources.Arena_Back;
            this.battleBackground.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.battleBackground.Location = new System.Drawing.Point(-6, -1);
            this.battleBackground.Name = "battleBackground";
            this.battleBackground.Size = new System.Drawing.Size(1168, 747);
            this.battleBackground.TabIndex = 30;
            this.battleBackground.TabStop = false;
            // 
            // pathLabel
            // 
            this.pathLabel.BackColor = System.Drawing.Color.BurlyWood;
            this.pathLabel.Location = new System.Drawing.Point(-6, -1);
            this.pathLabel.Name = "pathLabel";
            this.pathLabel.Size = new System.Drawing.Size(1168, 747);
            this.pathLabel.TabIndex = 33;
            this.pathLabel.Text = "label1";
            this.pathLabel.Visible = false;
            // 
            // pathPicture
            // 
            this.pathPicture.BackgroundImage = global::Arena_Champion.Properties.Resources.pixel_path_real;
            this.pathPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pathPicture.Location = new System.Drawing.Point(-6, -1);
            this.pathPicture.Name = "pathPicture";
            this.pathPicture.Size = new System.Drawing.Size(1168, 747);
            this.pathPicture.TabIndex = 34;
            this.pathPicture.TabStop = false;
            this.pathPicture.Visible = false;
            // 
            // opponentCharacter
            // 
            this.opponentCharacter.BackColor = System.Drawing.Color.Transparent;
            this.opponentCharacter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.opponentCharacter.Image = global::Arena_Champion.Properties.Resources.Knight_1;
            this.opponentCharacter.Location = new System.Drawing.Point(779, 293);
            this.opponentCharacter.Name = "opponentCharacter";
            this.opponentCharacter.Size = new System.Drawing.Size(183, 240);
            this.opponentCharacter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.opponentCharacter.TabIndex = 35;
            this.opponentCharacter.TabStop = false;
            this.opponentCharacter.Visible = false;
            // 
            // overworldCharacter
            // 
            this.overworldCharacter.BackColor = System.Drawing.Color.Transparent;
            this.overworldCharacter.Location = new System.Drawing.Point(321, 348);
            this.overworldCharacter.Name = "overworldCharacter";
            this.overworldCharacter.Size = new System.Drawing.Size(100, 101);
            this.overworldCharacter.TabIndex = 36;
            this.overworldCharacter.TabStop = false;
            // 
            // character1Picture
            // 
            this.character1Picture.BackColor = System.Drawing.Color.Transparent;
            this.character1Picture.Image = global::Arena_Champion.Properties.Resources.Knight_1;
            this.character1Picture.Location = new System.Drawing.Point(80, 172);
            this.character1Picture.Name = "character1Picture";
            this.character1Picture.Size = new System.Drawing.Size(185, 233);
            this.character1Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character1Picture.TabIndex = 37;
            this.character1Picture.TabStop = false;
            // 
            // character2Picture
            // 
            this.character2Picture.BackColor = System.Drawing.Color.Transparent;
            this.character2Picture.Image = global::Arena_Champion.Properties.Resources.ranger_choose;
            this.character2Picture.Location = new System.Drawing.Point(487, 172);
            this.character2Picture.Name = "character2Picture";
            this.character2Picture.Size = new System.Drawing.Size(185, 233);
            this.character2Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character2Picture.TabIndex = 38;
            this.character2Picture.TabStop = false;
            // 
            // character3Picture
            // 
            this.character3Picture.BackColor = System.Drawing.Color.Transparent;
            this.character3Picture.Image = global::Arena_Champion.Properties.Resources.Rogue_choose;
            this.character3Picture.Location = new System.Drawing.Point(899, 172);
            this.character3Picture.Name = "character3Picture";
            this.character3Picture.Size = new System.Drawing.Size(185, 233);
            this.character3Picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.character3Picture.TabIndex = 39;
            this.character3Picture.TabStop = false;
            // 
            // character1Nameplate
            // 
            this.character1Nameplate.BackColor = System.Drawing.Color.Transparent;
            this.character1Nameplate.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character1Nameplate.ForeColor = System.Drawing.Color.Transparent;
            this.character1Nameplate.Location = new System.Drawing.Point(32, 437);
            this.character1Nameplate.Name = "character1Nameplate";
            this.character1Nameplate.Size = new System.Drawing.Size(271, 31);
            this.character1Nameplate.TabIndex = 40;
            this.character1Nameplate.Text = "Tibald, of the Fallen Kingdom";
            this.character1Nameplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // character2Nameplate
            // 
            this.character2Nameplate.BackColor = System.Drawing.Color.Transparent;
            this.character2Nameplate.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character2Nameplate.ForeColor = System.Drawing.Color.Transparent;
            this.character2Nameplate.Location = new System.Drawing.Point(446, 437);
            this.character2Nameplate.Name = "character2Nameplate";
            this.character2Nameplate.Size = new System.Drawing.Size(271, 31);
            this.character2Nameplate.TabIndex = 41;
            this.character2Nameplate.Text = "Natalia, of the Light Forest";
            this.character2Nameplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // character3Nameplate
            // 
            this.character3Nameplate.BackColor = System.Drawing.Color.Transparent;
            this.character3Nameplate.Font = new System.Drawing.Font("Baskerville Old Face", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character3Nameplate.ForeColor = System.Drawing.Color.Transparent;
            this.character3Nameplate.Location = new System.Drawing.Point(852, 437);
            this.character3Nameplate.Name = "character3Nameplate";
            this.character3Nameplate.Size = new System.Drawing.Size(271, 31);
            this.character3Nameplate.TabIndex = 42;
            this.character3Nameplate.Text = "Vedori, of the Rebel Alliance";
            this.character3Nameplate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // character1Infoplate
            // 
            this.character1Infoplate.BackColor = System.Drawing.Color.Transparent;
            this.character1Infoplate.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character1Infoplate.ForeColor = System.Drawing.Color.White;
            this.character1Infoplate.Location = new System.Drawing.Point(36, 502);
            this.character1Infoplate.Name = "character1Infoplate";
            this.character1Infoplate.Size = new System.Drawing.Size(249, 62);
            this.character1Infoplate.TabIndex = 43;
            this.character1Infoplate.Text = "A knight wishing to regain his honour.\r\n\r\nVery high defensive stats, low speed an" +
    "d attack\r\n";
            // 
            // character2Infoplate
            // 
            this.character2Infoplate.BackColor = System.Drawing.Color.Transparent;
            this.character2Infoplate.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character2Infoplate.ForeColor = System.Drawing.Color.White;
            this.character2Infoplate.Location = new System.Drawing.Point(447, 502);
            this.character2Infoplate.Name = "character2Infoplate";
            this.character2Infoplate.Size = new System.Drawing.Size(249, 62);
            this.character2Infoplate.TabIndex = 44;
            this.character2Infoplate.Text = "An elf looking to prove her worthiness\r\n\r\nVery high attack, low defense, mediocre" +
    " speed\r\n";
            // 
            // character3Infoplate
            // 
            this.character3Infoplate.BackColor = System.Drawing.Color.Transparent;
            this.character3Infoplate.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.character3Infoplate.ForeColor = System.Drawing.Color.White;
            this.character3Infoplate.Location = new System.Drawing.Point(874, 503);
            this.character3Infoplate.Name = "character3Infoplate";
            this.character3Infoplate.Size = new System.Drawing.Size(249, 62);
            this.character3Infoplate.TabIndex = 45;
            this.character3Infoplate.Text = "A human seeking revenge for her fallen friends\r\n\r\nVery high speed, mediocre attac" +
    "k and defense";
            // 
            // finishBackground
            // 
            this.finishBackground.Location = new System.Drawing.Point(0, -1);
            this.finishBackground.Name = "finishBackground";
            this.finishBackground.Size = new System.Drawing.Size(1168, 747);
            this.finishBackground.TabIndex = 46;
            this.finishBackground.Text = "label1";
            this.finishBackground.Visible = false;
            // 
            // congratulationsLabel
            // 
            this.congratulationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.congratulationsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.congratulationsLabel.ForeColor = System.Drawing.Color.White;
            this.congratulationsLabel.Location = new System.Drawing.Point(3, 9);
            this.congratulationsLabel.Name = "congratulationsLabel";
            this.congratulationsLabel.Size = new System.Drawing.Size(1139, 141);
            this.congratulationsLabel.TabIndex = 47;
            this.congratulationsLabel.Text = "Congratulations!";
            this.congratulationsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // championLabel
            // 
            this.championLabel.BackColor = System.Drawing.Color.Transparent;
            this.championLabel.Font = new System.Drawing.Font("Baskerville Old Face", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.championLabel.ForeColor = System.Drawing.Color.White;
            this.championLabel.Location = new System.Drawing.Point(3, 263);
            this.championLabel.Name = "championLabel";
            this.championLabel.Size = new System.Drawing.Size(1139, 201);
            this.championLabel.TabIndex = 48;
            this.championLabel.Text = "You have become the champion of the arena!";
            this.championLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.championLabel.Visible = false;
            // 
            // exitLabel
            // 
            this.exitLabel.BackColor = System.Drawing.Color.Transparent;
            this.exitLabel.Font = new System.Drawing.Font("Baskerville Old Face", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitLabel.ForeColor = System.Drawing.Color.White;
            this.exitLabel.Location = new System.Drawing.Point(3, 487);
            this.exitLabel.Name = "exitLabel";
            this.exitLabel.Size = new System.Drawing.Size(1139, 201);
            this.exitLabel.TabIndex = 49;
            this.exitLabel.Text = "Press Esc to exit";
            this.exitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exitLabel.Visible = false;
            // 
            // startscreenPicture
            // 
            this.startscreenPicture.BackColor = System.Drawing.Color.Transparent;
            this.startscreenPicture.Image = global::Arena_Champion.Properties.Resources.Swords;
            this.startscreenPicture.Location = new System.Drawing.Point(380, 172);
            this.startscreenPicture.Name = "startscreenPicture";
            this.startscreenPicture.Size = new System.Drawing.Size(409, 349);
            this.startscreenPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.startscreenPicture.TabIndex = 50;
            this.startscreenPicture.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1150, 700);
            this.Controls.Add(this.startscreenPicture);
            this.Controls.Add(this.exitLabel);
            this.Controls.Add(this.championLabel);
            this.Controls.Add(this.congratulationsLabel);
            this.Controls.Add(this.finishBackground);
            this.Controls.Add(this.character3Infoplate);
            this.Controls.Add(this.character2Infoplate);
            this.Controls.Add(this.character1Infoplate);
            this.Controls.Add(this.character3Nameplate);
            this.Controls.Add(this.character2Nameplate);
            this.Controls.Add(this.character1Nameplate);
            this.Controls.Add(this.character3Picture);
            this.Controls.Add(this.character2Picture);
            this.Controls.Add(this.character1Picture);
            this.Controls.Add(this.overworldCharacter);
            this.Controls.Add(this.character2Background);
            this.Controls.Add(this.battleAnnouncingLabel);
            this.Controls.Add(this.battlechoiceLabel3);
            this.Controls.Add(this.battlechoiceLabel1);
            this.Controls.Add(this.battlechoiceLabel2);
            this.Controls.Add(this.character3Button);
            this.Controls.Add(this.character2Button);
            this.Controls.Add(this.character1Button);
            this.Controls.Add(this.character3Background);
            this.Controls.Add(this.character1Background);
            this.Controls.Add(this.choosecharacterLabel);
            this.Controls.Add(this.playerchoiceBackground);
            this.Controls.Add(this.battleBackgroundfake);
            this.Controls.Add(this.greenLabel4);
            this.Controls.Add(this.greenLabel3);
            this.Controls.Add(this.greenLabel2);
            this.Controls.Add(this.greenLabel1);
            this.Controls.Add(this.pathLabel);
            this.Controls.Add(this.pathPicture);
            this.Controls.Add(this.playerhealthLabel);
            this.Controls.Add(this.playernameLabel);
            this.Controls.Add(this.playerCharacter);
            this.Controls.Add(this.opponentnameLabel);
            this.Controls.Add(this.opponenthealthLabel);
            this.Controls.Add(this.opponentCharacter);
            this.Controls.Add(this.battleBackground);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.playerCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.battleBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pathPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.opponentCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.overworldCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character1Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character2Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.character3Picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startscreenPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label greenLabel1;
        private System.Windows.Forms.Label greenLabel2;
        private System.Windows.Forms.Label greenLabel4;
        private System.Windows.Forms.Label greenLabel3;
        private System.Windows.Forms.Timer gameTick;
        private System.Windows.Forms.Label battleBackgroundfake;
        private System.Windows.Forms.Label playernameLabel;
        private System.Windows.Forms.Label playerhealthLabel;
        private System.Windows.Forms.Label opponentnameLabel;
        private System.Windows.Forms.Label opponenthealthLabel;
        private System.Windows.Forms.Label playerchoiceBackground;
        private System.Windows.Forms.Label choosecharacterLabel;
        private System.Windows.Forms.Label character1Background;
        private System.Windows.Forms.Label character2Background;
        private System.Windows.Forms.Label character3Background;
        private System.Windows.Forms.Button character1Button;
        private System.Windows.Forms.Button character2Button;
        private System.Windows.Forms.Button character3Button;
        private System.Windows.Forms.Timer gameTick2;
        private System.Windows.Forms.Label battlechoiceLabel2;
        private System.Windows.Forms.Label battlechoiceLabel1;
        private System.Windows.Forms.Label battlechoiceLabel3;
        private System.Windows.Forms.PictureBox battleBackground;
        private System.Windows.Forms.Label battleAnnouncingLabel;
        private System.Windows.Forms.PictureBox playerCharacter;
        private System.Windows.Forms.Label pathLabel;
        private System.Windows.Forms.PictureBox pathPicture;
        private System.Windows.Forms.PictureBox opponentCharacter;
        private System.Windows.Forms.PictureBox overworldCharacter;
        private System.Windows.Forms.PictureBox character1Picture;
        private System.Windows.Forms.PictureBox character2Picture;
        private System.Windows.Forms.PictureBox character3Picture;
        private System.Windows.Forms.Label character1Nameplate;
        private System.Windows.Forms.Label character2Nameplate;
        private System.Windows.Forms.Label character3Nameplate;
        private System.Windows.Forms.Label character1Infoplate;
        private System.Windows.Forms.Label character2Infoplate;
        private System.Windows.Forms.Label character3Infoplate;
        private System.Windows.Forms.Label finishBackground;
        private System.Windows.Forms.Label congratulationsLabel;
        private System.Windows.Forms.Label championLabel;
        private System.Windows.Forms.Label exitLabel;
        private System.Windows.Forms.PictureBox startscreenPicture;
    }
}


namespace THA_W4_ALFRED_W
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
            this.lbl_soccerteam = new System.Windows.Forms.Label();
            this.lbl_choosecountry = new System.Windows.Forms.Label();
            this.lbl_chooseteam = new System.Windows.Forms.Label();
            this.list_players = new System.Windows.Forms.ListBox();
            this.btn_removeplayer = new System.Windows.Forms.Button();
            this.lbl_addteam = new System.Windows.Forms.Label();
            this.lbl_addplayers = new System.Windows.Forms.Label();
            this.lbl_teamname = new System.Windows.Forms.Label();
            this.lbl_teamcountry = new System.Windows.Forms.Label();
            this.lbl_teamcity = new System.Windows.Forms.Label();
            this.lbl_playername = new System.Windows.Forms.Label();
            this.lbl_playernum = new System.Windows.Forms.Label();
            this.lbl_playerpos = new System.Windows.Forms.Label();
            this.textBox_tname = new System.Windows.Forms.TextBox();
            this.textBox_tcountry = new System.Windows.Forms.TextBox();
            this.textBox_tcity = new System.Windows.Forms.TextBox();
            this.textBox_pname = new System.Windows.Forms.TextBox();
            this.textBox_pnum = new System.Windows.Forms.TextBox();
            this.comboBox_country = new System.Windows.Forms.ComboBox();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.btn_addteam = new System.Windows.Forms.Button();
            this.btn_addplayer = new System.Windows.Forms.Button();
            this.comboBox_position = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_soccerteam
            // 
            this.lbl_soccerteam.AutoSize = true;
            this.lbl_soccerteam.Location = new System.Drawing.Point(45, 63);
            this.lbl_soccerteam.Name = "lbl_soccerteam";
            this.lbl_soccerteam.Size = new System.Drawing.Size(112, 16);
            this.lbl_soccerteam.TabIndex = 0;
            this.lbl_soccerteam.Text = "Soccer Team List";
            // 
            // lbl_choosecountry
            // 
            this.lbl_choosecountry.AutoSize = true;
            this.lbl_choosecountry.Location = new System.Drawing.Point(45, 124);
            this.lbl_choosecountry.Name = "lbl_choosecountry";
            this.lbl_choosecountry.Size = new System.Drawing.Size(105, 16);
            this.lbl_choosecountry.TabIndex = 1;
            this.lbl_choosecountry.Text = "Choose Country:";
            // 
            // lbl_chooseteam
            // 
            this.lbl_chooseteam.AutoSize = true;
            this.lbl_chooseteam.Location = new System.Drawing.Point(45, 184);
            this.lbl_chooseteam.Name = "lbl_chooseteam";
            this.lbl_chooseteam.Size = new System.Drawing.Size(96, 16);
            this.lbl_chooseteam.TabIndex = 2;
            this.lbl_chooseteam.Text = "Choose Team:";
            // 
            // list_players
            // 
            this.list_players.FormattingEnabled = true;
            this.list_players.ItemHeight = 16;
            this.list_players.Location = new System.Drawing.Point(48, 231);
            this.list_players.Name = "list_players";
            this.list_players.Size = new System.Drawing.Size(264, 132);
            this.list_players.TabIndex = 3;
            // 
            // btn_removeplayer
            // 
            this.btn_removeplayer.Location = new System.Drawing.Point(48, 385);
            this.btn_removeplayer.Name = "btn_removeplayer";
            this.btn_removeplayer.Size = new System.Drawing.Size(75, 23);
            this.btn_removeplayer.TabIndex = 4;
            this.btn_removeplayer.Text = "Remove";
            this.btn_removeplayer.UseVisualStyleBackColor = true;
            this.btn_removeplayer.Click += new System.EventHandler(this.btn_removeplayer_Click);
            // 
            // lbl_addteam
            // 
            this.lbl_addteam.AutoSize = true;
            this.lbl_addteam.Location = new System.Drawing.Point(449, 63);
            this.lbl_addteam.Name = "lbl_addteam";
            this.lbl_addteam.Size = new System.Drawing.Size(89, 16);
            this.lbl_addteam.TabIndex = 5;
            this.lbl_addteam.Text = "Adding Team";
            // 
            // lbl_addplayers
            // 
            this.lbl_addplayers.AutoSize = true;
            this.lbl_addplayers.Location = new System.Drawing.Point(737, 63);
            this.lbl_addplayers.Name = "lbl_addplayers";
            this.lbl_addplayers.Size = new System.Drawing.Size(99, 16);
            this.lbl_addplayers.TabIndex = 6;
            this.lbl_addplayers.Text = "Adding Players";
            // 
            // lbl_teamname
            // 
            this.lbl_teamname.AutoSize = true;
            this.lbl_teamname.Location = new System.Drawing.Point(346, 101);
            this.lbl_teamname.Name = "lbl_teamname";
            this.lbl_teamname.Size = new System.Drawing.Size(86, 16);
            this.lbl_teamname.TabIndex = 7;
            this.lbl_teamname.Text = "Team Name:";
            // 
            // lbl_teamcountry
            // 
            this.lbl_teamcountry.AutoSize = true;
            this.lbl_teamcountry.Location = new System.Drawing.Point(346, 149);
            this.lbl_teamcountry.Name = "lbl_teamcountry";
            this.lbl_teamcountry.Size = new System.Drawing.Size(94, 16);
            this.lbl_teamcountry.TabIndex = 8;
            this.lbl_teamcountry.Text = "Team Country:";
            // 
            // lbl_teamcity
            // 
            this.lbl_teamcity.AutoSize = true;
            this.lbl_teamcity.Location = new System.Drawing.Point(346, 197);
            this.lbl_teamcity.Name = "lbl_teamcity";
            this.lbl_teamcity.Size = new System.Drawing.Size(71, 16);
            this.lbl_teamcity.TabIndex = 9;
            this.lbl_teamcity.Text = "Team City:";
            // 
            // lbl_playername
            // 
            this.lbl_playername.AutoSize = true;
            this.lbl_playername.Location = new System.Drawing.Point(628, 101);
            this.lbl_playername.Name = "lbl_playername";
            this.lbl_playername.Size = new System.Drawing.Size(89, 16);
            this.lbl_playername.TabIndex = 10;
            this.lbl_playername.Text = "Player Name:";
            // 
            // lbl_playernum
            // 
            this.lbl_playernum.AutoSize = true;
            this.lbl_playernum.Location = new System.Drawing.Point(628, 149);
            this.lbl_playernum.Name = "lbl_playernum";
            this.lbl_playernum.Size = new System.Drawing.Size(100, 16);
            this.lbl_playernum.TabIndex = 11;
            this.lbl_playernum.Text = "Player Number:";
            // 
            // lbl_playerpos
            // 
            this.lbl_playerpos.AutoSize = true;
            this.lbl_playerpos.Location = new System.Drawing.Point(628, 197);
            this.lbl_playerpos.Name = "lbl_playerpos";
            this.lbl_playerpos.Size = new System.Drawing.Size(100, 16);
            this.lbl_playerpos.TabIndex = 12;
            this.lbl_playerpos.Text = "Player Position:";
            // 
            // textBox_tname
            // 
            this.textBox_tname.Location = new System.Drawing.Point(452, 98);
            this.textBox_tname.Name = "textBox_tname";
            this.textBox_tname.Size = new System.Drawing.Size(145, 22);
            this.textBox_tname.TabIndex = 13;
            // 
            // textBox_tcountry
            // 
            this.textBox_tcountry.Location = new System.Drawing.Point(452, 146);
            this.textBox_tcountry.Name = "textBox_tcountry";
            this.textBox_tcountry.Size = new System.Drawing.Size(145, 22);
            this.textBox_tcountry.TabIndex = 14;
            // 
            // textBox_tcity
            // 
            this.textBox_tcity.Location = new System.Drawing.Point(452, 194);
            this.textBox_tcity.Name = "textBox_tcity";
            this.textBox_tcity.Size = new System.Drawing.Size(145, 22);
            this.textBox_tcity.TabIndex = 15;
            // 
            // textBox_pname
            // 
            this.textBox_pname.Location = new System.Drawing.Point(734, 98);
            this.textBox_pname.Name = "textBox_pname";
            this.textBox_pname.Size = new System.Drawing.Size(145, 22);
            this.textBox_pname.TabIndex = 16;
            // 
            // textBox_pnum
            // 
            this.textBox_pnum.Location = new System.Drawing.Point(734, 146);
            this.textBox_pnum.Name = "textBox_pnum";
            this.textBox_pnum.Size = new System.Drawing.Size(145, 22);
            this.textBox_pnum.TabIndex = 17;
            // 
            // comboBox_country
            // 
            this.comboBox_country.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_country.FormattingEnabled = true;
            this.comboBox_country.Location = new System.Drawing.Point(178, 115);
            this.comboBox_country.Name = "comboBox_country";
            this.comboBox_country.Size = new System.Drawing.Size(134, 24);
            this.comboBox_country.TabIndex = 19;
            this.comboBox_country.SelectionChangeCommitted += new System.EventHandler(this.comboBox_country_SelectionChangeCommitted);
            // 
            // comboBox_team
            // 
            this.comboBox_team.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(178, 181);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(134, 24);
            this.comboBox_team.TabIndex = 20;
            this.comboBox_team.SelectionChangeCommitted += new System.EventHandler(this.comboBox_team_SelectionChangeCommitted);
            // 
            // btn_addteam
            // 
            this.btn_addteam.Location = new System.Drawing.Point(452, 245);
            this.btn_addteam.Name = "btn_addteam";
            this.btn_addteam.Size = new System.Drawing.Size(75, 23);
            this.btn_addteam.TabIndex = 21;
            this.btn_addteam.Text = "Add";
            this.btn_addteam.UseVisualStyleBackColor = true;
            this.btn_addteam.Click += new System.EventHandler(this.btn_addteam_Click);
            // 
            // btn_addplayer
            // 
            this.btn_addplayer.Location = new System.Drawing.Point(734, 245);
            this.btn_addplayer.Name = "btn_addplayer";
            this.btn_addplayer.Size = new System.Drawing.Size(75, 23);
            this.btn_addplayer.TabIndex = 22;
            this.btn_addplayer.Text = "Add";
            this.btn_addplayer.UseVisualStyleBackColor = true;
            this.btn_addplayer.Click += new System.EventHandler(this.btn_addplayer_Click);
            // 
            // comboBox_position
            // 
            this.comboBox_position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_position.FormattingEnabled = true;
            this.comboBox_position.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBox_position.Location = new System.Drawing.Point(734, 194);
            this.comboBox_position.Name = "comboBox_position";
            this.comboBox_position.Size = new System.Drawing.Size(145, 24);
            this.comboBox_position.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 450);
            this.Controls.Add(this.comboBox_position);
            this.Controls.Add(this.btn_addplayer);
            this.Controls.Add(this.btn_addteam);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.comboBox_country);
            this.Controls.Add(this.textBox_pnum);
            this.Controls.Add(this.textBox_pname);
            this.Controls.Add(this.textBox_tcity);
            this.Controls.Add(this.textBox_tcountry);
            this.Controls.Add(this.textBox_tname);
            this.Controls.Add(this.lbl_playerpos);
            this.Controls.Add(this.lbl_playernum);
            this.Controls.Add(this.lbl_playername);
            this.Controls.Add(this.lbl_teamcity);
            this.Controls.Add(this.lbl_teamcountry);
            this.Controls.Add(this.lbl_teamname);
            this.Controls.Add(this.lbl_addplayers);
            this.Controls.Add(this.lbl_addteam);
            this.Controls.Add(this.btn_removeplayer);
            this.Controls.Add(this.list_players);
            this.Controls.Add(this.lbl_chooseteam);
            this.Controls.Add(this.lbl_choosecountry);
            this.Controls.Add(this.lbl_soccerteam);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_soccerteam;
        private System.Windows.Forms.Label lbl_choosecountry;
        private System.Windows.Forms.Label lbl_chooseteam;
        private System.Windows.Forms.ListBox list_players;
        private System.Windows.Forms.Button btn_removeplayer;
        private System.Windows.Forms.Label lbl_addteam;
        private System.Windows.Forms.Label lbl_addplayers;
        private System.Windows.Forms.Label lbl_teamname;
        private System.Windows.Forms.Label lbl_teamcountry;
        private System.Windows.Forms.Label lbl_teamcity;
        private System.Windows.Forms.Label lbl_playername;
        private System.Windows.Forms.Label lbl_playernum;
        private System.Windows.Forms.Label lbl_playerpos;
        private System.Windows.Forms.TextBox textBox_tname;
        private System.Windows.Forms.TextBox textBox_tcountry;
        private System.Windows.Forms.TextBox textBox_tcity;
        private System.Windows.Forms.TextBox textBox_pname;
        private System.Windows.Forms.TextBox textBox_pnum;
        private System.Windows.Forms.ComboBox comboBox_country;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.Button btn_addteam;
        private System.Windows.Forms.Button btn_addplayer;
        private System.Windows.Forms.ComboBox comboBox_position;
    }
}


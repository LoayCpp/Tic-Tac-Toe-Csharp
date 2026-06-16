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
using Tic_Tac_Toe.Properties;

namespace Tic_Tac_Toe
{
    public partial class Form1 : Form
    {
        enum enRole
        {
            ePlayer1,
            ePlayer2

        };
        struct stPlayers
        {
           public string name;
            public short win;
            
        };

        stPlayers player1 = new stPlayers();
        stPlayers player2 = new stPlayers();
        enRole playerWhat = enRole.ePlayer1;
        int counter = 0;
        int draw = 0;
        PictureBox [,] array=new PictureBox[3,3];
       
        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            player1.name = "Player X";
            player1.win = 0;
            player2.name = "Player O";
            player2.win = 0;
            array = new PictureBox[,]
            {
                {picture1,picture2,picture3 },
                {picture4,picture5,picture6 },
                {picture7,picture8,picture9 }


            };
        

        }
        bool IsImageTagEqual(PictureBox firstPictureBox, PictureBox secondPictureBox)
        {
            if((firstPictureBox!=null && secondPictureBox != null )&& (firstPictureBox.Tag!="?" && secondPictureBox.Tag!="?"))
            {
                string Tag1 = firstPictureBox.Tag.ToString();
                string Tag2 = secondPictureBox.Tag.ToString();
                return (Tag1 == Tag2);
            }

            return false;

           



        }
        void SetColorForImage(PictureBox pictureBox,PictureBox pictureBox1,PictureBox pictureBox2)
        {

            pictureBox2.BackColor = pictureBox1.BackColor = pictureBox.BackColor = Color.Green;

        }
        string SetWinner(PictureBox pictureBox)
        {


            if (pictureBox.Tag == "X")
            {

                return player1.name;
            }
            return player2.name;
        }
        void ResetScore()
        {


            player1.win = 0;
            player2.win = 0;
            draw = 0;

            lblDraw.Text = draw.ToString();
            lblPlayerXwin.Text = player1.win.ToString();
            lblPlayerOwin.Text = player1.win.ToString();



        }
        void Reset()
        {

            List<PictureBox> lPictureBoxes = new List<PictureBox> { picture1, picture2, picture3, picture4, picture5, picture6, picture7, picture8, picture9 };

            foreach(PictureBox picture in lPictureBoxes)
            {

                picture.Image = Resources.question_mark_96;
                picture.BackColor = Color.Transparent;
                picture.Tag = "?";
            }
            lblWinner.Text = "In Prograss";
            lblTurn.Text ="Player1";
            playerWhat = enRole.ePlayer1;
            counter = 0;
            picTurn.Image = Resources.X;
            
        }
        void ShowMessageBoxWinner()
        {

           if(MessageBox.Show($"Winner Is {lblWinner.Text}") == DialogResult.OK)
            {
                Reset();
            }


        }
       void HowMuchPlayerWin()
        {
            if(lblWinner.Text == player1.name)
            {

                player1.win++;
                lblPlayerXwin.Text = player1.win.ToString();
                return;

            }
            if (lblWinner.Text == player2.name)
            {

                player2.win++;
                lblPlayerOwin.Text = player2.win.ToString();

                return;

            }
           
          


        }
        bool CheckRowsAndColumns(PictureBox[,] pictureBoxes)
        {

            for(int i = 0; i < 3; i++)
            {
              if(IsImageTagEqual(pictureBoxes[i,0], pictureBoxes[i,1])&& IsImageTagEqual(pictureBoxes[i, 1], pictureBoxes[i, 2]))
                {
                    SetColorForImage(pictureBoxes[i, 0], pictureBoxes[i, 1], pictureBoxes[i, 2]);
                    lblWinner.Text = SetWinner(pictureBoxes[i, 0]);
                    HowMuchPlayerWin();
                    ShowMessageBoxWinner();
                    return true;

                }

                if (IsImageTagEqual(pictureBoxes[0, i], pictureBoxes[1, i]) && IsImageTagEqual(pictureBoxes[1, i], pictureBoxes[2, i]))
                {
                    SetColorForImage(pictureBoxes[0, i], pictureBoxes[1, i], pictureBoxes[2, i]);
                    lblWinner.Text = SetWinner(pictureBoxes[0, i]);
                    HowMuchPlayerWin();
                    ShowMessageBoxWinner();
                    return true;

                }


            }
            return false;


        }
        bool CheckMainDiagonal(PictureBox[,] pictureBoxes)
        {

             if (IsImageTagEqual(pictureBoxes[0, 0], pictureBoxes[1, 1]) && IsImageTagEqual(pictureBoxes[1, 1], pictureBoxes[2, 2]))
                {
                    SetColorForImage(pictureBoxes[0, 0], pictureBoxes[1, 1], pictureBoxes[2, 2]);
                    lblWinner.Text = SetWinner(pictureBoxes[0, 0]);
                HowMuchPlayerWin();
                ShowMessageBoxWinner();

                    return true;

                }

            return false;

        }
        bool CheckAntiDiagonal(PictureBox[,] pictureBoxes)
        {

            if (IsImageTagEqual(pictureBoxes[0, 2], pictureBoxes[1, 1]) && IsImageTagEqual(pictureBoxes[1, 1], pictureBoxes[2,0]))
            {
                SetColorForImage(pictureBoxes[0, 2], pictureBoxes[1, 1], pictureBoxes[2, 0]);
                lblWinner.Text = SetWinner(pictureBoxes[0, 2]);
                HowMuchPlayerWin();
                ShowMessageBoxWinner();
                return true;

            }

            return false;

        }
        void CheckGameRules(PictureBox[,] pictureBoxes )
        {
            if (counter < 5)
                return;



            if (CheckRowsAndColumns(pictureBoxes))
            {

                return;
            }

            if (CheckMainDiagonal(pictureBoxes))
            {

                return;
            }
            if (CheckAntiDiagonal(pictureBoxes))
            {

                return;
            }

            if (counter == 9)
            {

                lblWinner.Text = "Draw";
                ShowMessageBoxWinner();
                draw++;
                lblDraw.Text = draw.ToString();
                return;
            }
        }
        bool AreImageChecked(object sender)
        {
            PictureBox picture = ((PictureBox)sender);
            if  (picture.Tag=="O" || picture.Tag == "X"){


                MessageBox.Show("You cant choose it", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return true;
            }
            return false;

        }
        void ConvertPlayers(object sender)
        {
            PictureBox picture = ((PictureBox)sender);
            switch (playerWhat)
            {
                case enRole.ePlayer1:
                    picture.Tag = "X";
                    picture.Image = Resources.X;
                    picTurn.Image = Resources.O;
                    playerWhat =enRole.ePlayer2;
                    lblTurn.Text = player2.name;
                    break;


                case enRole.ePlayer2:
                    picture.Tag = "O";
                    lblTurn.Text = player1.name;
                    picTurn.Image = Resources.X;
                    picture.Image = Resources.O;


                    playerWhat =enRole.ePlayer1 ;
                    break;
            }

         


        }

     
      
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void Pictures_Click(object sender,EventArgs e)
        {
            if (AreImageChecked(sender))
            {

                return;
            }
            ConvertPlayers(sender);

            counter++;
            CheckGameRules(array);



        }
 
        private void btnRestartScore_Click(object sender, EventArgs e)
        {
            Reset();
            ResetScore();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void ContactMe(string fileName)
        {
            Process.Start(new ProcessStartInfo { FileName = fileName, UseShellExecute = true });

        }
        private void picLinkedln_Click(object sender, EventArgs e)
        {
            ContactMe("www.linkedin.com/in/luai-anwar");
        }

        private void picGithub_Click(object sender, EventArgs e)
        {
            ContactMe("https://github.com/LoayCpp");
        }

        private void PicX_Click(object sender, EventArgs e)
        {

            ContactMe("https://x.com/7lo_ay");
        }
    }
}

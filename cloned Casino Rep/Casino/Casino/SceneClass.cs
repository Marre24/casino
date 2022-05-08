using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casino
{
    class SceneClass
    {
        public void StartScene(Label Lbl_password, Label Lbl_username, Button Btn_Login, Button Btn_CreateLogin, CostomTextBox Tb_Password, CostomTextBox Tb_UserName)
        {
            Lbl_password.Text = "Enter your Password";
            Lbl_username.Text = "Enter your Username";
            Lbl_password.Show();
            Lbl_username.Show();
            Btn_Login.Show();
            Btn_CreateLogin.Show();
            Tb_Password.Show();
            Tb_UserName.Show();
        }

        public void LobbyScene(PictureBox Pb_Background, string lobbyImage)
        {
            Pb_Background.Image = Image.FromFile(lobbyImage);
        }

        public void UsercreateScene(Label Lbl_password, Label Lbl_username, Button Btn_Return, Button Btn_NewLoginInformation, CostomTextBox Tb_Password, CostomTextBox Tb_UserName)
        {
            Lbl_password.Text = "Select new Password";
            Lbl_username.Text = "Select new Username";
            Lbl_password.Show();
            Lbl_username.Show();

            Tb_UserName.Show();
            Tb_Password.Show();

            Btn_NewLoginInformation.Show();
            Btn_Return.Show();
        }

        public void AcconutMangementScene(Label Lbl_AccontBalance, Label Lbl_PasswordInfo, Label Lbl_UsernameInfo, Button Btn_GoToLobby, string username, string password, int balance, Button Btn_LogOut)
        {
            Lbl_UsernameInfo.Show();
            Lbl_PasswordInfo.Show();
            Lbl_AccontBalance.Show();
            Btn_GoToLobby.Show();
            Lbl_UsernameInfo.Text = "Username: " + username;
            Lbl_PasswordInfo.Text = "Password: " + password;
            Lbl_AccontBalance.Text = "Balance: " + balance.ToString();
            Btn_LogOut.Show();
        }

        public void LobbyStartScene(Button Btn_BlackJack, Button Btn_Poker, Button Btn_Slots, PictureBox Pb_Background)
        {
            Btn_Poker.Show();
            Btn_BlackJack.Show();
            Btn_Slots.Show();
            Pb_Background.Show();
        }


        public void BalanceSelectScene(Button Btn_GoToGame, CostomTextBox Tb_Balance, CostomTextBox Tb_MoneyChosen, PictureBox Pb_Background, ScrollBar Sb_Money)
        {
            Btn_GoToGame.Show();
            Tb_MoneyChosen.Show();
            Tb_Balance.Show();
            Pb_Background.Show();
            Sb_Money.Show();
        }
        public void BlackJackScene(Button Btn_Player1Join, Button Btn_Player2Join, Button Btn_Player3Join, Button Btn_Player4Join, Button Btn_startRound)
        {
            Btn_startRound.Show();
            Btn_Player1Join.Show();
            Btn_Player2Join.Show();
            Btn_Player3Join.Show();
            Btn_Player4Join.Show();

        }

        public void ShowPlayerComponents(Button Btn_PlayerHit, Button Btn_PlayerJoin, Button Btn_PlayerStand, CostomTextBox Tb_PlayerUsername)
        {
            Btn_PlayerHit.Show();
            Btn_PlayerJoin.Hide();
            Btn_PlayerStand.Show();
            Tb_PlayerUsername.Show();
        }

        public void RoundScene(List<Player> activePlayers,PictureBox Pb_DealerLeftCard, PictureBox Pb_DealerRightCard, PictureBox Pb_Player1LeftCard, PictureBox Pb_Player1RightCard, PictureBox Pb_Player2LeftCard, PictureBox Pb_Player2RightCard, PictureBox Pb_Player3LeftCard, PictureBox Pb_Player3RightCard, PictureBox Pb_Player4LeftCard, PictureBox Pb_Player4RightCard, CostomTextBox Tb_Player1SumValue, CostomTextBox Tb_Player2SumValue, CostomTextBox Tb_Player3SumValue, CostomTextBox Tb_Player4SumValue)
        {
            Pb_DealerLeftCard.Show();
            Pb_DealerRightCard.Show(); 
            if (activePlayers.Count > 0)
            {
                Pb_Player1LeftCard.Show();
                Pb_Player1RightCard.Show();
                Tb_Player1SumValue.Show();
            }
            if (activePlayers.Count > 1)
            {
                Pb_Player2LeftCard.Show();
                Pb_Player2RightCard.Show();
                Tb_Player2SumValue.Show();
            }
            if (activePlayers.Count > 2)
            {
                Pb_Player3LeftCard.Show();
                Pb_Player3RightCard.Show();
                Tb_Player3SumValue.Show();
            }
            if (activePlayers.Count > 3)
            {
                Pb_Player4LeftCard.Show();
                Pb_Player4RightCard.Show();
                Tb_Player4SumValue.Show();
            }
        }
        public void BustScene(Button Btn_PlayerHit, Button Btn_PlayerStand)
        {
            Btn_PlayerHit.Hide();
            Btn_PlayerStand.Hide();
        }

        public void StandScene(Button Btn_PlayerHit, Button Btn_PlayerStand)
        {
            Btn_PlayerHit.Hide();
            Btn_PlayerStand.Hide();
        }

        public void BettingScene(PictureBox Pb_ChipBlack,PictureBox Pb_ChipBlue, PictureBox Pb_ChipPink, PictureBox Pb_ChipRed, Button Btn_ClearBet, CostomTextBox Tb_100, CostomTextBox Tb_1000, CostomTextBox Tb_500 , CostomTextBox Tb_2000, CostomTextBox Tb_BetText, CostomTextBox Tb_Bet)
        {
            Pb_ChipPink.Show();
            Pb_ChipBlack.Show();
            Pb_ChipBlue.Show();
            Pb_ChipRed.Show();
            Btn_ClearBet.Show();
            Tb_2000.Show();
            Tb_500.Show();
            Tb_1000.Show();
            Tb_100.Show();
            Tb_BetText.Show();
            Tb_Bet.Show();
        }

        public void EndRoundScene()
        {



        }

    }
}

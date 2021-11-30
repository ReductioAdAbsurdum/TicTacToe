using GUI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using TicTacToeCore;
using TicTacToeCore.Engine;
using TicTacToeCore.Models;


namespace GUI
{
    
    public partial class GameForm : Form
    {
        #region Constants
        private const int afterMoveDelay = 100;
        private const int afterGameDelay = 1500;    
        #endregion

        #region Constructor
        public GameForm()
        {
            InitializeComponent();

            InitializePictureBoxes();
            InitializePictureBoxDictionary();
            SetTimer();
        }
        #endregion

        #region Fields

        GameStateModel game = new GameStateModel();
        List<PictureBox> pictureBoxes = new List<PictureBox>();
        ScoreBoard scoreX = new ScoreBoard();
        ScoreBoard scoreO = new ScoreBoard();
        Dictionary<PositionModel, PictureBox> pictureBoxDictionary = new Dictionary<PositionModel, PictureBox>();

        IEngine engine = new MinMaxAlgorithm();

        Name First = TicTacToeCore.Models.Name.X;

        bool gameInProgress = true;

        bool botX = false;
        bool botO = false;

        int botXLevel = 9;
        int botOLevel = 9;


        private Timer nextMoveTimer = new Timer();
        private Timer nextGameTimer = new Timer();
        #endregion

        #region Propertis

        public bool PlayersTurn 
        { get 
            {
                if (game.Turn == TicTacToeCore.Models.Name.X && !botX)
                {
                    return true;
                }
                if (game.Turn == TicTacToeCore.Models.Name.O && !botO)
                {
                    return true;
                }
                return false;
            } 
        }
        public int BotLevel 
        { get 
            {
                if (game.Turn == TicTacToeCore.Models.Name.X)
                {
                    return botXLevel;
                }
                else
                {
                    return botOLevel;
                }
            } 
        }
        #endregion       
        
        #region Initialization
        private void InitializePictureBoxes() 
        {
            pictureBoxes.Add(A1pictureBox);
            pictureBoxes.Add(B1pictureBox);
            pictureBoxes.Add(C1pictureBox);
            
            pictureBoxes.Add(A2pictureBox);
            pictureBoxes.Add(B2pictureBox);
            pictureBoxes.Add(C2pictureBox);
            
            pictureBoxes.Add(A3pictureBox);
            pictureBoxes.Add(B3pictureBox);
            pictureBoxes.Add(C3pictureBox);

            xBotPictureBox.Image = Resources.WhiteRobot;
            oBotPictureBox.Image = Resources.WhiteRobot;
        }
        private void InitializePictureBoxDictionary() 
        {
            pictureBoxDictionary.Add(new PositionModel(1, 1), A1pictureBox);
            pictureBoxDictionary.Add(new PositionModel(2, 1), B1pictureBox);
            pictureBoxDictionary.Add(new PositionModel(3, 1), C1pictureBox);

            pictureBoxDictionary.Add(new PositionModel(1, 2), A2pictureBox);
            pictureBoxDictionary.Add(new PositionModel(2, 2), B2pictureBox);
            pictureBoxDictionary.Add(new PositionModel(3, 2), C2pictureBox);

            pictureBoxDictionary.Add(new PositionModel(1, 3), A3pictureBox);
            pictureBoxDictionary.Add(new PositionModel(2, 3), B3pictureBox);
            pictureBoxDictionary.Add(new PositionModel(3, 3), C3pictureBox);
        }
        #endregion

        #region Form Game Logic
        
        private void PlayerMove(PositionModel position)
        {
            if (PlayersTurn && gameInProgress)
            {
                game.MakeMove(position);
                
                if (game.GameIsFinished())
                {
                    gameInProgress = false;
                    RefreshGamePictures();
                    nextGameTimer.Start();
                }
                else
                {
                    RefreshGamePictures();
                    nextMoveTimer.Start();
                }
            }
        }
        private void BotMove() 
        {
            if (!PlayersTurn && gameInProgress)
            {
                game.MakeMove(engine.GetNextMove_SelectDepth(game, BotLevel));

                if (game.GameIsFinished())
                {
                    gameInProgress = false;
                    RefreshGamePictures();
                    nextGameTimer.Start();

                }
                else
                {
                    RefreshGamePictures();
                    nextMoveTimer.Start();
                }
                
            }
        }     
        
        private void GameFinished() 
        {
            if (game.Winner() == TicTacToeCore.Models.Name.X)
            {
                // TODO - Draw line
                scoreX.Increase();
            }
            if (game.Winner() == TicTacToeCore.Models.Name.O)
            {
                // TODO - Draw line
                scoreO.Increase();
            }
                
            game = new GameStateModel();
            game.Turn = First;
        }
        
        #endregion

        #region Game PictureBox Click
        private void A3pictureBox_Click(object sender, EventArgs e)
        {
            PlayerMove(new PositionModel(1, 3));
        }

        private void B3pictureBox_Click(object sender, EventArgs e)
        {
            PlayerMove(new PositionModel(2, 3));
        }

        private void C3pictureBox_Click(object sender, EventArgs e)
        {
            PlayerMove(new PositionModel(3, 3));
        }

        private void A2pictureBox_Click(object sender, EventArgs e)
        {
            PlayerMove(new PositionModel(1, 2));
        }

        private void B2pictureBox_Click(object sender, EventArgs e)
        {
            PlayerMove(new PositionModel(2, 2));
        }

        private void C2pictureBox_Click(object sender, EventArgs e)
        {
            PlayerMove(new PositionModel(3, 2));
        }

        private void A1pictureBox_Click(object sender, EventArgs e)
        {
            PlayerMove(new PositionModel(1, 1));
        }

        private void B1pictureBox_Click(object sender, EventArgs e)
        {
            PlayerMove(new PositionModel(2, 1));
        }

        private void C1pictureBox_Click(object sender, EventArgs e)
        {
            PlayerMove(new PositionModel(3, 1));
        }
        #endregion

        #region Game Pictures
        private void RefreshGamePictures()
        {
            foreach (var pb in pictureBoxes)
            {
                pb.Image = null;
            }
            foreach (var p in game.Pieces)
            {
                DrawPiece(p);
            }

            RefreshScoreBoard();
            HighlightTurn();
        }
        private void RefreshScoreBoard()
        {
            xFirstLabel.Text = scoreX.FirstDigit.ToString();
            xSecoundLabel.Text = scoreX.SecoundtDigit.ToString();
            xThirdLabel.Text = scoreX.ThirdDigit.ToString();

            oFirstLabel.Text = scoreO.FirstDigit.ToString();
            oSecoundLabel.Text = scoreO.SecoundtDigit.ToString();
            oThirdLabel.Text = scoreO.ThirdDigit.ToString();
        }
        private void HighlightTurn() 
        {
            if (game.Turn == TicTacToeCore.Models.Name.X)
            {
                xScoreLabel.ForeColor = Color.FromArgb(0, 0, 153);
                oScoreLabel.ForeColor = Color.FromArgb(250, 60, 60);
            }
            else 
            {
                oScoreLabel.ForeColor = Color.FromArgb(203, 2, 2);
                xScoreLabel.ForeColor = Color.FromArgb(80, 80, 153);
            }
        }
        private void DrawPiece(PieceModel piece)
        {
            pictureBoxDictionary.Where(x => x.Key.Equals(piece.Position)).First().Value.Image = GetImage(piece.PieceName);
        }
        private Bitmap GetImage(Name name)
        {
            switch (name)
            {

                case TicTacToeCore.Models.Name.X:
                    return Resources.X;
                case TicTacToeCore.Models.Name.O:
                    return Resources.O;
                default:
                    return null;
            }
        }
        #endregion

        #region Change Turn
        private void xScoreLabel_Click(object sender, EventArgs e)
        {
            if (game.Turn == TicTacToeCore.Models.Name.O && game.Pieces.Count == 0)
            {
                game.Turn = TicTacToeCore.Models.Name.X; 
                First = TicTacToeCore.Models.Name.X;
                
                HighlightTurn();

                if (botX) BotMove();
            }  
        }
        private void oScoreLabel_Click(object sender, EventArgs e)
        {
            if (game.Turn == TicTacToeCore.Models.Name.X && game.Pieces.Count == 0)
            {
                game.Turn = TicTacToeCore.Models.Name.O;
                First = TicTacToeCore.Models.Name.O;

                HighlightTurn();

                if (botO) BotMove();
            }
        }
        #endregion
        
        #region Bot On/Of
        private void xBotPictureBox_Click(object sender, EventArgs e)
        {
            if (botX)
            {
                botX = false;
                xBotPictureBox.Image = Resources.WhiteRobot;
            }
            else
            {
                botX = true;
                xBotPictureBox.Image = Resources.BlueRobot;

                BotMove();
            }
        }

        private void oBotPictureBox_Click(object sender, EventArgs e)
        {
            if (botO)
            {
                botO = false;
                oBotPictureBox.Image = Resources.WhiteRobot;
            }
            else
            {
                botO = true;
                oBotPictureBox.Image = Resources.RedRobot;
                BotMove();
            }
        }
        #endregion

        #region Bot Levels
        private void blueUpPictureBox_Click(object sender, EventArgs e)
        {
            if (botXLevel == 9)
            {
                botXLevel = 1;
            }
            else
            {
                botXLevel++;
            }
            UpdateBlueBotLevelLabel();
        }
        private void blueDownPictureBox_Click(object sender, EventArgs e)
        {
            if (botXLevel == 1)
            {
                botXLevel = 9;
            }
            else
            {
                botXLevel--;
            }
            UpdateBlueBotLevelLabel();
        }
        private void UpdateBlueBotLevelLabel()
        {
            blueBotLevelLabel.Text = botXLevel.ToString();
        }
        private void redUpPictureBox_Click(object sender, EventArgs e)
        {
            if (botOLevel == 9)
            {
                botOLevel = 1;
            }
            else
            {
                botOLevel++;
            }
            UpdateRedBotLevelLabel();
        }
        private void redDownPictureBox_Click(object sender, EventArgs e)
        {
            if (botOLevel == 1)
            {
                botOLevel = 9;
            }
            else
            {
                botOLevel--;
            }
            UpdateRedBotLevelLabel();
        }
        
        private void UpdateRedBotLevelLabel()
        {
            redBotLevelLabel.Text = botOLevel.ToString();
        }

        #endregion

        #region Control Panel
        private void ResetScorePicturebox_Click(object sender, EventArgs e)
        {
            scoreO.Score = 0;
            scoreX.Score = 0;
            RefreshScoreBoard();
        }  
        private void newGamePicturebox_Click(object sender, EventArgs e)
        {
            game = new GameStateModel();
            game.Turn = First;           

            RefreshGamePictures();
        }
        #endregion

        #region Timer
        private void SetTimer()
        {

            nextMoveTimer = new Timer();
            nextGameTimer = new Timer();

            nextMoveTimer.Interval = afterMoveDelay;
            nextGameTimer.Interval = afterGameDelay;
            
            nextMoveTimer.Tick += new EventHandler(AfterMoveTick);
            nextGameTimer.Tick += new EventHandler(AfterGameTick);


            nextMoveTimer.Start();
        }
        private void AfterMoveTick(object myObject, EventArgs myEventArgs)
        {
            nextMoveTimer.Stop();
            BotMove();
        }
        private void AfterGameTick(object myObject, EventArgs myEventArgs)
        {
            nextGameTimer.Stop();

            GameFinished();
            RefreshGamePictures();
            gameInProgress = true;
            nextMoveTimer.Start();
        }
        #endregion
    
    }
}

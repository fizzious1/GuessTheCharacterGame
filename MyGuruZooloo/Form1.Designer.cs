using System.Data;

namespace MyGuruZooloo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;



        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        //ToolBox Componenets Decleration
        private Label delWrongOptsLabel;
        private Label questionsRemainLabel;
        private Label clickOnQuestionLabel;
        private Label guesstheCharLabel;
        private PictureBox pictureBox1;
        private TextBox charcterGuessInputTB;
        private Button checkCharacterButton;
        private Button newGameButton;
        private ListBox questionsLB;
        private ListBox remainingCharsLB;
        private ListBox deletedCharsLB;
        private FlowLayoutPanel questionsUsedFP;
        private Label deletedCharLabel;


        //ToolBox Componenets Initializer
        private void InitializeComponent()
        {
            delWrongOptsLabel = new Label();
            questionsRemainLabel = new Label();
            clickOnQuestionLabel = new Label();
            guesstheCharLabel = new Label();
            pictureBox1 = new PictureBox();
            charcterGuessInputTB = new TextBox();
            checkCharacterButton = new Button();
            newGameButton = new Button();
            questionsLB = new ListBox();
            remainingCharsLB = new ListBox();
            questionsUsedFP = new FlowLayoutPanel();
            deletedCharsLB = new ListBox();
            deletedCharLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // delWrongOptsLabel
            // 
            delWrongOptsLabel.AutoSize = true;
            delWrongOptsLabel.Location = new Point(11, 29);
            delWrongOptsLabel.Name = "delWrongOptsLabel";
            delWrongOptsLabel.Size = new Size(138, 20);
            delWrongOptsLabel.TabIndex = 0;
            delWrongOptsLabel.Text = "Characters Remains";
            // 
            // questionsRemainLabel
            // 
            questionsRemainLabel.AutoSize = true;
            questionsRemainLabel.Location = new Point(184, 29);
            questionsRemainLabel.Name = "questionsRemainLabel";
            questionsRemainLabel.Size = new Size(154, 20);
            questionsRemainLabel.TabIndex = 1;
            questionsRemainLabel.Text = "10 Questions Remains";
           
            // 
            // clickOnQuestionLabel
            // 
            clickOnQuestionLabel.AutoSize = true;
            clickOnQuestionLabel.Location = new Point(413, 29);
            clickOnQuestionLabel.Name = "clickOnQuestionLabel";
            clickOnQuestionLabel.Size = new Size(134, 20);
            clickOnQuestionLabel.TabIndex = 2;
            clickOnQuestionLabel.Text = "Click on a question";
            // 
            // guesstheCharLabel
            // 
            guesstheCharLabel.AutoSize = true;
            guesstheCharLabel.Location = new Point(617, 29);
            guesstheCharLabel.Name = "guesstheCharLabel";
            guesstheCharLabel.Size = new Size(142, 20);
            guesstheCharLabel.TabIndex = 3;
            guesstheCharLabel.Text = "Guess The Character";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(617, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(142, 95);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // charcterGuessInputTB
            // 
            charcterGuessInputTB.Location = new Point(617, 223);
            charcterGuessInputTB.Name = "charcterGuessInputTB";
            charcterGuessInputTB.PlaceholderText = "Guess a Character";
            charcterGuessInputTB.Size = new Size(142, 27);
            charcterGuessInputTB.TabIndex = 5;
            charcterGuessInputTB.TextChanged += CharcterGuessInputTB_TextChanged;
            // 
            // checkCharacterButton
            // 
            checkCharacterButton.Location = new Point(641, 276);
            checkCharacterButton.Name = "checkCharacterButton";
            checkCharacterButton.Size = new Size(94, 29);
            checkCharacterButton.TabIndex = 6;
            checkCharacterButton.Text = "Check";
            checkCharacterButton.UseVisualStyleBackColor = true;
            checkCharacterButton.Click += button1_Click;
            // 
            // newGameButton
            // 
            newGameButton.Location = new Point(641, 335);
            newGameButton.Name = "newGameButton";
            newGameButton.Size = new Size(94, 29);
            newGameButton.TabIndex = 7;
            newGameButton.Text = "New Game";
            newGameButton.UseVisualStyleBackColor = true;
            newGameButton.Click += newGameButton_Click;
            // 
            // questionsLB
            // 
            questionsLB.FormattingEnabled = true;
            questionsLB.ItemHeight = 20;
            questionsLB.Location = new Point(413, 85);
            questionsLB.Name = "questionsLB";
            questionsLB.Size = new Size(198, 264);
            questionsLB.TabIndex = 8;
            questionsLB.SelectedIndexChanged += QuestionsLB_SelectedIndexChanged;
            // 
            // remainingCharsLB
            // 
            remainingCharsLB.FormattingEnabled = true;
            remainingCharsLB.ItemHeight = 20;
            remainingCharsLB.Location = new Point(15, 85);
            remainingCharsLB.Name = "remainingCharsLB";
            remainingCharsLB.Size = new Size(150, 164);
            remainingCharsLB.Sorted = true;
            remainingCharsLB.TabIndex = 9;
            remainingCharsLB.SelectedIndexChanged += RemainingCharsLB_SelectedIndexChanged;
            // 
            // questionsUsedFP
            // 
            questionsUsedFP.AutoScroll = true;
            questionsUsedFP.FlowDirection = FlowDirection.TopDown;
            questionsUsedFP.Location = new Point(184, 85);
            questionsUsedFP.Name = "questionsUsedFP";
            questionsUsedFP.RightToLeft = RightToLeft.Yes;
            questionsUsedFP.Size = new Size(223, 264);
            questionsUsedFP.TabIndex = 10;
            // 
            // deletedCharsLB
            // 
            deletedCharsLB.FormattingEnabled = true;
            deletedCharsLB.ItemHeight = 20;
            deletedCharsLB.Location = new Point(15, 315);
            deletedCharsLB.Name = "deletedCharsLB";
            deletedCharsLB.Size = new Size(150, 84);
            deletedCharsLB.Sorted = true;
            deletedCharsLB.TabIndex = 11;
            deletedCharsLB.SelectedIndexChanged += DeletedCharsLB_SelectedIndexChanged;
            // 
            // deletedCharLabel
            // 
            deletedCharLabel.AutoSize = true;
            deletedCharLabel.Location = new Point(15, 276);
            deletedCharLabel.Name = "deletedCharLabel";
            deletedCharLabel.Size = new Size(135, 20);
            deletedCharLabel.TabIndex = 12;
            deletedCharLabel.Text = "Characters Deleted";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(deletedCharLabel);
            Controls.Add(deletedCharsLB);
            Controls.Add(questionsUsedFP);
            Controls.Add(remainingCharsLB);
            Controls.Add(questionsLB);
            Controls.Add(newGameButton);
            Controls.Add(checkCharacterButton);
            Controls.Add(charcterGuessInputTB);
            Controls.Add(pictureBox1);
            Controls.Add(guesstheCharLabel);
            Controls.Add(clickOnQuestionLabel);
            Controls.Add(questionsRemainLabel);
            Controls.Add(delWrongOptsLabel);
            Name = "Form1";
            Text = "Guess The Character";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

    }
}
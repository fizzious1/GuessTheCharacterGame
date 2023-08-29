using Microsoft.VisualBasic.FileIO;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace MyGuruZooloo
{
    public partial class Form1 : Form
    {
        string csvFilePath = @"C:\Users\User\source\repos\MyGuruZooloo\MyGuruZooloo\bin\Debug\net7.0-windows\Data\game_dataset.csv";
        /// CsvDataset csv = new CsvDataset();
        DataTable dt;
        int questionsLeft = 10;
        object target;
        int rowChosen;
        string yes = "כן";
        string currCharacter;
        string no = "לא";


        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            Init();
        }


        private void QuestionsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selected;
            string selectedName;
            if (questionsLB.SelectedItem != null)
            {
                selected = questionsLB.SelectedItem;
                selectedName = selected.ToString();
                if (questionsLeft > 0)
                {
                    Label currQuestion = new Label();
                    currQuestion.RightToLeft = RightToLeft.Yes;
                    currQuestion.AutoSize = true;
                    currQuestion.Text = selectedName;
                    Label currAnswer = new Label();
                    currAnswer.RightToLeft = RightToLeft.Yes;
                    currAnswer.AutoSize = true;

                    if (dt.Rows[rowChosen][selectedName].Equals("V"))
                    {
                        currAnswer.Text = yes;
                        currAnswer.ForeColor = System.Drawing.Color.Green;
                    }
                    else
                    {
                        currAnswer.Text = no;
                        currAnswer.ForeColor = System.Drawing.Color.Red;
                    }
                    questionsUsedFP.Controls.Add(currQuestion);
                    questionsUsedFP.Controls.Add(currAnswer);
                    // currQuestion.
                    questionsLeft--;
                    questionsRemainLabel.Text = questionsLeft + " Questions Remains";
                    questionsLB.Items.Remove(selected);


                }
                else System.Windows.Forms.MessageBox.Show("No questions remains. Please Guess A Character");
            }
        }

        private void RemainingCharsLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selected;
            string selectedName;
            if (remainingCharsLB.SelectedItem != null)
            {
                selected = remainingCharsLB.SelectedItem;
                selectedName = selected.ToString();
                remainingCharsLB.Items.Remove(selected);
                deletedCharsLB.Items.Add(selected);

            }

        }

        private void DeletedCharsLB_SelectedIndexChanged(object sender, EventArgs e)
        {

            object selected;
            string selectedName;
            if (deletedCharsLB.SelectedItem != null)
            {
                selected = deletedCharsLB.SelectedItem;
                selectedName = selected.ToString();
                remainingCharsLB.Items.Add(selected);
                deletedCharsLB.Items.Remove(selected);
            }

        }

        private void CharcterGuessInputTB_TextChanged(object sender, EventArgs e)
        {
            currCharacter = charcterGuessInputTB.Text;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (currCharacter == null || currCharacter == "")
                System.Windows.Forms.MessageBox.Show("No Input Inserted, Please Insert Character");
            else
            {
                bool found = false;
                string charTarget = target.ToString();
                found = findInDB(dt, currCharacter);
                if (found)
                {
                    if (currCharacter.Equals(charTarget))
                    {
                        generateWinButton();
                    }
                    else
                    {
                        generateLoseButton();
                    }
                }
                else System.Windows.Forms.MessageBox.Show("No Such Character Exists! Maybe there is a typo", "Oops!");
            }
        }

        private void newGameButton_Click(object sender, EventArgs e)
        {
            Init();
            questionsRemainLabel.Text = questionsLeft + " Questions Remains";
        }

        //----------Added Methods----------//
        private void Init()
        {
            questionsLeft = 10;
            charcterGuessInputTB.Text = "";
            if (remainingCharsLB != null)
                remainingCharsLB.Items.Clear();
            if (deletedCharsLB.Items.Count > 0)
                deletedCharsLB.Items.Clear();
            if (questionsUsedFP.Controls.Count > 0)
                questionsUsedFP.Controls.Clear();
            dt = GetDataTabletFromCSVFile(csvFilePath);
            if (dt == null)
                Application.Exit();


            if (dt != null)
            {

                for (int i = 0; i < dt.Rows.Count; i++)
                    remainingCharsLB.Items.Add(dt.Rows[i]["דמות"]);


                for (int i = 1; i < dt.Columns.Count; i++)
                    questionsLB.Items.Add(dt.Columns[i].ColumnName);
                Random chooseRow = new Random();
                rowChosen = chooseRow.Next(24);

                if (dt.Rows[rowChosen]["דמות"] != null)
                    target = dt.Rows[rowChosen]["דמות"];
            }
        }

        private static DataTable GetDataTabletFromCSVFile(string csv_file_path)
        {
            DataTable csvData = new DataTable();

            try
            {

                using (TextFieldParser csvReader = new TextFieldParser(csv_file_path))
                {
                    csvReader.SetDelimiters(new string[] { "," });
                    csvReader.HasFieldsEnclosedInQuotes = true;
                    string[] colFields = csvReader.ReadFields();
                    foreach (string column in colFields)
                    {
                        DataColumn datecolumn = new DataColumn(column);
                        datecolumn.AllowDBNull = true;
                        csvData.Columns.Add(datecolumn);
                    }

                    while (!csvReader.EndOfData)
                    {
                        string[] fieldData = csvReader.ReadFields();
                        //Making empty value as null
                        for (int i = 0; i < fieldData.Length; i++)
                        {
                            if (fieldData[i] == "")
                            {
                                fieldData[i] = null;
                            }
                        }
                        csvData.Rows.Add(fieldData);
                    }
                }
            }
            catch (Exception ex)
            {
            }
            return csvData;
        }
        private bool findInDB(DataTable dataTable, string name)
        {

            bool found = false;
            for (int i = 0; i < dt.Rows.Count && !found; i++)
            {
                string currChar = dataTable.Rows[i]["דמות"].ToString();
                if (currChar != null)
                {
                    if (currChar.Equals(name))
                        found = true;
                }
            }
            return found;

        }
        private void generateWinButton()
        {
            string message = "You Win! Click Yes to start a new game!";
            string title = "Win!";
            generateYesNoMessageBox(message, title);
        }
        private void generateLoseButton()
        {
            string message = "You Lose! Click on New Game to continue";
            string title = "Lose!";
            generateYesNoMessageBox(message, title);
        }
        private void generateYesNoMessageBox(string message, string title)
        {
            DialogResult result = MessageBox.Show(message, title, MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Init();
                questionsRemainLabel.Text = questionsLeft + " Questions Remains";
            }
            else Application.Exit();
        }

        
    }

}


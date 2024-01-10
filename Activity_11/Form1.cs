namespace Activity_11
{
    public partial class Form1 : Form
    {

        private int check_int;
        private object[] matrices;
        private int[] firtstMatrix, secondMatrix, resultMatrices;
        private int firstNo, secondNo, arrayNo = 0;


        public Form1()
        {
            InitializeComponent();

            arrayNo = 10;
            firtstMatrix = new int[arrayNo];
            secondMatrix = new int[arrayNo];
            resultMatrices = new int[arrayNo];
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
           textInput01.Text = string.Empty;
           textInput02.Text = string.Empty;

            listBoxResult01.Items.Clear();
            listBoxResult02.Items.Clear();
            listBoxResult03.Items.Clear();

            textInput01.Focus();
            
        }

        private void textInput01_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnInsert1.Focus();
            }

        }

        private void textInput02_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                btnInsert2.Focus();
            }

        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            try
            {
                listBoxResult03.Items.Clear();

                foreach (var row in resultMatrices)
                {
                    if(row > 0)
                    {
                        listBoxResult03.Items.Add(row.ToString());
                    }
                    
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnInsert1_Click(object sender, EventArgs e)
        {

            try
            {
                if(int.TryParse(textInput01.Text, out check_int) && firstNo <= (arrayNo - 1))
                {
                    firtstMatrix[firstNo] = (int.Parse(textInput01.Text));
                    listBoxResult01.Items.Add(textInput01.Text);
                    firstNo++;

                    if(firstNo == arrayNo)
                    {
                        matrices[0] = firtstMatrix;
                    }
                }
                else
                {
                    MessageBox.Show("Invalid input value");
                }

                textInput01.Text =  string.Empty;
                textInput01.Focus();

            }
            catch(Exception ex) {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnInsert2_Click(object sender, EventArgs e)
        {

            try
            {
                if (int.TryParse(textInput02.Text, out check_int) && secondNo <= (arrayNo - 1))
                {
                    secondMatrix[secondNo] = (int.Parse(textInput02.Text));
                    int result = (secondMatrix[secondNo] + firtstMatrix[secondNo]);
                    resultMatrices[secondNo] = (result);
                    listBoxResult02.Items.Add(textInput02.Text);
                    secondNo++;

                    if (secondNo == arrayNo)
                    {
                        matrices[1] = secondMatrix;
                        matrices[2] = resultMatrices;

                    }
                }
                else
                {
                    MessageBox.Show("Invalid input value");
                }

                textInput02.Text = string.Empty;
                textInput02.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

    }
}

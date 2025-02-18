using System.Linq;
using System.Text.RegularExpressions;

namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<double[]> MatrixCalc(List<double[]> array, out int count)
        {
            List<double[]> arrayMatrixA = array;
            double val = 0;
            int countCalc = 0;
            
            string infoReport = "«находженн€ оберненоњ матриц≥:\r\n";
            infoReport += "¬х≥дна матриц€:\r\n";

            for (int elX = 0; elX < arrayMatrixA.Count(); elX++)
            {
                
                for (int el = 0; el < arrayMatrixA[elX].Length; el++)
                {
                    infoReport += arrayMatrixA[elX][el];
                    if (el != arrayMatrixA[elX].Length - 1) infoReport += " ";
                }
                if (elX != arrayMatrixA.Count() - 1) infoReport += "\r\n";
            
            }
            infoReport += "\r\nѕротокол обчисленн€:\r\n";
            for (int x = 0; x < arrayMatrixA.Count(); x++)
            {
                if (x >= arrayMatrixA[0].Length) break;
                val = arrayMatrixA[x][x];
                if (Math.Abs(val) < Math.Pow(10, -10))
                {
                    val = 0;
                    for (int el = 0; el < arrayMatrixA[x].Length; el++)
                    {
                        if (el > x && arrayMatrixA[x][el] != 0)
                        {
                            val = arrayMatrixA[x][el];

                        }

                    }

                    if (val == 0) {
                        continue;
                }
                }
                countCalc++;
                arrayMatrixA[x][x] = 1 / val;

                for (int elX = 0; elX < arrayMatrixA.Count(); elX++)
                {
                    if (elX == x) continue;

                    for (int el = 0; el < arrayMatrixA[elX].Length; el++)
                    {
                        if (el == x) continue;

                        arrayMatrixA[elX][el] = (arrayMatrixA[elX][el] * val - arrayMatrixA[x][el] * arrayMatrixA[elX][x]) / val;
                    }
                }
                int size = arrayMatrixA.Count() > arrayMatrixA[0].Length ? arrayMatrixA.Count(): arrayMatrixA[0].Length;
                for (int elX = 0; elX < size; elX++)
                {
                    if (elX == x) continue;

                    if (elX < arrayMatrixA[0].Length) { arrayMatrixA[x][elX] = -arrayMatrixA[x][elX] / val; }
                    if (elX < arrayMatrixA.Count()) { arrayMatrixA[elX][x] = arrayMatrixA[elX][x] / val; }
                }

                infoReport += $"\r\n\r\n рок #{x+1}:\r\n";
                infoReport += $"–озвТ€зувальний елемент: A[{x}, {x}] = {Math.Round(val,4)}:\r\n";
                infoReport += "ћатриц€ п≥сл€ виконанн€ «∆¬:\r\n";
                for (int elX = 0; elX < arrayMatrixA.Count(); elX++)
                {

                    for (int el = 0; el < arrayMatrixA[elX].Length; el++)
                    {
                        infoReport += Math.Round(arrayMatrixA[elX][el],4);
                        if (el != arrayMatrixA[elX].Length - 1) infoReport += " ";
                    }
                    if (elX != arrayMatrixA.Count() - 1) infoReport += "\r\n";

                }

            }
            count = countCalc;
            textBoxReport.Text = infoReport;
            if (arrayMatrixA == null) return arrayMatrixA;
            infoReport += "\r\n\r\nќбернена матриц€:\r\n";
            for (int elX = 0; elX < arrayMatrixA.Count(); elX++)
            {

                for (int el = 0; el < arrayMatrixA[elX].Length; el++)
                {
                    infoReport += Math.Round(arrayMatrixA[elX][el],4);
                    if (el != arrayMatrixA[elX].Length - 1) infoReport += " ";
                }
                if (elX != arrayMatrixA.Count() - 1) infoReport += "\r\n";

            }
            
            return arrayMatrixA;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!valid(InputMatrixA.Text)) {
                TextBoxResultatMatrixA.Text = "Ќе вал≥дна матриц€";
                return; 
            }
            string b = InputMatrixA.Text;
            int count = 0;
            List<double[]> arrayMatrixA = b.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
            if (!check(arrayMatrixA))
            {
                TextBoxResultatMatrixA.Text = "Ќе коректна матриц€";
                return;
            }
            arrayMatrixA = MatrixCalc(arrayMatrixA, out count);

            if (arrayMatrixA == null) { TextBoxResultatMatrixA.Text = "¬ироджена матриц€"; return; }
            if (arrayMatrixA.Count != arrayMatrixA[0].Length)
            {
                TextBoxResultatMatrixA.Text = "÷€ матриц€ не квадратна";

            }
            else
            {
                TextBoxResultatMatrixA.Text = string.Join("\r\n", arrayMatrixA.Select(row => string.Join("   ", row.Select(num => Math.Round(num, 4)))));
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!valid(InputMatrixA.Text))
            {
                LabelMatrixRange.Text = "Ќе вал≥дна матриц€";
                return;
            }
            string b = InputMatrixA.Text;
            int count = 0;
            List<double[]> arrayMatrixA = b.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
            if (!check(arrayMatrixA))
            {
                LabelMatrixRange.Text = "Ќе коректна матриц€";
                return;
            }
            arrayMatrixA = MatrixCalc(arrayMatrixA, out count);
            LabelMatrixRange.Text = count.ToString();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!valid(InputMatrixA.Text))
            {
                TextBoxResultatMatrix.Text = "Ќе вал≥дна матриц€ A";
                return;
            }
            if (!validMatrixB(InputMatrixB.Text))
            {
                TextBoxResultatMatrix.Text = "Ќе вал≥дна матриц€ B";
                return;
            }
            
            string textInputA = InputMatrixA.Text;
            string textInputB = InputMatrixB.Text;

            if (textInputB == null || textInputB == "")
            {
                TextBoxResultatMatrix.Text = "ћатриц€ B не вал≥дна";
                return;
            }
            int count = 0;
            List<double[]> arrayMatrixA = textInputA.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
            List<double[]> arrayMatrixB = textInputB.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
            if (arrayMatrixA.Count != arrayMatrixB.Count)
            {
                TextBoxResultatMatrix.Text = " ≥льк≥сть р€дк≥в в матриц≥ B не сп≥впадаЇ з к≥льк≥сть р€дк≥в матриц≥ A";
                return;
            }

            if (!check(arrayMatrixA))
            {
                TextBoxResultatMatrix.Text = "Ќе коректна матриц€";
                return;
            }
            arrayMatrixA = MatrixCalc(arrayMatrixA, out count);
            if (arrayMatrixA == null) { TextBoxResultatMatrix.Text = "¬ироджена матриц€"; return; }
            if (arrayMatrixA.Count != arrayMatrixA[0].Length)
            {
                TextBoxResultatMatrix.Text = "÷€ матриц€ не квадратна";
                
            }
            else
            {
               textBoxReport.Text += "\r\n\r\n¬х≥дна матриц€ ¬:\r\n";
                for (int elX = 0; elX < arrayMatrixB.Count(); elX++)
                {

                    for (int el = 0; el < arrayMatrixB[elX].Length; el++)
                    {
                        textBoxReport.Text += Math.Round(arrayMatrixB[elX][el], 4);
                    }
                    if (elX != arrayMatrixB.Count() - 1) textBoxReport.Text += "\r\n";

                }
                textBoxReport.Text += "\r\n\r\nќбчисленн€ розвТ€зк≥в:\r\n";
                int x = 0;
                List<double[]> resultatMatrix = arrayMatrixA.Select(row =>
                {
                    
                    double[] res = new double[1];
                    
                    textBoxReport.Text += $"\r\nx[{++x}] = ";
                    for (int index = 0; index < row.Length; index++)
                    {
                        textBoxReport.Text += $"{Math.Round(row[index],4)} * {Math.Round(arrayMatrixB[index][0],4)}";
                        if (index != row.Length - 1) textBoxReport.Text += " + ";
                        res[0] += row[index] * arrayMatrixB[index][0];
                    }
                    textBoxReport.Text += $" = {Math.Round(res[0],4)} \r\n";
                    return res;
                }).ToList();

                
                TextBoxResultatMatrix.Text = string.Join("\r\n", resultatMatrix.Select(row => string.Join(" ", row.Select(num => Math.Round(num, 4)))));
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            decimal rows = InputNumGenMatrix1.Value, colums = InputNumGenMatrix2.Value;
            

            genMatrixA(rows, colums);
            genMatrixB(rows);
        }

        private void genMatrixA(decimal row, decimal col)
        {
            int n=0;
            List<double[]> arrayMatrixA;
            string f = "";
            do
            {
                string textInput = "";
                Random rand = new Random();
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < col; j++)
                    {
                        textInput += rand.Next(-20, 20);
                        if (j != col - 1) textInput += " ";
                    }
                    if (i != row - 1) textInput += "\r\n";
                }
                arrayMatrixA = textInput.Split("\r\n").Select(row => row.Split(" ").Select(double.Parse).ToArray()).ToList();
                f = textInput;
            } while (row == col && MatrixCalc(arrayMatrixA, out n) == null);
            InputMatrixA.Text = f;
        }

        private void genMatrixB(decimal size)
        {
            string textInput = "";
            Random rand = new Random();
            for (int i = 0; i < size; i++)
            {
                textInput += rand.Next(-20, 20);
                if (i != size - 1) textInput += "\r\n";
            }
            InputMatrixB.Text = textInput;
        }

        private bool valid(string input)
        {
            string pattern = @"^((-?\d+\s+)+(-?\d+))(\r?\n((-?\d+\s+)+(-?\d+)))*$";

            return Regex.IsMatch(input, pattern);
        }

        private bool check(List<double[]> input)
        {
            int row = input.Count;
            int col = input[0].Length;

            foreach(var el in input)
            {
                if (el.Length !=col) {
                    return false;
                }
            }

            return true;
        }

        private bool validMatrixB(string input)
        {
            string pattern = @"^(-?\d+)(\r\n(-?\d+))*$";

            return Regex.IsMatch(input, pattern);
        }
    }
}
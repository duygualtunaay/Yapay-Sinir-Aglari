using System;
using System.Windows.Forms;

namespace Yapay_Sinir_Ağları
{
    public partial class MainForm : Form
    {
        private Network? network;
        private int[,] inputMatrix = new int[7, 5];
        private Button[,] buttons = new Button[7, 5];
        private double[][] trainingInputs;
        private double[][] trainingOutputs;

        public MainForm()
        {
            InitializeComponent();
            InitializeMatrixButtons();
            InitializeNetwork();
        }

        private void InitializeNetwork()
        {
            network = new Network(35, 10, 5); 

            trainingInputs = new double[][]
            {
    ConvertTo1D(new int[,] { // A
        {0,0,1,0,0},
        {0,1,0,1,0},
        {1,0,0,0,1},
        {1,0,0,0,1},
        {1,1,1,1,1},
        {1,0,0,0,1},
        {1,0,0,0,1}
    }),
    ConvertTo1D(new int[,] { // B
        {1,1,1,1,0},
        {1,0,0,0,1},
        {1,0,0,0,1},
        {1,1,1,1,0},
        {1,0,0,0,1},
        {1,0,0,0,1},
        {1,1,1,1,0}
    }),
    ConvertTo1D(new int[,] { // C
        {0,0,1,1,1},
        {0,1,0,0,0},
        {1,0,0,0,0},
        {1,0,0,0,0},
        {1,0,0,0,0},
        {0,1,0,0,0},
        {0,0,1,1,1}
    }),
    ConvertTo1D(new int[,] { // D
        {1,1,1,0,0},
        {1,0,0,1,0},
        {1,0,0,0,1},
        {1,0,0,0,1},
        {1,0,0,0,1},
        {1,0,0,1,0},
        {1,1,1,0,0}
    }),
    ConvertTo1D(new int[,] { // E
        {1,1,1,1,1},
        {1,0,0,0,0},
        {1,0,0,0,0},
        {1,1,1,1,1},
        {1,0,0,0,0},
        {1,0,0,0,0},
        {1,1,1,1,1}
    })
            };

            trainingOutputs = new double[][]
            {
    new double[] {1,0,0,0,0}, // A
    new double[] {0,1,0,0,0}, // B
    new double[] {0,0,1,0,0}, // C
    new double[] {0,0,0,1,0}, // D
    new double[] {0,0,0,0,1}  // E
            };

        }

        private double TrainUntilConverged()
        {
            double error;
            int epoch = 0;
            do
            {
                error = 0;
                for (int i = 0; i < trainingInputs.Length; i++)
                {
                    error += network.Train(trainingInputs[i], trainingOutputs[i]);
                }
                epoch++;
            } while (error > network.Epsilon);

            MessageBox.Show("Eğitim tamamlandı.\nEpoch: " + epoch + "\nHata: " + error.ToString("F4"));
            return error;
        }



        private double[] ConvertTo1D(int[,] matrix)
        {
            double[] result = new double[35];
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 5; j++)
                    result[i * 5 + j] = matrix[i, j];
            return result;
        }

        private void InitializeMatrixButtons()
        {
            int startX = 20, startY = 20, size = 30;

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Button b = new Button();
                    b.SetBounds(startX + j * size, startY + i * size, size, size);
                    b.BackColor = System.Drawing.Color.White;
                    b.Tag = new Tuple<int, int>(i, j);
                    b.Click += ToggleButton_Click;
                    Controls.Add(b);
                    buttons[i, j] = b;
                }
            }
        }

        private void ToggleButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            var (i, j) = ((Tuple<int, int>)b.Tag);
            inputMatrix[i, j] = 1 - inputMatrix[i, j];
            b.BackColor = inputMatrix[i, j] == 1 ? System.Drawing.Color.Black : System.Drawing.Color.White;
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            double error;
            int epoch = 0;

            do
            {
                error = 0;
                for (int i = 0; i < trainingInputs.Length; i++)
                    TrainUntilConverged();


                epoch++;
            } while (error > network.Epsilon && epoch < 10000);

            lblError.Text = $"Hata oranı: {error:F4}";
        }

        private void btnRecognize_Click(object sender, EventArgs e)
        {
            double[] input = ConvertTo1D(inputMatrix);
            double[] output = network.FeedForward(input);

            string result = "";
            for (int i = 0; i < output.Length; i++)
                result += $"{(char)('A' + i)} çıkışı = {output[i]}\n"; 

            MessageBox.Show(result, "Sonuçlar");
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 5; j++)
                {
                    inputMatrix[i, j] = 0;
                    buttons[i, j].BackColor = System.Drawing.Color.White;
                }
        }

        private void btnClearGrid_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    inputMatrix[i, j] = 0;
                    buttons[i, j].BackColor = SystemColors.Control; 
                }
            }
        }

    }
}

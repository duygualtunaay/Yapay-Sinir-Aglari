using System;
using System.Collections.Generic;

namespace Yapay_Sinir_Ağları
{
    public class Network
    {
        private Layer inputLayer;
        private Layer hiddenLayer;
        private Layer outputLayer;

        public double LearningRate = 0.1;
        public double Epsilon = 0.005;


        public Network(int inputCount, int hiddenCount, int outputCount)
        {
            inputLayer = new Layer(inputCount, 0);
            hiddenLayer = new Layer(hiddenCount, inputCount);
            outputLayer = new Layer(outputCount, hiddenCount);
        }

        public double[] FeedForward(double[] inputs)
        {
            inputLayer.SetOutputs(inputs);
            hiddenLayer.CalculateOutputs(inputLayer);
            outputLayer.CalculateOutputs(hiddenLayer);

            return outputLayer.Outputs;
        }

        public double Train(double[] inputs, double[] targets)
        {
            double[] outputs = FeedForward(inputs);

          
            double error = 0.0;
            for (int i = 0; i < targets.Length; i++)
            {
                double delta = targets[i] - outputs[i];
                error += delta * delta;
            }
            error /= targets.Length;

       
            outputLayer.BackPropagateOutput(targets);
            hiddenLayer.BackPropagateHidden(outputLayer);

            
            outputLayer.UpdateWeights(hiddenLayer, LearningRate);
            hiddenLayer.UpdateWeights(inputLayer, LearningRate);

            return error;
        }

        public double GetError(double[][] inputs, double[][] targets)
        {
            double error = 0.0;
            for (int i = 0; i < inputs.Length; i++)
                error += Train(inputs[i], targets[i]);
            return error / inputs.Length;
        }
    }
}


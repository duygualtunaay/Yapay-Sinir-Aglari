using System.Collections.Generic;

namespace Yapay_Sinir_Ağları
{
    public class Layer
    {
        public Neuron[] Neurons;
        public double[] Outputs;

        public Layer(int neuronCount, int inputCountPerNeuron)
        {
            Neurons = new Neuron[neuronCount];
            Outputs = new double[neuronCount];
            for (int i = 0; i < neuronCount; i++)
                Neurons[i] = new Neuron(inputCountPerNeuron);
        }

        public void SetOutputs(double[] inputs)
        {
            Outputs = inputs;
        }

        public void CalculateOutputs(Layer previousLayer)
        {
            for (int i = 0; i < Neurons.Length; i++)
                Outputs[i] = Neurons[i].ComputeOutput(previousLayer.Outputs);
        }

        public void BackPropagateOutput(double[] targets)
        {
            for (int i = 0; i < Neurons.Length; i++)
            {
                double error = targets[i] - Neurons[i].Output;
                Neurons[i].Delta = error * Neurons[i].Derivative();
            }
        }

        public void BackPropagateHidden(Layer nextLayer)
        {
            for (int i = 0; i < Neurons.Length; i++)
            {
                double error = 0.0;
                for (int j = 0; j < nextLayer.Neurons.Length; j++)
                    error += nextLayer.Neurons[j].Weights[i] * nextLayer.Neurons[j].Delta;
                Neurons[i].Delta = error * Neurons[i].Derivative();
            }
        }

        public void UpdateWeights(Layer previousLayer, double learningRate)
        {
            for (int i = 0; i < Neurons.Length; i++)
            {
                for (int j = 0; j < previousLayer.Outputs.Length; j++)
                    Neurons[i].Weights[j] += learningRate * Neurons[i].Delta * previousLayer.Outputs[j];
                Neurons[i].Weights[^1] += learningRate * Neurons[i].Delta; 
            }
        }
    }
}

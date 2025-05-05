using System;
using System.Collections.Generic;

namespace Yapay_Sinir_Ağları
{
    public class Neuron
    {
        public double[] Weights;
        public double Output;
        public double Delta;

        private static Random rand = new Random();

        public Neuron(int inputCount)
        {
            Weights = new double[inputCount + 1]; 
            for (int i = 0; i < Weights.Length; i++)
                Weights[i] = rand.NextDouble() * 2 - 1; 
        }

        public double ComputeOutput(double[] inputs)
        {
            double sum = Weights[Weights.Length - 1]; 
            for (int i = 0; i < inputs.Length; i++)
                sum += inputs[i] * Weights[i];
            Output = Sigmoid(sum);
            return Output;
        }

        private double Sigmoid(double x)
        {
            return 1.0 / (1.0 + Math.Exp(-x));
        }

        public double Derivative()
        {
            return Output * (1 - Output);
        }
    }
}

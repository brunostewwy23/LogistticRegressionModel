using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Accord.Controls;
using Accord.Statistics;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Fitting;

namespace LogistticRegressionModel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //the model im going to build now is a simple
            //logistic regression model.
            //Given two dimenstional arrays and an expected output
            //I am going to develop a program that trains a logistic
            //regression classifier and then plot the results showing
            //the expected output and the ctaul predictions by this model.

            double[][] inputs =
            {
             new double [] { 0,0},
             new double [] { 0.25,0.25},
             new double [] { 0.5,0.5},
             new double [] { 1,1},
            };

            int[] outputs =
            {
                0,
                0,
                1,
                1,
            };

            //Train a logistuc regression model

            var learner = new IterativeReweightedLeastSquares<LogisticRegression>()
            {
                MaxIterations = 100
            };

            var logit = learner.Learn(inputs, outputs);

            //Predict output

            bool[] predictions = logit.Decide(inputs);

            //Plot the results

            ScatterplotBox.Show("Expected Results", inputs, outputs);
            ScatterplotBox.Show("Actual Regression Output", inputs, predictions.ToZeroOne());

            Console.ReadKey();
        }
    }
}

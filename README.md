# Logistic Regression Model

A C# implementation of a logistic regression classifier with visualization capabilities. This project demonstrates training a logistic regression model on two-dimensional data and visualizing predictions against expected outputs.

## Overview

This application implements a complete logistic regression pipeline using the [Accord.NET](http://accord-framework.net/) framework. It trains a classifier on 2D input arrays with corresponding labels and provides graphical visualization of the model's predictions.

## Features

- **Logistic Regression Classification**: Train a binary classifier on 2D data
- **Model Visualization**: Plot training data and predictions using ZedGraph
- **Accord.NET Integration**: Leverages powerful machine learning and statistics libraries
- **Console Application**: Easy-to-run command-line interface

## Technology Stack

- **Language**: C# (.NET Framework 4.7.2)
- **Machine Learning**: Accord.NET v3.8.0
  - Accord.MachineLearning
  - Accord.Statistics
  - Accord.Math
- **Visualization**: ZedGraph v5.1.7
- **UI Framework**: Windows Forms

## Project Structure

```
LogistticRegressionModel/
├── Program.cs                 # Main application entry point
├── Properties/
│   └── AssemblyInfo.cs       # Assembly metadata
├── LogistticRegressionModel.csproj
├── packages.config           # NuGet dependencies
└── README.md
```

## Getting Started

### Prerequisites

- Visual Studio 2015 or later
- .NET Framework 4.7.2
- NuGet Package Manager

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/brunostewwy23/LogistticRegressionModel.git
   cd LogistticRegressionModel
   ```

2. Restore NuGet packages:
   ```bash
   nuget restore
   ```

3. Open `LogistticRegressionModel.slnx` in Visual Studio

4. Build the solution (Build > Build Solution)

### Running the Application

1. Set the project as the startup project
2. Press `F5` or click Debug > Start Debugging
3. The application will train the model and display the visualization

## How It Works

The model follows these steps:

1. **Data Preparation**: Accepts two-dimensional input arrays and corresponding expected outputs
2. **Model Training**: Trains a logistic regression classifier using the Accord.NET framework
3. **Prediction**: Generates predictions for the training data
4. **Visualization**: Plots both expected outputs and model predictions for comparison

## Dependencies

- **Accord** (v3.8.0): Core machine learning framework
- **Accord.Controls** (v3.8.0): UI components for machine learning
- **Accord.MachineLearning** (v3.8.0): Classification and learning algorithms
- **Accord.Math** (v3.8.0): Mathematical operations
- **Accord.Statistics** (v3.8.0): Statistical analysis
- **ZedGraph** (v5.1.7): Data visualization and graphing

All dependencies are managed via NuGet and can be restored from `packages.config`.

## License

Licensed under the LGPL License. See `License-LGPL.txt` for details.

## Author

Bruno Stewart

## Contributing

Contributions are welcome! Feel free to open issues or submit pull requests to improve the project.

---

For more information about Accord.NET, visit: [Accord.NET Framework](http://accord-framework.net/)

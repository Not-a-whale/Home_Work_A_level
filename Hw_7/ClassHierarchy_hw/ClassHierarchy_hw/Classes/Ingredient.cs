﻿// <copyright file="Ingredient.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace ClassHierarchy_hw.Classes
{
    internal class Ingredient : IngredientType
    {
        private string name;
        private double calories;
        private double quantity;
        private string measurement;

        public Ingredient(string name, double calories, double quantity, string measurement)
            : base(name)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Calories = calories;
            this.Measurement = measurement;
        }

        public new string Name
        {
            get => this.name;
            set => this.name = $"{base.Name} - {value}";
        }

        public string Measurement
        {
            get => this.measurement;
            set => this.measurement = value;
        }

        public double Calories
        {
            get => this.calories;
            set => this.calories = value;
        }

        public double Quantity
        {
            get => this.quantity;
            set => this.quantity = value;
        }
    }
}
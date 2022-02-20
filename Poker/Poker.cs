/********************************************************************
Program: Poker.cs
Purpose: to demonstrate competency in cross class functionality by calling methods from different classes. The program itself deals 2 hands of 5 and declares a winner based on a poker scoring system
Authors: Logan Larocque, Mohamed Babiker, Nisham Prasai, Derrick Grant
*********************************************************************/

namespace Poker
{
    internal static class Poker
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
﻿namespace WeddingsPlanner.Import
{
    internal class Import
    {
        private static void Main(string[] args)
        {
            JsonMethods.ImportAgencies();
            JsonMethods.ImportPeople();
            JsonMethods.ImportWeddings();

            XmlMethods.ImportVenues();
            XmlMethods.ImportPresents();
        }
    }
}
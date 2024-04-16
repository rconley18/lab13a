/*
Class: CSE 1321L
Section: W#1
Term: Spring 24
Instructor: Manosmi Gundu
Name: Robert Conley
Lab#: Lab13
*/ 
using System;

public class BuildingBlueprint
{
    private int numberOfStories;
    private int numberOfApartments;
    private float occupancyRate;
    private bool fullyOccupied;

    // Default constructor
    public BuildingBlueprint()
    {
        numberOfStories = 10;
        numberOfApartments = 20;
        occupancyRate = 1.0f;
        fullyOccupied = true;
    }

    // Overloaded constructor
    public BuildingBlueprint(int stories, int apartments, float occupancy)
    {
        numberOfStories = stories;
        numberOfApartments = apartments;
        occupancyRate = occupancy;
        fullyOccupied = (occupancy == 1.0f);
    }

    // Getters and Setters
    public int GetNumberOfStories()
    {
        return numberOfStories;
    }

    public int GetNumberOfApartments()
    {
        return numberOfApartments;
    }

    public float GetOccupancyRate()
    {
        return occupancyRate;
    }

    public bool IsFullyOccupied()
    {
        return fullyOccupied;
    }

    public void SetOccupancyRate(float occupancy)
    {
        occupancyRate = occupancy;
        fullyOccupied = (occupancy == 1.0f);
    }
}

public class Lab13A
{
    public static void Main(string[] args)
    {
        BuildingBlueprint buildingOne = new BuildingBlueprint();
        BuildingBlueprint buildingTwo = new BuildingBlueprint(30, 30, 0.75f);

        Console.WriteLine("Year 2020:");
        PrintBuildingInfo(buildingOne, "Building 1");
        PrintBuildingInfo(buildingTwo, "Building 2");

        Console.WriteLine("Many years pass.");

        // Change occupancy rates
        buildingOne.SetOccupancyRate(0.0f);
        buildingTwo.SetOccupancyRate(1.0f);

        Console.WriteLine("Year 2043:");
        PrintBuildingInfo(buildingOne, "Building 1");
        PrintBuildingInfo(buildingTwo, "Building 2");

        Console.WriteLine("Looks like people prefer taller buildings.");
    }

    public static void PrintBuildingInfo(BuildingBlueprint building, string buildingName)
    {
        Console.WriteLine($"{buildingName} has {building.GetNumberOfStories()} floors, {building.GetNumberOfApartments()} apartments, and is {building.GetOccupancyRate() * 100}% occupied. Full? {building.IsFullyOccupied()}");
    }
}

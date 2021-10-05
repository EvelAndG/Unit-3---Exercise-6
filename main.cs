using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) 
	{

		int num = 6;
		//creating empty array of sharknado objects
		Sharknado[] sharknadoRay = new Sharknado[num];

		//temp Sharknado object to store data
		Sharknado tempSharknado;

		//create objects and add to array
		for(int i=0; i<sharknadoRay.Length; i++)
		{
			tempSharknado = new Sharknado();
			tempSharknado.windForce = i*33;
			tempSharknado.numOfSharks = i*3;
			sharknadoRay[i] = tempSharknado;			
		}

		//printing out sharknado array of objects
		for(int i = 0; i<sharknadoRay.Length; i++)
		{
			Console.WriteLine($"Sharknado windforce: {sharknadoRay[i].windForce}\nSharknado num of sharks: {sharknadoRay[i].numOfSharks}\n");
		}







		//creating empty list of alien objects
		List<Alien> aliensList = new List<Alien>();

		Alien tempAlien;

		//creating alien objects and adding to list
		for(int i = 0; i<num;i++)
		{
			tempAlien = new Alien();
			tempAlien.Name = $"Alien {i+1}";
			tempAlien.tentacleCount = i*3;
			tempAlien.eyeBalls = i*4;

			aliensList.Add(tempAlien);
		}

		//print out alien objects from aliensList
		foreach (Alien alien in aliensList)
		{
			Console.WriteLine($"Name: {alien.Name}\nTentacle Count: {alien.tentacleCount}\nEyeball Count: {alien.eyeBalls}\n");
		}


   
  }
}
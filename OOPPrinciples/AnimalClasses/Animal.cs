using System;

namespace OOPPrinciples.AnimalClasses
{
	public abstract class Animal
	{


		public abstract void Setup();

		public virtual void Goodbye()
		{
			Console.WriteLine("Thank you for visiting the choo choo kazoo zoo!"); 
		}
	}

		public abstract class FlyingAnimal : Animal
		{
			public abstract string TimeOfHunt { get; }

			public override void Setup()
			{
				Console.WriteLine("Time of Hunt:");
			
				
			}
		}	















}



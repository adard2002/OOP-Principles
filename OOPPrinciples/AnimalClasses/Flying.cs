using System;

public class Flying
{
	public Flying()
	{

		public class FlyingAnimal : Flying, IFlyingAnimal
    {
		public string TimeOfHunt { get; }

		public 



		
		public override void Setup()
        {
			Console.WriteLine("Animals in the zoo that can fly!");
        }

		public override void Goodbye()
        {
			Console.WriteLine("Hope you enjoyed your visit with the Flying animals! Come again!")

			// Don't forget to say goodbye to everyone in the zoo
			base.Goodbye();
        }


    } // closes public class FlyingAnimal


	// Interface
	public interface IFlyingAnimal
    {
		string TimeOfHunt { get; }
    }


}


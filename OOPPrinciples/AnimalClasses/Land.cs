using System;

public class Land
{
	public Land()
	{




	public class LandAnimal : Land, ILandAnimal
	{
		public string HasClaws { get; }

		public override void Setup()
		{
			Console.WriteLine("Animals in the zoo that have some big and amazing claws!");
		}

		public override void Goodbye()
		{
			Console.WriteLine("Hope you enjoyed your visit with the big clawwed animals! Come again!")

			// Don't forget to say goodbye to everyone in the zoo
			base.Goodbye();
		}


	} // closes public class LandAnimal


	// Interface
	public interface ILandAnimal
	{
		string HasClaws { get; }
	}










}
}

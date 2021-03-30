using System;

public class Marine
{
	public Marine()
	{




	public class MarineAnimal : Marine, IMarineAnimal
	{
		public string IsVenomous { get; }

		public override void Setup()
		{
			Console.WriteLine("Animal in the zoo that aquatic!");
		}

		public override void Goodbye()
		{
			Console.WriteLine("Hope you enjoyed your visit with the Marine animals! Come again!")

			// Don't forget to say goodbye to everyone in the zoo
			base.Goodbye();
		}


	} // closes public class MarineAnimal


	// Interface
	public interface IMarineAnimal
	{
		string IsVenomous { get; }
	}




}
}

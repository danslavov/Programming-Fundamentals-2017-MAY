namespace P03_Jarvis
{
	using System;
	using System.Collections.Generic;
	using System.Linq;

	public class P03_Jarvis
	{
		public static void Main()
		{
			var arms = new List<Limb>()
			{
				new Limb()
			};
			var legs = new List<Limb>()
			{
				new Limb()
			};
			var torso = new Body();
			var head = new Body();
			var maxEnergy = long.Parse(Console.ReadLine());
			var component = Console.ReadLine();
			while (component != "Assemble!")
			{
				AssembleComponents(component, arms, legs, torso, head);
				component = Console.ReadLine();
			}
			PrintResult(arms, legs, torso, head, maxEnergy);
		}

		public static void PrintResult(
			List<Limb> arms, List<Limb> legs, Body torso, Body head, long maxEnergy)
		{
			var armsEnergy = arms.Sum(a => a.Energy);
			var legsEnergy = legs.Sum(l => l.Energy);
			var usedEnergy = armsEnergy + legsEnergy + torso.Energy + head.Energy;
			if (NotEnoughParts(arms, legs, torso, head))
			{
				Console.WriteLine("We need more parts!");
			}
			else if (usedEnergy > maxEnergy)
			{
				Console.WriteLine("We need more power!");
			}
			else
			{
				PrintJarvis(arms.OrderBy(a => a.Energy).ToList(),
					legs.OrderBy(l => l.Energy).ToList(), torso, head);
			}

		}

		public static void PrintJarvis(
			List<Limb> arms, List<Limb> legs, Body torso, Body head)
		{
			Console.WriteLine($"Jarvis:\n" +
				$"#Head:\n" +
				$"###Energy consumption: {head.Energy}\n" +
				$"###IQ: {head.FirstProperty}\n" +
				$"###Skin material: {head.SecondProperty}\n" +
				$"#Torso:\n" +
				$"###Energy consumption: {torso.Energy}\n" +
				$"###Processor size: {torso.FirstProperty:F1}\n" +
				$"###Corpus material: {torso.SecondProperty}\n" +
				$"#Arm:\n" +
				$"###Energy consumption: {arms[0].Energy}\n" +
				$"###Reach: {arms[0].FirstProperty}\n" +
				$"###Fingers: {arms[0].SecondProperty}\n" +
				$"#Arm:\n" +
				$"###Energy consumption: {arms[1].Energy}\n" +
				$"###Reach: {arms[1].FirstProperty}\n" +
				$"###Fingers: {arms[1].SecondProperty}\n" +
				$"#Leg:\n" +
				$"###Energy consumption: {legs[0].Energy}\n" +
				$"###Strength: {legs[0].FirstProperty}\n" +
				$"###Speed: {legs[0].SecondProperty}\n" +
				$"#Leg:\n" +
				$"###Energy consumption: {legs[1].Energy}\n" +
				$"###Strength: {legs[1].FirstProperty}\n" +
				$"###Speed: {legs[1].SecondProperty}\n");
		}

		public static bool NotEnoughParts(
			List<Limb> arms, List<Limb> legs, Body torso, Body head)
		{
			if (arms.Any(a => a.Energy == long.MaxValue) ||
				legs.Any(l => l.Energy == long.MaxValue) ||
				torso.Energy == long.MaxValue ||
				head.Energy == long.MaxValue)
			{
				return true;
			}
			return false;
		}

		public static void AssembleComponents(
			string component, List<Limb> arms, List<Limb> legs, Body torso, Body head)
		{
			var specs = component.Split();
			switch (specs[0])
			{
				case "Arm":
					CheckComponent(specs, arms);
					break;
				case "Leg":
					CheckComponent(specs, legs);
					break;
				case "Torso":
					CheckComponent(specs, torso);
					break;
				case "Head":
					CheckComponent(specs, head);
					break;
			}
		}

		public static void CheckComponent(string[] specs, List<Limb> limbs)
		{
			var currentEnergy = long.Parse(specs[1]);
			for (var i = 0; i < limbs.Count(); i++)
			{
				if (currentEnergy < limbs[i].Energy)
				{
					ReplaceComponent(specs, limbs, currentEnergy, i);
				}
			}
		}

		public static void CheckComponent(string[] specs, Body body)
		{
			var currentEnergy = long.Parse(specs[1]);
			if (currentEnergy < body.Energy)
			{
				ReplaceComponent(specs, body, currentEnergy);
			}
		}

		public static void ReplaceComponent(
			string[] specs, List<Limb> limbs, long currentEnergy, int number)
		{
			if (limbs.Count > 1)
			{
				limbs.Remove(limbs[number]);
			}
			var currentFirstProperty = long.Parse(specs[2]);
			var currentSecondProperty = long.Parse(specs[3]);
			limbs.Add(new Limb
			{
				Energy = currentEnergy,
				FirstProperty = currentFirstProperty,
				SecondProperty = currentSecondProperty
			});
		}

		public static void ReplaceComponent(
			string[] specs, Body oldComponent, long currentEnergy)
		{
			var currentFirstProperty = double.Parse(specs[2]);
			var currentSecondProperty = specs[3];
			oldComponent.Energy = currentEnergy;
			oldComponent.FirstProperty = currentFirstProperty;
			oldComponent.SecondProperty = currentSecondProperty;
		}
	}

	public class Limb
	{
		public long Energy { get; set; } = long.MaxValue;
		public long FirstProperty { get; set; }
		public long SecondProperty { get; set; }
	}

	public class Body
	{
		public long Energy { get; set; } = long.MaxValue;
		public double FirstProperty { get; set; }
		public string SecondProperty { get; set; }
	}
}
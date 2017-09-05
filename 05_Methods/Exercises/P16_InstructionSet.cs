namespace P16_InstructionSet
{
	using System;

	public class P16_InstructionSet
	{
		public static void Main()
		{
			while (true)
			{
				string opCode = Console.ReadLine().ToUpper();

				if (opCode == "END")
				{
					return;
				}

				string[] codeArgs = opCode.Split(' ');

				long result = 0;
				switch (codeArgs[0])
				{
					case "INC":
						{
							int operandOne = int.Parse(codeArgs[1]);
							result = operandOne + 1L;
							break;
						}
					case "DEC":
						{
							int operandOne = int.Parse(codeArgs[1]);
							result = operandOne - 1L;
							break;
						}
					case "ADD":
						{
							int operandOne = int.Parse(codeArgs[1]);
							int operandTwo = int.Parse(codeArgs[2]);
							result = (long) operandOne + operandTwo;
							break;
						}
					case "MLA":
						{
							int operandOne = int.Parse(codeArgs[1]);
							int operandTwo = int.Parse(codeArgs[2]);
							result = (long) operandOne * operandTwo;
							break;
						}
				}

				Console.WriteLine(result);
			}
		}
	}
}

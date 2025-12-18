using GateControl.Definitions;

namespace ControlloCancello.Helpers
{
	static internal class StateHelper
	{
		static internal string ConstantToStringConverter(int state)
		{
			string stateString = "";
			switch(state)
			{
				case Costanti.S_INIZIALE:
					stateString = "FERMO";
					break;
				case Costanti.S_APERTURA:
					stateString = "APERTURA";
					break;
				case Costanti.S_APERTO:
					stateString = "APERTO";
					break;
				case Costanti.S_OSTACOLO:
					stateString = "OSTACOLO";
					break;
				case Costanti.S_CHIUSURA:
					stateString = "CHIUSURA";
					break;
				case Costanti.S_ARRESTO:
					stateString = "ARRESTO";
					break;
			}
			return stateString;
		}
	}
}

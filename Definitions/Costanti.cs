namespace GateControl.Definitions
{
	internal static class Costanti
	{
		// Stati del sistema di controllo
		internal const int S_INIZIALE = 0;
		internal const int S_APERTURA = 1;
		internal const int S_APERTO = 2;
		internal const int S_OSTACOLO = 3;
		internal const int S_CHIUSURA = 4;
		internal const int S_ARRESTO = 5;
		internal const int DURATA_CICLO_s = 12;
	}
}

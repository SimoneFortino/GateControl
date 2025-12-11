using ControlloCancello.Definizioni;

namespace ControlloCancello
{
	public interface IControlloAutomaticoCancello
	{
		int Secondi { get; }
		int Stato { get; }
		OutputState Uscita_M1_PW { get; }
		DirState Uscita_M1_DIR { get; }
		OutputState Uscita_LCancello { get; }
		OutputState Uscita_LAppartamento { get; }
		OutputState Uscita_T1_TRG { get; }

		InputState Ingresso_BF { get; set; }
		InputState Ingresso_PA { get; set; }
		InputState Ingresso_PS { get; set; }
		InputState Ingresso_T1_END { get; set; }

		void Open();
		void Close();
	}
}

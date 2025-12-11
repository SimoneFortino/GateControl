using ControlloCancello.Definizioni;
using System.Threading;

namespace GateControl
{
	public class ControlloAutomaticoCancello: IControlloAutomaticoCancello
	{
		private int stato;
		private int statoPrecedente;
		private bool controlInProgress;
		private Thread controlThread;
		private int decimiSecondo;
		private int secondi;

		object secondiLocker = new object();
		public int Secondi
		{
			get
			{
				lock (secondiLocker)
					return secondi;
			}
			private set
			{
				lock (secondiLocker)
					secondi = value;
			}
		}

		object controlInProgressLocker = new object();
		public bool ControlInProgress
		{
			get
			{
				lock (controlInProgressLocker)
					return controlInProgress;
			}
			private set
			{
				lock (controlInProgressLocker)
					controlInProgress = value;
			}
		}

		object statoLocker = new object();
		public int Stato
		{
			get
			{
				lock (statoLocker)
					return stato;
			}
			private set
			{
				lock (statoLocker)
					stato = value;
			}
		}
		
		// Uscite
		private OutputState uscita_M1_PW;
		private DirState uscita_M1_DIR;
		private LampState uscita_L1;
		private LampState uscita_L2;
		private OutputState uscita_LCancello;
		private OutputState uscita_LAppartamento;
		private OutputState uscita_T1_TRG;

		object uscita_LCancelloLocker = new object();
		public OutputState Uscita_LCancello
		{
			get
			{
				lock (uscita_LCancelloLocker)
					return uscita_LCancello;
			}
			private set
			{
				lock (uscita_LCancelloLocker)
					uscita_LCancello = value;
			}
		}

		object uscita_LAppartamentoLocker = new object();
		public OutputState Uscita_LAppartamento
		{
			get
			{
				lock (uscita_LAppartamentoLocker)
					return uscita_LAppartamento;
			}
			private set
			{
				lock (uscita_LAppartamentoLocker)
					uscita_LAppartamento = value;
			}
		}

		object uscita_M1_PWLocker = new object();
		public OutputState Uscita_M1_PW
		{
			get
			{
				lock (uscita_M1_PWLocker)
					return uscita_M1_PW;
			}
			private set
			{
				lock (uscita_M1_PWLocker)
					uscita_M1_PW = value;
			}
		}

		object uscita_M1_DIRLocker = new object();
		public DirState Uscita_M1_DIR
		{
			get
			{
				lock (uscita_M1_DIRLocker)
					return uscita_M1_DIR;
			}
			private set
			{
				lock (uscita_M1_DIRLocker)
					uscita_M1_DIR = value;
			}
		}

		object uscita_L1Locker = new object();
		private LampState Uscita_L1
		{
			get
			{
				lock (uscita_L1Locker)
					return uscita_L1;
			}
			set
			{
				lock (uscita_L1Locker)
					uscita_L1 = value;
			}
		}

		object uscita_L2Locker = new object();
		private LampState Uscita_L2
		{
			get
			{
				lock (uscita_L2Locker)
					return uscita_L2;
			}
			set
			{
				lock (uscita_L2Locker)
					uscita_L2 = value;
			}
		}

		object uscita_T1_TRGLocker = new object();
		public OutputState Uscita_T1_TRG
		{
			get
			{
				lock (uscita_T1_TRGLocker)
					return uscita_T1_TRG;
			}
			private set
			{
				lock (uscita_T1_TRGLocker)
					uscita_T1_TRG = value;
			}
		}

		// Ingressi
		private InputState ingresso_BF;
		private InputState ingresso_PA;
		private InputState ingresso_PS;
		private InputState ingresso_T1_END;

		object ingresso_BFLocker = new object();
		public InputState Ingresso_BF
		{
			get
			{
				lock (ingresso_BFLocker)
					return ingresso_BF;
			}
			set
			{
				lock (ingresso_BFLocker)
					ingresso_BF = value;
			}
		}

		object ingresso_PALocker = new object();
		public InputState Ingresso_PA
		{
			get
			{
				lock (ingresso_PALocker)
					return ingresso_PA;
			}
			set
			{
				lock (ingresso_PALocker)
					ingresso_PA = value;
			}
		}

		object ingresso_PSLocker = new object();
		public InputState Ingresso_PS
		{
			get
			{
				lock (ingresso_PSLocker)
					return ingresso_PS;
			}
			set
			{
				lock (ingresso_PSLocker)
					ingresso_PS = value;
			}
		}

		object ingresso_T1_ENDLocker = new object();
		public InputState Ingresso_T1_END
		{
			get
			{
				lock (ingresso_T1_ENDLocker)
					return ingresso_T1_END;
			}
			set
			{
				lock (ingresso_T1_ENDLocker)
					ingresso_T1_END = value;
			}
		}

		public ControlloAutomaticoCancello()
		{
			// Inizializza gli ingressi
			Ingresso_BF = InputState.OFF;
			Ingresso_PA = InputState.OFF;
			Ingresso_PS = InputState.OFF;
			Ingresso_T1_END = InputState.OFF;
			// Inizializza le uscite
			Uscita_M1_PW = OutputState.OFF;
			Uscita_M1_DIR = DirState.OPEN;
			Uscita_L1 = LampState.OFF;
			Uscita_L2 = LampState.OFF;
			Uscita_T1_TRG = OutputState.OFF;
			// Inizializza lo stato
			Stato = Costanti.S_INIZIALE;
			decimiSecondo = 0;
			Secondi = 0;
		}

		public void Open()
		{
			// Inizializza gli ingressi
			Ingresso_BF = InputState.OFF;
			Ingresso_PA = InputState.OFF;
			Ingresso_PS = InputState.OFF;
			Ingresso_T1_END = InputState.OFF;
			// Inizializza le uscite
			Uscita_M1_PW = OutputState.OFF;
			Uscita_M1_DIR = DirState.OPEN;
			Uscita_L1 = LampState.OFF;
			Uscita_L2 = LampState.OFF;
			Uscita_T1_TRG = OutputState.OFF;
			// Inizializza lo stato
			Stato = Costanti.S_INIZIALE;
			decimiSecondo = 0;
			Secondi = 0;
			// Crea il thread per il controllo automatico del cancello
			ControlInProgress = true;
			controlThread = new Thread(ControlProcess) { IsBackground = true, Priority = ThreadPriority.AboveNormal };
			controlThread.Start();
		}

		private void ControlProcess()
		{
			// Thread loop
			while(ControlInProgress)
			{
				ControlLoop();
				Thread.Sleep(100);
				// Se è richiesto l'avvio di un nuovo ciclo di conteggio
				if (Uscita_T1_TRG == OutputState.ON)
				{
					Uscita_T1_TRG = OutputState.OFF;
					Secondi = Costanti.DURATA_CICLO_s;
					Ingresso_T1_END = InputState.OFF;
				}
				// Aggiorna il tempo trascorso
				decimiSecondo++;
				// Se è trascorso un secondo
				if(decimiSecondo == 10)
				{
					decimiSecondo = 0;
					// Se è attivo un conteggio
					if (Secondi > 0)
					{
						Secondi--;
						// Se il ciclo di conteggio è terminato
						if(Secondi == 0)
							Ingresso_T1_END = InputState.ON;
					}
					// Se L2 è intermittente
					if(Uscita_L2 == LampState.INTERMITTENT)
					{
						// Complementa lo stato del lampeggiante del cancello
						if (Uscita_LCancello == OutputState.OFF)
							Uscita_LCancello = OutputState.ON;
						else
							Uscita_LCancello = OutputState.OFF;
					}
					// Se L1 è intermittente
					if (Uscita_L1 == LampState.INTERMITTENT)
					{
						// Complementa lo stato della spia dell'appartamento
						if (Uscita_LAppartamento == OutputState.OFF)
							Uscita_LAppartamento = OutputState.ON;
						else
							Uscita_LAppartamento = OutputState.OFF;
					}
				}
				// Se L1 e/o L2 non sono intermittenti, aggiorna stato lampada cancello e spia appartamento
				if (Uscita_L2 == LampState.ON)
					Uscita_LCancello = OutputState.ON;
				if (Uscita_L2 == LampState.OFF)
					Uscita_LCancello = OutputState.OFF;
				if (Uscita_L1 == LampState.ON)
					Uscita_LAppartamento = OutputState.ON;
				if (Uscita_L1 == LampState.OFF)
					Uscita_LAppartamento = OutputState.OFF;
			}
		}

		public void Close()
		{
			// Termina il thread di controllo
			ControlInProgress = false;
			if (controlThread != null) controlThread.Join();
			controlThread = null;
			// Inizializza gli ingressi
			Ingresso_BF = InputState.OFF;
			Ingresso_PA = InputState.OFF;
			Ingresso_PS = InputState.OFF;
			Ingresso_T1_END = InputState.OFF;
			// Inizializza le uscite
			Uscita_M1_PW = OutputState.OFF;
			Uscita_M1_DIR = DirState.OPEN;
			Uscita_L1 = LampState.OFF;
			Uscita_L2 = LampState.OFF;
			Uscita_T1_TRG = OutputState.OFF;
			// Inizializza lo stato
			Stato = Costanti.S_INIZIALE;
		}

		private void ControlLoop()
		{
			// Realizza la macchina a stati per il controllo della movimentazione del cancello
			switch (Stato)
			{
				case Costanti.S_INIZIALE:
					Ingresso_PS = InputState.OFF;
					// Se è stata richiesta l'apertura
					if (Ingresso_PA == InputState.ON)
					{
						Ingresso_PA = InputState.OFF;
						Uscita_M1_PW = OutputState.ON;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.INTERMITTENT;
						Uscita_L2 = LampState.INTERMITTENT;
						Uscita_T1_TRG = OutputState.ON;
						Stato = Costanti.S_APERTURA;
						return;
					}
					break;

				case Costanti.S_APERTURA:
					Ingresso_PA = InputState.OFF;
					// Se il periodo di attesa è terminato
					if (Ingresso_T1_END == InputState.ON)
					{
						Ingresso_T1_END = InputState.OFF;
						Uscita_M1_PW = OutputState.OFF;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.ON;
						Uscita_L2 = LampState.INTERMITTENT;
						Uscita_T1_TRG = OutputState.ON;
						Stato = Costanti.S_APERTO;
						return;
					}
					// Se è stato richiesto lo stop
					if (Ingresso_PS == InputState.ON)
					{
						Ingresso_PS = InputState.OFF;
						Uscita_M1_PW = OutputState.OFF;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.ON;
						Uscita_L2 = LampState.OFF;
						Stato = Costanti.S_ARRESTO;
						return;
					}
					// Se è presente un ostacolo
					if (Ingresso_BF == InputState.ON)
					{
						Uscita_M1_PW = OutputState.OFF;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.INTERMITTENT;
						Uscita_L2 = LampState.INTERMITTENT;
						Stato = Costanti.S_OSTACOLO;
						return;
					}
					break;

				case Costanti.S_APERTO:
					Ingresso_PA = InputState.OFF;
					// Se il periodo di attesa è terminato
					if (Ingresso_T1_END == InputState.ON)
					{
						Ingresso_T1_END = InputState.OFF;
						Uscita_M1_PW = OutputState.ON;
						Uscita_M1_DIR = DirState.CLOSE;
						Uscita_L1 = LampState.INTERMITTENT;
						Uscita_L2 = LampState.INTERMITTENT;
						Uscita_T1_TRG = OutputState.ON;
						Stato = Costanti.S_CHIUSURA;
						return;
					}
					// Se è stato richiesto lo stop
					if (Ingresso_PS == InputState.ON)
					{
						Ingresso_PS = InputState.OFF;
						Uscita_M1_PW = OutputState.OFF;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.ON;
						Uscita_L2 = LampState.OFF;
						Stato = Costanti.S_ARRESTO;
						return;
					}
					break;

				case Costanti.S_OSTACOLO:
					Ingresso_PA = InputState.OFF;
					// Se è stato richiesto lo stop
					if (Ingresso_PS == InputState.ON)
					{
						Ingresso_PS = InputState.OFF;
						Uscita_M1_PW = OutputState.OFF;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.ON;
						Uscita_L2 = LampState.OFF;
						Stato = Costanti.S_ARRESTO;
						return;
					}
					// Se non è presente un ostacolo
					if (Ingresso_BF == InputState.OFF)
					{
						Uscita_M1_PW = OutputState.ON;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.INTERMITTENT;
						Uscita_L2 = LampState.INTERMITTENT;
						Uscita_T1_TRG = OutputState.ON;
						Stato = Costanti.S_APERTURA;
						return;
					}
					break;

				case Costanti.S_CHIUSURA:
					// Se è stato richiesto lo stop
					if (Ingresso_PS == InputState.ON)
					{
						Ingresso_PS = InputState.OFF;
						Uscita_M1_PW = OutputState.OFF;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.ON;
						Uscita_L2 = LampState.OFF;
						Stato = Costanti.S_ARRESTO;
						return;
					}
					// Se il periodo di attesa è terminato
					if (Ingresso_T1_END == InputState.ON)
					{
						Ingresso_T1_END = InputState.OFF;
						Uscita_M1_PW = OutputState.OFF;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.OFF;
						Uscita_L2 = LampState.OFF;
						Stato = Costanti.S_INIZIALE;
						return;
					}
					// Se è presente un ostacolo
					if (Ingresso_BF == InputState.ON)
					{
						Uscita_M1_PW = OutputState.OFF;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.INTERMITTENT;
						Uscita_L2 = LampState.INTERMITTENT;
						Stato = Costanti.S_OSTACOLO;
						return;
					}
					// Se è stata richiesta l'apertura
					if (Ingresso_PA == InputState.ON)
					{
						Ingresso_PA = InputState.OFF;
						Uscita_M1_PW = OutputState.ON;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.INTERMITTENT;
						Uscita_L2 = LampState.INTERMITTENT;
						Uscita_T1_TRG = OutputState.ON;
						Stato = Costanti.S_APERTURA;
						return;
					}
					break;

				case Costanti.S_ARRESTO:
					Ingresso_PS = InputState.OFF;
					// Se è stata richiesta l'apertura
					if (Ingresso_PA == InputState.ON)
					{
						Ingresso_PA = InputState.OFF;
						Uscita_M1_PW = OutputState.ON;
						Uscita_M1_DIR = DirState.OPEN;
						Uscita_L1 = LampState.INTERMITTENT;
						Uscita_L2 = LampState.INTERMITTENT;
						Uscita_T1_TRG = OutputState.ON;
						Stato = Costanti.S_APERTURA;
						return;
					}
					break;
			}
		}
	}
}

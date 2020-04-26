using System;

namespace Bmi_Calculator.BL
{
    public class BmiModel
    {
		private double _gewicht;

		public double Gewicht
		{
			get { return _gewicht; }
			set { _gewicht = value; }
		}

		private double _lengte;

		public double Lengte
		{
			get { return _lengte; }
			set { _lengte = value; }
		}

		private double _uitkomst;

		public double Uitkomst
		{
			get { return _uitkomst; }
			set { _uitkomst = value; }
		}

		private string _feedback;

		public string Feedback
		{
			get { return _feedback; }
			set { _feedback = value; }
		}

		public BmiModel()
		{

		}

		public void Calculatie(double gewicht, double lengte) // berekening van het bmi en de waarschuwing die er bij gegeven wordt
		{
			Uitkomst = Math.Round(gewicht / (lengte * lengte),0);
			string Waarschuwing;
			if (Uitkomst < 18.5)
			{
				Waarschuwing = " heeft ondergewicht";
			}
			else if(Uitkomst >= 18.5 && Uitkomst < 25)
			{
				Waarschuwing = "bent normaal";
			}
			else if(Uitkomst >= 25 && Uitkomst < 30)
			{
				Waarschuwing = "heeft overgewicht";
			}
			else if (Uitkomst >= 30 && Uitkomst < 40)
			{
				Waarschuwing = "bent zwaarlijvig";
			}
			else
			{
				Waarschuwing = "bent heel zwaarlijvig";
			}

			Feedback = $"Uw BMI is {Uitkomst} u {Waarschuwing}";

			
		}

		public void BerekenBmi (string gewicht, string lengte)
		{
			bool SuccesGewicht;
			bool SuccesLengte;
			double InGewicht;
			double InLengte;
			SuccesLengte = double.TryParse(lengte, out InLengte);
			SuccesGewicht = double.TryParse(gewicht, out InGewicht); // manier om een string om te zetten naar een double ALLEEN als de inhoud in een double kan worden gestoken.
			if (SuccesGewicht == true && SuccesLengte == true) // Als beide Tryparse's zijn gelukt kan je onderstaande code uitvoeren
			{
				Gewicht = InGewicht;
				Lengte = InLengte;
				Calculatie(Gewicht, Lengte);
			}
			else //zoniet geef foutmelding
			{
				Feedback = "U heeft iets fout ingegeven";
			}
		}

	}
}

namespace AssemblyCSharp
{
	class GameWallet
	{
		// Variables
		public float Usd { get; set; }
		public float Btc { get; set; }
		
		// Constructors
		public GameWallet(float Usd)
		{
			this.Usd = Usd;
			Btc = 0;
		}
		public GameWallet(float Usd, float Btc)
		{
			this.Usd = Usd;
			this.Btc = Btc;
		}
		
		// Buy & Sell
		public void Buy(float Usd, float price)
		{
			if (this.Usd < Usd)
			{
				this.Btc += this.Usd /price;
				this.Usd = 0;
			}
			else
			{
				this.Btc += Usd / price;
				this.Usd -= Usd;
			}
		}
		public void Sell(float Btc, float price)
		{
			if (this.Btc < Btc)
			{
				this.Usd += this.Btc * price;
				this.Btc = 0;
			}
			else
			{
				this.Usd += Btc * price;
				this.Btc -= Btc;
			}
		}
	}
}
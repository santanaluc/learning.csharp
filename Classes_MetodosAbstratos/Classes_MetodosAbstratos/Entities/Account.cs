namespace Classes_MetodosAbstratos.Entities
{
    abstract class Account
    {
        public int Number { get; private set; }
        public string Holder { get; private set; }
        //modifica somente na sub-classe.
        public double Balance { get; protected set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            Balance -= amount + 5.0;
            //Pode ser sobrescrito nas sub-classe (virtual)
        }

        public virtual void Deposit(double amount)
        {
            Balance += amount;
        }
    }
}

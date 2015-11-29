

namespace Model
{
    public abstract class Gambler
    {
        public Gambler(string name)
        {
           Name=name;
        }
        public string Name { get; }
        public int Score { get; protected set; }
        public abstract void FetchNewNumber(object sender, ForEvent args); // абстрактный метод не имеет тела
    }
}

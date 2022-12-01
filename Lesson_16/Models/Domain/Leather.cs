namespace Lesson_16.Models.Domain
{
    public class Leather : Product
    {
        public Leather(string name, decimal price, int quantity) : base(name, price, quantity,TypeProducts.Leather) { }
    }
}

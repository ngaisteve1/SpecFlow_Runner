namespace SpecFlow_Service
{
    public class Calculator
    {
        public int Number1 { get; set; }
        public int Number2 { get; set; }
        public int Result { get; set; }

        public void Add() {
            Result = Number1 + Number2;
        }
    }
}

namespace DaysChallenge
{
    public class Person
    {
        public int age;

        //Criando o construtor abaixo: um método cujo nome é igual de seu tipo; sua assinatura do método inclui apenas o nome do método e a lista de parâmetro (não inclui nenhum tipo de retorno!);
        public Person(int initialAge)
        {
            if (initialAge < 0)
            {
                initialAge = 0;
                System.Console.WriteLine("Age is not valid, setting age to 0.");
            }
            else
            {
                age = initialAge;
            }
        }
        public void amIOld()
        {
            if (age < 13)
            {
                System.Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                System.Console.WriteLine("You are a teenager.");
            }
            else
            {
                System.Console.WriteLine("You are old.");
            }
        }
        public void yearPasses()
        {
            age += 1;
        }
    }
}
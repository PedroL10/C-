namespace ScreenSound1.Menus
{
    internal class Menu
    {
        public void ExibirTituloDaOpcao(string titulo)
        {


            int quantidadeDeLetras = titulo.Length;
            string astericos = string.Empty.PadLeft(quantidadeDeLetras, '*');
            Console.WriteLine(astericos);
            Console.WriteLine(titulo);
            Console.WriteLine(astericos + "\n");


        }
    }
}

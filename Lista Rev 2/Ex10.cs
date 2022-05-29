using System; 
public class Program {
  public static void Main(string[] args) {
    string texto = Console.ReadLine();
    string[] v = texto.Split('/');
    int dia = int.Parse(v[0]);
    int mes = int.Parse(v[1]);
    int ano = int.Parse(v[2]);
    string resp = "A data informada não é valida";
    if (mes <= 12 && mes >= 1 && ano >= 1900 && ano <= 2100) {
      switch (mes) {
        case 1:
        case 3:
        case 5:
        case 8:
        case 10:
        case 12:
          if (dia <= 31 && dia >= 1) resp = "A data informada é válida";
          break;
        case 2:
          if (dia <= 28 && dia >= 1) resp = "A data informada é válida";
          break;
        default:
          if (dia <= 30 && dia >= 1) resp = "A data informada é válida";
          break;
      }
    }
    Console.WriteLine(resp);
  }
}
namespace Kye.SistemasRegistros.Entities;

public static class Encriptar
{
    public static string EncriptarCadena(this string cadena)
    {
        string result = string.Empty;
        byte[] encrypted = System.Text.Encoding.Unicode.GetBytes(cadena);
        result = Convert.ToBase64String(encrypted);
        return result;
        
    }
}

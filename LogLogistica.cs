using System;
using System.IO;

class LogLogistica
{
    private string caminho;

    public LogLogistica(string caminho = @"C:\Users\vitor.fortunato\Desktop\TP-VITORFORTUNATO\bin\Debug\net10.0\log_logistica.txt")
    {
        this.caminho = caminho;
    }

    public void Registrar(string mensagem)
    {
        string dataHora = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

        string linha = $"{dataHora} | {mensagem}";

        File.AppendAllText(caminho, linha + Environment.NewLine);
    }
}
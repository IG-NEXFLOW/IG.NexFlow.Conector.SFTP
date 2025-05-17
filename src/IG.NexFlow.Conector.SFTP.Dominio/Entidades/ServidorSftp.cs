namespace IG.NexFlow.Conector.SFTP.Dominio.Entidades
{
    public class ServidorSftp
    {
        public long Id { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Host { get; set; } = string.Empty;
        public int Porta { get; set; }
        public string Usuario { get; set; } = string.Empty;
        public string Senha { get; set; } = string.Empty;
        public string SenhaSalt { get; set; } = string.Empty;
    }
}
